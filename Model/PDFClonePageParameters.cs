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
    /// Represents the parameters for a ClonePage action.
    /// </summary>
    [DataContract]
    public partial class PDFClonePageParameters :  IEquatable<PDFClonePageParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFClonePageParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFClonePageParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFClonePageParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="sourceFileId">Specifies the file identifier of the PDF to be cloned. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages to be cloned. (required).</param>
        /// <param name="destinationPage">Specifies the number of the page where the cloned page(s) shall be inserted. (required).</param>
        public PDFClonePageParameters(string fileId = default(string), string sourceFileId = default(string), string pageRange = default(string), int? destinationPage = default(int?))
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for PDFClonePageParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            
            // to ensure "sourceFileId" is required (not null)
            if (sourceFileId == null)
            {
                throw new InvalidDataException("sourceFileId is a required property for PDFClonePageParameters and cannot be null");
            }
            else
            {
                this.SourceFileId = sourceFileId;
            }
            
            // to ensure "pageRange" is required (not null)
            if (pageRange == null)
            {
                throw new InvalidDataException("pageRange is a required property for PDFClonePageParameters and cannot be null");
            }
            else
            {
                this.PageRange = pageRange;
            }
            
            // to ensure "destinationPage" is required (not null)
            if (destinationPage == null)
            {
                throw new InvalidDataException("destinationPage is a required property for PDFClonePageParameters and cannot be null");
            }
            else
            {
                this.DestinationPage = destinationPage;
            }
            
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the file identifier of the PDF to be cloned.
        /// </summary>
        /// <value>Specifies the file identifier of the PDF to be cloned.</value>
        [DataMember(Name="SourceFileId", EmitDefaultValue=false)]
        public string SourceFileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to be cloned.
        /// </summary>
        /// <value>Specifies the number of the page, or the range of pages to be cloned.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies the number of the page where the cloned page(s) shall be inserted.
        /// </summary>
        /// <value>Specifies the number of the page where the cloned page(s) shall be inserted.</value>
        [DataMember(Name="DestinationPage", EmitDefaultValue=false)]
        public int? DestinationPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFClonePageParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  SourceFileId: ").Append(SourceFileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  DestinationPage: ").Append(DestinationPage).Append("\n");
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
            return this.Equals(input as PDFClonePageParameters);
        }

        /// <summary>
        /// Returns true if PDFClonePageParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFClonePageParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFClonePageParameters input)
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
                    this.SourceFileId == input.SourceFileId ||
                    (this.SourceFileId != null &&
                    this.SourceFileId.Equals(input.SourceFileId))
                ) && 
                (
                    this.PageRange == input.PageRange ||
                    (this.PageRange != null &&
                    this.PageRange.Equals(input.PageRange))
                ) && 
                (
                    this.DestinationPage == input.DestinationPage ||
                    (this.DestinationPage != null &&
                    this.DestinationPage.Equals(input.DestinationPage))
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
                if (this.SourceFileId != null)
                    hashCode = hashCode * 59 + this.SourceFileId.GetHashCode();
                if (this.PageRange != null)
                    hashCode = hashCode * 59 + this.PageRange.GetHashCode();
                if (this.DestinationPage != null)
                    hashCode = hashCode * 59 + this.DestinationPage.GetHashCode();
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
