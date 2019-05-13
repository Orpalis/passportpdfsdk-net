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
    /// Represents the parameters for an image crop action.
    /// </summary>
    [DataContract]
    public partial class ImageCropParameters :  IEquatable<ImageCropParameters>, IValidatableObject
    {
        /// <summary>
        /// Specifies in which unit the provided crop box coordinates are expressed.
        /// </summary>
        /// <value>Specifies in which unit the provided crop box coordinates are expressed.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CropUnitEnum
        {
            /// <summary>
            /// Enum Pixel for value: Pixel
            /// </summary>
            [EnumMember(Value = "Pixel")]
            Pixel = 1,

            /// <summary>
            /// Enum Percent for value: Percent
            /// </summary>
            [EnumMember(Value = "Percent")]
            Percent = 2

        }

        /// <summary>
        /// Specifies in which unit the provided crop box coordinates are expressed.
        /// </summary>
        /// <value>Specifies in which unit the provided crop box coordinates are expressed.</value>
        [DataMember(Name="CropUnit", EmitDefaultValue=false)]
        public CropUnitEnum? CropUnit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageCropParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageCropParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageCropParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages to crop. (required).</param>
        /// <param name="cropBoxLeft">Specifies the crop box left coordinate. (required).</param>
        /// <param name="cropBoxTop">Specifies the crop box top coordinate. (required).</param>
        /// <param name="cropBoxWidth">Specifies the crop box width. (required).</param>
        /// <param name="cropBoxHeight">Specifies the crop box height. (required).</param>
        /// <param name="cropUnit">Specifies in which unit the provided crop box coordinates are expressed. (default to CropUnitEnum.Pixel).</param>
        public ImageCropParameters(string fileId = default(string), string pageRange = default(string), int? cropBoxLeft = default(int?), int? cropBoxTop = default(int?), int? cropBoxWidth = default(int?), int? cropBoxHeight = default(int?), CropUnitEnum? cropUnit = CropUnitEnum.Pixel)
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for ImageCropParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            
            // to ensure "pageRange" is required (not null)
            if (pageRange == null)
            {
                throw new InvalidDataException("pageRange is a required property for ImageCropParameters and cannot be null");
            }
            else
            {
                this.PageRange = pageRange;
            }
            
            // to ensure "cropBoxLeft" is required (not null)
            if (cropBoxLeft == null)
            {
                throw new InvalidDataException("cropBoxLeft is a required property for ImageCropParameters and cannot be null");
            }
            else
            {
                this.CropBoxLeft = cropBoxLeft;
            }
            
            // to ensure "cropBoxTop" is required (not null)
            if (cropBoxTop == null)
            {
                throw new InvalidDataException("cropBoxTop is a required property for ImageCropParameters and cannot be null");
            }
            else
            {
                this.CropBoxTop = cropBoxTop;
            }
            
            // to ensure "cropBoxWidth" is required (not null)
            if (cropBoxWidth == null)
            {
                throw new InvalidDataException("cropBoxWidth is a required property for ImageCropParameters and cannot be null");
            }
            else
            {
                this.CropBoxWidth = cropBoxWidth;
            }
            
            // to ensure "cropBoxHeight" is required (not null)
            if (cropBoxHeight == null)
            {
                throw new InvalidDataException("cropBoxHeight is a required property for ImageCropParameters and cannot be null");
            }
            else
            {
                this.CropBoxHeight = cropBoxHeight;
            }
            
            // use default value if no "cropUnit" provided
            if (cropUnit == null)
            {
                this.CropUnit = CropUnitEnum.Pixel;
            }
            else
            {
                this.CropUnit = cropUnit;
            }
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to crop.
        /// </summary>
        /// <value>Specifies the number of the page, or the range of pages to crop.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies the crop box left coordinate.
        /// </summary>
        /// <value>Specifies the crop box left coordinate.</value>
        [DataMember(Name="CropBoxLeft", EmitDefaultValue=false)]
        public int? CropBoxLeft { get; set; }

        /// <summary>
        /// Specifies the crop box top coordinate.
        /// </summary>
        /// <value>Specifies the crop box top coordinate.</value>
        [DataMember(Name="CropBoxTop", EmitDefaultValue=false)]
        public int? CropBoxTop { get; set; }

        /// <summary>
        /// Specifies the crop box width.
        /// </summary>
        /// <value>Specifies the crop box width.</value>
        [DataMember(Name="CropBoxWidth", EmitDefaultValue=false)]
        public int? CropBoxWidth { get; set; }

        /// <summary>
        /// Specifies the crop box height.
        /// </summary>
        /// <value>Specifies the crop box height.</value>
        [DataMember(Name="CropBoxHeight", EmitDefaultValue=false)]
        public int? CropBoxHeight { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageCropParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  CropBoxLeft: ").Append(CropBoxLeft).Append("\n");
            sb.Append("  CropBoxTop: ").Append(CropBoxTop).Append("\n");
            sb.Append("  CropBoxWidth: ").Append(CropBoxWidth).Append("\n");
            sb.Append("  CropBoxHeight: ").Append(CropBoxHeight).Append("\n");
            sb.Append("  CropUnit: ").Append(CropUnit).Append("\n");
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
            return this.Equals(input as ImageCropParameters);
        }

        /// <summary>
        /// Returns true if ImageCropParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageCropParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageCropParameters input)
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
                    this.CropBoxLeft == input.CropBoxLeft ||
                    (this.CropBoxLeft != null &&
                    this.CropBoxLeft.Equals(input.CropBoxLeft))
                ) && 
                (
                    this.CropBoxTop == input.CropBoxTop ||
                    (this.CropBoxTop != null &&
                    this.CropBoxTop.Equals(input.CropBoxTop))
                ) && 
                (
                    this.CropBoxWidth == input.CropBoxWidth ||
                    (this.CropBoxWidth != null &&
                    this.CropBoxWidth.Equals(input.CropBoxWidth))
                ) && 
                (
                    this.CropBoxHeight == input.CropBoxHeight ||
                    (this.CropBoxHeight != null &&
                    this.CropBoxHeight.Equals(input.CropBoxHeight))
                ) && 
                (
                    this.CropUnit == input.CropUnit ||
                    (this.CropUnit != null &&
                    this.CropUnit.Equals(input.CropUnit))
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
                if (this.CropBoxLeft != null)
                    hashCode = hashCode * 59 + this.CropBoxLeft.GetHashCode();
                if (this.CropBoxTop != null)
                    hashCode = hashCode * 59 + this.CropBoxTop.GetHashCode();
                if (this.CropBoxWidth != null)
                    hashCode = hashCode * 59 + this.CropBoxWidth.GetHashCode();
                if (this.CropBoxHeight != null)
                    hashCode = hashCode * 59 + this.CropBoxHeight.GetHashCode();
                if (this.CropUnit != null)
                    hashCode = hashCode * 59 + this.CropUnit.GetHashCode();
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
