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
    /// Represents the parameters for an insert page number action.
    /// </summary>
    [DataContract]
    public partial class PdfInsertPageNumberParameters :  IEquatable<PdfInsertPageNumberParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfInsertPageNumberParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfInsertPageNumberParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfInsertPageNumberParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the page or the range of pages on which the page number shall be inserted. (required).</param>
        public PdfInsertPageNumberParameters(string fileId, string pageRange)
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
        /// Specifies the page or the range of pages on which the page number shall be inserted.
        /// </summary>
        [DataMember(Name="PageRange")]
        public string PageRange { get; set; }

        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name="Format")]
        public PageNumberFormat Format { get; set; }

        /// <summary>
        /// Gets or Sets Layout
        /// </summary>
        [DataMember(Name="Layout")]
        public DrawableContentLayoutParameters Layout { get; set; }

        /// <summary>
        /// Gets or Sets TextParameters
        /// </summary>
        [DataMember(Name="TextParameters")]
        public PdfAlignedTextParameters TextParameters { get; set; }

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
            return Equals(input as PdfInsertPageNumberParameters);
        }

        /// <summary>
        /// Returns true if PdfInsertPageNumberParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfInsertPageNumberParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfInsertPageNumberParameters input)
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
                    Format == input.Format ||
                    Format.Equals(input.Format)
                ) && 
                (
                    Layout == input.Layout ||
                    (Layout != null &&
                    Layout.Equals(input.Layout))
                ) && 
                (
                    TextParameters == input.TextParameters ||
                    (TextParameters != null &&
                    TextParameters.Equals(input.TextParameters))
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
                hashCode = hashCode * 59 + Format.GetHashCode();
                if (Layout != null)
                    hashCode = hashCode * 59 + Layout.GetHashCode();
                if (TextParameters != null)
                    hashCode = hashCode * 59 + TextParameters.GetHashCode();
                return hashCode;
            }
        }
    }

}
