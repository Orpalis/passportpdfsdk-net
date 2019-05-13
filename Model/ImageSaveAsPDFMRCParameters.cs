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
    /// Represents the parameters for a save as PDF MRC action.
    /// </summary>
    [DataContract]
    public partial class ImageSaveAsPDFMRCParameters :  IEquatable<ImageSaveAsPDFMRCParameters>, IValidatableObject
    {
        /// <summary>
        /// Specifies the level of PDF conformance to be used.
        /// </summary>
        /// <value>Specifies the level of PDF conformance to be used.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConformanceEnum
        {
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,

            /// <summary>
            /// Enum PDF10 for value: PDF1_0
            /// </summary>
            [EnumMember(Value = "PDF1_0")]
            PDF10 = 2,

            /// <summary>
            /// Enum PDF11 for value: PDF1_1
            /// </summary>
            [EnumMember(Value = "PDF1_1")]
            PDF11 = 3,

            /// <summary>
            /// Enum PDF12 for value: PDF1_2
            /// </summary>
            [EnumMember(Value = "PDF1_2")]
            PDF12 = 4,

            /// <summary>
            /// Enum PDF13 for value: PDF1_3
            /// </summary>
            [EnumMember(Value = "PDF1_3")]
            PDF13 = 5,

            /// <summary>
            /// Enum PDF14 for value: PDF1_4
            /// </summary>
            [EnumMember(Value = "PDF1_4")]
            PDF14 = 6,

            /// <summary>
            /// Enum PDF15 for value: PDF1_5
            /// </summary>
            [EnumMember(Value = "PDF1_5")]
            PDF15 = 7,

            /// <summary>
            /// Enum PDF16 for value: PDF1_6
            /// </summary>
            [EnumMember(Value = "PDF1_6")]
            PDF16 = 8,

            /// <summary>
            /// Enum PDF17 for value: PDF1_7
            /// </summary>
            [EnumMember(Value = "PDF1_7")]
            PDF17 = 9,

            /// <summary>
            /// Enum PDF20 for value: PDF2_0
            /// </summary>
            [EnumMember(Value = "PDF2_0")]
            PDF20 = 10,

            /// <summary>
            /// Enum PDFA1a for value: PDF_A_1a
            /// </summary>
            [EnumMember(Value = "PDF_A_1a")]
            PDFA1a = 11,

            /// <summary>
            /// Enum PDFA1b for value: PDF_A_1b
            /// </summary>
            [EnumMember(Value = "PDF_A_1b")]
            PDFA1b = 12,

            /// <summary>
            /// Enum PDFA2a for value: PDF_A_2a
            /// </summary>
            [EnumMember(Value = "PDF_A_2a")]
            PDFA2a = 13,

            /// <summary>
            /// Enum PDFA2u for value: PDF_A_2u
            /// </summary>
            [EnumMember(Value = "PDF_A_2u")]
            PDFA2u = 14,

            /// <summary>
            /// Enum PDFA2b for value: PDF_A_2b
            /// </summary>
            [EnumMember(Value = "PDF_A_2b")]
            PDFA2b = 15,

            /// <summary>
            /// Enum PDFA3a for value: PDF_A_3a
            /// </summary>
            [EnumMember(Value = "PDF_A_3a")]
            PDFA3a = 16,

            /// <summary>
            /// Enum PDFA3u for value: PDF_A_3u
            /// </summary>
            [EnumMember(Value = "PDF_A_3u")]
            PDFA3u = 17,

            /// <summary>
            /// Enum PDFA3b for value: PDF_A_3b
            /// </summary>
            [EnumMember(Value = "PDF_A_3b")]
            PDFA3b = 18,

            /// <summary>
            /// Enum PDFUA1 for value: PDF_UA_1
            /// </summary>
            [EnumMember(Value = "PDF_UA_1")]
            PDFUA1 = 19

        }

        /// <summary>
        /// Specifies the level of PDF conformance to be used.
        /// </summary>
        /// <value>Specifies the level of PDF conformance to be used.</value>
        [DataMember(Name="Conformance", EmitDefaultValue=false)]
        public ConformanceEnum? Conformance { get; set; }
        /// <summary>
        /// Specifies the compression scheme to be used for color images.
        /// </summary>
        /// <value>Specifies the compression scheme to be used for color images.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ColorImageCompressionEnum
        {
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,

            /// <summary>
            /// Enum Flate for value: Flate
            /// </summary>
            [EnumMember(Value = "Flate")]
            Flate = 2,

            /// <summary>
            /// Enum CCIT4 for value: CCIT4
            /// </summary>
            [EnumMember(Value = "CCIT4")]
            CCIT4 = 3,

            /// <summary>
            /// Enum JPEG for value: JPEG
            /// </summary>
            [EnumMember(Value = "JPEG")]
            JPEG = 4,

            /// <summary>
            /// Enum JBIG2 for value: JBIG2
            /// </summary>
            [EnumMember(Value = "JBIG2")]
            JBIG2 = 5,

            /// <summary>
            /// Enum JPEG2000 for value: JPEG2000
            /// </summary>
            [EnumMember(Value = "JPEG2000")]
            JPEG2000 = 6

        }

        /// <summary>
        /// Specifies the compression scheme to be used for color images.
        /// </summary>
        /// <value>Specifies the compression scheme to be used for color images.</value>
        [DataMember(Name="ColorImageCompression", EmitDefaultValue=false)]
        public ColorImageCompressionEnum? ColorImageCompression { get; set; }
        /// <summary>
        /// Specifies the compression scheme to be used for bitonal images.
        /// </summary>
        /// <value>Specifies the compression scheme to be used for bitonal images.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BitonalImageCompressionEnum
        {
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,

            /// <summary>
            /// Enum Flate for value: Flate
            /// </summary>
            [EnumMember(Value = "Flate")]
            Flate = 2,

            /// <summary>
            /// Enum CCIT4 for value: CCIT4
            /// </summary>
            [EnumMember(Value = "CCIT4")]
            CCIT4 = 3,

            /// <summary>
            /// Enum JPEG for value: JPEG
            /// </summary>
            [EnumMember(Value = "JPEG")]
            JPEG = 4,

            /// <summary>
            /// Enum JBIG2 for value: JBIG2
            /// </summary>
            [EnumMember(Value = "JBIG2")]
            JBIG2 = 5,

            /// <summary>
            /// Enum JPEG2000 for value: JPEG2000
            /// </summary>
            [EnumMember(Value = "JPEG2000")]
            JPEG2000 = 6

        }

        /// <summary>
        /// Specifies the compression scheme to be used for bitonal images.
        /// </summary>
        /// <value>Specifies the compression scheme to be used for bitonal images.</value>
        [DataMember(Name="BitonalImageCompression", EmitDefaultValue=false)]
        public BitonalImageCompressionEnum? BitonalImageCompression { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSaveAsPDFMRCParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageSaveAsPDFMRCParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSaveAsPDFMRCParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages to be saved as PDF MRC. (required).</param>
        /// <param name="conformance">Specifies the level of PDF conformance to be used. (default to ConformanceEnum.PDF15).</param>
        /// <param name="colorImageCompression">Specifies the compression scheme to be used for color images. (default to ColorImageCompressionEnum.JPEG2000).</param>
        /// <param name="bitonalImageCompression">Specifies the compression scheme to be used for bitonal images. (default to BitonalImageCompressionEnum.JBIG2).</param>
        /// <param name="imageQuality">Specifies the quality to be used for the compression of the images from the PDF.  Must be in the range [0 (best compression - worst quality) - 100 (worst quality - best compression)]. (default to 60).</param>
        /// <param name="downscaleResolution">Specifies the resolution for downscaling the background layer, if any. (default to 100).</param>
        /// <param name="preserveSmoothing">Specifies whether the MRC engine should try to preserve smoothing between different layers.   Enabling this option should globally enhance the text quality but also reduce the compression rate..</param>
        /// <param name="fastWebView">Specifies whether the PDF shall be optimized for online distribution..</param>
        public ImageSaveAsPDFMRCParameters(string fileId = default(string), string pageRange = default(string), ConformanceEnum? conformance = ConformanceEnum.PDF15, ColorImageCompressionEnum? colorImageCompression = ColorImageCompressionEnum.JPEG2000, BitonalImageCompressionEnum? bitonalImageCompression = BitonalImageCompressionEnum.JBIG2, int? imageQuality = 60, int? downscaleResolution = 100, bool? preserveSmoothing = default(bool?), bool? fastWebView = default(bool?))
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for ImageSaveAsPDFMRCParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            
            // to ensure "pageRange" is required (not null)
            if (pageRange == null)
            {
                throw new InvalidDataException("pageRange is a required property for ImageSaveAsPDFMRCParameters and cannot be null");
            }
            else
            {
                this.PageRange = pageRange;
            }
            
            // use default value if no "conformance" provided
            if (conformance == null)
            {
                this.Conformance = ConformanceEnum.PDF15;
            }
            else
            {
                this.Conformance = conformance;
            }
            // use default value if no "colorImageCompression" provided
            if (colorImageCompression == null)
            {
                this.ColorImageCompression = ColorImageCompressionEnum.JPEG2000;
            }
            else
            {
                this.ColorImageCompression = colorImageCompression;
            }
            // use default value if no "bitonalImageCompression" provided
            if (bitonalImageCompression == null)
            {
                this.BitonalImageCompression = BitonalImageCompressionEnum.JBIG2;
            }
            else
            {
                this.BitonalImageCompression = bitonalImageCompression;
            }
            // use default value if no "imageQuality" provided
            if (imageQuality == null)
            {
                this.ImageQuality = 60;
            }
            else
            {
                this.ImageQuality = imageQuality;
            }
            // use default value if no "downscaleResolution" provided
            if (downscaleResolution == null)
            {
                this.DownscaleResolution = 100;
            }
            else
            {
                this.DownscaleResolution = downscaleResolution;
            }
            this.PreserveSmoothing = preserveSmoothing;
            this.FastWebView = fastWebView;
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to be saved as PDF MRC.
        /// </summary>
        /// <value>Specifies the number of the page, or the range of pages to be saved as PDF MRC.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }




        /// <summary>
        /// Specifies the quality to be used for the compression of the images from the PDF.  Must be in the range [0 (best compression - worst quality) - 100 (worst quality - best compression)].
        /// </summary>
        /// <value>Specifies the quality to be used for the compression of the images from the PDF.  Must be in the range [0 (best compression - worst quality) - 100 (worst quality - best compression)].</value>
        [DataMember(Name="ImageQuality", EmitDefaultValue=false)]
        public int? ImageQuality { get; set; }

        /// <summary>
        /// Specifies the resolution for downscaling the background layer, if any.
        /// </summary>
        /// <value>Specifies the resolution for downscaling the background layer, if any.</value>
        [DataMember(Name="DownscaleResolution", EmitDefaultValue=false)]
        public int? DownscaleResolution { get; set; }

        /// <summary>
        /// Specifies whether the MRC engine should try to preserve smoothing between different layers.   Enabling this option should globally enhance the text quality but also reduce the compression rate.
        /// </summary>
        /// <value>Specifies whether the MRC engine should try to preserve smoothing between different layers.   Enabling this option should globally enhance the text quality but also reduce the compression rate.</value>
        [DataMember(Name="PreserveSmoothing", EmitDefaultValue=false)]
        public bool? PreserveSmoothing { get; set; }

        /// <summary>
        /// Specifies whether the PDF shall be optimized for online distribution.
        /// </summary>
        /// <value>Specifies whether the PDF shall be optimized for online distribution.</value>
        [DataMember(Name="FastWebView", EmitDefaultValue=false)]
        public bool? FastWebView { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageSaveAsPDFMRCParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  Conformance: ").Append(Conformance).Append("\n");
            sb.Append("  ColorImageCompression: ").Append(ColorImageCompression).Append("\n");
            sb.Append("  BitonalImageCompression: ").Append(BitonalImageCompression).Append("\n");
            sb.Append("  ImageQuality: ").Append(ImageQuality).Append("\n");
            sb.Append("  DownscaleResolution: ").Append(DownscaleResolution).Append("\n");
            sb.Append("  PreserveSmoothing: ").Append(PreserveSmoothing).Append("\n");
            sb.Append("  FastWebView: ").Append(FastWebView).Append("\n");
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
            return this.Equals(input as ImageSaveAsPDFMRCParameters);
        }

        /// <summary>
        /// Returns true if ImageSaveAsPDFMRCParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageSaveAsPDFMRCParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageSaveAsPDFMRCParameters input)
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
                    this.Conformance == input.Conformance ||
                    (this.Conformance != null &&
                    this.Conformance.Equals(input.Conformance))
                ) && 
                (
                    this.ColorImageCompression == input.ColorImageCompression ||
                    (this.ColorImageCompression != null &&
                    this.ColorImageCompression.Equals(input.ColorImageCompression))
                ) && 
                (
                    this.BitonalImageCompression == input.BitonalImageCompression ||
                    (this.BitonalImageCompression != null &&
                    this.BitonalImageCompression.Equals(input.BitonalImageCompression))
                ) && 
                (
                    this.ImageQuality == input.ImageQuality ||
                    (this.ImageQuality != null &&
                    this.ImageQuality.Equals(input.ImageQuality))
                ) && 
                (
                    this.DownscaleResolution == input.DownscaleResolution ||
                    (this.DownscaleResolution != null &&
                    this.DownscaleResolution.Equals(input.DownscaleResolution))
                ) && 
                (
                    this.PreserveSmoothing == input.PreserveSmoothing ||
                    (this.PreserveSmoothing != null &&
                    this.PreserveSmoothing.Equals(input.PreserveSmoothing))
                ) && 
                (
                    this.FastWebView == input.FastWebView ||
                    (this.FastWebView != null &&
                    this.FastWebView.Equals(input.FastWebView))
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
                if (this.Conformance != null)
                    hashCode = hashCode * 59 + this.Conformance.GetHashCode();
                if (this.ColorImageCompression != null)
                    hashCode = hashCode * 59 + this.ColorImageCompression.GetHashCode();
                if (this.BitonalImageCompression != null)
                    hashCode = hashCode * 59 + this.BitonalImageCompression.GetHashCode();
                if (this.ImageQuality != null)
                    hashCode = hashCode * 59 + this.ImageQuality.GetHashCode();
                if (this.DownscaleResolution != null)
                    hashCode = hashCode * 59 + this.DownscaleResolution.GetHashCode();
                if (this.PreserveSmoothing != null)
                    hashCode = hashCode * 59 + this.PreserveSmoothing.GetHashCode();
                if (this.FastWebView != null)
                    hashCode = hashCode * 59 + this.FastWebView.GetHashCode();
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
