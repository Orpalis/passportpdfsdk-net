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
        /// <param name="sessionId">Specifies the unique identifier used to identify the user session. (required).</param>
        /// <param name="controlId">Specifies the identifier associated with the control. (required).</param>
        /// <param name="fileName">Specifies the name of the file to create. (required).</param>
        /// <param name="format">Specifies the format of the document to save.  Supported values are tiff, pdf, pdf/a, pdf/a1a, pdf/a1b, pdf/a2a, pdf/a2b, pdf/a2u, pdf/a3a, pdf/a3b, pdf/a3u. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages to be saved into the new file..</param>
        public DocuViewareSaveParameters(string sessionId = default(string), string controlId = default(string), string fileName = default(string), string format = default(string), string pageRange = default(string))
        {
            // to ensure "sessionId" is required (not null)
            if (sessionId == null)
            {
                throw new InvalidDataException("sessionId is a required property for DocuViewareSaveParameters and cannot be null");
            }
            else
            {
                this.SessionId = sessionId;
            }
            
            // to ensure "controlId" is required (not null)
            if (controlId == null)
            {
                throw new InvalidDataException("controlId is a required property for DocuViewareSaveParameters and cannot be null");
            }
            else
            {
                this.ControlId = controlId;
            }
            
            // to ensure "fileName" is required (not null)
            if (fileName == null)
            {
                throw new InvalidDataException("fileName is a required property for DocuViewareSaveParameters and cannot be null");
            }
            else
            {
                this.FileName = fileName;
            }
            
            // to ensure "format" is required (not null)
            if (format == null)
            {
                throw new InvalidDataException("format is a required property for DocuViewareSaveParameters and cannot be null");
            }
            else
            {
                this.Format = format;
            }
            
            this.PageRange = pageRange;
        }
        
        /// <summary>
        /// Specifies the unique identifier used to identify the user session.
        /// </summary>
        /// <value>Specifies the unique identifier used to identify the user session.</value>
        [DataMember(Name="SessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// Specifies the identifier associated with the control.
        /// </summary>
        /// <value>Specifies the identifier associated with the control.</value>
        [DataMember(Name="ControlId", EmitDefaultValue=false)]
        public string ControlId { get; set; }

        /// <summary>
        /// Specifies the name of the file to create.
        /// </summary>
        /// <value>Specifies the name of the file to create.</value>
        [DataMember(Name="FileName", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// Specifies the format of the document to save.  Supported values are tiff, pdf, pdf/a, pdf/a1a, pdf/a1b, pdf/a2a, pdf/a2b, pdf/a2u, pdf/a3a, pdf/a3b, pdf/a3u.
        /// </summary>
        /// <value>Specifies the format of the document to save.  Supported values are tiff, pdf, pdf/a, pdf/a1a, pdf/a1b, pdf/a2a, pdf/a2b, pdf/a2u, pdf/a3a, pdf/a3b, pdf/a3u.</value>
        [DataMember(Name="Format", EmitDefaultValue=false)]
        public string Format { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to be saved into the new file.
        /// </summary>
        /// <value>Specifies the number of the page, or the range of pages to be saved into the new file.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocuViewareSaveParameters {\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  ControlId: ").Append(ControlId).Append("\n");
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
                    this.SessionId == input.SessionId ||
                    (this.SessionId != null &&
                    this.SessionId.Equals(input.SessionId))
                ) && 
                (
                    this.ControlId == input.ControlId ||
                    (this.ControlId != null &&
                    this.ControlId.Equals(input.ControlId))
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
                if (this.SessionId != null)
                    hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.ControlId != null)
                    hashCode = hashCode * 59 + this.ControlId.GetHashCode();
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
