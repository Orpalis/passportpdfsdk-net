/* 
 * PassportPDF
 *
 * Copyright © 2018 ORPALIS - http://www.orpalis.com
 *
 * OpenAPI spec version: v1
 * Contact: contact@orpalis.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = PassportPDF.Client.SwaggerDateConverter;

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
        /// <param name="FileId">FileId (required).</param>
        /// <param name="Quality">Quality (default to 75).</param>
        /// <param name="Progressive">Progressive (default to false).</param>
        /// <param name="PageRange">PageRange (default to &quot;*&quot;).</param>
        /// <param name="Resolution">Resolution (default to 200.0F).</param>
        /// <param name="RenderFormFields">RenderFormFields.</param>
        /// <param name="KeepRasterPDFResolution">KeepRasterPDFResolution (default to true).</param>
        public PDFSaveAsJPEGParameters(string FileId = default(string), int? Quality = 75, bool? Progressive = false, string PageRange = "*", float? Resolution = 200.0F, bool? RenderFormFields = default(bool?), bool? KeepRasterPDFResolution = true)
        {
            // to ensure "FileId" is required (not null)
            if (FileId == null)
            {
                throw new InvalidDataException("FileId is a required property for PDFSaveAsJPEGParameters and cannot be null");
            }
            else
            {
                this.FileId = FileId;
            }
            // use default value if no "Quality" provided
            if (Quality == null)
            {
                this.Quality = 75;
            }
            else
            {
                this.Quality = Quality;
            }
            // use default value if no "Progressive" provided
            if (Progressive == null)
            {
                this.Progressive = false;
            }
            else
            {
                this.Progressive = Progressive;
            }
            // use default value if no "PageRange" provided
            if (PageRange == null)
            {
                this.PageRange = "*";
            }
            else
            {
                this.PageRange = PageRange;
            }
            // use default value if no "Resolution" provided
            if (Resolution == null)
            {
                this.Resolution = 200.0F;
            }
            else
            {
                this.Resolution = Resolution;
            }
            this.RenderFormFields = RenderFormFields;
            // use default value if no "KeepRasterPDFResolution" provided
            if (KeepRasterPDFResolution == null)
            {
                this.KeepRasterPDFResolution = true;
            }
            else
            {
                this.KeepRasterPDFResolution = KeepRasterPDFResolution;
            }
        }
        
        /// <summary>
        /// Gets or Sets FileId
        /// </summary>
        [DataMember(Name="fileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Gets or Sets Quality
        /// </summary>
        [DataMember(Name="quality", EmitDefaultValue=false)]
        public int? Quality { get; set; }

        /// <summary>
        /// Gets or Sets Progressive
        /// </summary>
        [DataMember(Name="progressive", EmitDefaultValue=false)]
        public bool? Progressive { get; set; }

        /// <summary>
        /// Gets or Sets PageRange
        /// </summary>
        [DataMember(Name="pageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }

        /// <summary>
        /// Gets or Sets Resolution
        /// </summary>
        [DataMember(Name="resolution", EmitDefaultValue=false)]
        public float? Resolution { get; set; }

        /// <summary>
        /// Gets or Sets RenderFormFields
        /// </summary>
        [DataMember(Name="renderFormFields", EmitDefaultValue=false)]
        public bool? RenderFormFields { get; set; }

        /// <summary>
        /// Gets or Sets KeepRasterPDFResolution
        /// </summary>
        [DataMember(Name="keepRasterPDFResolution", EmitDefaultValue=false)]
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
            sb.Append("  Quality: ").Append(Quality).Append("\n");
            sb.Append("  Progressive: ").Append(Progressive).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
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
        public string ToJson()
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
                    this.PageRange == input.PageRange ||
                    (this.PageRange != null &&
                    this.PageRange.Equals(input.PageRange))
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
                if (this.Quality != null)
                    hashCode = hashCode * 59 + this.Quality.GetHashCode();
                if (this.Progressive != null)
                    hashCode = hashCode * 59 + this.Progressive.GetHashCode();
                if (this.PageRange != null)
                    hashCode = hashCode * 59 + this.PageRange.GetHashCode();
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