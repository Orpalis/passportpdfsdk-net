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
    /// Represents the parameters for an extract text action.
    /// </summary>
    [DataContract]
    public partial class PdfExtractTextParameters :  IEquatable<PdfExtractTextParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfExtractTextParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfExtractTextParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfExtractTextParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages to extract text from. (required).</param>
        public PdfExtractTextParameters(string fileId, string pageRange)
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
        /// Specifies the number of the page, or the range of pages to extract text from.
        /// </summary>
        [DataMember(Name="PageRange")]
        public string PageRange { get; set; }

        /// <summary>
        /// Gets or Sets TextExtractionMode
        /// </summary>
        [DataMember(Name="TextExtractionMode")]
        public PdfExtractTextMode TextExtractionMode { get; set; }

        /// <summary>
        /// Specifies the left coordinate of the text extraction area for the PageAreaFormated extract mode.
        /// </summary>
        [DataMember(Name="TextExtractionAreaLeft")]
        public float TextExtractionAreaLeft { get; set; } = 0F;

        /// <summary>
        /// Specifies the top coordinate of the text extraction area for the PageAreaFormated extract mode.
        /// </summary>
        [DataMember(Name="TextExtractionAreaTop")]
        public float TextExtractionAreaTop { get; set; } = 0F;

        /// <summary>
        /// Specifies the width of the text extraction area for the PageAreaFormated extract mode.
        /// </summary>
        [DataMember(Name="TextExtractionAreaWidth")]
        public float TextExtractionAreaWidth { get; set; } = 0F;

        /// <summary>
        /// Specifies the height of the text extraction area for the PageAreaFormated extract mode.
        /// </summary>
        [DataMember(Name="TextExtractionAreaHeight")]
        public float TextExtractionAreaHeight { get; set; } = 0F;

        /// <summary>
        /// Specifies whether the CSV output should include header information.
        /// </summary>
        [DataMember(Name="IncludeHeader")]
        public bool IncludeHeader { get; set; } = false;

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
            return Equals(input as PdfExtractTextParameters);
        }

        /// <summary>
        /// Returns true if PdfExtractTextParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfExtractTextParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfExtractTextParameters input)
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
                    TextExtractionMode == input.TextExtractionMode ||
                    TextExtractionMode.Equals(input.TextExtractionMode)
                ) && 
                (
                    TextExtractionAreaLeft == input.TextExtractionAreaLeft ||
                    TextExtractionAreaLeft.Equals(input.TextExtractionAreaLeft)
                ) && 
                (
                    TextExtractionAreaTop == input.TextExtractionAreaTop ||
                    TextExtractionAreaTop.Equals(input.TextExtractionAreaTop)
                ) && 
                (
                    TextExtractionAreaWidth == input.TextExtractionAreaWidth ||
                    TextExtractionAreaWidth.Equals(input.TextExtractionAreaWidth)
                ) && 
                (
                    TextExtractionAreaHeight == input.TextExtractionAreaHeight ||
                    TextExtractionAreaHeight.Equals(input.TextExtractionAreaHeight)
                ) && 
                (
                    IncludeHeader == input.IncludeHeader ||
                    IncludeHeader.Equals(input.IncludeHeader)
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
                hashCode = hashCode * 59 + TextExtractionMode.GetHashCode();
                hashCode = hashCode * 59 + TextExtractionAreaLeft.GetHashCode();
                hashCode = hashCode * 59 + TextExtractionAreaTop.GetHashCode();
                hashCode = hashCode * 59 + TextExtractionAreaWidth.GetHashCode();
                hashCode = hashCode * 59 + TextExtractionAreaHeight.GetHashCode();
                hashCode = hashCode * 59 + IncludeHeader.GetHashCode();
                return hashCode;
            }
        }
    }

}
