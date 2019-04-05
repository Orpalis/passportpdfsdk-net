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
    /// Represents the response to a get document preview action request.
    /// </summary>
    [DataContract]
    public partial class DocumentGetPreviewResponse :  IEquatable<DocumentGetPreviewResponse>, IValidatableObject
    {
        /// <summary>
        /// Specifies the format of the document.
        /// </summary>
        /// <value>Specifies the format of the document.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DocumentFormatEnum
        {
            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN = 1,

            /// <summary>
            /// Enum ICO for value: ICO
            /// </summary>
            [EnumMember(Value = "ICO")]
            ICO = 2,

            /// <summary>
            /// Enum BMP for value: BMP
            /// </summary>
            [EnumMember(Value = "BMP")]
            BMP = 3,

            /// <summary>
            /// Enum WBMP for value: WBMP
            /// </summary>
            [EnumMember(Value = "WBMP")]
            WBMP = 4,

            /// <summary>
            /// Enum JPEG for value: JPEG
            /// </summary>
            [EnumMember(Value = "JPEG")]
            JPEG = 5,

            /// <summary>
            /// Enum GIF for value: GIF
            /// </summary>
            [EnumMember(Value = "GIF")]
            GIF = 6,

            /// <summary>
            /// Enum PNG for value: PNG
            /// </summary>
            [EnumMember(Value = "PNG")]
            PNG = 7,

            /// <summary>
            /// Enum TIFF for value: TIFF
            /// </summary>
            [EnumMember(Value = "TIFF")]
            TIFF = 8,

            /// <summary>
            /// Enum FAXG3 for value: FAXG3
            /// </summary>
            [EnumMember(Value = "FAXG3")]
            FAXG3 = 9,

            /// <summary>
            /// Enum EXIF for value: EXIF
            /// </summary>
            [EnumMember(Value = "EXIF")]
            EXIF = 10,

            /// <summary>
            /// Enum EMF for value: EMF
            /// </summary>
            [EnumMember(Value = "EMF")]
            EMF = 11,

            /// <summary>
            /// Enum WMF for value: WMF
            /// </summary>
            [EnumMember(Value = "WMF")]
            WMF = 12,

            /// <summary>
            /// Enum JNG for value: JNG
            /// </summary>
            [EnumMember(Value = "JNG")]
            JNG = 13,

            /// <summary>
            /// Enum KOALA for value: KOALA
            /// </summary>
            [EnumMember(Value = "KOALA")]
            KOALA = 14,

            /// <summary>
            /// Enum IFF for value: IFF
            /// </summary>
            [EnumMember(Value = "IFF")]
            IFF = 15,

            /// <summary>
            /// Enum MNG for value: MNG
            /// </summary>
            [EnumMember(Value = "MNG")]
            MNG = 16,

            /// <summary>
            /// Enum PCD for value: PCD
            /// </summary>
            [EnumMember(Value = "PCD")]
            PCD = 17,

            /// <summary>
            /// Enum PCX for value: PCX
            /// </summary>
            [EnumMember(Value = "PCX")]
            PCX = 18,

            /// <summary>
            /// Enum PBM for value: PBM
            /// </summary>
            [EnumMember(Value = "PBM")]
            PBM = 19,

            /// <summary>
            /// Enum PBMRAW for value: PBMRAW
            /// </summary>
            [EnumMember(Value = "PBMRAW")]
            PBMRAW = 20,

            /// <summary>
            /// Enum PFM for value: PFM
            /// </summary>
            [EnumMember(Value = "PFM")]
            PFM = 21,

            /// <summary>
            /// Enum PGM for value: PGM
            /// </summary>
            [EnumMember(Value = "PGM")]
            PGM = 22,

            /// <summary>
            /// Enum PGMRAW for value: PGMRAW
            /// </summary>
            [EnumMember(Value = "PGMRAW")]
            PGMRAW = 23,

            /// <summary>
            /// Enum PPM for value: PPM
            /// </summary>
            [EnumMember(Value = "PPM")]
            PPM = 24,

            /// <summary>
            /// Enum PPMRAW for value: PPMRAW
            /// </summary>
            [EnumMember(Value = "PPMRAW")]
            PPMRAW = 25,

            /// <summary>
            /// Enum RAS for value: RAS
            /// </summary>
            [EnumMember(Value = "RAS")]
            RAS = 26,

            /// <summary>
            /// Enum TARGA for value: TARGA
            /// </summary>
            [EnumMember(Value = "TARGA")]
            TARGA = 27,

            /// <summary>
            /// Enum PSD for value: PSD
            /// </summary>
            [EnumMember(Value = "PSD")]
            PSD = 28,

            /// <summary>
            /// Enum CUT for value: CUT
            /// </summary>
            [EnumMember(Value = "CUT")]
            CUT = 29,

            /// <summary>
            /// Enum XBM for value: XBM
            /// </summary>
            [EnumMember(Value = "XBM")]
            XBM = 30,

            /// <summary>
            /// Enum XPM for value: XPM
            /// </summary>
            [EnumMember(Value = "XPM")]
            XPM = 31,

            /// <summary>
            /// Enum DDS for value: DDS
            /// </summary>
            [EnumMember(Value = "DDS")]
            DDS = 32,

            /// <summary>
            /// Enum HDR for value: HDR
            /// </summary>
            [EnumMember(Value = "HDR")]
            HDR = 33,

            /// <summary>
            /// Enum SGI for value: SGI
            /// </summary>
            [EnumMember(Value = "SGI")]
            SGI = 34,

            /// <summary>
            /// Enum EXR for value: EXR
            /// </summary>
            [EnumMember(Value = "EXR")]
            EXR = 35,

            /// <summary>
            /// Enum J2K for value: J2K
            /// </summary>
            [EnumMember(Value = "J2K")]
            J2K = 36,

            /// <summary>
            /// Enum JP2 for value: JP2
            /// </summary>
            [EnumMember(Value = "JP2")]
            JP2 = 37,

            /// <summary>
            /// Enum PICT for value: PICT
            /// </summary>
            [EnumMember(Value = "PICT")]
            PICT = 38,

            /// <summary>
            /// Enum RAW for value: RAW
            /// </summary>
            [EnumMember(Value = "RAW")]
            RAW = 39,

            /// <summary>
            /// Enum WEBP for value: WEBP
            /// </summary>
            [EnumMember(Value = "WEBP")]
            WEBP = 40,

            /// <summary>
            /// Enum DICOM for value: DICOM
            /// </summary>
            [EnumMember(Value = "DICOM")]
            DICOM = 41,

            /// <summary>
            /// Enum JBIG for value: JBIG
            /// </summary>
            [EnumMember(Value = "JBIG")]
            JBIG = 42,

            /// <summary>
            /// Enum JBIG2 for value: JBIG2
            /// </summary>
            [EnumMember(Value = "JBIG2")]
            JBIG2 = 43,

            /// <summary>
            /// Enum WSQ for value: WSQ
            /// </summary>
            [EnumMember(Value = "WSQ")]
            WSQ = 44,

            /// <summary>
            /// Enum PDF for value: PDF
            /// </summary>
            [EnumMember(Value = "PDF")]
            PDF = 45,

            /// <summary>
            /// Enum SVG for value: SVG
            /// </summary>
            [EnumMember(Value = "SVG")]
            SVG = 46,

            /// <summary>
            /// Enum TXT for value: TXT
            /// </summary>
            [EnumMember(Value = "TXT")]
            TXT = 47,

            /// <summary>
            /// Enum DOCX for value: DOCX
            /// </summary>
            [EnumMember(Value = "DOCX")]
            DOCX = 48,

            /// <summary>
            /// Enum RTF for value: RTF
            /// </summary>
            [EnumMember(Value = "RTF")]
            RTF = 49,

            /// <summary>
            /// Enum DXF for value: DXF
            /// </summary>
            [EnumMember(Value = "DXF")]
            DXF = 50,

            /// <summary>
            /// Enum ODT for value: ODT
            /// </summary>
            [EnumMember(Value = "ODT")]
            ODT = 51

        }

        /// <summary>
        /// Specifies the format of the document.
        /// </summary>
        /// <value>Specifies the format of the document.</value>
        [DataMember(Name="DocumentFormat", EmitDefaultValue=false)]
        public DocumentFormatEnum? DocumentFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentGetPreviewResponse" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="remainingTokens">Specifies the number of remaining tokens..</param>
        public DocumentGetPreviewResponse(Error error = default(Error), long? remainingTokens = default(long?))
        {
            this.Error = error;
            this.RemainingTokens = remainingTokens;
        }
        
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="Error", EmitDefaultValue=false)]
        public Error Error { get; set; }

        /// <summary>
        /// Specifies the number of remaining tokens.
        /// </summary>
        /// <value>Specifies the number of remaining tokens.</value>
        [DataMember(Name="RemainingTokens", EmitDefaultValue=false)]
        public long? RemainingTokens { get; set; }

        /// <summary>
        /// Specifies the page count of the document.
        /// </summary>
        /// <value>Specifies the page count of the document.</value>
        [DataMember(Name="PageCount", EmitDefaultValue=false)]
        public int? PageCount { get; private set; }

        /// <summary>
        /// Specifies the data of a thumbnail from the first page of the document, in PNG format.
        /// </summary>
        /// <value>Specifies the data of a thumbnail from the first page of the document, in PNG format.</value>
        [DataMember(Name="ThumbnailData", EmitDefaultValue=false)]
        public byte[] ThumbnailData { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentGetPreviewResponse {\n");
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
            return this.Equals(input as DocumentGetPreviewResponse);
        }

        /// <summary>
        /// Returns true if DocumentGetPreviewResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentGetPreviewResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentGetPreviewResponse input)
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
