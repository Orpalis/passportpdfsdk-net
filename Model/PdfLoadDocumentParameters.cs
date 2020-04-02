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
    /// Represents the parameters for importing a document as PDF.
    /// </summary>
    [DataContract]
    public partial class PdfLoadDocumentParameters :  IEquatable<PdfLoadDocumentParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfLoadDocumentParameters" /> class.
        /// </summary>
        public PdfLoadDocumentParameters()
        {
        }

        /// <summary>
        /// Specifies the name of the document.
        /// </summary>
        [DataMember(Name="FileName")]
        public string FileName { get; set; }

        /// <summary>
        /// Specifies the password of the document.
        /// </summary>
        [DataMember(Name="Password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets Conformance
        /// </summary>
        [DataMember(Name="Conformance")]
        public PdfConformance Conformance { get; set; }

        /// <summary>
        /// Gets or Sets ContentEncoding
        /// </summary>
        [DataMember(Name="ContentEncoding")]
        public ContentEncoding ContentEncoding { get; set; }

        /// <summary>
        /// Specifies whether color detection must be used while importing a raster format to PDF.
        /// </summary>
        [DataMember(Name="EnableColorDetection")]
        public bool EnableColorDetection { get; set; } = false;

        /// <summary>
        /// Specifies whether the response must contain a thumbnail of the first page of the document.
        /// </summary>
        [DataMember(Name="GetPreview")]
        public bool GetPreview { get; set; } = false;

        /// <summary>
        /// Specifies, in pixels, the width of the thumbnail to be retrieved. Only applicable if GetPreview has been set to true.
        /// </summary>
        [DataMember(Name="ThumbnailWidth")]
        public int ThumbnailWidth { get; set; } = 140;

        /// <summary>
        /// Specifies, in pixels, the height of the thumbnail to be retrieved.  Only applicable if GetPreview has been set to true.
        /// </summary>
        [DataMember(Name="ThumbnailHeight")]
        public int ThumbnailHeight { get; set; } = 220;

        /// <summary>
        /// Specifies the background color of the thumbnail, using the color name (ie: \"red\") or its RGBa code (ie: \"rgba(255,0,0,1)\").   Only applicable if GetPreview has been set to true.
        /// </summary>
        [DataMember(Name="ThumbnailBackgroundColor")]
        public string ThumbnailBackgroundColor { get; set; } = "rgba(0,0,0,0)";

        /// <summary>
        /// Specifies if the size of the produced thumbnail is automatically adjusted to don't have any margin.  Only applicable if GetPreview has been set to true.
        /// </summary>
        [DataMember(Name="ThumbnailFitToPageSize")]
        public bool ThumbnailFitToPageSize { get; set; } = true;

        /// <summary>
        /// Specifies the page width, in points, of produced documents from txt files.
        /// </summary>
        [DataMember(Name="TxtPageWidth")]
        public float TxtPageWidth { get; set; } = 595F;

        /// <summary>
        /// Specifies the page height, in points, of produced documents from txt files.
        /// </summary>
        [DataMember(Name="TxtPageHeight")]
        public float TxtPageHeight { get; set; } = 842F;

        /// <summary>
        /// Specifies the page margin left, in points, of produced documents from txt files.
        /// </summary>
        [DataMember(Name="TxtPageMarginLeft")]
        public float TxtPageMarginLeft { get; set; } = 10F;

        /// <summary>
        /// Specifies the page margin top, in points, of produced documents from txt files.
        /// </summary>
        [DataMember(Name="TxtPageMarginTop")]
        public float TxtPageMarginTop { get; set; } = 10F;

        /// <summary>
        /// Specifies the page margin right, in points, of produced documents from txt files.
        /// </summary>
        [DataMember(Name="TxtPageMarginRight")]
        public float TxtPageMarginRight { get; set; } = 10F;

        /// <summary>
        /// Specifies the page margin bottom, in points, of produced documents from txt files.
        /// </summary>
        [DataMember(Name="TxtPageMarginBottom")]
        public float TxtPageMarginBottom { get; set; } = 10F;

        /// <summary>
        /// Gets or Sets TxtHorizontalTextAlignment
        /// </summary>
        [DataMember(Name="TxtHorizontalTextAlignment")]
        public TextAlignment TxtHorizontalTextAlignment { get; set; }

        /// <summary>
        /// Specifies the text size, in points, to be used for producing documents from txt files.
        /// </summary>
        [DataMember(Name="TxtFontSize")]
        public float TxtFontSize { get; set; } = 12F;

        /// <summary>
        /// Specifies the name of the font to be used for producing documents from txt files.
        /// </summary>
        [DataMember(Name="TxtFontFamily")]
        public string TxtFontFamily { get; set; } = "Arial Unicode MS";

        /// <summary>
        /// Specifies whether the font to be used for producing documents from txt files must have a bold style.
        /// </summary>
        [DataMember(Name="TxtFontBold")]
        public bool TxtFontBold { get; set; } = false;

        /// <summary>
        /// Specifies whether the font to be used for producing documents from txt files must have an italic style.
        /// </summary>
        [DataMember(Name="TxtFontItalic")]
        public bool TxtFontItalic { get; set; } = false;

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
            return Equals(input as PdfLoadDocumentParameters);
        }

        /// <summary>
        /// Returns true if PdfLoadDocumentParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfLoadDocumentParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfLoadDocumentParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    FileName == input.FileName ||
                    (FileName != null &&
                    FileName.Equals(input.FileName))
                ) && 
                (
                    Password == input.Password ||
                    (Password != null &&
                    Password.Equals(input.Password))
                ) && 
                (
                    Conformance == input.Conformance ||
                    Conformance.Equals(input.Conformance)
                ) && 
                (
                    ContentEncoding == input.ContentEncoding ||
                    ContentEncoding.Equals(input.ContentEncoding)
                ) && 
                (
                    EnableColorDetection == input.EnableColorDetection ||
                    EnableColorDetection.Equals(input.EnableColorDetection)
                ) && 
                (
                    GetPreview == input.GetPreview ||
                    GetPreview.Equals(input.GetPreview)
                ) && 
                (
                    ThumbnailWidth == input.ThumbnailWidth ||
                    ThumbnailWidth.Equals(input.ThumbnailWidth)
                ) && 
                (
                    ThumbnailHeight == input.ThumbnailHeight ||
                    ThumbnailHeight.Equals(input.ThumbnailHeight)
                ) && 
                (
                    ThumbnailBackgroundColor == input.ThumbnailBackgroundColor ||
                    (ThumbnailBackgroundColor != null &&
                    ThumbnailBackgroundColor.Equals(input.ThumbnailBackgroundColor))
                ) && 
                (
                    ThumbnailFitToPageSize == input.ThumbnailFitToPageSize ||
                    ThumbnailFitToPageSize.Equals(input.ThumbnailFitToPageSize)
                ) && 
                (
                    TxtPageWidth == input.TxtPageWidth ||
                    TxtPageWidth.Equals(input.TxtPageWidth)
                ) && 
                (
                    TxtPageHeight == input.TxtPageHeight ||
                    TxtPageHeight.Equals(input.TxtPageHeight)
                ) && 
                (
                    TxtPageMarginLeft == input.TxtPageMarginLeft ||
                    TxtPageMarginLeft.Equals(input.TxtPageMarginLeft)
                ) && 
                (
                    TxtPageMarginTop == input.TxtPageMarginTop ||
                    TxtPageMarginTop.Equals(input.TxtPageMarginTop)
                ) && 
                (
                    TxtPageMarginRight == input.TxtPageMarginRight ||
                    TxtPageMarginRight.Equals(input.TxtPageMarginRight)
                ) && 
                (
                    TxtPageMarginBottom == input.TxtPageMarginBottom ||
                    TxtPageMarginBottom.Equals(input.TxtPageMarginBottom)
                ) && 
                (
                    TxtHorizontalTextAlignment == input.TxtHorizontalTextAlignment ||
                    TxtHorizontalTextAlignment.Equals(input.TxtHorizontalTextAlignment)
                ) && 
                (
                    TxtFontSize == input.TxtFontSize ||
                    TxtFontSize.Equals(input.TxtFontSize)
                ) && 
                (
                    TxtFontFamily == input.TxtFontFamily ||
                    (TxtFontFamily != null &&
                    TxtFontFamily.Equals(input.TxtFontFamily))
                ) && 
                (
                    TxtFontBold == input.TxtFontBold ||
                    TxtFontBold.Equals(input.TxtFontBold)
                ) && 
                (
                    TxtFontItalic == input.TxtFontItalic ||
                    TxtFontItalic.Equals(input.TxtFontItalic)
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
                if (FileName != null)
                    hashCode = hashCode * 59 + FileName.GetHashCode();
                if (Password != null)
                    hashCode = hashCode * 59 + Password.GetHashCode();
                hashCode = hashCode * 59 + Conformance.GetHashCode();
                hashCode = hashCode * 59 + ContentEncoding.GetHashCode();
                hashCode = hashCode * 59 + EnableColorDetection.GetHashCode();
                hashCode = hashCode * 59 + GetPreview.GetHashCode();
                hashCode = hashCode * 59 + ThumbnailWidth.GetHashCode();
                hashCode = hashCode * 59 + ThumbnailHeight.GetHashCode();
                if (ThumbnailBackgroundColor != null)
                    hashCode = hashCode * 59 + ThumbnailBackgroundColor.GetHashCode();
                hashCode = hashCode * 59 + ThumbnailFitToPageSize.GetHashCode();
                hashCode = hashCode * 59 + TxtPageWidth.GetHashCode();
                hashCode = hashCode * 59 + TxtPageHeight.GetHashCode();
                hashCode = hashCode * 59 + TxtPageMarginLeft.GetHashCode();
                hashCode = hashCode * 59 + TxtPageMarginTop.GetHashCode();
                hashCode = hashCode * 59 + TxtPageMarginRight.GetHashCode();
                hashCode = hashCode * 59 + TxtPageMarginBottom.GetHashCode();
                hashCode = hashCode * 59 + TxtHorizontalTextAlignment.GetHashCode();
                hashCode = hashCode * 59 + TxtFontSize.GetHashCode();
                if (TxtFontFamily != null)
                    hashCode = hashCode * 59 + TxtFontFamily.GetHashCode();
                hashCode = hashCode * 59 + TxtFontBold.GetHashCode();
                hashCode = hashCode * 59 + TxtFontItalic.GetHashCode();
                return hashCode;
            }
        }
    }

}
