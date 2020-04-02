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
    /// Represents the basic parameters for text content.
    /// </summary>
    [DataContract]
    public partial class PdfTextParameters :  IEquatable<PdfTextParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfTextParameters" /> class.
        /// </summary>
        public PdfTextParameters()
        {
        }

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
            return Equals(input as PdfTextParameters);
        }

        /// <summary>
        /// Returns true if PdfTextParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfTextParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfTextParameters input)
        {
            if (input == null)
                return false;

            return 
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
