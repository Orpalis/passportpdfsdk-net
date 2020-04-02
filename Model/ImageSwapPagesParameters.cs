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
    /// Represents the parameters for a swap pages action.
    /// </summary>
    [DataContract]
    public partial class ImageSwapPagesParameters :  IEquatable<ImageSwapPagesParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSwapPagesParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageSwapPagesParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSwapPagesParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="page1">Specifies the number of the first page. (required).</param>
        /// <param name="page2">Specifies the number of the second page. (required).</param>
        public ImageSwapPagesParameters(string fileId, int page1, int page2)
        {
            FileId = fileId;
            Page1 = page1;
            Page2 = page2;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the first page.
        /// </summary>
        [DataMember(Name="Page1")]
        public int Page1 { get; set; }

        /// <summary>
        /// Specifies the number of the second page.
        /// </summary>
        [DataMember(Name="Page2")]
        public int Page2 { get; set; }

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
            return Equals(input as ImageSwapPagesParameters);
        }

        /// <summary>
        /// Returns true if ImageSwapPagesParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageSwapPagesParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageSwapPagesParameters input)
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
                    Page1 == input.Page1 ||
                    Page1.Equals(input.Page1)
                ) && 
                (
                    Page2 == input.Page2 ||
                    Page2.Equals(input.Page2)
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
                hashCode = hashCode * 59 + Page1.GetHashCode();
                hashCode = hashCode * 59 + Page2.GetHashCode();
                return hashCode;
            }
        }
    }

}
