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
    /// Represents the parameters for a draw image action.
    /// </summary>
    [DataContract]
    public partial class PDFDrawImageParameters :  IEquatable<PDFDrawImageParameters>, IValidatableObject
    {
        /// <summary>
        /// Specifies the compression scheme to be used for a color image.
        /// </summary>
        /// <value>Specifies the compression scheme to be used for a color image.</value>
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
        /// Specifies the compression scheme to be used for a color image.
        /// </summary>
        /// <value>Specifies the compression scheme to be used for a color image.</value>
        [DataMember(Name="ColorImageCompression", EmitDefaultValue=false)]
        public ColorImageCompressionEnum? ColorImageCompression { get; set; }
        /// <summary>
        /// Specifies the compression scheme to be used for a bitonal image.
        /// </summary>
        /// <value>Specifies the compression scheme to be used for a bitonal image.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BitonalCompressionEnum
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
        /// Specifies the compression scheme to be used for a bitonal image.
        /// </summary>
        /// <value>Specifies the compression scheme to be used for a bitonal image.</value>
        [DataMember(Name="BitonalCompression", EmitDefaultValue=false)]
        public BitonalCompressionEnum? BitonalCompression { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFDrawImageParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFDrawImageParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFDrawImageParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the page or the page range on which the image shall be drawn. (required).</param>
        /// <param name="imageData">Specifies the data of the image to be drawn..</param>
        /// <param name="imageFileId">Specifies the file ID of the image to be drawn..</param>
        /// <param name="quality">Specifies the level of quality to be used for the compression, from 1 (poorest) to 100 (greatest). (default to 75).</param>
        /// <param name="colorImageCompression">Specifies the compression scheme to be used for a color image. (default to ColorImageCompressionEnum.JPEG).</param>
        /// <param name="bitonalCompression">Specifies the compression scheme to be used for a bitonal image. (default to BitonalCompressionEnum.JBIG2).</param>
        /// <param name="imageLayout">imageLayout.</param>
        public PDFDrawImageParameters(string fileId = default(string), string pageRange = default(string), byte[] imageData = default(byte[]), string imageFileId = default(string), int? quality = 75, ColorImageCompressionEnum? colorImageCompression = ColorImageCompressionEnum.JPEG, BitonalCompressionEnum? bitonalCompression = BitonalCompressionEnum.JBIG2, DrawableContentLayoutParameters imageLayout = default(DrawableContentLayoutParameters))
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for PDFDrawImageParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            // to ensure "pageRange" is required (not null)
            if (pageRange == null)
            {
                throw new InvalidDataException("pageRange is a required property for PDFDrawImageParameters and cannot be null");
            }
            else
            {
                this.PageRange = pageRange;
            }
            this.ImageData = imageData;
            this.ImageFileId = imageFileId;
            // use default value if no "quality" provided
            if (quality == null)
            {
                this.Quality = 75;
            }
            else
            {
                this.Quality = quality;
            }
            // use default value if no "colorImageCompression" provided
            if (colorImageCompression == null)
            {
                this.ColorImageCompression = ColorImageCompressionEnum.JPEG;
            }
            else
            {
                this.ColorImageCompression = colorImageCompression;
            }
            // use default value if no "bitonalCompression" provided
            if (bitonalCompression == null)
            {
                this.BitonalCompression = BitonalCompressionEnum.JBIG2;
            }
            else
            {
                this.BitonalCompression = bitonalCompression;
            }
            this.ImageLayout = imageLayout;
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the page or the page range on which the image shall be drawn.
        /// </summary>
        /// <value>Specifies the page or the page range on which the image shall be drawn.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies the data of the image to be drawn.
        /// </summary>
        /// <value>Specifies the data of the image to be drawn.</value>
        [DataMember(Name="ImageData", EmitDefaultValue=false)]
        public byte[] ImageData { get; set; }

        /// <summary>
        /// Specifies the file ID of the image to be drawn.
        /// </summary>
        /// <value>Specifies the file ID of the image to be drawn.</value>
        [DataMember(Name="ImageFileId", EmitDefaultValue=false)]
        public string ImageFileId { get; set; }

        /// <summary>
        /// Specifies the level of quality to be used for the compression, from 1 (poorest) to 100 (greatest).
        /// </summary>
        /// <value>Specifies the level of quality to be used for the compression, from 1 (poorest) to 100 (greatest).</value>
        [DataMember(Name="Quality", EmitDefaultValue=false)]
        public int? Quality { get; set; }



        /// <summary>
        /// Gets or Sets ImageLayout
        /// </summary>
        [DataMember(Name="ImageLayout", EmitDefaultValue=false)]
        public DrawableContentLayoutParameters ImageLayout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFDrawImageParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  ImageData: ").Append(ImageData).Append("\n");
            sb.Append("  ImageFileId: ").Append(ImageFileId).Append("\n");
            sb.Append("  Quality: ").Append(Quality).Append("\n");
            sb.Append("  ColorImageCompression: ").Append(ColorImageCompression).Append("\n");
            sb.Append("  BitonalCompression: ").Append(BitonalCompression).Append("\n");
            sb.Append("  ImageLayout: ").Append(ImageLayout).Append("\n");
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
            return this.Equals(input as PDFDrawImageParameters);
        }

        /// <summary>
        /// Returns true if PDFDrawImageParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFDrawImageParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFDrawImageParameters input)
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
                    this.ImageData == input.ImageData ||
                    (this.ImageData != null &&
                    this.ImageData.Equals(input.ImageData))
                ) && 
                (
                    this.ImageFileId == input.ImageFileId ||
                    (this.ImageFileId != null &&
                    this.ImageFileId.Equals(input.ImageFileId))
                ) && 
                (
                    this.Quality == input.Quality ||
                    (this.Quality != null &&
                    this.Quality.Equals(input.Quality))
                ) && 
                (
                    this.ColorImageCompression == input.ColorImageCompression ||
                    (this.ColorImageCompression != null &&
                    this.ColorImageCompression.Equals(input.ColorImageCompression))
                ) && 
                (
                    this.BitonalCompression == input.BitonalCompression ||
                    (this.BitonalCompression != null &&
                    this.BitonalCompression.Equals(input.BitonalCompression))
                ) && 
                (
                    this.ImageLayout == input.ImageLayout ||
                    (this.ImageLayout != null &&
                    this.ImageLayout.Equals(input.ImageLayout))
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
                if (this.ImageData != null)
                    hashCode = hashCode * 59 + this.ImageData.GetHashCode();
                if (this.ImageFileId != null)
                    hashCode = hashCode * 59 + this.ImageFileId.GetHashCode();
                if (this.Quality != null)
                    hashCode = hashCode * 59 + this.Quality.GetHashCode();
                if (this.ColorImageCompression != null)
                    hashCode = hashCode * 59 + this.ColorImageCompression.GetHashCode();
                if (this.BitonalCompression != null)
                    hashCode = hashCode * 59 + this.BitonalCompression.GetHashCode();
                if (this.ImageLayout != null)
                    hashCode = hashCode * 59 + this.ImageLayout.GetHashCode();
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
