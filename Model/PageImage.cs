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
    /// Holds the data of an image from a given page of a document.
    /// </summary>
    [DataContract]
    public partial class PageImage :  IEquatable<PageImage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageImage" /> class.
        /// </summary>
        /// <param name="pageNumber">Specifies the number of the page..</param>
        /// <param name="imageData">The data of the image..</param>
        public PageImage(int? pageNumber = default(int?), byte[] imageData = default(byte[]))
        {
            this.PageNumber = pageNumber;
            this.ImageData = imageData;
        }
        
        /// <summary>
        /// Specifies the number of the page.
        /// </summary>
        /// <value>Specifies the number of the page.</value>
        [DataMember(Name="PageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The data of the image.
        /// </summary>
        /// <value>The data of the image.</value>
        [DataMember(Name="ImageData", EmitDefaultValue=false)]
        public byte[] ImageData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageImage {\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  ImageData: ").Append(ImageData).Append("\n");
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
            return this.Equals(input as PageImage);
        }

        /// <summary>
        /// Returns true if PageImage instances are equal
        /// </summary>
        /// <param name="input">Instance of PageImage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PageImage input)
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
                    this.ImageData == input.ImageData ||
                    (this.ImageData != null &&
                    this.ImageData.Equals(input.ImageData))
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
                if (this.ImageData != null)
                    hashCode = hashCode * 59 + this.ImageData.GetHashCode();
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
