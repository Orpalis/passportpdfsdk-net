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
    /// Represents the parameters for an extract page action.
    /// </summary>
    [DataContract]
    public partial class PdfExtractPageParameters :  IEquatable<PdfExtractPageParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfExtractPageParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfExtractPageParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfExtractPageParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages to be extracted. (required).</param>
        public PdfExtractPageParameters(string fileId, string pageRange)
        {
            FileId = fileId;
            PageRange = pageRange;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to be extracted.
        /// </summary>
        [DataMember(Name="PageRange")]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies whether each extracted page shall form a separate document.
        /// </summary>
        [DataMember(Name="ExtractAsSeparate")]
        public bool ExtractAsSeparate { get; set; } = false;

        /// <summary>
        /// Specifies whether the file(s) created as a result of the action shall be available for immediate download.
        /// </summary>
        [DataMember(Name="ImmediateDownload")]
        public bool ImmediateDownload { get; set; } = false;

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
            return Equals(input as PdfExtractPageParameters);
        }

        /// <summary>
        /// Returns true if PdfExtractPageParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfExtractPageParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfExtractPageParameters input)
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
                    PageRange == input.PageRange ||
                    (PageRange != null &&
                    PageRange.Equals(input.PageRange))
                ) && 
                (
                    ExtractAsSeparate == input.ExtractAsSeparate ||
                    ExtractAsSeparate.Equals(input.ExtractAsSeparate)
                ) && 
                (
                    ImmediateDownload == input.ImmediateDownload ||
                    ImmediateDownload.Equals(input.ImmediateDownload)
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
                if (PageRange != null)
                    hashCode = hashCode * 59 + PageRange.GetHashCode();
                hashCode = hashCode * 59 + ExtractAsSeparate.GetHashCode();
                hashCode = hashCode * 59 + ImmediateDownload.GetHashCode();
                return hashCode;
            }
        }
    }

}
