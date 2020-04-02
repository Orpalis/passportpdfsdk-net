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
    /// Represents information about a warning that occured during a reduce action.
    /// </summary>
    [DataContract]
    public partial class ReduceWarningInfo :  IEquatable<ReduceWarningInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReduceWarningInfo" /> class.
        /// </summary>
        public ReduceWarningInfo()
        {
        }

        /// <summary>
        /// Gets or Sets WarningCode
        /// </summary>
        [DataMember(Name="WarningCode")]
        public ReduceWarningCode WarningCode { get; set; }

        /// <summary>
        /// The number of the page processed when the warning occured.
        /// </summary>
        [DataMember(Name="PageNumber")]
        public int PageNumber { get; private set; }

        /// <summary>
        /// The number of the image of the page processed when the warning occured.
        /// </summary>
        [DataMember(Name="PageImageNumber")]
        public int PageImageNumber { get; private set; }

        /// <summary>
        /// The warning message associated with the warning, if any.
        /// </summary>
        [DataMember(Name="ExtWarningMessage")]
        public string ExtWarningMessage { get; private set; }

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
            return Equals(input as ReduceWarningInfo);
        }

        /// <summary>
        /// Returns true if ReduceWarningInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ReduceWarningInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReduceWarningInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    WarningCode == input.WarningCode ||
                    WarningCode.Equals(input.WarningCode)
                ) && 
                (
                    PageNumber == input.PageNumber ||
                    PageNumber.Equals(input.PageNumber)
                ) && 
                (
                    PageImageNumber == input.PageImageNumber ||
                    PageImageNumber.Equals(input.PageImageNumber)
                ) && 
                (
                    ExtWarningMessage == input.ExtWarningMessage ||
                    (ExtWarningMessage != null &&
                    ExtWarningMessage.Equals(input.ExtWarningMessage))
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
                hashCode = hashCode * 59 + WarningCode.GetHashCode();
                hashCode = hashCode * 59 + PageNumber.GetHashCode();
                hashCode = hashCode * 59 + PageImageNumber.GetHashCode();
                if (ExtWarningMessage != null)
                    hashCode = hashCode * 59 + ExtWarningMessage.GetHashCode();
                return hashCode;
            }
        }
    }

}
