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
            /// Enum PdfVersionRetainExisting for "PdfVersionRetainExisting"
            /// </summary>
            [EnumMember(Value = "PdfVersionRetainExisting")]
            PdfVersionRetainExisting = 1,
            
            /// <summary>
            /// Enum PdfVersion14 for "PdfVersion14"
            /// </summary>
            [EnumMember(Value = "PdfVersion14")]
            PdfVersion14 = 2,
            
            /// <summary>
            /// Enum PdfVersion15 for "PdfVersion15"
            /// </summary>
            [EnumMember(Value = "PdfVersion15")]
            PdfVersion15 = 3,
            
            /// <summary>
            /// Enum PdfVersion16 for "PdfVersion16"
            /// </summary>
            [EnumMember(Value = "PdfVersion16")]
            PdfVersion16 = 4,
            
            /// <summary>
            /// Enum PdfVersion17 for "PdfVersion17"
            /// </summary>
            [EnumMember(Value = "PdfVersion17")]
            PdfVersion17 = 5
        }

        /// <summary>
        /// Specifies the preferred version for the reduced PDF.
        /// </summary>
        /// <value>Specifies the preferred version for the reduced PDF.</value>
        [DataMember(Name="outputVersion", EmitDefaultValue=false)]
        public OutputVersionEnum? OutputVersion { get; set; }
        /// <summary>
        /// Specifies the quality to be used for the compression of the images from the PDF.
        /// </summary>
        /// <value>Specifies the quality to be used for the compression of the images from the PDF.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ImageQualityEnum
        {
            
            /// <summary>
            /// Enum ImageQualityLow for "ImageQualityLow"
            /// </summary>
            [EnumMember(Value = "ImageQualityLow")]
            ImageQualityLow = 1,
            
            /// <summary>
            /// Enum ImageQualityMedium for "ImageQualityMedium"
            /// </summary>
            [EnumMember(Value = "ImageQualityMedium")]
            ImageQualityMedium = 2,
            
            /// <summary>
            /// Enum ImageQualityHigh for "ImageQualityHigh"
            /// </summary>
            [EnumMember(Value = "ImageQualityHigh")]
            ImageQualityHigh = 3,
            
            /// <summary>
            /// Enum ImageQualityVeryHigh for "ImageQualityVeryHigh"
            /// </summary>
            [EnumMember(Value = "ImageQualityVeryHigh")]
            ImageQualityVeryHigh = 4
        }

        /// <summary>
        /// Specifies the quality to be used for the compression of the images from the PDF.
        /// </summary>
        /// <value>Specifies the quality to be used for the compression of the images from the PDF.</value>
        [DataMember(Name="imageQuality", EmitDefaultValue=false)]
        public ImageQualityEnum? ImageQuality { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFReduceParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFReduceParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFReduceParameters" /> class.
        /// </summary>
        /// <param name="FileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="OutputVersion">Specifies the preferred version for the reduced PDF. (default to OutputVersionEnum.PdfVersion15).</param>
        /// <param name="ImageQuality">Specifies the quality to be used for the compression of the images from the PDF. (default to ImageQualityEnum.ImageQualityMedium).</param>
        /// <param name="RecompressImages">Specifies whether the images from the PDF shall be recompressed. (default to true).</param>
        /// <param name="EnableColorDetection">Specifies whether color detection must be performed on the images from the PDF. (default to true).</param>
        /// <param name="PackDocument">Specifies whether the PDF shall be packed when saved in order to reduce its size. (default to true).</param>
        /// <param name="PackFonts">Specifies whether the PDF fonts must be packed in order to reduce their size. (default to true).</param>
        /// <param name="DownscaleImages">Specifies whether the images from the PDF shall be downscaled. (default to true).</param>
        /// <param name="DownscaleResolution">Specifies the scale percentage for the images downscaling. (default to 150).</param>
        /// <param name="FastWebView">Specifies whether the PDF shall be optimized for online distribution. (default to false).</param>
        /// <param name="RemoveFormFields">Specifies whether the form fields shall be removed from the PDF. (default to false).</param>
        /// <param name="RemoveAnnotations">Specifies whether the annotations shall be removed from the PDF. (default to false).</param>
        /// <param name="RemoveBookmarks">Specifies whether the bookmarks shall be removed from the PDF. (default to false).</param>
        /// <param name="RemoveHyperlinks">Specifies whether the hyperlinks shall be removed from the PDF. (default to false).</param>
        /// <param name="RemoveEmbeddedFiles">Specifies whether the embedded files shall be removed from the PDF. (default to false).</param>
        /// <param name="RemoveBlankPages">Specifies whether the blank pages shall be removed. (default to false).</param>
        /// <param name="RemoveJavaScript">Specifies whether the JavaScript shall be removed. (default to false).</param>
        /// <param name="EnableJPEG2000">Specifies whether the JPEG2000 compression scheme shall be used to compress the images of the PDF. (default to true).</param>
        /// <param name="EnableJBIG2">Specifies whether the JBIG2 compression scheme shall be used to compress the bitonal images of the PDF. (default to true).</param>
        /// <param name="EnableCharRepair">Specifies whether characters repairing shall be performed during bitonal conversion. (default to false).</param>
        /// <param name="EnableMRC">Specifies whether MRC shall be used for compressing the PDF contents. (default to false).</param>
        public PDFReduceParameters(string FileId = default(string), OutputVersionEnum? OutputVersion = OutputVersionEnum.PdfVersion15, ImageQualityEnum? ImageQuality = ImageQualityEnum.ImageQualityMedium, bool? RecompressImages = true, bool? EnableColorDetection = true, bool? PackDocument = true, bool? PackFonts = true, bool? DownscaleImages = true, int? DownscaleResolution = 150, bool? FastWebView = false, bool? RemoveFormFields = false, bool? RemoveAnnotations = false, bool? RemoveBookmarks = false, bool? RemoveHyperlinks = false, bool? RemoveEmbeddedFiles = false, bool? RemoveBlankPages = false, bool? RemoveJavaScript = false, bool? EnableJPEG2000 = true, bool? EnableJBIG2 = true, bool? EnableCharRepair = false, bool? EnableMRC = false)
        {
            // to ensure "FileId" is required (not null)
            if (FileId == null)
            {
                throw new InvalidDataException("FileId is a required property for PDFReduceParameters and cannot be null");
            }
            else
            {
                this.FileId = FileId;
            }
            // use default value if no "OutputVersion" provided
            if (OutputVersion == null)
            {
                this.OutputVersion = OutputVersionEnum.PdfVersion15;
            }
            else
            {
                this.OutputVersion = OutputVersion;
            }
            // use default value if no "ImageQuality" provided
            if (ImageQuality == null)
            {
                this.ImageQuality = ImageQualityEnum.ImageQualityMedium;
            }
            else
            {
                this.ImageQuality = ImageQuality;
            }
            // use default value if no "RecompressImages" provided
            if (RecompressImages == null)
            {
                this.RecompressImages = true;
            }
            else
            {
                this.RecompressImages = RecompressImages;
            }
            // use default value if no "EnableColorDetection" provided
            if (EnableColorDetection == null)
            {
                this.EnableColorDetection = true;
            }
            else
            {
                this.EnableColorDetection = EnableColorDetection;
            }
            // use default value if no "PackDocument" provided
            if (PackDocument == null)
            {
                this.PackDocument = true;
            }
            else
            {
                this.PackDocument = PackDocument;
            }
            // use default value if no "PackFonts" provided
            if (PackFonts == null)
            {
                this.PackFonts = true;
            }
            else
            {
                this.PackFonts = PackFonts;
            }
            // use default value if no "DownscaleImages" provided
            if (DownscaleImages == null)
            {
                this.DownscaleImages = true;
            }
            else
            {
                this.DownscaleImages = DownscaleImages;
            }
            // use default value if no "DownscaleResolution" provided
            if (DownscaleResolution == null)
            {
                this.DownscaleResolution = 150;
            }
            else
            {
                this.DownscaleResolution = DownscaleResolution;
            }
            // use default value if no "FastWebView" provided
            if (FastWebView == null)
            {
                this.FastWebView = false;
            }
            else
            {
                this.FastWebView = FastWebView;
            }
            // use default value if no "RemoveFormFields" provided
            if (RemoveFormFields == null)
            {
                this.RemoveFormFields = false;
            }
            else
            {
                this.RemoveFormFields = RemoveFormFields;
            }
            // use default value if no "RemoveAnnotations" provided
            if (RemoveAnnotations == null)
            {
                this.RemoveAnnotations = false;
            }
            else
            {
                this.RemoveAnnotations = RemoveAnnotations;
            }
            // use default value if no "RemoveBookmarks" provided
            if (RemoveBookmarks == null)
            {
                this.RemoveBookmarks = false;
            }
            else
            {
                this.RemoveBookmarks = RemoveBookmarks;
            }
            // use default value if no "RemoveHyperlinks" provided
            if (RemoveHyperlinks == null)
            {
                this.RemoveHyperlinks = false;
            }
            else
            {
                this.RemoveHyperlinks = RemoveHyperlinks;
            }
            // use default value if no "RemoveEmbeddedFiles" provided
            if (RemoveEmbeddedFiles == null)
            {
                this.RemoveEmbeddedFiles = false;
            }
            else
            {
                this.RemoveEmbeddedFiles = RemoveEmbeddedFiles;
            }
            // use default value if no "RemoveBlankPages" provided
            if (RemoveBlankPages == null)
            {
                this.RemoveBlankPages = false;
            }
            else
            {
                this.RemoveBlankPages = RemoveBlankPages;
            }
            // use default value if no "RemoveJavaScript" provided
            if (RemoveJavaScript == null)
            {
                this.RemoveJavaScript = false;
            }
            else
            {
                this.RemoveJavaScript = RemoveJavaScript;
            }
            // use default value if no "EnableJPEG2000" provided
            if (EnableJPEG2000 == null)
            {
                this.EnableJPEG2000 = true;
            }
            else
            {
                this.EnableJPEG2000 = EnableJPEG2000;
            }
            // use default value if no "EnableJBIG2" provided
            if (EnableJBIG2 == null)
            {
                this.EnableJBIG2 = true;
            }
            else
            {
                this.EnableJBIG2 = EnableJBIG2;
            }
            // use default value if no "EnableCharRepair" provided
            if (EnableCharRepair == null)
            {
                this.EnableCharRepair = false;
            }
            else
            {
                this.EnableCharRepair = EnableCharRepair;
            }
            // use default value if no "EnableMRC" provided
            if (EnableMRC == null)
            {
                this.EnableMRC = false;
            }
            else
            {
                this.EnableMRC = EnableMRC;
            }
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="fileId", EmitDefaultValue=false)]
        public string FileId { get; set; }



        /// <summary>
        /// Specifies whether the images from the PDF shall be recompressed.
        /// </summary>
        /// <value>Specifies whether the images from the PDF shall be recompressed.</value>
        [DataMember(Name="recompressImages", EmitDefaultValue=false)]
        public bool? RecompressImages { get; set; }

        /// <summary>
        /// Specifies whether color detection must be performed on the images from the PDF.
        /// </summary>
        /// <value>Specifies whether color detection must be performed on the images from the PDF.</value>
        [DataMember(Name="enableColorDetection", EmitDefaultValue=false)]
        public bool? EnableColorDetection { get; set; }

        /// <summary>
        /// Specifies whether the PDF shall be packed when saved in order to reduce its size.
        /// </summary>
        /// <value>Specifies whether the PDF shall be packed when saved in order to reduce its size.</value>
        [DataMember(Name="packDocument", EmitDefaultValue=false)]
        public bool? PackDocument { get; set; }

        /// <summary>
        /// Specifies whether the PDF fonts must be packed in order to reduce their size.
        /// </summary>
        /// <value>Specifies whether the PDF fonts must be packed in order to reduce their size.</value>
        [DataMember(Name="packFonts", EmitDefaultValue=false)]
        public bool? PackFonts { get; set; }

        /// <summary>
        /// Specifies whether the images from the PDF shall be downscaled.
        /// </summary>
        /// <value>Specifies whether the images from the PDF shall be downscaled.</value>
        [DataMember(Name="downscaleImages", EmitDefaultValue=false)]
        public bool? DownscaleImages { get; set; }

        /// <summary>
        /// Specifies the scale percentage for the images downscaling.
        /// </summary>
        /// <value>Specifies the scale percentage for the images downscaling.</value>
        [DataMember(Name="downscaleResolution", EmitDefaultValue=false)]
        public int? DownscaleResolution { get; set; }

        /// <summary>
        /// Specifies whether the PDF shall be optimized for online distribution.
        /// </summary>
        /// <value>Specifies whether the PDF shall be optimized for online distribution.</value>
        [DataMember(Name="fastWebView", EmitDefaultValue=false)]
        public bool? FastWebView { get; set; }

        /// <summary>
        /// Specifies whether the form fields shall be removed from the PDF.
        /// </summary>
        /// <value>Specifies whether the form fields shall be removed from the PDF.</value>
        [DataMember(Name="removeFormFields", EmitDefaultValue=false)]
        public bool? RemoveFormFields { get; set; }

        /// <summary>
        /// Specifies whether the annotations shall be removed from the PDF.
        /// </summary>
        /// <value>Specifies whether the annotations shall be removed from the PDF.</value>
        [DataMember(Name="removeAnnotations", EmitDefaultValue=false)]
        public bool? RemoveAnnotations { get; set; }

        /// <summary>
        /// Specifies whether the bookmarks shall be removed from the PDF.
        /// </summary>
        /// <value>Specifies whether the bookmarks shall be removed from the PDF.</value>
        [DataMember(Name="removeBookmarks", EmitDefaultValue=false)]
        public bool? RemoveBookmarks { get; set; }

        /// <summary>
        /// Specifies whether the hyperlinks shall be removed from the PDF.
        /// </summary>
        /// <value>Specifies whether the hyperlinks shall be removed from the PDF.</value>
        [DataMember(Name="removeHyperlinks", EmitDefaultValue=false)]
        public bool? RemoveHyperlinks { get; set; }

        /// <summary>
        /// Specifies whether the embedded files shall be removed from the PDF.
        /// </summary>
        /// <value>Specifies whether the embedded files shall be removed from the PDF.</value>
        [DataMember(Name="removeEmbeddedFiles", EmitDefaultValue=false)]
        public bool? RemoveEmbeddedFiles { get; set; }

        /// <summary>
        /// Specifies whether the blank pages shall be removed.
        /// </summary>
        /// <value>Specifies whether the blank pages shall be removed.</value>
        [DataMember(Name="removeBlankPages", EmitDefaultValue=false)]
        public bool? RemoveBlankPages { get; set; }

        /// <summary>
        /// Specifies whether the JavaScript shall be removed.
        /// </summary>
        /// <value>Specifies whether the JavaScript shall be removed.</value>
        [DataMember(Name="removeJavaScript", EmitDefaultValue=false)]
        public bool? RemoveJavaScript { get; set; }

        /// <summary>
        /// Specifies whether the JPEG2000 compression scheme shall be used to compress the images of the PDF.
        /// </summary>
        /// <value>Specifies whether the JPEG2000 compression scheme shall be used to compress the images of the PDF.</value>
        [DataMember(Name="enableJPEG2000", EmitDefaultValue=false)]
        public bool? EnableJPEG2000 { get; set; }

        /// <summary>
        /// Specifies whether the JBIG2 compression scheme shall be used to compress the bitonal images of the PDF.
        /// </summary>
        /// <value>Specifies whether the JBIG2 compression scheme shall be used to compress the bitonal images of the PDF.</value>
        [DataMember(Name="enableJBIG2", EmitDefaultValue=false)]
        public bool? EnableJBIG2 { get; set; }

        /// <summary>
        /// Specifies whether characters repairing shall be performed during bitonal conversion.
        /// </summary>
        /// <value>Specifies whether characters repairing shall be performed during bitonal conversion.</value>
        [DataMember(Name="enableCharRepair", EmitDefaultValue=false)]
        public bool? EnableCharRepair { get; set; }

        /// <summary>
        /// Specifies whether MRC shall be used for compressing the PDF contents.
        /// </summary>
        /// <value>Specifies whether MRC shall be used for compressing the PDF contents.</value>
        [DataMember(Name="enableMRC", EmitDefaultValue=false)]
        public bool? EnableMRC { get; set; }

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
