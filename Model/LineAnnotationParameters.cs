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
    /// Represents information about the Line Annotation.
    /// </summary>
    [DataContract]
    public partial class LineAnnotationParameters :  IEquatable<LineAnnotationParameters>, IValidatableObject
    {
        /// <summary>
        /// Specifies the line ending style for the start point of the line annotation.
        /// </summary>
        /// <value>Specifies the line ending style for the start point of the line annotation.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LineStartStyleEnum
        {
            /// <summary>
            /// Enum Square for value: Square
            /// </summary>
            [EnumMember(Value = "Square")]
            Square = 1,

            /// <summary>
            /// Enum Circle for value: Circle
            /// </summary>
            [EnumMember(Value = "Circle")]
            Circle = 2,

            /// <summary>
            /// Enum Diamond for value: Diamond
            /// </summary>
            [EnumMember(Value = "Diamond")]
            Diamond = 3,

            /// <summary>
            /// Enum OpenArrow for value: OpenArrow
            /// </summary>
            [EnumMember(Value = "OpenArrow")]
            OpenArrow = 4,

            /// <summary>
            /// Enum ClosedArrow for value: ClosedArrow
            /// </summary>
            [EnumMember(Value = "ClosedArrow")]
            ClosedArrow = 5,

            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 6,

            /// <summary>
            /// Enum Butt for value: Butt
            /// </summary>
            [EnumMember(Value = "Butt")]
            Butt = 7,

            /// <summary>
            /// Enum ReversedOpenArrow for value: ReversedOpenArrow
            /// </summary>
            [EnumMember(Value = "ReversedOpenArrow")]
            ReversedOpenArrow = 8,

            /// <summary>
            /// Enum ReversedClosedArrow for value: ReversedClosedArrow
            /// </summary>
            [EnumMember(Value = "ReversedClosedArrow")]
            ReversedClosedArrow = 9,

            /// <summary>
            /// Enum Slash for value: Slash
            /// </summary>
            [EnumMember(Value = "Slash")]
            Slash = 10

        }

        /// <summary>
        /// Specifies the line ending style for the start point of the line annotation.
        /// </summary>
        /// <value>Specifies the line ending style for the start point of the line annotation.</value>
        [DataMember(Name="LineStartStyle", EmitDefaultValue=false)]
        public LineStartStyleEnum? LineStartStyle { get; set; }
        /// <summary>
        /// Specifies the line ending style for the start point of the line annotation.
        /// </summary>
        /// <value>Specifies the line ending style for the start point of the line annotation.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LineEndStyleEnum
        {
            /// <summary>
            /// Enum Square for value: Square
            /// </summary>
            [EnumMember(Value = "Square")]
            Square = 1,

            /// <summary>
            /// Enum Circle for value: Circle
            /// </summary>
            [EnumMember(Value = "Circle")]
            Circle = 2,

            /// <summary>
            /// Enum Diamond for value: Diamond
            /// </summary>
            [EnumMember(Value = "Diamond")]
            Diamond = 3,

            /// <summary>
            /// Enum OpenArrow for value: OpenArrow
            /// </summary>
            [EnumMember(Value = "OpenArrow")]
            OpenArrow = 4,

            /// <summary>
            /// Enum ClosedArrow for value: ClosedArrow
            /// </summary>
            [EnumMember(Value = "ClosedArrow")]
            ClosedArrow = 5,

            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 6,

            /// <summary>
            /// Enum Butt for value: Butt
            /// </summary>
            [EnumMember(Value = "Butt")]
            Butt = 7,

            /// <summary>
            /// Enum ReversedOpenArrow for value: ReversedOpenArrow
            /// </summary>
            [EnumMember(Value = "ReversedOpenArrow")]
            ReversedOpenArrow = 8,

            /// <summary>
            /// Enum ReversedClosedArrow for value: ReversedClosedArrow
            /// </summary>
            [EnumMember(Value = "ReversedClosedArrow")]
            ReversedClosedArrow = 9,

            /// <summary>
            /// Enum Slash for value: Slash
            /// </summary>
            [EnumMember(Value = "Slash")]
            Slash = 10

        }

        /// <summary>
        /// Specifies the line ending style for the start point of the line annotation.
        /// </summary>
        /// <value>Specifies the line ending style for the start point of the line annotation.</value>
        [DataMember(Name="LineEndStyle", EmitDefaultValue=false)]
        public LineEndStyleEnum? LineEndStyle { get; set; }
        /// <summary>
        /// Specifies the line width of the annotation.
        /// </summary>
        /// <value>Specifies the line width of the annotation.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LineWidthEnum
        {
            /// <summary>
            /// Enum Small for value: Small
            /// </summary>
            [EnumMember(Value = "Small")]
            Small = 1,

            /// <summary>
            /// Enum Medium for value: Medium
            /// </summary>
            [EnumMember(Value = "Medium")]
            Medium = 2,

            /// <summary>
            /// Enum Large for value: Large
            /// </summary>
            [EnumMember(Value = "Large")]
            Large = 3,

            /// <summary>
            /// Enum Absolute for value: Absolute
            /// </summary>
            [EnumMember(Value = "Absolute")]
            Absolute = 4,

            /// <summary>
            /// Enum AutoFit for value: AutoFit
            /// </summary>
            [EnumMember(Value = "AutoFit")]
            AutoFit = 5

        }

        /// <summary>
        /// Specifies the line width of the annotation.
        /// </summary>
        /// <value>Specifies the line width of the annotation.</value>
        [DataMember(Name="LineWidth", EmitDefaultValue=false)]
        public LineWidthEnum? LineWidth { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LineAnnotationParameters" /> class.
        /// </summary>
        /// <param name="lineStartX">Specifies if the horizontal coordinate of line annotation start point..</param>
        /// <param name="lineStartY">Specifies if the vertical coordinate of line annotation start point..</param>
        /// <param name="lineEndX">Specifies if the horizontal coordinate of line annotation end point..</param>
        /// <param name="lineEndY">Specifies if the vertical coordinate of line annotation end point..</param>
        /// <param name="title">Specifies the title of the annotation, if any..</param>
        /// <param name="content">Specify the content of the annotation, if any..</param>
        /// <param name="lineStartStyle">Specifies the line ending style for the start point of the line annotation. (default to LineStartStyleEnum.None).</param>
        /// <param name="lineEndStyle">Specifies the line ending style for the start point of the line annotation. (default to LineEndStyleEnum.None).</param>
        /// <param name="showContent">Specifies if the popup of annotation shall be opened by default..</param>
        /// <param name="lineWidth">Specifies the line width of the annotation. (default to LineWidthEnum.Medium).</param>
        /// <param name="absoluteAnnotationLineWidth">Specifies the absolute line width of the annotation, in points..</param>
        /// <param name="color">Specifies the color of the annotation, using the color name (ie: \&quot;red\&quot;) or its RGBa code (ie: \&quot;rgba(255,0,0,1)\&quot;). (default to &quot;red&quot;).</param>
        public LineAnnotationParameters(float? lineStartX = default(float?), float? lineStartY = default(float?), float? lineEndX = default(float?), float? lineEndY = default(float?), string title = default(string), string content = default(string), LineStartStyleEnum? lineStartStyle = LineStartStyleEnum.None, LineEndStyleEnum? lineEndStyle = LineEndStyleEnum.None, bool? showContent = default(bool?), LineWidthEnum? lineWidth = LineWidthEnum.Medium, float? absoluteAnnotationLineWidth = default(float?), string color = "red")
        {
            this.LineStartX = lineStartX;
            this.LineStartY = lineStartY;
            this.LineEndX = lineEndX;
            this.LineEndY = lineEndY;
            this.Title = title;
            this.Content = content;
            // use default value if no "lineStartStyle" provided
            if (lineStartStyle == null)
            {
                this.LineStartStyle = LineStartStyleEnum.None;
            }
            else
            {
                this.LineStartStyle = lineStartStyle;
            }
            // use default value if no "lineEndStyle" provided
            if (lineEndStyle == null)
            {
                this.LineEndStyle = LineEndStyleEnum.None;
            }
            else
            {
                this.LineEndStyle = lineEndStyle;
            }
            this.ShowContent = showContent;
            // use default value if no "lineWidth" provided
            if (lineWidth == null)
            {
                this.LineWidth = LineWidthEnum.Medium;
            }
            else
            {
                this.LineWidth = lineWidth;
            }
            this.AbsoluteAnnotationLineWidth = absoluteAnnotationLineWidth;
            // use default value if no "color" provided
            if (color == null)
            {
                this.Color = "red";
            }
            else
            {
                this.Color = color;
            }
        }
        
        /// <summary>
        /// Specifies if the horizontal coordinate of line annotation start point.
        /// </summary>
        /// <value>Specifies if the horizontal coordinate of line annotation start point.</value>
        [DataMember(Name="LineStartX", EmitDefaultValue=false)]
        public float? LineStartX { get; set; }

        /// <summary>
        /// Specifies if the vertical coordinate of line annotation start point.
        /// </summary>
        /// <value>Specifies if the vertical coordinate of line annotation start point.</value>
        [DataMember(Name="LineStartY", EmitDefaultValue=false)]
        public float? LineStartY { get; set; }

        /// <summary>
        /// Specifies if the horizontal coordinate of line annotation end point.
        /// </summary>
        /// <value>Specifies if the horizontal coordinate of line annotation end point.</value>
        [DataMember(Name="LineEndX", EmitDefaultValue=false)]
        public float? LineEndX { get; set; }

        /// <summary>
        /// Specifies if the vertical coordinate of line annotation end point.
        /// </summary>
        /// <value>Specifies if the vertical coordinate of line annotation end point.</value>
        [DataMember(Name="LineEndY", EmitDefaultValue=false)]
        public float? LineEndY { get; set; }

        /// <summary>
        /// Specifies the title of the annotation, if any.
        /// </summary>
        /// <value>Specifies the title of the annotation, if any.</value>
        [DataMember(Name="Title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Specify the content of the annotation, if any.
        /// </summary>
        /// <value>Specify the content of the annotation, if any.</value>
        [DataMember(Name="Content", EmitDefaultValue=false)]
        public string Content { get; set; }



        /// <summary>
        /// Specifies if the popup of annotation shall be opened by default.
        /// </summary>
        /// <value>Specifies if the popup of annotation shall be opened by default.</value>
        [DataMember(Name="ShowContent", EmitDefaultValue=false)]
        public bool? ShowContent { get; set; }


        /// <summary>
        /// Specifies the absolute line width of the annotation, in points.
        /// </summary>
        /// <value>Specifies the absolute line width of the annotation, in points.</value>
        [DataMember(Name="AbsoluteAnnotationLineWidth", EmitDefaultValue=false)]
        public float? AbsoluteAnnotationLineWidth { get; set; }

        /// <summary>
        /// Specifies the color of the annotation, using the color name (ie: \&quot;red\&quot;) or its RGBa code (ie: \&quot;rgba(255,0,0,1)\&quot;).
        /// </summary>
        /// <value>Specifies the color of the annotation, using the color name (ie: \&quot;red\&quot;) or its RGBa code (ie: \&quot;rgba(255,0,0,1)\&quot;).</value>
        [DataMember(Name="Color", EmitDefaultValue=false)]
        public string Color { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineAnnotationParameters {\n");
            sb.Append("  LineStartX: ").Append(LineStartX).Append("\n");
            sb.Append("  LineStartY: ").Append(LineStartY).Append("\n");
            sb.Append("  LineEndX: ").Append(LineEndX).Append("\n");
            sb.Append("  LineEndY: ").Append(LineEndY).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  LineStartStyle: ").Append(LineStartStyle).Append("\n");
            sb.Append("  LineEndStyle: ").Append(LineEndStyle).Append("\n");
            sb.Append("  ShowContent: ").Append(ShowContent).Append("\n");
            sb.Append("  LineWidth: ").Append(LineWidth).Append("\n");
            sb.Append("  AbsoluteAnnotationLineWidth: ").Append(AbsoluteAnnotationLineWidth).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
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
            return this.Equals(input as LineAnnotationParameters);
        }

        /// <summary>
        /// Returns true if LineAnnotationParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of LineAnnotationParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineAnnotationParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LineStartX == input.LineStartX ||
                    (this.LineStartX != null &&
                    this.LineStartX.Equals(input.LineStartX))
                ) && 
                (
                    this.LineStartY == input.LineStartY ||
                    (this.LineStartY != null &&
                    this.LineStartY.Equals(input.LineStartY))
                ) && 
                (
                    this.LineEndX == input.LineEndX ||
                    (this.LineEndX != null &&
                    this.LineEndX.Equals(input.LineEndX))
                ) && 
                (
                    this.LineEndY == input.LineEndY ||
                    (this.LineEndY != null &&
                    this.LineEndY.Equals(input.LineEndY))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.LineStartStyle == input.LineStartStyle ||
                    (this.LineStartStyle != null &&
                    this.LineStartStyle.Equals(input.LineStartStyle))
                ) && 
                (
                    this.LineEndStyle == input.LineEndStyle ||
                    (this.LineEndStyle != null &&
                    this.LineEndStyle.Equals(input.LineEndStyle))
                ) && 
                (
                    this.ShowContent == input.ShowContent ||
                    (this.ShowContent != null &&
                    this.ShowContent.Equals(input.ShowContent))
                ) && 
                (
                    this.LineWidth == input.LineWidth ||
                    (this.LineWidth != null &&
                    this.LineWidth.Equals(input.LineWidth))
                ) && 
                (
                    this.AbsoluteAnnotationLineWidth == input.AbsoluteAnnotationLineWidth ||
                    (this.AbsoluteAnnotationLineWidth != null &&
                    this.AbsoluteAnnotationLineWidth.Equals(input.AbsoluteAnnotationLineWidth))
                ) && 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
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
                if (this.LineStartX != null)
                    hashCode = hashCode * 59 + this.LineStartX.GetHashCode();
                if (this.LineStartY != null)
                    hashCode = hashCode * 59 + this.LineStartY.GetHashCode();
                if (this.LineEndX != null)
                    hashCode = hashCode * 59 + this.LineEndX.GetHashCode();
                if (this.LineEndY != null)
                    hashCode = hashCode * 59 + this.LineEndY.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.LineStartStyle != null)
                    hashCode = hashCode * 59 + this.LineStartStyle.GetHashCode();
                if (this.LineEndStyle != null)
                    hashCode = hashCode * 59 + this.LineEndStyle.GetHashCode();
                if (this.ShowContent != null)
                    hashCode = hashCode * 59 + this.ShowContent.GetHashCode();
                if (this.LineWidth != null)
                    hashCode = hashCode * 59 + this.LineWidth.GetHashCode();
                if (this.AbsoluteAnnotationLineWidth != null)
                    hashCode = hashCode * 59 + this.AbsoluteAnnotationLineWidth.GetHashCode();
                if (this.Color != null)
                    hashCode = hashCode * 59 + this.Color.GetHashCode();
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
