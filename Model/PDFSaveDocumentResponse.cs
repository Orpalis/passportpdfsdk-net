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
    /// Represents the response to a save document action request.
    /// </summary>
    [DataContract]
    public partial class PdfSaveDocumentResponse :  IEquatable<PdfSaveDocumentResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfSaveDocumentResponse" /> class.
        /// </summary>
        public PdfSaveDocumentResponse()
        {
        }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="Error")]
        public Error Error { get; set; }

        /// <summary>
        /// Specifies the number of remaining tokens.
        /// </summary>
        [DataMember(Name="RemainingTokens")]
        public long RemainingTokens { get; set; }

        /// <summary>
        /// Specifies the data of the saved document.
        /// </summary>
        [DataMember(Name="Data")]
        public byte[] Data { get; private set; }

        /// <summary>
        /// Specifies the name of the saved document.
        /// </summary>
        [DataMember(Name="FileName")]
        public string FileName { get; private set; }

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
            return Equals(input as PdfSaveDocumentResponse);
        }

        /// <summary>
        /// Returns true if PdfSaveDocumentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfSaveDocumentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfSaveDocumentResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    Error == input.Error ||
                    (Error != null &&
                    Error.Equals(input.Error))
                ) && 
                (
                    RemainingTokens == input.RemainingTokens ||
                    RemainingTokens.Equals(input.RemainingTokens)
                ) && 
                (
                    Data == input.Data ||
                    (Data != null &&
                    Data.Equals(input.Data))
                ) && 
                (
                    FileName == input.FileName ||
                    (FileName != null &&
                    FileName.Equals(input.FileName))
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
                if (Error != null)
                    hashCode = hashCode * 59 + Error.GetHashCode();
                hashCode = hashCode * 59 + RemainingTokens.GetHashCode();
                if (Data != null)
                    hashCode = hashCode * 59 + Data.GetHashCode();
                if (FileName != null)
                    hashCode = hashCode * 59 + FileName.GetHashCode();
                return hashCode;
            }
        }
    }

}
