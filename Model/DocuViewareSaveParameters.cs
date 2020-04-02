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


namespace PassportPDF.Model
{
    /// <summary>
    /// Represents the parameters for a Save action.
    /// </summary>
    [DataContract]
    public partial class DocuViewareSaveParameters :  IEquatable<DocuViewareSaveParameters>
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
        public DocuViewareSaveParameters(string sessionId, string controlId, string fileName, string format)
        {
            SessionId = sessionId;
            ControlId = controlId;
            FileName = fileName;
            Format = format;
        }

        /// <summary>
        /// Specifies the unique identifier used to identify the user session.
        /// </summary>
        [DataMember(Name="SessionId")]
        public string SessionId { get; set; }

        /// <summary>
        /// Specifies the identifier associated with the control.
        /// </summary>
        [DataMember(Name="ControlId")]
        public string ControlId { get; set; }

        /// <summary>
        /// Specifies the name of the file to create.
        /// </summary>
        [DataMember(Name="FileName")]
        public string FileName { get; set; }

        /// <summary>
        /// Specifies the format of the document to save.  Supported values are tiff, pdf, pdf/a, pdf/a1a, pdf/a1b, pdf/a2a, pdf/a2b, pdf/a2u, pdf/a3a, pdf/a3b, pdf/a3u.
        /// </summary>
        [DataMember(Name="Format")]
        public string Format { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to be saved into the new file.
        /// </summary>
        [DataMember(Name="PageRange")]
        public string PageRange { get; set; } = "*";

        /// <summary>
        /// Returns the String presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
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
            return Equals(input as DocuViewareSaveParameters);
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
                    SessionId == input.SessionId ||
                    (SessionId != null &&
                    SessionId.Equals(input.SessionId))
                ) && 
                (
                    ControlId == input.ControlId ||
                    (ControlId != null &&
                    ControlId.Equals(input.ControlId))
                ) && 
                (
                    FileName == input.FileName ||
                    (FileName != null &&
                    FileName.Equals(input.FileName))
                ) && 
                (
                    Format == input.Format ||
                    (Format != null &&
                    Format.Equals(input.Format))
                ) && 
                (
                    PageRange == input.PageRange ||
                    (PageRange != null &&
                    PageRange.Equals(input.PageRange))
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
                if (SessionId != null)
                    hashCode = hashCode * 59 + SessionId.GetHashCode();
                if (ControlId != null)
                    hashCode = hashCode * 59 + ControlId.GetHashCode();
                if (FileName != null)
                    hashCode = hashCode * 59 + FileName.GetHashCode();
                if (Format != null)
                    hashCode = hashCode * 59 + Format.GetHashCode();
                if (PageRange != null)
                    hashCode = hashCode * 59 + PageRange.GetHashCode();
                return hashCode;
            }
        }
    }

}
