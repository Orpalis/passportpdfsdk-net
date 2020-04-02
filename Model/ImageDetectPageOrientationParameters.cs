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
    /// Represents the parameters for a detect page orientation action.
    /// </summary>
    [DataContract]
    public partial class ImageDetectPageOrientationParameters :  IEquatable<ImageDetectPageOrientationParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageDetectPageOrientationParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageDetectPageOrientationParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageDetectPageOrientationParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages to be processed. (required).</param>
        public ImageDetectPageOrientationParameters(string fileId, string pageRange)
        {
            FileId = fileId;
            PageRange = pageRange;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to be processed.
        /// </summary>
        [DataMember(Name="PageRange")]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies the language(s) to be used for the OCR.
        /// </summary>
        [DataMember(Name="Language")]
        public string Language { get; set; } = "eng";

        /// <summary>
        /// Specifies whether a rotation shall be automatically applied in order to correct the page orientation when needed.
        /// </summary>
        [DataMember(Name="AutomaticallyApplyRotation")]
        public bool AutomaticallyApplyRotation { get; set; } = true;

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
            return Equals(input as ImageDetectPageOrientationParameters);
        }

        /// <summary>
        /// Returns true if ImageDetectPageOrientationParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageDetectPageOrientationParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageDetectPageOrientationParameters input)
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
                    Language == input.Language ||
                    (Language != null &&
                    Language.Equals(input.Language))
                ) && 
                (
                    AutomaticallyApplyRotation == input.AutomaticallyApplyRotation ||
                    AutomaticallyApplyRotation.Equals(input.AutomaticallyApplyRotation)
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
                if (Language != null)
                    hashCode = hashCode * 59 + Language.GetHashCode();
                hashCode = hashCode * 59 + AutomaticallyApplyRotation.GetHashCode();
                return hashCode;
            }
        }
    }

}
