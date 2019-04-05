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
    /// Represents the parameters for an image resize action.
    /// </summary>
    [DataContract]
    public partial class ImageResizeParameters :  IEquatable<ImageResizeParameters>, IValidatableObject
    {
        /// <summary>
        /// Specifies the interpolation algorithm that must be used during the resizing operation.
        /// </summary>
        /// <value>Specifies the interpolation algorithm that must be used during the resizing operation.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResizeModeEnum
        {
            /// <summary>
            /// Enum Auto for value: Auto
            /// </summary>
            [EnumMember(Value = "Auto")]
            Auto = 1,

            /// <summary>
            /// Enum NearestNeighbor for value: NearestNeighbor
            /// </summary>
            [EnumMember(Value = "NearestNeighbor")]
            NearestNeighbor = 2,

            /// <summary>
            /// Enum Box for value: Box
            /// </summary>
            [EnumMember(Value = "Box")]
            Box = 3,

            /// <summary>
            /// Enum Lanczos3 for value: Lanczos3
            /// </summary>
            [EnumMember(Value = "Lanczos3")]
            Lanczos3 = 4,

            /// <summary>
            /// Enum Bilinear for value: Bilinear
            /// </summary>
            [EnumMember(Value = "Bilinear")]
            Bilinear = 5,

            /// <summary>
            /// Enum Bicubic for value: Bicubic
            /// </summary>
            [EnumMember(Value = "Bicubic")]
            Bicubic = 6,

            /// <summary>
            /// Enum Bspline for value: Bspline
            /// </summary>
            [EnumMember(Value = "Bspline")]
            Bspline = 7,

            /// <summary>
            /// Enum CatmullRomSpline for value: CatmullRomSpline
            /// </summary>
            [EnumMember(Value = "CatmullRomSpline")]
            CatmullRomSpline = 8

        }

        /// <summary>
        /// Specifies the interpolation algorithm that must be used during the resizing operation.
        /// </summary>
        /// <value>Specifies the interpolation algorithm that must be used during the resizing operation.</value>
        [DataMember(Name="ResizeMode", EmitDefaultValue=false)]
        public ResizeModeEnum? ResizeMode { get; set; }
        /// <summary>
        /// Specifies the unit of measure for the given parameters.
        /// </summary>
        /// <value>Specifies the unit of measure for the given parameters.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResizeUnitEnum
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
        /// Specifies the unit of measure for the given parameters.
        /// </summary>
        /// <value>Specifies the unit of measure for the given parameters.</value>
        [DataMember(Name="ResizeUnit", EmitDefaultValue=false)]
        public ResizeUnitEnum? ResizeUnit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageResizeParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageResizeParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageResizeParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages to resize. (required).</param>
        /// <param name="resizeHorizontal">Specifies the resize horizontal parameter. (required).</param>
        /// <param name="resizeVertical">Specifies the resize vertical parameter. (required).</param>
        /// <param name="resizeMode">Specifies the interpolation algorithm that must be used during the resizing operation. (default to ResizeModeEnum.Auto).</param>
        /// <param name="resizeUnit">Specifies the unit of measure for the given parameters. (default to ResizeUnitEnum.Pixel).</param>
        public ImageResizeParameters(string fileId = default(string), string pageRange = default(string), float? resizeHorizontal = default(float?), float? resizeVertical = default(float?), ResizeModeEnum? resizeMode = ResizeModeEnum.Auto, ResizeUnitEnum? resizeUnit = ResizeUnitEnum.Pixel)
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for ImageResizeParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            // to ensure "pageRange" is required (not null)
            if (pageRange == null)
            {
                throw new InvalidDataException("pageRange is a required property for ImageResizeParameters and cannot be null");
            }
            else
            {
                this.PageRange = pageRange;
            }
            // to ensure "resizeHorizontal" is required (not null)
            if (resizeHorizontal == null)
            {
                throw new InvalidDataException("resizeHorizontal is a required property for ImageResizeParameters and cannot be null");
            }
            else
            {
                this.ResizeHorizontal = resizeHorizontal;
            }
            // to ensure "resizeVertical" is required (not null)
            if (resizeVertical == null)
            {
                throw new InvalidDataException("resizeVertical is a required property for ImageResizeParameters and cannot be null");
            }
            else
            {
                this.ResizeVertical = resizeVertical;
            }
            // use default value if no "resizeMode" provided
            if (resizeMode == null)
            {
                this.ResizeMode = ResizeModeEnum.Auto;
            }
            else
            {
                this.ResizeMode = resizeMode;
            }
            // use default value if no "resizeUnit" provided
            if (resizeUnit == null)
            {
                this.ResizeUnit = ResizeUnitEnum.Pixel;
            }
            else
            {
                this.ResizeUnit = resizeUnit;
            }
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to resize.
        /// </summary>
        /// <value>Specifies the number of the page, or the range of pages to resize.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies the resize horizontal parameter.
        /// </summary>
        /// <value>Specifies the resize horizontal parameter.</value>
        [DataMember(Name="ResizeHorizontal", EmitDefaultValue=false)]
        public float? ResizeHorizontal { get; set; }

        /// <summary>
        /// Specifies the resize vertical parameter.
        /// </summary>
        /// <value>Specifies the resize vertical parameter.</value>
        [DataMember(Name="ResizeVertical", EmitDefaultValue=false)]
        public float? ResizeVertical { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageResizeParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  ResizeHorizontal: ").Append(ResizeHorizontal).Append("\n");
            sb.Append("  ResizeVertical: ").Append(ResizeVertical).Append("\n");
            sb.Append("  ResizeMode: ").Append(ResizeMode).Append("\n");
            sb.Append("  ResizeUnit: ").Append(ResizeUnit).Append("\n");
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
            return this.Equals(input as ImageResizeParameters);
        }

        /// <summary>
        /// Returns true if ImageResizeParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageResizeParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageResizeParameters input)
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
                    this.ResizeHorizontal == input.ResizeHorizontal ||
                    (this.ResizeHorizontal != null &&
                    this.ResizeHorizontal.Equals(input.ResizeHorizontal))
                ) && 
                (
                    this.ResizeVertical == input.ResizeVertical ||
                    (this.ResizeVertical != null &&
                    this.ResizeVertical.Equals(input.ResizeVertical))
                ) && 
                (
                    this.ResizeMode == input.ResizeMode ||
                    (this.ResizeMode != null &&
                    this.ResizeMode.Equals(input.ResizeMode))
                ) && 
                (
                    this.ResizeUnit == input.ResizeUnit ||
                    (this.ResizeUnit != null &&
                    this.ResizeUnit.Equals(input.ResizeUnit))
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
                if (this.ResizeHorizontal != null)
                    hashCode = hashCode * 59 + this.ResizeHorizontal.GetHashCode();
                if (this.ResizeVertical != null)
                    hashCode = hashCode * 59 + this.ResizeVertical.GetHashCode();
                if (this.ResizeMode != null)
                    hashCode = hashCode * 59 + this.ResizeMode.GetHashCode();
                if (this.ResizeUnit != null)
                    hashCode = hashCode * 59 + this.ResizeUnit.GetHashCode();
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
