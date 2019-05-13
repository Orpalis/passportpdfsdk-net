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
    /// Represents the parameters for a SetPageBox action.
    /// </summary>
    [DataContract]
    public partial class PDFSetPageBoxParameters :  IEquatable<PDFSetPageBoxParameters>, IValidatableObject
    {
        /// <summary>
        /// Specifies the page box to be set.
        /// </summary>
        /// <value>Specifies the page box to be set.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PageBoxEnum
        {
            /// <summary>
            /// Enum MediaBox for value: MediaBox
            /// </summary>
            [EnumMember(Value = "MediaBox")]
            MediaBox = 1,

            /// <summary>
            /// Enum CropBox for value: CropBox
            /// </summary>
            [EnumMember(Value = "CropBox")]
            CropBox = 2,

            /// <summary>
            /// Enum BleedBox for value: BleedBox
            /// </summary>
            [EnumMember(Value = "BleedBox")]
            BleedBox = 3,

            /// <summary>
            /// Enum TrimBox for value: TrimBox
            /// </summary>
            [EnumMember(Value = "TrimBox")]
            TrimBox = 4,

            /// <summary>
            /// Enum ArtBox for value: ArtBox
            /// </summary>
            [EnumMember(Value = "ArtBox")]
            ArtBox = 5

        }

        /// <summary>
        /// Specifies the page box to be set.
        /// </summary>
        /// <value>Specifies the page box to be set.</value>
        [DataMember(Name="PageBox", EmitDefaultValue=false)]
        public PageBoxEnum? PageBox { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFSetPageBoxParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFSetPageBoxParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFSetPageBoxParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of page whose page box shall be set. (required).</param>
        /// <param name="left">Specifies, in points, the newly defined left position of the specified page box. (required).</param>
        /// <param name="top">Specifies, in points, the newly defined top position of the specified page box. (required).</param>
        /// <param name="right">Specifies, in points, the newly defined right position of the specified page box. (required).</param>
        /// <param name="bottom">Specifies, in points, the newly defined bottom position of the specified page box. (required).</param>
        /// <param name="pageBox">Specifies the page box to be set. (default to PageBoxEnum.CropBox).</param>
        public PDFSetPageBoxParameters(string fileId = default(string), string pageRange = default(string), float? left = default(float?), float? top = default(float?), float? right = default(float?), float? bottom = default(float?), PageBoxEnum? pageBox = PageBoxEnum.CropBox)
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for PDFSetPageBoxParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            
            // to ensure "pageRange" is required (not null)
            if (pageRange == null)
            {
                throw new InvalidDataException("pageRange is a required property for PDFSetPageBoxParameters and cannot be null");
            }
            else
            {
                this.PageRange = pageRange;
            }
            
            // to ensure "left" is required (not null)
            if (left == null)
            {
                throw new InvalidDataException("left is a required property for PDFSetPageBoxParameters and cannot be null");
            }
            else
            {
                this.Left = left;
            }
            
            // to ensure "top" is required (not null)
            if (top == null)
            {
                throw new InvalidDataException("top is a required property for PDFSetPageBoxParameters and cannot be null");
            }
            else
            {
                this.Top = top;
            }
            
            // to ensure "right" is required (not null)
            if (right == null)
            {
                throw new InvalidDataException("right is a required property for PDFSetPageBoxParameters and cannot be null");
            }
            else
            {
                this.Right = right;
            }
            
            // to ensure "bottom" is required (not null)
            if (bottom == null)
            {
                throw new InvalidDataException("bottom is a required property for PDFSetPageBoxParameters and cannot be null");
            }
            else
            {
                this.Bottom = bottom;
            }
            
            // use default value if no "pageBox" provided
            if (pageBox == null)
            {
                this.PageBox = PageBoxEnum.CropBox;
            }
            else
            {
                this.PageBox = pageBox;
            }
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of page whose page box shall be set.
        /// </summary>
        /// <value>Specifies the number of the page, or the range of page whose page box shall be set.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies, in points, the newly defined left position of the specified page box.
        /// </summary>
        /// <value>Specifies, in points, the newly defined left position of the specified page box.</value>
        [DataMember(Name="Left", EmitDefaultValue=false)]
        public float? Left { get; set; }

        /// <summary>
        /// Specifies, in points, the newly defined top position of the specified page box.
        /// </summary>
        /// <value>Specifies, in points, the newly defined top position of the specified page box.</value>
        [DataMember(Name="Top", EmitDefaultValue=false)]
        public float? Top { get; set; }

        /// <summary>
        /// Specifies, in points, the newly defined right position of the specified page box.
        /// </summary>
        /// <value>Specifies, in points, the newly defined right position of the specified page box.</value>
        [DataMember(Name="Right", EmitDefaultValue=false)]
        public float? Right { get; set; }

        /// <summary>
        /// Specifies, in points, the newly defined bottom position of the specified page box.
        /// </summary>
        /// <value>Specifies, in points, the newly defined bottom position of the specified page box.</value>
        [DataMember(Name="Bottom", EmitDefaultValue=false)]
        public float? Bottom { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFSetPageBoxParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  Left: ").Append(Left).Append("\n");
            sb.Append("  Top: ").Append(Top).Append("\n");
            sb.Append("  Right: ").Append(Right).Append("\n");
            sb.Append("  Bottom: ").Append(Bottom).Append("\n");
            sb.Append("  PageBox: ").Append(PageBox).Append("\n");
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
            return this.Equals(input as PDFSetPageBoxParameters);
        }

        /// <summary>
        /// Returns true if PDFSetPageBoxParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFSetPageBoxParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFSetPageBoxParameters input)
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
                    this.Left == input.Left ||
                    (this.Left != null &&
                    this.Left.Equals(input.Left))
                ) && 
                (
                    this.Top == input.Top ||
                    (this.Top != null &&
                    this.Top.Equals(input.Top))
                ) && 
                (
                    this.Right == input.Right ||
                    (this.Right != null &&
                    this.Right.Equals(input.Right))
                ) && 
                (
                    this.Bottom == input.Bottom ||
                    (this.Bottom != null &&
                    this.Bottom.Equals(input.Bottom))
                ) && 
                (
                    this.PageBox == input.PageBox ||
                    (this.PageBox != null &&
                    this.PageBox.Equals(input.PageBox))
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
                if (this.Left != null)
                    hashCode = hashCode * 59 + this.Left.GetHashCode();
                if (this.Top != null)
                    hashCode = hashCode * 59 + this.Top.GetHashCode();
                if (this.Right != null)
                    hashCode = hashCode * 59 + this.Right.GetHashCode();
                if (this.Bottom != null)
                    hashCode = hashCode * 59 + this.Bottom.GetHashCode();
                if (this.PageBox != null)
                    hashCode = hashCode * 59 + this.PageBox.GetHashCode();
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
