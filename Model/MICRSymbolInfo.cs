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
    /// Holds detailed information about a magnetic ink symbol detected by a MICR process.
    /// </summary>
    [DataContract]
    public partial class MICRSymbolInfo :  IEquatable<MICRSymbolInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MICRSymbolInfo" /> class.
        /// </summary>
        public MICRSymbolInfo()
        {
        }

        /// <summary>
        /// Specifies the best candidate for the character representation of the detected symbol.
        /// </summary>
        [DataMember(Name="SymbolValue")]
        public string SymbolValue { get; set; }

        /// <summary>
        /// Specifies the second best candidate for the character representation of the detected symbol.
        /// </summary>
        [DataMember(Name="SymbolValue2")]
        public string SymbolValue2 { get; set; }

        /// <summary>
        /// Specifies the top coordinate of the symbol, in pixels.
        /// </summary>
        [DataMember(Name="Top")]
        public int Top { get; set; }

        /// <summary>
        /// Specifies the left coordinate of the symbol, in pixels.
        /// </summary>
        [DataMember(Name="Left")]
        public int Left { get; set; }

        /// <summary>
        /// Specifies the bottom coordinate of the symbol, in pixels.
        /// </summary>
        [DataMember(Name="Bottom")]
        public int Bottom { get; set; }

        /// <summary>
        /// Specifies the right coordinate of the symbol, in pixels.
        /// </summary>
        [DataMember(Name="Right")]
        public int Right { get; set; }

        /// <summary>
        /// Specifies the number of the line on which the symbol has been detected.
        /// </summary>
        [DataMember(Name="Line")]
        public int Line { get; set; }

        /// <summary>
        /// Specifies the level of confidence of the best detected symbol candidate.
        /// </summary>
        [DataMember(Name="Confidence")]
        public float Confidence { get; set; }

        /// <summary>
        /// Specifies the level of confidence of the second best detected symbol candidate.
        /// </summary>
        [DataMember(Name="Confidence2")]
        public float Confidence2 { get; set; }

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
            return Equals(input as MICRSymbolInfo);
        }

        /// <summary>
        /// Returns true if MICRSymbolInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of MICRSymbolInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MICRSymbolInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    SymbolValue == input.SymbolValue ||
                    (SymbolValue != null &&
                    SymbolValue.Equals(input.SymbolValue))
                ) && 
                (
                    SymbolValue2 == input.SymbolValue2 ||
                    (SymbolValue2 != null &&
                    SymbolValue2.Equals(input.SymbolValue2))
                ) && 
                (
                    Top == input.Top ||
                    Top.Equals(input.Top)
                ) && 
                (
                    Left == input.Left ||
                    Left.Equals(input.Left)
                ) && 
                (
                    Bottom == input.Bottom ||
                    Bottom.Equals(input.Bottom)
                ) && 
                (
                    Right == input.Right ||
                    Right.Equals(input.Right)
                ) && 
                (
                    Line == input.Line ||
                    Line.Equals(input.Line)
                ) && 
                (
                    Confidence == input.Confidence ||
                    Confidence.Equals(input.Confidence)
                ) && 
                (
                    Confidence2 == input.Confidence2 ||
                    Confidence2.Equals(input.Confidence2)
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
                if (SymbolValue != null)
                    hashCode = hashCode * 59 + SymbolValue.GetHashCode();
                if (SymbolValue2 != null)
                    hashCode = hashCode * 59 + SymbolValue2.GetHashCode();
                hashCode = hashCode * 59 + Top.GetHashCode();
                hashCode = hashCode * 59 + Left.GetHashCode();
                hashCode = hashCode * 59 + Bottom.GetHashCode();
                hashCode = hashCode * 59 + Right.GetHashCode();
                hashCode = hashCode * 59 + Line.GetHashCode();
                hashCode = hashCode * 59 + Confidence.GetHashCode();
                hashCode = hashCode * 59 + Confidence2.GetHashCode();
                return hashCode;
            }
        }
    }

}
