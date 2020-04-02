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
    /// Represents information about the FreeText Annotation.
    /// </summary>
    [DataContract]
    public partial class FreeTextAnnotationParameters :  IEquatable<FreeTextAnnotationParameters>
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
        public FreeTextAnnotationParameters(DrawableContentLayoutParameters annotationLayout)
        {
            AnnotationLayout = annotationLayout;
        }

        /// <summary>
        /// Gets or Sets AnnotationLayout
        /// </summary>
        [DataMember(Name="AnnotationLayout")]
        public DrawableContentLayoutParameters AnnotationLayout { get; set; }

        /// <summary>
        /// Gets or Sets TextParameters
        /// </summary>
        [DataMember(Name="TextParameters")]
        public PdfTextParameters TextParameters { get; set; }

        /// <summary>
        /// Specifies the title of the annotation, if any.
        /// </summary>
        [DataMember(Name="Title")]
        public string Title { get; set; }

        /// <summary>
        /// Specify the subject of the annotation, if any.
        /// </summary>
        [DataMember(Name="Subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Specifies if the annotation border shall be drawn.
        /// </summary>
        [DataMember(Name="ShowBorder")]
        public bool ShowBorder { get; set; }

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
            return Equals(input as FreeTextAnnotationParameters);
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
                    AnnotationLayout == input.AnnotationLayout ||
                    (AnnotationLayout != null &&
                    AnnotationLayout.Equals(input.AnnotationLayout))
                ) && 
                (
                    TextParameters == input.TextParameters ||
                    (TextParameters != null &&
                    TextParameters.Equals(input.TextParameters))
                ) && 
                (
                    Title == input.Title ||
                    (Title != null &&
                    Title.Equals(input.Title))
                ) && 
                (
                    Subject == input.Subject ||
                    (Subject != null &&
                    Subject.Equals(input.Subject))
                ) && 
                (
                    ShowBorder == input.ShowBorder ||
                    ShowBorder.Equals(input.ShowBorder)
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
                if (TextParameters != null)
                    hashCode = hashCode * 59 + TextParameters.GetHashCode();
                if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                if (Subject != null)
                    hashCode = hashCode * 59 + Subject.GetHashCode();
                hashCode = hashCode * 59 + ShowBorder.GetHashCode();
                if (Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();
                return hashCode;
            }
        }
    }

}
