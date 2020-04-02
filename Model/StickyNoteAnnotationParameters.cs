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
    /// Represents information about the Sticky Note Annotation.
    /// </summary>
    [DataContract]
    public partial class StickyNoteAnnotationParameters :  IEquatable<StickyNoteAnnotationParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StickyNoteAnnotationParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StickyNoteAnnotationParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="StickyNoteAnnotationParameters" /> class.
        /// </summary>
        /// <param name="annotationLayout">annotationLayout (required).</param>
        public StickyNoteAnnotationParameters(DrawableContentLayoutParameters annotationLayout)
        {
            AnnotationLayout = annotationLayout;
        }

        /// <summary>
        /// Gets or Sets AnnotationLayout
        /// </summary>
        [DataMember(Name="AnnotationLayout")]
        public DrawableContentLayoutParameters AnnotationLayout { get; set; }

        /// <summary>
        /// Gets or Sets StickyNoteIcon
        /// </summary>
        [DataMember(Name="StickyNoteIcon")]
        public StickyNoteAnnotationIcon StickyNoteIcon { get; set; }

        /// <summary>
        /// Specify the author of the annotation, if any.
        /// </summary>
        [DataMember(Name="Author")]
        public string Author { get; set; }

        /// <summary>
        /// Specify the subject of the annotation, if any.
        /// </summary>
        [DataMember(Name="Subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Specify the content of the annotation, if any.
        /// </summary>
        [DataMember(Name="Content")]
        public string Content { get; set; }

        /// <summary>
        /// Specifies if the popup of annotation shall be opened by default.
        /// </summary>
        [DataMember(Name="OpenPopup")]
        public bool OpenPopup { get; set; }

        /// <summary>
        /// Specifies the color of the annotation, using the color name (ie: \"red\") or its RGBa code (ie: \"rgba(255,0,0,1)\").
        /// </summary>
        [DataMember(Name="Color")]
        public string Color { get; set; } = "red";

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
            return Equals(input as StickyNoteAnnotationParameters);
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
                    AnnotationLayout == input.AnnotationLayout ||
                    (AnnotationLayout != null &&
                    AnnotationLayout.Equals(input.AnnotationLayout))
                ) && 
                (
                    StickyNoteIcon == input.StickyNoteIcon ||
                    StickyNoteIcon.Equals(input.StickyNoteIcon)
                ) && 
                (
                    Author == input.Author ||
                    (Author != null &&
                    Author.Equals(input.Author))
                ) && 
                (
                    Subject == input.Subject ||
                    (Subject != null &&
                    Subject.Equals(input.Subject))
                ) && 
                (
                    Content == input.Content ||
                    (Content != null &&
                    Content.Equals(input.Content))
                ) && 
                (
                    OpenPopup == input.OpenPopup ||
                    OpenPopup.Equals(input.OpenPopup)
                ) && 
                (
                    Color == input.Color ||
                    (Color != null &&
                    Color.Equals(input.Color))
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
                if (AnnotationLayout != null)
                    hashCode = hashCode * 59 + AnnotationLayout.GetHashCode();
                hashCode = hashCode * 59 + StickyNoteIcon.GetHashCode();
                if (Author != null)
                    hashCode = hashCode * 59 + Author.GetHashCode();
                if (Subject != null)
                    hashCode = hashCode * 59 + Subject.GetHashCode();
                if (Content != null)
                    hashCode = hashCode * 59 + Content.GetHashCode();
                hashCode = hashCode * 59 + OpenPopup.GetHashCode();
                if (Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();
                return hashCode;
            }
        }
    }

}
