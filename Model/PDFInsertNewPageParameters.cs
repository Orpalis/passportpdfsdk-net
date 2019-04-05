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
    /// Represents the parameters for an insert new page action.
    /// </summary>
    [DataContract]
    public partial class PDFInsertNewPageParameters :  IEquatable<PDFInsertNewPageParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFInsertNewPageParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFInsertNewPageParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFInsertNewPageParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageNumber">Specifies the number of the page where the new page(s) shall be inserted. (required).</param>
        /// <param name="pageCount">Specifies the number of pages that must be inserted. (default to 1).</param>
        /// <param name="width">Specifies, in points, the width of the page(s) to be inserted. (default to 595.0F).</param>
        /// <param name="height">Specifies, in points, the height of the page(s) to be inserted. (default to 842.0F).</param>
        public PDFInsertNewPageParameters(string fileId = default(string), int? pageNumber = default(int?), int? pageCount = 1, float? width = 595.0F, float? height = 842.0F)
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for PDFInsertNewPageParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            // to ensure "pageNumber" is required (not null)
            if (pageNumber == null)
            {
                throw new InvalidDataException("pageNumber is a required property for PDFInsertNewPageParameters and cannot be null");
            }
            else
            {
                this.PageNumber = pageNumber;
            }
            // use default value if no "pageCount" provided
            if (pageCount == null)
            {
                this.PageCount = 1;
            }
            else
            {
                this.PageCount = pageCount;
            }
            // use default value if no "width" provided
            if (width == null)
            {
                this.Width = 595.0F;
            }
            else
            {
                this.Width = width;
            }
            // use default value if no "height" provided
            if (height == null)
            {
                this.Height = 842.0F;
            }
            else
            {
                this.Height = height;
            }
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page where the new page(s) shall be inserted.
        /// </summary>
        /// <value>Specifies the number of the page where the new page(s) shall be inserted.</value>
        [DataMember(Name="PageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// Specifies the number of pages that must be inserted.
        /// </summary>
        /// <value>Specifies the number of pages that must be inserted.</value>
        [DataMember(Name="PageCount", EmitDefaultValue=false)]
        public int? PageCount { get; set; }

        /// <summary>
        /// Specifies, in points, the width of the page(s) to be inserted.
        /// </summary>
        /// <value>Specifies, in points, the width of the page(s) to be inserted.</value>
        [DataMember(Name="Width", EmitDefaultValue=false)]
        public float? Width { get; set; }

        /// <summary>
        /// Specifies, in points, the height of the page(s) to be inserted.
        /// </summary>
        /// <value>Specifies, in points, the height of the page(s) to be inserted.</value>
        [DataMember(Name="Height", EmitDefaultValue=false)]
        public float? Height { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFInsertNewPageParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
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
            return this.Equals(input as PDFInsertNewPageParameters);
        }

        /// <summary>
        /// Returns true if PDFInsertNewPageParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFInsertNewPageParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFInsertNewPageParameters input)
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
                    this.PageNumber == input.PageNumber ||
                    (this.PageNumber != null &&
                    this.PageNumber.Equals(input.PageNumber))
                ) && 
                (
                    this.PageCount == input.PageCount ||
                    (this.PageCount != null &&
                    this.PageCount.Equals(input.PageCount))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
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
                if (this.PageNumber != null)
                    hashCode = hashCode * 59 + this.PageNumber.GetHashCode();
                if (this.PageCount != null)
                    hashCode = hashCode * 59 + this.PageCount.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
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
