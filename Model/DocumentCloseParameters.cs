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
    /// Represents the parameters for a close document action.
    /// </summary>
    [DataContract]
    public partial class DocumentCloseParameters :  IEquatable<DocumentCloseParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentCloseParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentCloseParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentCloseParameters" /> class.
        /// </summary>
        /// <param name="FileId">FileId (required).</param>
        /// <param name="Aa">Aa.</param>
        public DocumentCloseParameters(string FileId = default(string), string Aa = default(string))
        {
            // to ensure "FileId" is required (not null)
            if (FileId == null)
            {
                throw new InvalidDataException("FileId is a required property for DocumentCloseParameters and cannot be null");
            }
            else
            {
                this.FileId = FileId;
            }
            this.Aa = Aa;
        }
        
        /// <summary>
        /// Gets or Sets FileId
        /// </summary>
        [DataMember(Name="fileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Gets or Sets Aa
        /// </summary>
        [DataMember(Name="aa", EmitDefaultValue=false)]
        public string Aa { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentCloseParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  Aa: ").Append(Aa).Append("\n");
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
            return this.Equals(input as DocumentCloseParameters);
        }

        /// <summary>
        /// Returns true if DocumentCloseParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentCloseParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentCloseParameters input)
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
                    this.Aa == input.Aa ||
                    (this.Aa != null &&
                    this.Aa.Equals(input.Aa))
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
                if (this.Aa != null)
                    hashCode = hashCode * 59 + this.Aa.GetHashCode();
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