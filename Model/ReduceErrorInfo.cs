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
    /// Represents information about an error which caused the failure of a reduce action.
    /// </summary>
    [DataContract]
    public partial class ReduceErrorInfo :  IEquatable<ReduceErrorInfo>, IValidatableObject
    {
        /// <summary>
        /// The error code.
        /// </summary>
        /// <value>The error code.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ErrorCodeEnum
        {
            
            /// <summary>
            /// Enum OK for "OK"
            /// </summary>
            [EnumMember(Value = "OK")]
            OK = 1,
            
            /// <summary>
            /// Enum GetPageImagesCount for "GetPageImagesCount"
            /// </summary>
            [EnumMember(Value = "GetPageImagesCount")]
            GetPageImagesCount = 2,
            
            /// <summary>
            /// Enum MRCPostOperationsFailure for "MRCPostOperationsFailure"
            /// </summary>
            [EnumMember(Value = "MRCPostOperationsFailure")]
            MRCPostOperationsFailure = 3,
            
            /// <summary>
            /// Enum PageConversionFailure for "PageConversionFailure"
            /// </summary>
            [EnumMember(Value = "PageConversionFailure")]
            PageConversionFailure = 4,
            
            /// <summary>
            /// Enum DocumentEncrypted for "DocumentEncrypted"
            /// </summary>
            [EnumMember(Value = "DocumentEncrypted")]
            DocumentEncrypted = 5,
            
            /// <summary>
            /// Enum UnexpectedError for "UnexpectedError"
            /// </summary>
            [EnumMember(Value = "UnexpectedError")]
            UnexpectedError = 6
        }

        /// <summary>
        /// The error code.
        /// </summary>
        /// <value>The error code.</value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public ErrorCodeEnum? ErrorCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReduceErrorInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ReduceErrorInfo()
        {
        }
        

        /// <summary>
        /// The number of the page processed when the error occured.
        /// </summary>
        /// <value>The number of the page processed when the error occured.</value>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; private set; }

        /// <summary>
        /// The error message associated with the error, if any.
        /// </summary>
        /// <value>The error message associated with the error, if any.</value>
        [DataMember(Name="extErrorMessage", EmitDefaultValue=false)]
        public string ExtErrorMessage { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReduceErrorInfo {\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  ExtErrorMessage: ").Append(ExtErrorMessage).Append("\n");
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
            return this.Equals(input as ReduceErrorInfo);
        }

        /// <summary>
        /// Returns true if ReduceErrorInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ReduceErrorInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReduceErrorInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.PageNumber == input.PageNumber ||
                    (this.PageNumber != null &&
                    this.PageNumber.Equals(input.PageNumber))
                ) && 
                (
                    this.ExtErrorMessage == input.ExtErrorMessage ||
                    (this.ExtErrorMessage != null &&
                    this.ExtErrorMessage.Equals(input.ExtErrorMessage))
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
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.PageNumber != null)
                    hashCode = hashCode * 59 + this.PageNumber.GetHashCode();
                if (this.ExtErrorMessage != null)
                    hashCode = hashCode * 59 + this.ExtErrorMessage.GetHashCode();
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