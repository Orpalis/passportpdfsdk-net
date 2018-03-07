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
    /// Represents the response to a reduce action request.
    /// </summary>
    [DataContract]
    public partial class PDFReduceResponse :  IEquatable<PDFReduceResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFReduceResponse" /> class.
        /// </summary>
        /// <param name="Error">Error.</param>
        /// <param name="RemainingTokens">RemainingTokens.</param>
        /// <param name="ErrorInfo">Specifies further information about the error causing the reduce action failure, if any..</param>
        /// <param name="WarningsInfo">Specifies the different warnings that occured during the process of the reduce action..</param>
        public PDFReduceResponse(Error Error = default(Error), long? RemainingTokens = default(long?), ReduceErrorInfo ErrorInfo = default(ReduceErrorInfo), List<ReduceWarningInfo> WarningsInfo = default(List<ReduceWarningInfo>))
        {
            this.Error = Error;
            this.RemainingTokens = RemainingTokens;
            this.ErrorInfo = ErrorInfo;
            this.WarningsInfo = WarningsInfo;
        }
        
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public Error Error { get; set; }

        /// <summary>
        /// Gets or Sets RemainingTokens
        /// </summary>
        [DataMember(Name="remainingTokens", EmitDefaultValue=false)]
        public long? RemainingTokens { get; set; }

        /// <summary>
        /// Specifies further information about the error causing the reduce action failure, if any.
        /// </summary>
        /// <value>Specifies further information about the error causing the reduce action failure, if any.</value>
        [DataMember(Name="errorInfo", EmitDefaultValue=false)]
        public ReduceErrorInfo ErrorInfo { get; set; }

        /// <summary>
        /// Specifies the different warnings that occured during the process of the reduce action.
        /// </summary>
        /// <value>Specifies the different warnings that occured during the process of the reduce action.</value>
        [DataMember(Name="warningsInfo", EmitDefaultValue=false)]
        public List<ReduceWarningInfo> WarningsInfo { get; set; }

        /// <summary>
        /// Specifies whether content has been removed from the PDF during the process of the reduce action.
        /// </summary>
        /// <value>Specifies whether content has been removed from the PDF during the process of the reduce action.</value>
        [DataMember(Name="contentRemoved", EmitDefaultValue=false)]
        public bool? ContentRemoved { get; private set; }

        /// <summary>
        /// Specifies whether the version of the PDF has changed during the process of the reduce action.
        /// </summary>
        /// <value>Specifies whether the version of the PDF has changed during the process of the reduce action.</value>
        [DataMember(Name="versionChanged", EmitDefaultValue=false)]
        public bool? VersionChanged { get; private set; }

        /// <summary>
        /// Specify the size of the new created document.
        /// </summary>
        /// <value>Specify the size of the new created document.</value>
        [DataMember(Name="newFileSize", EmitDefaultValue=false)]
        public long? NewFileSize { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFReduceResponse {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  RemainingTokens: ").Append(RemainingTokens).Append("\n");
            sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
            sb.Append("  WarningsInfo: ").Append(WarningsInfo).Append("\n");
            sb.Append("  ContentRemoved: ").Append(ContentRemoved).Append("\n");
            sb.Append("  VersionChanged: ").Append(VersionChanged).Append("\n");
            sb.Append("  NewFileSize: ").Append(NewFileSize).Append("\n");
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
            return this.Equals(input as PDFReduceResponse);
        }

        /// <summary>
        /// Returns true if PDFReduceResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFReduceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFReduceResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.RemainingTokens == input.RemainingTokens ||
                    (this.RemainingTokens != null &&
                    this.RemainingTokens.Equals(input.RemainingTokens))
                ) && 
                (
                    this.ErrorInfo == input.ErrorInfo ||
                    (this.ErrorInfo != null &&
                    this.ErrorInfo.Equals(input.ErrorInfo))
                ) && 
                (
                    this.WarningsInfo == input.WarningsInfo ||
                    this.WarningsInfo != null &&
                    this.WarningsInfo.SequenceEqual(input.WarningsInfo)
                ) && 
                (
                    this.ContentRemoved == input.ContentRemoved ||
                    (this.ContentRemoved != null &&
                    this.ContentRemoved.Equals(input.ContentRemoved))
                ) && 
                (
                    this.VersionChanged == input.VersionChanged ||
                    (this.VersionChanged != null &&
                    this.VersionChanged.Equals(input.VersionChanged))
                ) && 
                (
                    this.NewFileSize == input.NewFileSize ||
                    (this.NewFileSize != null &&
                    this.NewFileSize.Equals(input.NewFileSize))
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
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.RemainingTokens != null)
                    hashCode = hashCode * 59 + this.RemainingTokens.GetHashCode();
                if (this.ErrorInfo != null)
                    hashCode = hashCode * 59 + this.ErrorInfo.GetHashCode();
                if (this.WarningsInfo != null)
                    hashCode = hashCode * 59 + this.WarningsInfo.GetHashCode();
                if (this.ContentRemoved != null)
                    hashCode = hashCode * 59 + this.ContentRemoved.GetHashCode();
                if (this.VersionChanged != null)
                    hashCode = hashCode * 59 + this.VersionChanged.GetHashCode();
                if (this.NewFileSize != null)
                    hashCode = hashCode * 59 + this.NewFileSize.GetHashCode();
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
