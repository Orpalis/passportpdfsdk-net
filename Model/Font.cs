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
    /// Represents a font.
    /// </summary>
    [DataContract]
    public partial class Font :  IEquatable<Font>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Font" /> class.
        /// </summary>
        public Font()
        {
        }

        /// <summary>
        /// Gets or Sets FontStyle
        /// </summary>
        [DataMember(Name="FontStyle")]
        public FontStyle FontStyle { get; set; }

        /// <summary>
        /// Specifies the family name of the font, i.e: \"Arial\".
        /// </summary>
        [DataMember(Name="FamilyName")]
        public string FamilyName { get; set; }

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
            return Equals(input as Font);
        }

        /// <summary>
        /// Returns true if Font instances are equal
        /// </summary>
        /// <param name="input">Instance of Font to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Font input)
        {
            if (input == null)
                return false;

            return 
                (
                    FontStyle == input.FontStyle ||
                    FontStyle.Equals(input.FontStyle)
                ) && 
                (
                    FamilyName == input.FamilyName ||
                    (FamilyName != null &&
                    FamilyName.Equals(input.FamilyName))
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
                hashCode = hashCode * 59 + FontStyle.GetHashCode();
                if (FamilyName != null)
                    hashCode = hashCode * 59 + FamilyName.GetHashCode();
                return hashCode;
            }
        }
    }

}
