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
    /// Represents the parameters for a draw image action.
    /// </summary>
    [DataContract]
    public partial class PdfDrawImageParameters :  IEquatable<PdfDrawImageParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfDrawImageParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfDrawImageParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfDrawImageParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the page or the page range on which the image shall be drawn. (required).</param>
        public PdfDrawImageParameters(string fileId, string pageRange)
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
        /// Specifies the page or the page range on which the image shall be drawn.
        /// </summary>
        [DataMember(Name="PageRange")]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies the data of the image to be drawn.
        /// </summary>
        [DataMember(Name="ImageData")]
        public byte[] ImageData { get; set; }

        /// <summary>
        /// Specifies the file ID of the image to be drawn.
        /// </summary>
        [DataMember(Name="ImageFileId")]
        public string ImageFileId { get; set; } = "";

        /// <summary>
        /// Specifies the level of quality to be used for the compression, from 1 (poorest) to 100 (greatest).
        /// </summary>
        [DataMember(Name="Quality")]
        public int Quality { get; set; } = 75;

        /// <summary>
        /// Gets or Sets ColorImageCompression
        /// </summary>
        [DataMember(Name="ColorImageCompression")]
        public PdfImageCompressionScheme ColorImageCompression { get; set; }

        /// <summary>
        /// Gets or Sets BitonalCompression
        /// </summary>
        [DataMember(Name="BitonalCompression")]
        public PdfImageCompressionScheme BitonalCompression { get; set; }

        /// <summary>
        /// Gets or Sets ImageLayout
        /// </summary>
        [DataMember(Name="ImageLayout")]
        public DrawableContentLayoutParameters ImageLayout { get; set; }

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
            return Equals(input as PdfDrawImageParameters);
        }

        /// <summary>
        /// Returns true if PdfDrawImageParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfDrawImageParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfDrawImageParameters input)
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
                    ImageData == input.ImageData ||
                    (ImageData != null &&
                    ImageData.Equals(input.ImageData))
                ) && 
                (
                    ImageFileId == input.ImageFileId ||
                    (ImageFileId != null &&
                    ImageFileId.Equals(input.ImageFileId))
                ) && 
                (
                    Quality == input.Quality ||
                    Quality.Equals(input.Quality)
                ) && 
                (
                    ColorImageCompression == input.ColorImageCompression ||
                    ColorImageCompression.Equals(input.ColorImageCompression)
                ) && 
                (
                    BitonalCompression == input.BitonalCompression ||
                    BitonalCompression.Equals(input.BitonalCompression)
                ) && 
                (
                    ImageLayout == input.ImageLayout ||
                    (ImageLayout != null &&
                    ImageLayout.Equals(input.ImageLayout))
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
                if (ImageData != null)
                    hashCode = hashCode * 59 + ImageData.GetHashCode();
                if (ImageFileId != null)
                    hashCode = hashCode * 59 + ImageFileId.GetHashCode();
                hashCode = hashCode * 59 + Quality.GetHashCode();
                hashCode = hashCode * 59 + ColorImageCompression.GetHashCode();
                hashCode = hashCode * 59 + BitonalCompression.GetHashCode();
                if (ImageLayout != null)
                    hashCode = hashCode * 59 + ImageLayout.GetHashCode();
                return hashCode;
            }
        }
    }

}
