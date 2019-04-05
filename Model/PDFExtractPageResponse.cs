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
    /// Represents the response to an extract page action request.
    /// </summary>
    [DataContract]
    public partial class PDFExtractPageResponse :  IEquatable<PDFExtractPageResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFExtractPageResponse" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="remainingTokens">Specifies the number of remaining tokens..</param>
        public PDFExtractPageResponse(Error error = default(Error), long? remainingTokens = default(long?))
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
        /// Specifies the identifier(s) of the file(s) created as a result of the action.
        /// </summary>
        /// <value>Specifies the identifier(s) of the file(s) created as a result of the action.</value>
        [DataMember(Name="FileIds", EmitDefaultValue=false)]
        public List<string> FileIds { get; private set; }

        /// <summary>
        /// Specifies the data of the file(s) created as a result of the action.
        /// </summary>
        /// <value>Specifies the data of the file(s) created as a result of the action.</value>
        [DataMember(Name="FileData", EmitDefaultValue=false)]
        public List<byte[]> FileData { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFExtractPageResponse {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  RemainingTokens: ").Append(RemainingTokens).Append("\n");
            sb.Append("  FileIds: ").Append(FileIds).Append("\n");
            sb.Append("  FileData: ").Append(FileData).Append("\n");
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
            return this.Equals(input as PDFExtractPageResponse);
        }

        /// <summary>
        /// Returns true if PDFExtractPageResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFExtractPageResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFExtractPageResponse input)
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
                    this.FileIds == input.FileIds ||
                    this.FileIds != null &&
                    this.FileIds.SequenceEqual(input.FileIds)
                ) && 
                (
                    this.FileData == input.FileData ||
                    this.FileData != null &&
                    this.FileData.SequenceEqual(input.FileData)
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
                if (this.FileIds != null)
                    hashCode = hashCode * 59 + this.FileIds.GetHashCode();
                if (this.FileData != null)
                    hashCode = hashCode * 59 + this.FileData.GetHashCode();
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
