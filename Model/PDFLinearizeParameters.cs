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
    /// Represents the parameters for a linearize action.
    /// </summary>
    [DataContract]
    public partial class PdfLinearizeParameters :  IEquatable<PdfLinearizeParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfLinearizeParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfLinearizeParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfLinearizeParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        public PdfLinearizeParameters(string fileId)
        {
            FileId = fileId;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies whether the document shall be packed, in order to reduce its size.
        /// </summary>
        [DataMember(Name="PackDocument")]
        public bool PackDocument { get; set; } = false;

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
            return Equals(input as PdfLinearizeParameters);
        }

        /// <summary>
        /// Returns true if PdfLinearizeParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfLinearizeParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfLinearizeParameters input)
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
                    PackDocument == input.PackDocument ||
                    PackDocument.Equals(input.PackDocument)
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
                hashCode = hashCode * 59 + PackDocument.GetHashCode();
                return hashCode;
            }
        }
    }

}
