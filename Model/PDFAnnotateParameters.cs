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
    /// Represents the parameters for an annotate action.
    /// </summary>
    [DataContract]
    public partial class PdfAnnotateParameters :  IEquatable<PdfAnnotateParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfAnnotateParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfAnnotateParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfAnnotateParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the page or the range of page to be annotated. (required).</param>
        public PdfAnnotateParameters(string fileId, string pageRange)
        {
            FileId = fileId;
            PageRange = pageRange;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the page or the range of page to be annotated.
        /// </summary>
        [DataMember(Name="PageRange")]
        public string PageRange { get; set; }

        /// <summary>
        /// Gets or Sets AnnotationType
        /// </summary>
        [DataMember(Name="AnnotationType")]
        public AnnotationType AnnotationType { get; set; }

        /// <summary>
        /// Gets or Sets StickyNoteAnnotationParameters
        /// </summary>
        [DataMember(Name="StickyNoteAnnotationParameters")]
        public StickyNoteAnnotationParameters StickyNoteAnnotationParameters { get; set; }

        /// <summary>
        /// Gets or Sets LinkAnnotationParameters
        /// </summary>
        [DataMember(Name="LinkAnnotationParameters")]
        public LinkAnnotationParameters LinkAnnotationParameters { get; set; }

        /// <summary>
        /// Gets or Sets FreeTextAnnotationParameters
        /// </summary>
        [DataMember(Name="FreeTextAnnotationParameters")]
        public FreeTextAnnotationParameters FreeTextAnnotationParameters { get; set; }

        /// <summary>
        /// Gets or Sets LineAnnotationParameters
        /// </summary>
        [DataMember(Name="LineAnnotationParameters")]
        public LineAnnotationParameters LineAnnotationParameters { get; set; }

        /// <summary>
        /// Gets or Sets SquareAndCircleAnnotationParameters
        /// </summary>
        [DataMember(Name="SquareAndCircleAnnotationParameters")]
        public SquareAndCircleAnnotationParameters SquareAndCircleAnnotationParameters { get; set; }

        /// <summary>
        /// Gets or Sets RubberStampAnnotationParameters
        /// </summary>
        [DataMember(Name="RubberStampAnnotationParameters")]
        public RubberStampAnnotationParameters RubberStampAnnotationParameters { get; set; }

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
            return Equals(input as PdfAnnotateParameters);
        }

        /// <summary>
        /// Returns true if PdfAnnotateParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfAnnotateParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfAnnotateParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    FileId == input.FileId ||
                    (FileId != null &&
                    FileId.Equals(input.FileId))
                ) && 
                (
                    PageRange == input.PageRange ||
                    (PageRange != null &&
                    PageRange.Equals(input.PageRange))
                ) && 
                (
                    AnnotationType == input.AnnotationType ||
                    AnnotationType.Equals(input.AnnotationType)
                ) && 
                (
                    StickyNoteAnnotationParameters == input.StickyNoteAnnotationParameters ||
                    (StickyNoteAnnotationParameters != null &&
                    StickyNoteAnnotationParameters.Equals(input.StickyNoteAnnotationParameters))
                ) && 
                (
                    LinkAnnotationParameters == input.LinkAnnotationParameters ||
                    (LinkAnnotationParameters != null &&
                    LinkAnnotationParameters.Equals(input.LinkAnnotationParameters))
                ) && 
                (
                    FreeTextAnnotationParameters == input.FreeTextAnnotationParameters ||
                    (FreeTextAnnotationParameters != null &&
                    FreeTextAnnotationParameters.Equals(input.FreeTextAnnotationParameters))
                ) && 
                (
                    LineAnnotationParameters == input.LineAnnotationParameters ||
                    (LineAnnotationParameters != null &&
                    LineAnnotationParameters.Equals(input.LineAnnotationParameters))
                ) && 
                (
                    SquareAndCircleAnnotationParameters == input.SquareAndCircleAnnotationParameters ||
                    (SquareAndCircleAnnotationParameters != null &&
                    SquareAndCircleAnnotationParameters.Equals(input.SquareAndCircleAnnotationParameters))
                ) && 
                (
                    RubberStampAnnotationParameters == input.RubberStampAnnotationParameters ||
                    (RubberStampAnnotationParameters != null &&
                    RubberStampAnnotationParameters.Equals(input.RubberStampAnnotationParameters))
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
                if (FileId != null)
                    hashCode = hashCode * 59 + FileId.GetHashCode();
                if (PageRange != null)
                    hashCode = hashCode * 59 + PageRange.GetHashCode();
                hashCode = hashCode * 59 + AnnotationType.GetHashCode();
                if (StickyNoteAnnotationParameters != null)
                    hashCode = hashCode * 59 + StickyNoteAnnotationParameters.GetHashCode();
                if (LinkAnnotationParameters != null)
                    hashCode = hashCode * 59 + LinkAnnotationParameters.GetHashCode();
                if (FreeTextAnnotationParameters != null)
                    hashCode = hashCode * 59 + FreeTextAnnotationParameters.GetHashCode();
                if (LineAnnotationParameters != null)
                    hashCode = hashCode * 59 + LineAnnotationParameters.GetHashCode();
                if (SquareAndCircleAnnotationParameters != null)
                    hashCode = hashCode * 59 + SquareAndCircleAnnotationParameters.GetHashCode();
                if (RubberStampAnnotationParameters != null)
                    hashCode = hashCode * 59 + RubberStampAnnotationParameters.GetHashCode();
                return hashCode;
            }
        }
    }

}
