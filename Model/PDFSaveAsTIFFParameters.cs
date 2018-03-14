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
    /// Represents the parameters for a save as TIFF action.
    /// </summary>
    [DataContract]
    public partial class PDFSaveAsTIFFParameters :  IEquatable<PDFSaveAsTIFFParameters>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Compression
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CompressionEnum
        {
            
            /// <summary>
            /// Enum Deflate for "Deflate"
            /// </summary>
            [EnumMember(Value = "Deflate")]
            Deflate = 1,
            
            /// <summary>
            /// Enum CCITT3 for "CCITT3"
            /// </summary>
            [EnumMember(Value = "CCITT3")]
            CCITT3 = 2,
            
            /// <summary>
            /// Enum CCITT4 for "CCITT4"
            /// </summary>
            [EnumMember(Value = "CCITT4")]
            CCITT4 = 3,
            
            /// <summary>
            /// Enum LZW for "LZW"
            /// </summary>
            [EnumMember(Value = "LZW")]
            LZW = 4,
            
            /// <summary>
            /// Enum JPEG for "JPEG"
            /// </summary>
            [EnumMember(Value = "JPEG")]
            JPEG = 5,
            
            /// <summary>
            /// Enum RLE for "RLE"
            /// </summary>
            [EnumMember(Value = "RLE")]
            RLE = 6,
            
            /// <summary>
            /// Enum Auto for "Auto"
            /// </summary>
            [EnumMember(Value = "Auto")]
            Auto = 7
        }

        /// <summary>
        /// Gets or Sets Compression
        /// </summary>
        [DataMember(Name="compression", EmitDefaultValue=false)]
        public CompressionEnum? Compression { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFSaveAsTIFFParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFSaveAsTIFFParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFSaveAsTIFFParameters" /> class.
        /// </summary>
        /// <param name="FileId">FileId (required).</param>
        /// <param name="Compression">Compression (default to CompressionEnum.Auto).</param>
        /// <param name="JpegQuality">JpegQuality (default to 75).</param>
        /// <param name="PageRange">PageRange (default to &quot;*&quot;).</param>
        /// <param name="Resolution">Resolution (default to 200.0F).</param>
        /// <param name="RenderFormFields">RenderFormFields (default to false).</param>
        /// <param name="KeepRasterPDFResolution">KeepRasterPDFResolution (default to true).</param>
        public PDFSaveAsTIFFParameters(string FileId = default(string), CompressionEnum? Compression = CompressionEnum.Auto, int? JpegQuality = 75, string PageRange = "*", float? Resolution = 200.0F, bool? RenderFormFields = false, bool? KeepRasterPDFResolution = true)
        {
            // to ensure "FileId" is required (not null)
            if (FileId == null)
            {
                throw new InvalidDataException("FileId is a required property for PDFSaveAsTIFFParameters and cannot be null");
            }
            else
            {
                this.FileId = FileId;
            }
            // use default value if no "Compression" provided
            if (Compression == null)
            {
                this.Compression = CompressionEnum.Auto;
            }
            else
            {
                this.Compression = Compression;
            }
            // use default value if no "JpegQuality" provided
            if (JpegQuality == null)
            {
                this.JpegQuality = 75;
            }
            else
            {
                this.JpegQuality = JpegQuality;
            }
            // use default value if no "PageRange" provided
            if (PageRange == null)
            {
                this.PageRange = "*";
            }
            else
            {
                this.PageRange = PageRange;
            }
            // use default value if no "Resolution" provided
            if (Resolution == null)
            {
                this.Resolution = 200.0F;
            }
            else
            {
                this.Resolution = Resolution;
            }
            // use default value if no "RenderFormFields" provided
            if (RenderFormFields == null)
            {
                this.RenderFormFields = false;
            }
            else
            {
                this.RenderFormFields = RenderFormFields;
            }
            // use default value if no "KeepRasterPDFResolution" provided
            if (KeepRasterPDFResolution == null)
            {
                this.KeepRasterPDFResolution = true;
            }
            else
            {
                this.KeepRasterPDFResolution = KeepRasterPDFResolution;
            }
        }
        
        /// <summary>
        /// Gets or Sets FileId
        /// </summary>
        [DataMember(Name="fileId", EmitDefaultValue=false)]
        public string FileId { get; set; }


        /// <summary>
        /// Gets or Sets JpegQuality
        /// </summary>
        [DataMember(Name="jpegQuality", EmitDefaultValue=false)]
        public int? JpegQuality { get; set; }

        /// <summary>
        /// Gets or Sets PageRange
        /// </summary>
        [DataMember(Name="pageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }

        /// <summary>
        /// Gets or Sets Resolution
        /// </summary>
        [DataMember(Name="resolution", EmitDefaultValue=false)]
        public float? Resolution { get; set; }

        /// <summary>
        /// Gets or Sets RenderFormFields
        /// </summary>
        [DataMember(Name="renderFormFields", EmitDefaultValue=false)]
        public bool? RenderFormFields { get; set; }

        /// <summary>
        /// Gets or Sets KeepRasterPDFResolution
        /// </summary>
        [DataMember(Name="keepRasterPDFResolution", EmitDefaultValue=false)]
        public bool? KeepRasterPDFResolution { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFSaveAsTIFFParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  Compression: ").Append(Compression).Append("\n");
            sb.Append("  JpegQuality: ").Append(JpegQuality).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
            sb.Append("  RenderFormFields: ").Append(RenderFormFields).Append("\n");
            sb.Append("  KeepRasterPDFResolution: ").Append(KeepRasterPDFResolution).Append("\n");
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
            return this.Equals(input as PDFSaveAsTIFFParameters);
        }

        /// <summary>
        /// Returns true if PDFSaveAsTIFFParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFSaveAsTIFFParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFSaveAsTIFFParameters input)
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
                    this.Compression == input.Compression ||
                    (this.Compression != null &&
                    this.Compression.Equals(input.Compression))
                ) && 
                (
                    this.JpegQuality == input.JpegQuality ||
                    (this.JpegQuality != null &&
                    this.JpegQuality.Equals(input.JpegQuality))
                ) && 
                (
                    this.PageRange == input.PageRange ||
                    (this.PageRange != null &&
                    this.PageRange.Equals(input.PageRange))
                ) && 
                (
                    this.Resolution == input.Resolution ||
                    (this.Resolution != null &&
                    this.Resolution.Equals(input.Resolution))
                ) && 
                (
                    this.RenderFormFields == input.RenderFormFields ||
                    (this.RenderFormFields != null &&
                    this.RenderFormFields.Equals(input.RenderFormFields))
                ) && 
                (
                    this.KeepRasterPDFResolution == input.KeepRasterPDFResolution ||
                    (this.KeepRasterPDFResolution != null &&
                    this.KeepRasterPDFResolution.Equals(input.KeepRasterPDFResolution))
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
                if (this.Compression != null)
                    hashCode = hashCode * 59 + this.Compression.GetHashCode();
                if (this.JpegQuality != null)
                    hashCode = hashCode * 59 + this.JpegQuality.GetHashCode();
                if (this.PageRange != null)
                    hashCode = hashCode * 59 + this.PageRange.GetHashCode();
                if (this.Resolution != null)
                    hashCode = hashCode * 59 + this.Resolution.GetHashCode();
                if (this.RenderFormFields != null)
                    hashCode = hashCode * 59 + this.RenderFormFields.GetHashCode();
                if (this.KeepRasterPDFResolution != null)
                    hashCode = hashCode * 59 + this.KeepRasterPDFResolution.GetHashCode();
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
