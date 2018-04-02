/* 
 * PassportPDF
 *
 * Copyright © 2018 ORPALIS - http://www.orpalis.com
 *
 * OpenAPI spec version: v1
 * Contact: contact@orpalis.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = PassportPDF.Client.SwaggerDateConverter;

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
            /// Enum Auto for "Auto"
            /// </summary>
            [EnumMember(Value = "Auto")]
            Auto = 1,
            
            /// <summary>
            /// Enum NearestNeighbor for "NearestNeighbor"
            /// </summary>
            [EnumMember(Value = "NearestNeighbor")]
            NearestNeighbor = 2,
            
            /// <summary>
            /// Enum Box for "Box"
            /// </summary>
            [EnumMember(Value = "Box")]
            Box = 3,
            
            /// <summary>
            /// Enum Lanczos3 for "Lanczos3"
            /// </summary>
            [EnumMember(Value = "Lanczos3")]
            Lanczos3 = 4,
            
            /// <summary>
            /// Enum Bilinear for "Bilinear"
            /// </summary>
            [EnumMember(Value = "Bilinear")]
            Bilinear = 5,
            
            /// <summary>
            /// Enum Bicubic for "Bicubic"
            /// </summary>
            [EnumMember(Value = "Bicubic")]
            Bicubic = 6,
            
            /// <summary>
            /// Enum Bspline for "Bspline"
            /// </summary>
            [EnumMember(Value = "Bspline")]
            Bspline = 7,
            
            /// <summary>
            /// Enum CatmullRomSpline for "CatmullRomSpline"
            /// </summary>
            [EnumMember(Value = "CatmullRomSpline")]
            CatmullRomSpline = 8
        }

        /// <summary>
        /// Specifies the interpolation algorithm that must be used during the resizing operation.
        /// </summary>
        /// <value>Specifies the interpolation algorithm that must be used during the resizing operation.</value>
        [DataMember(Name="resizeMode", EmitDefaultValue=false)]
        public ResizeModeEnum? ResizeMode { get; set; }
        /// <summary>
        /// Specifies the unit of measure for the given parameters.
        /// </summary>
        /// <value>Specifies the unit of measure for the given parameters.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResizeUnitEnum
        {
            
            /// <summary>
            /// Enum Pixel for "Pixel"
            /// </summary>
            [EnumMember(Value = "Pixel")]
            Pixel = 1,
            
            /// <summary>
            /// Enum Percent for "Percent"
            /// </summary>
            [EnumMember(Value = "Percent")]
            Percent = 2
        }

        /// <summary>
        /// Specifies the unit of measure for the given parameters.
        /// </summary>
        /// <value>Specifies the unit of measure for the given parameters.</value>
        [DataMember(Name="resizeUnit", EmitDefaultValue=false)]
        public ResizeUnitEnum? ResizeUnit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageResizeParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageResizeParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageResizeParameters" /> class.
        /// </summary>
        /// <param name="ResizeHorizontal">Specifies the resize horizontal parameter. (required).</param>
        /// <param name="ResizeVertical">Specifies the resize vertical parameter. (required).</param>
        /// <param name="FileId">FileId (required).</param>
        /// <param name="PageRange">Specifies the number of the page, or the range of pages to resize. (default to &quot;1&quot;).</param>
        /// <param name="ResizeMode">Specifies the interpolation algorithm that must be used during the resizing operation. (default to ResizeModeEnum.Auto).</param>
        /// <param name="ResizeUnit">Specifies the unit of measure for the given parameters. (default to ResizeUnitEnum.Pixel).</param>
        public ImageResizeParameters(float? ResizeHorizontal = default(float?), float? ResizeVertical = default(float?), string FileId = default(string), string PageRange = "1", ResizeModeEnum? ResizeMode = ResizeModeEnum.Auto, ResizeUnitEnum? ResizeUnit = ResizeUnitEnum.Pixel)
        {
            // to ensure "ResizeHorizontal" is required (not null)
            if (ResizeHorizontal == null)
            {
                throw new InvalidDataException("ResizeHorizontal is a required property for ImageResizeParameters and cannot be null");
            }
            else
            {
                this.ResizeHorizontal = ResizeHorizontal;
            }
            // to ensure "ResizeVertical" is required (not null)
            if (ResizeVertical == null)
            {
                throw new InvalidDataException("ResizeVertical is a required property for ImageResizeParameters and cannot be null");
            }
            else
            {
                this.ResizeVertical = ResizeVertical;
            }
            // to ensure "FileId" is required (not null)
            if (FileId == null)
            {
                throw new InvalidDataException("FileId is a required property for ImageResizeParameters and cannot be null");
            }
            else
            {
                this.FileId = FileId;
            }
            // use default value if no "PageRange" provided
            if (PageRange == null)
            {
                this.PageRange = "1";
            }
            else
            {
                this.PageRange = PageRange;
            }
            // use default value if no "ResizeMode" provided
            if (ResizeMode == null)
            {
                this.ResizeMode = ResizeModeEnum.Auto;
            }
            else
            {
                this.ResizeMode = ResizeMode;
            }
            // use default value if no "ResizeUnit" provided
            if (ResizeUnit == null)
            {
                this.ResizeUnit = ResizeUnitEnum.Pixel;
            }
            else
            {
                this.ResizeUnit = ResizeUnit;
            }
        }
        
        /// <summary>
        /// Specifies the resize horizontal parameter.
        /// </summary>
        /// <value>Specifies the resize horizontal parameter.</value>
        [DataMember(Name="resizeHorizontal", EmitDefaultValue=false)]
        public float? ResizeHorizontal { get; set; }

        /// <summary>
        /// Specifies the resize vertical parameter.
        /// </summary>
        /// <value>Specifies the resize vertical parameter.</value>
        [DataMember(Name="resizeVertical", EmitDefaultValue=false)]
        public float? ResizeVertical { get; set; }

        /// <summary>
        /// Gets or Sets FileId
        /// </summary>
        [DataMember(Name="fileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to resize.
        /// </summary>
        /// <value>Specifies the number of the page, or the range of pages to resize.</value>
        [DataMember(Name="pageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageResizeParameters {\n");
            sb.Append("  ResizeHorizontal: ").Append(ResizeHorizontal).Append("\n");
            sb.Append("  ResizeVertical: ").Append(ResizeVertical).Append("\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  ResizeMode: ").Append(ResizeMode).Append("\n");
            sb.Append("  ResizeUnit: ").Append(ResizeUnit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
                if (this.ResizeHorizontal != null)
                    hashCode = hashCode * 59 + this.ResizeHorizontal.GetHashCode();
                if (this.ResizeVertical != null)
                    hashCode = hashCode * 59 + this.ResizeVertical.GetHashCode();
                if (this.FileId != null)
                    hashCode = hashCode * 59 + this.FileId.GetHashCode();
                if (this.PageRange != null)
                    hashCode = hashCode * 59 + this.PageRange.GetHashCode();
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