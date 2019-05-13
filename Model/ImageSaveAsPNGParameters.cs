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
    /// Represents the parameters for a save as PNG action.
    /// </summary>
    [DataContract]
    public partial class ImageSaveAsPNGParameters :  IEquatable<ImageSaveAsPNGParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSaveAsPNGParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageSaveAsPNGParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSaveAsPNGParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages to be saved as PNG. (required).</param>
        /// <param name="compression">Specifies the level of compression to be used for the PNG output, between 0 (no compression - faster encoding) to 9(max compression - slower encoding). (default to 6).</param>
        /// <param name="interlaced">Specifies if the produced PNG image must be interlaced..</param>
        public ImageSaveAsPNGParameters(string fileId = default(string), string pageRange = default(string), int? compression = 6, bool? interlaced = default(bool?))
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for ImageSaveAsPNGParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            
            // to ensure "pageRange" is required (not null)
            if (pageRange == null)
            {
                throw new InvalidDataException("pageRange is a required property for ImageSaveAsPNGParameters and cannot be null");
            }
            else
            {
                this.PageRange = pageRange;
            }
            
            // use default value if no "compression" provided
            if (compression == null)
            {
                this.Compression = 6;
            }
            else
            {
                this.Compression = compression;
            }
            this.Interlaced = interlaced;
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to be saved as PNG.
        /// </summary>
        /// <value>Specifies the number of the page, or the range of pages to be saved as PNG.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies the level of compression to be used for the PNG output, between 0 (no compression - faster encoding) to 9(max compression - slower encoding).
        /// </summary>
        /// <value>Specifies the level of compression to be used for the PNG output, between 0 (no compression - faster encoding) to 9(max compression - slower encoding).</value>
        [DataMember(Name="Compression", EmitDefaultValue=false)]
        public int? Compression { get; set; }

        /// <summary>
        /// Specifies if the produced PNG image must be interlaced.
        /// </summary>
        /// <value>Specifies if the produced PNG image must be interlaced.</value>
        [DataMember(Name="Interlaced", EmitDefaultValue=false)]
        public bool? Interlaced { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageSaveAsPNGParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  Compression: ").Append(Compression).Append("\n");
            sb.Append("  Interlaced: ").Append(Interlaced).Append("\n");
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
            return this.Equals(input as ImageSaveAsPNGParameters);
        }

        /// <summary>
        /// Returns true if ImageSaveAsPNGParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageSaveAsPNGParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageSaveAsPNGParameters input)
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
                    this.Compression == input.Compression ||
                    (this.Compression != null &&
                    this.Compression.Equals(input.Compression))
                ) && 
                (
                    this.Interlaced == input.Interlaced ||
                    (this.Interlaced != null &&
                    this.Interlaced.Equals(input.Interlaced))
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
                if (this.Compression != null)
                    hashCode = hashCode * 59 + this.Compression.GetHashCode();
                if (this.Interlaced != null)
                    hashCode = hashCode * 59 + this.Interlaced.GetHashCode();
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
