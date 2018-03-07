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
    /// Represents the parameters for a Save action.
    /// </summary>
    [DataContract]
    public partial class DocuViewareSaveParameters :  IEquatable<DocuViewareSaveParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocuViewareSaveParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocuViewareSaveParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocuViewareSaveParameters" /> class.
        /// </summary>
        /// <param name="SessionID">SessionID (required).</param>
        /// <param name="ControlID">ControlID (required).</param>
        /// <param name="FileName">FileName (required).</param>
        /// <param name="Format">Format (required).</param>
        /// <param name="PageRange">PageRange.</param>
        public DocuViewareSaveParameters(string SessionID = default(string), string ControlID = default(string), string FileName = default(string), string Format = default(string), string PageRange = default(string))
        {
            // to ensure "SessionID" is required (not null)
            if (SessionID == null)
            {
                throw new InvalidDataException("SessionID is a required property for DocuViewareSaveParameters and cannot be null");
            }
            else
            {
                this.SessionID = SessionID;
            }
            // to ensure "ControlID" is required (not null)
            if (ControlID == null)
            {
                throw new InvalidDataException("ControlID is a required property for DocuViewareSaveParameters and cannot be null");
            }
            else
            {
                this.ControlID = ControlID;
            }
            // to ensure "FileName" is required (not null)
            if (FileName == null)
            {
                throw new InvalidDataException("FileName is a required property for DocuViewareSaveParameters and cannot be null");
            }
            else
            {
                this.FileName = FileName;
            }
            // to ensure "Format" is required (not null)
            if (Format == null)
            {
                throw new InvalidDataException("Format is a required property for DocuViewareSaveParameters and cannot be null");
            }
            else
            {
                this.Format = Format;
            }
            this.PageRange = PageRange;
        }
        
        /// <summary>
        /// Gets or Sets SessionID
        /// </summary>
        [DataMember(Name="sessionID", EmitDefaultValue=false)]
        public string SessionID { get; set; }

        /// <summary>
        /// Gets or Sets ControlID
        /// </summary>
        [DataMember(Name="controlID", EmitDefaultValue=false)]
        public string ControlID { get; set; }

        /// <summary>
        /// Gets or Sets FileName
        /// </summary>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public string Format { get; set; }

        /// <summary>
        /// Gets or Sets PageRange
        /// </summary>
        [DataMember(Name="pageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocuViewareSaveParameters {\n");
            sb.Append("  SessionID: ").Append(SessionID).Append("\n");
            sb.Append("  ControlID: ").Append(ControlID).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
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
            return this.Equals(input as DocuViewareSaveParameters);
        }

        /// <summary>
        /// Returns true if DocuViewareSaveParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of DocuViewareSaveParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocuViewareSaveParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SessionID == input.SessionID ||
                    (this.SessionID != null &&
                    this.SessionID.Equals(input.SessionID))
                ) && 
                (
                    this.ControlID == input.ControlID ||
                    (this.ControlID != null &&
                    this.ControlID.Equals(input.ControlID))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.PageRange == input.PageRange ||
                    (this.PageRange != null &&
                    this.PageRange.Equals(input.PageRange))
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
                if (this.SessionID != null)
                    hashCode = hashCode * 59 + this.SessionID.GetHashCode();
                if (this.ControlID != null)
                    hashCode = hashCode * 59 + this.ControlID.GetHashCode();
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.PageRange != null)
                    hashCode = hashCode * 59 + this.PageRange.GetHashCode();
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
