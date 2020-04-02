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
    /// Represents the parameters for a save as TIFF multipage action.
    /// </summary>
    [DataContract]
    public partial class ImageSaveAsTIFFMultipageParameters :  IEquatable<ImageSaveAsTIFFMultipageParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSaveAsTIFFMultipageParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageSaveAsTIFFMultipageParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSaveAsTIFFMultipageParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        public ImageSaveAsTIFFMultipageParameters(string fileId)
        {
            FileId = fileId;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to be saved as TIFF.
        /// </summary>
        [DataMember(Name="PageRange")]
        public string PageRange { get; set; } = "*";

        /// <summary>
        /// Gets or Sets Compression
        /// </summary>
        [DataMember(Name="Compression")]
        public TiffSaveCompression Compression { get; set; }

        /// <summary>
        /// Specifies the level of quality to be used if JPEG compression is used, from 1 (poorest) to 100 (greatest).
        /// </summary>
        [DataMember(Name="JpegQuality")]
        public int JpegQuality { get; set; } = 75;

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
            return Equals(input as ImageSaveAsTIFFMultipageParameters);
        }

        /// <summary>
        /// Returns true if ImageSaveAsTIFFMultipageParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageSaveAsTIFFMultipageParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageSaveAsTIFFMultipageParameters input)
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
                    Compression == input.Compression ||
                    Compression.Equals(input.Compression)
                ) && 
                (
                    JpegQuality == input.JpegQuality ||
                    JpegQuality.Equals(input.JpegQuality)
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
                hashCode = hashCode * 59 + Compression.GetHashCode();
                hashCode = hashCode * 59 + JpegQuality.GetHashCode();
                return hashCode;
            }
        }
    }

}
