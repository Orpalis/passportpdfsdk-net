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
    /// Represents the parameters for an image color depth change action.
    /// </summary>
    [DataContract]
    public partial class ImageConvertColorDepthParameters :  IEquatable<ImageConvertColorDepthParameters>, IValidatableObject
    {
        /// <summary>
        /// Specifies the color depth conversion method to be used.
        /// </summary>
        /// <value>Specifies the color depth conversion method to be used.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConvertColorDepthModeEnum
        {
            /// <summary>
            /// Enum Depth1Bpp for value: Depth1Bpp
            /// </summary>
            [EnumMember(Value = "Depth1Bpp")]
            Depth1Bpp = 1,

            /// <summary>
            /// Enum Depth1BppOtsu for value: Depth1BppOtsu
            /// </summary>
            [EnumMember(Value = "Depth1BppOtsu")]
            Depth1BppOtsu = 2,

            /// <summary>
            /// Enum Depth1BppBradley for value: Depth1BppBradley
            /// </summary>
            [EnumMember(Value = "Depth1BppBradley")]
            Depth1BppBradley = 3,

            /// <summary>
            /// Enum Depth1BppSauvola for value: Depth1BppSauvola
            /// </summary>
            [EnumMember(Value = "Depth1BppSauvola")]
            Depth1BppSauvola = 4,

            /// <summary>
            /// Enum Depth1BppFast for value: Depth1BppFast
            /// </summary>
            [EnumMember(Value = "Depth1BppFast")]
            Depth1BppFast = 5,

            /// <summary>
            /// Enum Depth4Bpp16 for value: Depth4Bpp16
            /// </summary>
            [EnumMember(Value = "Depth4Bpp16")]
            Depth4Bpp16 = 6,

            /// <summary>
            /// Enum Depth4BppQ for value: Depth4BppQ
            /// </summary>
            [EnumMember(Value = "Depth4BppQ")]
            Depth4BppQ = 7,

            /// <summary>
            /// Enum Depth8BppGrayScale for value: Depth8BppGrayScale
            /// </summary>
            [EnumMember(Value = "Depth8BppGrayScale")]
            Depth8BppGrayScale = 8,

            /// <summary>
            /// Enum Depth8BppGrayScaleAdv for value: Depth8BppGrayScaleAdv
            /// </summary>
            [EnumMember(Value = "Depth8BppGrayScaleAdv")]
            Depth8BppGrayScaleAdv = 9,

            /// <summary>
            /// Enum Depth8Bpp216 for value: Depth8Bpp216
            /// </summary>
            [EnumMember(Value = "Depth8Bpp216")]
            Depth8Bpp216 = 10,

            /// <summary>
            /// Enum Depth8BppQ for value: Depth8BppQ
            /// </summary>
            [EnumMember(Value = "Depth8BppQ")]
            Depth8BppQ = 11,

            /// <summary>
            /// Enum Depth16BppRGB555 for value: Depth16BppRGB555
            /// </summary>
            [EnumMember(Value = "Depth16BppRGB555")]
            Depth16BppRGB555 = 12,

            /// <summary>
            /// Enum Depth16BppRGB565 for value: Depth16BppRGB565
            /// </summary>
            [EnumMember(Value = "Depth16BppRGB565")]
            Depth16BppRGB565 = 13,

            /// <summary>
            /// Enum Depth24BppRGB for value: Depth24BppRGB
            /// </summary>
            [EnumMember(Value = "Depth24BppRGB")]
            Depth24BppRGB = 14,

            /// <summary>
            /// Enum Depth32BppARGB for value: Depth32BppARGB
            /// </summary>
            [EnumMember(Value = "Depth32BppARGB")]
            Depth32BppARGB = 15,

            /// <summary>
            /// Enum Depth32BppRGB for value: Depth32BppRGB
            /// </summary>
            [EnumMember(Value = "Depth32BppRGB")]
            Depth32BppRGB = 16,

            /// <summary>
            /// Enum Depth32BppPARGB for value: Depth32BppPARGB
            /// </summary>
            [EnumMember(Value = "Depth32BppPARGB")]
            Depth32BppPARGB = 17,

            /// <summary>
            /// Enum Depth48BppRGB for value: Depth48BppRGB
            /// </summary>
            [EnumMember(Value = "Depth48BppRGB")]
            Depth48BppRGB = 18,

            /// <summary>
            /// Enum Depth64BppARGB for value: Depth64BppARGB
            /// </summary>
            [EnumMember(Value = "Depth64BppARGB")]
            Depth64BppARGB = 19,

            /// <summary>
            /// Enum Depth64BppPARGB for value: Depth64BppPARGB
            /// </summary>
            [EnumMember(Value = "Depth64BppPARGB")]
            Depth64BppPARGB = 20

        }

        /// <summary>
        /// Specifies the color depth conversion method to be used.
        /// </summary>
        /// <value>Specifies the color depth conversion method to be used.</value>
        [DataMember(Name="ConvertColorDepthMode", EmitDefaultValue=false)]
        public ConvertColorDepthModeEnum ConvertColorDepthMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageConvertColorDepthParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageConvertColorDepthParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageConvertColorDepthParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages to process. (required).</param>
        /// <param name="convertColorDepthMode">Specifies the color depth conversion method to be used. (required).</param>
        /// <param name="depth1BppOtsuThreshold">Specifies the threshold for a conversion using the Depth1BppOtsu method. (default to 50).</param>
        /// <param name="depth1BppBradleyThreshold">Specifies the threshold for a conversion using the Depth1BppBradley method. (default to 38).</param>
        /// <param name="depth1BppSauvolaFactor">Specifies the factor for a conversion using the Depth1BppSauvola method. (default to 0.35F).</param>
        public ImageConvertColorDepthParameters(string fileId = default(string), string pageRange = default(string), ConvertColorDepthModeEnum convertColorDepthMode = default(ConvertColorDepthModeEnum), int? depth1BppOtsuThreshold = 50, int? depth1BppBradleyThreshold = 38, float? depth1BppSauvolaFactor = 0.35F)
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for ImageConvertColorDepthParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            
            // to ensure "pageRange" is required (not null)
            if (pageRange == null)
            {
                throw new InvalidDataException("pageRange is a required property for ImageConvertColorDepthParameters and cannot be null");
            }
            else
            {
                this.PageRange = pageRange;
            }
            
            // to ensure "convertColorDepthMode" is required (not null)
            if (convertColorDepthMode == null)
            {
                throw new InvalidDataException("convertColorDepthMode is a required property for ImageConvertColorDepthParameters and cannot be null");
            }
            else
            {
                this.ConvertColorDepthMode = convertColorDepthMode;
            }
            
            // use default value if no "depth1BppOtsuThreshold" provided
            if (depth1BppOtsuThreshold == null)
            {
                this.Depth1BppOtsuThreshold = 50;
            }
            else
            {
                this.Depth1BppOtsuThreshold = depth1BppOtsuThreshold;
            }
            // use default value if no "depth1BppBradleyThreshold" provided
            if (depth1BppBradleyThreshold == null)
            {
                this.Depth1BppBradleyThreshold = 38;
            }
            else
            {
                this.Depth1BppBradleyThreshold = depth1BppBradleyThreshold;
            }
            // use default value if no "depth1BppSauvolaFactor" provided
            if (depth1BppSauvolaFactor == null)
            {
                this.Depth1BppSauvolaFactor = 0.35F;
            }
            else
            {
                this.Depth1BppSauvolaFactor = depth1BppSauvolaFactor;
            }
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to process.
        /// </summary>
        /// <value>Specifies the number of the page, or the range of pages to process.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }


        /// <summary>
        /// Specifies the threshold for a conversion using the Depth1BppOtsu method.
        /// </summary>
        /// <value>Specifies the threshold for a conversion using the Depth1BppOtsu method.</value>
        [DataMember(Name="Depth1BppOtsuThreshold", EmitDefaultValue=false)]
        public int? Depth1BppOtsuThreshold { get; set; }

        /// <summary>
        /// Specifies the threshold for a conversion using the Depth1BppBradley method.
        /// </summary>
        /// <value>Specifies the threshold for a conversion using the Depth1BppBradley method.</value>
        [DataMember(Name="Depth1BppBradleyThreshold", EmitDefaultValue=false)]
        public int? Depth1BppBradleyThreshold { get; set; }

        /// <summary>
        /// Specifies the factor for a conversion using the Depth1BppSauvola method.
        /// </summary>
        /// <value>Specifies the factor for a conversion using the Depth1BppSauvola method.</value>
        [DataMember(Name="Depth1BppSauvolaFactor", EmitDefaultValue=false)]
        public float? Depth1BppSauvolaFactor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageConvertColorDepthParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  ConvertColorDepthMode: ").Append(ConvertColorDepthMode).Append("\n");
            sb.Append("  Depth1BppOtsuThreshold: ").Append(Depth1BppOtsuThreshold).Append("\n");
            sb.Append("  Depth1BppBradleyThreshold: ").Append(Depth1BppBradleyThreshold).Append("\n");
            sb.Append("  Depth1BppSauvolaFactor: ").Append(Depth1BppSauvolaFactor).Append("\n");
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
            return this.Equals(input as ImageConvertColorDepthParameters);
        }

        /// <summary>
        /// Returns true if ImageConvertColorDepthParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageConvertColorDepthParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageConvertColorDepthParameters input)
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
                    this.ConvertColorDepthMode == input.ConvertColorDepthMode ||
                    (this.ConvertColorDepthMode != null &&
                    this.ConvertColorDepthMode.Equals(input.ConvertColorDepthMode))
                ) && 
                (
                    this.Depth1BppOtsuThreshold == input.Depth1BppOtsuThreshold ||
                    (this.Depth1BppOtsuThreshold != null &&
                    this.Depth1BppOtsuThreshold.Equals(input.Depth1BppOtsuThreshold))
                ) && 
                (
                    this.Depth1BppBradleyThreshold == input.Depth1BppBradleyThreshold ||
                    (this.Depth1BppBradleyThreshold != null &&
                    this.Depth1BppBradleyThreshold.Equals(input.Depth1BppBradleyThreshold))
                ) && 
                (
                    this.Depth1BppSauvolaFactor == input.Depth1BppSauvolaFactor ||
                    (this.Depth1BppSauvolaFactor != null &&
                    this.Depth1BppSauvolaFactor.Equals(input.Depth1BppSauvolaFactor))
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
                if (this.ConvertColorDepthMode != null)
                    hashCode = hashCode * 59 + this.ConvertColorDepthMode.GetHashCode();
                if (this.Depth1BppOtsuThreshold != null)
                    hashCode = hashCode * 59 + this.Depth1BppOtsuThreshold.GetHashCode();
                if (this.Depth1BppBradleyThreshold != null)
                    hashCode = hashCode * 59 + this.Depth1BppBradleyThreshold.GetHashCode();
                if (this.Depth1BppSauvolaFactor != null)
                    hashCode = hashCode * 59 + this.Depth1BppSauvolaFactor.GetHashCode();
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
