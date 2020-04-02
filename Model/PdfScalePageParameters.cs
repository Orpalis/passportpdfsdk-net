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
    /// Represents the parameters for a scale page action.
    /// </summary>
    [DataContract]
    public partial class PdfScalePageParameters :  IEquatable<PdfScalePageParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfScalePageParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfScalePageParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfScalePageParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages which shall be scaled. (required).</param>
        /// <param name="scaleX">Specifies the horizontal scale factor, by which the width of the page shall be multiplied. (required).</param>
        /// <param name="scaleY">Specifies the horizontal scale factor, by which the height of the page shall be multiplied. (required).</param>
        public PdfScalePageParameters(string fileId, string pageRange, float scaleX, float scaleY)
        {
            FileId = fileId;
            PageRange = pageRange;
            ScaleX = scaleX;
            ScaleY = scaleY;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages which shall be scaled.
        /// </summary>
        [DataMember(Name="PageRange")]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies the horizontal scale factor, by which the width of the page shall be multiplied.
        /// </summary>
        [DataMember(Name="ScaleX")]
        public float ScaleX { get; set; }

        /// <summary>
        /// Specifies the horizontal scale factor, by which the height of the page shall be multiplied.
        /// </summary>
        [DataMember(Name="ScaleY")]
        public float ScaleY { get; set; }

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
            return Equals(input as PdfScalePageParameters);
        }

        /// <summary>
        /// Returns true if PdfScalePageParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfScalePageParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfScalePageParameters input)
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
                    ScaleX == input.ScaleX ||
                    ScaleX.Equals(input.ScaleX)
                ) && 
                (
                    ScaleY == input.ScaleY ||
                    ScaleY.Equals(input.ScaleY)
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
                hashCode = hashCode * 59 + ScaleX.GetHashCode();
                hashCode = hashCode * 59 + ScaleY.GetHashCode();
                return hashCode;
            }
        }
    }

}
