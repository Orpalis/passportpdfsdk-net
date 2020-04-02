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
    /// Represents the response to a save as JPEG action request.
    /// </summary>
    [DataContract]
    public partial class PdfSaveAsJPEGResponse :  IEquatable<PdfSaveAsJPEGResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfSaveAsJPEGResponse" /> class.
        /// </summary>
        public PdfSaveAsJPEGResponse()
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
        /// The page(s) of the PDF saved as JPEG image(s).
        /// </summary>
        [DataMember(Name="PageImages")]
        public List<PageImage> PageImages { get; private set; }

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
            return Equals(input as PdfSaveAsJPEGResponse);
        }

        /// <summary>
        /// Returns true if PdfSaveAsJPEGResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfSaveAsJPEGResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfSaveAsJPEGResponse input)
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
                    PageImages == input.PageImages ||
                    PageImages != null &&
                    input.PageImages != null &&
                    PageImages.SequenceEqual(input.PageImages)
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
                if (PageImages != null)
                    hashCode = hashCode * 59 + PageImages.GetHashCode();
                return hashCode;
            }
        }
    }

}
