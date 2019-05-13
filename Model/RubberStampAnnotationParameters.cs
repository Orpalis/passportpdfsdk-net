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
    /// Represents information about the Rubber Stamp Annotation.
    /// </summary>
    [DataContract]
    public partial class RubberStampAnnotationParameters :  IEquatable<RubberStampAnnotationParameters>, IValidatableObject
    {
        /// <summary>
        /// Specifies the icon to be used for a rubber stamp annotation.
        /// </summary>
        /// <value>Specifies the icon to be used for a rubber stamp annotation.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RubberStampIconEnum
        {
            /// <summary>
            /// Enum Approved for value: Approved
            /// </summary>
            [EnumMember(Value = "Approved")]
            Approved = 1,

            /// <summary>
            /// Enum NotApproved for value: NotApproved
            /// </summary>
            [EnumMember(Value = "NotApproved")]
            NotApproved = 2,

            /// <summary>
            /// Enum NotForPublicRelease for value: NotForPublicRelease
            /// </summary>
            [EnumMember(Value = "NotForPublicRelease")]
            NotForPublicRelease = 3,

            /// <summary>
            /// Enum Confidential for value: Confidential
            /// </summary>
            [EnumMember(Value = "Confidential")]
            Confidential = 4,

            /// <summary>
            /// Enum Final for value: Final
            /// </summary>
            [EnumMember(Value = "Final")]
            Final = 5,

            /// <summary>
            /// Enum ForComment for value: ForComment
            /// </summary>
            [EnumMember(Value = "ForComment")]
            ForComment = 6,

            /// <summary>
            /// Enum Draft for value: Draft
            /// </summary>
            [EnumMember(Value = "Draft")]
            Draft = 7,

            /// <summary>
            /// Enum ForPublicRelease for value: ForPublicRelease
            /// </summary>
            [EnumMember(Value = "ForPublicRelease")]
            ForPublicRelease = 8,

            /// <summary>
            /// Enum SBCompleted for value: SBCompleted
            /// </summary>
            [EnumMember(Value = "SBCompleted")]
            SBCompleted = 9,

            /// <summary>
            /// Enum SBInformationOnly for value: SBInformationOnly
            /// </summary>
            [EnumMember(Value = "SBInformationOnly")]
            SBInformationOnly = 10,

            /// <summary>
            /// Enum SBVoid for value: SBVoid
            /// </summary>
            [EnumMember(Value = "SBVoid")]
            SBVoid = 11,

            /// <summary>
            /// Enum SBPreliminaryResults for value: SBPreliminaryResults
            /// </summary>
            [EnumMember(Value = "SBPreliminaryResults")]
            SBPreliminaryResults = 12,

            /// <summary>
            /// Enum SBRejected for value: SBRejected
            /// </summary>
            [EnumMember(Value = "SBRejected")]
            SBRejected = 13,

            /// <summary>
            /// Enum SHAccepted for value: SHAccepted
            /// </summary>
            [EnumMember(Value = "SHAccepted")]
            SHAccepted = 14,

            /// <summary>
            /// Enum SHInitialHere for value: SHInitialHere
            /// </summary>
            [EnumMember(Value = "SHInitialHere")]
            SHInitialHere = 15,

            /// <summary>
            /// Enum SHSignHere for value: SHSignHere
            /// </summary>
            [EnumMember(Value = "SHSignHere")]
            SHSignHere = 16,

            /// <summary>
            /// Enum SHWitness for value: SHWitness
            /// </summary>
            [EnumMember(Value = "SHWitness")]
            SHWitness = 17,

            /// <summary>
            /// Enum DApproved for value: DApproved
            /// </summary>
            [EnumMember(Value = "DApproved")]
            DApproved = 18,

            /// <summary>
            /// Enum DConfidential for value: DConfidential
            /// </summary>
            [EnumMember(Value = "DConfidential")]
            DConfidential = 19,

            /// <summary>
            /// Enum DReceived for value: DReceived
            /// </summary>
            [EnumMember(Value = "DReceived")]
            DReceived = 20,

            /// <summary>
            /// Enum DReviewed for value: DReviewed
            /// </summary>
            [EnumMember(Value = "DReviewed")]
            DReviewed = 21

        }

        /// <summary>
        /// Specifies the icon to be used for a rubber stamp annotation.
        /// </summary>
        /// <value>Specifies the icon to be used for a rubber stamp annotation.</value>
        [DataMember(Name="RubberStampIcon", EmitDefaultValue=false)]
        public RubberStampIconEnum? RubberStampIcon { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RubberStampAnnotationParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RubberStampAnnotationParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RubberStampAnnotationParameters" /> class.
        /// </summary>
        /// <param name="annotationLayout">annotationLayout (required).</param>
        /// <param name="rubberStampIcon">Specifies the icon to be used for a rubber stamp annotation. (default to RubberStampIconEnum.Approved).</param>
        /// <param name="title">Specifies the title of the annotation, if any..</param>
        /// <param name="content">Specify the content of the annotation, if any..</param>
        /// <param name="color">Specifies the color of the annotation, using the color name (ie: \&quot;red\&quot;) or its RGBa code (ie: \&quot;rgba(255,0,0,1)\&quot;). (default to &quot;red&quot;).</param>
        public RubberStampAnnotationParameters(DrawableContentLayoutParameters annotationLayout = default(DrawableContentLayoutParameters), RubberStampIconEnum? rubberStampIcon = RubberStampIconEnum.Approved, string title = default(string), string content = default(string), string color = "red")
        {
            // to ensure "annotationLayout" is required (not null)
            if (annotationLayout == null)
            {
                throw new InvalidDataException("annotationLayout is a required property for RubberStampAnnotationParameters and cannot be null");
            }
            else
            {
                this.AnnotationLayout = annotationLayout;
            }
            
            // use default value if no "rubberStampIcon" provided
            if (rubberStampIcon == null)
            {
                this.RubberStampIcon = RubberStampIconEnum.Approved;
            }
            else
            {
                this.RubberStampIcon = rubberStampIcon;
            }
            this.Title = title;
            this.Content = content;
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
            sb.Append("class RubberStampAnnotationParameters {\n");
            sb.Append("  AnnotationLayout: ").Append(AnnotationLayout).Append("\n");
            sb.Append("  RubberStampIcon: ").Append(RubberStampIcon).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
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
            return this.Equals(input as RubberStampAnnotationParameters);
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
                    this.AnnotationLayout == input.AnnotationLayout ||
                    (this.AnnotationLayout != null &&
                    this.AnnotationLayout.Equals(input.AnnotationLayout))
                ) && 
                (
                    this.RubberStampIcon == input.RubberStampIcon ||
                    (this.RubberStampIcon != null &&
                    this.RubberStampIcon.Equals(input.RubberStampIcon))
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
                if (this.RubberStampIcon != null)
                    hashCode = hashCode * 59 + this.RubberStampIcon.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
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
