/* 
 * PassportPDF
 *
 * Copyright © 2018 ORPALIS - http://www.orpalis.com
 *
 * OpenAPI spec version: v1
 * Contact: contact@orpalis.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = PassportPDF.Client.SwaggerDateConverter;

namespace PassportPDF.Model
{
    /// <summary>
    /// Represents the response to a save as PNG action request.
    /// </summary>
    [DataContract]
    public partial class ImageSaveAsPNGResponse :  IEquatable<ImageSaveAsPNGResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSaveAsPNGResponse" /> class.
        /// </summary>
        /// <param name="Error">If not null, provides information about an unsuccessful action..</param>
        /// <param name="RemainingTokens">Specifies the number of remaining tokens..</param>
        /// <param name="PageImages">The image(s) saved as PNG..</param>
        public ImageSaveAsPNGResponse(Error Error = default(Error), long? RemainingTokens = default(long?), List<PageImage> PageImages = default(List<PageImage>))
        {
            this.Error = Error;
            this.RemainingTokens = RemainingTokens;
            this.PageImages = PageImages;
        }
        
        /// <summary>
        /// If not null, provides information about an unsuccessful action.
        /// </summary>
        /// <value>If not null, provides information about an unsuccessful action.</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public Error Error { get; set; }

        /// <summary>
        /// Specifies the number of remaining tokens.
        /// </summary>
        /// <value>Specifies the number of remaining tokens.</value>
        [DataMember(Name="remainingTokens", EmitDefaultValue=false)]
        public long? RemainingTokens { get; set; }

        /// <summary>
        /// The image(s) saved as PNG.
        /// </summary>
        /// <value>The image(s) saved as PNG.</value>
        [DataMember(Name="pageImages", EmitDefaultValue=false)]
        public List<PageImage> PageImages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageSaveAsPNGResponse {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  RemainingTokens: ").Append(RemainingTokens).Append("\n");
            sb.Append("  PageImages: ").Append(PageImages).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as ImageSaveAsPNGResponse);
        }

        /// <summary>
        /// Returns true if ImageSaveAsPNGResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageSaveAsPNGResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageSaveAsPNGResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.RemainingTokens == input.RemainingTokens ||
                    (this.RemainingTokens != null &&
                    this.RemainingTokens.Equals(input.RemainingTokens))
                ) && 
                (
                    this.PageImages == input.PageImages ||
                    this.PageImages != null &&
                    this.PageImages.SequenceEqual(input.PageImages)
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
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.RemainingTokens != null)
                    hashCode = hashCode * 59 + this.RemainingTokens.GetHashCode();
                if (this.PageImages != null)
                    hashCode = hashCode * 59 + this.PageImages.GetHashCode();
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
