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
    /// Represents the parameters for a cleanup document action.
    /// </summary>
    [DataContract]
    public partial class ImageCleanupDocumentParameters :  IEquatable<ImageCleanupDocumentParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageCleanupDocumentParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageCleanupDocumentParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageCleanupDocumentParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages to cleanup. (required).</param>
        public ImageCleanupDocumentParameters(string fileId, string pageRange)
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
        /// Specifies the number of the page, or the range of pages to cleanup.
        /// </summary>
        [DataMember(Name="PageRange")]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies whether the dark borders of the document image shall be replaced with white content.
        /// </summary>
        [DataMember(Name="RemoveBlackBorders")]
        public bool RemoveBlackBorders { get; set; } = false;

        /// <summary>
        /// Specifies whether the document shall be deskewed.
        /// </summary>
        [DataMember(Name="Deskew")]
        public bool Deskew { get; set; } = false;

        /// <summary>
        /// Specifies whether punch holes shall be removed from the left margin of the document.
        /// </summary>
        [DataMember(Name="RemoveLeftMarginPunchHoles")]
        public bool RemoveLeftMarginPunchHoles { get; set; } = false;

        /// <summary>
        /// Specifies whether punch holes shall be removed from the top margin of the document.
        /// </summary>
        [DataMember(Name="RemoveTopMarginPunchHoles")]
        public bool RemoveTopMarginPunchHoles { get; set; } = false;

        /// <summary>
        /// Specifies whether punch holes shall be removed from the right margin of the document.
        /// </summary>
        [DataMember(Name="RemoveRightMarginPunchHoles")]
        public bool RemoveRightMarginPunchHoles { get; set; } = false;

        /// <summary>
        /// Specifies whether punch holes shall be removed from the bottom margin of the document.
        /// </summary>
        [DataMember(Name="RemoveBottomMarginPunchHoles")]
        public bool RemoveBottomMarginPunchHoles { get; set; } = false;

        /// <summary>
        /// Specifies the strength of the despeckle filter to be applied on the image.
        /// </summary>
        [DataMember(Name="DespeckleStrength")]
        public int DespeckleStrength { get; set; } = 0;

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
            return Equals(input as ImageCleanupDocumentParameters);
        }

        /// <summary>
        /// Returns true if ImageCleanupDocumentParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageCleanupDocumentParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageCleanupDocumentParameters input)
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
                    RemoveBlackBorders == input.RemoveBlackBorders ||
                    RemoveBlackBorders.Equals(input.RemoveBlackBorders)
                ) && 
                (
                    Deskew == input.Deskew ||
                    Deskew.Equals(input.Deskew)
                ) && 
                (
                    RemoveLeftMarginPunchHoles == input.RemoveLeftMarginPunchHoles ||
                    RemoveLeftMarginPunchHoles.Equals(input.RemoveLeftMarginPunchHoles)
                ) && 
                (
                    RemoveTopMarginPunchHoles == input.RemoveTopMarginPunchHoles ||
                    RemoveTopMarginPunchHoles.Equals(input.RemoveTopMarginPunchHoles)
                ) && 
                (
                    RemoveRightMarginPunchHoles == input.RemoveRightMarginPunchHoles ||
                    RemoveRightMarginPunchHoles.Equals(input.RemoveRightMarginPunchHoles)
                ) && 
                (
                    RemoveBottomMarginPunchHoles == input.RemoveBottomMarginPunchHoles ||
                    RemoveBottomMarginPunchHoles.Equals(input.RemoveBottomMarginPunchHoles)
                ) && 
                (
                    DespeckleStrength == input.DespeckleStrength ||
                    DespeckleStrength.Equals(input.DespeckleStrength)
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
                hashCode = hashCode * 59 + RemoveBlackBorders.GetHashCode();
                hashCode = hashCode * 59 + Deskew.GetHashCode();
                hashCode = hashCode * 59 + RemoveLeftMarginPunchHoles.GetHashCode();
                hashCode = hashCode * 59 + RemoveTopMarginPunchHoles.GetHashCode();
                hashCode = hashCode * 59 + RemoveRightMarginPunchHoles.GetHashCode();
                hashCode = hashCode * 59 + RemoveBottomMarginPunchHoles.GetHashCode();
                hashCode = hashCode * 59 + DespeckleStrength.GetHashCode();
                return hashCode;
            }
        }
    }

}
