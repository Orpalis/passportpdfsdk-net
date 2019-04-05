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
    /// Represents the parameters for an image color detection action.
    /// </summary>
    [DataContract]
    public partial class ImageDetectColorParameters :  IEquatable<ImageDetectColorParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageDetectColorParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageDetectColorParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageDetectColorParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages to perform color detection on. (required).</param>
        /// <param name="autoConvert">Specifies whether to automatically convert the image in its best suited/optimized bits-per-pixel encoding..</param>
        /// <param name="autoRepairCharacters">Specifies whether the characters shall be repaired during bitonal conversion, if any, or not..</param>
        public ImageDetectColorParameters(string fileId = default(string), string pageRange = default(string), bool? autoConvert = default(bool?), bool? autoRepairCharacters = default(bool?))
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for ImageDetectColorParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            // to ensure "pageRange" is required (not null)
            if (pageRange == null)
            {
                throw new InvalidDataException("pageRange is a required property for ImageDetectColorParameters and cannot be null");
            }
            else
            {
                this.PageRange = pageRange;
            }
            this.AutoConvert = autoConvert;
            this.AutoRepairCharacters = autoRepairCharacters;
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to perform color detection on.
        /// </summary>
        /// <value>Specifies the number of the page, or the range of pages to perform color detection on.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies whether to automatically convert the image in its best suited/optimized bits-per-pixel encoding.
        /// </summary>
        /// <value>Specifies whether to automatically convert the image in its best suited/optimized bits-per-pixel encoding.</value>
        [DataMember(Name="AutoConvert", EmitDefaultValue=false)]
        public bool? AutoConvert { get; set; }

        /// <summary>
        /// Specifies whether the characters shall be repaired during bitonal conversion, if any, or not.
        /// </summary>
        /// <value>Specifies whether the characters shall be repaired during bitonal conversion, if any, or not.</value>
        [DataMember(Name="AutoRepairCharacters", EmitDefaultValue=false)]
        public bool? AutoRepairCharacters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageDetectColorParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  AutoConvert: ").Append(AutoConvert).Append("\n");
            sb.Append("  AutoRepairCharacters: ").Append(AutoRepairCharacters).Append("\n");
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
            return this.Equals(input as ImageDetectColorParameters);
        }

        /// <summary>
        /// Returns true if ImageDetectColorParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageDetectColorParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageDetectColorParameters input)
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
                    this.AutoConvert == input.AutoConvert ||
                    (this.AutoConvert != null &&
                    this.AutoConvert.Equals(input.AutoConvert))
                ) && 
                (
                    this.AutoRepairCharacters == input.AutoRepairCharacters ||
                    (this.AutoRepairCharacters != null &&
                    this.AutoRepairCharacters.Equals(input.AutoRepairCharacters))
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
                if (this.AutoConvert != null)
                    hashCode = hashCode * 59 + this.AutoConvert.GetHashCode();
                if (this.AutoRepairCharacters != null)
                    hashCode = hashCode * 59 + this.AutoRepairCharacters.GetHashCode();
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
