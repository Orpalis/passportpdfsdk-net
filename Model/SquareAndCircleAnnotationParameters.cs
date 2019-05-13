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
    /// Represents information about the Square / Circle Annotation.
    /// </summary>
    [DataContract]
    public partial class SquareAndCircleAnnotationParameters :  IEquatable<SquareAndCircleAnnotationParameters>, IValidatableObject
    {
        /// <summary>
        /// Specifies the thickness of the annotation.
        /// </summary>
        /// <value>Specifies the thickness of the annotation.</value>
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
        /// Specifies the thickness of the annotation.
        /// </summary>
        /// <value>Specifies the thickness of the annotation.</value>
        [DataMember(Name="LineWidth", EmitDefaultValue=false)]
        public LineWidthEnum? LineWidth { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SquareAndCircleAnnotationParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SquareAndCircleAnnotationParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SquareAndCircleAnnotationParameters" /> class.
        /// </summary>
        /// <param name="annotationLayout">annotationLayout (required).</param>
        /// <param name="title">Specifies the title of the annotation, if any..</param>
        /// <param name="content">Specify the content of the annotation, if any..</param>
        /// <param name="lineWidth">Specifies the thickness of the annotation. (default to LineWidthEnum.Medium).</param>
        /// <param name="absoluteAnnotationLineWidth">Specifies the absolute thickness of the annotation, in points..</param>
        /// <param name="color">Specifies the color of the annotation, using the color name (ie: \&quot;red\&quot;) or its RGBa code (ie: \&quot;rgba(255,0,0,1)\&quot;). (default to &quot;red&quot;).</param>
        public SquareAndCircleAnnotationParameters(DrawableContentLayoutParameters annotationLayout = default(DrawableContentLayoutParameters), string title = default(string), string content = default(string), LineWidthEnum? lineWidth = LineWidthEnum.Medium, float? absoluteAnnotationLineWidth = default(float?), string color = "red")
        {
            // to ensure "annotationLayout" is required (not null)
            if (annotationLayout == null)
            {
                throw new InvalidDataException("annotationLayout is a required property for SquareAndCircleAnnotationParameters and cannot be null");
            }
            else
            {
                this.AnnotationLayout = annotationLayout;
            }
            
            this.Title = title;
            this.Content = content;
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
        /// Gets or Sets AnnotationLayout
        /// </summary>
        [DataMember(Name="AnnotationLayout", EmitDefaultValue=false)]
        public DrawableContentLayoutParameters AnnotationLayout { get; set; }

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
        /// Specifies the absolute thickness of the annotation, in points.
        /// </summary>
        /// <value>Specifies the absolute thickness of the annotation, in points.</value>
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
            sb.Append("class SquareAndCircleAnnotationParameters {\n");
            sb.Append("  AnnotationLayout: ").Append(AnnotationLayout).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
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
            return this.Equals(input as SquareAndCircleAnnotationParameters);
        }

        /// <summary>
        /// Returns true if SquareAndCircleAnnotationParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of SquareAndCircleAnnotationParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SquareAndCircleAnnotationParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AnnotationLayout == input.AnnotationLayout ||
                    (this.AnnotationLayout != null &&
                    this.AnnotationLayout.Equals(input.AnnotationLayout))
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
                if (this.AnnotationLayout != null)
                    hashCode = hashCode * 59 + this.AnnotationLayout.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
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
