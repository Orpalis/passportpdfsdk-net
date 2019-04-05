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
using OpenAPIDateConverter = PassportPDF.Client.OpenAPIDateConverter;

namespace PassportPDF.Model
{
    /// <summary>
    /// Holds detailed information about a magnetic ink symbol detected by a MICR process.
    /// </summary>
    [DataContract]
    public partial class MICRSymbolInfo :  IEquatable<MICRSymbolInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MICRSymbolInfo" /> class.
        /// </summary>
        /// <param name="symbolValue">Specifies the best candidate for the character representation of the detected symbol..</param>
        /// <param name="symbolValue2">Specifies the second best candidate for the character representation of the detected symbol..</param>
        /// <param name="top">Specifies the top coordinate of the symbol, in pixels..</param>
        /// <param name="left">Specifies the left coordinate of the symbol, in pixels..</param>
        /// <param name="bottom">Specifies the bottom coordinate of the symbol, in pixels..</param>
        /// <param name="right">Specifies the right coordinate of the symbol, in pixels..</param>
        /// <param name="line">Specifies the number of the line on which the symbol has been detected..</param>
        /// <param name="confidence">Specifies the level of confidence of the best detected symbol candidate..</param>
        /// <param name="confidence2">Specifies the level of confidence of the second best detected symbol candidate..</param>
        public MICRSymbolInfo(string symbolValue = default(string), string symbolValue2 = default(string), int? top = default(int?), int? left = default(int?), int? bottom = default(int?), int? right = default(int?), int? line = default(int?), float? confidence = default(float?), float? confidence2 = default(float?))
        {
            this.SymbolValue = symbolValue;
            this.SymbolValue2 = symbolValue2;
            this.Top = top;
            this.Left = left;
            this.Bottom = bottom;
            this.Right = right;
            this.Line = line;
            this.Confidence = confidence;
            this.Confidence2 = confidence2;
        }
        
        /// <summary>
        /// Specifies the best candidate for the character representation of the detected symbol.
        /// </summary>
        /// <value>Specifies the best candidate for the character representation of the detected symbol.</value>
        [DataMember(Name="SymbolValue", EmitDefaultValue=false)]
        public string SymbolValue { get; set; }

        /// <summary>
        /// Specifies the second best candidate for the character representation of the detected symbol.
        /// </summary>
        /// <value>Specifies the second best candidate for the character representation of the detected symbol.</value>
        [DataMember(Name="SymbolValue2", EmitDefaultValue=false)]
        public string SymbolValue2 { get; set; }

        /// <summary>
        /// Specifies the top coordinate of the symbol, in pixels.
        /// </summary>
        /// <value>Specifies the top coordinate of the symbol, in pixels.</value>
        [DataMember(Name="Top", EmitDefaultValue=false)]
        public int? Top { get; set; }

        /// <summary>
        /// Specifies the left coordinate of the symbol, in pixels.
        /// </summary>
        /// <value>Specifies the left coordinate of the symbol, in pixels.</value>
        [DataMember(Name="Left", EmitDefaultValue=false)]
        public int? Left { get; set; }

        /// <summary>
        /// Specifies the bottom coordinate of the symbol, in pixels.
        /// </summary>
        /// <value>Specifies the bottom coordinate of the symbol, in pixels.</value>
        [DataMember(Name="Bottom", EmitDefaultValue=false)]
        public int? Bottom { get; set; }

        /// <summary>
        /// Specifies the right coordinate of the symbol, in pixels.
        /// </summary>
        /// <value>Specifies the right coordinate of the symbol, in pixels.</value>
        [DataMember(Name="Right", EmitDefaultValue=false)]
        public int? Right { get; set; }

        /// <summary>
        /// Specifies the number of the line on which the symbol has been detected.
        /// </summary>
        /// <value>Specifies the number of the line on which the symbol has been detected.</value>
        [DataMember(Name="Line", EmitDefaultValue=false)]
        public int? Line { get; set; }

        /// <summary>
        /// Specifies the level of confidence of the best detected symbol candidate.
        /// </summary>
        /// <value>Specifies the level of confidence of the best detected symbol candidate.</value>
        [DataMember(Name="Confidence", EmitDefaultValue=false)]
        public float? Confidence { get; set; }

        /// <summary>
        /// Specifies the level of confidence of the second best detected symbol candidate.
        /// </summary>
        /// <value>Specifies the level of confidence of the second best detected symbol candidate.</value>
        [DataMember(Name="Confidence2", EmitDefaultValue=false)]
        public float? Confidence2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MICRSymbolInfo {\n");
            sb.Append("  SymbolValue: ").Append(SymbolValue).Append("\n");
            sb.Append("  SymbolValue2: ").Append(SymbolValue2).Append("\n");
            sb.Append("  Top: ").Append(Top).Append("\n");
            sb.Append("  Left: ").Append(Left).Append("\n");
            sb.Append("  Bottom: ").Append(Bottom).Append("\n");
            sb.Append("  Right: ").Append(Right).Append("\n");
            sb.Append("  Line: ").Append(Line).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("  Confidence2: ").Append(Confidence2).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(input as MICRSymbolInfo);
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
                    this.SymbolValue == input.SymbolValue ||
                    (this.SymbolValue != null &&
                    this.SymbolValue.Equals(input.SymbolValue))
                ) && 
                (
                    this.SymbolValue2 == input.SymbolValue2 ||
                    (this.SymbolValue2 != null &&
                    this.SymbolValue2.Equals(input.SymbolValue2))
                ) && 
                (
                    this.Top == input.Top ||
                    (this.Top != null &&
                    this.Top.Equals(input.Top))
                ) && 
                (
                    this.Left == input.Left ||
                    (this.Left != null &&
                    this.Left.Equals(input.Left))
                ) && 
                (
                    this.Bottom == input.Bottom ||
                    (this.Bottom != null &&
                    this.Bottom.Equals(input.Bottom))
                ) && 
                (
                    this.Right == input.Right ||
                    (this.Right != null &&
                    this.Right.Equals(input.Right))
                ) && 
                (
                    this.Line == input.Line ||
                    (this.Line != null &&
                    this.Line.Equals(input.Line))
                ) && 
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
                ) && 
                (
                    this.Confidence2 == input.Confidence2 ||
                    (this.Confidence2 != null &&
                    this.Confidence2.Equals(input.Confidence2))
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
                if (this.SymbolValue != null)
                    hashCode = hashCode * 59 + this.SymbolValue.GetHashCode();
                if (this.SymbolValue2 != null)
                    hashCode = hashCode * 59 + this.SymbolValue2.GetHashCode();
                if (this.Top != null)
                    hashCode = hashCode * 59 + this.Top.GetHashCode();
                if (this.Left != null)
                    hashCode = hashCode * 59 + this.Left.GetHashCode();
                if (this.Bottom != null)
                    hashCode = hashCode * 59 + this.Bottom.GetHashCode();
                if (this.Right != null)
                    hashCode = hashCode * 59 + this.Right.GetHashCode();
                if (this.Line != null)
                    hashCode = hashCode * 59 + this.Line.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.Confidence2 != null)
                    hashCode = hashCode * 59 + this.Confidence2.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
