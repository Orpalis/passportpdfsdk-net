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
    /// Represents the parameters for a MICR action.
    /// </summary>
    [DataContract]
    public partial class ImageMICRParameters :  IEquatable<ImageMICRParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageMICRParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageMICRParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageMICRParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the page or the range of page to be processed. (required).</param>
        /// <param name="font">font (required).</param>
        /// <param name="context">context (required).</param>
        public ImageMICRParameters(string fileId, string pageRange, MicrFont font, MicrContext context)
        {
            FileId = fileId;
            PageRange = pageRange;
            Font = font;
            Context = context;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the page or the range of page to be processed.
        /// </summary>
        [DataMember(Name="PageRange")]
        public string PageRange { get; set; }

        /// <summary>
        /// Gets or Sets Font
        /// </summary>
        [DataMember(Name="Font")]
        public MicrFont Font { get; set; }

        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name="Context")]
        public MicrContext Context { get; set; }

        /// <summary>
        /// Specifies the characters to be ignored by the recognition process.
        /// </summary>
        [DataMember(Name="WhiteList")]
        public string WhiteList { get; set; } = "";

        /// <summary>
        /// Specifies the left coordinate, in pixel, of the region to process.
        /// </summary>
        [DataMember(Name="RoiLeft")]
        public int RoiLeft { get; set; } = 0;

        /// <summary>
        /// Specifies the top coordinate, in pixel, of the region to process.
        /// </summary>
        [DataMember(Name="RoiTop")]
        public int RoiTop { get; set; } = 0;

        /// <summary>
        /// Specifies the width, in pixel, of the region to process. 0 causes the entire image to be processed.
        /// </summary>
        [DataMember(Name="RoiWidth")]
        public int RoiWidth { get; set; } = 0;

        /// <summary>
        /// Specifies the height, in pixel, of the region to process. 0 causes the entire image to be processed.
        /// </summary>
        [DataMember(Name="RoiHeight")]
        public int RoiHeight { get; set; } = 0;

        /// <summary>
        /// Specifies the number of symbols expected to be detected, use 0 if unknown.
        /// </summary>
        [DataMember(Name="ExpectedSymbolsCount")]
        public int ExpectedSymbolsCount { get; set; } = 0;

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
            return Equals(input as ImageMICRParameters);
        }

        /// <summary>
        /// Returns true if ImageMICRParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageMICRParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageMICRParameters input)
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
                    Font == input.Font ||
                    Font.Equals(input.Font)
                ) && 
                (
                    Context == input.Context ||
                    Context.Equals(input.Context)
                ) && 
                (
                    WhiteList == input.WhiteList ||
                    (WhiteList != null &&
                    WhiteList.Equals(input.WhiteList))
                ) && 
                (
                    RoiLeft == input.RoiLeft ||
                    RoiLeft.Equals(input.RoiLeft)
                ) && 
                (
                    RoiTop == input.RoiTop ||
                    RoiTop.Equals(input.RoiTop)
                ) && 
                (
                    RoiWidth == input.RoiWidth ||
                    RoiWidth.Equals(input.RoiWidth)
                ) && 
                (
                    RoiHeight == input.RoiHeight ||
                    RoiHeight.Equals(input.RoiHeight)
                ) && 
                (
                    ExpectedSymbolsCount == input.ExpectedSymbolsCount ||
                    ExpectedSymbolsCount.Equals(input.ExpectedSymbolsCount)
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
                hashCode = hashCode * 59 + Font.GetHashCode();
                hashCode = hashCode * 59 + Context.GetHashCode();
                if (WhiteList != null)
                    hashCode = hashCode * 59 + WhiteList.GetHashCode();
                hashCode = hashCode * 59 + RoiLeft.GetHashCode();
                hashCode = hashCode * 59 + RoiTop.GetHashCode();
                hashCode = hashCode * 59 + RoiWidth.GetHashCode();
                hashCode = hashCode * 59 + RoiHeight.GetHashCode();
                hashCode = hashCode * 59 + ExpectedSymbolsCount.GetHashCode();
                return hashCode;
            }
        }
    }

}
