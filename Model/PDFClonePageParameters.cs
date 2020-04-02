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
    /// Represents the parameters for a ClonePage action.
    /// </summary>
    [DataContract]
    public partial class PdfClonePageParameters :  IEquatable<PdfClonePageParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfClonePageParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfClonePageParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfClonePageParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="sourceFileId">Specifies the file identifier of the PDF to be cloned. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages to be cloned. (required).</param>
        /// <param name="destinationPage">Specifies the number of the page where the cloned page(s) shall be inserted. (required).</param>
        public PdfClonePageParameters(string fileId, string sourceFileId, string pageRange, int destinationPage)
        {
            FileId = fileId;
            SourceFileId = sourceFileId;
            PageRange = pageRange;
            DestinationPage = destinationPage;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the file identifier of the PDF to be cloned.
        /// </summary>
        [DataMember(Name="SourceFileId")]
        public string SourceFileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to be cloned.
        /// </summary>
        [DataMember(Name="PageRange")]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies the number of the page where the cloned page(s) shall be inserted.
        /// </summary>
        [DataMember(Name="DestinationPage")]
        public int DestinationPage { get; set; }

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
            return Equals(input as PdfClonePageParameters);
        }

        /// <summary>
        /// Returns true if PdfClonePageParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfClonePageParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfClonePageParameters input)
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
                    SourceFileId == input.SourceFileId ||
                    (SourceFileId != null &&
                    SourceFileId.Equals(input.SourceFileId))
                ) && 
                (
                    PageRange == input.PageRange ||
                    (PageRange != null &&
                    PageRange.Equals(input.PageRange))
                ) && 
                (
                    DestinationPage == input.DestinationPage ||
                    DestinationPage.Equals(input.DestinationPage)
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
                if (SourceFileId != null)
                    hashCode = hashCode * 59 + SourceFileId.GetHashCode();
                if (PageRange != null)
                    hashCode = hashCode * 59 + PageRange.GetHashCode();
                hashCode = hashCode * 59 + DestinationPage.GetHashCode();
                return hashCode;
            }
        }
    }

}
