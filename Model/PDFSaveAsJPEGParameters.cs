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
    /// Represents the parameters for a save as JPEG acion.
    /// </summary>
    [DataContract]
    public partial class PDFSaveAsJPEGParameters :  IEquatable<PDFSaveAsJPEGParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFSaveAsJPEGParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFSaveAsJPEGParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFSaveAsJPEGParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages to be saved as JPEG. (required).</param>
        /// <param name="quality">Specifies the level of quality to be used for the JPEG compression, from 1 (poorest) to 100 (greatest). (default to 75).</param>
        /// <param name="progressive">Specifies if the encoded JPEG image must be progressive..</param>
        /// <param name="resolution">Specifies the resolution to be used for the rendition process. (default to 200.0F).</param>
        /// <param name="renderFormFields">Specifies whether the form fields of the PDF shall be rendered..</param>
        /// <param name="keepRasterPDFResolution">Specifies if the initial image resolution must be kept in case of raster-pdf processing. (default to true).</param>
        public PDFSaveAsJPEGParameters(string fileId = default(string), string pageRange = default(string), int? quality = 75, bool? progressive = default(bool?), float? resolution = 200.0F, bool? renderFormFields = default(bool?), bool? keepRasterPDFResolution = true)
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for PDFSaveAsJPEGParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            
            // to ensure "pageRange" is required (not null)
            if (pageRange == null)
            {
                throw new InvalidDataException("pageRange is a required property for PDFSaveAsJPEGParameters and cannot be null");
            }
            else
            {
                this.PageRange = pageRange;
            }
            
            // use default value if no "quality" provided
            if (quality == null)
            {
                this.Quality = 75;
            }
            else
            {
                this.Quality = quality;
            }
            this.Progressive = progressive;
            // use default value if no "resolution" provided
            if (resolution == null)
            {
                this.Resolution = 200.0F;
            }
            else
            {
                this.Resolution = resolution;
            }
            this.RenderFormFields = renderFormFields;
            // use default value if no "keepRasterPDFResolution" provided
            if (keepRasterPDFResolution == null)
            {
                this.KeepRasterPDFResolution = true;
            }
            else
            {
                this.KeepRasterPDFResolution = keepRasterPDFResolution;
            }
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to be saved as JPEG.
        /// </summary>
        /// <value>Specifies the number of the page, or the range of pages to be saved as JPEG.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies the level of quality to be used for the JPEG compression, from 1 (poorest) to 100 (greatest).
        /// </summary>
        /// <value>Specifies the level of quality to be used for the JPEG compression, from 1 (poorest) to 100 (greatest).</value>
        [DataMember(Name="Quality", EmitDefaultValue=false)]
        public int? Quality { get; set; }

        /// <summary>
        /// Specifies if the encoded JPEG image must be progressive.
        /// </summary>
        /// <value>Specifies if the encoded JPEG image must be progressive.</value>
        [DataMember(Name="Progressive", EmitDefaultValue=false)]
        public bool? Progressive { get; set; }

        /// <summary>
        /// Specifies the resolution to be used for the rendition process.
        /// </summary>
        /// <value>Specifies the resolution to be used for the rendition process.</value>
        [DataMember(Name="Resolution", EmitDefaultValue=false)]
        public float? Resolution { get; set; }

        /// <summary>
        /// Specifies whether the form fields of the PDF shall be rendered.
        /// </summary>
        /// <value>Specifies whether the form fields of the PDF shall be rendered.</value>
        [DataMember(Name="RenderFormFields", EmitDefaultValue=false)]
        public bool? RenderFormFields { get; set; }

        /// <summary>
        /// Specifies if the initial image resolution must be kept in case of raster-pdf processing.
        /// </summary>
        /// <value>Specifies if the initial image resolution must be kept in case of raster-pdf processing.</value>
        [DataMember(Name="KeepRasterPDFResolution", EmitDefaultValue=false)]
        public bool? KeepRasterPDFResolution { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFSaveAsJPEGParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  Quality: ").Append(Quality).Append("\n");
            sb.Append("  Progressive: ").Append(Progressive).Append("\n");
            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
            sb.Append("  RenderFormFields: ").Append(RenderFormFields).Append("\n");
            sb.Append("  KeepRasterPDFResolution: ").Append(KeepRasterPDFResolution).Append("\n");
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
            return this.Equals(input as PDFSaveAsJPEGParameters);
        }

        /// <summary>
        /// Returns true if PDFSaveAsJPEGParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFSaveAsJPEGParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFSaveAsJPEGParameters input)
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
                    this.Quality == input.Quality ||
                    (this.Quality != null &&
                    this.Quality.Equals(input.Quality))
                ) && 
                (
                    this.Progressive == input.Progressive ||
                    (this.Progressive != null &&
                    this.Progressive.Equals(input.Progressive))
                ) && 
                (
                    this.Resolution == input.Resolution ||
                    (this.Resolution != null &&
                    this.Resolution.Equals(input.Resolution))
                ) && 
                (
                    this.RenderFormFields == input.RenderFormFields ||
                    (this.RenderFormFields != null &&
                    this.RenderFormFields.Equals(input.RenderFormFields))
                ) && 
                (
                    this.KeepRasterPDFResolution == input.KeepRasterPDFResolution ||
                    (this.KeepRasterPDFResolution != null &&
                    this.KeepRasterPDFResolution.Equals(input.KeepRasterPDFResolution))
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
                if (this.Quality != null)
                    hashCode = hashCode * 59 + this.Quality.GetHashCode();
                if (this.Progressive != null)
                    hashCode = hashCode * 59 + this.Progressive.GetHashCode();
                if (this.Resolution != null)
                    hashCode = hashCode * 59 + this.Resolution.GetHashCode();
                if (this.RenderFormFields != null)
                    hashCode = hashCode * 59 + this.RenderFormFields.GetHashCode();
                if (this.KeepRasterPDFResolution != null)
                    hashCode = hashCode * 59 + this.KeepRasterPDFResolution.GetHashCode();
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
