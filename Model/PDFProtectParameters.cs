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


namespace PassportPDF.Model
{
    /// <summary>
    /// Represents the parameters for a protect action.
    /// </summary>
    [DataContract]
    public partial class PdfProtectParameters :  IEquatable<PdfProtectParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfProtectParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfProtectParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfProtectParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        public PdfProtectParameters(string fileId)
        {
            FileId = fileId;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the owner password to be set.
        /// </summary>
        [DataMember(Name="OwnerPassword")]
        public string OwnerPassword { get; set; } = "";

        /// <summary>
        /// Specifies the user password to be set.
        /// </summary>
        [DataMember(Name="UserPassword")]
        public string UserPassword { get; set; } = "";

        /// <summary>
        /// Gets or Sets Encryption
        /// </summary>
        [DataMember(Name="Encryption")]
        public EncryptionAlgorithm Encryption { get; set; }

        /// <summary>
        /// Allows the user to print the document, but possibly not at the highest quality level. Ignored if no encryption algorithm is set.
        /// </summary>
        [DataMember(Name="CanPrint")]
        public bool CanPrint { get; set; } = true;

        /// <summary>
        /// Allows the user to copy or extract text and graphics from the document. Ignored if the no encryption scheme is set.
        /// </summary>
        [DataMember(Name="CanCopy")]
        public bool CanCopy { get; set; } = true;

        /// <summary>
        /// Allows the user to modify the document. Ignored if the no encryption scheme is set.
        /// </summary>
        [DataMember(Name="CanModify")]
        public bool CanModify { get; set; } = true;

        /// <summary>
        /// Allows the user to add annotations. Ignored if the no encryption scheme is set.
        /// </summary>
        [DataMember(Name="CanAddNotes")]
        public bool CanAddNotes { get; set; } = true;

        /// <summary>
        /// Allows the user to fill-in form fields. Only works with 128-bit encryption.
        /// </summary>
        [DataMember(Name="CanFillFields")]
        public bool CanFillFields { get; set; } = true;

        /// <summary>
        /// Enables copying or extracting for use with accessibility features. Only works with 128-bit encryption.
        /// </summary>
        [DataMember(Name="CanCopyAccess")]
        public bool CanCopyAccess { get; set; } = true;

        /// <summary>
        /// Allows the user to assemble the document. Only works with 128-bit encryption.
        /// </summary>
        [DataMember(Name="CanAssemble")]
        public bool CanAssemble { get; set; } = true;

        /// <summary>
        /// Allows high resolution printing of the document. Only works with 128-bit encryption.
        /// </summary>
        [DataMember(Name="CanPrintFull")]
        public bool CanPrintFull { get; set; } = true;

        /// <summary>
        /// Returns the String presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
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
            return Equals(input as PdfProtectParameters);
        }

        /// <summary>
        /// Returns true if PdfProtectParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfProtectParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfProtectParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    FileId == input.FileId ||
                    (FileId != null &&
                    FileId.Equals(input.FileId))
                ) && 
                (
                    OwnerPassword == input.OwnerPassword ||
                    (OwnerPassword != null &&
                    OwnerPassword.Equals(input.OwnerPassword))
                ) && 
                (
                    UserPassword == input.UserPassword ||
                    (UserPassword != null &&
                    UserPassword.Equals(input.UserPassword))
                ) && 
                (
                    Encryption == input.Encryption ||
                    Encryption.Equals(input.Encryption)
                ) && 
                (
                    CanPrint == input.CanPrint ||
                    CanPrint.Equals(input.CanPrint)
                ) && 
                (
                    CanCopy == input.CanCopy ||
                    CanCopy.Equals(input.CanCopy)
                ) && 
                (
                    CanModify == input.CanModify ||
                    CanModify.Equals(input.CanModify)
                ) && 
                (
                    CanAddNotes == input.CanAddNotes ||
                    CanAddNotes.Equals(input.CanAddNotes)
                ) && 
                (
                    CanFillFields == input.CanFillFields ||
                    CanFillFields.Equals(input.CanFillFields)
                ) && 
                (
                    CanCopyAccess == input.CanCopyAccess ||
                    CanCopyAccess.Equals(input.CanCopyAccess)
                ) && 
                (
                    CanAssemble == input.CanAssemble ||
                    CanAssemble.Equals(input.CanAssemble)
                ) && 
                (
                    CanPrintFull == input.CanPrintFull ||
                    CanPrintFull.Equals(input.CanPrintFull)
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
                if (FileId != null)
                    hashCode = hashCode * 59 + FileId.GetHashCode();
                if (OwnerPassword != null)
                    hashCode = hashCode * 59 + OwnerPassword.GetHashCode();
                if (UserPassword != null)
                    hashCode = hashCode * 59 + UserPassword.GetHashCode();
                hashCode = hashCode * 59 + Encryption.GetHashCode();
                hashCode = hashCode * 59 + CanPrint.GetHashCode();
                hashCode = hashCode * 59 + CanCopy.GetHashCode();
                hashCode = hashCode * 59 + CanModify.GetHashCode();
                hashCode = hashCode * 59 + CanAddNotes.GetHashCode();
                hashCode = hashCode * 59 + CanFillFields.GetHashCode();
                hashCode = hashCode * 59 + CanCopyAccess.GetHashCode();
                hashCode = hashCode * 59 + CanAssemble.GetHashCode();
                hashCode = hashCode * 59 + CanPrintFull.GetHashCode();
                return hashCode;
            }
        }
    }

}
