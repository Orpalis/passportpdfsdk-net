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
    /// Represents the parameters for an insert new page action.
    /// </summary>
    [DataContract]
    public partial class PdfInsertNewPageParameters :  IEquatable<PdfInsertNewPageParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfInsertNewPageParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfInsertNewPageParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfInsertNewPageParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageNumber">Specifies the number of the page where the new page(s) shall be inserted. (required).</param>
        public PdfInsertNewPageParameters(string fileId, int pageNumber)
        {
            FileId = fileId;
            PageNumber = pageNumber;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page where the new page(s) shall be inserted.
        /// </summary>
        [DataMember(Name="PageNumber")]
        public int PageNumber { get; set; }

        /// <summary>
        /// Specifies the number of pages that must be inserted.
        /// </summary>
        [DataMember(Name="PageCount")]
        public int PageCount { get; set; } = 1;

        /// <summary>
        /// Specifies, in points, the width of the page(s) to be inserted.
        /// </summary>
        [DataMember(Name="Width")]
        public float Width { get; set; } = 595F;

        /// <summary>
        /// Specifies, in points, the height of the page(s) to be inserted.
        /// </summary>
        [DataMember(Name="Height")]
        public float Height { get; set; } = 842F;

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
            return Equals(input as PdfInsertNewPageParameters);
        }

        /// <summary>
        /// Returns true if PdfInsertNewPageParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfInsertNewPageParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfInsertNewPageParameters input)
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
                    PageNumber == input.PageNumber ||
                    PageNumber.Equals(input.PageNumber)
                ) && 
                (
                    PageCount == input.PageCount ||
                    PageCount.Equals(input.PageCount)
                ) && 
                (
                    Width == input.Width ||
                    Width.Equals(input.Width)
                ) && 
                (
                    Height == input.Height ||
                    Height.Equals(input.Height)
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
                hashCode = hashCode * 59 + PageNumber.GetHashCode();
                hashCode = hashCode * 59 + PageCount.GetHashCode();
                hashCode = hashCode * 59 + Width.GetHashCode();
                hashCode = hashCode * 59 + Height.GetHashCode();
                return hashCode;
            }
        }
    }

}
