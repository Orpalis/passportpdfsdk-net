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
    /// Represents the parameters for a MICR action.
    /// </summary>
    [DataContract]
    public partial class ImageMICRParameters :  IEquatable<ImageMICRParameters>, IValidatableObject
    {
        /// <summary>
        /// Specifies the font the type of MICR font to be recognized.
        /// </summary>
        /// <value>Specifies the font the type of MICR font to be recognized.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FontEnum
        {
            /// <summary>
            /// Enum CMC7 for value: CMC7
            /// </summary>
            [EnumMember(Value = "CMC7")]
            CMC7 = 1,

            /// <summary>
            /// Enum E13B for value: E13B
            /// </summary>
            [EnumMember(Value = "E13B")]
            E13B = 2

        }

        /// <summary>
        /// Specifies the font the type of MICR font to be recognized.
        /// </summary>
        /// <value>Specifies the font the type of MICR font to be recognized.</value>
        [DataMember(Name="Font", EmitDefaultValue=false)]
        public FontEnum Font { get; set; }
        /// <summary>
        /// Specifies the layout type of the data to be recognized.
        /// </summary>
        /// <value>Specifies the layout type of the data to be recognized.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum WholeDocument for value: WholeDocument
            /// </summary>
            [EnumMember(Value = "WholeDocument")]
            WholeDocument = 1,

            /// <summary>
            /// Enum LineFinding for value: LineFinding
            /// </summary>
            [EnumMember(Value = "LineFinding")]
            LineFinding = 2

        }

        /// <summary>
        /// Specifies the layout type of the data to be recognized.
        /// </summary>
        /// <value>Specifies the layout type of the data to be recognized.</value>
        [DataMember(Name="Context", EmitDefaultValue=false)]
        public ContextEnum Context { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageMICRParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageMICRParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageMICRParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the page or the range of page to be processed. (required).</param>
        /// <param name="font">Specifies the font the type of MICR font to be recognized. (required).</param>
        /// <param name="context">Specifies the layout type of the data to be recognized. (required).</param>
        /// <param name="whiteList">Specifies the characters to be ignored by the recognition process..</param>
        /// <param name="roiLeft">Specifies the left coordinate, in pixel, of the region to process..</param>
        /// <param name="roiTop">Specifies the top coordinate, in pixel, of the region to process..</param>
        /// <param name="roiWidth">Specifies the width, in pixel, of the region to process. 0 causes the entire image to be processed..</param>
        /// <param name="roiHeight">Specifies the height, in pixel, of the region to process. 0 causes the entire image to be processed..</param>
        /// <param name="expectedSymbolsCount">Specifies the number of symbols expected to be detected, use 0 if unknown..</param>
        public ImageMICRParameters(string fileId = default(string), string pageRange = default(string), FontEnum font = default(FontEnum), ContextEnum context = default(ContextEnum), string whiteList = default(string), int? roiLeft = default(int?), int? roiTop = default(int?), int? roiWidth = default(int?), int? roiHeight = default(int?), int? expectedSymbolsCount = default(int?))
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for ImageMICRParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            
            // to ensure "pageRange" is required (not null)
            if (pageRange == null)
            {
                throw new InvalidDataException("pageRange is a required property for ImageMICRParameters and cannot be null");
            }
            else
            {
                this.PageRange = pageRange;
            }
            
            // to ensure "font" is required (not null)
            if (font == null)
            {
                throw new InvalidDataException("font is a required property for ImageMICRParameters and cannot be null");
            }
            else
            {
                this.Font = font;
            }
            
            // to ensure "context" is required (not null)
            if (context == null)
            {
                throw new InvalidDataException("context is a required property for ImageMICRParameters and cannot be null");
            }
            else
            {
                this.Context = context;
            }
            
            this.WhiteList = whiteList;
            this.RoiLeft = roiLeft;
            this.RoiTop = roiTop;
            this.RoiWidth = roiWidth;
            this.RoiHeight = roiHeight;
            this.ExpectedSymbolsCount = expectedSymbolsCount;
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the page or the range of page to be processed.
        /// </summary>
        /// <value>Specifies the page or the range of page to be processed.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }



        /// <summary>
        /// Specifies the characters to be ignored by the recognition process.
        /// </summary>
        /// <value>Specifies the characters to be ignored by the recognition process.</value>
        [DataMember(Name="WhiteList", EmitDefaultValue=false)]
        public string WhiteList { get; set; }

        /// <summary>
        /// Specifies the left coordinate, in pixel, of the region to process.
        /// </summary>
        /// <value>Specifies the left coordinate, in pixel, of the region to process.</value>
        [DataMember(Name="RoiLeft", EmitDefaultValue=false)]
        public int? RoiLeft { get; set; }

        /// <summary>
        /// Specifies the top coordinate, in pixel, of the region to process.
        /// </summary>
        /// <value>Specifies the top coordinate, in pixel, of the region to process.</value>
        [DataMember(Name="RoiTop", EmitDefaultValue=false)]
        public int? RoiTop { get; set; }

        /// <summary>
        /// Specifies the width, in pixel, of the region to process. 0 causes the entire image to be processed.
        /// </summary>
        /// <value>Specifies the width, in pixel, of the region to process. 0 causes the entire image to be processed.</value>
        [DataMember(Name="RoiWidth", EmitDefaultValue=false)]
        public int? RoiWidth { get; set; }

        /// <summary>
        /// Specifies the height, in pixel, of the region to process. 0 causes the entire image to be processed.
        /// </summary>
        /// <value>Specifies the height, in pixel, of the region to process. 0 causes the entire image to be processed.</value>
        [DataMember(Name="RoiHeight", EmitDefaultValue=false)]
        public int? RoiHeight { get; set; }

        /// <summary>
        /// Specifies the number of symbols expected to be detected, use 0 if unknown.
        /// </summary>
        /// <value>Specifies the number of symbols expected to be detected, use 0 if unknown.</value>
        [DataMember(Name="ExpectedSymbolsCount", EmitDefaultValue=false)]
        public int? ExpectedSymbolsCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageMICRParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  Font: ").Append(Font).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  WhiteList: ").Append(WhiteList).Append("\n");
            sb.Append("  RoiLeft: ").Append(RoiLeft).Append("\n");
            sb.Append("  RoiTop: ").Append(RoiTop).Append("\n");
            sb.Append("  RoiWidth: ").Append(RoiWidth).Append("\n");
            sb.Append("  RoiHeight: ").Append(RoiHeight).Append("\n");
            sb.Append("  ExpectedSymbolsCount: ").Append(ExpectedSymbolsCount).Append("\n");
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
            return this.Equals(input as ImageMICRParameters);
        }

        /// <summary>
        /// Returns true if ImageMICRParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageMICRParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageMICRParameters input)
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
                    this.Font == input.Font ||
                    (this.Font != null &&
                    this.Font.Equals(input.Font))
                ) && 
                (
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
                ) && 
                (
                    this.WhiteList == input.WhiteList ||
                    (this.WhiteList != null &&
                    this.WhiteList.Equals(input.WhiteList))
                ) && 
                (
                    this.RoiLeft == input.RoiLeft ||
                    (this.RoiLeft != null &&
                    this.RoiLeft.Equals(input.RoiLeft))
                ) && 
                (
                    this.RoiTop == input.RoiTop ||
                    (this.RoiTop != null &&
                    this.RoiTop.Equals(input.RoiTop))
                ) && 
                (
                    this.RoiWidth == input.RoiWidth ||
                    (this.RoiWidth != null &&
                    this.RoiWidth.Equals(input.RoiWidth))
                ) && 
                (
                    this.RoiHeight == input.RoiHeight ||
                    (this.RoiHeight != null &&
                    this.RoiHeight.Equals(input.RoiHeight))
                ) && 
                (
                    this.ExpectedSymbolsCount == input.ExpectedSymbolsCount ||
                    (this.ExpectedSymbolsCount != null &&
                    this.ExpectedSymbolsCount.Equals(input.ExpectedSymbolsCount))
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
                if (this.Font != null)
                    hashCode = hashCode * 59 + this.Font.GetHashCode();
                if (this.Context != null)
                    hashCode = hashCode * 59 + this.Context.GetHashCode();
                if (this.WhiteList != null)
                    hashCode = hashCode * 59 + this.WhiteList.GetHashCode();
                if (this.RoiLeft != null)
                    hashCode = hashCode * 59 + this.RoiLeft.GetHashCode();
                if (this.RoiTop != null)
                    hashCode = hashCode * 59 + this.RoiTop.GetHashCode();
                if (this.RoiWidth != null)
                    hashCode = hashCode * 59 + this.RoiWidth.GetHashCode();
                if (this.RoiHeight != null)
                    hashCode = hashCode * 59 + this.RoiHeight.GetHashCode();
                if (this.ExpectedSymbolsCount != null)
                    hashCode = hashCode * 59 + this.ExpectedSymbolsCount.GetHashCode();
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
