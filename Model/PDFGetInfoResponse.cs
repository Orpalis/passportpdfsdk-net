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
    /// Represents the response to a get info action request.
    /// </summary>
    [DataContract]
    public partial class PDFGetInfoResponse :  IEquatable<PDFGetInfoResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFGetInfoResponse" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="remainingTokens">Specifies the number of remaining tokens..</param>
        public PDFGetInfoResponse(Error error = default(Error), long? remainingTokens = default(long?))
        {
            this.Error = error;
            this.RemainingTokens = remainingTokens;
        }
        
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="Error", EmitDefaultValue=false)]
        public Error Error { get; set; }

        /// <summary>
        /// Specifies the number of remaining tokens.
        /// </summary>
        /// <value>Specifies the number of remaining tokens.</value>
        [DataMember(Name="RemainingTokens", EmitDefaultValue=false)]
        public long? RemainingTokens { get; set; }

        /// <summary>
        /// Specifies the number of pages of the PDF.
        /// </summary>
        /// <value>Specifies the number of pages of the PDF.</value>
        [DataMember(Name="PageCount", EmitDefaultValue=false)]
        public int? PageCount { get; private set; }

        /// <summary>
        /// Specifies the version of the PDF.
        /// </summary>
        /// <value>Specifies the version of the PDF.</value>
        [DataMember(Name="Version", EmitDefaultValue=false)]
        public string Version { get; private set; }

        /// <summary>
        /// Specifies the author name specified within the PDF, if any.
        /// </summary>
        /// <value>Specifies the author name specified within the PDF, if any.</value>
        [DataMember(Name="Author", EmitDefaultValue=false)]
        public string Author { get; private set; }

        /// <summary>
        /// Specifies the document title specified within the PDF, if any.
        /// </summary>
        /// <value>Specifies the document title specified within the PDF, if any.</value>
        [DataMember(Name="Title", EmitDefaultValue=false)]
        public string Title { get; private set; }

        /// <summary>
        /// Specifies the document subject specified within the PDF, if any.
        /// </summary>
        /// <value>Specifies the document subject specified within the PDF, if any.</value>
        [DataMember(Name="Subject", EmitDefaultValue=false)]
        public string Subject { get; private set; }

        /// <summary>
        /// Specifies the producer name specified within the PDF, if any.
        /// </summary>
        /// <value>Specifies the producer name specified within the PDF, if any.</value>
        [DataMember(Name="Producer", EmitDefaultValue=false)]
        public string Producer { get; private set; }

        /// <summary>
        /// Specifies the metadata contained within the PDF, if any.
        /// </summary>
        /// <value>Specifies the metadata contained within the PDF, if any.</value>
        [DataMember(Name="Metadata", EmitDefaultValue=false)]
        public string Metadata { get; private set; }

        /// <summary>
        /// Specifies the keywords associated with the PDF, if any.
        /// </summary>
        /// <value>Specifies the keywords associated with the PDF, if any.</value>
        [DataMember(Name="Keywords", EmitDefaultValue=false)]
        public string Keywords { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFGetInfoResponse {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  RemainingTokens: ").Append(RemainingTokens).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Producer: ").Append(Producer).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
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
            return this.Equals(input as PDFGetInfoResponse);
        }

        /// <summary>
        /// Returns true if PDFGetInfoResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFGetInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFGetInfoResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.RemainingTokens == input.RemainingTokens ||
                    (this.RemainingTokens != null &&
                    this.RemainingTokens.Equals(input.RemainingTokens))
                ) && 
                (
                    this.PageCount == input.PageCount ||
                    (this.PageCount != null &&
                    this.PageCount.Equals(input.PageCount))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Producer == input.Producer ||
                    (this.Producer != null &&
                    this.Producer.Equals(input.Producer))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Keywords == input.Keywords ||
                    (this.Keywords != null &&
                    this.Keywords.Equals(input.Keywords))
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
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.RemainingTokens != null)
                    hashCode = hashCode * 59 + this.RemainingTokens.GetHashCode();
                if (this.PageCount != null)
                    hashCode = hashCode * 59 + this.PageCount.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Producer != null)
                    hashCode = hashCode * 59 + this.Producer.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Keywords != null)
                    hashCode = hashCode * 59 + this.Keywords.GetHashCode();
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
