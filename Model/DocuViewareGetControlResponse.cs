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
    /// Represents a response to a getcontrol action.
    /// </summary>
    [DataContract]
    public partial class DocuViewareGetControlResponse :  IEquatable<DocuViewareGetControlResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocuViewareGetControlResponse" /> class.
        /// </summary>
        /// <param name="Error">Error.</param>
        /// <param name="RemainingTokens">RemainingTokens.</param>
        public DocuViewareGetControlResponse(Error Error = default(Error), long? RemainingTokens = default(long?))
        {
            this.Error = Error;
            this.RemainingTokens = RemainingTokens;
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
        /// The element content, as HTML format.
        /// </summary>
        /// <value>The element content, as HTML format.</value>
        [DataMember(Name="element", EmitDefaultValue=false)]
        public string Element { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocuViewareGetControlResponse {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  RemainingTokens: ").Append(RemainingTokens).Append("\n");
            sb.Append("  Element: ").Append(Element).Append("\n");
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
            return this.Equals(input as DocuViewareGetControlResponse);
        }

        /// <summary>
        /// Returns true if DocuViewareGetControlResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DocuViewareGetControlResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocuViewareGetControlResponse input)
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
                    this.Element == input.Element ||
                    (this.Element != null &&
                    this.Element.Equals(input.Element))
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
                if (this.Element != null)
                    hashCode = hashCode * 59 + this.Element.GetHashCode();
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
