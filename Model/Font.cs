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
    /// Represents a font.
    /// </summary>
    [DataContract]
    public partial class Font :  IEquatable<Font>, IValidatableObject
    {
        /// <summary>
        /// Specifies the style of the font.
        /// </summary>
        /// <value>Specifies the style of the font.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FontStyleEnum
        {
            /// <summary>
            /// Enum Regular for value: Regular
            /// </summary>
            [EnumMember(Value = "Regular")]
            Regular = 1,

            /// <summary>
            /// Enum Bold for value: Bold
            /// </summary>
            [EnumMember(Value = "Bold")]
            Bold = 2,

            /// <summary>
            /// Enum Italic for value: Italic
            /// </summary>
            [EnumMember(Value = "Italic")]
            Italic = 3,

            /// <summary>
            /// Enum BoldItalic for value: BoldItalic
            /// </summary>
            [EnumMember(Value = "BoldItalic")]
            BoldItalic = 4

        }

        /// <summary>
        /// Specifies the style of the font.
        /// </summary>
        /// <value>Specifies the style of the font.</value>
        [DataMember(Name="FontStyle", EmitDefaultValue=false)]
        public FontStyleEnum? FontStyle { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Font" /> class.
        /// </summary>
        /// <param name="fontStyle">Specifies the style of the font..</param>
        /// <param name="familyName">Specifies the family name of the font, i.e: \&quot;Arial\&quot;..</param>
        public Font(FontStyleEnum? fontStyle = default(FontStyleEnum?), string familyName = default(string))
        {
            this.FontStyle = fontStyle;
            this.FamilyName = familyName;
        }
        

        /// <summary>
        /// Specifies the family name of the font, i.e: \&quot;Arial\&quot;.
        /// </summary>
        /// <value>Specifies the family name of the font, i.e: \&quot;Arial\&quot;.</value>
        [DataMember(Name="FamilyName", EmitDefaultValue=false)]
        public string FamilyName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Font {\n");
            sb.Append("  FontStyle: ").Append(FontStyle).Append("\n");
            sb.Append("  FamilyName: ").Append(FamilyName).Append("\n");
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
            return this.Equals(input as Font);
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
                    this.FontStyle == input.FontStyle ||
                    (this.FontStyle != null &&
                    this.FontStyle.Equals(input.FontStyle))
                ) && 
                (
                    this.FamilyName == input.FamilyName ||
                    (this.FamilyName != null &&
                    this.FamilyName.Equals(input.FamilyName))
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
                if (this.FontStyle != null)
                    hashCode = hashCode * 59 + this.FontStyle.GetHashCode();
                if (this.FamilyName != null)
                    hashCode = hashCode * 59 + this.FamilyName.GetHashCode();
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
