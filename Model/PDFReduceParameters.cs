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
    /// Represents the parameters for a reduce action.
    /// </summary>
    [DataContract]
    public partial class PDFReduceParameters :  IEquatable<PDFReduceParameters>, IValidatableObject
    {
        /// <summary>
        /// Specifies the preferred version for the reduced PDF.
        /// </summary>
        /// <value>Specifies the preferred version for the reduced PDF.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OutputVersionEnum
        {
            /// <summary>
            /// Enum PdfVersionRetainExisting for value: PdfVersionRetainExisting
            /// </summary>
            [EnumMember(Value = "PdfVersionRetainExisting")]
            PdfVersionRetainExisting = 1,

            /// <summary>
            /// Enum PdfVersion14 for value: PdfVersion14
            /// </summary>
            [EnumMember(Value = "PdfVersion14")]
            PdfVersion14 = 2,

            /// <summary>
            /// Enum PdfVersion15 for value: PdfVersion15
            /// </summary>
            [EnumMember(Value = "PdfVersion15")]
            PdfVersion15 = 3,

            /// <summary>
            /// Enum PdfVersion16 for value: PdfVersion16
            /// </summary>
            [EnumMember(Value = "PdfVersion16")]
            PdfVersion16 = 4,

            /// <summary>
            /// Enum PdfVersion17 for value: PdfVersion17
            /// </summary>
            [EnumMember(Value = "PdfVersion17")]
            PdfVersion17 = 5

        }

        /// <summary>
        /// Specifies the preferred version for the reduced PDF.
        /// </summary>
        /// <value>Specifies the preferred version for the reduced PDF.</value>
        [DataMember(Name="OutputVersion", EmitDefaultValue=false)]
        public OutputVersionEnum? OutputVersion { get; set; }
        /// <summary>
        /// Specifies the quality to be used for the compression of the images from the PDF.
        /// </summary>
        /// <value>Specifies the quality to be used for the compression of the images from the PDF.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ImageQualityEnum
        {
            /// <summary>
            /// Enum ImageQualityLow for value: ImageQualityLow
            /// </summary>
            [EnumMember(Value = "ImageQualityLow")]
            ImageQualityLow = 1,

            /// <summary>
            /// Enum ImageQualityMedium for value: ImageQualityMedium
            /// </summary>
            [EnumMember(Value = "ImageQualityMedium")]
            ImageQualityMedium = 2,

            /// <summary>
            /// Enum ImageQualityHigh for value: ImageQualityHigh
            /// </summary>
            [EnumMember(Value = "ImageQualityHigh")]
            ImageQualityHigh = 3,

            /// <summary>
            /// Enum ImageQualityVeryHigh for value: ImageQualityVeryHigh
            /// </summary>
            [EnumMember(Value = "ImageQualityVeryHigh")]
            ImageQualityVeryHigh = 4

        }

        /// <summary>
        /// Specifies the quality to be used for the compression of the images from the PDF.
        /// </summary>
        /// <value>Specifies the quality to be used for the compression of the images from the PDF.</value>
        [DataMember(Name="ImageQuality", EmitDefaultValue=false)]
        public ImageQualityEnum? ImageQuality { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFReduceParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFReduceParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFReduceParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="outputVersion">Specifies the preferred version for the reduced PDF. (default to OutputVersionEnum.PdfVersion15).</param>
        /// <param name="imageQuality">Specifies the quality to be used for the compression of the images from the PDF. (default to ImageQualityEnum.ImageQualityMedium).</param>
        /// <param name="recompressImages">Specifies whether the images from the PDF shall be recompressed. (default to true).</param>
        /// <param name="enableColorDetection">Specifies whether color detection must be performed on the images from the PDF. (default to true).</param>
        /// <param name="packDocument">Specifies whether the PDF shall be packed when saved in order to reduce its size. (default to true).</param>
        /// <param name="packFonts">Specifies whether the PDF fonts must be packed in order to reduce their size. (default to true).</param>
        /// <param name="downscaleImages">Specifies whether the images from the PDF shall be downscaled. (default to true).</param>
        /// <param name="downscaleResolution">Specifies the resolution to be used to downscale images. (default to 150).</param>
        /// <param name="fastWebView">Specifies whether the PDF shall be optimized for online distribution. (default to false).</param>
        /// <param name="removeFormFields">Specifies whether the form fields shall be removed from the PDF. (default to false).</param>
        /// <param name="removeAnnotations">Specifies whether the annotations shall be removed from the PDF. (default to false).</param>
        /// <param name="removeBookmarks">Specifies whether the bookmarks shall be removed from the PDF. (default to false).</param>
        /// <param name="removeHyperlinks">Specifies whether the hyperlinks shall be removed from the PDF. (default to false).</param>
        /// <param name="removeEmbeddedFiles">Specifies whether the embedded files shall be removed from the PDF. (default to false).</param>
        /// <param name="removeBlankPages">Specifies whether the blank pages shall be removed. (default to false).</param>
        /// <param name="removeJavaScript">Specifies whether the JavaScript shall be removed. (default to false).</param>
        /// <param name="enableJPEG2000">Specifies whether the JPEG2000 compression scheme shall be used to compress the images of the PDF. (default to true).</param>
        /// <param name="enableJBIG2">Specifies whether the JBIG2 compression scheme shall be used to compress the bitonal images of the PDF. (default to true).</param>
        /// <param name="enableCharRepair">Specifies whether characters repairing shall be performed during bitonal conversion. (default to false).</param>
        /// <param name="enableMRC">Specifies whether MRC shall be used for compressing the PDF contents. (default to false).</param>
        /// <param name="preserveSmoothing">Specifies if the MRC engine shall try to preserve smoothing between different layers. (default to false).</param>
        /// <param name="downscaleResolutionMRC">Specifies the resolution for downscaling the background layer by the MRC engine, if any. (default to 100).</param>
        public PDFReduceParameters(string fileId = default(string), OutputVersionEnum? outputVersion = OutputVersionEnum.PdfVersion15, ImageQualityEnum? imageQuality = ImageQualityEnum.ImageQualityMedium, bool? recompressImages = true, bool? enableColorDetection = true, bool? packDocument = true, bool? packFonts = true, bool? downscaleImages = true, int? downscaleResolution = 150, bool? fastWebView = false, bool? removeFormFields = false, bool? removeAnnotations = false, bool? removeBookmarks = false, bool? removeHyperlinks = false, bool? removeEmbeddedFiles = false, bool? removeBlankPages = false, bool? removeJavaScript = false, bool? enableJPEG2000 = true, bool? enableJBIG2 = true, bool? enableCharRepair = false, bool? enableMRC = false, bool? preserveSmoothing = false, int? downscaleResolutionMRC = 100)
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for PDFReduceParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            
            // use default value if no "outputVersion" provided
            if (outputVersion == null)
            {
                this.OutputVersion = OutputVersionEnum.PdfVersion15;
            }
            else
            {
                this.OutputVersion = outputVersion;
            }
            // use default value if no "imageQuality" provided
            if (imageQuality == null)
            {
                this.ImageQuality = ImageQualityEnum.ImageQualityMedium;
            }
            else
            {
                this.ImageQuality = imageQuality;
            }
            // use default value if no "recompressImages" provided
            if (recompressImages == null)
            {
                this.RecompressImages = true;
            }
            else
            {
                this.RecompressImages = recompressImages;
            }
            // use default value if no "enableColorDetection" provided
            if (enableColorDetection == null)
            {
                this.EnableColorDetection = true;
            }
            else
            {
                this.EnableColorDetection = enableColorDetection;
            }
            // use default value if no "packDocument" provided
            if (packDocument == null)
            {
                this.PackDocument = true;
            }
            else
            {
                this.PackDocument = packDocument;
            }
            // use default value if no "packFonts" provided
            if (packFonts == null)
            {
                this.PackFonts = true;
            }
            else
            {
                this.PackFonts = packFonts;
            }
            // use default value if no "downscaleImages" provided
            if (downscaleImages == null)
            {
                this.DownscaleImages = true;
            }
            else
            {
                this.DownscaleImages = downscaleImages;
            }
            // use default value if no "downscaleResolution" provided
            if (downscaleResolution == null)
            {
                this.DownscaleResolution = 150;
            }
            else
            {
                this.DownscaleResolution = downscaleResolution;
            }
            // use default value if no "fastWebView" provided
            if (fastWebView == null)
            {
                this.FastWebView = false;
            }
            else
            {
                this.FastWebView = fastWebView;
            }
            // use default value if no "removeFormFields" provided
            if (removeFormFields == null)
            {
                this.RemoveFormFields = false;
            }
            else
            {
                this.RemoveFormFields = removeFormFields;
            }
            // use default value if no "removeAnnotations" provided
            if (removeAnnotations == null)
            {
                this.RemoveAnnotations = false;
            }
            else
            {
                this.RemoveAnnotations = removeAnnotations;
            }
            // use default value if no "removeBookmarks" provided
            if (removeBookmarks == null)
            {
                this.RemoveBookmarks = false;
            }
            else
            {
                this.RemoveBookmarks = removeBookmarks;
            }
            // use default value if no "removeHyperlinks" provided
            if (removeHyperlinks == null)
            {
                this.RemoveHyperlinks = false;
            }
            else
            {
                this.RemoveHyperlinks = removeHyperlinks;
            }
            // use default value if no "removeEmbeddedFiles" provided
            if (removeEmbeddedFiles == null)
            {
                this.RemoveEmbeddedFiles = false;
            }
            else
            {
                this.RemoveEmbeddedFiles = removeEmbeddedFiles;
            }
            // use default value if no "removeBlankPages" provided
            if (removeBlankPages == null)
            {
                this.RemoveBlankPages = false;
            }
            else
            {
                this.RemoveBlankPages = removeBlankPages;
            }
            // use default value if no "removeJavaScript" provided
            if (removeJavaScript == null)
            {
                this.RemoveJavaScript = false;
            }
            else
            {
                this.RemoveJavaScript = removeJavaScript;
            }
            // use default value if no "enableJPEG2000" provided
            if (enableJPEG2000 == null)
            {
                this.EnableJPEG2000 = true;
            }
            else
            {
                this.EnableJPEG2000 = enableJPEG2000;
            }
            // use default value if no "enableJBIG2" provided
            if (enableJBIG2 == null)
            {
                this.EnableJBIG2 = true;
            }
            else
            {
                this.EnableJBIG2 = enableJBIG2;
            }
            // use default value if no "enableCharRepair" provided
            if (enableCharRepair == null)
            {
                this.EnableCharRepair = false;
            }
            else
            {
                this.EnableCharRepair = enableCharRepair;
            }
            // use default value if no "enableMRC" provided
            if (enableMRC == null)
            {
                this.EnableMRC = false;
            }
            else
            {
                this.EnableMRC = enableMRC;
            }
            // use default value if no "preserveSmoothing" provided
            if (preserveSmoothing == null)
            {
                this.PreserveSmoothing = false;
            }
            else
            {
                this.PreserveSmoothing = preserveSmoothing;
            }
            // use default value if no "downscaleResolutionMRC" provided
            if (downscaleResolutionMRC == null)
            {
                this.DownscaleResolutionMRC = 100;
            }
            else
            {
                this.DownscaleResolutionMRC = downscaleResolutionMRC;
            }
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }



        /// <summary>
        /// Specifies whether the images from the PDF shall be recompressed.
        /// </summary>
        /// <value>Specifies whether the images from the PDF shall be recompressed.</value>
        [DataMember(Name="RecompressImages", EmitDefaultValue=false)]
        public bool? RecompressImages { get; set; }

        /// <summary>
        /// Specifies whether color detection must be performed on the images from the PDF.
        /// </summary>
        /// <value>Specifies whether color detection must be performed on the images from the PDF.</value>
        [DataMember(Name="EnableColorDetection", EmitDefaultValue=false)]
        public bool? EnableColorDetection { get; set; }

        /// <summary>
        /// Specifies whether the PDF shall be packed when saved in order to reduce its size.
        /// </summary>
        /// <value>Specifies whether the PDF shall be packed when saved in order to reduce its size.</value>
        [DataMember(Name="PackDocument", EmitDefaultValue=false)]
        public bool? PackDocument { get; set; }

        /// <summary>
        /// Specifies whether the PDF fonts must be packed in order to reduce their size.
        /// </summary>
        /// <value>Specifies whether the PDF fonts must be packed in order to reduce their size.</value>
        [DataMember(Name="PackFonts", EmitDefaultValue=false)]
        public bool? PackFonts { get; set; }

        /// <summary>
        /// Specifies whether the images from the PDF shall be downscaled.
        /// </summary>
        /// <value>Specifies whether the images from the PDF shall be downscaled.</value>
        [DataMember(Name="DownscaleImages", EmitDefaultValue=false)]
        public bool? DownscaleImages { get; set; }

        /// <summary>
        /// Specifies the resolution to be used to downscale images.
        /// </summary>
        /// <value>Specifies the resolution to be used to downscale images.</value>
        [DataMember(Name="DownscaleResolution", EmitDefaultValue=false)]
        public int? DownscaleResolution { get; set; }

        /// <summary>
        /// Specifies whether the PDF shall be optimized for online distribution.
        /// </summary>
        /// <value>Specifies whether the PDF shall be optimized for online distribution.</value>
        [DataMember(Name="FastWebView", EmitDefaultValue=false)]
        public bool? FastWebView { get; set; }

        /// <summary>
        /// Specifies whether the form fields shall be removed from the PDF.
        /// </summary>
        /// <value>Specifies whether the form fields shall be removed from the PDF.</value>
        [DataMember(Name="RemoveFormFields", EmitDefaultValue=false)]
        public bool? RemoveFormFields { get; set; }

        /// <summary>
        /// Specifies whether the annotations shall be removed from the PDF.
        /// </summary>
        /// <value>Specifies whether the annotations shall be removed from the PDF.</value>
        [DataMember(Name="RemoveAnnotations", EmitDefaultValue=false)]
        public bool? RemoveAnnotations { get; set; }

        /// <summary>
        /// Specifies whether the bookmarks shall be removed from the PDF.
        /// </summary>
        /// <value>Specifies whether the bookmarks shall be removed from the PDF.</value>
        [DataMember(Name="RemoveBookmarks", EmitDefaultValue=false)]
        public bool? RemoveBookmarks { get; set; }

        /// <summary>
        /// Specifies whether the hyperlinks shall be removed from the PDF.
        /// </summary>
        /// <value>Specifies whether the hyperlinks shall be removed from the PDF.</value>
        [DataMember(Name="RemoveHyperlinks", EmitDefaultValue=false)]
        public bool? RemoveHyperlinks { get; set; }

        /// <summary>
        /// Specifies whether the embedded files shall be removed from the PDF.
        /// </summary>
        /// <value>Specifies whether the embedded files shall be removed from the PDF.</value>
        [DataMember(Name="RemoveEmbeddedFiles", EmitDefaultValue=false)]
        public bool? RemoveEmbeddedFiles { get; set; }

        /// <summary>
        /// Specifies whether the blank pages shall be removed.
        /// </summary>
        /// <value>Specifies whether the blank pages shall be removed.</value>
        [DataMember(Name="RemoveBlankPages", EmitDefaultValue=false)]
        public bool? RemoveBlankPages { get; set; }

        /// <summary>
        /// Specifies whether the JavaScript shall be removed.
        /// </summary>
        /// <value>Specifies whether the JavaScript shall be removed.</value>
        [DataMember(Name="RemoveJavaScript", EmitDefaultValue=false)]
        public bool? RemoveJavaScript { get; set; }

        /// <summary>
        /// Specifies whether the JPEG2000 compression scheme shall be used to compress the images of the PDF.
        /// </summary>
        /// <value>Specifies whether the JPEG2000 compression scheme shall be used to compress the images of the PDF.</value>
        [DataMember(Name="EnableJPEG2000", EmitDefaultValue=false)]
        public bool? EnableJPEG2000 { get; set; }

        /// <summary>
        /// Specifies whether the JBIG2 compression scheme shall be used to compress the bitonal images of the PDF.
        /// </summary>
        /// <value>Specifies whether the JBIG2 compression scheme shall be used to compress the bitonal images of the PDF.</value>
        [DataMember(Name="EnableJBIG2", EmitDefaultValue=false)]
        public bool? EnableJBIG2 { get; set; }

        /// <summary>
        /// Specifies whether characters repairing shall be performed during bitonal conversion.
        /// </summary>
        /// <value>Specifies whether characters repairing shall be performed during bitonal conversion.</value>
        [DataMember(Name="EnableCharRepair", EmitDefaultValue=false)]
        public bool? EnableCharRepair { get; set; }

        /// <summary>
        /// Specifies whether MRC shall be used for compressing the PDF contents.
        /// </summary>
        /// <value>Specifies whether MRC shall be used for compressing the PDF contents.</value>
        [DataMember(Name="EnableMRC", EmitDefaultValue=false)]
        public bool? EnableMRC { get; set; }

        /// <summary>
        /// Specifies if the MRC engine shall try to preserve smoothing between different layers.
        /// </summary>
        /// <value>Specifies if the MRC engine shall try to preserve smoothing between different layers.</value>
        [DataMember(Name="PreserveSmoothing", EmitDefaultValue=false)]
        public bool? PreserveSmoothing { get; set; }

        /// <summary>
        /// Specifies the resolution for downscaling the background layer by the MRC engine, if any.
        /// </summary>
        /// <value>Specifies the resolution for downscaling the background layer by the MRC engine, if any.</value>
        [DataMember(Name="DownscaleResolutionMRC", EmitDefaultValue=false)]
        public int? DownscaleResolutionMRC { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFReduceParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  OutputVersion: ").Append(OutputVersion).Append("\n");
            sb.Append("  ImageQuality: ").Append(ImageQuality).Append("\n");
            sb.Append("  RecompressImages: ").Append(RecompressImages).Append("\n");
            sb.Append("  EnableColorDetection: ").Append(EnableColorDetection).Append("\n");
            sb.Append("  PackDocument: ").Append(PackDocument).Append("\n");
            sb.Append("  PackFonts: ").Append(PackFonts).Append("\n");
            sb.Append("  DownscaleImages: ").Append(DownscaleImages).Append("\n");
            sb.Append("  DownscaleResolution: ").Append(DownscaleResolution).Append("\n");
            sb.Append("  FastWebView: ").Append(FastWebView).Append("\n");
            sb.Append("  RemoveFormFields: ").Append(RemoveFormFields).Append("\n");
            sb.Append("  RemoveAnnotations: ").Append(RemoveAnnotations).Append("\n");
            sb.Append("  RemoveBookmarks: ").Append(RemoveBookmarks).Append("\n");
            sb.Append("  RemoveHyperlinks: ").Append(RemoveHyperlinks).Append("\n");
            sb.Append("  RemoveEmbeddedFiles: ").Append(RemoveEmbeddedFiles).Append("\n");
            sb.Append("  RemoveBlankPages: ").Append(RemoveBlankPages).Append("\n");
            sb.Append("  RemoveJavaScript: ").Append(RemoveJavaScript).Append("\n");
            sb.Append("  EnableJPEG2000: ").Append(EnableJPEG2000).Append("\n");
            sb.Append("  EnableJBIG2: ").Append(EnableJBIG2).Append("\n");
            sb.Append("  EnableCharRepair: ").Append(EnableCharRepair).Append("\n");
            sb.Append("  EnableMRC: ").Append(EnableMRC).Append("\n");
            sb.Append("  PreserveSmoothing: ").Append(PreserveSmoothing).Append("\n");
            sb.Append("  DownscaleResolutionMRC: ").Append(DownscaleResolutionMRC).Append("\n");
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
            return this.Equals(input as PDFReduceParameters);
        }

        /// <summary>
        /// Returns true if PDFReduceParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFReduceParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFReduceParameters input)
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
                    this.OutputVersion == input.OutputVersion ||
                    (this.OutputVersion != null &&
                    this.OutputVersion.Equals(input.OutputVersion))
                ) && 
                (
                    this.ImageQuality == input.ImageQuality ||
                    (this.ImageQuality != null &&
                    this.ImageQuality.Equals(input.ImageQuality))
                ) && 
                (
                    this.RecompressImages == input.RecompressImages ||
                    (this.RecompressImages != null &&
                    this.RecompressImages.Equals(input.RecompressImages))
                ) && 
                (
                    this.EnableColorDetection == input.EnableColorDetection ||
                    (this.EnableColorDetection != null &&
                    this.EnableColorDetection.Equals(input.EnableColorDetection))
                ) && 
                (
                    this.PackDocument == input.PackDocument ||
                    (this.PackDocument != null &&
                    this.PackDocument.Equals(input.PackDocument))
                ) && 
                (
                    this.PackFonts == input.PackFonts ||
                    (this.PackFonts != null &&
                    this.PackFonts.Equals(input.PackFonts))
                ) && 
                (
                    this.DownscaleImages == input.DownscaleImages ||
                    (this.DownscaleImages != null &&
                    this.DownscaleImages.Equals(input.DownscaleImages))
                ) && 
                (
                    this.DownscaleResolution == input.DownscaleResolution ||
                    (this.DownscaleResolution != null &&
                    this.DownscaleResolution.Equals(input.DownscaleResolution))
                ) && 
                (
                    this.FastWebView == input.FastWebView ||
                    (this.FastWebView != null &&
                    this.FastWebView.Equals(input.FastWebView))
                ) && 
                (
                    this.RemoveFormFields == input.RemoveFormFields ||
                    (this.RemoveFormFields != null &&
                    this.RemoveFormFields.Equals(input.RemoveFormFields))
                ) && 
                (
                    this.RemoveAnnotations == input.RemoveAnnotations ||
                    (this.RemoveAnnotations != null &&
                    this.RemoveAnnotations.Equals(input.RemoveAnnotations))
                ) && 
                (
                    this.RemoveBookmarks == input.RemoveBookmarks ||
                    (this.RemoveBookmarks != null &&
                    this.RemoveBookmarks.Equals(input.RemoveBookmarks))
                ) && 
                (
                    this.RemoveHyperlinks == input.RemoveHyperlinks ||
                    (this.RemoveHyperlinks != null &&
                    this.RemoveHyperlinks.Equals(input.RemoveHyperlinks))
                ) && 
                (
                    this.RemoveEmbeddedFiles == input.RemoveEmbeddedFiles ||
                    (this.RemoveEmbeddedFiles != null &&
                    this.RemoveEmbeddedFiles.Equals(input.RemoveEmbeddedFiles))
                ) && 
                (
                    this.RemoveBlankPages == input.RemoveBlankPages ||
                    (this.RemoveBlankPages != null &&
                    this.RemoveBlankPages.Equals(input.RemoveBlankPages))
                ) && 
                (
                    this.RemoveJavaScript == input.RemoveJavaScript ||
                    (this.RemoveJavaScript != null &&
                    this.RemoveJavaScript.Equals(input.RemoveJavaScript))
                ) && 
                (
                    this.EnableJPEG2000 == input.EnableJPEG2000 ||
                    (this.EnableJPEG2000 != null &&
                    this.EnableJPEG2000.Equals(input.EnableJPEG2000))
                ) && 
                (
                    this.EnableJBIG2 == input.EnableJBIG2 ||
                    (this.EnableJBIG2 != null &&
                    this.EnableJBIG2.Equals(input.EnableJBIG2))
                ) && 
                (
                    this.EnableCharRepair == input.EnableCharRepair ||
                    (this.EnableCharRepair != null &&
                    this.EnableCharRepair.Equals(input.EnableCharRepair))
                ) && 
                (
                    this.EnableMRC == input.EnableMRC ||
                    (this.EnableMRC != null &&
                    this.EnableMRC.Equals(input.EnableMRC))
                ) && 
                (
                    this.PreserveSmoothing == input.PreserveSmoothing ||
                    (this.PreserveSmoothing != null &&
                    this.PreserveSmoothing.Equals(input.PreserveSmoothing))
                ) && 
                (
                    this.DownscaleResolutionMRC == input.DownscaleResolutionMRC ||
                    (this.DownscaleResolutionMRC != null &&
                    this.DownscaleResolutionMRC.Equals(input.DownscaleResolutionMRC))
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
                if (this.OutputVersion != null)
                    hashCode = hashCode * 59 + this.OutputVersion.GetHashCode();
                if (this.ImageQuality != null)
                    hashCode = hashCode * 59 + this.ImageQuality.GetHashCode();
                if (this.RecompressImages != null)
                    hashCode = hashCode * 59 + this.RecompressImages.GetHashCode();
                if (this.EnableColorDetection != null)
                    hashCode = hashCode * 59 + this.EnableColorDetection.GetHashCode();
                if (this.PackDocument != null)
                    hashCode = hashCode * 59 + this.PackDocument.GetHashCode();
                if (this.PackFonts != null)
                    hashCode = hashCode * 59 + this.PackFonts.GetHashCode();
                if (this.DownscaleImages != null)
                    hashCode = hashCode * 59 + this.DownscaleImages.GetHashCode();
                if (this.DownscaleResolution != null)
                    hashCode = hashCode * 59 + this.DownscaleResolution.GetHashCode();
                if (this.FastWebView != null)
                    hashCode = hashCode * 59 + this.FastWebView.GetHashCode();
                if (this.RemoveFormFields != null)
                    hashCode = hashCode * 59 + this.RemoveFormFields.GetHashCode();
                if (this.RemoveAnnotations != null)
                    hashCode = hashCode * 59 + this.RemoveAnnotations.GetHashCode();
                if (this.RemoveBookmarks != null)
                    hashCode = hashCode * 59 + this.RemoveBookmarks.GetHashCode();
                if (this.RemoveHyperlinks != null)
                    hashCode = hashCode * 59 + this.RemoveHyperlinks.GetHashCode();
                if (this.RemoveEmbeddedFiles != null)
                    hashCode = hashCode * 59 + this.RemoveEmbeddedFiles.GetHashCode();
                if (this.RemoveBlankPages != null)
                    hashCode = hashCode * 59 + this.RemoveBlankPages.GetHashCode();
                if (this.RemoveJavaScript != null)
                    hashCode = hashCode * 59 + this.RemoveJavaScript.GetHashCode();
                if (this.EnableJPEG2000 != null)
                    hashCode = hashCode * 59 + this.EnableJPEG2000.GetHashCode();
                if (this.EnableJBIG2 != null)
                    hashCode = hashCode * 59 + this.EnableJBIG2.GetHashCode();
                if (this.EnableCharRepair != null)
                    hashCode = hashCode * 59 + this.EnableCharRepair.GetHashCode();
                if (this.EnableMRC != null)
                    hashCode = hashCode * 59 + this.EnableMRC.GetHashCode();
                if (this.PreserveSmoothing != null)
                    hashCode = hashCode * 59 + this.PreserveSmoothing.GetHashCode();
                if (this.DownscaleResolutionMRC != null)
                    hashCode = hashCode * 59 + this.DownscaleResolutionMRC.GetHashCode();
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
