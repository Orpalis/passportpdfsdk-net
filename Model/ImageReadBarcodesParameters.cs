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
    /// Represents the parameters for a read barcode action.
    /// </summary>
    [DataContract]
    public partial class ImageReadBarcodesParameters :  IEquatable<ImageReadBarcodesParameters>, IValidatableObject
    {
        /// <summary>
        /// Specifies the preferred scan mode.
        /// </summary>
        /// <value>Specifies the preferred scan mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ScanModeEnum
        {
            
            /// <summary>
            /// Enum FavorSpeed for "FavorSpeed"
            /// </summary>
            [EnumMember(Value = "FavorSpeed")]
            FavorSpeed = 1,
            
            /// <summary>
            /// Enum FavorAccuracy for "FavorAccuracy"
            /// </summary>
            [EnumMember(Value = "FavorAccuracy")]
            FavorAccuracy = 2
        }

        /// <summary>
        /// Specifies the preferred scan mode.
        /// </summary>
        /// <value>Specifies the preferred scan mode.</value>
        [DataMember(Name="scanMode", EmitDefaultValue=false)]
        public ScanModeEnum? ScanMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageReadBarcodesParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageReadBarcodesParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageReadBarcodesParameters" /> class.
        /// </summary>
        /// <param name="FileId">FileId (required).</param>
        /// <param name="PageRange">Specifies the number of the page, or the range of pages to read the barcodes from. (default to &quot;1&quot;).</param>
        /// <param name="RoiLeft">Specifies the left coordinate, in pixel, of the region to process..</param>
        /// <param name="RoiTop">Specifies the top coordinate, in pixel, of the region to process..</param>
        /// <param name="RoiWidth">Specifies the width, in pixel, of the region to process. 0 causes the entire image to be processed..</param>
        /// <param name="RoiHeight">Specifies the height, in pixel, of the region to process. 0 causes the entire image to be processed..</param>
        /// <param name="ScanMode">Specifies the preferred scan mode. (default to ScanModeEnum.FavorAccuracy).</param>
        /// <param name="ScanBarcode1D">Specifies whether the barcodes of type 1D shall be read. (default to true).</param>
        /// <param name="ScanBarcodeQR">Specifies whether the barcodes of type QR shall be read. (default to true).</param>
        /// <param name="ScanBarcodeMicroQR">Specifies whether the barcodes of type Micro QR shall be read. (default to true).</param>
        /// <param name="ScanBarcodePDF417">Specifies whether the barcodes of type PDF 147 shall be read. (default to true).</param>
        /// <param name="ScanBarcodeDataMatrix">Specifies whether the barcodes of type Data Matrix shall be read. (default to true).</param>
        public ImageReadBarcodesParameters(string FileId = default(string), string PageRange = "1", int? RoiLeft = default(int?), int? RoiTop = default(int?), int? RoiWidth = default(int?), int? RoiHeight = default(int?), ScanModeEnum? ScanMode = ScanModeEnum.FavorAccuracy, bool? ScanBarcode1D = true, bool? ScanBarcodeQR = true, bool? ScanBarcodeMicroQR = true, bool? ScanBarcodePDF417 = true, bool? ScanBarcodeDataMatrix = true)
        {
            // to ensure "FileId" is required (not null)
            if (FileId == null)
            {
                throw new InvalidDataException("FileId is a required property for ImageReadBarcodesParameters and cannot be null");
            }
            else
            {
                this.FileId = FileId;
            }
            // use default value if no "PageRange" provided
            if (PageRange == null)
            {
                this.PageRange = "1";
            }
            else
            {
                this.PageRange = PageRange;
            }
            this.RoiLeft = RoiLeft;
            this.RoiTop = RoiTop;
            this.RoiWidth = RoiWidth;
            this.RoiHeight = RoiHeight;
            // use default value if no "ScanMode" provided
            if (ScanMode == null)
            {
                this.ScanMode = ScanModeEnum.FavorAccuracy;
            }
            else
            {
                this.ScanMode = ScanMode;
            }
            // use default value if no "ScanBarcode1D" provided
            if (ScanBarcode1D == null)
            {
                this.ScanBarcode1D = true;
            }
            else
            {
                this.ScanBarcode1D = ScanBarcode1D;
            }
            // use default value if no "ScanBarcodeQR" provided
            if (ScanBarcodeQR == null)
            {
                this.ScanBarcodeQR = true;
            }
            else
            {
                this.ScanBarcodeQR = ScanBarcodeQR;
            }
            // use default value if no "ScanBarcodeMicroQR" provided
            if (ScanBarcodeMicroQR == null)
            {
                this.ScanBarcodeMicroQR = true;
            }
            else
            {
                this.ScanBarcodeMicroQR = ScanBarcodeMicroQR;
            }
            // use default value if no "ScanBarcodePDF417" provided
            if (ScanBarcodePDF417 == null)
            {
                this.ScanBarcodePDF417 = true;
            }
            else
            {
                this.ScanBarcodePDF417 = ScanBarcodePDF417;
            }
            // use default value if no "ScanBarcodeDataMatrix" provided
            if (ScanBarcodeDataMatrix == null)
            {
                this.ScanBarcodeDataMatrix = true;
            }
            else
            {
                this.ScanBarcodeDataMatrix = ScanBarcodeDataMatrix;
            }
        }
        
        /// <summary>
        /// Gets or Sets FileId
        /// </summary>
        [DataMember(Name="fileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to read the barcodes from.
        /// </summary>
        /// <value>Specifies the number of the page, or the range of pages to read the barcodes from.</value>
        [DataMember(Name="pageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies the left coordinate, in pixel, of the region to process.
        /// </summary>
        /// <value>Specifies the left coordinate, in pixel, of the region to process.</value>
        [DataMember(Name="roiLeft", EmitDefaultValue=false)]
        public int? RoiLeft { get; set; }

        /// <summary>
        /// Specifies the top coordinate, in pixel, of the region to process.
        /// </summary>
        /// <value>Specifies the top coordinate, in pixel, of the region to process.</value>
        [DataMember(Name="roiTop", EmitDefaultValue=false)]
        public int? RoiTop { get; set; }

        /// <summary>
        /// Specifies the width, in pixel, of the region to process. 0 causes the entire image to be processed.
        /// </summary>
        /// <value>Specifies the width, in pixel, of the region to process. 0 causes the entire image to be processed.</value>
        [DataMember(Name="roiWidth", EmitDefaultValue=false)]
        public int? RoiWidth { get; set; }

        /// <summary>
        /// Specifies the height, in pixel, of the region to process. 0 causes the entire image to be processed.
        /// </summary>
        /// <value>Specifies the height, in pixel, of the region to process. 0 causes the entire image to be processed.</value>
        [DataMember(Name="roiHeight", EmitDefaultValue=false)]
        public int? RoiHeight { get; set; }


        /// <summary>
        /// Specifies whether the barcodes of type 1D shall be read.
        /// </summary>
        /// <value>Specifies whether the barcodes of type 1D shall be read.</value>
        [DataMember(Name="scanBarcode1D", EmitDefaultValue=false)]
        public bool? ScanBarcode1D { get; set; }

        /// <summary>
        /// Specifies whether the barcodes of type QR shall be read.
        /// </summary>
        /// <value>Specifies whether the barcodes of type QR shall be read.</value>
        [DataMember(Name="scanBarcodeQR", EmitDefaultValue=false)]
        public bool? ScanBarcodeQR { get; set; }

        /// <summary>
        /// Specifies whether the barcodes of type Micro QR shall be read.
        /// </summary>
        /// <value>Specifies whether the barcodes of type Micro QR shall be read.</value>
        [DataMember(Name="scanBarcodeMicroQR", EmitDefaultValue=false)]
        public bool? ScanBarcodeMicroQR { get; set; }

        /// <summary>
        /// Specifies whether the barcodes of type PDF 147 shall be read.
        /// </summary>
        /// <value>Specifies whether the barcodes of type PDF 147 shall be read.</value>
        [DataMember(Name="scanBarcodePDF417", EmitDefaultValue=false)]
        public bool? ScanBarcodePDF417 { get; set; }

        /// <summary>
        /// Specifies whether the barcodes of type Data Matrix shall be read.
        /// </summary>
        /// <value>Specifies whether the barcodes of type Data Matrix shall be read.</value>
        [DataMember(Name="scanBarcodeDataMatrix", EmitDefaultValue=false)]
        public bool? ScanBarcodeDataMatrix { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageReadBarcodesParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  RoiLeft: ").Append(RoiLeft).Append("\n");
            sb.Append("  RoiTop: ").Append(RoiTop).Append("\n");
            sb.Append("  RoiWidth: ").Append(RoiWidth).Append("\n");
            sb.Append("  RoiHeight: ").Append(RoiHeight).Append("\n");
            sb.Append("  ScanMode: ").Append(ScanMode).Append("\n");
            sb.Append("  ScanBarcode1D: ").Append(ScanBarcode1D).Append("\n");
            sb.Append("  ScanBarcodeQR: ").Append(ScanBarcodeQR).Append("\n");
            sb.Append("  ScanBarcodeMicroQR: ").Append(ScanBarcodeMicroQR).Append("\n");
            sb.Append("  ScanBarcodePDF417: ").Append(ScanBarcodePDF417).Append("\n");
            sb.Append("  ScanBarcodeDataMatrix: ").Append(ScanBarcodeDataMatrix).Append("\n");
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
            return this.Equals(input as ImageReadBarcodesParameters);
        }

        /// <summary>
        /// Returns true if ImageReadBarcodesParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageReadBarcodesParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageReadBarcodesParameters input)
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
                    this.RoiLeft == input.RoiLeft ||
                    (this.RoiLeft != null &&
                    this.RoiLeft.Equals(input.RoiLeft))
                ) && 
                (
                    this.RoiTop == input.RoiTop ||
                    (this.RoiTop != null &&
                    this.RoiTop.Equals(input.RoiTop))
                ) && 
                (
                    this.RoiWidth == input.RoiWidth ||
                    (this.RoiWidth != null &&
                    this.RoiWidth.Equals(input.RoiWidth))
                ) && 
                (
                    this.RoiHeight == input.RoiHeight ||
                    (this.RoiHeight != null &&
                    this.RoiHeight.Equals(input.RoiHeight))
                ) && 
                (
                    this.ScanMode == input.ScanMode ||
                    (this.ScanMode != null &&
                    this.ScanMode.Equals(input.ScanMode))
                ) && 
                (
                    this.ScanBarcode1D == input.ScanBarcode1D ||
                    (this.ScanBarcode1D != null &&
                    this.ScanBarcode1D.Equals(input.ScanBarcode1D))
                ) && 
                (
                    this.ScanBarcodeQR == input.ScanBarcodeQR ||
                    (this.ScanBarcodeQR != null &&
                    this.ScanBarcodeQR.Equals(input.ScanBarcodeQR))
                ) && 
                (
                    this.ScanBarcodeMicroQR == input.ScanBarcodeMicroQR ||
                    (this.ScanBarcodeMicroQR != null &&
                    this.ScanBarcodeMicroQR.Equals(input.ScanBarcodeMicroQR))
                ) && 
                (
                    this.ScanBarcodePDF417 == input.ScanBarcodePDF417 ||
                    (this.ScanBarcodePDF417 != null &&
                    this.ScanBarcodePDF417.Equals(input.ScanBarcodePDF417))
                ) && 
                (
                    this.ScanBarcodeDataMatrix == input.ScanBarcodeDataMatrix ||
                    (this.ScanBarcodeDataMatrix != null &&
                    this.ScanBarcodeDataMatrix.Equals(input.ScanBarcodeDataMatrix))
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
                if (this.RoiLeft != null)
                    hashCode = hashCode * 59 + this.RoiLeft.GetHashCode();
                if (this.RoiTop != null)
                    hashCode = hashCode * 59 + this.RoiTop.GetHashCode();
                if (this.RoiWidth != null)
                    hashCode = hashCode * 59 + this.RoiWidth.GetHashCode();
                if (this.RoiHeight != null)
                    hashCode = hashCode * 59 + this.RoiHeight.GetHashCode();
                if (this.ScanMode != null)
                    hashCode = hashCode * 59 + this.ScanMode.GetHashCode();
                if (this.ScanBarcode1D != null)
                    hashCode = hashCode * 59 + this.ScanBarcode1D.GetHashCode();
                if (this.ScanBarcodeQR != null)
                    hashCode = hashCode * 59 + this.ScanBarcodeQR.GetHashCode();
                if (this.ScanBarcodeMicroQR != null)
                    hashCode = hashCode * 59 + this.ScanBarcodeMicroQR.GetHashCode();
                if (this.ScanBarcodePDF417 != null)
                    hashCode = hashCode * 59 + this.ScanBarcodePDF417.GetHashCode();
                if (this.ScanBarcodeDataMatrix != null)
                    hashCode = hashCode * 59 + this.ScanBarcodeDataMatrix.GetHashCode();
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
