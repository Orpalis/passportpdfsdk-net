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
    /// Represents the parameters for an image rotate action.
    /// </summary>
    [DataContract]
    public partial class ImageRotateParameters :  IEquatable<ImageRotateParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageRotateParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageRotateParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageRotateParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages to rotate. (required).</param>
        /// <param name="rotationAngle">Specifies the rotation angle, clockwise in degrees, which can be either positive and negative and any multiple of 90..</param>
        /// <param name="flipHorizontally">Specifies whether the page(s) shall be flipped horizontally..</param>
        /// <param name="flipVertically">Specifies whether the page(s) shall be flipped vertically..</param>
        public ImageRotateParameters(string fileId = default(string), string pageRange = default(string), float? rotationAngle = default(float?), bool? flipHorizontally = default(bool?), bool? flipVertically = default(bool?))
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for ImageRotateParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            
            // to ensure "pageRange" is required (not null)
            if (pageRange == null)
            {
                throw new InvalidDataException("pageRange is a required property for ImageRotateParameters and cannot be null");
            }
            else
            {
                this.PageRange = pageRange;
            }
            
            this.RotationAngle = rotationAngle;
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
        /// Specifies the number of the page, or the range of pages to rotate.
        /// </summary>
        /// <value>Specifies the number of the page, or the range of pages to rotate.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies the rotation angle, clockwise in degrees, which can be either positive and negative and any multiple of 90.
        /// </summary>
        /// <value>Specifies the rotation angle, clockwise in degrees, which can be either positive and negative and any multiple of 90.</value>
        [DataMember(Name="RotationAngle", EmitDefaultValue=false)]
        public float? RotationAngle { get; set; }

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
            sb.Append("class ImageRotateParameters {\n");
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
            return this.Equals(input as ImageRotateParameters);
        }

        /// <summary>
        /// Returns true if ImageRotateParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageRotateParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageRotateParameters input)
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
