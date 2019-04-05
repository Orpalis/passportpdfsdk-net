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
    /// Represents the result to a color detection operation performed on a given page of an image.
    /// </summary>
    [DataContract]
    public partial class ColorDetectionResult :  IEquatable<ColorDetectionResult>, IValidatableObject
    {
        /// <summary>
        /// Specifies the output intent of the analyzed page.
        /// </summary>
        /// <value>Specifies the output intent of the analyzed page.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OutputIntentEnum
        {
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,

            /// <summary>
            /// Enum BlackWhite for value: BlackWhite
            /// </summary>
            [EnumMember(Value = "BlackWhite")]
            BlackWhite = 2,

            /// <summary>
            /// Enum Grayscale for value: Grayscale
            /// </summary>
            [EnumMember(Value = "Grayscale")]
            Grayscale = 3,

            /// <summary>
            /// Enum Palletized for value: Palletized
            /// </summary>
            [EnumMember(Value = "Palletized")]
            Palletized = 4,

            /// <summary>
            /// Enum Color for value: Color
            /// </summary>
            [EnumMember(Value = "Color")]
            Color = 5,

            /// <summary>
            /// Enum White for value: White
            /// </summary>
            [EnumMember(Value = "White")]
            White = 6

        }

        /// <summary>
        /// Specifies the output intent of the analyzed page.
        /// </summary>
        /// <value>Specifies the output intent of the analyzed page.</value>
        [DataMember(Name="OutputIntent", EmitDefaultValue=false)]
        public OutputIntentEnum? OutputIntent { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ColorDetectionResult" /> class.
        /// </summary>
        /// <param name="pageNumber">Specifies the number of the analyzed page..</param>
        /// <param name="outputIntent">Specifies the output intent of the analyzed page..</param>
        public ColorDetectionResult(int? pageNumber = default(int?), OutputIntentEnum? outputIntent = default(OutputIntentEnum?))
        {
            this.PageNumber = pageNumber;
            this.OutputIntent = outputIntent;
        }
        
        /// <summary>
        /// Specifies the number of the analyzed page.
        /// </summary>
        /// <value>Specifies the number of the analyzed page.</value>
        [DataMember(Name="PageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ColorDetectionResult {\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  OutputIntent: ").Append(OutputIntent).Append("\n");
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
            return this.Equals(input as ColorDetectionResult);
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
                    this.PageNumber == input.PageNumber ||
                    (this.PageNumber != null &&
                    this.PageNumber.Equals(input.PageNumber))
                ) && 
                (
                    this.OutputIntent == input.OutputIntent ||
                    (this.OutputIntent != null &&
                    this.OutputIntent.Equals(input.OutputIntent))
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
                if (this.OutputIntent != null)
                    hashCode = hashCode * 59 + this.OutputIntent.GetHashCode();
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
