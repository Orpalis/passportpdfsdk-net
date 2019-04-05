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
    /// Represents the parameters for aligned text content.
    /// </summary>
    [DataContract]
    public partial class PDFAlignedTextParameters :  IEquatable<PDFAlignedTextParameters>, IValidatableObject
    {
        /// <summary>
        /// Specifies the vertical alignment of the text.
        /// </summary>
        /// <value>Specifies the vertical alignment of the text.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TextVerticalAlignmentEnum
        {
            /// <summary>
            /// Enum Near for value: Near
            /// </summary>
            [EnumMember(Value = "Near")]
            Near = 1,

            /// <summary>
            /// Enum Center for value: Center
            /// </summary>
            [EnumMember(Value = "Center")]
            Center = 2,

            /// <summary>
            /// Enum Far for value: Far
            /// </summary>
            [EnumMember(Value = "Far")]
            Far = 3

        }

        /// <summary>
        /// Specifies the vertical alignment of the text.
        /// </summary>
        /// <value>Specifies the vertical alignment of the text.</value>
        [DataMember(Name="TextVerticalAlignment", EmitDefaultValue=false)]
        public TextVerticalAlignmentEnum? TextVerticalAlignment { get; set; }
        /// <summary>
        /// Specifies the horizontal alignment of the text.
        /// </summary>
        /// <value>Specifies the horizontal alignment of the text.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TextHorizontalAlignmentEnum
        {
            /// <summary>
            /// Enum Near for value: Near
            /// </summary>
            [EnumMember(Value = "Near")]
            Near = 1,

            /// <summary>
            /// Enum Center for value: Center
            /// </summary>
            [EnumMember(Value = "Center")]
            Center = 2,

            /// <summary>
            /// Enum Far for value: Far
            /// </summary>
            [EnumMember(Value = "Far")]
            Far = 3

        }

        /// <summary>
        /// Specifies the horizontal alignment of the text.
        /// </summary>
        /// <value>Specifies the horizontal alignment of the text.</value>
        [DataMember(Name="TextHorizontalAlignment", EmitDefaultValue=false)]
        public TextHorizontalAlignmentEnum? TextHorizontalAlignment { get; set; }
        /// <summary>
        /// Specifies the name of the standard font to be used.
        /// </summary>
        /// <value>Specifies the name of the standard font to be used.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StandardFontNameEnum
        {
            /// <summary>
            /// Enum Courier for value: Courier
            /// </summary>
            [EnumMember(Value = "Courier")]
            Courier = 1,

            /// <summary>
            /// Enum Helvetica for value: Helvetica
            /// </summary>
            [EnumMember(Value = "Helvetica")]
            Helvetica = 2,

            /// <summary>
            /// Enum Times for value: Times
            /// </summary>
            [EnumMember(Value = "Times")]
            Times = 3,

            /// <summary>
            /// Enum Symbol for value: Symbol
            /// </summary>
            [EnumMember(Value = "Symbol")]
            Symbol = 4,

            /// <summary>
            /// Enum ZapfDingbats for value: ZapfDingbats
            /// </summary>
            [EnumMember(Value = "ZapfDingbats")]
            ZapfDingbats = 5

        }

        /// <summary>
        /// Specifies the name of the standard font to be used.
        /// </summary>
        /// <value>Specifies the name of the standard font to be used.</value>
        [DataMember(Name="StandardFontName", EmitDefaultValue=false)]
        public StandardFontNameEnum? StandardFontName { get; set; }
        /// <summary>
        /// Specifies the style of the font.
        /// </summary>
        /// <value>Specifies the style of the font.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FontStyleEnum
        {
            /// <summary>
            /// Enum Regular for value: Regular
            /// </summary>
            [EnumMember(Value = "Regular")]
            Regular = 1,

            /// <summary>
            /// Enum Bold for value: Bold
            /// </summary>
            [EnumMember(Value = "Bold")]
            Bold = 2,

            /// <summary>
            /// Enum Italic for value: Italic
            /// </summary>
            [EnumMember(Value = "Italic")]
            Italic = 3,

            /// <summary>
            /// Enum BoldItalic for value: BoldItalic
            /// </summary>
            [EnumMember(Value = "BoldItalic")]
            BoldItalic = 4

        }

        /// <summary>
        /// Specifies the style of the font.
        /// </summary>
        /// <value>Specifies the style of the font.</value>
        [DataMember(Name="FontStyle", EmitDefaultValue=false)]
        public FontStyleEnum? FontStyle { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFAlignedTextParameters" /> class.
        /// </summary>
        /// <param name="textVerticalAlignment">Specifies the vertical alignment of the text. (default to TextVerticalAlignmentEnum.Near).</param>
        /// <param name="textHorizontalAlignment">Specifies the horizontal alignment of the text. (default to TextHorizontalAlignmentEnum.Near).</param>
        /// <param name="text">Specifies the text..</param>
        /// <param name="textColor">Specifies the color of the text, using the color name (ie: \&quot;red\&quot;) or its RGBa code (ie: \&quot;rgba(255,0,0,1)\&quot;). (default to &quot;black&quot;).</param>
        /// <param name="fontName">Specifies the name of the font to be used..</param>
        /// <param name="standardFontName">Specifies the name of the standard font to be used. (default to StandardFontNameEnum.Helvetica).</param>
        /// <param name="fontStyle">Specifies the style of the font. (default to FontStyleEnum.Regular).</param>
        /// <param name="fontSize">Specifies the size of the font. (default to 11).</param>
        public PDFAlignedTextParameters(TextVerticalAlignmentEnum? textVerticalAlignment = TextVerticalAlignmentEnum.Near, TextHorizontalAlignmentEnum? textHorizontalAlignment = TextHorizontalAlignmentEnum.Near, string text = default(string), string textColor = "black", string fontName = default(string), StandardFontNameEnum? standardFontName = StandardFontNameEnum.Helvetica, FontStyleEnum? fontStyle = FontStyleEnum.Regular, int? fontSize = 11)
        {
            // use default value if no "textVerticalAlignment" provided
            if (textVerticalAlignment == null)
            {
                this.TextVerticalAlignment = TextVerticalAlignmentEnum.Near;
            }
            else
            {
                this.TextVerticalAlignment = textVerticalAlignment;
            }
            // use default value if no "textHorizontalAlignment" provided
            if (textHorizontalAlignment == null)
            {
                this.TextHorizontalAlignment = TextHorizontalAlignmentEnum.Near;
            }
            else
            {
                this.TextHorizontalAlignment = textHorizontalAlignment;
            }
            this.Text = text;
            // use default value if no "textColor" provided
            if (textColor == null)
            {
                this.TextColor = "black";
            }
            else
            {
                this.TextColor = textColor;
            }
            this.FontName = fontName;
            // use default value if no "standardFontName" provided
            if (standardFontName == null)
            {
                this.StandardFontName = StandardFontNameEnum.Helvetica;
            }
            else
            {
                this.StandardFontName = standardFontName;
            }
            // use default value if no "fontStyle" provided
            if (fontStyle == null)
            {
                this.FontStyle = FontStyleEnum.Regular;
            }
            else
            {
                this.FontStyle = fontStyle;
            }
            // use default value if no "fontSize" provided
            if (fontSize == null)
            {
                this.FontSize = 11;
            }
            else
            {
                this.FontSize = fontSize;
            }
        }
        


        /// <summary>
        /// Specifies the text.
        /// </summary>
        /// <value>Specifies the text.</value>
        [DataMember(Name="Text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Specifies the color of the text, using the color name (ie: \&quot;red\&quot;) or its RGBa code (ie: \&quot;rgba(255,0,0,1)\&quot;).
        /// </summary>
        /// <value>Specifies the color of the text, using the color name (ie: \&quot;red\&quot;) or its RGBa code (ie: \&quot;rgba(255,0,0,1)\&quot;).</value>
        [DataMember(Name="TextColor", EmitDefaultValue=false)]
        public string TextColor { get; set; }

        /// <summary>
        /// Specifies the name of the font to be used.
        /// </summary>
        /// <value>Specifies the name of the font to be used.</value>
        [DataMember(Name="FontName", EmitDefaultValue=false)]
        public string FontName { get; set; }



        /// <summary>
        /// Specifies the size of the font.
        /// </summary>
        /// <value>Specifies the size of the font.</value>
        [DataMember(Name="FontSize", EmitDefaultValue=false)]
        public int? FontSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFAlignedTextParameters {\n");
            sb.Append("  TextVerticalAlignment: ").Append(TextVerticalAlignment).Append("\n");
            sb.Append("  TextHorizontalAlignment: ").Append(TextHorizontalAlignment).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  TextColor: ").Append(TextColor).Append("\n");
            sb.Append("  FontName: ").Append(FontName).Append("\n");
            sb.Append("  StandardFontName: ").Append(StandardFontName).Append("\n");
            sb.Append("  FontStyle: ").Append(FontStyle).Append("\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
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
            return this.Equals(input as PDFAlignedTextParameters);
        }

        /// <summary>
        /// Returns true if PDFAlignedTextParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFAlignedTextParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFAlignedTextParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TextVerticalAlignment == input.TextVerticalAlignment ||
                    (this.TextVerticalAlignment != null &&
                    this.TextVerticalAlignment.Equals(input.TextVerticalAlignment))
                ) && 
                (
                    this.TextHorizontalAlignment == input.TextHorizontalAlignment ||
                    (this.TextHorizontalAlignment != null &&
                    this.TextHorizontalAlignment.Equals(input.TextHorizontalAlignment))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.TextColor == input.TextColor ||
                    (this.TextColor != null &&
                    this.TextColor.Equals(input.TextColor))
                ) && 
                (
                    this.FontName == input.FontName ||
                    (this.FontName != null &&
                    this.FontName.Equals(input.FontName))
                ) && 
                (
                    this.StandardFontName == input.StandardFontName ||
                    (this.StandardFontName != null &&
                    this.StandardFontName.Equals(input.StandardFontName))
                ) && 
                (
                    this.FontStyle == input.FontStyle ||
                    (this.FontStyle != null &&
                    this.FontStyle.Equals(input.FontStyle))
                ) && 
                (
                    this.FontSize == input.FontSize ||
                    (this.FontSize != null &&
                    this.FontSize.Equals(input.FontSize))
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
                if (this.TextVerticalAlignment != null)
                    hashCode = hashCode * 59 + this.TextVerticalAlignment.GetHashCode();
                if (this.TextHorizontalAlignment != null)
                    hashCode = hashCode * 59 + this.TextHorizontalAlignment.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.TextColor != null)
                    hashCode = hashCode * 59 + this.TextColor.GetHashCode();
                if (this.FontName != null)
                    hashCode = hashCode * 59 + this.FontName.GetHashCode();
                if (this.StandardFontName != null)
                    hashCode = hashCode * 59 + this.StandardFontName.GetHashCode();
                if (this.FontStyle != null)
                    hashCode = hashCode * 59 + this.FontStyle.GetHashCode();
                if (this.FontSize != null)
                    hashCode = hashCode * 59 + this.FontSize.GetHashCode();
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
