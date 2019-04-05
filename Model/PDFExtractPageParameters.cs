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
    /// Represents the parameters for an extract page action.
    /// </summary>
    [DataContract]
    public partial class PDFExtractPageParameters :  IEquatable<PDFExtractPageParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFExtractPageParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFExtractPageParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFExtractPageParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages to be extracted. (required).</param>
        /// <param name="extractAsSeparate">Specifies whether each extracted page shall form a separate document..</param>
        /// <param name="immediateDownload">Specifies whether the file(s) created as a result of the action shall be available for immediate download..</param>
        public PDFExtractPageParameters(string fileId = default(string), string pageRange = default(string), bool? extractAsSeparate = default(bool?), bool? immediateDownload = default(bool?))
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for PDFExtractPageParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            // to ensure "pageRange" is required (not null)
            if (pageRange == null)
            {
                throw new InvalidDataException("pageRange is a required property for PDFExtractPageParameters and cannot be null");
            }
            else
            {
                this.PageRange = pageRange;
            }
            this.ExtractAsSeparate = extractAsSeparate;
            this.ImmediateDownload = immediateDownload;
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to be extracted.
        /// </summary>
        /// <value>Specifies the number of the page, or the range of pages to be extracted.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies whether each extracted page shall form a separate document.
        /// </summary>
        /// <value>Specifies whether each extracted page shall form a separate document.</value>
        [DataMember(Name="ExtractAsSeparate", EmitDefaultValue=false)]
        public bool? ExtractAsSeparate { get; set; }

        /// <summary>
        /// Specifies whether the file(s) created as a result of the action shall be available for immediate download.
        /// </summary>
        /// <value>Specifies whether the file(s) created as a result of the action shall be available for immediate download.</value>
        [DataMember(Name="ImmediateDownload", EmitDefaultValue=false)]
        public bool? ImmediateDownload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFExtractPageParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  ExtractAsSeparate: ").Append(ExtractAsSeparate).Append("\n");
            sb.Append("  ImmediateDownload: ").Append(ImmediateDownload).Append("\n");
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
            return this.Equals(input as PDFExtractPageParameters);
        }

        /// <summary>
        /// Returns true if PDFExtractPageParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFExtractPageParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFExtractPageParameters input)
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
                    this.ExtractAsSeparate == input.ExtractAsSeparate ||
                    (this.ExtractAsSeparate != null &&
                    this.ExtractAsSeparate.Equals(input.ExtractAsSeparate))
                ) && 
                (
                    this.ImmediateDownload == input.ImmediateDownload ||
                    (this.ImmediateDownload != null &&
                    this.ImmediateDownload.Equals(input.ImmediateDownload))
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
                if (this.ExtractAsSeparate != null)
                    hashCode = hashCode * 59 + this.ExtractAsSeparate.GetHashCode();
                if (this.ImmediateDownload != null)
                    hashCode = hashCode * 59 + this.ImmediateDownload.GetHashCode();
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
