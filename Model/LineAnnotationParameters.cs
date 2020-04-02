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
    /// Represents information about the Line Annotation.
    /// </summary>
    [DataContract]
    public partial class LineAnnotationParameters :  IEquatable<LineAnnotationParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LineAnnotationParameters" /> class.
        /// </summary>
        public LineAnnotationParameters()
        {
        }

        /// <summary>
        /// Specifies if the horizontal coordinate of line annotation start point.
        /// </summary>
        [DataMember(Name="LineStartX")]
        public float LineStartX { get; set; }

        /// <summary>
        /// Specifies if the vertical coordinate of line annotation start point.
        /// </summary>
        [DataMember(Name="LineStartY")]
        public float LineStartY { get; set; }

        /// <summary>
        /// Specifies if the horizontal coordinate of line annotation end point.
        /// </summary>
        [DataMember(Name="LineEndX")]
        public float LineEndX { get; set; }

        /// <summary>
        /// Specifies if the vertical coordinate of line annotation end point.
        /// </summary>
        [DataMember(Name="LineEndY")]
        public float LineEndY { get; set; }

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
        /// Gets or Sets LineStartStyle
        /// </summary>
        [DataMember(Name="LineStartStyle")]
        public LineAnnotationEndingStyle LineStartStyle { get; set; }

        /// <summary>
        /// Gets or Sets LineEndStyle
        /// </summary>
        [DataMember(Name="LineEndStyle")]
        public LineAnnotationEndingStyle LineEndStyle { get; set; }

        /// <summary>
        /// Specifies if the popup of annotation shall be opened by default.
        /// </summary>
        [DataMember(Name="ShowContent")]
        public bool ShowContent { get; set; }

        /// <summary>
        /// Gets or Sets LineWidth
        /// </summary>
        [DataMember(Name="LineWidth")]
        public ContentSize LineWidth { get; set; }

        /// <summary>
        /// Specifies the absolute line width of the annotation, in points.
        /// </summary>
        [DataMember(Name="AbsoluteAnnotationLineWidth")]
        public float AbsoluteAnnotationLineWidth { get; set; }

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
            return Equals(input as LineAnnotationParameters);
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
                    LineStartX == input.LineStartX ||
                    LineStartX.Equals(input.LineStartX)
                ) && 
                (
                    LineStartY == input.LineStartY ||
                    LineStartY.Equals(input.LineStartY)
                ) && 
                (
                    LineEndX == input.LineEndX ||
                    LineEndX.Equals(input.LineEndX)
                ) && 
                (
                    LineEndY == input.LineEndY ||
                    LineEndY.Equals(input.LineEndY)
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
                    LineStartStyle == input.LineStartStyle ||
                    LineStartStyle.Equals(input.LineStartStyle)
                ) && 
                (
                    LineEndStyle == input.LineEndStyle ||
                    LineEndStyle.Equals(input.LineEndStyle)
                ) && 
                (
                    ShowContent == input.ShowContent ||
                    ShowContent.Equals(input.ShowContent)
                ) && 
                (
                    LineWidth == input.LineWidth ||
                    LineWidth.Equals(input.LineWidth)
                ) && 
                (
                    AbsoluteAnnotationLineWidth == input.AbsoluteAnnotationLineWidth ||
                    AbsoluteAnnotationLineWidth.Equals(input.AbsoluteAnnotationLineWidth)
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
                hashCode = hashCode * 59 + LineStartX.GetHashCode();
                hashCode = hashCode * 59 + LineStartY.GetHashCode();
                hashCode = hashCode * 59 + LineEndX.GetHashCode();
                hashCode = hashCode * 59 + LineEndY.GetHashCode();
                if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                if (Content != null)
                    hashCode = hashCode * 59 + Content.GetHashCode();
                hashCode = hashCode * 59 + LineStartStyle.GetHashCode();
                hashCode = hashCode * 59 + LineEndStyle.GetHashCode();
                hashCode = hashCode * 59 + ShowContent.GetHashCode();
                hashCode = hashCode * 59 + LineWidth.GetHashCode();
                hashCode = hashCode * 59 + AbsoluteAnnotationLineWidth.GetHashCode();
                if (Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();
                return hashCode;
            }
        }
    }

}
