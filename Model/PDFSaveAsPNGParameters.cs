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
    /// Represents the parameters for a save as PNG acion.
    /// </summary>
    [DataContract]
    public partial class PdfSaveAsPNGParameters :  IEquatable<PdfSaveAsPNGParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfSaveAsPNGParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfSaveAsPNGParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfSaveAsPNGParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        public PdfSaveAsPNGParameters(string fileId)
        {
            FileId = fileId;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to be saved as PNG.
        /// </summary>
        [DataMember(Name="PageRange")]
        public string PageRange { get; set; } = "*";

        /// <summary>
        /// Specifies the level of compression to be used for the PNG output, between 0 (no compression - faster encoding) to 9(max compression - slower encoding).
        /// </summary>
        [DataMember(Name="Compression")]
        public int Compression { get; set; } = 6;

        /// <summary>
        /// Specifies if the produced PNG image must be interlaced.
        /// </summary>
        [DataMember(Name="Interlaced")]
        public bool Interlaced { get; set; } = false;

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
            return Equals(input as PdfSaveAsPNGParameters);
        }

        /// <summary>
        /// Returns true if PdfSaveAsPNGParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfSaveAsPNGParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfSaveAsPNGParameters input)
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
                    Interlaced == input.Interlaced ||
                    Interlaced.Equals(input.Interlaced)
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
                hashCode = hashCode * 59 + Compression.GetHashCode();
                hashCode = hashCode * 59 + Interlaced.GetHashCode();
                hashCode = hashCode * 59 + Resolution.GetHashCode();
                hashCode = hashCode * 59 + RenderFormFields.GetHashCode();
                hashCode = hashCode * 59 + KeepRasterPDFResolution.GetHashCode();
                return hashCode;
            }
        }
    }

}
