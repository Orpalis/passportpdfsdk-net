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
    /// Represents the parameters for a split action.
    /// </summary>
    [DataContract]
    public partial class PDFSplitParameters :  IEquatable<PDFSplitParameters>, IValidatableObject
    {
        /// <summary>
        /// Specifies the split method to be used.
        /// </summary>
        /// <value>Specifies the split method to be used.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SplitMethodEnum
        {
            /// <summary>
            /// Enum SplitByNumberOfPages for value: SplitByNumberOfPages
            /// </summary>
            [EnumMember(Value = "SplitByNumberOfPages")]
            SplitByNumberOfPages = 1,

            /// <summary>
            /// Enum SplitByFileSize for value: SplitByFileSize
            /// </summary>
            [EnumMember(Value = "SplitByFileSize")]
            SplitByFileSize = 2,

            /// <summary>
            /// Enum SplitByTopLevelBookmarks for value: SplitByTopLevelBookmarks
            /// </summary>
            [EnumMember(Value = "SplitByTopLevelBookmarks")]
            SplitByTopLevelBookmarks = 3

        }

        /// <summary>
        /// Specifies the split method to be used.
        /// </summary>
        /// <value>Specifies the split method to be used.</value>
        [DataMember(Name="SplitMethod", EmitDefaultValue=false)]
        public SplitMethodEnum SplitMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFSplitParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFSplitParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFSplitParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="splitMethod">Specifies the split method to be used. (required) (default to SplitMethodEnum.SplitByNumberOfPages).</param>
        /// <param name="splitValue">Specifies, respectively for the SplitByPageCount and SplitByFileSize split methods, the number of pages or the maximum size, in kilobytes, of the produced files..</param>
        /// <param name="immediateDownload">Specifies whether the file(s) created as a result of the action shall be available for immediate download..</param>
        public PDFSplitParameters(string fileId = default(string), SplitMethodEnum splitMethod = SplitMethodEnum.SplitByNumberOfPages, int? splitValue = default(int?), bool? immediateDownload = default(bool?))
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for PDFSplitParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            
            // to ensure "splitMethod" is required (not null)
            if (splitMethod == null)
            {
                throw new InvalidDataException("splitMethod is a required property for PDFSplitParameters and cannot be null");
            }
            else
            {
                this.SplitMethod = splitMethod;
            }
            
            this.SplitValue = splitValue;
            this.ImmediateDownload = immediateDownload;
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }


        /// <summary>
        /// Specifies, respectively for the SplitByPageCount and SplitByFileSize split methods, the number of pages or the maximum size, in kilobytes, of the produced files.
        /// </summary>
        /// <value>Specifies, respectively for the SplitByPageCount and SplitByFileSize split methods, the number of pages or the maximum size, in kilobytes, of the produced files.</value>
        [DataMember(Name="SplitValue", EmitDefaultValue=false)]
        public int? SplitValue { get; set; }

        /// <summary>
        /// Specifies whether the file(s) created as a result of the action shall be available for immediate download.
        /// </summary>
        /// <value>Specifies whether the file(s) created as a result of the action shall be available for immediate download.</value>
        [DataMember(Name="ImmediateDownload", EmitDefaultValue=false)]
        public bool? ImmediateDownload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFSplitParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  SplitMethod: ").Append(SplitMethod).Append("\n");
            sb.Append("  SplitValue: ").Append(SplitValue).Append("\n");
            sb.Append("  ImmediateDownload: ").Append(ImmediateDownload).Append("\n");
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
            return this.Equals(input as PDFSplitParameters);
        }

        /// <summary>
        /// Returns true if PDFSplitParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFSplitParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFSplitParameters input)
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
                    this.SplitMethod == input.SplitMethod ||
                    (this.SplitMethod != null &&
                    this.SplitMethod.Equals(input.SplitMethod))
                ) && 
                (
                    this.SplitValue == input.SplitValue ||
                    (this.SplitValue != null &&
                    this.SplitValue.Equals(input.SplitValue))
                ) && 
                (
                    this.ImmediateDownload == input.ImmediateDownload ||
                    (this.ImmediateDownload != null &&
                    this.ImmediateDownload.Equals(input.ImmediateDownload))
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
                if (this.SplitMethod != null)
                    hashCode = hashCode * 59 + this.SplitMethod.GetHashCode();
                if (this.SplitValue != null)
                    hashCode = hashCode * 59 + this.SplitValue.GetHashCode();
                if (this.ImmediateDownload != null)
                    hashCode = hashCode * 59 + this.ImmediateDownload.GetHashCode();
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
