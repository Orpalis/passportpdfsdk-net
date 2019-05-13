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
    /// Represents the parameters for a cleanup document action.
    /// </summary>
    [DataContract]
    public partial class ImageCleanupDocumentParameters :  IEquatable<ImageCleanupDocumentParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageCleanupDocumentParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageCleanupDocumentParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageCleanupDocumentParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages to cleanup. (required).</param>
        /// <param name="removeBlackBorders">Specifies whether the dark borders of the document image shall be replaced with white content..</param>
        /// <param name="deskew">Specifies whether the document shall be deskewed..</param>
        /// <param name="removeLeftMarginPunchHoles">Specifies whether punch holes shall be removed from the left margin of the document..</param>
        /// <param name="removeTopMarginPunchHoles">Specifies whether punch holes shall be removed from the top margin of the document..</param>
        /// <param name="removeRightMarginPunchHoles">Specifies whether punch holes shall be removed from the right margin of the document..</param>
        /// <param name="removeBottomMarginPunchHoles">Specifies whether punch holes shall be removed from the bottom margin of the document..</param>
        /// <param name="despeckleStrength">Specifies the strength of the despeckle filter to be applied on the image..</param>
        public ImageCleanupDocumentParameters(string fileId = default(string), string pageRange = default(string), bool? removeBlackBorders = default(bool?), bool? deskew = default(bool?), bool? removeLeftMarginPunchHoles = default(bool?), bool? removeTopMarginPunchHoles = default(bool?), bool? removeRightMarginPunchHoles = default(bool?), bool? removeBottomMarginPunchHoles = default(bool?), int? despeckleStrength = default(int?))
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for ImageCleanupDocumentParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            
            // to ensure "pageRange" is required (not null)
            if (pageRange == null)
            {
                throw new InvalidDataException("pageRange is a required property for ImageCleanupDocumentParameters and cannot be null");
            }
            else
            {
                this.PageRange = pageRange;
            }
            
            this.RemoveBlackBorders = removeBlackBorders;
            this.Deskew = deskew;
            this.RemoveLeftMarginPunchHoles = removeLeftMarginPunchHoles;
            this.RemoveTopMarginPunchHoles = removeTopMarginPunchHoles;
            this.RemoveRightMarginPunchHoles = removeRightMarginPunchHoles;
            this.RemoveBottomMarginPunchHoles = removeBottomMarginPunchHoles;
            this.DespeckleStrength = despeckleStrength;
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to cleanup.
        /// </summary>
        /// <value>Specifies the number of the page, or the range of pages to cleanup.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies whether the dark borders of the document image shall be replaced with white content.
        /// </summary>
        /// <value>Specifies whether the dark borders of the document image shall be replaced with white content.</value>
        [DataMember(Name="RemoveBlackBorders", EmitDefaultValue=false)]
        public bool? RemoveBlackBorders { get; set; }

        /// <summary>
        /// Specifies whether the document shall be deskewed.
        /// </summary>
        /// <value>Specifies whether the document shall be deskewed.</value>
        [DataMember(Name="Deskew", EmitDefaultValue=false)]
        public bool? Deskew { get; set; }

        /// <summary>
        /// Specifies whether punch holes shall be removed from the left margin of the document.
        /// </summary>
        /// <value>Specifies whether punch holes shall be removed from the left margin of the document.</value>
        [DataMember(Name="RemoveLeftMarginPunchHoles", EmitDefaultValue=false)]
        public bool? RemoveLeftMarginPunchHoles { get; set; }

        /// <summary>
        /// Specifies whether punch holes shall be removed from the top margin of the document.
        /// </summary>
        /// <value>Specifies whether punch holes shall be removed from the top margin of the document.</value>
        [DataMember(Name="RemoveTopMarginPunchHoles", EmitDefaultValue=false)]
        public bool? RemoveTopMarginPunchHoles { get; set; }

        /// <summary>
        /// Specifies whether punch holes shall be removed from the right margin of the document.
        /// </summary>
        /// <value>Specifies whether punch holes shall be removed from the right margin of the document.</value>
        [DataMember(Name="RemoveRightMarginPunchHoles", EmitDefaultValue=false)]
        public bool? RemoveRightMarginPunchHoles { get; set; }

        /// <summary>
        /// Specifies whether punch holes shall be removed from the bottom margin of the document.
        /// </summary>
        /// <value>Specifies whether punch holes shall be removed from the bottom margin of the document.</value>
        [DataMember(Name="RemoveBottomMarginPunchHoles", EmitDefaultValue=false)]
        public bool? RemoveBottomMarginPunchHoles { get; set; }

        /// <summary>
        /// Specifies the strength of the despeckle filter to be applied on the image.
        /// </summary>
        /// <value>Specifies the strength of the despeckle filter to be applied on the image.</value>
        [DataMember(Name="DespeckleStrength", EmitDefaultValue=false)]
        public int? DespeckleStrength { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageCleanupDocumentParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  RemoveBlackBorders: ").Append(RemoveBlackBorders).Append("\n");
            sb.Append("  Deskew: ").Append(Deskew).Append("\n");
            sb.Append("  RemoveLeftMarginPunchHoles: ").Append(RemoveLeftMarginPunchHoles).Append("\n");
            sb.Append("  RemoveTopMarginPunchHoles: ").Append(RemoveTopMarginPunchHoles).Append("\n");
            sb.Append("  RemoveRightMarginPunchHoles: ").Append(RemoveRightMarginPunchHoles).Append("\n");
            sb.Append("  RemoveBottomMarginPunchHoles: ").Append(RemoveBottomMarginPunchHoles).Append("\n");
            sb.Append("  DespeckleStrength: ").Append(DespeckleStrength).Append("\n");
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
            return this.Equals(input as ImageCleanupDocumentParameters);
        }

        /// <summary>
        /// Returns true if ImageCleanupDocumentParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageCleanupDocumentParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageCleanupDocumentParameters input)
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
                    this.RemoveBlackBorders == input.RemoveBlackBorders ||
                    (this.RemoveBlackBorders != null &&
                    this.RemoveBlackBorders.Equals(input.RemoveBlackBorders))
                ) && 
                (
                    this.Deskew == input.Deskew ||
                    (this.Deskew != null &&
                    this.Deskew.Equals(input.Deskew))
                ) && 
                (
                    this.RemoveLeftMarginPunchHoles == input.RemoveLeftMarginPunchHoles ||
                    (this.RemoveLeftMarginPunchHoles != null &&
                    this.RemoveLeftMarginPunchHoles.Equals(input.RemoveLeftMarginPunchHoles))
                ) && 
                (
                    this.RemoveTopMarginPunchHoles == input.RemoveTopMarginPunchHoles ||
                    (this.RemoveTopMarginPunchHoles != null &&
                    this.RemoveTopMarginPunchHoles.Equals(input.RemoveTopMarginPunchHoles))
                ) && 
                (
                    this.RemoveRightMarginPunchHoles == input.RemoveRightMarginPunchHoles ||
                    (this.RemoveRightMarginPunchHoles != null &&
                    this.RemoveRightMarginPunchHoles.Equals(input.RemoveRightMarginPunchHoles))
                ) && 
                (
                    this.RemoveBottomMarginPunchHoles == input.RemoveBottomMarginPunchHoles ||
                    (this.RemoveBottomMarginPunchHoles != null &&
                    this.RemoveBottomMarginPunchHoles.Equals(input.RemoveBottomMarginPunchHoles))
                ) && 
                (
                    this.DespeckleStrength == input.DespeckleStrength ||
                    (this.DespeckleStrength != null &&
                    this.DespeckleStrength.Equals(input.DespeckleStrength))
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
                if (this.RemoveBlackBorders != null)
                    hashCode = hashCode * 59 + this.RemoveBlackBorders.GetHashCode();
                if (this.Deskew != null)
                    hashCode = hashCode * 59 + this.Deskew.GetHashCode();
                if (this.RemoveLeftMarginPunchHoles != null)
                    hashCode = hashCode * 59 + this.RemoveLeftMarginPunchHoles.GetHashCode();
                if (this.RemoveTopMarginPunchHoles != null)
                    hashCode = hashCode * 59 + this.RemoveTopMarginPunchHoles.GetHashCode();
                if (this.RemoveRightMarginPunchHoles != null)
                    hashCode = hashCode * 59 + this.RemoveRightMarginPunchHoles.GetHashCode();
                if (this.RemoveBottomMarginPunchHoles != null)
                    hashCode = hashCode * 59 + this.RemoveBottomMarginPunchHoles.GetHashCode();
                if (this.DespeckleStrength != null)
                    hashCode = hashCode * 59 + this.DespeckleStrength.GetHashCode();
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
