/* 
 * PassportPDF API
 *
 * Copyright © 2019 PassportPDF - https://www.passportpdf.com
 *
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = PassportPDF.Client.OpenAPIDateConverter;

namespace PassportPDF.Model
{
    /// <summary>
    /// Represents the parameters for a protect action.
    /// </summary>
    [DataContract]
    public partial class PDFProtectParameters :  IEquatable<PDFProtectParameters>, IValidatableObject
    {
        /// <summary>
        /// Specifies the encryption scheme to be used.
        /// </summary>
        /// <value>Specifies the encryption scheme to be used.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EncryptionEnum
        {
            /// <summary>
            /// Enum PdfEncryptionNone for value: PdfEncryptionNone
            /// </summary>
            [EnumMember(Value = "PdfEncryptionNone")]
            PdfEncryptionNone = 1,

            /// <summary>
            /// Enum PdfEncryption40BitRC4 for value: PdfEncryption40BitRC4
            /// </summary>
            [EnumMember(Value = "PdfEncryption40BitRC4")]
            PdfEncryption40BitRC4 = 2,

            /// <summary>
            /// Enum PdfEncryption128BitRC4 for value: PdfEncryption128BitRC4
            /// </summary>
            [EnumMember(Value = "PdfEncryption128BitRC4")]
            PdfEncryption128BitRC4 = 3,

            /// <summary>
            /// Enum PdfEncryption128BitAES for value: PdfEncryption128BitAES
            /// </summary>
            [EnumMember(Value = "PdfEncryption128BitAES")]
            PdfEncryption128BitAES = 4,

            /// <summary>
            /// Enum PdfEncryption256BitAES for value: PdfEncryption256BitAES
            /// </summary>
            [EnumMember(Value = "PdfEncryption256BitAES")]
            PdfEncryption256BitAES = 5

        }

        /// <summary>
        /// Specifies the encryption scheme to be used.
        /// </summary>
        /// <value>Specifies the encryption scheme to be used.</value>
        [DataMember(Name="Encryption", EmitDefaultValue=false)]
        public EncryptionEnum? Encryption { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFProtectParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFProtectParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFProtectParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="ownerPassword">Specifies the owner password to be set..</param>
        /// <param name="userPassword">Specifies the user password to be set..</param>
        /// <param name="encryption">Specifies the encryption scheme to be used. (default to EncryptionEnum.PdfEncryption256BitAES).</param>
        /// <param name="canPrint">Allows the user to print the document, but possibly not at the highest quality level. Ignored if no encryption algorithm is set. (default to true).</param>
        /// <param name="canCopy">Allows the user to copy or extract text and graphics from the document. Ignored if the no encryption scheme is set. (default to true).</param>
        /// <param name="canModify">Allows the user to modify the document. Ignored if the no encryption scheme is set. (default to true).</param>
        /// <param name="canAddNotes">Allows the user to add annotations. Ignored if the no encryption scheme is set. (default to true).</param>
        /// <param name="canFillFields">Allows the user to fill-in form fields. Only works with 128-bit encryption. (default to true).</param>
        /// <param name="canCopyAccess">Enables copying or extracting for use with accessibility features. Only works with 128-bit encryption. (default to true).</param>
        /// <param name="canAssemble">Allows the user to assemble the document. Only works with 128-bit encryption. (default to true).</param>
        /// <param name="canPrintFull">Allows high resolution printing of the document. Only works with 128-bit encryption. (default to true).</param>
        public PDFProtectParameters(string fileId = default(string), string ownerPassword = default(string), string userPassword = default(string), EncryptionEnum? encryption = EncryptionEnum.PdfEncryption256BitAES, bool? canPrint = true, bool? canCopy = true, bool? canModify = true, bool? canAddNotes = true, bool? canFillFields = true, bool? canCopyAccess = true, bool? canAssemble = true, bool? canPrintFull = true)
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for PDFProtectParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            this.OwnerPassword = ownerPassword;
            this.UserPassword = userPassword;
            // use default value if no "encryption" provided
            if (encryption == null)
            {
                this.Encryption = EncryptionEnum.PdfEncryption256BitAES;
            }
            else
            {
                this.Encryption = encryption;
            }
            // use default value if no "canPrint" provided
            if (canPrint == null)
            {
                this.CanPrint = true;
            }
            else
            {
                this.CanPrint = canPrint;
            }
            // use default value if no "canCopy" provided
            if (canCopy == null)
            {
                this.CanCopy = true;
            }
            else
            {
                this.CanCopy = canCopy;
            }
            // use default value if no "canModify" provided
            if (canModify == null)
            {
                this.CanModify = true;
            }
            else
            {
                this.CanModify = canModify;
            }
            // use default value if no "canAddNotes" provided
            if (canAddNotes == null)
            {
                this.CanAddNotes = true;
            }
            else
            {
                this.CanAddNotes = canAddNotes;
            }
            // use default value if no "canFillFields" provided
            if (canFillFields == null)
            {
                this.CanFillFields = true;
            }
            else
            {
                this.CanFillFields = canFillFields;
            }
            // use default value if no "canCopyAccess" provided
            if (canCopyAccess == null)
            {
                this.CanCopyAccess = true;
            }
            else
            {
                this.CanCopyAccess = canCopyAccess;
            }
            // use default value if no "canAssemble" provided
            if (canAssemble == null)
            {
                this.CanAssemble = true;
            }
            else
            {
                this.CanAssemble = canAssemble;
            }
            // use default value if no "canPrintFull" provided
            if (canPrintFull == null)
            {
                this.CanPrintFull = true;
            }
            else
            {
                this.CanPrintFull = canPrintFull;
            }
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the owner password to be set.
        /// </summary>
        /// <value>Specifies the owner password to be set.</value>
        [DataMember(Name="OwnerPassword", EmitDefaultValue=false)]
        public string OwnerPassword { get; set; }

        /// <summary>
        /// Specifies the user password to be set.
        /// </summary>
        /// <value>Specifies the user password to be set.</value>
        [DataMember(Name="UserPassword", EmitDefaultValue=false)]
        public string UserPassword { get; set; }


        /// <summary>
        /// Allows the user to print the document, but possibly not at the highest quality level. Ignored if no encryption algorithm is set.
        /// </summary>
        /// <value>Allows the user to print the document, but possibly not at the highest quality level. Ignored if no encryption algorithm is set.</value>
        [DataMember(Name="CanPrint", EmitDefaultValue=false)]
        public bool? CanPrint { get; set; }

        /// <summary>
        /// Allows the user to copy or extract text and graphics from the document. Ignored if the no encryption scheme is set.
        /// </summary>
        /// <value>Allows the user to copy or extract text and graphics from the document. Ignored if the no encryption scheme is set.</value>
        [DataMember(Name="CanCopy", EmitDefaultValue=false)]
        public bool? CanCopy { get; set; }

        /// <summary>
        /// Allows the user to modify the document. Ignored if the no encryption scheme is set.
        /// </summary>
        /// <value>Allows the user to modify the document. Ignored if the no encryption scheme is set.</value>
        [DataMember(Name="CanModify", EmitDefaultValue=false)]
        public bool? CanModify { get; set; }

        /// <summary>
        /// Allows the user to add annotations. Ignored if the no encryption scheme is set.
        /// </summary>
        /// <value>Allows the user to add annotations. Ignored if the no encryption scheme is set.</value>
        [DataMember(Name="CanAddNotes", EmitDefaultValue=false)]
        public bool? CanAddNotes { get; set; }

        /// <summary>
        /// Allows the user to fill-in form fields. Only works with 128-bit encryption.
        /// </summary>
        /// <value>Allows the user to fill-in form fields. Only works with 128-bit encryption.</value>
        [DataMember(Name="CanFillFields", EmitDefaultValue=false)]
        public bool? CanFillFields { get; set; }

        /// <summary>
        /// Enables copying or extracting for use with accessibility features. Only works with 128-bit encryption.
        /// </summary>
        /// <value>Enables copying or extracting for use with accessibility features. Only works with 128-bit encryption.</value>
        [DataMember(Name="CanCopyAccess", EmitDefaultValue=false)]
        public bool? CanCopyAccess { get; set; }

        /// <summary>
        /// Allows the user to assemble the document. Only works with 128-bit encryption.
        /// </summary>
        /// <value>Allows the user to assemble the document. Only works with 128-bit encryption.</value>
        [DataMember(Name="CanAssemble", EmitDefaultValue=false)]
        public bool? CanAssemble { get; set; }

        /// <summary>
        /// Allows high resolution printing of the document. Only works with 128-bit encryption.
        /// </summary>
        /// <value>Allows high resolution printing of the document. Only works with 128-bit encryption.</value>
        [DataMember(Name="CanPrintFull", EmitDefaultValue=false)]
        public bool? CanPrintFull { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFProtectParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  OwnerPassword: ").Append(OwnerPassword).Append("\n");
            sb.Append("  UserPassword: ").Append(UserPassword).Append("\n");
            sb.Append("  Encryption: ").Append(Encryption).Append("\n");
            sb.Append("  CanPrint: ").Append(CanPrint).Append("\n");
            sb.Append("  CanCopy: ").Append(CanCopy).Append("\n");
            sb.Append("  CanModify: ").Append(CanModify).Append("\n");
            sb.Append("  CanAddNotes: ").Append(CanAddNotes).Append("\n");
            sb.Append("  CanFillFields: ").Append(CanFillFields).Append("\n");
            sb.Append("  CanCopyAccess: ").Append(CanCopyAccess).Append("\n");
            sb.Append("  CanAssemble: ").Append(CanAssemble).Append("\n");
            sb.Append("  CanPrintFull: ").Append(CanPrintFull).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PDFProtectParameters);
        }

        /// <summary>
        /// Returns true if PDFProtectParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFProtectParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFProtectParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileId == input.FileId ||
                    (this.FileId != null &&
                    this.FileId.Equals(input.FileId))
                ) && 
                (
                    this.OwnerPassword == input.OwnerPassword ||
                    (this.OwnerPassword != null &&
                    this.OwnerPassword.Equals(input.OwnerPassword))
                ) && 
                (
                    this.UserPassword == input.UserPassword ||
                    (this.UserPassword != null &&
                    this.UserPassword.Equals(input.UserPassword))
                ) && 
                (
                    this.Encryption == input.Encryption ||
                    (this.Encryption != null &&
                    this.Encryption.Equals(input.Encryption))
                ) && 
                (
                    this.CanPrint == input.CanPrint ||
                    (this.CanPrint != null &&
                    this.CanPrint.Equals(input.CanPrint))
                ) && 
                (
                    this.CanCopy == input.CanCopy ||
                    (this.CanCopy != null &&
                    this.CanCopy.Equals(input.CanCopy))
                ) && 
                (
                    this.CanModify == input.CanModify ||
                    (this.CanModify != null &&
                    this.CanModify.Equals(input.CanModify))
                ) && 
                (
                    this.CanAddNotes == input.CanAddNotes ||
                    (this.CanAddNotes != null &&
                    this.CanAddNotes.Equals(input.CanAddNotes))
                ) && 
                (
                    this.CanFillFields == input.CanFillFields ||
                    (this.CanFillFields != null &&
                    this.CanFillFields.Equals(input.CanFillFields))
                ) && 
                (
                    this.CanCopyAccess == input.CanCopyAccess ||
                    (this.CanCopyAccess != null &&
                    this.CanCopyAccess.Equals(input.CanCopyAccess))
                ) && 
                (
                    this.CanAssemble == input.CanAssemble ||
                    (this.CanAssemble != null &&
                    this.CanAssemble.Equals(input.CanAssemble))
                ) && 
                (
                    this.CanPrintFull == input.CanPrintFull ||
                    (this.CanPrintFull != null &&
                    this.CanPrintFull.Equals(input.CanPrintFull))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.FileId != null)
                    hashCode = hashCode * 59 + this.FileId.GetHashCode();
                if (this.OwnerPassword != null)
                    hashCode = hashCode * 59 + this.OwnerPassword.GetHashCode();
                if (this.UserPassword != null)
                    hashCode = hashCode * 59 + this.UserPassword.GetHashCode();
                if (this.Encryption != null)
                    hashCode = hashCode * 59 + this.Encryption.GetHashCode();
                if (this.CanPrint != null)
                    hashCode = hashCode * 59 + this.CanPrint.GetHashCode();
                if (this.CanCopy != null)
                    hashCode = hashCode * 59 + this.CanCopy.GetHashCode();
                if (this.CanModify != null)
                    hashCode = hashCode * 59 + this.CanModify.GetHashCode();
                if (this.CanAddNotes != null)
                    hashCode = hashCode * 59 + this.CanAddNotes.GetHashCode();
                if (this.CanFillFields != null)
                    hashCode = hashCode * 59 + this.CanFillFields.GetHashCode();
                if (this.CanCopyAccess != null)
                    hashCode = hashCode * 59 + this.CanCopyAccess.GetHashCode();
                if (this.CanAssemble != null)
                    hashCode = hashCode * 59 + this.CanAssemble.GetHashCode();
                if (this.CanPrintFull != null)
                    hashCode = hashCode * 59 + this.CanPrintFull.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
