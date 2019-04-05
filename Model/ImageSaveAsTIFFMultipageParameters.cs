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
    /// Represents the parameters for a save as TIFF multipage action.
    /// </summary>
    [DataContract]
    public partial class ImageSaveAsTIFFMultipageParameters :  IEquatable<ImageSaveAsTIFFMultipageParameters>, IValidatableObject
    {
        /// <summary>
        /// Specifies the compression to be used for the TIFF output.
        /// </summary>
        /// <value>Specifies the compression to be used for the TIFF output.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CompressionEnum
        {
            /// <summary>
            /// Enum Deflate for value: Deflate
            /// </summary>
            [EnumMember(Value = "Deflate")]
            Deflate = 1,

            /// <summary>
            /// Enum CCITT3 for value: CCITT3
            /// </summary>
            [EnumMember(Value = "CCITT3")]
            CCITT3 = 2,

            /// <summary>
            /// Enum CCITT4 for value: CCITT4
            /// </summary>
            [EnumMember(Value = "CCITT4")]
            CCITT4 = 3,

            /// <summary>
            /// Enum LZW for value: LZW
            /// </summary>
            [EnumMember(Value = "LZW")]
            LZW = 4,

            /// <summary>
            /// Enum JPEG for value: JPEG
            /// </summary>
            [EnumMember(Value = "JPEG")]
            JPEG = 5,

            /// <summary>
            /// Enum RLE for value: RLE
            /// </summary>
            [EnumMember(Value = "RLE")]
            RLE = 6,

            /// <summary>
            /// Enum Auto for value: Auto
            /// </summary>
            [EnumMember(Value = "Auto")]
            Auto = 7

        }

        /// <summary>
        /// Specifies the compression to be used for the TIFF output.
        /// </summary>
        /// <value>Specifies the compression to be used for the TIFF output.</value>
        [DataMember(Name="Compression", EmitDefaultValue=false)]
        public CompressionEnum? Compression { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSaveAsTIFFMultipageParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageSaveAsTIFFMultipageParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSaveAsTIFFMultipageParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages to be saved as TIFF. (required).</param>
        /// <param name="compression">Specifies the compression to be used for the TIFF output. (default to CompressionEnum.Auto).</param>
        /// <param name="jpegQuality">Specifies the level of quality to be used if JPEG compression is used, from 1 (poorest) to 100 (greatest). (default to 75).</param>
        public ImageSaveAsTIFFMultipageParameters(string fileId = default(string), string pageRange = default(string), CompressionEnum? compression = CompressionEnum.Auto, int? jpegQuality = 75)
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for ImageSaveAsTIFFMultipageParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            // to ensure "pageRange" is required (not null)
            if (pageRange == null)
            {
                throw new InvalidDataException("pageRange is a required property for ImageSaveAsTIFFMultipageParameters and cannot be null");
            }
            else
            {
                this.PageRange = pageRange;
            }
            // use default value if no "compression" provided
            if (compression == null)
            {
                this.Compression = CompressionEnum.Auto;
            }
            else
            {
                this.Compression = compression;
            }
            // use default value if no "jpegQuality" provided
            if (jpegQuality == null)
            {
                this.JpegQuality = 75;
            }
            else
            {
                this.JpegQuality = jpegQuality;
            }
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to be saved as TIFF.
        /// </summary>
        /// <value>Specifies the number of the page, or the range of pages to be saved as TIFF.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }


        /// <summary>
        /// Specifies the level of quality to be used if JPEG compression is used, from 1 (poorest) to 100 (greatest).
        /// </summary>
        /// <value>Specifies the level of quality to be used if JPEG compression is used, from 1 (poorest) to 100 (greatest).</value>
        [DataMember(Name="JpegQuality", EmitDefaultValue=false)]
        public int? JpegQuality { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageSaveAsTIFFMultipageParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  Compression: ").Append(Compression).Append("\n");
            sb.Append("  JpegQuality: ").Append(JpegQuality).Append("\n");
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
            return this.Equals(input as ImageSaveAsTIFFMultipageParameters);
        }

        /// <summary>
        /// Returns true if ImageSaveAsTIFFMultipageParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageSaveAsTIFFMultipageParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageSaveAsTIFFMultipageParameters input)
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
                    this.Compression == input.Compression ||
                    (this.Compression != null &&
                    this.Compression.Equals(input.Compression))
                ) && 
                (
                    this.JpegQuality == input.JpegQuality ||
                    (this.JpegQuality != null &&
                    this.JpegQuality.Equals(input.JpegQuality))
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
                if (this.Compression != null)
                    hashCode = hashCode * 59 + this.Compression.GetHashCode();
                if (this.JpegQuality != null)
                    hashCode = hashCode * 59 + this.JpegQuality.GetHashCode();
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
