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
    /// Represents the parameters for a save as PDF action.
    /// </summary>
    [DataContract]
    public partial class ImageSaveAsPDFParameters :  IEquatable<ImageSaveAsPDFParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSaveAsPDFParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageSaveAsPDFParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSaveAsPDFParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        public ImageSaveAsPDFParameters(string fileId)
        {
            FileId = fileId;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to be saved as PDF.
        /// </summary>
        [DataMember(Name="PageRange")]
        public string PageRange { get; set; } = "*";

        /// <summary>
        /// Gets or Sets Conformance
        /// </summary>
        [DataMember(Name="Conformance")]
        public PdfConformance Conformance { get; set; }

        /// <summary>
        /// Gets or Sets ColorImageCompression
        /// </summary>
        [DataMember(Name="ColorImageCompression")]
        public PdfImageCompressionScheme ColorImageCompression { get; set; }

        /// <summary>
        /// Gets or Sets BitonalImageCompression
        /// </summary>
        [DataMember(Name="BitonalImageCompression")]
        public PdfImageCompressionScheme BitonalImageCompression { get; set; }

        /// <summary>
        /// Specifies is color detection must be used.
        /// </summary>
        [DataMember(Name="EnableColorDetection")]
        public bool EnableColorDetection { get; set; } = false;

        /// <summary>
        /// Specifies the quality to be used for the compression of the images from the PDF.  Must be in the range [0 (best compression - worst quality) - 100 (worst quality - best compression)].
        /// </summary>
        [DataMember(Name="ImageQuality")]
        public int ImageQuality { get; set; } = 75;

        /// <summary>
        /// Specifies the resolution for downscaling images, if any.
        /// </summary>
        [DataMember(Name="DownscaleResolution")]
        public int DownscaleResolution { get; set; } = 0;

        /// <summary>
        /// Specifies whether the PDF shall be optimized for online distribution.
        /// </summary>
        [DataMember(Name="FastWebView")]
        public bool FastWebView { get; set; } = false;

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
            return Equals(input as ImageSaveAsPDFParameters);
        }

        /// <summary>
        /// Returns true if ImageSaveAsPDFParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageSaveAsPDFParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageSaveAsPDFParameters input)
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
                    Conformance == input.Conformance ||
                    Conformance.Equals(input.Conformance)
                ) && 
                (
                    ColorImageCompression == input.ColorImageCompression ||
                    ColorImageCompression.Equals(input.ColorImageCompression)
                ) && 
                (
                    BitonalImageCompression == input.BitonalImageCompression ||
                    BitonalImageCompression.Equals(input.BitonalImageCompression)
                ) && 
                (
                    EnableColorDetection == input.EnableColorDetection ||
                    EnableColorDetection.Equals(input.EnableColorDetection)
                ) && 
                (
                    ImageQuality == input.ImageQuality ||
                    ImageQuality.Equals(input.ImageQuality)
                ) && 
                (
                    DownscaleResolution == input.DownscaleResolution ||
                    DownscaleResolution.Equals(input.DownscaleResolution)
                ) && 
                (
                    FastWebView == input.FastWebView ||
                    FastWebView.Equals(input.FastWebView)
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
                hashCode = hashCode * 59 + Conformance.GetHashCode();
                hashCode = hashCode * 59 + ColorImageCompression.GetHashCode();
                hashCode = hashCode * 59 + BitonalImageCompression.GetHashCode();
                hashCode = hashCode * 59 + EnableColorDetection.GetHashCode();
                hashCode = hashCode * 59 + ImageQuality.GetHashCode();
                hashCode = hashCode * 59 + DownscaleResolution.GetHashCode();
                hashCode = hashCode * 59 + FastWebView.GetHashCode();
                return hashCode;
            }
        }
    }

}
