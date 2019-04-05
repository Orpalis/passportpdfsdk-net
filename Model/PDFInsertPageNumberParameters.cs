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
    /// Represents the parameters for an insert page number action.
    /// </summary>
    [DataContract]
    public partial class PDFInsertPageNumberParameters :  IEquatable<PDFInsertPageNumberParameters>, IValidatableObject
    {
        /// <summary>
        /// Specifies the format of the page number(s) to be inserted.
        /// </summary>
        /// <value>Specifies the format of the page number(s) to be inserted.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormatEnum
        {
            /// <summary>
            /// Enum PageNumber for value: PageNumber
            /// </summary>
            [EnumMember(Value = "PageNumber")]
            PageNumber = 1,

            /// <summary>
            /// Enum PagePageNumber for value: PagePageNumber
            /// </summary>
            [EnumMember(Value = "PagePageNumber")]
            PagePageNumber = 2,

            /// <summary>
            /// Enum PagePageNumberOfPageCount for value: PagePageNumberOfPageCount
            /// </summary>
            [EnumMember(Value = "PagePageNumberOfPageCount")]
            PagePageNumberOfPageCount = 3,

            /// <summary>
            /// Enum CustomFormatting for value: CustomFormatting
            /// </summary>
            [EnumMember(Value = "CustomFormatting")]
            CustomFormatting = 4

        }

        /// <summary>
        /// Specifies the format of the page number(s) to be inserted.
        /// </summary>
        /// <value>Specifies the format of the page number(s) to be inserted.</value>
        [DataMember(Name="Format", EmitDefaultValue=false)]
        public FormatEnum? Format { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFInsertPageNumberParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFInsertPageNumberParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFInsertPageNumberParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the page or the range of pages on which the page number shall be inserted. (required).</param>
        /// <param name="format">Specifies the format of the page number(s) to be inserted. (default to FormatEnum.PageNumber).</param>
        /// <param name="layout">layout.</param>
        /// <param name="textParameters">textParameters.</param>
        public PDFInsertPageNumberParameters(string fileId = default(string), string pageRange = default(string), FormatEnum? format = FormatEnum.PageNumber, DrawableContentLayoutParameters layout = default(DrawableContentLayoutParameters), PDFAlignedTextParameters textParameters = default(PDFAlignedTextParameters))
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for PDFInsertPageNumberParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            // to ensure "pageRange" is required (not null)
            if (pageRange == null)
            {
                throw new InvalidDataException("pageRange is a required property for PDFInsertPageNumberParameters and cannot be null");
            }
            else
            {
                this.PageRange = pageRange;
            }
            // use default value if no "format" provided
            if (format == null)
            {
                this.Format = FormatEnum.PageNumber;
            }
            else
            {
                this.Format = format;
            }
            this.Layout = layout;
            this.TextParameters = textParameters;
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the page or the range of pages on which the page number shall be inserted.
        /// </summary>
        /// <value>Specifies the page or the range of pages on which the page number shall be inserted.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }


        /// <summary>
        /// Gets or Sets Layout
        /// </summary>
        [DataMember(Name="Layout", EmitDefaultValue=false)]
        public DrawableContentLayoutParameters Layout { get; set; }

        /// <summary>
        /// Gets or Sets TextParameters
        /// </summary>
        [DataMember(Name="TextParameters", EmitDefaultValue=false)]
        public PDFAlignedTextParameters TextParameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFInsertPageNumberParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Layout: ").Append(Layout).Append("\n");
            sb.Append("  TextParameters: ").Append(TextParameters).Append("\n");
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
            return this.Equals(input as PDFInsertPageNumberParameters);
        }

        /// <summary>
        /// Returns true if PDFInsertPageNumberParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFInsertPageNumberParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFInsertPageNumberParameters input)
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
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.Layout == input.Layout ||
                    (this.Layout != null &&
                    this.Layout.Equals(input.Layout))
                ) && 
                (
                    this.TextParameters == input.TextParameters ||
                    (this.TextParameters != null &&
                    this.TextParameters.Equals(input.TextParameters))
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
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.Layout != null)
                    hashCode = hashCode * 59 + this.Layout.GetHashCode();
                if (this.TextParameters != null)
                    hashCode = hashCode * 59 + this.TextParameters.GetHashCode();
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
