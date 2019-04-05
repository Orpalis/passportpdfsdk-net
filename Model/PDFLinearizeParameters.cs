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
    /// Represents the parameters for a linearize action.
    /// </summary>
    [DataContract]
    public partial class PDFLinearizeParameters :  IEquatable<PDFLinearizeParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFLinearizeParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFLinearizeParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFLinearizeParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="packDocument">Specifies whether the document shall be packed, in order to reduce its size..</param>
        public PDFLinearizeParameters(string fileId = default(string), bool? packDocument = default(bool?))
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for PDFLinearizeParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            this.PackDocument = packDocument;
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies whether the document shall be packed, in order to reduce its size.
        /// </summary>
        /// <value>Specifies whether the document shall be packed, in order to reduce its size.</value>
        [DataMember(Name="PackDocument", EmitDefaultValue=false)]
        public bool? PackDocument { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFLinearizeParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PackDocument: ").Append(PackDocument).Append("\n");
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
            return this.Equals(input as PDFLinearizeParameters);
        }

        /// <summary>
        /// Returns true if PDFLinearizeParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFLinearizeParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFLinearizeParameters input)
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
                    this.PackDocument == input.PackDocument ||
                    (this.PackDocument != null &&
                    this.PackDocument.Equals(input.PackDocument))
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
                if (this.PackDocument != null)
                    hashCode = hashCode * 59 + this.PackDocument.GetHashCode();
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
