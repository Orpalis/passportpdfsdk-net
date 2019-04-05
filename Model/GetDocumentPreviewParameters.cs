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
    /// Represents the parameters for a get document preview action.
    /// </summary>
    [DataContract]
    public partial class GetDocumentPreviewParameters :  IEquatable<GetDocumentPreviewParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentPreviewParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetDocumentPreviewParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentPreviewParameters" /> class.
        /// </summary>
        /// <param name="fileId">Specifies the identifier of the file to be previewed..</param>
        /// <param name="fileData">Specifies the data of the document to be previewed..</param>
        /// <param name="fileName">Specifies the name of the file to be previewed. (required).</param>
        /// <param name="thumbnailWidth">Specifies, in pixels, the width of the thumbnail to be retrieved. (default to 140).</param>
        /// <param name="thumbnailHeight">Specifies, in pixels, the height of the thumbnail to be retrieved. (default to 220).</param>
        /// <param name="thumbnailBackgroundColor">Specifies the background color of the thumbnail, using the color name (ie: \&quot;red\&quot;) or its RGBa code (ie: \&quot;rgba(255,0,0,1)\&quot;). (default to &quot;rgba(0,0,0,0)&quot;).</param>
        public GetDocumentPreviewParameters(string fileId = default(string), byte[] fileData = default(byte[]), string fileName = default(string), int? thumbnailWidth = 140, int? thumbnailHeight = 220, string thumbnailBackgroundColor = "rgba(0,0,0,0)")
        {
            // to ensure "fileName" is required (not null)
            if (fileName == null)
            {
                throw new InvalidDataException("fileName is a required property for GetDocumentPreviewParameters and cannot be null");
            }
            else
            {
                this.FileName = fileName;
            }
            this.FileId = fileId;
            this.FileData = fileData;
            // use default value if no "thumbnailWidth" provided
            if (thumbnailWidth == null)
            {
                this.ThumbnailWidth = 140;
            }
            else
            {
                this.ThumbnailWidth = thumbnailWidth;
            }
            // use default value if no "thumbnailHeight" provided
            if (thumbnailHeight == null)
            {
                this.ThumbnailHeight = 220;
            }
            else
            {
                this.ThumbnailHeight = thumbnailHeight;
            }
            // use default value if no "thumbnailBackgroundColor" provided
            if (thumbnailBackgroundColor == null)
            {
                this.ThumbnailBackgroundColor = "rgba(0,0,0,0)";
            }
            else
            {
                this.ThumbnailBackgroundColor = thumbnailBackgroundColor;
            }
        }
        
        /// <summary>
        /// Specifies the identifier of the file to be previewed.
        /// </summary>
        /// <value>Specifies the identifier of the file to be previewed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the data of the document to be previewed.
        /// </summary>
        /// <value>Specifies the data of the document to be previewed.</value>
        [DataMember(Name="FileData", EmitDefaultValue=false)]
        public byte[] FileData { get; set; }

        /// <summary>
        /// Specifies the name of the file to be previewed.
        /// </summary>
        /// <value>Specifies the name of the file to be previewed.</value>
        [DataMember(Name="FileName", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// Specifies, in pixels, the width of the thumbnail to be retrieved.
        /// </summary>
        /// <value>Specifies, in pixels, the width of the thumbnail to be retrieved.</value>
        [DataMember(Name="ThumbnailWidth", EmitDefaultValue=false)]
        public int? ThumbnailWidth { get; set; }

        /// <summary>
        /// Specifies, in pixels, the height of the thumbnail to be retrieved.
        /// </summary>
        /// <value>Specifies, in pixels, the height of the thumbnail to be retrieved.</value>
        [DataMember(Name="ThumbnailHeight", EmitDefaultValue=false)]
        public int? ThumbnailHeight { get; set; }

        /// <summary>
        /// Specifies the background color of the thumbnail, using the color name (ie: \&quot;red\&quot;) or its RGBa code (ie: \&quot;rgba(255,0,0,1)\&quot;).
        /// </summary>
        /// <value>Specifies the background color of the thumbnail, using the color name (ie: \&quot;red\&quot;) or its RGBa code (ie: \&quot;rgba(255,0,0,1)\&quot;).</value>
        [DataMember(Name="ThumbnailBackgroundColor", EmitDefaultValue=false)]
        public string ThumbnailBackgroundColor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDocumentPreviewParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  FileData: ").Append(FileData).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  ThumbnailWidth: ").Append(ThumbnailWidth).Append("\n");
            sb.Append("  ThumbnailHeight: ").Append(ThumbnailHeight).Append("\n");
            sb.Append("  ThumbnailBackgroundColor: ").Append(ThumbnailBackgroundColor).Append("\n");
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
            return this.Equals(input as GetDocumentPreviewParameters);
        }

        /// <summary>
        /// Returns true if GetDocumentPreviewParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDocumentPreviewParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDocumentPreviewParameters input)
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
                    this.FileData == input.FileData ||
                    (this.FileData != null &&
                    this.FileData.Equals(input.FileData))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.ThumbnailWidth == input.ThumbnailWidth ||
                    (this.ThumbnailWidth != null &&
                    this.ThumbnailWidth.Equals(input.ThumbnailWidth))
                ) && 
                (
                    this.ThumbnailHeight == input.ThumbnailHeight ||
                    (this.ThumbnailHeight != null &&
                    this.ThumbnailHeight.Equals(input.ThumbnailHeight))
                ) && 
                (
                    this.ThumbnailBackgroundColor == input.ThumbnailBackgroundColor ||
                    (this.ThumbnailBackgroundColor != null &&
                    this.ThumbnailBackgroundColor.Equals(input.ThumbnailBackgroundColor))
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
                if (this.FileData != null)
                    hashCode = hashCode * 59 + this.FileData.GetHashCode();
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.ThumbnailWidth != null)
                    hashCode = hashCode * 59 + this.ThumbnailWidth.GetHashCode();
                if (this.ThumbnailHeight != null)
                    hashCode = hashCode * 59 + this.ThumbnailHeight.GetHashCode();
                if (this.ThumbnailBackgroundColor != null)
                    hashCode = hashCode * 59 + this.ThumbnailBackgroundColor.GetHashCode();
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
