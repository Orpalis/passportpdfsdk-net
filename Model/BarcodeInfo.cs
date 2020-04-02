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
    /// Represents information about a read barcode.
    /// </summary>
    [DataContract]
    public partial class BarcodeInfo :  IEquatable<BarcodeInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BarcodeInfo" /> class.
        /// </summary>
        public BarcodeInfo()
        {
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type")]
        public BarcodeType Type { get; set; }

        /// <summary>
        /// Gets or Sets Barcode1DSymbology
        /// </summary>
        [DataMember(Name="Barcode1DSymbology")]
        public Barcode1DSymbology Barcode1DSymbology { get; set; }

        /// <summary>
        /// Specifies the data contained within the barcode.
        /// </summary>
        [DataMember(Name="Data")]
        public string Data { get; private set; }

        /// <summary>
        /// Specifies the horizontal top-left position of the barcode, in pixels.
        /// </summary>
        [DataMember(Name="X1")]
        public int X1 { get; private set; }

        /// <summary>
        /// Specifies the horizontal top-right position of the barcode, in pixels.
        /// </summary>
        [DataMember(Name="X2")]
        public int X2 { get; private set; }

        /// <summary>
        /// Specifies the horizontal bottom-left position of the barcode, in pixels.
        /// </summary>
        [DataMember(Name="X3")]
        public int X3 { get; private set; }

        /// <summary>
        /// Specifies the horizontal bottom-right position of the barcode, in pixels.
        /// </summary>
        [DataMember(Name="X4")]
        public int X4 { get; private set; }

        /// <summary>
        /// Specifies the vertical top-left position of the barcode, in pixels.
        /// </summary>
        [DataMember(Name="Y1")]
        public int Y1 { get; private set; }

        /// <summary>
        /// Specifies the vertical top-right position of the barcode, in pixels.
        /// </summary>
        [DataMember(Name="Y2")]
        public int Y2 { get; private set; }

        /// <summary>
        /// Specifies the vertical bottom-left position of the barcode, in pixels.
        /// </summary>
        [DataMember(Name="Y3")]
        public int Y3 { get; private set; }

        /// <summary>
        /// Specifies the vertical bottom-right position of the barcode, in pixels.
        /// </summary>
        [DataMember(Name="Y4")]
        public int Y4 { get; private set; }

        /// <summary>
        /// Specifies the left coordinates of the bounding box of the barcode, in inches.
        /// </summary>
        [DataMember(Name="BboxLeftInches")]
        public float BboxLeftInches { get; private set; }

        /// <summary>
        /// Specifies the top coordinates of the bounding box of the barcode, in inches.
        /// </summary>
        [DataMember(Name="BboxTopInches")]
        public float BboxTopInches { get; private set; }

        /// <summary>
        /// Specifies the width of the bounding box of the barcode, in inches.
        /// </summary>
        [DataMember(Name="BboxWidthInches")]
        public float BboxWidthInches { get; private set; }

        /// <summary>
        /// Specifies the height of the bounding box of the barcode, in inches.
        /// </summary>
        [DataMember(Name="BboxHeightInches")]
        public float BboxHeightInches { get; private set; }

        /// <summary>
        /// Specifies the number of the page on which the barcode was read.
        /// </summary>
        [DataMember(Name="PageNumber")]
        public int PageNumber { get; private set; }

        /// <summary>
        /// Specifies the width, in pixels, of the page where the barcode has been decoded.
        /// </summary>
        [DataMember(Name="PagePixelWidth")]
        public int PagePixelWidth { get; private set; }

        /// <summary>
        /// Specifies the height, in pixels, of the page where the barcode has been decoded.
        /// </summary>
        [DataMember(Name="PagePixelHeight")]
        public int PagePixelHeight { get; private set; }

        /// <summary>
        /// Specifies the horizontal resolution, in pixel per inches, of the page where the barcode has been decoded.
        /// </summary>
        [DataMember(Name="PageHorizontalResolution")]
        public float PageHorizontalResolution { get; private set; }

        /// <summary>
        /// Specifies the vertical resolution, in pixel per inches, of the page where the barcode has been decoded.
        /// </summary>
        [DataMember(Name="PageVerticalResolution")]
        public float PageVerticalResolution { get; private set; }

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
            return Equals(input as BarcodeInfo);
        }

        /// <summary>
        /// Returns true if BarcodeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BarcodeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BarcodeInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    Type == input.Type ||
                    Type.Equals(input.Type)
                ) && 
                (
                    Barcode1DSymbology == input.Barcode1DSymbology ||
                    Barcode1DSymbology.Equals(input.Barcode1DSymbology)
                ) && 
                (
                    Data == input.Data ||
                    (Data != null &&
                    Data.Equals(input.Data))
                ) && 
                (
                    X1 == input.X1 ||
                    X1.Equals(input.X1)
                ) && 
                (
                    X2 == input.X2 ||
                    X2.Equals(input.X2)
                ) && 
                (
                    X3 == input.X3 ||
                    X3.Equals(input.X3)
                ) && 
                (
                    X4 == input.X4 ||
                    X4.Equals(input.X4)
                ) && 
                (
                    Y1 == input.Y1 ||
                    Y1.Equals(input.Y1)
                ) && 
                (
                    Y2 == input.Y2 ||
                    Y2.Equals(input.Y2)
                ) && 
                (
                    Y3 == input.Y3 ||
                    Y3.Equals(input.Y3)
                ) && 
                (
                    Y4 == input.Y4 ||
                    Y4.Equals(input.Y4)
                ) && 
                (
                    BboxLeftInches == input.BboxLeftInches ||
                    BboxLeftInches.Equals(input.BboxLeftInches)
                ) && 
                (
                    BboxTopInches == input.BboxTopInches ||
                    BboxTopInches.Equals(input.BboxTopInches)
                ) && 
                (
                    BboxWidthInches == input.BboxWidthInches ||
                    BboxWidthInches.Equals(input.BboxWidthInches)
                ) && 
                (
                    BboxHeightInches == input.BboxHeightInches ||
                    BboxHeightInches.Equals(input.BboxHeightInches)
                ) && 
                (
                    PageNumber == input.PageNumber ||
                    PageNumber.Equals(input.PageNumber)
                ) && 
                (
                    PagePixelWidth == input.PagePixelWidth ||
                    PagePixelWidth.Equals(input.PagePixelWidth)
                ) && 
                (
                    PagePixelHeight == input.PagePixelHeight ||
                    PagePixelHeight.Equals(input.PagePixelHeight)
                ) && 
                (
                    PageHorizontalResolution == input.PageHorizontalResolution ||
                    PageHorizontalResolution.Equals(input.PageHorizontalResolution)
                ) && 
                (
                    PageVerticalResolution == input.PageVerticalResolution ||
                    PageVerticalResolution.Equals(input.PageVerticalResolution)
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
                hashCode = hashCode * 59 + Type.GetHashCode();
                hashCode = hashCode * 59 + Barcode1DSymbology.GetHashCode();
                if (Data != null)
                    hashCode = hashCode * 59 + Data.GetHashCode();
                hashCode = hashCode * 59 + X1.GetHashCode();
                hashCode = hashCode * 59 + X2.GetHashCode();
                hashCode = hashCode * 59 + X3.GetHashCode();
                hashCode = hashCode * 59 + X4.GetHashCode();
                hashCode = hashCode * 59 + Y1.GetHashCode();
                hashCode = hashCode * 59 + Y2.GetHashCode();
                hashCode = hashCode * 59 + Y3.GetHashCode();
                hashCode = hashCode * 59 + Y4.GetHashCode();
                hashCode = hashCode * 59 + BboxLeftInches.GetHashCode();
                hashCode = hashCode * 59 + BboxTopInches.GetHashCode();
                hashCode = hashCode * 59 + BboxWidthInches.GetHashCode();
                hashCode = hashCode * 59 + BboxHeightInches.GetHashCode();
                hashCode = hashCode * 59 + PageNumber.GetHashCode();
                hashCode = hashCode * 59 + PagePixelWidth.GetHashCode();
                hashCode = hashCode * 59 + PagePixelHeight.GetHashCode();
                hashCode = hashCode * 59 + PageHorizontalResolution.GetHashCode();
                hashCode = hashCode * 59 + PageVerticalResolution.GetHashCode();
                return hashCode;
            }
        }
    }

}
