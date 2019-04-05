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
    /// Represents a cloned image region.
    /// </summary>
    [DataContract]
    public partial class ClonedImageRegion :  IEquatable<ClonedImageRegion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClonedImageRegion" /> class.
        /// </summary>
        /// <param name="imageRegion">imageRegion.</param>
        /// <param name="fileId">The file identifier of the image..</param>
        public ClonedImageRegion(ImageRegion imageRegion = default(ImageRegion), string fileId = default(string))
        {
            this.ImageRegion = imageRegion;
            this.FileId = fileId;
        }
        
        /// <summary>
        /// Gets or Sets ImageRegion
        /// </summary>
        [DataMember(Name="ImageRegion", EmitDefaultValue=false)]
        public ImageRegion ImageRegion { get; set; }

        /// <summary>
        /// The file identifier of the image.
        /// </summary>
        /// <value>The file identifier of the image.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClonedImageRegion {\n");
            sb.Append("  ImageRegion: ").Append(ImageRegion).Append("\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
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
            return this.Equals(input as ClonedImageRegion);
        }

        /// <summary>
        /// Returns true if ClonedImageRegion instances are equal
        /// </summary>
        /// <param name="input">Instance of ClonedImageRegion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClonedImageRegion input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImageRegion == input.ImageRegion ||
                    (this.ImageRegion != null &&
                    this.ImageRegion.Equals(input.ImageRegion))
                ) && 
                (
                    this.FileId == input.FileId ||
                    (this.FileId != null &&
                    this.FileId.Equals(input.FileId))
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
                if (this.ImageRegion != null)
                    hashCode = hashCode * 59 + this.ImageRegion.GetHashCode();
                if (this.FileId != null)
                    hashCode = hashCode * 59 + this.FileId.GetHashCode();
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
