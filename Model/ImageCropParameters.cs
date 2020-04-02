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


namespace PassportPDF.Model
{
    /// <summary>
    /// Represents the parameters for an image crop action.
    /// </summary>
    [DataContract]
    public partial class ImageCropParameters :  IEquatable<ImageCropParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageCropParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageCropParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageCropParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages to crop. (required).</param>
        /// <param name="cropBoxLeft">Specifies the crop box left coordinate. (required).</param>
        /// <param name="cropBoxTop">Specifies the crop box top coordinate. (required).</param>
        /// <param name="cropBoxWidth">Specifies the crop box width. (required).</param>
        /// <param name="cropBoxHeight">Specifies the crop box height. (required).</param>
        public ImageCropParameters(string fileId, string pageRange, int cropBoxLeft, int cropBoxTop, int cropBoxWidth, int cropBoxHeight)
        {
            FileId = fileId;
            PageRange = pageRange;
            CropBoxLeft = cropBoxLeft;
            CropBoxTop = cropBoxTop;
            CropBoxWidth = cropBoxWidth;
            CropBoxHeight = cropBoxHeight;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to crop.
        /// </summary>
        [DataMember(Name="PageRange")]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies the crop box left coordinate.
        /// </summary>
        [DataMember(Name="CropBoxLeft")]
        public int CropBoxLeft { get; set; }

        /// <summary>
        /// Specifies the crop box top coordinate.
        /// </summary>
        [DataMember(Name="CropBoxTop")]
        public int CropBoxTop { get; set; }

        /// <summary>
        /// Specifies the crop box width.
        /// </summary>
        [DataMember(Name="CropBoxWidth")]
        public int CropBoxWidth { get; set; }

        /// <summary>
        /// Specifies the crop box height.
        /// </summary>
        [DataMember(Name="CropBoxHeight")]
        public int CropBoxHeight { get; set; }

        /// <summary>
        /// Gets or Sets CropUnit
        /// </summary>
        [DataMember(Name="CropUnit")]
        public CropUnit CropUnit { get; set; }

        /// <summary>
        /// Returns the String presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
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
            return Equals(input as ImageCropParameters);
        }

        /// <summary>
        /// Returns true if ImageCropParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageCropParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageCropParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    FileId == input.FileId ||
                    (FileId != null &&
                    FileId.Equals(input.FileId))
                ) && 
                (
                    PageRange == input.PageRange ||
                    (PageRange != null &&
                    PageRange.Equals(input.PageRange))
                ) && 
                (
                    CropBoxLeft == input.CropBoxLeft ||
                    CropBoxLeft.Equals(input.CropBoxLeft)
                ) && 
                (
                    CropBoxTop == input.CropBoxTop ||
                    CropBoxTop.Equals(input.CropBoxTop)
                ) && 
                (
                    CropBoxWidth == input.CropBoxWidth ||
                    CropBoxWidth.Equals(input.CropBoxWidth)
                ) && 
                (
                    CropBoxHeight == input.CropBoxHeight ||
                    CropBoxHeight.Equals(input.CropBoxHeight)
                ) && 
                (
                    CropUnit == input.CropUnit ||
                    CropUnit.Equals(input.CropUnit)
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
                if (FileId != null)
                    hashCode = hashCode * 59 + FileId.GetHashCode();
                if (PageRange != null)
                    hashCode = hashCode * 59 + PageRange.GetHashCode();
                hashCode = hashCode * 59 + CropBoxLeft.GetHashCode();
                hashCode = hashCode * 59 + CropBoxTop.GetHashCode();
                hashCode = hashCode * 59 + CropBoxWidth.GetHashCode();
                hashCode = hashCode * 59 + CropBoxHeight.GetHashCode();
                hashCode = hashCode * 59 + CropUnit.GetHashCode();
                return hashCode;
            }
        }
    }

}
