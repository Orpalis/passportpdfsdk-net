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
    /// Represents the parameters for a read barcode action.
    /// </summary>
    [DataContract]
    public partial class ImageReadBarcodesParameters :  IEquatable<ImageReadBarcodesParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageReadBarcodesParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageReadBarcodesParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageReadBarcodesParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages to read the barcodes from. (required).</param>
        public ImageReadBarcodesParameters(string fileId, string pageRange)
        {
            FileId = fileId;
            PageRange = pageRange;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to read the barcodes from.
        /// </summary>
        [DataMember(Name="PageRange")]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies the left coordinate, in pixel, of the region to process.
        /// </summary>
        [DataMember(Name="RoiLeft")]
        public int RoiLeft { get; set; } = 0;

        /// <summary>
        /// Specifies the top coordinate, in pixel, of the region to process.
        /// </summary>
        [DataMember(Name="RoiTop")]
        public int RoiTop { get; set; } = 0;

        /// <summary>
        /// Specifies the width, in pixel, of the region to process. 0 causes the entire image to be processed.
        /// </summary>
        [DataMember(Name="RoiWidth")]
        public int RoiWidth { get; set; } = 0;

        /// <summary>
        /// Specifies the height, in pixel, of the region to process. 0 causes the entire image to be processed.
        /// </summary>
        [DataMember(Name="RoiHeight")]
        public int RoiHeight { get; set; } = 0;

        /// <summary>
        /// Gets or Sets ScanMode
        /// </summary>
        [DataMember(Name="ScanMode")]
        public ScanMode ScanMode { get; set; }

        /// <summary>
        /// Specifies whether the barcodes of type 1D shall be read.
        /// </summary>
        [DataMember(Name="ScanBarcode1D")]
        public bool ScanBarcode1D { get; set; } = true;

        /// <summary>
        /// Specifies whether the barcodes of type QR shall be read.
        /// </summary>
        [DataMember(Name="ScanBarcodeQR")]
        public bool ScanBarcodeQR { get; set; } = true;

        /// <summary>
        /// Specifies whether the barcodes of type Micro QR shall be read.
        /// </summary>
        [DataMember(Name="ScanBarcodeMicroQR")]
        public bool ScanBarcodeMicroQR { get; set; } = true;

        /// <summary>
        /// Specifies whether the barcodes of type PDF 147 shall be read.
        /// </summary>
        [DataMember(Name="ScanBarcodePDF417")]
        public bool ScanBarcodePDF417 { get; set; } = true;

        /// <summary>
        /// Specifies whether the barcodes of type Data Matrix shall be read.
        /// </summary>
        [DataMember(Name="ScanBarcodeDataMatrix")]
        public bool ScanBarcodeDataMatrix { get; set; } = true;

        /// <summary>
        /// Specifies whether the barcodes of type Aztec shall be read.
        /// </summary>
        [DataMember(Name="ScanBarcodeAztec")]
        public bool ScanBarcodeAztec { get; set; } = true;

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
            return Equals(input as ImageReadBarcodesParameters);
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
                    FileId == input.FileId ||
                    (FileId != null &&
                    FileId.Equals(input.FileId))
                ) && 
                (
                    PageRange == input.PageRange ||
                    (PageRange != null &&
                    PageRange.Equals(input.PageRange))
                ) && 
                (
                    RoiLeft == input.RoiLeft ||
                    RoiLeft.Equals(input.RoiLeft)
                ) && 
                (
                    RoiTop == input.RoiTop ||
                    RoiTop.Equals(input.RoiTop)
                ) && 
                (
                    RoiWidth == input.RoiWidth ||
                    RoiWidth.Equals(input.RoiWidth)
                ) && 
                (
                    RoiHeight == input.RoiHeight ||
                    RoiHeight.Equals(input.RoiHeight)
                ) && 
                (
                    ScanMode == input.ScanMode ||
                    ScanMode.Equals(input.ScanMode)
                ) && 
                (
                    ScanBarcode1D == input.ScanBarcode1D ||
                    ScanBarcode1D.Equals(input.ScanBarcode1D)
                ) && 
                (
                    ScanBarcodeQR == input.ScanBarcodeQR ||
                    ScanBarcodeQR.Equals(input.ScanBarcodeQR)
                ) && 
                (
                    ScanBarcodeMicroQR == input.ScanBarcodeMicroQR ||
                    ScanBarcodeMicroQR.Equals(input.ScanBarcodeMicroQR)
                ) && 
                (
                    ScanBarcodePDF417 == input.ScanBarcodePDF417 ||
                    ScanBarcodePDF417.Equals(input.ScanBarcodePDF417)
                ) && 
                (
                    ScanBarcodeDataMatrix == input.ScanBarcodeDataMatrix ||
                    ScanBarcodeDataMatrix.Equals(input.ScanBarcodeDataMatrix)
                ) && 
                (
                    ScanBarcodeAztec == input.ScanBarcodeAztec ||
                    ScanBarcodeAztec.Equals(input.ScanBarcodeAztec)
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
                if (PageRange != null)
                    hashCode = hashCode * 59 + PageRange.GetHashCode();
                hashCode = hashCode * 59 + RoiLeft.GetHashCode();
                hashCode = hashCode * 59 + RoiTop.GetHashCode();
                hashCode = hashCode * 59 + RoiWidth.GetHashCode();
                hashCode = hashCode * 59 + RoiHeight.GetHashCode();
                hashCode = hashCode * 59 + ScanMode.GetHashCode();
                hashCode = hashCode * 59 + ScanBarcode1D.GetHashCode();
                hashCode = hashCode * 59 + ScanBarcodeQR.GetHashCode();
                hashCode = hashCode * 59 + ScanBarcodeMicroQR.GetHashCode();
                hashCode = hashCode * 59 + ScanBarcodePDF417.GetHashCode();
                hashCode = hashCode * 59 + ScanBarcodeDataMatrix.GetHashCode();
                hashCode = hashCode * 59 + ScanBarcodeAztec.GetHashCode();
                return hashCode;
            }
        }
    }

}
