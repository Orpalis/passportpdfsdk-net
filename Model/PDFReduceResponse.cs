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
    /// Represents the response to a reduce action request.
    /// </summary>
    [DataContract]
    public partial class PdfReduceResponse :  IEquatable<PdfReduceResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfReduceResponse" /> class.
        /// </summary>
        public PdfReduceResponse()
        {
        }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="Error")]
        public Error Error { get; set; }

        /// <summary>
        /// Specifies the number of remaining tokens.
        /// </summary>
        [DataMember(Name="RemainingTokens")]
        public long RemainingTokens { get; set; }

        /// <summary>
        /// Gets or Sets ErrorInfo
        /// </summary>
        [DataMember(Name="ErrorInfo")]
        public ReduceErrorInfo ErrorInfo { get; set; }

        /// <summary>
        /// Specifies the different warnings that occured during the process of the reduce action.
        /// </summary>
        [DataMember(Name="WarningsInfo")]
        public List<ReduceWarningInfo> WarningsInfo { get; private set; }

        /// <summary>
        /// Specifies whether content has been removed from the PDF during the process of the reduce action.
        /// </summary>
        [DataMember(Name="ContentRemoved")]
        public bool ContentRemoved { get; private set; }

        /// <summary>
        /// Specifies whether the version of the PDF has changed during the process of the reduce action.
        /// </summary>
        [DataMember(Name="VersionChanged")]
        public bool VersionChanged { get; private set; }

        /// <summary>
        /// Specify the size of the new created document.
        /// </summary>
        [DataMember(Name="NewFileSize")]
        public long NewFileSize { get; private set; }

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
            return Equals(input as PdfReduceResponse);
        }

        /// <summary>
        /// Returns true if PdfReduceResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfReduceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfReduceResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    Error == input.Error ||
                    (Error != null &&
                    Error.Equals(input.Error))
                ) && 
                (
                    RemainingTokens == input.RemainingTokens ||
                    RemainingTokens.Equals(input.RemainingTokens)
                ) && 
                (
                    ErrorInfo == input.ErrorInfo ||
                    (ErrorInfo != null &&
                    ErrorInfo.Equals(input.ErrorInfo))
                ) && 
                (
                    WarningsInfo == input.WarningsInfo ||
                    WarningsInfo != null &&
                    input.WarningsInfo != null &&
                    WarningsInfo.SequenceEqual(input.WarningsInfo)
                ) && 
                (
                    ContentRemoved == input.ContentRemoved ||
                    ContentRemoved.Equals(input.ContentRemoved)
                ) && 
                (
                    VersionChanged == input.VersionChanged ||
                    VersionChanged.Equals(input.VersionChanged)
                ) && 
                (
                    NewFileSize == input.NewFileSize ||
                    NewFileSize.Equals(input.NewFileSize)
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
                if (Error != null)
                    hashCode = hashCode * 59 + Error.GetHashCode();
                hashCode = hashCode * 59 + RemainingTokens.GetHashCode();
                if (ErrorInfo != null)
                    hashCode = hashCode * 59 + ErrorInfo.GetHashCode();
                if (WarningsInfo != null)
                    hashCode = hashCode * 59 + WarningsInfo.GetHashCode();
                hashCode = hashCode * 59 + ContentRemoved.GetHashCode();
                hashCode = hashCode * 59 + VersionChanged.GetHashCode();
                hashCode = hashCode * 59 + NewFileSize.GetHashCode();
                return hashCode;
            }
        }
    }

}
