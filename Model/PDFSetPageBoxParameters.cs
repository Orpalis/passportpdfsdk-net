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
    /// Represents the parameters for a SetPageBox action.
    /// </summary>
    [DataContract]
    public partial class PdfSetPageBoxParameters :  IEquatable<PdfSetPageBoxParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfSetPageBoxParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfSetPageBoxParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfSetPageBoxParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of page whose page box shall be set. (required).</param>
        /// <param name="left">Specifies, in points, the newly defined left position of the specified page box. (required).</param>
        /// <param name="top">Specifies, in points, the newly defined top position of the specified page box. (required).</param>
        /// <param name="right">Specifies, in points, the newly defined right position of the specified page box. (required).</param>
        /// <param name="bottom">Specifies, in points, the newly defined bottom position of the specified page box. (required).</param>
        public PdfSetPageBoxParameters(string fileId, string pageRange, float left, float top, float right, float bottom)
        {
            FileId = fileId;
            PageRange = pageRange;
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of page whose page box shall be set.
        /// </summary>
        [DataMember(Name="PageRange")]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies, in points, the newly defined left position of the specified page box.
        /// </summary>
        [DataMember(Name="Left")]
        public float Left { get; set; }

        /// <summary>
        /// Specifies, in points, the newly defined top position of the specified page box.
        /// </summary>
        [DataMember(Name="Top")]
        public float Top { get; set; }

        /// <summary>
        /// Specifies, in points, the newly defined right position of the specified page box.
        /// </summary>
        [DataMember(Name="Right")]
        public float Right { get; set; }

        /// <summary>
        /// Specifies, in points, the newly defined bottom position of the specified page box.
        /// </summary>
        [DataMember(Name="Bottom")]
        public float Bottom { get; set; }

        /// <summary>
        /// Gets or Sets PageBox
        /// </summary>
        [DataMember(Name="PageBox")]
        public PdfPageBox PageBox { get; set; }

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
            return Equals(input as PdfSetPageBoxParameters);
        }

        /// <summary>
        /// Returns true if PdfSetPageBoxParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfSetPageBoxParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfSetPageBoxParameters input)
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
                    Left == input.Left ||
                    Left.Equals(input.Left)
                ) && 
                (
                    Top == input.Top ||
                    Top.Equals(input.Top)
                ) && 
                (
                    Right == input.Right ||
                    Right.Equals(input.Right)
                ) && 
                (
                    Bottom == input.Bottom ||
                    Bottom.Equals(input.Bottom)
                ) && 
                (
                    PageBox == input.PageBox ||
                    PageBox.Equals(input.PageBox)
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
                hashCode = hashCode * 59 + Left.GetHashCode();
                hashCode = hashCode * 59 + Top.GetHashCode();
                hashCode = hashCode * 59 + Right.GetHashCode();
                hashCode = hashCode * 59 + Bottom.GetHashCode();
                hashCode = hashCode * 59 + PageBox.GetHashCode();
                return hashCode;
            }
        }
    }

}
