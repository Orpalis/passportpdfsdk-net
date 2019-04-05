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
    /// Represents the parameters for an annotate action.
    /// </summary>
    [DataContract]
    public partial class PDFAnnotateParameters :  IEquatable<PDFAnnotateParameters>, IValidatableObject
    {
        /// <summary>
        /// Specifies the type of the annotation.
        /// </summary>
        /// <value>Specifies the type of the annotation.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AnnotationTypeEnum
        {
            /// <summary>
            /// Enum StickyNote for value: StickyNote
            /// </summary>
            [EnumMember(Value = "StickyNote")]
            StickyNote = 1,

            /// <summary>
            /// Enum Link for value: Link
            /// </summary>
            [EnumMember(Value = "Link")]
            Link = 2,

            /// <summary>
            /// Enum FreeText for value: FreeText
            /// </summary>
            [EnumMember(Value = "FreeText")]
            FreeText = 3,

            /// <summary>
            /// Enum Line for value: Line
            /// </summary>
            [EnumMember(Value = "Line")]
            Line = 4,

            /// <summary>
            /// Enum Square for value: Square
            /// </summary>
            [EnumMember(Value = "Square")]
            Square = 5,

            /// <summary>
            /// Enum Circle for value: Circle
            /// </summary>
            [EnumMember(Value = "Circle")]
            Circle = 6,

            /// <summary>
            /// Enum RubberStamp for value: RubberStamp
            /// </summary>
            [EnumMember(Value = "RubberStamp")]
            RubberStamp = 7

        }

        /// <summary>
        /// Specifies the type of the annotation.
        /// </summary>
        /// <value>Specifies the type of the annotation.</value>
        [DataMember(Name="AnnotationType", EmitDefaultValue=false)]
        public AnnotationTypeEnum? AnnotationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFAnnotateParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFAnnotateParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFAnnotateParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the page or the range of page to be annotated. (required).</param>
        /// <param name="annotationType">Specifies the type of the annotation. (default to AnnotationTypeEnum.StickyNote).</param>
        /// <param name="stickyNoteAnnotationParameters">stickyNoteAnnotationParameters.</param>
        /// <param name="linkAnnotationParameters">linkAnnotationParameters.</param>
        /// <param name="freeTextAnnotationParameters">freeTextAnnotationParameters.</param>
        /// <param name="lineAnnotationParameters">lineAnnotationParameters.</param>
        /// <param name="squareAndCircleAnnotationParameters">squareAndCircleAnnotationParameters.</param>
        /// <param name="rubberStampAnnotationParameters">rubberStampAnnotationParameters.</param>
        public PDFAnnotateParameters(string fileId = default(string), string pageRange = default(string), AnnotationTypeEnum? annotationType = AnnotationTypeEnum.StickyNote, StickyNoteAnnotationParameters stickyNoteAnnotationParameters = default(StickyNoteAnnotationParameters), LinkAnnotationParameters linkAnnotationParameters = default(LinkAnnotationParameters), FreeTextAnnotationParameters freeTextAnnotationParameters = default(FreeTextAnnotationParameters), LineAnnotationParameters lineAnnotationParameters = default(LineAnnotationParameters), SquareAndCircleAnnotationParameters squareAndCircleAnnotationParameters = default(SquareAndCircleAnnotationParameters), RubberStampAnnotationParameters rubberStampAnnotationParameters = default(RubberStampAnnotationParameters))
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for PDFAnnotateParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            // to ensure "pageRange" is required (not null)
            if (pageRange == null)
            {
                throw new InvalidDataException("pageRange is a required property for PDFAnnotateParameters and cannot be null");
            }
            else
            {
                this.PageRange = pageRange;
            }
            // use default value if no "annotationType" provided
            if (annotationType == null)
            {
                this.AnnotationType = AnnotationTypeEnum.StickyNote;
            }
            else
            {
                this.AnnotationType = annotationType;
            }
            this.StickyNoteAnnotationParameters = stickyNoteAnnotationParameters;
            this.LinkAnnotationParameters = linkAnnotationParameters;
            this.FreeTextAnnotationParameters = freeTextAnnotationParameters;
            this.LineAnnotationParameters = lineAnnotationParameters;
            this.SquareAndCircleAnnotationParameters = squareAndCircleAnnotationParameters;
            this.RubberStampAnnotationParameters = rubberStampAnnotationParameters;
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the page or the range of page to be annotated.
        /// </summary>
        /// <value>Specifies the page or the range of page to be annotated.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }


        /// <summary>
        /// Gets or Sets StickyNoteAnnotationParameters
        /// </summary>
        [DataMember(Name="StickyNoteAnnotationParameters", EmitDefaultValue=false)]
        public StickyNoteAnnotationParameters StickyNoteAnnotationParameters { get; set; }

        /// <summary>
        /// Gets or Sets LinkAnnotationParameters
        /// </summary>
        [DataMember(Name="LinkAnnotationParameters", EmitDefaultValue=false)]
        public LinkAnnotationParameters LinkAnnotationParameters { get; set; }

        /// <summary>
        /// Gets or Sets FreeTextAnnotationParameters
        /// </summary>
        [DataMember(Name="FreeTextAnnotationParameters", EmitDefaultValue=false)]
        public FreeTextAnnotationParameters FreeTextAnnotationParameters { get; set; }

        /// <summary>
        /// Gets or Sets LineAnnotationParameters
        /// </summary>
        [DataMember(Name="LineAnnotationParameters", EmitDefaultValue=false)]
        public LineAnnotationParameters LineAnnotationParameters { get; set; }

        /// <summary>
        /// Gets or Sets SquareAndCircleAnnotationParameters
        /// </summary>
        [DataMember(Name="SquareAndCircleAnnotationParameters", EmitDefaultValue=false)]
        public SquareAndCircleAnnotationParameters SquareAndCircleAnnotationParameters { get; set; }

        /// <summary>
        /// Gets or Sets RubberStampAnnotationParameters
        /// </summary>
        [DataMember(Name="RubberStampAnnotationParameters", EmitDefaultValue=false)]
        public RubberStampAnnotationParameters RubberStampAnnotationParameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFAnnotateParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  AnnotationType: ").Append(AnnotationType).Append("\n");
            sb.Append("  StickyNoteAnnotationParameters: ").Append(StickyNoteAnnotationParameters).Append("\n");
            sb.Append("  LinkAnnotationParameters: ").Append(LinkAnnotationParameters).Append("\n");
            sb.Append("  FreeTextAnnotationParameters: ").Append(FreeTextAnnotationParameters).Append("\n");
            sb.Append("  LineAnnotationParameters: ").Append(LineAnnotationParameters).Append("\n");
            sb.Append("  SquareAndCircleAnnotationParameters: ").Append(SquareAndCircleAnnotationParameters).Append("\n");
            sb.Append("  RubberStampAnnotationParameters: ").Append(RubberStampAnnotationParameters).Append("\n");
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
            return this.Equals(input as PDFAnnotateParameters);
        }

        /// <summary>
        /// Returns true if PDFAnnotateParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFAnnotateParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFAnnotateParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileId == input.FileId ||
                    (this.FileId != null &&
                    this.FileId.Equals(input.FileId))
                ) && 
                (
                    this.PageRange == input.PageRange ||
                    (this.PageRange != null &&
                    this.PageRange.Equals(input.PageRange))
                ) && 
                (
                    this.AnnotationType == input.AnnotationType ||
                    (this.AnnotationType != null &&
                    this.AnnotationType.Equals(input.AnnotationType))
                ) && 
                (
                    this.StickyNoteAnnotationParameters == input.StickyNoteAnnotationParameters ||
                    (this.StickyNoteAnnotationParameters != null &&
                    this.StickyNoteAnnotationParameters.Equals(input.StickyNoteAnnotationParameters))
                ) && 
                (
                    this.LinkAnnotationParameters == input.LinkAnnotationParameters ||
                    (this.LinkAnnotationParameters != null &&
                    this.LinkAnnotationParameters.Equals(input.LinkAnnotationParameters))
                ) && 
                (
                    this.FreeTextAnnotationParameters == input.FreeTextAnnotationParameters ||
                    (this.FreeTextAnnotationParameters != null &&
                    this.FreeTextAnnotationParameters.Equals(input.FreeTextAnnotationParameters))
                ) && 
                (
                    this.LineAnnotationParameters == input.LineAnnotationParameters ||
                    (this.LineAnnotationParameters != null &&
                    this.LineAnnotationParameters.Equals(input.LineAnnotationParameters))
                ) && 
                (
                    this.SquareAndCircleAnnotationParameters == input.SquareAndCircleAnnotationParameters ||
                    (this.SquareAndCircleAnnotationParameters != null &&
                    this.SquareAndCircleAnnotationParameters.Equals(input.SquareAndCircleAnnotationParameters))
                ) && 
                (
                    this.RubberStampAnnotationParameters == input.RubberStampAnnotationParameters ||
                    (this.RubberStampAnnotationParameters != null &&
                    this.RubberStampAnnotationParameters.Equals(input.RubberStampAnnotationParameters))
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
                if (this.FileId != null)
                    hashCode = hashCode * 59 + this.FileId.GetHashCode();
                if (this.PageRange != null)
                    hashCode = hashCode * 59 + this.PageRange.GetHashCode();
                if (this.AnnotationType != null)
                    hashCode = hashCode * 59 + this.AnnotationType.GetHashCode();
                if (this.StickyNoteAnnotationParameters != null)
                    hashCode = hashCode * 59 + this.StickyNoteAnnotationParameters.GetHashCode();
                if (this.LinkAnnotationParameters != null)
                    hashCode = hashCode * 59 + this.LinkAnnotationParameters.GetHashCode();
                if (this.FreeTextAnnotationParameters != null)
                    hashCode = hashCode * 59 + this.FreeTextAnnotationParameters.GetHashCode();
                if (this.LineAnnotationParameters != null)
                    hashCode = hashCode * 59 + this.LineAnnotationParameters.GetHashCode();
                if (this.SquareAndCircleAnnotationParameters != null)
                    hashCode = hashCode * 59 + this.SquareAndCircleAnnotationParameters.GetHashCode();
                if (this.RubberStampAnnotationParameters != null)
                    hashCode = hashCode * 59 + this.RubberStampAnnotationParameters.GetHashCode();
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
