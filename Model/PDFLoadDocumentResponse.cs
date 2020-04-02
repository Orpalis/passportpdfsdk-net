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
    /// Represents the response to a load document action request.
    /// </summary>
    [DataContract]
    public partial class PdfLoadDocumentResponse :  IEquatable<PdfLoadDocumentResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfLoadDocumentResponse" /> class.
        /// </summary>
        public PdfLoadDocumentResponse()
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
        /// Specifies the file identifier of the loaded document.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; private set; }

        /// <summary>
        /// Specifies the number of pages into the loaded document.
        /// </summary>
        [DataMember(Name="PageCount")]
        public int PageCount { get; private set; }

        /// <summary>
        /// Gets or Sets Encryption
        /// </summary>
        [DataMember(Name="Encryption")]
        public EncryptionAlgorithm Encryption { get; set; }

        /// <summary>
        /// Specifies if a password will be subsequently required to open the document.  Password can be provided using the SetPassword action / method.
        /// </summary>
        [DataMember(Name="PasswordIsRequired")]
        public bool PasswordIsRequired { get; private set; }

        /// <summary>
        /// Specifies the data of a thumbnail from the first page of the document, in PNG format. Only applicable if the GetPreview field of the request has been set to true.
        /// </summary>
        [DataMember(Name="ThumbnailData")]
        public byte[] ThumbnailData { get; private set; }

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
            return Equals(input as PdfLoadDocumentResponse);
        }

        /// <summary>
        /// Returns true if PdfLoadDocumentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfLoadDocumentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfLoadDocumentResponse input)
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
                    FileId == input.FileId ||
                    (FileId != null &&
                    FileId.Equals(input.FileId))
                ) && 
                (
                    PageCount == input.PageCount ||
                    PageCount.Equals(input.PageCount)
                ) && 
                (
                    Encryption == input.Encryption ||
                    Encryption.Equals(input.Encryption)
                ) && 
                (
                    PasswordIsRequired == input.PasswordIsRequired ||
                    PasswordIsRequired.Equals(input.PasswordIsRequired)
                ) && 
                (
                    ThumbnailData == input.ThumbnailData ||
                    (ThumbnailData != null &&
                    ThumbnailData.Equals(input.ThumbnailData))
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
                if (FileId != null)
                    hashCode = hashCode * 59 + FileId.GetHashCode();
                hashCode = hashCode * 59 + PageCount.GetHashCode();
                hashCode = hashCode * 59 + Encryption.GetHashCode();
                hashCode = hashCode * 59 + PasswordIsRequired.GetHashCode();
                if (ThumbnailData != null)
                    hashCode = hashCode * 59 + ThumbnailData.GetHashCode();
                return hashCode;
            }
        }
    }

}
