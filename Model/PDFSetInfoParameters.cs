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
    /// Represents the parameters for a set info action.
    /// </summary>
    [DataContract]
    public partial class PDFSetInfoParameters :  IEquatable<PDFSetInfoParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFSetInfoParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFSetInfoParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFSetInfoParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="author">Specifies the author name specified within the PDF, if any..</param>
        /// <param name="title">Specifies the document title specified within the PDF, if any..</param>
        /// <param name="subject">Specifies the document subject specified within the PDF, if any..</param>
        /// <param name="producer">Specifies the producer name specified within the PDF, if any..</param>
        /// <param name="metadata">Specifies the metadata contained within the PDF, if any..</param>
        /// <param name="keywords">Specifies the keywords associated with the PDF, if any..</param>
        /// <param name="clearEmptyValues">Specifies whether the empty info values shall be cleared..</param>
        public PDFSetInfoParameters(string fileId = default(string), string author = default(string), string title = default(string), string subject = default(string), string producer = default(string), string metadata = default(string), string keywords = default(string), bool? clearEmptyValues = default(bool?))
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for PDFSetInfoParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            
            this.Author = author;
            this.Title = title;
            this.Subject = subject;
            this.Producer = producer;
            this.Metadata = metadata;
            this.Keywords = keywords;
            this.ClearEmptyValues = clearEmptyValues;
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the author name specified within the PDF, if any.
        /// </summary>
        /// <value>Specifies the author name specified within the PDF, if any.</value>
        [DataMember(Name="Author", EmitDefaultValue=false)]
        public string Author { get; set; }

        /// <summary>
        /// Specifies the document title specified within the PDF, if any.
        /// </summary>
        /// <value>Specifies the document title specified within the PDF, if any.</value>
        [DataMember(Name="Title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Specifies the document subject specified within the PDF, if any.
        /// </summary>
        /// <value>Specifies the document subject specified within the PDF, if any.</value>
        [DataMember(Name="Subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Specifies the producer name specified within the PDF, if any.
        /// </summary>
        /// <value>Specifies the producer name specified within the PDF, if any.</value>
        [DataMember(Name="Producer", EmitDefaultValue=false)]
        public string Producer { get; set; }

        /// <summary>
        /// Specifies the metadata contained within the PDF, if any.
        /// </summary>
        /// <value>Specifies the metadata contained within the PDF, if any.</value>
        [DataMember(Name="Metadata", EmitDefaultValue=false)]
        public string Metadata { get; set; }

        /// <summary>
        /// Specifies the keywords associated with the PDF, if any.
        /// </summary>
        /// <value>Specifies the keywords associated with the PDF, if any.</value>
        [DataMember(Name="Keywords", EmitDefaultValue=false)]
        public string Keywords { get; set; }

        /// <summary>
        /// Specifies whether the empty info values shall be cleared.
        /// </summary>
        /// <value>Specifies whether the empty info values shall be cleared.</value>
        [DataMember(Name="ClearEmptyValues", EmitDefaultValue=false)]
        public bool? ClearEmptyValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFSetInfoParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Producer: ").Append(Producer).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  ClearEmptyValues: ").Append(ClearEmptyValues).Append("\n");
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
            return this.Equals(input as PDFSetInfoParameters);
        }

        /// <summary>
        /// Returns true if PDFSetInfoParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFSetInfoParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFSetInfoParameters input)
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
                ) && 
                (
                    this.ClearEmptyValues == input.ClearEmptyValues ||
                    (this.ClearEmptyValues != null &&
                    this.ClearEmptyValues.Equals(input.ClearEmptyValues))
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
                if (this.ClearEmptyValues != null)
                    hashCode = hashCode * 59 + this.ClearEmptyValues.GetHashCode();
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
