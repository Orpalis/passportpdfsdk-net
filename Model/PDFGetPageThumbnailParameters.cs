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
    /// Represents the parameters for a get page thumbnail action.
    /// </summary>
    [DataContract]
    public partial class PDFGetPageThumbnailParameters :  IEquatable<PDFGetPageThumbnailParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFGetPageThumbnailParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFGetPageThumbnailParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFGetPageThumbnailParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the page or the range of pages to get a thumbnail from. (required).</param>
        /// <param name="backgroundColor">Specifies the background color of the thumbnail(s), using the color name (ie: \&quot;red\&quot;) or its RGBa code (ie: \&quot;rgba(255,0,0,1)\&quot;). (default to &quot;rgba(0,0,0,0)&quot;).</param>
        /// <param name="thumbnailWidth">Specifies the width, in points, of the thumbnail(s). (default to 140).</param>
        /// <param name="thumbnailHeight">Specifies the height, in points, of the thumbnail(s). (default to 220).</param>
        public PDFGetPageThumbnailParameters(string fileId = default(string), string pageRange = default(string), string backgroundColor = "rgba(0,0,0,0)", int? thumbnailWidth = 140, int? thumbnailHeight = 220)
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for PDFGetPageThumbnailParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            
            // to ensure "pageRange" is required (not null)
            if (pageRange == null)
            {
                throw new InvalidDataException("pageRange is a required property for PDFGetPageThumbnailParameters and cannot be null");
            }
            else
            {
                this.PageRange = pageRange;
            }
            
            // use default value if no "backgroundColor" provided
            if (backgroundColor == null)
            {
                this.BackgroundColor = "rgba(0,0,0,0)";
            }
            else
            {
                this.BackgroundColor = backgroundColor;
            }
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
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the page or the range of pages to get a thumbnail from.
        /// </summary>
        /// <value>Specifies the page or the range of pages to get a thumbnail from.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies the background color of the thumbnail(s), using the color name (ie: \&quot;red\&quot;) or its RGBa code (ie: \&quot;rgba(255,0,0,1)\&quot;).
        /// </summary>
        /// <value>Specifies the background color of the thumbnail(s), using the color name (ie: \&quot;red\&quot;) or its RGBa code (ie: \&quot;rgba(255,0,0,1)\&quot;).</value>
        [DataMember(Name="BackgroundColor", EmitDefaultValue=false)]
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Specifies the width, in points, of the thumbnail(s).
        /// </summary>
        /// <value>Specifies the width, in points, of the thumbnail(s).</value>
        [DataMember(Name="ThumbnailWidth", EmitDefaultValue=false)]
        public int? ThumbnailWidth { get; set; }

        /// <summary>
        /// Specifies the height, in points, of the thumbnail(s).
        /// </summary>
        /// <value>Specifies the height, in points, of the thumbnail(s).</value>
        [DataMember(Name="ThumbnailHeight", EmitDefaultValue=false)]
        public int? ThumbnailHeight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFGetPageThumbnailParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
            sb.Append("  ThumbnailWidth: ").Append(ThumbnailWidth).Append("\n");
            sb.Append("  ThumbnailHeight: ").Append(ThumbnailHeight).Append("\n");
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
            return this.Equals(input as PDFGetPageThumbnailParameters);
        }

        /// <summary>
        /// Returns true if PDFGetPageThumbnailParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFGetPageThumbnailParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFGetPageThumbnailParameters input)
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
                    this.BackgroundColor == input.BackgroundColor ||
                    (this.BackgroundColor != null &&
                    this.BackgroundColor.Equals(input.BackgroundColor))
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
                if (this.BackgroundColor != null)
                    hashCode = hashCode * 59 + this.BackgroundColor.GetHashCode();
                if (this.ThumbnailWidth != null)
                    hashCode = hashCode * 59 + this.ThumbnailWidth.GetHashCode();
                if (this.ThumbnailHeight != null)
                    hashCode = hashCode * 59 + this.ThumbnailHeight.GetHashCode();
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
