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
    /// Represents the parameters for aligned text content.
    /// </summary>
    [DataContract]
    public partial class PdfAlignedTextParameters :  IEquatable<PdfAlignedTextParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfAlignedTextParameters" /> class.
        /// </summary>
        public PdfAlignedTextParameters()
        {
        }

        /// <summary>
        /// Gets or Sets TextVerticalAlignment
        /// </summary>
        [DataMember(Name="TextVerticalAlignment")]
        public TextAlignment TextVerticalAlignment { get; set; }

        /// <summary>
        /// Gets or Sets TextHorizontalAlignment
        /// </summary>
        [DataMember(Name="TextHorizontalAlignment")]
        public TextAlignment TextHorizontalAlignment { get; set; }

        /// <summary>
        /// Specifies the text.
        /// </summary>
        [DataMember(Name="Text")]
        public string Text { get; set; }

        /// <summary>
        /// Specifies the color of the text, using the color name (ie: \"red\") or its RGBa code (ie: \"rgba(255,0,0,1)\").
        /// </summary>
        [DataMember(Name="TextColor")]
        public string TextColor { get; set; } = "black";

        /// <summary>
        /// Specifies the name of the font to be used.
        /// </summary>
        [DataMember(Name="FontName")]
        public string FontName { get; set; }

        /// <summary>
        /// Gets or Sets StandardFontName
        /// </summary>
        [DataMember(Name="StandardFontName")]
        public StandardFontName StandardFontName { get; set; }

        /// <summary>
        /// Gets or Sets FontStyle
        /// </summary>
        [DataMember(Name="FontStyle")]
        public FontStyle FontStyle { get; set; }

        /// <summary>
        /// Specifies the size of the font.
        /// </summary>
        [DataMember(Name="FontSize")]
        public int FontSize { get; set; } = 11;

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
            return Equals(input as PdfAlignedTextParameters);
        }

        /// <summary>
        /// Returns true if PdfAlignedTextParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfAlignedTextParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfAlignedTextParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    TextVerticalAlignment == input.TextVerticalAlignment ||
                    TextVerticalAlignment.Equals(input.TextVerticalAlignment)
                ) && 
                (
                    TextHorizontalAlignment == input.TextHorizontalAlignment ||
                    TextHorizontalAlignment.Equals(input.TextHorizontalAlignment)
                ) && 
                (
                    Text == input.Text ||
                    (Text != null &&
                    Text.Equals(input.Text))
                ) && 
                (
                    TextColor == input.TextColor ||
                    (TextColor != null &&
                    TextColor.Equals(input.TextColor))
                ) && 
                (
                    FontName == input.FontName ||
                    (FontName != null &&
                    FontName.Equals(input.FontName))
                ) && 
                (
                    StandardFontName == input.StandardFontName ||
                    StandardFontName.Equals(input.StandardFontName)
                ) && 
                (
                    FontStyle == input.FontStyle ||
                    FontStyle.Equals(input.FontStyle)
                ) && 
                (
                    FontSize == input.FontSize ||
                    FontSize.Equals(input.FontSize)
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
                hashCode = hashCode * 59 + TextVerticalAlignment.GetHashCode();
                hashCode = hashCode * 59 + TextHorizontalAlignment.GetHashCode();
                if (Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();
                if (TextColor != null)
                    hashCode = hashCode * 59 + TextColor.GetHashCode();
                if (FontName != null)
                    hashCode = hashCode * 59 + FontName.GetHashCode();
                hashCode = hashCode * 59 + StandardFontName.GetHashCode();
                hashCode = hashCode * 59 + FontStyle.GetHashCode();
                hashCode = hashCode * 59 + FontSize.GetHashCode();
                return hashCode;
            }
        }
    }

}
