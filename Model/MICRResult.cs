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
    /// Represents the result of a MICR operation run on a document given page.
    /// </summary>
    [DataContract]
    public partial class MICRResult :  IEquatable<MICRResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MICRResult" /> class.
        /// </summary>
        public MICRResult()
        {
        }

        /// <summary>
        /// Specifies the number of the page on which the symbols have been detected.
        /// </summary>
        [DataMember(Name="PageNumber")]
        public int PageNumber { get; set; }

        /// <summary>
        /// The detected data.
        /// </summary>
        [DataMember(Name="Data")]
        public string Data { get; set; }

        /// <summary>
        /// Holds detailed information about every single symbol which has been detected.
        /// </summary>
        [DataMember(Name="DetectedSymbols")]
        public List<MICRSymbolInfo> DetectedSymbols { get; set; }

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
            return Equals(input as MICRResult);
        }

        /// <summary>
        /// Returns true if MICRResult instances are equal
        /// </summary>
        /// <param name="input">Instance of MICRResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MICRResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    PageNumber == input.PageNumber ||
                    PageNumber.Equals(input.PageNumber)
                ) && 
                (
                    Data == input.Data ||
                    (Data != null &&
                    Data.Equals(input.Data))
                ) && 
                (
                    DetectedSymbols == input.DetectedSymbols ||
                    DetectedSymbols != null &&
                    input.DetectedSymbols != null &&
                    DetectedSymbols.SequenceEqual(input.DetectedSymbols)
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
                if (Data != null)
                    hashCode = hashCode * 59 + Data.GetHashCode();
                if (DetectedSymbols != null)
                    hashCode = hashCode * 59 + DetectedSymbols.GetHashCode();
                return hashCode;
            }
        }
    }

}
