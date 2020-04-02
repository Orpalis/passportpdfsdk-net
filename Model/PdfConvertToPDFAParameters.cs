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
    /// Represents the parameters for a convert to PDF/A action.
    /// </summary>
    [DataContract]
    public partial class PdfConvertToPDFAParameters :  IEquatable<PdfConvertToPDFAParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfConvertToPDFAParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfConvertToPDFAParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfConvertToPDFAParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        public PdfConvertToPDFAParameters(string fileId)
        {
            FileId = fileId;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Gets or Sets Conformance
        /// </summary>
        [DataMember(Name="Conformance")]
        public PdfAConformance Conformance { get; set; }

        /// <summary>
        /// If set to true, conversion engine will use the page vectorization in case direct conversion is not possible.
        /// </summary>
        [DataMember(Name="AllowVectorization")]
        public bool AllowVectorization { get; set; } = true;

        /// <summary>
        /// If set to true, conversion engine will use the page rasterization in case direct conversion and verorization are not possible or allowed.
        /// </summary>
        [DataMember(Name="AllowRasterization")]
        public bool AllowRasterization { get; set; } = true;

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
            return Equals(input as PdfConvertToPDFAParameters);
        }

        /// <summary>
        /// Returns true if PdfConvertToPDFAParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfConvertToPDFAParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfConvertToPDFAParameters input)
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
                    Conformance == input.Conformance ||
                    Conformance.Equals(input.Conformance)
                ) && 
                (
                    AllowVectorization == input.AllowVectorization ||
                    AllowVectorization.Equals(input.AllowVectorization)
                ) && 
                (
                    AllowRasterization == input.AllowRasterization ||
                    AllowRasterization.Equals(input.AllowRasterization)
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
                hashCode = hashCode * 59 + Conformance.GetHashCode();
                hashCode = hashCode * 59 + AllowVectorization.GetHashCode();
                hashCode = hashCode * 59 + AllowRasterization.GetHashCode();
                return hashCode;
            }
        }
    }

}
