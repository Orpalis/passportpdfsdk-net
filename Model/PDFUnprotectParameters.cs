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
    /// Represents the parameters for an unprotect action.
    /// </summary>
    [DataContract]
    public partial class PDFUnprotectParameters :  IEquatable<PDFUnprotectParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFUnprotectParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFUnprotectParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFUnprotectParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="password">Specifies the password to be used to unprotect the PDF. (required).</param>
        public PDFUnprotectParameters(string fileId = default(string), string password = default(string))
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for PDFUnprotectParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new InvalidDataException("password is a required property for PDFUnprotectParameters and cannot be null");
            }
            else
            {
                this.Password = password;
            }
            
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the password to be used to unprotect the PDF.
        /// </summary>
        /// <value>Specifies the password to be used to unprotect the PDF.</value>
        [DataMember(Name="Password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFUnprotectParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return this.Equals(input as PDFUnprotectParameters);
        }

        /// <summary>
        /// Returns true if PDFUnprotectParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFUnprotectParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFUnprotectParameters input)
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
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
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
