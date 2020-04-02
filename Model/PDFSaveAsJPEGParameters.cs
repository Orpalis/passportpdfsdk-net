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
    /// Represents the parameters for a save as JPEG acion.
    /// </summary>
    [DataContract]
    public partial class PdfSaveAsJPEGParameters :  IEquatable<PdfSaveAsJPEGParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfSaveAsJPEGParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfSaveAsJPEGParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfSaveAsJPEGParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        public PdfSaveAsJPEGParameters(string fileId)
        {
            FileId = fileId;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to be saved as JPEG.
        /// </summary>
        [DataMember(Name="PageRange")]
        public string PageRange { get; set; } = "*";

        /// <summary>
        /// Specifies the level of quality to be used for the JPEG compression, from 1 (poorest) to 100 (greatest).
        /// </summary>
        [DataMember(Name="Quality")]
        public int Quality { get; set; } = 75;

        /// <summary>
        /// Specifies if the encoded JPEG image must be progressive.
        /// </summary>
        [DataMember(Name="Progressive")]
        public bool Progressive { get; set; } = false;

        /// <summary>
        /// Specifies the resolution to be used for the rendition process.
        /// </summary>
        [DataMember(Name="Resolution")]
        public float Resolution { get; set; } = 200F;

        /// <summary>
        /// Specifies whether the form fields of the PDF shall be rendered.
        /// </summary>
        [DataMember(Name="RenderFormFields")]
        public bool RenderFormFields { get; set; } = false;

        /// <summary>
        /// Specifies if the initial image resolution must be kept in case of raster-pdf processing.
        /// </summary>
        [DataMember(Name="KeepRasterPDFResolution")]
        public bool KeepRasterPDFResolution { get; set; } = true;

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
            return Equals(input as PdfSaveAsJPEGParameters);
        }

        /// <summary>
        /// Returns true if PdfSaveAsJPEGParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfSaveAsJPEGParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfSaveAsJPEGParameters input)
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
                    Quality == input.Quality ||
                    Quality.Equals(input.Quality)
                ) && 
                (
                    Progressive == input.Progressive ||
                    Progressive.Equals(input.Progressive)
                ) && 
                (
                    Resolution == input.Resolution ||
                    Resolution.Equals(input.Resolution)
                ) && 
                (
                    RenderFormFields == input.RenderFormFields ||
                    RenderFormFields.Equals(input.RenderFormFields)
                ) && 
                (
                    KeepRasterPDFResolution == input.KeepRasterPDFResolution ||
                    KeepRasterPDFResolution.Equals(input.KeepRasterPDFResolution)
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
                hashCode = hashCode * 59 + Quality.GetHashCode();
                hashCode = hashCode * 59 + Progressive.GetHashCode();
                hashCode = hashCode * 59 + Resolution.GetHashCode();
                hashCode = hashCode * 59 + RenderFormFields.GetHashCode();
                hashCode = hashCode * 59 + KeepRasterPDFResolution.GetHashCode();
                return hashCode;
            }
        }
    }

}
