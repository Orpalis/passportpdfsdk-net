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
    /// Represents the parameters for an auto deskew action.
    /// </summary>
    [DataContract]
    public partial class PDFAutoDeskewParameters :  IEquatable<PDFAutoDeskewParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFAutoDeskewParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFAutoDeskewParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFAutoDeskewParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the page or the page range to be auto-deskewed. (required).</param>
        /// <param name="maxAngleOfResearch">Specifies the maximum skew angle to be detected. A value of below 15 is suggested. (default to 15.0F).</param>
        /// <param name="optimistic">Specifies whether the skew detection engine must be optimistic when detecting angles.  If you know the image is skewed, you should set this to true..</param>
        public PDFAutoDeskewParameters(string fileId = default(string), string pageRange = default(string), float? maxAngleOfResearch = 15.0F, bool? optimistic = default(bool?))
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for PDFAutoDeskewParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            // to ensure "pageRange" is required (not null)
            if (pageRange == null)
            {
                throw new InvalidDataException("pageRange is a required property for PDFAutoDeskewParameters and cannot be null");
            }
            else
            {
                this.PageRange = pageRange;
            }
            // use default value if no "maxAngleOfResearch" provided
            if (maxAngleOfResearch == null)
            {
                this.MaxAngleOfResearch = 15.0F;
            }
            else
            {
                this.MaxAngleOfResearch = maxAngleOfResearch;
            }
            this.Optimistic = optimistic;
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the page or the page range to be auto-deskewed.
        /// </summary>
        /// <value>Specifies the page or the page range to be auto-deskewed.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies the maximum skew angle to be detected. A value of below 15 is suggested.
        /// </summary>
        /// <value>Specifies the maximum skew angle to be detected. A value of below 15 is suggested.</value>
        [DataMember(Name="MaxAngleOfResearch", EmitDefaultValue=false)]
        public float? MaxAngleOfResearch { get; set; }

        /// <summary>
        /// Specifies whether the skew detection engine must be optimistic when detecting angles.  If you know the image is skewed, you should set this to true.
        /// </summary>
        /// <value>Specifies whether the skew detection engine must be optimistic when detecting angles.  If you know the image is skewed, you should set this to true.</value>
        [DataMember(Name="Optimistic", EmitDefaultValue=false)]
        public bool? Optimistic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFAutoDeskewParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  MaxAngleOfResearch: ").Append(MaxAngleOfResearch).Append("\n");
            sb.Append("  Optimistic: ").Append(Optimistic).Append("\n");
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
            return this.Equals(input as PDFAutoDeskewParameters);
        }

        /// <summary>
        /// Returns true if PDFAutoDeskewParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFAutoDeskewParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFAutoDeskewParameters input)
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
                    this.MaxAngleOfResearch == input.MaxAngleOfResearch ||
                    (this.MaxAngleOfResearch != null &&
                    this.MaxAngleOfResearch.Equals(input.MaxAngleOfResearch))
                ) && 
                (
                    this.Optimistic == input.Optimistic ||
                    (this.Optimistic != null &&
                    this.Optimistic.Equals(input.Optimistic))
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
                if (this.MaxAngleOfResearch != null)
                    hashCode = hashCode * 59 + this.MaxAngleOfResearch.GetHashCode();
                if (this.Optimistic != null)
                    hashCode = hashCode * 59 + this.Optimistic.GetHashCode();
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
