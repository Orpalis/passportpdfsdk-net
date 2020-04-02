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


namespace PassportPDF.Model
{
    /// <summary>
    /// Represents the parameters for an image adjustment action.
    /// </summary>
    [DataContract]
    public partial class ImageAdjustParameters :  IEquatable<ImageAdjustParameters>
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
        public ImageAdjustParameters(string fileId, string pageRange)
        {
            FileId = fileId;
            PageRange = pageRange;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to adjust.
        /// </summary>
        [DataMember(Name="PageRange")]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies the left coordinate, in pixel, of the region to process.
        /// </summary>
        [DataMember(Name="RoiLeft")]
        public int RoiLeft { get; set; } = 0;

        /// <summary>
        /// Specifies the top coordinate, in pixel, of the region to process.
        /// </summary>
        [DataMember(Name="RoiTop")]
        public int RoiTop { get; set; } = 0;

        /// <summary>
        /// Specifies the width, in pixel, of the region to process. 0 causes the entire image to be processed.
        /// </summary>
        [DataMember(Name="RoiWidth")]
        public int RoiWidth { get; set; } = 0;

        /// <summary>
        /// Specifies the height, in pixel, of the region to process. 0 causes the entire image to be processed.
        /// </summary>
        [DataMember(Name="RoiHeight")]
        public int RoiHeight { get; set; } = 0;

        /// <summary>
        /// Specifies the gamma correction parameter.
        /// </summary>
        [DataMember(Name="GammaCorrection")]
        public int GammaCorrection { get; set; } = 0;

        /// <summary>
        /// Specifies the brightness parameter.
        /// </summary>
        [DataMember(Name="Brightness")]
        public int Brightness { get; set; } = 0;

        /// <summary>
        /// Specifies the contrast parameter.
        /// </summary>
        [DataMember(Name="Contrast")]
        public int Contrast { get; set; } = 0;

        /// <summary>
        /// Specifies the saturation parameter.
        /// </summary>
        [DataMember(Name="Saturation")]
        public int Saturation { get; set; } = 0;

        /// <summary>
        /// Specifies whether the contrast shall be automatically enhanced.
        /// </summary>
        [DataMember(Name="AutoContrastEnhancement")]
        public bool AutoContrastEnhancement { get; set; } = false;

        /// <summary>
        /// Specifies whether a contrast histogram stretch filter shall be performed.
        /// </summary>
        [DataMember(Name="ContrastHistogramStretch")]
        public bool ContrastHistogramStretch { get; set; } = false;

        /// <summary>
        /// Returns the String presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
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
            return Equals(input as ImageAdjustParameters);
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
                    FileId == input.FileId ||
                    (FileId != null &&
                    FileId.Equals(input.FileId))
                ) && 
                (
                    PageRange == input.PageRange ||
                    (PageRange != null &&
                    PageRange.Equals(input.PageRange))
                ) && 
                (
                    RoiLeft == input.RoiLeft ||
                    RoiLeft.Equals(input.RoiLeft)
                ) && 
                (
                    RoiTop == input.RoiTop ||
                    RoiTop.Equals(input.RoiTop)
                ) && 
                (
                    RoiWidth == input.RoiWidth ||
                    RoiWidth.Equals(input.RoiWidth)
                ) && 
                (
                    RoiHeight == input.RoiHeight ||
                    RoiHeight.Equals(input.RoiHeight)
                ) && 
                (
                    GammaCorrection == input.GammaCorrection ||
                    GammaCorrection.Equals(input.GammaCorrection)
                ) && 
                (
                    Brightness == input.Brightness ||
                    Brightness.Equals(input.Brightness)
                ) && 
                (
                    Contrast == input.Contrast ||
                    Contrast.Equals(input.Contrast)
                ) && 
                (
                    Saturation == input.Saturation ||
                    Saturation.Equals(input.Saturation)
                ) && 
                (
                    AutoContrastEnhancement == input.AutoContrastEnhancement ||
                    AutoContrastEnhancement.Equals(input.AutoContrastEnhancement)
                ) && 
                (
                    ContrastHistogramStretch == input.ContrastHistogramStretch ||
                    ContrastHistogramStretch.Equals(input.ContrastHistogramStretch)
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
                if (FileId != null)
                    hashCode = hashCode * 59 + FileId.GetHashCode();
                if (PageRange != null)
                    hashCode = hashCode * 59 + PageRange.GetHashCode();
                hashCode = hashCode * 59 + RoiLeft.GetHashCode();
                hashCode = hashCode * 59 + RoiTop.GetHashCode();
                hashCode = hashCode * 59 + RoiWidth.GetHashCode();
                hashCode = hashCode * 59 + RoiHeight.GetHashCode();
                hashCode = hashCode * 59 + GammaCorrection.GetHashCode();
                hashCode = hashCode * 59 + Brightness.GetHashCode();
                hashCode = hashCode * 59 + Contrast.GetHashCode();
                hashCode = hashCode * 59 + Saturation.GetHashCode();
                hashCode = hashCode * 59 + AutoContrastEnhancement.GetHashCode();
                hashCode = hashCode * 59 + ContrastHistogramStretch.GetHashCode();
                return hashCode;
            }
        }
    }

}
