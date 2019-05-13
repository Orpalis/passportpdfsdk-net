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
    /// Represents the parameters for an OCR action.
    /// </summary>
    [DataContract]
    public partial class PDFOCRParameters :  IEquatable<PDFOCRParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFOCRParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFOCRParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFOCRParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the page or the page range to be processed. (required).</param>
        /// <param name="language">Specifies the language to be used for the OCR. (default to &quot;eng&quot;).</param>
        /// <param name="skipPageWithText">Specifies if pages containing text must be ignored (in such case no token is charged). (default to true).</param>
        public PDFOCRParameters(string fileId = default(string), string pageRange = default(string), string language = "eng", bool? skipPageWithText = true)
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for PDFOCRParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            
            // to ensure "pageRange" is required (not null)
            if (pageRange == null)
            {
                throw new InvalidDataException("pageRange is a required property for PDFOCRParameters and cannot be null");
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
            // use default value if no "skipPageWithText" provided
            if (skipPageWithText == null)
            {
                this.SkipPageWithText = true;
            }
            else
            {
                this.SkipPageWithText = skipPageWithText;
            }
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the page or the page range to be processed.
        /// </summary>
        /// <value>Specifies the page or the page range to be processed.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies the language to be used for the OCR.
        /// </summary>
        /// <value>Specifies the language to be used for the OCR.</value>
        [DataMember(Name="Language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// Specifies if pages containing text must be ignored (in such case no token is charged).
        /// </summary>
        /// <value>Specifies if pages containing text must be ignored (in such case no token is charged).</value>
        [DataMember(Name="SkipPageWithText", EmitDefaultValue=false)]
        public bool? SkipPageWithText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFOCRParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  SkipPageWithText: ").Append(SkipPageWithText).Append("\n");
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
            return this.Equals(input as PDFOCRParameters);
        }

        /// <summary>
        /// Returns true if PDFOCRParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFOCRParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFOCRParameters input)
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
                    this.SkipPageWithText == input.SkipPageWithText ||
                    (this.SkipPageWithText != null &&
                    this.SkipPageWithText.Equals(input.SkipPageWithText))
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
                if (this.SkipPageWithText != null)
                    hashCode = hashCode * 59 + this.SkipPageWithText.GetHashCode();
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
