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
    /// Represents the parameters for a reduce action.
    /// </summary>
    [DataContract]
    public partial class PdfReduceParameters :  IEquatable<PdfReduceParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfReduceParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfReduceParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfReduceParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        public PdfReduceParameters(string fileId)
        {
            FileId = fileId;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Gets or Sets OutputVersion
        /// </summary>
        [DataMember(Name="OutputVersion")]
        public PdfVersion OutputVersion { get; set; }

        /// <summary>
        /// Gets or Sets ImageQuality
        /// </summary>
        [DataMember(Name="ImageQuality")]
        public ImageQuality ImageQuality { get; set; }

        /// <summary>
        /// Specifies whether the images from the PDF shall be recompressed.
        /// </summary>
        [DataMember(Name="RecompressImages")]
        public bool RecompressImages { get; set; } = true;

        /// <summary>
        /// Specifies whether color detection must be performed on the images from the PDF.
        /// </summary>
        [DataMember(Name="EnableColorDetection")]
        public bool EnableColorDetection { get; set; } = true;

        /// <summary>
        /// Specifies whether the PDF shall be packed when saved in order to reduce its size.
        /// </summary>
        [DataMember(Name="PackDocument")]
        public bool PackDocument { get; set; } = true;

        /// <summary>
        /// Specifies whether the PDF fonts must be packed in order to reduce their size.
        /// </summary>
        [DataMember(Name="PackFonts")]
        public bool PackFonts { get; set; } = true;

        /// <summary>
        /// Specifies whether the images from the PDF shall be downscaled.
        /// </summary>
        [DataMember(Name="DownscaleImages")]
        public bool DownscaleImages { get; set; } = true;

        /// <summary>
        /// Specifies the resolution to be used to downscale images.
        /// </summary>
        [DataMember(Name="DownscaleResolution")]
        public int DownscaleResolution { get; set; } = 150;

        /// <summary>
        /// Specifies whether the PDF shall be optimized for online distribution.
        /// </summary>
        [DataMember(Name="FastWebView")]
        public bool FastWebView { get; set; } = false;

        /// <summary>
        /// Specifies whether the form fields shall be removed from the PDF.
        /// </summary>
        [DataMember(Name="RemoveFormFields")]
        public bool RemoveFormFields { get; set; } = false;

        /// <summary>
        /// Specifies whether the annotations shall be removed from the PDF.
        /// </summary>
        [DataMember(Name="RemoveAnnotations")]
        public bool RemoveAnnotations { get; set; } = false;

        /// <summary>
        /// Specifies whether the bookmarks shall be removed from the PDF.
        /// </summary>
        [DataMember(Name="RemoveBookmarks")]
        public bool RemoveBookmarks { get; set; } = false;

        /// <summary>
        /// Specifies whether the hyperlinks shall be removed from the PDF.
        /// </summary>
        [DataMember(Name="RemoveHyperlinks")]
        public bool RemoveHyperlinks { get; set; } = false;

        /// <summary>
        /// Specifies whether the embedded files shall be removed from the PDF.
        /// </summary>
        [DataMember(Name="RemoveEmbeddedFiles")]
        public bool RemoveEmbeddedFiles { get; set; } = false;

        /// <summary>
        /// Specifies whether the blank pages shall be removed.
        /// </summary>
        [DataMember(Name="RemoveBlankPages")]
        public bool RemoveBlankPages { get; set; } = false;

        /// <summary>
        /// Specifies whether the JavaScript shall be removed.
        /// </summary>
        [DataMember(Name="RemoveJavaScript")]
        public bool RemoveJavaScript { get; set; } = false;

        /// <summary>
        /// Specifies whether the JPEG2000 compression scheme shall be used to compress the images of the PDF.
        /// </summary>
        [DataMember(Name="EnableJPEG2000")]
        public bool EnableJPEG2000 { get; set; } = true;

        /// <summary>
        /// Specifies whether the JBIG2 compression scheme shall be used to compress the bitonal images of the PDF.
        /// </summary>
        [DataMember(Name="EnableJBIG2")]
        public bool EnableJBIG2 { get; set; } = true;

        /// <summary>
        /// Specifies whether characters repairing shall be performed during bitonal conversion.
        /// </summary>
        [DataMember(Name="EnableCharRepair")]
        public bool EnableCharRepair { get; set; } = false;

        /// <summary>
        /// Specifies whether MRC shall be used for compressing the PDF contents.
        /// </summary>
        [DataMember(Name="EnableMRC")]
        public bool EnableMRC { get; set; } = false;

        /// <summary>
        /// Specifies if the MRC engine shall try to preserve smoothing between different layers.
        /// </summary>
        [DataMember(Name="PreserveSmoothing")]
        public bool PreserveSmoothing { get; set; } = false;

        /// <summary>
        /// Specifies the resolution for downscaling the background layer by the MRC engine, if any.
        /// </summary>
        [DataMember(Name="DownscaleResolutionMRC")]
        public int DownscaleResolutionMRC { get; set; } = 100;

        /// <summary>
        /// Specifies whether the metadata shall be removed.
        /// </summary>
        [DataMember(Name="RemoveMetadata")]
        public bool RemoveMetadata { get; set; } = false;

        /// <summary>
        /// Specifies whether the page thumbnails shall be removed.
        /// </summary>
        [DataMember(Name="RemovePageThumbnails")]
        public bool RemovePageThumbnails { get; set; } = false;

        /// <summary>
        /// Specifies whether the page PieceInfo dictionary used to hold private application data shall be removed.
        /// </summary>
        [DataMember(Name="RemovePagePieceInfo")]
        public bool RemovePagePieceInfo { get; set; } = false;

        /// <summary>
        /// Specifies the threshold value for the JBIG2 encoder pattern matching and substitution between 0 and 1. Any number lower than 1 may lead to lossy compression.
        /// </summary>
        [DataMember(Name="JBIG2PMSThreshold")]
        public float JBIG2PMSThreshold { get; set; } = 0.85F;

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
            return Equals(input as PdfReduceParameters);
        }

        /// <summary>
        /// Returns true if PdfReduceParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfReduceParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfReduceParameters input)
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
                    OutputVersion == input.OutputVersion ||
                    OutputVersion.Equals(input.OutputVersion)
                ) && 
                (
                    ImageQuality == input.ImageQuality ||
                    ImageQuality.Equals(input.ImageQuality)
                ) && 
                (
                    RecompressImages == input.RecompressImages ||
                    RecompressImages.Equals(input.RecompressImages)
                ) && 
                (
                    EnableColorDetection == input.EnableColorDetection ||
                    EnableColorDetection.Equals(input.EnableColorDetection)
                ) && 
                (
                    PackDocument == input.PackDocument ||
                    PackDocument.Equals(input.PackDocument)
                ) && 
                (
                    PackFonts == input.PackFonts ||
                    PackFonts.Equals(input.PackFonts)
                ) && 
                (
                    DownscaleImages == input.DownscaleImages ||
                    DownscaleImages.Equals(input.DownscaleImages)
                ) && 
                (
                    DownscaleResolution == input.DownscaleResolution ||
                    DownscaleResolution.Equals(input.DownscaleResolution)
                ) && 
                (
                    FastWebView == input.FastWebView ||
                    FastWebView.Equals(input.FastWebView)
                ) && 
                (
                    RemoveFormFields == input.RemoveFormFields ||
                    RemoveFormFields.Equals(input.RemoveFormFields)
                ) && 
                (
                    RemoveAnnotations == input.RemoveAnnotations ||
                    RemoveAnnotations.Equals(input.RemoveAnnotations)
                ) && 
                (
                    RemoveBookmarks == input.RemoveBookmarks ||
                    RemoveBookmarks.Equals(input.RemoveBookmarks)
                ) && 
                (
                    RemoveHyperlinks == input.RemoveHyperlinks ||
                    RemoveHyperlinks.Equals(input.RemoveHyperlinks)
                ) && 
                (
                    RemoveEmbeddedFiles == input.RemoveEmbeddedFiles ||
                    RemoveEmbeddedFiles.Equals(input.RemoveEmbeddedFiles)
                ) && 
                (
                    RemoveBlankPages == input.RemoveBlankPages ||
                    RemoveBlankPages.Equals(input.RemoveBlankPages)
                ) && 
                (
                    RemoveJavaScript == input.RemoveJavaScript ||
                    RemoveJavaScript.Equals(input.RemoveJavaScript)
                ) && 
                (
                    EnableJPEG2000 == input.EnableJPEG2000 ||
                    EnableJPEG2000.Equals(input.EnableJPEG2000)
                ) && 
                (
                    EnableJBIG2 == input.EnableJBIG2 ||
                    EnableJBIG2.Equals(input.EnableJBIG2)
                ) && 
                (
                    EnableCharRepair == input.EnableCharRepair ||
                    EnableCharRepair.Equals(input.EnableCharRepair)
                ) && 
                (
                    EnableMRC == input.EnableMRC ||
                    EnableMRC.Equals(input.EnableMRC)
                ) && 
                (
                    PreserveSmoothing == input.PreserveSmoothing ||
                    PreserveSmoothing.Equals(input.PreserveSmoothing)
                ) && 
                (
                    DownscaleResolutionMRC == input.DownscaleResolutionMRC ||
                    DownscaleResolutionMRC.Equals(input.DownscaleResolutionMRC)
                ) && 
                (
                    RemoveMetadata == input.RemoveMetadata ||
                    RemoveMetadata.Equals(input.RemoveMetadata)
                ) && 
                (
                    RemovePageThumbnails == input.RemovePageThumbnails ||
                    RemovePageThumbnails.Equals(input.RemovePageThumbnails)
                ) && 
                (
                    RemovePagePieceInfo == input.RemovePagePieceInfo ||
                    RemovePagePieceInfo.Equals(input.RemovePagePieceInfo)
                ) && 
                (
                    JBIG2PMSThreshold == input.JBIG2PMSThreshold ||
                    JBIG2PMSThreshold.Equals(input.JBIG2PMSThreshold)
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
                hashCode = hashCode * 59 + OutputVersion.GetHashCode();
                hashCode = hashCode * 59 + ImageQuality.GetHashCode();
                hashCode = hashCode * 59 + RecompressImages.GetHashCode();
                hashCode = hashCode * 59 + EnableColorDetection.GetHashCode();
                hashCode = hashCode * 59 + PackDocument.GetHashCode();
                hashCode = hashCode * 59 + PackFonts.GetHashCode();
                hashCode = hashCode * 59 + DownscaleImages.GetHashCode();
                hashCode = hashCode * 59 + DownscaleResolution.GetHashCode();
                hashCode = hashCode * 59 + FastWebView.GetHashCode();
                hashCode = hashCode * 59 + RemoveFormFields.GetHashCode();
                hashCode = hashCode * 59 + RemoveAnnotations.GetHashCode();
                hashCode = hashCode * 59 + RemoveBookmarks.GetHashCode();
                hashCode = hashCode * 59 + RemoveHyperlinks.GetHashCode();
                hashCode = hashCode * 59 + RemoveEmbeddedFiles.GetHashCode();
                hashCode = hashCode * 59 + RemoveBlankPages.GetHashCode();
                hashCode = hashCode * 59 + RemoveJavaScript.GetHashCode();
                hashCode = hashCode * 59 + EnableJPEG2000.GetHashCode();
                hashCode = hashCode * 59 + EnableJBIG2.GetHashCode();
                hashCode = hashCode * 59 + EnableCharRepair.GetHashCode();
                hashCode = hashCode * 59 + EnableMRC.GetHashCode();
                hashCode = hashCode * 59 + PreserveSmoothing.GetHashCode();
                hashCode = hashCode * 59 + DownscaleResolutionMRC.GetHashCode();
                hashCode = hashCode * 59 + RemoveMetadata.GetHashCode();
                hashCode = hashCode * 59 + RemovePageThumbnails.GetHashCode();
                hashCode = hashCode * 59 + RemovePagePieceInfo.GetHashCode();
                hashCode = hashCode * 59 + JBIG2PMSThreshold.GetHashCode();
                return hashCode;
            }
        }
    }

}
