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
    /// Represents the parameters for a set info action.
    /// </summary>
    [DataContract]
    public partial class PdfSetInfoParameters :  IEquatable<PdfSetInfoParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfSetInfoParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfSetInfoParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfSetInfoParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        public PdfSetInfoParameters(string fileId)
        {
            FileId = fileId;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the author name specified within the PDF, if any.
        /// </summary>
        [DataMember(Name="Author")]
        public string Author { get; set; } = "";

        /// <summary>
        /// Specifies the document title specified within the PDF, if any.
        /// </summary>
        [DataMember(Name="Title")]
        public string Title { get; set; } = "";

        /// <summary>
        /// Specifies the document subject specified within the PDF, if any.
        /// </summary>
        [DataMember(Name="Subject")]
        public string Subject { get; set; } = "";

        /// <summary>
        /// Specifies the producer name specified within the PDF, if any.
        /// </summary>
        [DataMember(Name="Producer")]
        public string Producer { get; set; } = "";

        /// <summary>
        /// Specifies the metadata contained within the PDF, if any.
        /// </summary>
        [DataMember(Name="Metadata")]
        public string Metadata { get; set; } = "";

        /// <summary>
        /// Specifies the keywords associated with the PDF, if any.
        /// </summary>
        [DataMember(Name="Keywords")]
        public string Keywords { get; set; } = "";

        /// <summary>
        /// Specifies whether the empty info values shall be cleared.
        /// </summary>
        [DataMember(Name="ClearEmptyValues")]
        public bool ClearEmptyValues { get; set; } = false;

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
            return Equals(input as PdfSetInfoParameters);
        }

        /// <summary>
        /// Returns true if PdfSetInfoParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfSetInfoParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfSetInfoParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    FileId == input.FileId ||
                    (FileId != null &&
                    FileId.Equals(input.FileId))
                ) && 
                (
                    Author == input.Author ||
                    (Author != null &&
                    Author.Equals(input.Author))
                ) && 
                (
                    Title == input.Title ||
                    (Title != null &&
                    Title.Equals(input.Title))
                ) && 
                (
                    Subject == input.Subject ||
                    (Subject != null &&
                    Subject.Equals(input.Subject))
                ) && 
                (
                    Producer == input.Producer ||
                    (Producer != null &&
                    Producer.Equals(input.Producer))
                ) && 
                (
                    Metadata == input.Metadata ||
                    (Metadata != null &&
                    Metadata.Equals(input.Metadata))
                ) && 
                (
                    Keywords == input.Keywords ||
                    (Keywords != null &&
                    Keywords.Equals(input.Keywords))
                ) && 
                (
                    ClearEmptyValues == input.ClearEmptyValues ||
                    ClearEmptyValues.Equals(input.ClearEmptyValues)
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
                if (Author != null)
                    hashCode = hashCode * 59 + Author.GetHashCode();
                if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                if (Subject != null)
                    hashCode = hashCode * 59 + Subject.GetHashCode();
                if (Producer != null)
                    hashCode = hashCode * 59 + Producer.GetHashCode();
                if (Metadata != null)
                    hashCode = hashCode * 59 + Metadata.GetHashCode();
                if (Keywords != null)
                    hashCode = hashCode * 59 + Keywords.GetHashCode();
                hashCode = hashCode * 59 + ClearEmptyValues.GetHashCode();
                return hashCode;
            }
        }
    }

}
