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
    /// Represents the parameters for an insert text action.
    /// </summary>
    [DataContract]
    public partial class PDFInsertTextParameters :  IEquatable<PDFInsertTextParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFInsertTextParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFInsertTextParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFInsertTextParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages on which the text shall be inserted. (required).</param>
        /// <param name="textParameters">textParameters (required).</param>
        /// <param name="textBoundingBoxLayout">textBoundingBoxLayout.</param>
        public PDFInsertTextParameters(string fileId = default(string), string pageRange = default(string), PDFAlignedTextParameters textParameters = default(PDFAlignedTextParameters), DrawableContentLayoutParameters textBoundingBoxLayout = default(DrawableContentLayoutParameters))
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for PDFInsertTextParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            // to ensure "pageRange" is required (not null)
            if (pageRange == null)
            {
                throw new InvalidDataException("pageRange is a required property for PDFInsertTextParameters and cannot be null");
            }
            else
            {
                this.PageRange = pageRange;
            }
            // to ensure "textParameters" is required (not null)
            if (textParameters == null)
            {
                throw new InvalidDataException("textParameters is a required property for PDFInsertTextParameters and cannot be null");
            }
            else
            {
                this.TextParameters = textParameters;
            }
            this.TextBoundingBoxLayout = textBoundingBoxLayout;
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages on which the text shall be inserted.
        /// </summary>
        /// <value>Specifies the number of the page, or the range of pages on which the text shall be inserted.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }

        /// <summary>
        /// Gets or Sets TextParameters
        /// </summary>
        [DataMember(Name="TextParameters", EmitDefaultValue=false)]
        public PDFAlignedTextParameters TextParameters { get; set; }

        /// <summary>
        /// Gets or Sets TextBoundingBoxLayout
        /// </summary>
        [DataMember(Name="TextBoundingBoxLayout", EmitDefaultValue=false)]
        public DrawableContentLayoutParameters TextBoundingBoxLayout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFInsertTextParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  TextParameters: ").Append(TextParameters).Append("\n");
            sb.Append("  TextBoundingBoxLayout: ").Append(TextBoundingBoxLayout).Append("\n");
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
            return this.Equals(input as PDFInsertTextParameters);
        }

        /// <summary>
        /// Returns true if PDFInsertTextParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFInsertTextParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFInsertTextParameters input)
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
                    this.TextParameters == input.TextParameters ||
                    (this.TextParameters != null &&
                    this.TextParameters.Equals(input.TextParameters))
                ) && 
                (
                    this.TextBoundingBoxLayout == input.TextBoundingBoxLayout ||
                    (this.TextBoundingBoxLayout != null &&
                    this.TextBoundingBoxLayout.Equals(input.TextBoundingBoxLayout))
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
                if (this.TextParameters != null)
                    hashCode = hashCode * 59 + this.TextParameters.GetHashCode();
                if (this.TextBoundingBoxLayout != null)
                    hashCode = hashCode * 59 + this.TextBoundingBoxLayout.GetHashCode();
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
