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
    /// Represents information about the Link Annotation.
    /// </summary>
    [DataContract]
    public partial class LinkAnnotationParameters :  IEquatable<LinkAnnotationParameters>, IValidatableObject
    {
        /// <summary>
        /// Specifies the link annotation type and parameters.
        /// </summary>
        /// <value>Specifies the link annotation type and parameters.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LinkTypeEnum
        {
            /// <summary>
            /// Enum Page for value: Page
            /// </summary>
            [EnumMember(Value = "Page")]
            Page = 1,

            /// <summary>
            /// Enum Web for value: Web
            /// </summary>
            [EnumMember(Value = "Web")]
            Web = 2

        }

        /// <summary>
        /// Specifies the link annotation type and parameters.
        /// </summary>
        /// <value>Specifies the link annotation type and parameters.</value>
        [DataMember(Name="LinkType", EmitDefaultValue=false)]
        public LinkTypeEnum? LinkType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkAnnotationParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LinkAnnotationParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkAnnotationParameters" /> class.
        /// </summary>
        /// <param name="annotationLayout">annotationLayout (required).</param>
        /// <param name="linkType">Specifies the link annotation type and parameters..</param>
        /// <param name="linkPage">Specifies the link annotation destination page if the Page type is specified..</param>
        /// <param name="linkUri">Specifies the link annotation destination URI if the Web type is specified..</param>
        /// <param name="showBorder">Specifies if the annotation border shall be drawn..</param>
        /// <param name="color">Specifies the color of the annotation, using the color name (ie: \&quot;red\&quot;) or its RGBa code (ie: \&quot;rgba(255,0,0,1)\&quot;). (default to &quot;red&quot;).</param>
        public LinkAnnotationParameters(DrawableContentLayoutParameters annotationLayout = default(DrawableContentLayoutParameters), LinkTypeEnum? linkType = default(LinkTypeEnum?), int? linkPage = default(int?), string linkUri = default(string), bool? showBorder = default(bool?), string color = "red")
        {
            // to ensure "annotationLayout" is required (not null)
            if (annotationLayout == null)
            {
                throw new InvalidDataException("annotationLayout is a required property for LinkAnnotationParameters and cannot be null");
            }
            else
            {
                this.AnnotationLayout = annotationLayout;
            }
            
            this.LinkType = linkType;
            this.LinkPage = linkPage;
            this.LinkUri = linkUri;
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
        /// Specifies the link annotation destination page if the Page type is specified.
        /// </summary>
        /// <value>Specifies the link annotation destination page if the Page type is specified.</value>
        [DataMember(Name="LinkPage", EmitDefaultValue=false)]
        public int? LinkPage { get; set; }

        /// <summary>
        /// Specifies the link annotation destination URI if the Web type is specified.
        /// </summary>
        /// <value>Specifies the link annotation destination URI if the Web type is specified.</value>
        [DataMember(Name="LinkUri", EmitDefaultValue=false)]
        public string LinkUri { get; set; }

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
            sb.Append("class LinkAnnotationParameters {\n");
            sb.Append("  AnnotationLayout: ").Append(AnnotationLayout).Append("\n");
            sb.Append("  LinkType: ").Append(LinkType).Append("\n");
            sb.Append("  LinkPage: ").Append(LinkPage).Append("\n");
            sb.Append("  LinkUri: ").Append(LinkUri).Append("\n");
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
            return this.Equals(input as LinkAnnotationParameters);
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
                    this.AnnotationLayout == input.AnnotationLayout ||
                    (this.AnnotationLayout != null &&
                    this.AnnotationLayout.Equals(input.AnnotationLayout))
                ) && 
                (
                    this.LinkType == input.LinkType ||
                    (this.LinkType != null &&
                    this.LinkType.Equals(input.LinkType))
                ) && 
                (
                    this.LinkPage == input.LinkPage ||
                    (this.LinkPage != null &&
                    this.LinkPage.Equals(input.LinkPage))
                ) && 
                (
                    this.LinkUri == input.LinkUri ||
                    (this.LinkUri != null &&
                    this.LinkUri.Equals(input.LinkUri))
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
                if (this.LinkType != null)
                    hashCode = hashCode * 59 + this.LinkType.GetHashCode();
                if (this.LinkPage != null)
                    hashCode = hashCode * 59 + this.LinkPage.GetHashCode();
                if (this.LinkUri != null)
                    hashCode = hashCode * 59 + this.LinkUri.GetHashCode();
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
