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
    /// Holds the extracted text from a given page of a document.
    /// </summary>
    [DataContract]
    public partial class PageText :  IEquatable<PageText>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageText" /> class.
        /// </summary>
        public PageText()
        {
        }

        /// <summary>
        /// Specifies the number of the page.
        /// </summary>
        [DataMember(Name="PageNumber")]
        public int PageNumber { get; set; }

        /// <summary>
        /// The text extraction result.
        /// </summary>
        [DataMember(Name="ExtractedText")]
        public string ExtractedText { get; set; }

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
            return Equals(input as PageText);
        }

        /// <summary>
        /// Returns true if PageText instances are equal
        /// </summary>
        /// <param name="input">Instance of PageText to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PageText input)
        {
            if (input == null)
                return false;

            return 
                (
                    PageNumber == input.PageNumber ||
                    PageNumber.Equals(input.PageNumber)
                ) && 
                (
                    ExtractedText == input.ExtractedText ||
                    (ExtractedText != null &&
                    ExtractedText.Equals(input.ExtractedText))
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
                hashCode = hashCode * 59 + PageNumber.GetHashCode();
                if (ExtractedText != null)
                    hashCode = hashCode * 59 + ExtractedText.GetHashCode();
                return hashCode;
            }
        }
    }

}
