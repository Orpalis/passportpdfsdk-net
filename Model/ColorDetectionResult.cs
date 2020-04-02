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
    /// Represents the result to a color detection operation performed on a given page of an image.
    /// </summary>
    [DataContract]
    public partial class ColorDetectionResult :  IEquatable<ColorDetectionResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ColorDetectionResult" /> class.
        /// </summary>
        public ColorDetectionResult()
        {
        }

        /// <summary>
        /// Specifies the number of the analyzed page.
        /// </summary>
        [DataMember(Name="PageNumber")]
        public int PageNumber { get; set; }

        /// <summary>
        /// Gets or Sets OutputIntent
        /// </summary>
        [DataMember(Name="OutputIntent")]
        public OutputIntent OutputIntent { get; set; }

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
            return Equals(input as ColorDetectionResult);
        }

        /// <summary>
        /// Returns true if ColorDetectionResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ColorDetectionResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ColorDetectionResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    PageNumber == input.PageNumber ||
                    PageNumber.Equals(input.PageNumber)
                ) && 
                (
                    OutputIntent == input.OutputIntent ||
                    OutputIntent.Equals(input.OutputIntent)
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
                hashCode = hashCode * 59 + OutputIntent.GetHashCode();
                return hashCode;
            }
        }
    }

}
