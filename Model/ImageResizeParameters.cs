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
    /// Represents the parameters for an image resize action.
    /// </summary>
    [DataContract]
    public partial class ImageResizeParameters :  IEquatable<ImageResizeParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageResizeParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageResizeParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageResizeParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages to resize. (required).</param>
        /// <param name="resizeHorizontal">Specifies the resize horizontal parameter. (required).</param>
        /// <param name="resizeVertical">Specifies the resize vertical parameter. (required).</param>
        public ImageResizeParameters(string fileId, string pageRange, float resizeHorizontal, float resizeVertical)
        {
            FileId = fileId;
            PageRange = pageRange;
            ResizeHorizontal = resizeHorizontal;
            ResizeVertical = resizeVertical;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to resize.
        /// </summary>
        [DataMember(Name="PageRange")]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies the resize horizontal parameter.
        /// </summary>
        [DataMember(Name="ResizeHorizontal")]
        public float ResizeHorizontal { get; set; }

        /// <summary>
        /// Specifies the resize vertical parameter.
        /// </summary>
        [DataMember(Name="ResizeVertical")]
        public float ResizeVertical { get; set; }

        /// <summary>
        /// Gets or Sets ResizeMode
        /// </summary>
        [DataMember(Name="ResizeMode")]
        public ResizeMode ResizeMode { get; set; }

        /// <summary>
        /// Gets or Sets ResizeUnit
        /// </summary>
        [DataMember(Name="ResizeUnit")]
        public ResizeUnit ResizeUnit { get; set; }

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
            return Equals(input as ImageResizeParameters);
        }

        /// <summary>
        /// Returns true if ImageResizeParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageResizeParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageResizeParameters input)
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
                    ResizeHorizontal == input.ResizeHorizontal ||
                    ResizeHorizontal.Equals(input.ResizeHorizontal)
                ) && 
                (
                    ResizeVertical == input.ResizeVertical ||
                    ResizeVertical.Equals(input.ResizeVertical)
                ) && 
                (
                    ResizeMode == input.ResizeMode ||
                    ResizeMode.Equals(input.ResizeMode)
                ) && 
                (
                    ResizeUnit == input.ResizeUnit ||
                    ResizeUnit.Equals(input.ResizeUnit)
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
                hashCode = hashCode * 59 + ResizeHorizontal.GetHashCode();
                hashCode = hashCode * 59 + ResizeVertical.GetHashCode();
                hashCode = hashCode * 59 + ResizeMode.GetHashCode();
                hashCode = hashCode * 59 + ResizeUnit.GetHashCode();
                return hashCode;
            }
        }
    }

}
