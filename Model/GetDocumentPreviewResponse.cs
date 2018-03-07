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
    /// Represents a response to a get document preview action request.
    /// </summary>
    [DataContract]
    public partial class GetDocumentPreviewResponse :  IEquatable<GetDocumentPreviewResponse>, IValidatableObject
    {
        /// <summary>
        /// Specifies the format of the document.
        /// </summary>
        /// <value>Specifies the format of the document.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DocumentFormatEnum
        {
            
            /// <summary>
            /// Enum UNKNOWN for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN = 1,
            
            /// <summary>
            /// Enum ICO for "ICO"
            /// </summary>
            [EnumMember(Value = "ICO")]
            ICO = 2,
            
            /// <summary>
            /// Enum BMP for "BMP"
            /// </summary>
            [EnumMember(Value = "BMP")]
            BMP = 3,
            
            /// <summary>
            /// Enum WBMP for "WBMP"
            /// </summary>
            [EnumMember(Value = "WBMP")]
            WBMP = 4,
            
            /// <summary>
            /// Enum JPEG for "JPEG"
            /// </summary>
            [EnumMember(Value = "JPEG")]
            JPEG = 5,
            
            /// <summary>
            /// Enum GIF for "GIF"
            /// </summary>
            [EnumMember(Value = "GIF")]
            GIF = 6,
            
            /// <summary>
            /// Enum PNG for "PNG"
            /// </summary>
            [EnumMember(Value = "PNG")]
            PNG = 7,
            
            /// <summary>
            /// Enum TIFF for "TIFF"
            /// </summary>
            [EnumMember(Value = "TIFF")]
            TIFF = 8,
            
            /// <summary>
            /// Enum FAXG3 for "FAXG3"
            /// </summary>
            [EnumMember(Value = "FAXG3")]
            FAXG3 = 9,
            
            /// <summary>
            /// Enum EXIF for "EXIF"
            /// </summary>
            [EnumMember(Value = "EXIF")]
            EXIF = 10,
            
            /// <summary>
            /// Enum EMF for "EMF"
            /// </summary>
            [EnumMember(Value = "EMF")]
            EMF = 11,
            
            /// <summary>
            /// Enum WMF for "WMF"
            /// </summary>
            [EnumMember(Value = "WMF")]
            WMF = 12,
            
            /// <summary>
            /// Enum JNG for "JNG"
            /// </summary>
            [EnumMember(Value = "JNG")]
            JNG = 13,
            
            /// <summary>
            /// Enum KOALA for "KOALA"
            /// </summary>
            [EnumMember(Value = "KOALA")]
            KOALA = 14,
            
            /// <summary>
            /// Enum IFF for "IFF"
            /// </summary>
            [EnumMember(Value = "IFF")]
            IFF = 15,
            
            /// <summary>
            /// Enum MNG for "MNG"
            /// </summary>
            [EnumMember(Value = "MNG")]
            MNG = 16,
            
            /// <summary>
            /// Enum PCD for "PCD"
            /// </summary>
            [EnumMember(Value = "PCD")]
            PCD = 17,
            
            /// <summary>
            /// Enum PCX for "PCX"
            /// </summary>
            [EnumMember(Value = "PCX")]
            PCX = 18,
            
            /// <summary>
            /// Enum PBM for "PBM"
            /// </summary>
            [EnumMember(Value = "PBM")]
            PBM = 19,
            
            /// <summary>
            /// Enum PBMRAW for "PBMRAW"
            /// </summary>
            [EnumMember(Value = "PBMRAW")]
            PBMRAW = 20,
            
            /// <summary>
            /// Enum PFM for "PFM"
            /// </summary>
            [EnumMember(Value = "PFM")]
            PFM = 21,
            
            /// <summary>
            /// Enum PGM for "PGM"
            /// </summary>
            [EnumMember(Value = "PGM")]
            PGM = 22,
            
            /// <summary>
            /// Enum PGMRAW for "PGMRAW"
            /// </summary>
            [EnumMember(Value = "PGMRAW")]
            PGMRAW = 23,
            
            /// <summary>
            /// Enum PPM for "PPM"
            /// </summary>
            [EnumMember(Value = "PPM")]
            PPM = 24,
            
            /// <summary>
            /// Enum PPMRAW for "PPMRAW"
            /// </summary>
            [EnumMember(Value = "PPMRAW")]
            PPMRAW = 25,
            
            /// <summary>
            /// Enum RAS for "RAS"
            /// </summary>
            [EnumMember(Value = "RAS")]
            RAS = 26,
            
            /// <summary>
            /// Enum TARGA for "TARGA"
            /// </summary>
            [EnumMember(Value = "TARGA")]
            TARGA = 27,
            
            /// <summary>
            /// Enum PSD for "PSD"
            /// </summary>
            [EnumMember(Value = "PSD")]
            PSD = 28,
            
            /// <summary>
            /// Enum CUT for "CUT"
            /// </summary>
            [EnumMember(Value = "CUT")]
            CUT = 29,
            
            /// <summary>
            /// Enum XBM for "XBM"
            /// </summary>
            [EnumMember(Value = "XBM")]
            XBM = 30,
            
            /// <summary>
            /// Enum XPM for "XPM"
            /// </summary>
            [EnumMember(Value = "XPM")]
            XPM = 31,
            
            /// <summary>
            /// Enum DDS for "DDS"
            /// </summary>
            [EnumMember(Value = "DDS")]
            DDS = 32,
            
            /// <summary>
            /// Enum HDR for "HDR"
            /// </summary>
            [EnumMember(Value = "HDR")]
            HDR = 33,
            
            /// <summary>
            /// Enum SGI for "SGI"
            /// </summary>
            [EnumMember(Value = "SGI")]
            SGI = 34,
            
            /// <summary>
            /// Enum EXR for "EXR"
            /// </summary>
            [EnumMember(Value = "EXR")]
            EXR = 35,
            
            /// <summary>
            /// Enum J2K for "J2K"
            /// </summary>
            [EnumMember(Value = "J2K")]
            J2K = 36,
            
            /// <summary>
            /// Enum JP2 for "JP2"
            /// </summary>
            [EnumMember(Value = "JP2")]
            JP2 = 37,
            
            /// <summary>
            /// Enum PICT for "PICT"
            /// </summary>
            [EnumMember(Value = "PICT")]
            PICT = 38,
            
            /// <summary>
            /// Enum RAW for "RAW"
            /// </summary>
            [EnumMember(Value = "RAW")]
            RAW = 39,
            
            /// <summary>
            /// Enum WEBP for "WEBP"
            /// </summary>
            [EnumMember(Value = "WEBP")]
            WEBP = 40,
            
            /// <summary>
            /// Enum DICOM for "DICOM"
            /// </summary>
            [EnumMember(Value = "DICOM")]
            DICOM = 41,
            
            /// <summary>
            /// Enum JBIG for "JBIG"
            /// </summary>
            [EnumMember(Value = "JBIG")]
            JBIG = 42,
            
            /// <summary>
            /// Enum JBIG2 for "JBIG2"
            /// </summary>
            [EnumMember(Value = "JBIG2")]
            JBIG2 = 43,
            
            /// <summary>
            /// Enum WSQ for "WSQ"
            /// </summary>
            [EnumMember(Value = "WSQ")]
            WSQ = 44,
            
            /// <summary>
            /// Enum PDF for "PDF"
            /// </summary>
            [EnumMember(Value = "PDF")]
            PDF = 45,
            
            /// <summary>
            /// Enum SVG for "SVG"
            /// </summary>
            [EnumMember(Value = "SVG")]
            SVG = 46,
            
            /// <summary>
            /// Enum TXT for "TXT"
            /// </summary>
            [EnumMember(Value = "TXT")]
            TXT = 47,
            
            /// <summary>
            /// Enum OpenXMLWord for "OpenXMLWord"
            /// </summary>
            [EnumMember(Value = "OpenXMLWord")]
            OpenXMLWord = 48,
            
            /// <summary>
            /// Enum RTF for "RTF"
            /// </summary>
            [EnumMember(Value = "RTF")]
            RTF = 49
        }

        /// <summary>
        /// Specifies the format of the document.
        /// </summary>
        /// <value>Specifies the format of the document.</value>
        [DataMember(Name="documentFormat", EmitDefaultValue=false)]
        public DocumentFormatEnum? DocumentFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentPreviewResponse" /> class.
        /// </summary>
        /// <param name="Error">Error.</param>
        /// <param name="RemainingTokens">RemainingTokens.</param>
        public GetDocumentPreviewResponse(Error Error = default(Error), long? RemainingTokens = default(long?))
        {
            this.Error = Error;
            this.RemainingTokens = RemainingTokens;
        }
        
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public Error Error { get; set; }

        /// <summary>
        /// Gets or Sets RemainingTokens
        /// </summary>
        [DataMember(Name="remainingTokens", EmitDefaultValue=false)]
        public long? RemainingTokens { get; set; }

        /// <summary>
        /// Specifies the page count of the document.
        /// </summary>
        /// <value>Specifies the page count of the document.</value>
        [DataMember(Name="pageCount", EmitDefaultValue=false)]
        public int? PageCount { get; private set; }

        /// <summary>
        /// Specifies the data of a thumbnail from the first page of the document, in PNG format.
        /// </summary>
        /// <value>Specifies the data of a thumbnail from the first page of the document, in PNG format.</value>
        [DataMember(Name="thumbnailData", EmitDefaultValue=false)]
        public byte[] ThumbnailData { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDocumentPreviewResponse {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  RemainingTokens: ").Append(RemainingTokens).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  ThumbnailData: ").Append(ThumbnailData).Append("\n");
            sb.Append("  DocumentFormat: ").Append(DocumentFormat).Append("\n");
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
            return this.Equals(input as GetDocumentPreviewResponse);
        }

        /// <summary>
        /// Returns true if GetDocumentPreviewResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDocumentPreviewResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDocumentPreviewResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.RemainingTokens == input.RemainingTokens ||
                    (this.RemainingTokens != null &&
                    this.RemainingTokens.Equals(input.RemainingTokens))
                ) && 
                (
                    this.PageCount == input.PageCount ||
                    (this.PageCount != null &&
                    this.PageCount.Equals(input.PageCount))
                ) && 
                (
                    this.ThumbnailData == input.ThumbnailData ||
                    (this.ThumbnailData != null &&
                    this.ThumbnailData.Equals(input.ThumbnailData))
                ) && 
                (
                    this.DocumentFormat == input.DocumentFormat ||
                    (this.DocumentFormat != null &&
                    this.DocumentFormat.Equals(input.DocumentFormat))
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
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.RemainingTokens != null)
                    hashCode = hashCode * 59 + this.RemainingTokens.GetHashCode();
                if (this.PageCount != null)
                    hashCode = hashCode * 59 + this.PageCount.GetHashCode();
                if (this.ThumbnailData != null)
                    hashCode = hashCode * 59 + this.ThumbnailData.GetHashCode();
                if (this.DocumentFormat != null)
                    hashCode = hashCode * 59 + this.DocumentFormat.GetHashCode();
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
