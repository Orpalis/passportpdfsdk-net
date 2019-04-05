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
    /// Represents the parameters for a merge action.
    /// </summary>
    [DataContract]
    public partial class PDFMergeParameters :  IEquatable<PDFMergeParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFMergeParameters" /> class.
        /// </summary>
        /// <param name="filesId">Specifies the identifiers of the documents to be merged..</param>
        /// <param name="includeAttachments">Specifies if file attachments should be included in merged document. (default to true).</param>
        public PDFMergeParameters(List<string> filesId = default(List<string>), bool? includeAttachments = true)
        {
            this.FilesId = filesId;
            // use default value if no "includeAttachments" provided
            if (includeAttachments == null)
            {
                this.IncludeAttachments = true;
            }
            else
            {
                this.IncludeAttachments = includeAttachments;
            }
        }
        
        /// <summary>
        /// Specifies the identifiers of the documents to be merged.
        /// </summary>
        /// <value>Specifies the identifiers of the documents to be merged.</value>
        [DataMember(Name="FilesId", EmitDefaultValue=false)]
        public List<string> FilesId { get; set; }

        /// <summary>
        /// Specifies if file attachments should be included in merged document.
        /// </summary>
        /// <value>Specifies if file attachments should be included in merged document.</value>
        [DataMember(Name="IncludeAttachments", EmitDefaultValue=false)]
        public bool? IncludeAttachments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFMergeParameters {\n");
            sb.Append("  FilesId: ").Append(FilesId).Append("\n");
            sb.Append("  IncludeAttachments: ").Append(IncludeAttachments).Append("\n");
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
            return this.Equals(input as PDFMergeParameters);
        }

        /// <summary>
        /// Returns true if PDFMergeParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFMergeParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFMergeParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FilesId == input.FilesId ||
                    this.FilesId != null &&
                    this.FilesId.SequenceEqual(input.FilesId)
                ) && 
                (
                    this.IncludeAttachments == input.IncludeAttachments ||
                    (this.IncludeAttachments != null &&
                    this.IncludeAttachments.Equals(input.IncludeAttachments))
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
                if (this.FilesId != null)
                    hashCode = hashCode * 59 + this.FilesId.GetHashCode();
                if (this.IncludeAttachments != null)
                    hashCode = hashCode * 59 + this.IncludeAttachments.GetHashCode();
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
