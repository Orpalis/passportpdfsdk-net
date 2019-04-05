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
    /// Represents a region of a given page of an image.
    /// </summary>
    [DataContract]
    public partial class ImageRegion :  IEquatable<ImageRegion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageRegion" /> class.
        /// </summary>
        /// <param name="pageNumber">Specifies the number of the page..</param>
        /// <param name="left">Specifies, in pixels, the left coordinate of the region..</param>
        /// <param name="top">Specifies, in pixels, the top coordinate of the region..</param>
        /// <param name="width">Specifies, in pixels, the width of the region..</param>
        /// <param name="height">Specifies, in pixels, the height of the region..</param>
        public ImageRegion(int? pageNumber = default(int?), int? left = default(int?), int? top = default(int?), int? width = default(int?), int? height = default(int?))
        {
            this.PageNumber = pageNumber;
            this.Left = left;
            this.Top = top;
            this.Width = width;
            this.Height = height;
        }
        
        /// <summary>
        /// Specifies the number of the page.
        /// </summary>
        /// <value>Specifies the number of the page.</value>
        [DataMember(Name="PageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// Specifies, in pixels, the left coordinate of the region.
        /// </summary>
        /// <value>Specifies, in pixels, the left coordinate of the region.</value>
        [DataMember(Name="Left", EmitDefaultValue=false)]
        public int? Left { get; set; }

        /// <summary>
        /// Specifies, in pixels, the top coordinate of the region.
        /// </summary>
        /// <value>Specifies, in pixels, the top coordinate of the region.</value>
        [DataMember(Name="Top", EmitDefaultValue=false)]
        public int? Top { get; set; }

        /// <summary>
        /// Specifies, in pixels, the width of the region.
        /// </summary>
        /// <value>Specifies, in pixels, the width of the region.</value>
        [DataMember(Name="Width", EmitDefaultValue=false)]
        public int? Width { get; set; }

        /// <summary>
        /// Specifies, in pixels, the height of the region.
        /// </summary>
        /// <value>Specifies, in pixels, the height of the region.</value>
        [DataMember(Name="Height", EmitDefaultValue=false)]
        public int? Height { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageRegion {\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  Left: ").Append(Left).Append("\n");
            sb.Append("  Top: ").Append(Top).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
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
            return this.Equals(input as ImageRegion);
        }

        /// <summary>
        /// Returns true if ImageRegion instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageRegion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageRegion input)
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
                    this.Left == input.Left ||
                    (this.Left != null &&
                    this.Left.Equals(input.Left))
                ) && 
                (
                    this.Top == input.Top ||
                    (this.Top != null &&
                    this.Top.Equals(input.Top))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
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
                if (this.Left != null)
                    hashCode = hashCode * 59 + this.Left.GetHashCode();
                if (this.Top != null)
                    hashCode = hashCode * 59 + this.Top.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
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
