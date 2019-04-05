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
    /// Represents the parameters for a rotate page standard action.
    /// </summary>
    [DataContract]
    public partial class PDFRotatePageStandardParameters :  IEquatable<PDFRotatePageStandardParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFRotatePageStandardParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFRotatePageStandardParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFRotatePageStandardParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages to be rotated. (required).</param>
        /// <param name="rotationAngle">Specifies the rotation angle, clockwise in degrees, which can be either positive and negative and any multiple of 90. (required).</param>
        /// <param name="flipHorizontally">Specifies whether the page(s) shall be flipped horizontally..</param>
        /// <param name="flipVertically">Specifies whether the page(s) shall be flipped vertically..</param>
        public PDFRotatePageStandardParameters(string fileId = default(string), string pageRange = default(string), int? rotationAngle = default(int?), bool? flipHorizontally = default(bool?), bool? flipVertically = default(bool?))
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for PDFRotatePageStandardParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            // to ensure "pageRange" is required (not null)
            if (pageRange == null)
            {
                throw new InvalidDataException("pageRange is a required property for PDFRotatePageStandardParameters and cannot be null");
            }
            else
            {
                this.PageRange = pageRange;
            }
            // to ensure "rotationAngle" is required (not null)
            if (rotationAngle == null)
            {
                throw new InvalidDataException("rotationAngle is a required property for PDFRotatePageStandardParameters and cannot be null");
            }
            else
            {
                this.RotationAngle = rotationAngle;
            }
            this.FlipHorizontally = flipHorizontally;
            this.FlipVertically = flipVertically;
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to be rotated.
        /// </summary>
        /// <value>Specifies the number of the page, or the range of pages to be rotated.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies the rotation angle, clockwise in degrees, which can be either positive and negative and any multiple of 90.
        /// </summary>
        /// <value>Specifies the rotation angle, clockwise in degrees, which can be either positive and negative and any multiple of 90.</value>
        [DataMember(Name="RotationAngle", EmitDefaultValue=false)]
        public int? RotationAngle { get; set; }

        /// <summary>
        /// Specifies whether the page(s) shall be flipped horizontally.
        /// </summary>
        /// <value>Specifies whether the page(s) shall be flipped horizontally.</value>
        [DataMember(Name="FlipHorizontally", EmitDefaultValue=false)]
        public bool? FlipHorizontally { get; set; }

        /// <summary>
        /// Specifies whether the page(s) shall be flipped vertically.
        /// </summary>
        /// <value>Specifies whether the page(s) shall be flipped vertically.</value>
        [DataMember(Name="FlipVertically", EmitDefaultValue=false)]
        public bool? FlipVertically { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFRotatePageStandardParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  RotationAngle: ").Append(RotationAngle).Append("\n");
            sb.Append("  FlipHorizontally: ").Append(FlipHorizontally).Append("\n");
            sb.Append("  FlipVertically: ").Append(FlipVertically).Append("\n");
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
            return this.Equals(input as PDFRotatePageStandardParameters);
        }

        /// <summary>
        /// Returns true if PDFRotatePageStandardParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFRotatePageStandardParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFRotatePageStandardParameters input)
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
                    this.RotationAngle == input.RotationAngle ||
                    (this.RotationAngle != null &&
                    this.RotationAngle.Equals(input.RotationAngle))
                ) && 
                (
                    this.FlipHorizontally == input.FlipHorizontally ||
                    (this.FlipHorizontally != null &&
                    this.FlipHorizontally.Equals(input.FlipHorizontally))
                ) && 
                (
                    this.FlipVertically == input.FlipVertically ||
                    (this.FlipVertically != null &&
                    this.FlipVertically.Equals(input.FlipVertically))
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
                if (this.RotationAngle != null)
                    hashCode = hashCode * 59 + this.RotationAngle.GetHashCode();
                if (this.FlipHorizontally != null)
                    hashCode = hashCode * 59 + this.FlipHorizontally.GetHashCode();
                if (this.FlipVertically != null)
                    hashCode = hashCode * 59 + this.FlipVertically.GetHashCode();
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
