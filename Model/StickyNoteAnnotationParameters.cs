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
    /// Represents information about the Sticky Note Annotation.
    /// </summary>
    [DataContract]
    public partial class StickyNoteAnnotationParameters :  IEquatable<StickyNoteAnnotationParameters>, IValidatableObject
    {
        /// <summary>
        /// Specifies the icon to be used for a sticky note annotation.
        /// </summary>
        /// <value>Specifies the icon to be used for a sticky note annotation.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StickyNoteIconEnum
        {
            /// <summary>
            /// Enum Comment for value: Comment
            /// </summary>
            [EnumMember(Value = "Comment")]
            Comment = 1,

            /// <summary>
            /// Enum Key for value: Key
            /// </summary>
            [EnumMember(Value = "Key")]
            Key = 2,

            /// <summary>
            /// Enum Note for value: Note
            /// </summary>
            [EnumMember(Value = "Note")]
            Note = 3,

            /// <summary>
            /// Enum Help for value: Help
            /// </summary>
            [EnumMember(Value = "Help")]
            Help = 4,

            /// <summary>
            /// Enum NewParagraph for value: NewParagraph
            /// </summary>
            [EnumMember(Value = "NewParagraph")]
            NewParagraph = 5,

            /// <summary>
            /// Enum Paragraph for value: Paragraph
            /// </summary>
            [EnumMember(Value = "Paragraph")]
            Paragraph = 6,

            /// <summary>
            /// Enum Insert for value: Insert
            /// </summary>
            [EnumMember(Value = "Insert")]
            Insert = 7,

            /// <summary>
            /// Enum Check for value: Check
            /// </summary>
            [EnumMember(Value = "Check")]
            Check = 8,

            /// <summary>
            /// Enum Circle for value: Circle
            /// </summary>
            [EnumMember(Value = "Circle")]
            Circle = 9,

            /// <summary>
            /// Enum Cross for value: Cross
            /// </summary>
            [EnumMember(Value = "Cross")]
            Cross = 10,

            /// <summary>
            /// Enum CrossHairs for value: CrossHairs
            /// </summary>
            [EnumMember(Value = "CrossHairs")]
            CrossHairs = 11,

            /// <summary>
            /// Enum RightArrow for value: RightArrow
            /// </summary>
            [EnumMember(Value = "RightArrow")]
            RightArrow = 12,

            /// <summary>
            /// Enum RightPointer for value: RightPointer
            /// </summary>
            [EnumMember(Value = "RightPointer")]
            RightPointer = 13,

            /// <summary>
            /// Enum Star for value: Star
            /// </summary>
            [EnumMember(Value = "Star")]
            Star = 14,

            /// <summary>
            /// Enum UpArrow for value: UpArrow
            /// </summary>
            [EnumMember(Value = "UpArrow")]
            UpArrow = 15,

            /// <summary>
            /// Enum UpLeftArrow for value: UpLeftArrow
            /// </summary>
            [EnumMember(Value = "UpLeftArrow")]
            UpLeftArrow = 16

        }

        /// <summary>
        /// Specifies the icon to be used for a sticky note annotation.
        /// </summary>
        /// <value>Specifies the icon to be used for a sticky note annotation.</value>
        [DataMember(Name="StickyNoteIcon", EmitDefaultValue=false)]
        public StickyNoteIconEnum? StickyNoteIcon { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StickyNoteAnnotationParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StickyNoteAnnotationParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StickyNoteAnnotationParameters" /> class.
        /// </summary>
        /// <param name="annotationLayout">annotationLayout (required).</param>
        /// <param name="stickyNoteIcon">Specifies the icon to be used for a sticky note annotation. (default to StickyNoteIconEnum.Comment).</param>
        /// <param name="author">Specify the author of the annotation, if any..</param>
        /// <param name="subject">Specify the subject of the annotation, if any..</param>
        /// <param name="content">Specify the content of the annotation, if any..</param>
        /// <param name="openPopup">Specifies if the popup of annotation shall be opened by default..</param>
        /// <param name="color">Specifies the color of the annotation, using the color name (ie: \&quot;red\&quot;) or its RGBa code (ie: \&quot;rgba(255,0,0,1)\&quot;). (default to &quot;red&quot;).</param>
        public StickyNoteAnnotationParameters(DrawableContentLayoutParameters annotationLayout = default(DrawableContentLayoutParameters), StickyNoteIconEnum? stickyNoteIcon = StickyNoteIconEnum.Comment, string author = default(string), string subject = default(string), string content = default(string), bool? openPopup = default(bool?), string color = "red")
        {
            // to ensure "annotationLayout" is required (not null)
            if (annotationLayout == null)
            {
                throw new InvalidDataException("annotationLayout is a required property for StickyNoteAnnotationParameters and cannot be null");
            }
            else
            {
                this.AnnotationLayout = annotationLayout;
            }
            
            // use default value if no "stickyNoteIcon" provided
            if (stickyNoteIcon == null)
            {
                this.StickyNoteIcon = StickyNoteIconEnum.Comment;
            }
            else
            {
                this.StickyNoteIcon = stickyNoteIcon;
            }
            this.Author = author;
            this.Subject = subject;
            this.Content = content;
            this.OpenPopup = openPopup;
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
        /// Specify the author of the annotation, if any.
        /// </summary>
        /// <value>Specify the author of the annotation, if any.</value>
        [DataMember(Name="Author", EmitDefaultValue=false)]
        public string Author { get; set; }

        /// <summary>
        /// Specify the subject of the annotation, if any.
        /// </summary>
        /// <value>Specify the subject of the annotation, if any.</value>
        [DataMember(Name="Subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

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
        [DataMember(Name="OpenPopup", EmitDefaultValue=false)]
        public bool? OpenPopup { get; set; }

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
            sb.Append("class StickyNoteAnnotationParameters {\n");
            sb.Append("  AnnotationLayout: ").Append(AnnotationLayout).Append("\n");
            sb.Append("  StickyNoteIcon: ").Append(StickyNoteIcon).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  OpenPopup: ").Append(OpenPopup).Append("\n");
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
            return this.Equals(input as StickyNoteAnnotationParameters);
        }

        /// <summary>
        /// Returns true if StickyNoteAnnotationParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of StickyNoteAnnotationParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StickyNoteAnnotationParameters input)
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
                    this.StickyNoteIcon == input.StickyNoteIcon ||
                    (this.StickyNoteIcon != null &&
                    this.StickyNoteIcon.Equals(input.StickyNoteIcon))
                ) && 
                (
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.OpenPopup == input.OpenPopup ||
                    (this.OpenPopup != null &&
                    this.OpenPopup.Equals(input.OpenPopup))
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
                if (this.StickyNoteIcon != null)
                    hashCode = hashCode * 59 + this.StickyNoteIcon.GetHashCode();
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.OpenPopup != null)
                    hashCode = hashCode * 59 + this.OpenPopup.GetHashCode();
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
