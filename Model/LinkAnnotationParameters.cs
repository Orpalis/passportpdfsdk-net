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
    /// Represents information about the Link Annotation.
    /// </summary>
    [DataContract]
    public partial class LinkAnnotationParameters :  IEquatable<LinkAnnotationParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkAnnotationParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LinkAnnotationParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkAnnotationParameters" /> class.
        /// </summary>
        /// <param name="annotationLayout">annotationLayout (required).</param>
        public LinkAnnotationParameters(DrawableContentLayoutParameters annotationLayout)
        {
            AnnotationLayout = annotationLayout;
        }

        /// <summary>
        /// Gets or Sets AnnotationLayout
        /// </summary>
        [DataMember(Name="AnnotationLayout")]
        public DrawableContentLayoutParameters AnnotationLayout { get; set; }

        /// <summary>
        /// Gets or Sets LinkType
        /// </summary>
        [DataMember(Name="LinkType")]
        public LinkAnnotationType LinkType { get; set; }

        /// <summary>
        /// Specifies the link annotation destination page if the Page type is specified.
        /// </summary>
        [DataMember(Name="LinkPage")]
        public int LinkPage { get; set; }

        /// <summary>
        /// Specifies the link annotation destination URI if the Web type is specified.
        /// </summary>
        [DataMember(Name="LinkUri")]
        public string LinkUri { get; set; }

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
            return Equals(input as LinkAnnotationParameters);
        }

        /// <summary>
        /// Returns true if LinkAnnotationParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of LinkAnnotationParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkAnnotationParameters input)
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
                    LinkType == input.LinkType ||
                    LinkType.Equals(input.LinkType)
                ) && 
                (
                    LinkPage == input.LinkPage ||
                    LinkPage.Equals(input.LinkPage)
                ) && 
                (
                    LinkUri == input.LinkUri ||
                    (LinkUri != null &&
                    LinkUri.Equals(input.LinkUri))
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
                hashCode = hashCode * 59 + LinkType.GetHashCode();
                hashCode = hashCode * 59 + LinkPage.GetHashCode();
                if (LinkUri != null)
                    hashCode = hashCode * 59 + LinkUri.GetHashCode();
                hashCode = hashCode * 59 + ShowBorder.GetHashCode();
                if (Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();
                return hashCode;
            }
        }
    }

}
