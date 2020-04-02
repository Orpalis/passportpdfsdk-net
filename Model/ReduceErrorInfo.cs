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
    /// Represents information about an error which caused the failure of a reduce action.
    /// </summary>
    [DataContract]
    public partial class ReduceErrorInfo :  IEquatable<ReduceErrorInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReduceErrorInfo" /> class.
        /// </summary>
        public ReduceErrorInfo()
        {
        }

        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="ErrorCode")]
        public ReduceErrorCode ErrorCode { get; set; }

        /// <summary>
        /// The number of the page processed when the error occured.
        /// </summary>
        [DataMember(Name="PageNumber")]
        public int PageNumber { get; private set; }

        /// <summary>
        /// The error message associated with the error, if any.
        /// </summary>
        [DataMember(Name="ExtErrorMessage")]
        public string ExtErrorMessage { get; private set; }

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
            return Equals(input as ReduceErrorInfo);
        }

        /// <summary>
        /// Returns true if ReduceErrorInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ReduceErrorInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReduceErrorInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    ErrorCode == input.ErrorCode ||
                    ErrorCode.Equals(input.ErrorCode)
                ) && 
                (
                    PageNumber == input.PageNumber ||
                    PageNumber.Equals(input.PageNumber)
                ) && 
                (
                    ExtErrorMessage == input.ExtErrorMessage ||
                    (ExtErrorMessage != null &&
                    ExtErrorMessage.Equals(input.ExtErrorMessage))
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
                hashCode = hashCode * 59 + ErrorCode.GetHashCode();
                hashCode = hashCode * 59 + PageNumber.GetHashCode();
                if (ExtErrorMessage != null)
                    hashCode = hashCode * 59 + ExtErrorMessage.GetHashCode();
                return hashCode;
            }
        }
    }

}
