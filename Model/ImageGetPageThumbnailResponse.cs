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
    /// Represents the response to a get page thumbnail action request.
    /// </summary>
    [DataContract]
    public partial class ImageGetPageThumbnailResponse :  IEquatable<ImageGetPageThumbnailResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGetPageThumbnailResponse" /> class.
        /// </summary>
        public ImageGetPageThumbnailResponse()
        {
        }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="Error")]
        public Error Error { get; set; }

        /// <summary>
        /// Specifies the number of remaining tokens.
        /// </summary>
        [DataMember(Name="RemainingTokens")]
        public long RemainingTokens { get; set; }

        /// <summary>
        /// Contains all the obtained thumbnails.
        /// </summary>
        [DataMember(Name="PageThumbnails")]
        public List<PageImage> PageThumbnails { get; private set; }

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
            return Equals(input as ImageGetPageThumbnailResponse);
        }

        /// <summary>
        /// Returns true if ImageGetPageThumbnailResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageGetPageThumbnailResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageGetPageThumbnailResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    Error == input.Error ||
                    (Error != null &&
                    Error.Equals(input.Error))
                ) && 
                (
                    RemainingTokens == input.RemainingTokens ||
                    RemainingTokens.Equals(input.RemainingTokens)
                ) && 
                (
                    PageThumbnails == input.PageThumbnails ||
                    PageThumbnails != null &&
                    input.PageThumbnails != null &&
                    PageThumbnails.SequenceEqual(input.PageThumbnails)
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
                if (Error != null)
                    hashCode = hashCode * 59 + Error.GetHashCode();
                hashCode = hashCode * 59 + RemainingTokens.GetHashCode();
                if (PageThumbnails != null)
                    hashCode = hashCode * 59 + PageThumbnails.GetHashCode();
                return hashCode;
            }
        }
    }

}
