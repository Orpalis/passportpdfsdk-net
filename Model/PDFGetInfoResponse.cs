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
    /// Represents the response to a get info action request.
    /// </summary>
    [DataContract]
    public partial class PdfGetInfoResponse :  IEquatable<PdfGetInfoResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfGetInfoResponse" /> class.
        /// </summary>
        public PdfGetInfoResponse()
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
        /// Specifies the number of pages of the PDF.
        /// </summary>
        [DataMember(Name="PageCount")]
        public int PageCount { get; private set; }

        /// <summary>
        /// Specifies the version of the PDF.
        /// </summary>
        [DataMember(Name="Version")]
        public string Version { get; private set; }

        /// <summary>
        /// Specifies the author name specified within the PDF, if any.
        /// </summary>
        [DataMember(Name="Author")]
        public string Author { get; private set; }

        /// <summary>
        /// Specifies the document title specified within the PDF, if any.
        /// </summary>
        [DataMember(Name="Title")]
        public string Title { get; private set; }

        /// <summary>
        /// Specifies the document subject specified within the PDF, if any.
        /// </summary>
        [DataMember(Name="Subject")]
        public string Subject { get; private set; }

        /// <summary>
        /// Specifies the producer name specified within the PDF, if any.
        /// </summary>
        [DataMember(Name="Producer")]
        public string Producer { get; private set; }

        /// <summary>
        /// Specifies the metadata contained within the PDF, if any.
        /// </summary>
        [DataMember(Name="Metadata")]
        public string Metadata { get; private set; }

        /// <summary>
        /// Specifies the keywords associated with the PDF, if any.
        /// </summary>
        [DataMember(Name="Keywords")]
        public string Keywords { get; private set; }

        /// <summary>
        /// Specifies if the PDF is protected with a user password.
        /// </summary>
        [DataMember(Name="HasUserPassword")]
        public bool HasUserPassword { get; private set; }

        /// <summary>
        /// Specifies if the PDF is protected with a owner password.
        /// </summary>
        [DataMember(Name="HasOwnerPassword")]
        public bool HasOwnerPassword { get; private set; }

        /// <summary>
        /// Gets or Sets Encryption
        /// </summary>
        [DataMember(Name="Encryption")]
        public EncryptionAlgorithm Encryption { get; set; }

        /// <summary>
        /// Specifies if the user is allowed to print the document, but possibly not at the highest quality level.
        /// </summary>
        [DataMember(Name="CanPrint")]
        public bool CanPrint { get; private set; }

        /// <summary>
        /// Specifies if the user is allowed to copy or extract text and graphics from the document.
        /// </summary>
        [DataMember(Name="CanCopy")]
        public bool CanCopy { get; private set; }

        /// <summary>
        /// Specifies if the user is allowed to modify the document.
        /// </summary>
        [DataMember(Name="CanModify")]
        public bool CanModify { get; private set; }

        /// <summary>
        /// Specifies if the user is allowed to add annotations.
        /// </summary>
        [DataMember(Name="CanAddNotes")]
        public bool CanAddNotes { get; private set; }

        /// <summary>
        /// Specifies if the user is allowed to fill-in form fields.
        /// </summary>
        [DataMember(Name="CanFillFields")]
        public bool CanFillFields { get; private set; }

        /// <summary>
        /// Specifies if the user is allowed for copying or extracting for use with accessibility features.
        /// </summary>
        [DataMember(Name="CanCopyAccess")]
        public bool CanCopyAccess { get; private set; }

        /// <summary>
        /// Specifies if the user is allowed to assemble the document.
        /// </summary>
        [DataMember(Name="CanAssemble")]
        public bool CanAssemble { get; private set; }

        /// <summary>
        /// Specifies if the user is allowed to print the document with high resolution.
        /// </summary>
        [DataMember(Name="CanPrintFull")]
        public bool CanPrintFull { get; private set; }

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
            return Equals(input as PdfGetInfoResponse);
        }

        /// <summary>
        /// Returns true if PdfGetInfoResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfGetInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfGetInfoResponse input)
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
                    PageCount == input.PageCount ||
                    PageCount.Equals(input.PageCount)
                ) && 
                (
                    Version == input.Version ||
                    (Version != null &&
                    Version.Equals(input.Version))
                ) && 
                (
                    Author == input.Author ||
                    (Author != null &&
                    Author.Equals(input.Author))
                ) && 
                (
                    Title == input.Title ||
                    (Title != null &&
                    Title.Equals(input.Title))
                ) && 
                (
                    Subject == input.Subject ||
                    (Subject != null &&
                    Subject.Equals(input.Subject))
                ) && 
                (
                    Producer == input.Producer ||
                    (Producer != null &&
                    Producer.Equals(input.Producer))
                ) && 
                (
                    Metadata == input.Metadata ||
                    (Metadata != null &&
                    Metadata.Equals(input.Metadata))
                ) && 
                (
                    Keywords == input.Keywords ||
                    (Keywords != null &&
                    Keywords.Equals(input.Keywords))
                ) && 
                (
                    HasUserPassword == input.HasUserPassword ||
                    HasUserPassword.Equals(input.HasUserPassword)
                ) && 
                (
                    HasOwnerPassword == input.HasOwnerPassword ||
                    HasOwnerPassword.Equals(input.HasOwnerPassword)
                ) && 
                (
                    Encryption == input.Encryption ||
                    Encryption.Equals(input.Encryption)
                ) && 
                (
                    CanPrint == input.CanPrint ||
                    CanPrint.Equals(input.CanPrint)
                ) && 
                (
                    CanCopy == input.CanCopy ||
                    CanCopy.Equals(input.CanCopy)
                ) && 
                (
                    CanModify == input.CanModify ||
                    CanModify.Equals(input.CanModify)
                ) && 
                (
                    CanAddNotes == input.CanAddNotes ||
                    CanAddNotes.Equals(input.CanAddNotes)
                ) && 
                (
                    CanFillFields == input.CanFillFields ||
                    CanFillFields.Equals(input.CanFillFields)
                ) && 
                (
                    CanCopyAccess == input.CanCopyAccess ||
                    CanCopyAccess.Equals(input.CanCopyAccess)
                ) && 
                (
                    CanAssemble == input.CanAssemble ||
                    CanAssemble.Equals(input.CanAssemble)
                ) && 
                (
                    CanPrintFull == input.CanPrintFull ||
                    CanPrintFull.Equals(input.CanPrintFull)
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
                hashCode = hashCode * 59 + PageCount.GetHashCode();
                if (Version != null)
                    hashCode = hashCode * 59 + Version.GetHashCode();
                if (Author != null)
                    hashCode = hashCode * 59 + Author.GetHashCode();
                if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                if (Subject != null)
                    hashCode = hashCode * 59 + Subject.GetHashCode();
                if (Producer != null)
                    hashCode = hashCode * 59 + Producer.GetHashCode();
                if (Metadata != null)
                    hashCode = hashCode * 59 + Metadata.GetHashCode();
                if (Keywords != null)
                    hashCode = hashCode * 59 + Keywords.GetHashCode();
                hashCode = hashCode * 59 + HasUserPassword.GetHashCode();
                hashCode = hashCode * 59 + HasOwnerPassword.GetHashCode();
                hashCode = hashCode * 59 + Encryption.GetHashCode();
                hashCode = hashCode * 59 + CanPrint.GetHashCode();
                hashCode = hashCode * 59 + CanCopy.GetHashCode();
                hashCode = hashCode * 59 + CanModify.GetHashCode();
                hashCode = hashCode * 59 + CanAddNotes.GetHashCode();
                hashCode = hashCode * 59 + CanFillFields.GetHashCode();
                hashCode = hashCode * 59 + CanCopyAccess.GetHashCode();
                hashCode = hashCode * 59 + CanAssemble.GetHashCode();
                hashCode = hashCode * 59 + CanPrintFull.GetHashCode();
                return hashCode;
            }
        }
    }

}
