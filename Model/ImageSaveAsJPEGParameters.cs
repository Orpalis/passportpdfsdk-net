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
    /// Represents the parameters for a save as JPEG action.
    /// </summary>
    [DataContract]
    public partial class ImageSaveAsJPEGParameters :  IEquatable<ImageSaveAsJPEGParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSaveAsJPEGParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageSaveAsJPEGParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSaveAsJPEGParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages to be saved as JPEG. (required).</param>
        /// <param name="quality">Specifies the level of quality to be used for the JPEG compression, from 1 (poorest) to 100 (greatest). (default to 75).</param>
        /// <param name="progressive">Specifies if the encoded JPEG image must be progressive..</param>
        public ImageSaveAsJPEGParameters(string fileId = default(string), string pageRange = default(string), int? quality = 75, bool? progressive = default(bool?))
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for ImageSaveAsJPEGParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            // to ensure "pageRange" is required (not null)
            if (pageRange == null)
            {
                throw new InvalidDataException("pageRange is a required property for ImageSaveAsJPEGParameters and cannot be null");
            }
            else
            {
                this.PageRange = pageRange;
            }
            // use default value if no "quality" provided
            if (quality == null)
            {
                this.Quality = 75;
            }
            else
            {
                this.Quality = quality;
            }
            this.Progressive = progressive;
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to be saved as JPEG.
        /// </summary>
        /// <value>Specifies the number of the page, or the range of pages to be saved as JPEG.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies the level of quality to be used for the JPEG compression, from 1 (poorest) to 100 (greatest).
        /// </summary>
        /// <value>Specifies the level of quality to be used for the JPEG compression, from 1 (poorest) to 100 (greatest).</value>
        [DataMember(Name="Quality", EmitDefaultValue=false)]
        public int? Quality { get; set; }

        /// <summary>
        /// Specifies if the encoded JPEG image must be progressive.
        /// </summary>
        /// <value>Specifies if the encoded JPEG image must be progressive.</value>
        [DataMember(Name="Progressive", EmitDefaultValue=false)]
        public bool? Progressive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageSaveAsJPEGParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  Quality: ").Append(Quality).Append("\n");
            sb.Append("  Progressive: ").Append(Progressive).Append("\n");
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
            return this.Equals(input as ImageSaveAsJPEGParameters);
        }

        /// <summary>
        /// Returns true if ImageSaveAsJPEGParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageSaveAsJPEGParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageSaveAsJPEGParameters input)
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
                    this.Quality == input.Quality ||
                    (this.Quality != null &&
                    this.Quality.Equals(input.Quality))
                ) && 
                (
                    this.Progressive == input.Progressive ||
                    (this.Progressive != null &&
                    this.Progressive.Equals(input.Progressive))
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
                if (this.Quality != null)
                    hashCode = hashCode * 59 + this.Quality.GetHashCode();
                if (this.Progressive != null)
                    hashCode = hashCode * 59 + this.Progressive.GetHashCode();
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
