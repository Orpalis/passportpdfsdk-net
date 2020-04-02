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
    /// Represents information about the Rubber Stamp Annotation.
    /// </summary>
    [DataContract]
    public partial class RubberStampAnnotationParameters :  IEquatable<RubberStampAnnotationParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RubberStampAnnotationParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RubberStampAnnotationParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="RubberStampAnnotationParameters" /> class.
        /// </summary>
        /// <param name="annotationLayout">annotationLayout (required).</param>
        public RubberStampAnnotationParameters(DrawableContentLayoutParameters annotationLayout)
        {
            AnnotationLayout = annotationLayout;
        }

        /// <summary>
        /// Gets or Sets AnnotationLayout
        /// </summary>
        [DataMember(Name="AnnotationLayout")]
        public DrawableContentLayoutParameters AnnotationLayout { get; set; }

        /// <summary>
        /// Gets or Sets RubberStampIcon
        /// </summary>
        [DataMember(Name="RubberStampIcon")]
        public RubberStampAnnotationIcon RubberStampIcon { get; set; }

        /// <summary>
        /// Specifies the title of the annotation, if any.
        /// </summary>
        [DataMember(Name="Title")]
        public string Title { get; set; }

        /// <summary>
        /// Specify the content of the annotation, if any.
        /// </summary>
        [DataMember(Name="Content")]
        public string Content { get; set; }

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
            return Equals(input as RubberStampAnnotationParameters);
        }

        /// <summary>
        /// Returns true if RubberStampAnnotationParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of RubberStampAnnotationParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RubberStampAnnotationParameters input)
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
                    RubberStampIcon == input.RubberStampIcon ||
                    RubberStampIcon.Equals(input.RubberStampIcon)
                ) && 
                (
                    Title == input.Title ||
                    (Title != null &&
                    Title.Equals(input.Title))
                ) && 
                (
                    Content == input.Content ||
                    (Content != null &&
                    Content.Equals(input.Content))
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
                hashCode = hashCode * 59 + RubberStampIcon.GetHashCode();
                if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                if (Content != null)
                    hashCode = hashCode * 59 + Content.GetHashCode();
                if (Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();
                return hashCode;
            }
        }
    }

}
