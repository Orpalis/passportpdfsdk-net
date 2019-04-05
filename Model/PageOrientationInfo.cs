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
    /// Represents information about the orientation of a given page.
    /// </summary>
    [DataContract]
    public partial class PageOrientationInfo :  IEquatable<PageOrientationInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageOrientationInfo" /> class.
        /// </summary>
        /// <param name="pageNumber">Specifies the number of the page..</param>
        /// <param name="rotationAngle">Specifies, clockwise in degrees, the rotation angle of the page..</param>
        public PageOrientationInfo(int? pageNumber = default(int?), int? rotationAngle = default(int?))
        {
            this.PageNumber = pageNumber;
            this.RotationAngle = rotationAngle;
        }
        
        /// <summary>
        /// Specifies the number of the page.
        /// </summary>
        /// <value>Specifies the number of the page.</value>
        [DataMember(Name="PageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// Specifies, clockwise in degrees, the rotation angle of the page.
        /// </summary>
        /// <value>Specifies, clockwise in degrees, the rotation angle of the page.</value>
        [DataMember(Name="RotationAngle", EmitDefaultValue=false)]
        public int? RotationAngle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageOrientationInfo {\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  RotationAngle: ").Append(RotationAngle).Append("\n");
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
            return this.Equals(input as PageOrientationInfo);
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
                    this.PageNumber == input.PageNumber ||
                    (this.PageNumber != null &&
                    this.PageNumber.Equals(input.PageNumber))
                ) && 
                (
                    this.RotationAngle == input.RotationAngle ||
                    (this.RotationAngle != null &&
                    this.RotationAngle.Equals(input.RotationAngle))
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
                if (this.RotationAngle != null)
                    hashCode = hashCode * 59 + this.RotationAngle.GetHashCode();
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
