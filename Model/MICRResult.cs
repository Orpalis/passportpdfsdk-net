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
    /// Represents the result of a MICR operation run on a document given page.
    /// </summary>
    [DataContract]
    public partial class MICRResult :  IEquatable<MICRResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MICRResult" /> class.
        /// </summary>
        /// <param name="pageNumber">Specifies the number of the page on which the symbols have been detected..</param>
        /// <param name="data">The detected data..</param>
        /// <param name="detectedSymbols">Holds detailed information about every single symbol which has been detected..</param>
        public MICRResult(int? pageNumber = default(int?), string data = default(string), List<MICRSymbolInfo> detectedSymbols = default(List<MICRSymbolInfo>))
        {
            this.PageNumber = pageNumber;
            this.Data = data;
            this.DetectedSymbols = detectedSymbols;
        }
        
        /// <summary>
        /// Specifies the number of the page on which the symbols have been detected.
        /// </summary>
        /// <value>Specifies the number of the page on which the symbols have been detected.</value>
        [DataMember(Name="PageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The detected data.
        /// </summary>
        /// <value>The detected data.</value>
        [DataMember(Name="Data", EmitDefaultValue=false)]
        public string Data { get; set; }

        /// <summary>
        /// Holds detailed information about every single symbol which has been detected.
        /// </summary>
        /// <value>Holds detailed information about every single symbol which has been detected.</value>
        [DataMember(Name="DetectedSymbols", EmitDefaultValue=false)]
        public List<MICRSymbolInfo> DetectedSymbols { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MICRResult {\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  DetectedSymbols: ").Append(DetectedSymbols).Append("\n");
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
            return this.Equals(input as MICRResult);
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
                    this.PageNumber == input.PageNumber ||
                    (this.PageNumber != null &&
                    this.PageNumber.Equals(input.PageNumber))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.DetectedSymbols == input.DetectedSymbols ||
                    this.DetectedSymbols != null &&
                    this.DetectedSymbols.SequenceEqual(input.DetectedSymbols)
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
                if (this.PageNumber != null)
                    hashCode = hashCode * 59 + this.PageNumber.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.DetectedSymbols != null)
                    hashCode = hashCode * 59 + this.DetectedSymbols.GetHashCode();
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
