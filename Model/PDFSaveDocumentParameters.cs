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
    /// Represents the parameters for a save document action.
    /// </summary>
    [DataContract]
    public partial class PdfSaveDocumentParameters :  IEquatable<PdfSaveDocumentParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfSaveDocumentParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfSaveDocumentParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfSaveDocumentParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        public PdfSaveDocumentParameters(string fileId)
        {
            FileId = fileId;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

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
            return Equals(input as PdfSaveDocumentParameters);
        }

        /// <summary>
        /// Returns true if PdfSaveDocumentParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfSaveDocumentParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfSaveDocumentParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    FileId == input.FileId ||
                    (FileId != null &&
                    FileId.Equals(input.FileId))
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
                if (FileId != null)
                    hashCode = hashCode * 59 + FileId.GetHashCode();
                return hashCode;
            }
        }
    }

}
