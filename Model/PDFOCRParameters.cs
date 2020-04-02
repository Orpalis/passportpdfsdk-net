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
    /// Represents the parameters for an OCR action.
    /// </summary>
    [DataContract]
    public partial class PdfOCRParameters :  IEquatable<PdfOCRParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfOCRParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfOCRParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfOCRParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the page or the page range to be processed. (required).</param>
        public PdfOCRParameters(string fileId, string pageRange)
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
        /// Specifies the page or the page range to be processed.
        /// </summary>
        [DataMember(Name="PageRange")]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies the language to be used for the OCR.
        /// </summary>
        [DataMember(Name="Language")]
        public string Language { get; set; } = "eng";

        /// <summary>
        /// Specifies if pages containing text must be ignored (in such case no token is charged).
        /// </summary>
        [DataMember(Name="SkipPageWithText")]
        public bool SkipPageWithText { get; set; } = true;

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
            return Equals(input as PdfOCRParameters);
        }

        /// <summary>
        /// Returns true if PdfOCRParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfOCRParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfOCRParameters input)
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
                    Language == input.Language ||
                    (Language != null &&
                    Language.Equals(input.Language))
                ) && 
                (
                    SkipPageWithText == input.SkipPageWithText ||
                    SkipPageWithText.Equals(input.SkipPageWithText)
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
                if (Language != null)
                    hashCode = hashCode * 59 + Language.GetHashCode();
                hashCode = hashCode * 59 + SkipPageWithText.GetHashCode();
                return hashCode;
            }
        }
    }

}
