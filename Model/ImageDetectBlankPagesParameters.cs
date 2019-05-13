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
    /// Represents the parameters for a detect blank pages action.
    /// </summary>
    [DataContract]
    public partial class ImageDetectBlankPagesParameters :  IEquatable<ImageDetectBlankPagesParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageDetectBlankPagesParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageDetectBlankPagesParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageDetectBlankPagesParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of page to be processed. (required).</param>
        /// <param name="removeDetectedBlankPages">Specifies whether the detected blank page(s) shall be removed. (default to true).</param>
        public ImageDetectBlankPagesParameters(string fileId = default(string), string pageRange = default(string), bool? removeDetectedBlankPages = true)
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for ImageDetectBlankPagesParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            
            // to ensure "pageRange" is required (not null)
            if (pageRange == null)
            {
                throw new InvalidDataException("pageRange is a required property for ImageDetectBlankPagesParameters and cannot be null");
            }
            else
            {
                this.PageRange = pageRange;
            }
            
            // use default value if no "removeDetectedBlankPages" provided
            if (removeDetectedBlankPages == null)
            {
                this.RemoveDetectedBlankPages = true;
            }
            else
            {
                this.RemoveDetectedBlankPages = removeDetectedBlankPages;
            }
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of page to be processed.
        /// </summary>
        /// <value>Specifies the number of the page, or the range of page to be processed.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies whether the detected blank page(s) shall be removed.
        /// </summary>
        /// <value>Specifies whether the detected blank page(s) shall be removed.</value>
        [DataMember(Name="RemoveDetectedBlankPages", EmitDefaultValue=false)]
        public bool? RemoveDetectedBlankPages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageDetectBlankPagesParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  RemoveDetectedBlankPages: ").Append(RemoveDetectedBlankPages).Append("\n");
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
            return this.Equals(input as ImageDetectBlankPagesParameters);
        }

        /// <summary>
        /// Returns true if ImageDetectBlankPagesParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageDetectBlankPagesParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageDetectBlankPagesParameters input)
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
                    this.PageRange == input.PageRange ||
                    (this.PageRange != null &&
                    this.PageRange.Equals(input.PageRange))
                ) && 
                (
                    this.RemoveDetectedBlankPages == input.RemoveDetectedBlankPages ||
                    (this.RemoveDetectedBlankPages != null &&
                    this.RemoveDetectedBlankPages.Equals(input.RemoveDetectedBlankPages))
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
                if (this.PageRange != null)
                    hashCode = hashCode * 59 + this.PageRange.GetHashCode();
                if (this.RemoveDetectedBlankPages != null)
                    hashCode = hashCode * 59 + this.RemoveDetectedBlankPages.GetHashCode();
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
