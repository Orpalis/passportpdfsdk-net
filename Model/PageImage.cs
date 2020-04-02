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
    /// Holds the data of an image from a given page of a document.
    /// </summary>
    [DataContract]
    public partial class PageImage :  IEquatable<PageImage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageImage" /> class.
        /// </summary>
        public PageImage()
        {
        }

        /// <summary>
        /// Specifies the number of the page.
        /// </summary>
        [DataMember(Name="PageNumber")]
        public int PageNumber { get; set; }

        /// <summary>
        /// The data of the image.
        /// </summary>
        [DataMember(Name="ImageData")]
        public byte[] ImageData { get; set; }

        /// <summary>
        /// Specifies the name of the file.
        /// </summary>
        [DataMember(Name="FileName")]
        public string FileName { get; set; }

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
            return Equals(input as PageImage);
        }

        /// <summary>
        /// Returns true if PageImage instances are equal
        /// </summary>
        /// <param name="input">Instance of PageImage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PageImage input)
        {
            if (input == null)
                return false;

            return 
                (
                    PageNumber == input.PageNumber ||
                    PageNumber.Equals(input.PageNumber)
                ) && 
                (
                    ImageData == input.ImageData ||
                    (ImageData != null &&
                    ImageData.Equals(input.ImageData))
                ) && 
                (
                    FileName == input.FileName ||
                    (FileName != null &&
                    FileName.Equals(input.FileName))
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
                if (ImageData != null)
                    hashCode = hashCode * 59 + ImageData.GetHashCode();
                if (FileName != null)
                    hashCode = hashCode * 59 + FileName.GetHashCode();
                return hashCode;
            }
        }
    }

}
