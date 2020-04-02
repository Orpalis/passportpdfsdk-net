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
    public partial class PdfSaveAsTIFFMultipageParameters :  IEquatable<PdfSaveAsTIFFMultipageParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfSaveAsTIFFMultipageParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfSaveAsTIFFMultipageParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfSaveAsTIFFMultipageParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        public PdfSaveAsTIFFMultipageParameters(string fileId)
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
        /// Specifies whether the initial image resolution must be kept in case of raster-pdf processing.
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
            return Equals(input as PdfSaveAsTIFFMultipageParameters);
        }

        /// <summary>
        /// Returns true if PdfSaveAsTIFFMultipageParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfSaveAsTIFFMultipageParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfSaveAsTIFFMultipageParameters input)
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
                hashCode = hashCode * 59 + JpegQuality.GetHashCode();
                hashCode = hashCode * 59 + Resolution.GetHashCode();
                hashCode = hashCode * 59 + RenderFormFields.GetHashCode();
                hashCode = hashCode * 59 + KeepRasterPDFResolution.GetHashCode();
                return hashCode;
            }
        }
    }

}
