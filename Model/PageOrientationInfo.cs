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
    /// Represents information about the orientation of a given page.
    /// </summary>
    [DataContract]
    public partial class PageOrientationInfo :  IEquatable<PageOrientationInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageOrientationInfo" /> class.
        /// </summary>
        public PageOrientationInfo()
        {
        }

        /// <summary>
        /// Specifies the number of the page.
        /// </summary>
        [DataMember(Name="PageNumber")]
        public int PageNumber { get; set; }

        /// <summary>
        /// Specifies, clockwise in degrees, the rotation angle of the page.
        /// </summary>
        [DataMember(Name="RotationAngle")]
        public int RotationAngle { get; set; }

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
            return Equals(input as PageOrientationInfo);
        }

        /// <summary>
        /// Returns true if PageOrientationInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PageOrientationInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PageOrientationInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    PageNumber == input.PageNumber ||
                    PageNumber.Equals(input.PageNumber)
                ) && 
                (
                    RotationAngle == input.RotationAngle ||
                    RotationAngle.Equals(input.RotationAngle)
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
                hashCode = hashCode * 59 + RotationAngle.GetHashCode();
                return hashCode;
            }
        }
    }

}
