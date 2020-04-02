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
    /// Represents the parameters for an image color depth change action.
    /// </summary>
    [DataContract]
    public partial class ImageConvertColorDepthParameters :  IEquatable<ImageConvertColorDepthParameters>
    {
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
        /// <param name="convertColorDepthMode">convertColorDepthMode (required).</param>
        public ImageConvertColorDepthParameters(string fileId, string pageRange, ColorDepthConversionMethod convertColorDepthMode)
        {
            FileId = fileId;
            PageRange = pageRange;
            ConvertColorDepthMode = convertColorDepthMode;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to process.
        /// </summary>
        [DataMember(Name="PageRange")]
        public string PageRange { get; set; }

        /// <summary>
        /// Gets or Sets ConvertColorDepthMode
        /// </summary>
        [DataMember(Name="ConvertColorDepthMode")]
        public ColorDepthConversionMethod ConvertColorDepthMode { get; set; }

        /// <summary>
        /// Specifies the threshold for a conversion using the Depth1BppOtsu method.
        /// </summary>
        [DataMember(Name="Depth1BppOtsuThreshold")]
        public int Depth1BppOtsuThreshold { get; set; } = 50;

        /// <summary>
        /// Specifies the threshold for a conversion using the Depth1BppBradley method.
        /// </summary>
        [DataMember(Name="Depth1BppBradleyThreshold")]
        public int Depth1BppBradleyThreshold { get; set; } = 38;

        /// <summary>
        /// Specifies the factor for a conversion using the Depth1BppSauvola method.
        /// </summary>
        [DataMember(Name="Depth1BppSauvolaFactor")]
        public float Depth1BppSauvolaFactor { get; set; } = 0.35F;

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
            return Equals(input as ImageConvertColorDepthParameters);
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
                    ConvertColorDepthMode == input.ConvertColorDepthMode ||
                    ConvertColorDepthMode.Equals(input.ConvertColorDepthMode)
                ) && 
                (
                    Depth1BppOtsuThreshold == input.Depth1BppOtsuThreshold ||
                    Depth1BppOtsuThreshold.Equals(input.Depth1BppOtsuThreshold)
                ) && 
                (
                    Depth1BppBradleyThreshold == input.Depth1BppBradleyThreshold ||
                    Depth1BppBradleyThreshold.Equals(input.Depth1BppBradleyThreshold)
                ) && 
                (
                    Depth1BppSauvolaFactor == input.Depth1BppSauvolaFactor ||
                    Depth1BppSauvolaFactor.Equals(input.Depth1BppSauvolaFactor)
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
                hashCode = hashCode * 59 + ConvertColorDepthMode.GetHashCode();
                hashCode = hashCode * 59 + Depth1BppOtsuThreshold.GetHashCode();
                hashCode = hashCode * 59 + Depth1BppBradleyThreshold.GetHashCode();
                hashCode = hashCode * 59 + Depth1BppSauvolaFactor.GetHashCode();
                return hashCode;
            }
        }
    }

}
