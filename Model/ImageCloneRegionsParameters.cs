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
    /// Represents the parameters for a clone image region action.
    /// </summary>
    [DataContract]
    public partial class ImageCloneRegionsParameters :  IEquatable<ImageCloneRegionsParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageCloneRegionsParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageCloneRegionsParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageCloneRegionsParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="imageRegions">The regions to be cloned. (required).</param>
        public ImageCloneRegionsParameters(string fileId = default(string), List<ImageRegion> imageRegions = default(List<ImageRegion>))
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for ImageCloneRegionsParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            
            // to ensure "imageRegions" is required (not null)
            if (imageRegions == null)
            {
                throw new InvalidDataException("imageRegions is a required property for ImageCloneRegionsParameters and cannot be null");
            }
            else
            {
                this.ImageRegions = imageRegions;
            }
            
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// The regions to be cloned.
        /// </summary>
        /// <value>The regions to be cloned.</value>
        [DataMember(Name="ImageRegions", EmitDefaultValue=false)]
        public List<ImageRegion> ImageRegions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageCloneRegionsParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  ImageRegions: ").Append(ImageRegions).Append("\n");
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
            return this.Equals(input as ImageCloneRegionsParameters);
        }

        /// <summary>
        /// Returns true if ImageCloneRegionsParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageCloneRegionsParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageCloneRegionsParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileId == input.FileId ||
                    (this.FileId != null &&
                    this.FileId.Equals(input.FileId))
                ) && 
                (
                    this.ImageRegions == input.ImageRegions ||
                    this.ImageRegions != null &&
                    this.ImageRegions.SequenceEqual(input.ImageRegions)
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
                if (this.FileId != null)
                    hashCode = hashCode * 59 + this.FileId.GetHashCode();
                if (this.ImageRegions != null)
                    hashCode = hashCode * 59 + this.ImageRegions.GetHashCode();
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
