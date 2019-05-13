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
    /// Represents the parameters for an extract text action.
    /// </summary>
    [DataContract]
    public partial class PDFExtractTextParameters :  IEquatable<PDFExtractTextParameters>, IValidatableObject
    {
        /// <summary>
        /// Specifies the way the text shall be extracted from document.
        /// </summary>
        /// <value>Specifies the way the text shall be extracted from document.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TextExtractionModeEnum
        {
            /// <summary>
            /// Enum WholePageReadable for value: WholePageReadable
            /// </summary>
            [EnumMember(Value = "WholePageReadable")]
            WholePageReadable = 1,

            /// <summary>
            /// Enum PageAreaReadable for value: PageAreaReadable
            /// </summary>
            [EnumMember(Value = "PageAreaReadable")]
            PageAreaReadable = 2,

            /// <summary>
            /// Enum WholePageCSV for value: WholePageCSV
            /// </summary>
            [EnumMember(Value = "WholePageCSV")]
            WholePageCSV = 3

        }

        /// <summary>
        /// Specifies the way the text shall be extracted from document.
        /// </summary>
        /// <value>Specifies the way the text shall be extracted from document.</value>
        [DataMember(Name="TextExtractionMode", EmitDefaultValue=false)]
        public TextExtractionModeEnum? TextExtractionMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFExtractTextParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFExtractTextParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFExtractTextParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages to extract text from. (required).</param>
        /// <param name="textExtractionMode">Specifies the way the text shall be extracted from document. (default to TextExtractionModeEnum.WholePageReadable).</param>
        /// <param name="textExtractionAreaLeft">Specifies the left coordinate of the text extraction area for the PageAreaFormated extract mode..</param>
        /// <param name="textExtractionAreaTop">Specifies the top coordinate of the text extraction area for the PageAreaFormated extract mode..</param>
        /// <param name="textExtractionAreaWidth">Specifies the width of the text extraction area for the PageAreaFormated extract mode..</param>
        /// <param name="textExtractionAreaHeight">Specifies the height of the text extraction area for the PageAreaFormated extract mode..</param>
        /// <param name="includeHeader">Specifies whether the CSV output should include header information..</param>
        public PDFExtractTextParameters(string fileId = default(string), string pageRange = default(string), TextExtractionModeEnum? textExtractionMode = TextExtractionModeEnum.WholePageReadable, float? textExtractionAreaLeft = default(float?), float? textExtractionAreaTop = default(float?), float? textExtractionAreaWidth = default(float?), float? textExtractionAreaHeight = default(float?), bool? includeHeader = default(bool?))
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for PDFExtractTextParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            
            // to ensure "pageRange" is required (not null)
            if (pageRange == null)
            {
                throw new InvalidDataException("pageRange is a required property for PDFExtractTextParameters and cannot be null");
            }
            else
            {
                this.PageRange = pageRange;
            }
            
            // use default value if no "textExtractionMode" provided
            if (textExtractionMode == null)
            {
                this.TextExtractionMode = TextExtractionModeEnum.WholePageReadable;
            }
            else
            {
                this.TextExtractionMode = textExtractionMode;
            }
            this.TextExtractionAreaLeft = textExtractionAreaLeft;
            this.TextExtractionAreaTop = textExtractionAreaTop;
            this.TextExtractionAreaWidth = textExtractionAreaWidth;
            this.TextExtractionAreaHeight = textExtractionAreaHeight;
            this.IncludeHeader = includeHeader;
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to extract text from.
        /// </summary>
        /// <value>Specifies the number of the page, or the range of pages to extract text from.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }


        /// <summary>
        /// Specifies the left coordinate of the text extraction area for the PageAreaFormated extract mode.
        /// </summary>
        /// <value>Specifies the left coordinate of the text extraction area for the PageAreaFormated extract mode.</value>
        [DataMember(Name="TextExtractionAreaLeft", EmitDefaultValue=false)]
        public float? TextExtractionAreaLeft { get; set; }

        /// <summary>
        /// Specifies the top coordinate of the text extraction area for the PageAreaFormated extract mode.
        /// </summary>
        /// <value>Specifies the top coordinate of the text extraction area for the PageAreaFormated extract mode.</value>
        [DataMember(Name="TextExtractionAreaTop", EmitDefaultValue=false)]
        public float? TextExtractionAreaTop { get; set; }

        /// <summary>
        /// Specifies the width of the text extraction area for the PageAreaFormated extract mode.
        /// </summary>
        /// <value>Specifies the width of the text extraction area for the PageAreaFormated extract mode.</value>
        [DataMember(Name="TextExtractionAreaWidth", EmitDefaultValue=false)]
        public float? TextExtractionAreaWidth { get; set; }

        /// <summary>
        /// Specifies the height of the text extraction area for the PageAreaFormated extract mode.
        /// </summary>
        /// <value>Specifies the height of the text extraction area for the PageAreaFormated extract mode.</value>
        [DataMember(Name="TextExtractionAreaHeight", EmitDefaultValue=false)]
        public float? TextExtractionAreaHeight { get; set; }

        /// <summary>
        /// Specifies whether the CSV output should include header information.
        /// </summary>
        /// <value>Specifies whether the CSV output should include header information.</value>
        [DataMember(Name="IncludeHeader", EmitDefaultValue=false)]
        public bool? IncludeHeader { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFExtractTextParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  TextExtractionMode: ").Append(TextExtractionMode).Append("\n");
            sb.Append("  TextExtractionAreaLeft: ").Append(TextExtractionAreaLeft).Append("\n");
            sb.Append("  TextExtractionAreaTop: ").Append(TextExtractionAreaTop).Append("\n");
            sb.Append("  TextExtractionAreaWidth: ").Append(TextExtractionAreaWidth).Append("\n");
            sb.Append("  TextExtractionAreaHeight: ").Append(TextExtractionAreaHeight).Append("\n");
            sb.Append("  IncludeHeader: ").Append(IncludeHeader).Append("\n");
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
            return this.Equals(input as PDFExtractTextParameters);
        }

        /// <summary>
        /// Returns true if PDFExtractTextParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFExtractTextParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFExtractTextParameters input)
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
                    this.TextExtractionMode == input.TextExtractionMode ||
                    (this.TextExtractionMode != null &&
                    this.TextExtractionMode.Equals(input.TextExtractionMode))
                ) && 
                (
                    this.TextExtractionAreaLeft == input.TextExtractionAreaLeft ||
                    (this.TextExtractionAreaLeft != null &&
                    this.TextExtractionAreaLeft.Equals(input.TextExtractionAreaLeft))
                ) && 
                (
                    this.TextExtractionAreaTop == input.TextExtractionAreaTop ||
                    (this.TextExtractionAreaTop != null &&
                    this.TextExtractionAreaTop.Equals(input.TextExtractionAreaTop))
                ) && 
                (
                    this.TextExtractionAreaWidth == input.TextExtractionAreaWidth ||
                    (this.TextExtractionAreaWidth != null &&
                    this.TextExtractionAreaWidth.Equals(input.TextExtractionAreaWidth))
                ) && 
                (
                    this.TextExtractionAreaHeight == input.TextExtractionAreaHeight ||
                    (this.TextExtractionAreaHeight != null &&
                    this.TextExtractionAreaHeight.Equals(input.TextExtractionAreaHeight))
                ) && 
                (
                    this.IncludeHeader == input.IncludeHeader ||
                    (this.IncludeHeader != null &&
                    this.IncludeHeader.Equals(input.IncludeHeader))
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
                if (this.TextExtractionMode != null)
                    hashCode = hashCode * 59 + this.TextExtractionMode.GetHashCode();
                if (this.TextExtractionAreaLeft != null)
                    hashCode = hashCode * 59 + this.TextExtractionAreaLeft.GetHashCode();
                if (this.TextExtractionAreaTop != null)
                    hashCode = hashCode * 59 + this.TextExtractionAreaTop.GetHashCode();
                if (this.TextExtractionAreaWidth != null)
                    hashCode = hashCode * 59 + this.TextExtractionAreaWidth.GetHashCode();
                if (this.TextExtractionAreaHeight != null)
                    hashCode = hashCode * 59 + this.TextExtractionAreaHeight.GetHashCode();
                if (this.IncludeHeader != null)
                    hashCode = hashCode * 59 + this.IncludeHeader.GetHashCode();
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
