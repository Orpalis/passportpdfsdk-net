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
    /// Represents the parameters for an auto deskew action.
    /// </summary>
    [DataContract]
    public partial class PdfAutoDeskewParameters :  IEquatable<PdfAutoDeskewParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfAutoDeskewParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfAutoDeskewParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfAutoDeskewParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the page or the page range to be auto-deskewed. (required).</param>
        public PdfAutoDeskewParameters(string fileId, string pageRange)
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
        /// Specifies the page or the page range to be auto-deskewed.
        /// </summary>
        [DataMember(Name="PageRange")]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies the maximum skew angle to be detected. A value of below 15 is suggested.
        /// </summary>
        [DataMember(Name="MaxAngleOfResearch")]
        public float MaxAngleOfResearch { get; set; } = 15F;

        /// <summary>
        /// Specifies whether the skew detection engine must be optimistic when detecting angles.  If you know the image is skewed, you should set this to true.
        /// </summary>
        [DataMember(Name="Optimistic")]
        public bool Optimistic { get; set; } = false;

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
            return Equals(input as PdfAutoDeskewParameters);
        }

        /// <summary>
        /// Returns true if PdfAutoDeskewParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfAutoDeskewParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfAutoDeskewParameters input)
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
                    MaxAngleOfResearch == input.MaxAngleOfResearch ||
                    MaxAngleOfResearch.Equals(input.MaxAngleOfResearch)
                ) && 
                (
                    Optimistic == input.Optimistic ||
                    Optimistic.Equals(input.Optimistic)
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
                hashCode = hashCode * 59 + MaxAngleOfResearch.GetHashCode();
                hashCode = hashCode * 59 + Optimistic.GetHashCode();
                return hashCode;
            }
        }
    }

}
