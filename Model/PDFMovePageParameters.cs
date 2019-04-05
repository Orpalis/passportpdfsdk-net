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
    /// Represents the parameters for a move pages action.
    /// </summary>
    [DataContract]
    public partial class PDFMovePageParameters :  IEquatable<PDFMovePageParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFMovePageParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFMovePageParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFMovePageParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="sourcePageRange">Specifies the number of the page, or the range of pages to be moved. (required).</param>
        /// <param name="destinationPage">Specifies the number of the destination page. (required).</param>
        public PDFMovePageParameters(string fileId = default(string), string sourcePageRange = default(string), int? destinationPage = default(int?))
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for PDFMovePageParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            // to ensure "sourcePageRange" is required (not null)
            if (sourcePageRange == null)
            {
                throw new InvalidDataException("sourcePageRange is a required property for PDFMovePageParameters and cannot be null");
            }
            else
            {
                this.SourcePageRange = sourcePageRange;
            }
            // to ensure "destinationPage" is required (not null)
            if (destinationPage == null)
            {
                throw new InvalidDataException("destinationPage is a required property for PDFMovePageParameters and cannot be null");
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
        /// Specifies the number of the page, or the range of pages to be moved.
        /// </summary>
        /// <value>Specifies the number of the page, or the range of pages to be moved.</value>
        [DataMember(Name="SourcePageRange", EmitDefaultValue=false)]
        public string SourcePageRange { get; set; }

        /// <summary>
        /// Specifies the number of the destination page.
        /// </summary>
        /// <value>Specifies the number of the destination page.</value>
        [DataMember(Name="DestinationPage", EmitDefaultValue=false)]
        public int? DestinationPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFMovePageParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  SourcePageRange: ").Append(SourcePageRange).Append("\n");
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
            return this.Equals(input as PDFMovePageParameters);
        }

        /// <summary>
        /// Returns true if PDFMovePageParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFMovePageParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFMovePageParameters input)
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
                    this.SourcePageRange == input.SourcePageRange ||
                    (this.SourcePageRange != null &&
                    this.SourcePageRange.Equals(input.SourcePageRange))
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
                if (this.SourcePageRange != null)
                    hashCode = hashCode * 59 + this.SourcePageRange.GetHashCode();
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
