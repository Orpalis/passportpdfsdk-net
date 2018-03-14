/* 
 * PassportPDF
 *
 * Copyright © 2018 ORPALIS - http://www.orpalis.com
 *
 * OpenAPI spec version: v1
 * Contact: contact@orpalis.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = PassportPDF.Client.SwaggerDateConverter;

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
        /// <param name="Error">Error.</param>
        /// <param name="RemainingTokens">RemainingTokens.</param>
        /// <param name="FileIds">Specifies the identifier(s) of the file(s) created as a result of the action..</param>
        public PDFExtractPageResponse(Error Error = default(Error), long? RemainingTokens = default(long?), List<string> FileIds = default(List<string>))
        {
            this.Error = Error;
            this.RemainingTokens = RemainingTokens;
            this.FileIds = FileIds;
        }
        
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public Error Error { get; set; }

        /// <summary>
        /// Gets or Sets RemainingTokens
        /// </summary>
        [DataMember(Name="remainingTokens", EmitDefaultValue=false)]
        public long? RemainingTokens { get; set; }

        /// <summary>
        /// Specifies the identifier(s) of the file(s) created as a result of the action.
        /// </summary>
        /// <value>Specifies the identifier(s) of the file(s) created as a result of the action.</value>
        [DataMember(Name="fileIds", EmitDefaultValue=false)]
        public List<string> FileIds { get; set; }

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
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
