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
    /// Represents the parameters for a split action.
    /// </summary>
    [DataContract]
    public partial class PdfSplitParameters :  IEquatable<PdfSplitParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfSplitParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfSplitParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfSplitParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="splitMethod">splitMethod (required).</param>
        /// <param name="splitValue">Specifies, respectively for the SplitByPageCount and SplitByFileSize split methods, the number of pages or the maximum size, in kilobytes, of the produced files. (required).</param>
        public PdfSplitParameters(string fileId, PdfSplitMethod splitMethod, int splitValue)
        {
            FileId = fileId;
            SplitMethod = splitMethod;
            SplitValue = splitValue;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Gets or Sets SplitMethod
        /// </summary>
        [DataMember(Name="SplitMethod")]
        public PdfSplitMethod SplitMethod { get; set; }

        /// <summary>
        /// Specifies, respectively for the SplitByPageCount and SplitByFileSize split methods, the number of pages or the maximum size, in kilobytes, of the produced files.
        /// </summary>
        [DataMember(Name="SplitValue")]
        public int SplitValue { get; set; }

        /// <summary>
        /// Specifies whether the file(s) created as a result of the action shall be available for immediate download.
        /// </summary>
        [DataMember(Name="ImmediateDownload")]
        public bool ImmediateDownload { get; set; } = false;

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
            return Equals(input as PdfSplitParameters);
        }

        /// <summary>
        /// Returns true if PdfSplitParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfSplitParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfSplitParameters input)
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
                    SplitMethod == input.SplitMethod ||
                    SplitMethod.Equals(input.SplitMethod)
                ) && 
                (
                    SplitValue == input.SplitValue ||
                    SplitValue.Equals(input.SplitValue)
                ) && 
                (
                    ImmediateDownload == input.ImmediateDownload ||
                    ImmediateDownload.Equals(input.ImmediateDownload)
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
                hashCode = hashCode * 59 + SplitMethod.GetHashCode();
                hashCode = hashCode * 59 + SplitValue.GetHashCode();
                hashCode = hashCode * 59 + ImmediateDownload.GetHashCode();
                return hashCode;
            }
        }
    }

}
