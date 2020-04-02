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
    /// Represents the parameters for a get page thumbnail action.
    /// </summary>
    [DataContract]
    public partial class PdfGetPageThumbnailParameters :  IEquatable<PdfGetPageThumbnailParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfGetPageThumbnailParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfGetPageThumbnailParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfGetPageThumbnailParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the page or the range of pages to get a thumbnail from. (required).</param>
        public PdfGetPageThumbnailParameters(string fileId, string pageRange)
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
        /// Specifies the page or the range of pages to get a thumbnail from.
        /// </summary>
        [DataMember(Name="PageRange")]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies the width, in points, of the thumbnail(s).
        /// </summary>
        [DataMember(Name="ThumbnailWidth")]
        public int ThumbnailWidth { get; set; } = 140;

        /// <summary>
        /// Specifies the height, in points, of the thumbnail(s).
        /// </summary>
        [DataMember(Name="ThumbnailHeight")]
        public int ThumbnailHeight { get; set; } = 220;

        /// <summary>
        /// Specifies the background color of the thumbnail(s), using the color name (ie: \"red\") or its RGBa code (ie: \"rgba(255,0,0,1)\").
        /// </summary>
        [DataMember(Name="BackgroundColor")]
        public string BackgroundColor { get; set; } = "rgba(0,0,0,0)";

        /// <summary>
        /// Specifies if the size of the produced thumbnail is automatically adjusted to don't have any margin.
        /// </summary>
        [DataMember(Name="ThumbnailFitToPageSize")]
        public bool ThumbnailFitToPageSize { get; set; } = true;

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
            return Equals(input as PdfGetPageThumbnailParameters);
        }

        /// <summary>
        /// Returns true if PdfGetPageThumbnailParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfGetPageThumbnailParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfGetPageThumbnailParameters input)
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
                    ThumbnailWidth == input.ThumbnailWidth ||
                    ThumbnailWidth.Equals(input.ThumbnailWidth)
                ) && 
                (
                    ThumbnailHeight == input.ThumbnailHeight ||
                    ThumbnailHeight.Equals(input.ThumbnailHeight)
                ) && 
                (
                    BackgroundColor == input.BackgroundColor ||
                    (BackgroundColor != null &&
                    BackgroundColor.Equals(input.BackgroundColor))
                ) && 
                (
                    ThumbnailFitToPageSize == input.ThumbnailFitToPageSize ||
                    ThumbnailFitToPageSize.Equals(input.ThumbnailFitToPageSize)
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
                hashCode = hashCode * 59 + ThumbnailWidth.GetHashCode();
                hashCode = hashCode * 59 + ThumbnailHeight.GetHashCode();
                if (BackgroundColor != null)
                    hashCode = hashCode * 59 + BackgroundColor.GetHashCode();
                hashCode = hashCode * 59 + ThumbnailFitToPageSize.GetHashCode();
                return hashCode;
            }
        }
    }

}
