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
    /// Represents the parameters for a detect page orientation action.
    /// </summary>
    [DataContract]
    public partial class PDFDetectPageOrientationParameters :  IEquatable<PDFDetectPageOrientationParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFDetectPageOrientationParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFDetectPageOrientationParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFDetectPageOrientationParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages to be processed. (required).</param>
        /// <param name="language">Specifies the language to be used for the detection. (default to &quot;eng&quot;).</param>
        /// <param name="automaticallyApplyRotation">Specifies whether a rotation shall be automatically applied in order to correct the page orientation when needed. (default to true).</param>
        public PDFDetectPageOrientationParameters(string fileId = default(string), string pageRange = default(string), string language = "eng", bool? automaticallyApplyRotation = true)
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for PDFDetectPageOrientationParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            
            // to ensure "pageRange" is required (not null)
            if (pageRange == null)
            {
                throw new InvalidDataException("pageRange is a required property for PDFDetectPageOrientationParameters and cannot be null");
            }
            else
            {
                this.PageRange = pageRange;
            }
            
            // use default value if no "language" provided
            if (language == null)
            {
                this.Language = "eng";
            }
            else
            {
                this.Language = language;
            }
            // use default value if no "automaticallyApplyRotation" provided
            if (automaticallyApplyRotation == null)
            {
                this.AutomaticallyApplyRotation = true;
            }
            else
            {
                this.AutomaticallyApplyRotation = automaticallyApplyRotation;
            }
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to be processed.
        /// </summary>
        /// <value>Specifies the number of the page, or the range of pages to be processed.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies the language to be used for the detection.
        /// </summary>
        /// <value>Specifies the language to be used for the detection.</value>
        [DataMember(Name="Language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// Specifies whether a rotation shall be automatically applied in order to correct the page orientation when needed.
        /// </summary>
        /// <value>Specifies whether a rotation shall be automatically applied in order to correct the page orientation when needed.</value>
        [DataMember(Name="AutomaticallyApplyRotation", EmitDefaultValue=false)]
        public bool? AutomaticallyApplyRotation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFDetectPageOrientationParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  AutomaticallyApplyRotation: ").Append(AutomaticallyApplyRotation).Append("\n");
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
            return this.Equals(input as PDFDetectPageOrientationParameters);
        }

        /// <summary>
        /// Returns true if PDFDetectPageOrientationParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFDetectPageOrientationParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFDetectPageOrientationParameters input)
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
                    this.PageRange == input.PageRange ||
                    (this.PageRange != null &&
                    this.PageRange.Equals(input.PageRange))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.AutomaticallyApplyRotation == input.AutomaticallyApplyRotation ||
                    (this.AutomaticallyApplyRotation != null &&
                    this.AutomaticallyApplyRotation.Equals(input.AutomaticallyApplyRotation))
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
                if (this.PageRange != null)
                    hashCode = hashCode * 59 + this.PageRange.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.AutomaticallyApplyRotation != null)
                    hashCode = hashCode * 59 + this.AutomaticallyApplyRotation.GetHashCode();
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
