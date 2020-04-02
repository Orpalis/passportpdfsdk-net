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
    /// Represents the parameters for a merge action.
    /// </summary>
    [DataContract]
    public partial class PdfMergeParameters :  IEquatable<PdfMergeParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfMergeParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfMergeParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfMergeParameters" /> class.
        /// </summary>
        /// <param name="filesId">Specifies the identifiers of the documents to be merged. (required).</param>
        public PdfMergeParameters(List<string> filesId)
        {
            FilesId = filesId;
        }

        /// <summary>
        /// Specifies the identifiers of the documents to be merged.
        /// </summary>
        [DataMember(Name="FilesId")]
        public List<string> FilesId { get; set; }

        /// <summary>
        /// Specifies if file attachments should be included in merged document.
        /// </summary>
        [DataMember(Name="IncludeAttachments")]
        public bool IncludeAttachments { get; set; } = true;

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
            return Equals(input as PdfMergeParameters);
        }

        /// <summary>
        /// Returns true if PdfMergeParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfMergeParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfMergeParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    FilesId == input.FilesId ||
                    FilesId != null &&
                    input.FilesId != null &&
                    FilesId.SequenceEqual(input.FilesId)
                ) && 
                (
                    IncludeAttachments == input.IncludeAttachments ||
                    IncludeAttachments.Equals(input.IncludeAttachments)
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
                if (FilesId != null)
                    hashCode = hashCode * 59 + FilesId.GetHashCode();
                hashCode = hashCode * 59 + IncludeAttachments.GetHashCode();
                return hashCode;
            }
        }
    }

}
