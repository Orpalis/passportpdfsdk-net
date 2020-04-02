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
    /// Represents the parameters for a rotate page standard action.
    /// </summary>
    [DataContract]
    public partial class PdfRotatePageStandardParameters :  IEquatable<PdfRotatePageStandardParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfRotatePageStandardParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfRotatePageStandardParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfRotatePageStandardParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages to be rotated.  You can specify different page rotations using such pattern: Page Range = \"M:1:90;2:270\". In this example, a rotation of 90 degrees will be applied to the page 1 and 270 degrees to the page 2. (required).</param>
        /// <param name="rotationAngle">Specifies the rotation angle, clockwise in degrees, which can be either positive and negative and any multiple of 90.  Use 0 in case of special pattern usage for the PageRange property. (required).</param>
        public PdfRotatePageStandardParameters(string fileId, string pageRange, int rotationAngle)
        {
            FileId = fileId;
            PageRange = pageRange;
            RotationAngle = rotationAngle;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to be rotated.  You can specify different page rotations using such pattern: Page Range = \"M:1:90;2:270\". In this example, a rotation of 90 degrees will be applied to the page 1 and 270 degrees to the page 2.
        /// </summary>
        [DataMember(Name="PageRange")]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies the rotation angle, clockwise in degrees, which can be either positive and negative and any multiple of 90.  Use 0 in case of special pattern usage for the PageRange property.
        /// </summary>
        [DataMember(Name="RotationAngle")]
        public int RotationAngle { get; set; }

        /// <summary>
        /// Specifies whether the page(s) shall be flipped horizontally.  This parameter is ignored if PageRange start with \"M:\".
        /// </summary>
        [DataMember(Name="FlipHorizontally")]
        public bool FlipHorizontally { get; set; } = false;

        /// <summary>
        /// Specifies whether the page(s) shall be flipped vertically.  This parameter is ignored if PageRange start with \"M:\".
        /// </summary>
        [DataMember(Name="FlipVertically")]
        public bool FlipVertically { get; set; } = false;

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
            return Equals(input as PdfRotatePageStandardParameters);
        }

        /// <summary>
        /// Returns true if PdfRotatePageStandardParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfRotatePageStandardParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfRotatePageStandardParameters input)
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
                    RotationAngle == input.RotationAngle ||
                    RotationAngle.Equals(input.RotationAngle)
                ) && 
                (
                    FlipHorizontally == input.FlipHorizontally ||
                    FlipHorizontally.Equals(input.FlipHorizontally)
                ) && 
                (
                    FlipVertically == input.FlipVertically ||
                    FlipVertically.Equals(input.FlipVertically)
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
                hashCode = hashCode * 59 + RotationAngle.GetHashCode();
                hashCode = hashCode * 59 + FlipHorizontally.GetHashCode();
                hashCode = hashCode * 59 + FlipVertically.GetHashCode();
                return hashCode;
            }
        }
    }

}
