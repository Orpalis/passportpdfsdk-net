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
    /// Represents information about the FreeText Annotation.
    /// </summary>
    [DataContract]
    public partial class FreeTextAnnotationParameters :  IEquatable<FreeTextAnnotationParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FreeTextAnnotationParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FreeTextAnnotationParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FreeTextAnnotationParameters" /> class.
        /// </summary>
        /// <param name="annotationLayout">annotationLayout (required).</param>
        /// <param name="textParameters">textParameters.</param>
        /// <param name="title">Specifies the title of the annotation, if any..</param>
        /// <param name="subject">Specify the subject of the annotation, if any..</param>
        /// <param name="showBorder">Specifies if the annotation border shall be drawn..</param>
        /// <param name="color">Specifies the color of the annotation, using the color name (ie: \&quot;red\&quot;) or its RGBa code (ie: \&quot;rgba(255,0,0,1)\&quot;). (default to &quot;red&quot;).</param>
        public FreeTextAnnotationParameters(DrawableContentLayoutParameters annotationLayout = default(DrawableContentLayoutParameters), PDFTextParameters textParameters = default(PDFTextParameters), string title = default(string), string subject = default(string), bool? showBorder = default(bool?), string color = "red")
        {
            // to ensure "annotationLayout" is required (not null)
            if (annotationLayout == null)
            {
                throw new InvalidDataException("annotationLayout is a required property for FreeTextAnnotationParameters and cannot be null");
            }
            else
            {
                this.AnnotationLayout = annotationLayout;
            }
            
            this.TextParameters = textParameters;
            this.Title = title;
            this.Subject = subject;
            this.ShowBorder = showBorder;
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
        /// Gets or Sets TextParameters
        /// </summary>
        [DataMember(Name="TextParameters", EmitDefaultValue=false)]
        public PDFTextParameters TextParameters { get; set; }

        /// <summary>
        /// Specifies the title of the annotation, if any.
        /// </summary>
        /// <value>Specifies the title of the annotation, if any.</value>
        [DataMember(Name="Title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Specify the subject of the annotation, if any.
        /// </summary>
        /// <value>Specify the subject of the annotation, if any.</value>
        [DataMember(Name="Subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Specifies if the annotation border shall be drawn.
        /// </summary>
        /// <value>Specifies if the annotation border shall be drawn.</value>
        [DataMember(Name="ShowBorder", EmitDefaultValue=false)]
        public bool? ShowBorder { get; set; }

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
            sb.Append("class FreeTextAnnotationParameters {\n");
            sb.Append("  AnnotationLayout: ").Append(AnnotationLayout).Append("\n");
            sb.Append("  TextParameters: ").Append(TextParameters).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  ShowBorder: ").Append(ShowBorder).Append("\n");
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
            return this.Equals(input as FreeTextAnnotationParameters);
        }

        /// <summary>
        /// Returns true if FreeTextAnnotationParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of FreeTextAnnotationParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FreeTextAnnotationParameters input)
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
                    this.TextParameters == input.TextParameters ||
                    (this.TextParameters != null &&
                    this.TextParameters.Equals(input.TextParameters))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.ShowBorder == input.ShowBorder ||
                    (this.ShowBorder != null &&
                    this.ShowBorder.Equals(input.ShowBorder))
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
                if (this.TextParameters != null)
                    hashCode = hashCode * 59 + this.TextParameters.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.ShowBorder != null)
                    hashCode = hashCode * 59 + this.ShowBorder.GetHashCode();
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
