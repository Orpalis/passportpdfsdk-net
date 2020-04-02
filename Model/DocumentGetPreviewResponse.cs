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
    /// Represents the response to a get document preview action request.
    /// </summary>
    [DataContract]
    public partial class DocumentGetPreviewResponse :  IEquatable<DocumentGetPreviewResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentGetPreviewResponse" /> class.
        /// </summary>
        public DocumentGetPreviewResponse()
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
        /// Specifies the page count of the document.
        /// </summary>
        [DataMember(Name="PageCount")]
        public int PageCount { get; private set; }

        /// <summary>
        /// Specifies the data of a thumbnail from the first page of the document, in PNG format.
        /// </summary>
        [DataMember(Name="ThumbnailData")]
        public byte[] ThumbnailData { get; private set; }

        /// <summary>
        /// Gets or Sets DocumentFormat
        /// </summary>
        [DataMember(Name="DocumentFormat")]
        public DocumentFormat DocumentFormat { get; set; }

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
            return Equals(input as DocumentGetPreviewResponse);
        }

        /// <summary>
        /// Returns true if DocumentGetPreviewResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentGetPreviewResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentGetPreviewResponse input)
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
                    PageCount == input.PageCount ||
                    PageCount.Equals(input.PageCount)
                ) && 
                (
                    ThumbnailData == input.ThumbnailData ||
                    (ThumbnailData != null &&
                    ThumbnailData.Equals(input.ThumbnailData))
                ) && 
                (
                    DocumentFormat == input.DocumentFormat ||
                    DocumentFormat.Equals(input.DocumentFormat)
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
                hashCode = hashCode * 59 + PageCount.GetHashCode();
                if (ThumbnailData != null)
                    hashCode = hashCode * 59 + ThumbnailData.GetHashCode();
                hashCode = hashCode * 59 + DocumentFormat.GetHashCode();
                return hashCode;
            }
        }
    }

}
