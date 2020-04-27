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
    /// Represents the parameters for an image loading request.
    /// </summary>
    [DataContract]
    public partial class LoadImageFromByteArrayParameters :  IEquatable<LoadImageFromByteArrayParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoadImageFromByteArrayParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LoadImageFromByteArrayParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadImageFromByteArrayParameters" /> class.
        /// </summary>
        /// <param name="content">Specifies the data of the image. (required).</param>
        public LoadImageFromByteArrayParameters(byte[] content)
        {
            Content = content;
        }

        /// <summary>
        /// Specifies the data of the image.
        /// </summary>
        [DataMember(Name="Content")]
        public byte[] Content { get; set; }

        /// <summary>
        /// Specifies the name of the document.
        /// </summary>
        [DataMember(Name="FileName")]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or Sets ContentEncoding
        /// </summary>
        [DataMember(Name="ContentEncoding")]
        public ContentEncoding ContentEncoding { get; set; }

        /// <summary>
        /// Specifies whether the response must contain a thumbnail of the first page of the document.
        /// </summary>
        [DataMember(Name="GetPreview")]
        public bool GetPreview { get; set; } = false;

        /// <summary>
        /// Specifies, in pixels, the width of the thumbnail to be retrieved. Only applicable if GetPreview has been set to true.
        /// </summary>
        [DataMember(Name="ThumbnailWidth")]
        public int ThumbnailWidth { get; set; } = 140;

        /// <summary>
        /// Specifies, in pixels, the height of the thumbnail to be retrieved.  Only applicable if GetPreview has been set to true.
        /// </summary>
        [DataMember(Name="ThumbnailHeight")]
        public int ThumbnailHeight { get; set; } = 220;

        /// <summary>
        /// Specifies the background color of the thumbnail, using the color name (ie: \"red\") or its RGBa code (ie: \"rgba(255,0,0,1)\").   Only applicable if GetPreview has been set to true.
        /// </summary>
        [DataMember(Name="ThumbnailBackgroundColor")]
        public string ThumbnailBackgroundColor { get; set; } = "rgba(0,0,0,0)";

        /// <summary>
        /// Specifies if the size of the produced thumbnail is automatically adjusted to don't have any margin.  Only applicable if GetPreview has been set to true.
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
            return Equals(input as LoadImageFromByteArrayParameters);
        }

        /// <summary>
        /// Returns true if LoadImageFromByteArrayParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of LoadImageFromByteArrayParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoadImageFromByteArrayParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    Content == input.Content ||
                    (Content != null &&
                    Content.Equals(input.Content))
                ) && 
                (
                    FileName == input.FileName ||
                    (FileName != null &&
                    FileName.Equals(input.FileName))
                ) && 
                (
                    ContentEncoding == input.ContentEncoding ||
                    ContentEncoding.Equals(input.ContentEncoding)
                ) && 
                (
                    GetPreview == input.GetPreview ||
                    GetPreview.Equals(input.GetPreview)
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
                if (Content != null)
                    hashCode = hashCode * 59 + Content.GetHashCode();
                if (FileName != null)
                    hashCode = hashCode * 59 + FileName.GetHashCode();
                hashCode = hashCode * 59 + ContentEncoding.GetHashCode();
                hashCode = hashCode * 59 + GetPreview.GetHashCode();
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
