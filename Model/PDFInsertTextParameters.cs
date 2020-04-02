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
    /// Represents the parameters for an insert text action.
    /// </summary>
    [DataContract]
    public partial class PdfInsertTextParameters :  IEquatable<PdfInsertTextParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfInsertTextParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfInsertTextParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfInsertTextParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages on which the text shall be inserted. (required).</param>
        /// <param name="textParameters">textParameters (required).</param>
        public PdfInsertTextParameters(string fileId, string pageRange, PdfAlignedTextParameters textParameters)
        {
            FileId = fileId;
            PageRange = pageRange;
            TextParameters = textParameters;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages on which the text shall be inserted.
        /// </summary>
        [DataMember(Name="PageRange")]
        public string PageRange { get; set; }

        /// <summary>
        /// Gets or Sets TextParameters
        /// </summary>
        [DataMember(Name="TextParameters")]
        public PdfAlignedTextParameters TextParameters { get; set; }

        /// <summary>
        /// Gets or Sets TextBoundingBoxLayout
        /// </summary>
        [DataMember(Name="TextBoundingBoxLayout")]
        public DrawableContentLayoutParameters TextBoundingBoxLayout { get; set; }

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
            return Equals(input as PdfInsertTextParameters);
        }

        /// <summary>
        /// Returns true if PdfInsertTextParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfInsertTextParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfInsertTextParameters input)
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
                    TextParameters == input.TextParameters ||
                    (TextParameters != null &&
                    TextParameters.Equals(input.TextParameters))
                ) && 
                (
                    TextBoundingBoxLayout == input.TextBoundingBoxLayout ||
                    (TextBoundingBoxLayout != null &&
                    TextBoundingBoxLayout.Equals(input.TextBoundingBoxLayout))
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
                if (TextParameters != null)
                    hashCode = hashCode * 59 + TextParameters.GetHashCode();
                if (TextBoundingBoxLayout != null)
                    hashCode = hashCode * 59 + TextBoundingBoxLayout.GetHashCode();
                return hashCode;
            }
        }
    }

}
