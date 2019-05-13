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
    /// Represents the parameters for a swap pages action.
    /// </summary>
    [DataContract]
    public partial class PDFSwapPagesParameters :  IEquatable<PDFSwapPagesParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFSwapPagesParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFSwapPagesParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFSwapPagesParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="page1">Specifies the number of the first page. (required).</param>
        /// <param name="page2">Specifies the number of the second page. (required).</param>
        public PDFSwapPagesParameters(string fileId = default(string), int? page1 = default(int?), int? page2 = default(int?))
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for PDFSwapPagesParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            
            // to ensure "page1" is required (not null)
            if (page1 == null)
            {
                throw new InvalidDataException("page1 is a required property for PDFSwapPagesParameters and cannot be null");
            }
            else
            {
                this.Page1 = page1;
            }
            
            // to ensure "page2" is required (not null)
            if (page2 == null)
            {
                throw new InvalidDataException("page2 is a required property for PDFSwapPagesParameters and cannot be null");
            }
            else
            {
                this.Page2 = page2;
            }
            
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the first page.
        /// </summary>
        /// <value>Specifies the number of the first page.</value>
        [DataMember(Name="Page1", EmitDefaultValue=false)]
        public int? Page1 { get; set; }

        /// <summary>
        /// Specifies the number of the second page.
        /// </summary>
        /// <value>Specifies the number of the second page.</value>
        [DataMember(Name="Page2", EmitDefaultValue=false)]
        public int? Page2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFSwapPagesParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  Page1: ").Append(Page1).Append("\n");
            sb.Append("  Page2: ").Append(Page2).Append("\n");
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
            return this.Equals(input as PDFSwapPagesParameters);
        }

        /// <summary>
        /// Returns true if PDFSwapPagesParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFSwapPagesParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFSwapPagesParameters input)
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
                    this.Page1 == input.Page1 ||
                    (this.Page1 != null &&
                    this.Page1.Equals(input.Page1))
                ) && 
                (
                    this.Page2 == input.Page2 ||
                    (this.Page2 != null &&
                    this.Page2.Equals(input.Page2))
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
                if (this.Page1 != null)
                    hashCode = hashCode * 59 + this.Page1.GetHashCode();
                if (this.Page2 != null)
                    hashCode = hashCode * 59 + this.Page2.GetHashCode();
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
