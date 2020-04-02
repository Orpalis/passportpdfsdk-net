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
    /// Represents the parameters for a digital signature action.
    /// </summary>
    [DataContract]
    public partial class PdfDigiSignParameters :  IEquatable<PdfDigiSignParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfDigiSignParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfDigiSignParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfDigiSignParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="certificateData">Specifies the data of the digital PKCS#12 certificate file. (required).</param>
        /// <param name="certificatePassword">Specifies the certificate password. (required).</param>
        public PdfDigiSignParameters(string fileId, byte[] certificateData, string certificatePassword)
        {
            FileId = fileId;
            CertificateData = certificateData;
            CertificatePassword = certificatePassword;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the data of the digital PKCS#12 certificate file.
        /// </summary>
        [DataMember(Name="CertificateData")]
        public byte[] CertificateData { get; set; }

        /// <summary>
        /// Specifies the certificate password.
        /// </summary>
        [DataMember(Name="CertificatePassword")]
        public string CertificatePassword { get; set; }

        /// <summary>
        /// Gets or Sets SignatureMode
        /// </summary>
        [DataMember(Name="SignatureMode")]
        public SignatureMode SignatureMode { get; set; }

        /// <summary>
        /// Gets or Sets SignatureCertificationLevel
        /// </summary>
        [DataMember(Name="SignatureCertificationLevel")]
        public SignatureCertificationLevel SignatureCertificationLevel { get; set; }

        /// <summary>
        /// Gets or Sets SignatureHashAlgorithm
        /// </summary>
        [DataMember(Name="SignatureHashAlgorithm")]
        public SignatureHash SignatureHashAlgorithm { get; set; }

        /// <summary>
        /// Specifies the name of the signer.
        /// </summary>
        [DataMember(Name="SignerName")]
        public string SignerName { get; set; } = "PassportPDF";

        /// <summary>
        /// Specifies the reason of the signature.
        /// </summary>
        [DataMember(Name="Reason")]
        public string Reason { get; set; } = "";

        /// <summary>
        /// Specifies the location where the signature is applied.
        /// </summary>
        [DataMember(Name="Location")]
        public string Location { get; set; } = "";

        /// <summary>
        /// Specifies contact information about the signer.
        /// </summary>
        [DataMember(Name="ContactInfo")]
        public string ContactInfo { get; set; } = "";

        /// <summary>
        /// Specifies the URL of the server responsible of providing a time stamp.
        /// </summary>
        [DataMember(Name="TimeStampURL")]
        public string TimeStampURL { get; set; } = "";

        /// <summary>
        /// Specifies the optional user name associated with the time stamp server.
        /// </summary>
        [DataMember(Name="TimeStampUserName")]
        public string TimeStampUserName { get; set; } = "";

        /// <summary>
        /// Specifies the optional password associated with the time stamp server.
        /// </summary>
        [DataMember(Name="TimeStampPassword")]
        public string TimeStampPassword { get; set; } = "";

        /// <summary>
        /// Specifies whether the signed PDF shall be linearized.
        /// </summary>
        [DataMember(Name="Linearize")]
        public bool Linearize { get; set; } = false;

        /// <summary>
        /// Specifies whether the signature shall be drawn on the document.
        /// </summary>
        [DataMember(Name="DrawSignature")]
        public bool DrawSignature { get; set; } = false;

        /// <summary>
        /// Specifies the number of the page on which the signature shall be drawn.
        /// </summary>
        [DataMember(Name="PageNumber")]
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// Specifies whether a validation mark shall be drawn with the signature.
        /// </summary>
        [DataMember(Name="ShowValidationMark")]
        public bool ShowValidationMark { get; set; } = false;

        /// <summary>
        /// Specifies the data of the image to be drawn at the signature location.
        /// </summary>
        [DataMember(Name="ImageData")]
        public byte[] ImageData { get; set; }

        /// <summary>
        /// Gets or Sets SignatureLayout
        /// </summary>
        [DataMember(Name="SignatureLayout")]
        public DrawableContentLayoutParameters SignatureLayout { get; set; }

        /// <summary>
        /// Gets or Sets SignatureText
        /// </summary>
        [DataMember(Name="SignatureText")]
        public PdfAlignedTextParameters SignatureText { get; set; }

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
            return Equals(input as PdfDigiSignParameters);
        }

        /// <summary>
        /// Returns true if PdfDigiSignParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfDigiSignParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfDigiSignParameters input)
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
                    CertificateData == input.CertificateData ||
                    (CertificateData != null &&
                    CertificateData.Equals(input.CertificateData))
                ) && 
                (
                    CertificatePassword == input.CertificatePassword ||
                    (CertificatePassword != null &&
                    CertificatePassword.Equals(input.CertificatePassword))
                ) && 
                (
                    SignatureMode == input.SignatureMode ||
                    SignatureMode.Equals(input.SignatureMode)
                ) && 
                (
                    SignatureCertificationLevel == input.SignatureCertificationLevel ||
                    SignatureCertificationLevel.Equals(input.SignatureCertificationLevel)
                ) && 
                (
                    SignatureHashAlgorithm == input.SignatureHashAlgorithm ||
                    SignatureHashAlgorithm.Equals(input.SignatureHashAlgorithm)
                ) && 
                (
                    SignerName == input.SignerName ||
                    (SignerName != null &&
                    SignerName.Equals(input.SignerName))
                ) && 
                (
                    Reason == input.Reason ||
                    (Reason != null &&
                    Reason.Equals(input.Reason))
                ) && 
                (
                    Location == input.Location ||
                    (Location != null &&
                    Location.Equals(input.Location))
                ) && 
                (
                    ContactInfo == input.ContactInfo ||
                    (ContactInfo != null &&
                    ContactInfo.Equals(input.ContactInfo))
                ) && 
                (
                    TimeStampURL == input.TimeStampURL ||
                    (TimeStampURL != null &&
                    TimeStampURL.Equals(input.TimeStampURL))
                ) && 
                (
                    TimeStampUserName == input.TimeStampUserName ||
                    (TimeStampUserName != null &&
                    TimeStampUserName.Equals(input.TimeStampUserName))
                ) && 
                (
                    TimeStampPassword == input.TimeStampPassword ||
                    (TimeStampPassword != null &&
                    TimeStampPassword.Equals(input.TimeStampPassword))
                ) && 
                (
                    Linearize == input.Linearize ||
                    Linearize.Equals(input.Linearize)
                ) && 
                (
                    DrawSignature == input.DrawSignature ||
                    DrawSignature.Equals(input.DrawSignature)
                ) && 
                (
                    PageNumber == input.PageNumber ||
                    PageNumber.Equals(input.PageNumber)
                ) && 
                (
                    ShowValidationMark == input.ShowValidationMark ||
                    ShowValidationMark.Equals(input.ShowValidationMark)
                ) && 
                (
                    ImageData == input.ImageData ||
                    (ImageData != null &&
                    ImageData.Equals(input.ImageData))
                ) && 
                (
                    SignatureLayout == input.SignatureLayout ||
                    (SignatureLayout != null &&
                    SignatureLayout.Equals(input.SignatureLayout))
                ) && 
                (
                    SignatureText == input.SignatureText ||
                    (SignatureText != null &&
                    SignatureText.Equals(input.SignatureText))
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
                if (CertificateData != null)
                    hashCode = hashCode * 59 + CertificateData.GetHashCode();
                if (CertificatePassword != null)
                    hashCode = hashCode * 59 + CertificatePassword.GetHashCode();
                hashCode = hashCode * 59 + SignatureMode.GetHashCode();
                hashCode = hashCode * 59 + SignatureCertificationLevel.GetHashCode();
                hashCode = hashCode * 59 + SignatureHashAlgorithm.GetHashCode();
                if (SignerName != null)
                    hashCode = hashCode * 59 + SignerName.GetHashCode();
                if (Reason != null)
                    hashCode = hashCode * 59 + Reason.GetHashCode();
                if (Location != null)
                    hashCode = hashCode * 59 + Location.GetHashCode();
                if (ContactInfo != null)
                    hashCode = hashCode * 59 + ContactInfo.GetHashCode();
                if (TimeStampURL != null)
                    hashCode = hashCode * 59 + TimeStampURL.GetHashCode();
                if (TimeStampUserName != null)
                    hashCode = hashCode * 59 + TimeStampUserName.GetHashCode();
                if (TimeStampPassword != null)
                    hashCode = hashCode * 59 + TimeStampPassword.GetHashCode();
                hashCode = hashCode * 59 + Linearize.GetHashCode();
                hashCode = hashCode * 59 + DrawSignature.GetHashCode();
                hashCode = hashCode * 59 + PageNumber.GetHashCode();
                hashCode = hashCode * 59 + ShowValidationMark.GetHashCode();
                if (ImageData != null)
                    hashCode = hashCode * 59 + ImageData.GetHashCode();
                if (SignatureLayout != null)
                    hashCode = hashCode * 59 + SignatureLayout.GetHashCode();
                if (SignatureText != null)
                    hashCode = hashCode * 59 + SignatureText.GetHashCode();
                return hashCode;
            }
        }
    }

}
