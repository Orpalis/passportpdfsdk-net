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
    /// Represents information about the layout of a content, on the page it is drawn onto.
    /// </summary>
    [DataContract]
    public partial class DrawableContentLayoutParameters :  IEquatable<DrawableContentLayoutParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DrawableContentLayoutParameters" /> class.
        /// </summary>
        public DrawableContentLayoutParameters()
        {
        }

        /// <summary>
        /// Gets or Sets HorizontalPosition
        /// </summary>
        [DataMember(Name="HorizontalPosition")]
        public ContentHorizontalPosition HorizontalPosition { get; set; }

        /// <summary>
        /// Gets or Sets VerticalPosition
        /// </summary>
        [DataMember(Name="VerticalPosition")]
        public ContentVerticalPosition VerticalPosition { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="Size")]
        public ContentSize Size { get; set; }

        /// <summary>
        /// Specifies whether the content shall be slightly indented from the nearest page edges.
        /// </summary>
        [DataMember(Name="IndentFromEdges")]
        public bool IndentFromEdges { get; set; } = true;

        /// <summary>
        /// Specifies the absolute horizontal position of the top-left edge of the content, in points.
        /// </summary>
        [DataMember(Name="AbsolutePositionLeft")]
        public float AbsolutePositionLeft { get; set; }

        /// <summary>
        /// Specifies the absolute vertical position of the top-left edge of the content, in points.
        /// </summary>
        [DataMember(Name="AbsolutePositionTop")]
        public float AbsolutePositionTop { get; set; }

        /// <summary>
        /// Specifies the absolute width of the content, in points.
        /// </summary>
        [DataMember(Name="AbsoluteWidth")]
        public float AbsoluteWidth { get; set; }

        /// <summary>
        /// Specifies the absolute height of the content, in points.
        /// </summary>
        [DataMember(Name="AbsoluteHeight")]
        public float AbsoluteHeight { get; set; }

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
            return Equals(input as DrawableContentLayoutParameters);
        }

        /// <summary>
        /// Returns true if DrawableContentLayoutParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of DrawableContentLayoutParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DrawableContentLayoutParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    HorizontalPosition == input.HorizontalPosition ||
                    HorizontalPosition.Equals(input.HorizontalPosition)
                ) && 
                (
                    VerticalPosition == input.VerticalPosition ||
                    VerticalPosition.Equals(input.VerticalPosition)
                ) && 
                (
                    Size == input.Size ||
                    Size.Equals(input.Size)
                ) && 
                (
                    IndentFromEdges == input.IndentFromEdges ||
                    IndentFromEdges.Equals(input.IndentFromEdges)
                ) && 
                (
                    AbsolutePositionLeft == input.AbsolutePositionLeft ||
                    AbsolutePositionLeft.Equals(input.AbsolutePositionLeft)
                ) && 
                (
                    AbsolutePositionTop == input.AbsolutePositionTop ||
                    AbsolutePositionTop.Equals(input.AbsolutePositionTop)
                ) && 
                (
                    AbsoluteWidth == input.AbsoluteWidth ||
                    AbsoluteWidth.Equals(input.AbsoluteWidth)
                ) && 
                (
                    AbsoluteHeight == input.AbsoluteHeight ||
                    AbsoluteHeight.Equals(input.AbsoluteHeight)
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
                hashCode = hashCode * 59 + HorizontalPosition.GetHashCode();
                hashCode = hashCode * 59 + VerticalPosition.GetHashCode();
                hashCode = hashCode * 59 + Size.GetHashCode();
                hashCode = hashCode * 59 + IndentFromEdges.GetHashCode();
                hashCode = hashCode * 59 + AbsolutePositionLeft.GetHashCode();
                hashCode = hashCode * 59 + AbsolutePositionTop.GetHashCode();
                hashCode = hashCode * 59 + AbsoluteWidth.GetHashCode();
                hashCode = hashCode * 59 + AbsoluteHeight.GetHashCode();
                return hashCode;
            }
        }
    }

}
