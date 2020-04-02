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
    /// Represents the parameters for a get document preview action.
    /// </summary>
    [DataContract]
    public partial class GetDocumentPreviewParameters :  IEquatable<GetDocumentPreviewParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentPreviewParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetDocumentPreviewParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentPreviewParameters" /> class.
        /// </summary>
        /// <param name="fileName">Specifies the name of the file to be previewed. (required).</param>
        public GetDocumentPreviewParameters(string fileName)
        {
            FileName = fileName;
        }

        /// <summary>
        /// Specifies the identifier of the file to be previewed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the data of the document to be previewed.
        /// </summary>
        [DataMember(Name="FileData")]
        public byte[] FileData { get; set; }

        /// <summary>
        /// Specifies the name of the file to be previewed.
        /// </summary>
        [DataMember(Name="FileName")]
        public string FileName { get; set; }

        /// <summary>
        /// Specifies, in pixels, the width of the thumbnail to be retrieved.
        /// </summary>
        [DataMember(Name="ThumbnailWidth")]
        public int ThumbnailWidth { get; set; } = 140;

        /// <summary>
        /// Specifies, in pixels, the height of the thumbnail to be retrieved.
        /// </summary>
        [DataMember(Name="ThumbnailHeight")]
        public int ThumbnailHeight { get; set; } = 220;

        /// <summary>
        /// Specifies the background color of the thumbnail, using the color name (ie: \"red\") or its RGBa code (ie: \"rgba(255,0,0,1)\").
        /// </summary>
        [DataMember(Name="ThumbnailBackgroundColor")]
        public string ThumbnailBackgroundColor { get; set; } = "rgba(0,0,0,0)";

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
            return Equals(input as GetDocumentPreviewParameters);
        }

        /// <summary>
        /// Returns true if GetDocumentPreviewParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDocumentPreviewParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDocumentPreviewParameters input)
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
                    FileData == input.FileData ||
                    (FileData != null &&
                    FileData.Equals(input.FileData))
                ) && 
                (
                    FileName == input.FileName ||
                    (FileName != null &&
                    FileName.Equals(input.FileName))
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
                    ThumbnailBackgroundColor == input.ThumbnailBackgroundColor ||
                    (ThumbnailBackgroundColor != null &&
                    ThumbnailBackgroundColor.Equals(input.ThumbnailBackgroundColor))
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
                if (FileData != null)
                    hashCode = hashCode * 59 + FileData.GetHashCode();
                if (FileName != null)
                    hashCode = hashCode * 59 + FileName.GetHashCode();
                hashCode = hashCode * 59 + ThumbnailWidth.GetHashCode();
                hashCode = hashCode * 59 + ThumbnailHeight.GetHashCode();
                if (ThumbnailBackgroundColor != null)
                    hashCode = hashCode * 59 + ThumbnailBackgroundColor.GetHashCode();
                hashCode = hashCode * 59 + ThumbnailFitToPageSize.GetHashCode();
                return hashCode;
            }
        }
    }

}
