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
        /// <param name="FileId">FileId (required).</param>
        /// <param name="PageRange">PageRange (default to &quot;*&quot;).</param>
        /// <param name="Quality">Quality (default to 75).</param>
        /// <param name="Progressive">Progressive.</param>
        public ImageSaveAsJPEGParameters(string FileId = default(string), string PageRange = "*", int? Quality = 75, bool? Progressive = default(bool?))
        {
            // to ensure "FileId" is required (not null)
            if (FileId == null)
            {
                throw new InvalidDataException("FileId is a required property for ImageSaveAsJPEGParameters and cannot be null");
            }
            else
            {
                this.FileId = FileId;
            }
            // use default value if no "PageRange" provided
            if (PageRange == null)
            {
                this.PageRange = "*";
            }
            else
            {
                this.PageRange = PageRange;
            }
            // use default value if no "Quality" provided
            if (Quality == null)
            {
                this.Quality = 75;
            }
            else
            {
                this.Quality = Quality;
            }
            this.Progressive = Progressive;
        }
        
        /// <summary>
        /// Gets or Sets FileId
        /// </summary>
        [DataMember(Name="fileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Gets or Sets PageRange
        /// </summary>
        [DataMember(Name="pageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }

        /// <summary>
        /// Gets or Sets Quality
        /// </summary>
        [DataMember(Name="quality", EmitDefaultValue=false)]
        public int? Quality { get; set; }

        /// <summary>
        /// Gets or Sets Progressive
        /// </summary>
        [DataMember(Name="progressive", EmitDefaultValue=false)]
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
