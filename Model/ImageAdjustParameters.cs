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
    /// Represents the parameters for an image adjustment action.
    /// </summary>
    [DataContract]
    public partial class ImageAdjustParameters :  IEquatable<ImageAdjustParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageAdjustParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageAdjustParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageAdjustParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages to adjust. (required).</param>
        /// <param name="roiLeft">Specifies the left coordinate, in pixel, of the region to process..</param>
        /// <param name="roiTop">Specifies the top coordinate, in pixel, of the region to process..</param>
        /// <param name="roiWidth">Specifies the width, in pixel, of the region to process. 0 causes the entire image to be processed..</param>
        /// <param name="roiHeight">Specifies the height, in pixel, of the region to process. 0 causes the entire image to be processed..</param>
        /// <param name="gammaCorrection">Specifies the gamma correction parameter..</param>
        /// <param name="brightness">Specifies the brightness parameter..</param>
        /// <param name="contrast">Specifies the contrast parameter..</param>
        /// <param name="saturation">Specifies the saturation parameter..</param>
        /// <param name="autoContrastEnhancement">Specifies whether the contrast shall be automatically enhanced..</param>
        /// <param name="contrastHistogramStretch">Specifies whether a contrast histogram stretch filter shall be performed..</param>
        public ImageAdjustParameters(string fileId = default(string), string pageRange = default(string), int? roiLeft = default(int?), int? roiTop = default(int?), int? roiWidth = default(int?), int? roiHeight = default(int?), int? gammaCorrection = default(int?), int? brightness = default(int?), int? contrast = default(int?), int? saturation = default(int?), bool? autoContrastEnhancement = default(bool?), bool? contrastHistogramStretch = default(bool?))
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for ImageAdjustParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            // to ensure "pageRange" is required (not null)
            if (pageRange == null)
            {
                throw new InvalidDataException("pageRange is a required property for ImageAdjustParameters and cannot be null");
            }
            else
            {
                this.PageRange = pageRange;
            }
            this.RoiLeft = roiLeft;
            this.RoiTop = roiTop;
            this.RoiWidth = roiWidth;
            this.RoiHeight = roiHeight;
            this.GammaCorrection = gammaCorrection;
            this.Brightness = brightness;
            this.Contrast = contrast;
            this.Saturation = saturation;
            this.AutoContrastEnhancement = autoContrastEnhancement;
            this.ContrastHistogramStretch = contrastHistogramStretch;
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to adjust.
        /// </summary>
        /// <value>Specifies the number of the page, or the range of pages to adjust.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies the left coordinate, in pixel, of the region to process.
        /// </summary>
        /// <value>Specifies the left coordinate, in pixel, of the region to process.</value>
        [DataMember(Name="RoiLeft", EmitDefaultValue=false)]
        public int? RoiLeft { get; set; }

        /// <summary>
        /// Specifies the top coordinate, in pixel, of the region to process.
        /// </summary>
        /// <value>Specifies the top coordinate, in pixel, of the region to process.</value>
        [DataMember(Name="RoiTop", EmitDefaultValue=false)]
        public int? RoiTop { get; set; }

        /// <summary>
        /// Specifies the width, in pixel, of the region to process. 0 causes the entire image to be processed.
        /// </summary>
        /// <value>Specifies the width, in pixel, of the region to process. 0 causes the entire image to be processed.</value>
        [DataMember(Name="RoiWidth", EmitDefaultValue=false)]
        public int? RoiWidth { get; set; }

        /// <summary>
        /// Specifies the height, in pixel, of the region to process. 0 causes the entire image to be processed.
        /// </summary>
        /// <value>Specifies the height, in pixel, of the region to process. 0 causes the entire image to be processed.</value>
        [DataMember(Name="RoiHeight", EmitDefaultValue=false)]
        public int? RoiHeight { get; set; }

        /// <summary>
        /// Specifies the gamma correction parameter.
        /// </summary>
        /// <value>Specifies the gamma correction parameter.</value>
        [DataMember(Name="GammaCorrection", EmitDefaultValue=false)]
        public int? GammaCorrection { get; set; }

        /// <summary>
        /// Specifies the brightness parameter.
        /// </summary>
        /// <value>Specifies the brightness parameter.</value>
        [DataMember(Name="Brightness", EmitDefaultValue=false)]
        public int? Brightness { get; set; }

        /// <summary>
        /// Specifies the contrast parameter.
        /// </summary>
        /// <value>Specifies the contrast parameter.</value>
        [DataMember(Name="Contrast", EmitDefaultValue=false)]
        public int? Contrast { get; set; }

        /// <summary>
        /// Specifies the saturation parameter.
        /// </summary>
        /// <value>Specifies the saturation parameter.</value>
        [DataMember(Name="Saturation", EmitDefaultValue=false)]
        public int? Saturation { get; set; }

        /// <summary>
        /// Specifies whether the contrast shall be automatically enhanced.
        /// </summary>
        /// <value>Specifies whether the contrast shall be automatically enhanced.</value>
        [DataMember(Name="AutoContrastEnhancement", EmitDefaultValue=false)]
        public bool? AutoContrastEnhancement { get; set; }

        /// <summary>
        /// Specifies whether a contrast histogram stretch filter shall be performed.
        /// </summary>
        /// <value>Specifies whether a contrast histogram stretch filter shall be performed.</value>
        [DataMember(Name="ContrastHistogramStretch", EmitDefaultValue=false)]
        public bool? ContrastHistogramStretch { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageAdjustParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  RoiLeft: ").Append(RoiLeft).Append("\n");
            sb.Append("  RoiTop: ").Append(RoiTop).Append("\n");
            sb.Append("  RoiWidth: ").Append(RoiWidth).Append("\n");
            sb.Append("  RoiHeight: ").Append(RoiHeight).Append("\n");
            sb.Append("  GammaCorrection: ").Append(GammaCorrection).Append("\n");
            sb.Append("  Brightness: ").Append(Brightness).Append("\n");
            sb.Append("  Contrast: ").Append(Contrast).Append("\n");
            sb.Append("  Saturation: ").Append(Saturation).Append("\n");
            sb.Append("  AutoContrastEnhancement: ").Append(AutoContrastEnhancement).Append("\n");
            sb.Append("  ContrastHistogramStretch: ").Append(ContrastHistogramStretch).Append("\n");
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
            return this.Equals(input as ImageAdjustParameters);
        }

        /// <summary>
        /// Returns true if ImageAdjustParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageAdjustParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageAdjustParameters input)
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
                    this.RoiLeft == input.RoiLeft ||
                    (this.RoiLeft != null &&
                    this.RoiLeft.Equals(input.RoiLeft))
                ) && 
                (
                    this.RoiTop == input.RoiTop ||
                    (this.RoiTop != null &&
                    this.RoiTop.Equals(input.RoiTop))
                ) && 
                (
                    this.RoiWidth == input.RoiWidth ||
                    (this.RoiWidth != null &&
                    this.RoiWidth.Equals(input.RoiWidth))
                ) && 
                (
                    this.RoiHeight == input.RoiHeight ||
                    (this.RoiHeight != null &&
                    this.RoiHeight.Equals(input.RoiHeight))
                ) && 
                (
                    this.GammaCorrection == input.GammaCorrection ||
                    (this.GammaCorrection != null &&
                    this.GammaCorrection.Equals(input.GammaCorrection))
                ) && 
                (
                    this.Brightness == input.Brightness ||
                    (this.Brightness != null &&
                    this.Brightness.Equals(input.Brightness))
                ) && 
                (
                    this.Contrast == input.Contrast ||
                    (this.Contrast != null &&
                    this.Contrast.Equals(input.Contrast))
                ) && 
                (
                    this.Saturation == input.Saturation ||
                    (this.Saturation != null &&
                    this.Saturation.Equals(input.Saturation))
                ) && 
                (
                    this.AutoContrastEnhancement == input.AutoContrastEnhancement ||
                    (this.AutoContrastEnhancement != null &&
                    this.AutoContrastEnhancement.Equals(input.AutoContrastEnhancement))
                ) && 
                (
                    this.ContrastHistogramStretch == input.ContrastHistogramStretch ||
                    (this.ContrastHistogramStretch != null &&
                    this.ContrastHistogramStretch.Equals(input.ContrastHistogramStretch))
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
                if (this.RoiLeft != null)
                    hashCode = hashCode * 59 + this.RoiLeft.GetHashCode();
                if (this.RoiTop != null)
                    hashCode = hashCode * 59 + this.RoiTop.GetHashCode();
                if (this.RoiWidth != null)
                    hashCode = hashCode * 59 + this.RoiWidth.GetHashCode();
                if (this.RoiHeight != null)
                    hashCode = hashCode * 59 + this.RoiHeight.GetHashCode();
                if (this.GammaCorrection != null)
                    hashCode = hashCode * 59 + this.GammaCorrection.GetHashCode();
                if (this.Brightness != null)
                    hashCode = hashCode * 59 + this.Brightness.GetHashCode();
                if (this.Contrast != null)
                    hashCode = hashCode * 59 + this.Contrast.GetHashCode();
                if (this.Saturation != null)
                    hashCode = hashCode * 59 + this.Saturation.GetHashCode();
                if (this.AutoContrastEnhancement != null)
                    hashCode = hashCode * 59 + this.AutoContrastEnhancement.GetHashCode();
                if (this.ContrastHistogramStretch != null)
                    hashCode = hashCode * 59 + this.ContrastHistogramStretch.GetHashCode();
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
