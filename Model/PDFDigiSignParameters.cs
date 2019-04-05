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
    /// Represents the parameters for a digital signature action.
    /// </summary>
    [DataContract]
    public partial class PDFDigiSignParameters :  IEquatable<PDFDigiSignParameters>, IValidatableObject
    {
        /// <summary>
        /// Specifies the mode of the signature.
        /// </summary>
        /// <value>Specifies the mode of the signature.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SignatureModeEnum
        {
            /// <summary>
            /// Enum AdobePPKMS for value: AdobePPKMS
            /// </summary>
            [EnumMember(Value = "AdobePPKMS")]
            AdobePPKMS = 1,

            /// <summary>
            /// Enum AdobePPKLite for value: AdobePPKLite
            /// </summary>
            [EnumMember(Value = "AdobePPKLite")]
            AdobePPKLite = 2,

            /// <summary>
            /// Enum AdobeCADES for value: AdobeCADES
            /// </summary>
            [EnumMember(Value = "AdobeCADES")]
            AdobeCADES = 3

        }

        /// <summary>
        /// Specifies the mode of the signature.
        /// </summary>
        /// <value>Specifies the mode of the signature.</value>
        [DataMember(Name="SignatureMode", EmitDefaultValue=false)]
        public SignatureModeEnum? SignatureMode { get; set; }
        /// <summary>
        /// Specifies the certification level of the singature.
        /// </summary>
        /// <value>Specifies the certification level of the singature.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SignatureCertificationLevelEnum
        {
            /// <summary>
            /// Enum NotCertified for value: NotCertified
            /// </summary>
            [EnumMember(Value = "NotCertified")]
            NotCertified = 1,

            /// <summary>
            /// Enum NoChanges for value: NoChanges
            /// </summary>
            [EnumMember(Value = "NoChanges")]
            NoChanges = 2,

            /// <summary>
            /// Enum FormFilling for value: FormFilling
            /// </summary>
            [EnumMember(Value = "FormFilling")]
            FormFilling = 3,

            /// <summary>
            /// Enum FormFillingAndAnnotations for value: FormFillingAndAnnotations
            /// </summary>
            [EnumMember(Value = "FormFillingAndAnnotations")]
            FormFillingAndAnnotations = 4

        }

        /// <summary>
        /// Specifies the certification level of the singature.
        /// </summary>
        /// <value>Specifies the certification level of the singature.</value>
        [DataMember(Name="SignatureCertificationLevel", EmitDefaultValue=false)]
        public SignatureCertificationLevelEnum? SignatureCertificationLevel { get; set; }
        /// <summary>
        /// Specifies the algorithm to be used for the signature.
        /// </summary>
        /// <value>Specifies the algorithm to be used for the signature.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SignatureHashAlgorithmEnum
        {
            /// <summary>
            /// Enum SHA1 for value: SHA1
            /// </summary>
            [EnumMember(Value = "SHA1")]
            SHA1 = 1,

            /// <summary>
            /// Enum SHA256 for value: SHA256
            /// </summary>
            [EnumMember(Value = "SHA256")]
            SHA256 = 2,

            /// <summary>
            /// Enum SHA512 for value: SHA512
            /// </summary>
            [EnumMember(Value = "SHA512")]
            SHA512 = 3,

            /// <summary>
            /// Enum SHA224 for value: SHA224
            /// </summary>
            [EnumMember(Value = "SHA224")]
            SHA224 = 4,

            /// <summary>
            /// Enum SHA384 for value: SHA384
            /// </summary>
            [EnumMember(Value = "SHA384")]
            SHA384 = 5

        }

        /// <summary>
        /// Specifies the algorithm to be used for the signature.
        /// </summary>
        /// <value>Specifies the algorithm to be used for the signature.</value>
        [DataMember(Name="SignatureHashAlgorithm", EmitDefaultValue=false)]
        public SignatureHashAlgorithmEnum? SignatureHashAlgorithm { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFDigiSignParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFDigiSignParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFDigiSignParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="certificateData">Specifies the data of the digital PKCS#12 certificate file. (required).</param>
        /// <param name="certificatePassword">Specifies the certificate password. (required).</param>
        /// <param name="signatureMode">Specifies the mode of the signature. (default to SignatureModeEnum.AdobePPKMS).</param>
        /// <param name="signatureCertificationLevel">Specifies the certification level of the singature. (default to SignatureCertificationLevelEnum.NotCertified).</param>
        /// <param name="signatureHashAlgorithm">Specifies the algorithm to be used for the signature. (default to SignatureHashAlgorithmEnum.SHA256).</param>
        /// <param name="signerName">Specifies the name of the signer. (default to &quot;PassportPDF&quot;).</param>
        /// <param name="reason">Specifies the reason of the signature..</param>
        /// <param name="location">Specifies the location where the signature is applied..</param>
        /// <param name="contactInfo">Specifies contact information about the signer..</param>
        /// <param name="timeStampURL">Specifies the URL of the server responsible of providing a time stamp..</param>
        /// <param name="timeStampUserName">Specifies the optional user name associated with the time stamp server..</param>
        /// <param name="timeStampPassword">Specifies the optional password associated with the time stamp server..</param>
        /// <param name="linearize">Specifies whether the signed PDF shall be linearized..</param>
        /// <param name="drawSignature">Specifies whether the signature shall be drawn on the document..</param>
        /// <param name="pageNumber">Specifies the number of the page on which the signature shall be drawn. (default to 1).</param>
        /// <param name="showValidationMark">Specifies whether a validation mark shall be drawn with the signature..</param>
        /// <param name="imageData">Specifies the data of the image to be drawn at the signature location..</param>
        /// <param name="signatureLayout">signatureLayout.</param>
        /// <param name="signatureText">signatureText.</param>
        public PDFDigiSignParameters(string fileId = default(string), byte[] certificateData = default(byte[]), string certificatePassword = default(string), SignatureModeEnum? signatureMode = SignatureModeEnum.AdobePPKMS, SignatureCertificationLevelEnum? signatureCertificationLevel = SignatureCertificationLevelEnum.NotCertified, SignatureHashAlgorithmEnum? signatureHashAlgorithm = SignatureHashAlgorithmEnum.SHA256, string signerName = "PassportPDF", string reason = default(string), string location = default(string), string contactInfo = default(string), string timeStampURL = default(string), string timeStampUserName = default(string), string timeStampPassword = default(string), bool? linearize = default(bool?), bool? drawSignature = default(bool?), int? pageNumber = 1, bool? showValidationMark = default(bool?), byte[] imageData = default(byte[]), DrawableContentLayoutParameters signatureLayout = default(DrawableContentLayoutParameters), PDFAlignedTextParameters signatureText = default(PDFAlignedTextParameters))
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for PDFDigiSignParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            // to ensure "certificateData" is required (not null)
            if (certificateData == null)
            {
                throw new InvalidDataException("certificateData is a required property for PDFDigiSignParameters and cannot be null");
            }
            else
            {
                this.CertificateData = certificateData;
            }
            // to ensure "certificatePassword" is required (not null)
            if (certificatePassword == null)
            {
                throw new InvalidDataException("certificatePassword is a required property for PDFDigiSignParameters and cannot be null");
            }
            else
            {
                this.CertificatePassword = certificatePassword;
            }
            // use default value if no "signatureMode" provided
            if (signatureMode == null)
            {
                this.SignatureMode = SignatureModeEnum.AdobePPKMS;
            }
            else
            {
                this.SignatureMode = signatureMode;
            }
            // use default value if no "signatureCertificationLevel" provided
            if (signatureCertificationLevel == null)
            {
                this.SignatureCertificationLevel = SignatureCertificationLevelEnum.NotCertified;
            }
            else
            {
                this.SignatureCertificationLevel = signatureCertificationLevel;
            }
            // use default value if no "signatureHashAlgorithm" provided
            if (signatureHashAlgorithm == null)
            {
                this.SignatureHashAlgorithm = SignatureHashAlgorithmEnum.SHA256;
            }
            else
            {
                this.SignatureHashAlgorithm = signatureHashAlgorithm;
            }
            // use default value if no "signerName" provided
            if (signerName == null)
            {
                this.SignerName = "PassportPDF";
            }
            else
            {
                this.SignerName = signerName;
            }
            this.Reason = reason;
            this.Location = location;
            this.ContactInfo = contactInfo;
            this.TimeStampURL = timeStampURL;
            this.TimeStampUserName = timeStampUserName;
            this.TimeStampPassword = timeStampPassword;
            this.Linearize = linearize;
            this.DrawSignature = drawSignature;
            // use default value if no "pageNumber" provided
            if (pageNumber == null)
            {
                this.PageNumber = 1;
            }
            else
            {
                this.PageNumber = pageNumber;
            }
            this.ShowValidationMark = showValidationMark;
            this.ImageData = imageData;
            this.SignatureLayout = signatureLayout;
            this.SignatureText = signatureText;
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the data of the digital PKCS#12 certificate file.
        /// </summary>
        /// <value>Specifies the data of the digital PKCS#12 certificate file.</value>
        [DataMember(Name="CertificateData", EmitDefaultValue=false)]
        public byte[] CertificateData { get; set; }

        /// <summary>
        /// Specifies the certificate password.
        /// </summary>
        /// <value>Specifies the certificate password.</value>
        [DataMember(Name="CertificatePassword", EmitDefaultValue=false)]
        public string CertificatePassword { get; set; }




        /// <summary>
        /// Specifies the name of the signer.
        /// </summary>
        /// <value>Specifies the name of the signer.</value>
        [DataMember(Name="SignerName", EmitDefaultValue=false)]
        public string SignerName { get; set; }

        /// <summary>
        /// Specifies the reason of the signature.
        /// </summary>
        /// <value>Specifies the reason of the signature.</value>
        [DataMember(Name="Reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Specifies the location where the signature is applied.
        /// </summary>
        /// <value>Specifies the location where the signature is applied.</value>
        [DataMember(Name="Location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Specifies contact information about the signer.
        /// </summary>
        /// <value>Specifies contact information about the signer.</value>
        [DataMember(Name="ContactInfo", EmitDefaultValue=false)]
        public string ContactInfo { get; set; }

        /// <summary>
        /// Specifies the URL of the server responsible of providing a time stamp.
        /// </summary>
        /// <value>Specifies the URL of the server responsible of providing a time stamp.</value>
        [DataMember(Name="TimeStampURL", EmitDefaultValue=false)]
        public string TimeStampURL { get; set; }

        /// <summary>
        /// Specifies the optional user name associated with the time stamp server.
        /// </summary>
        /// <value>Specifies the optional user name associated with the time stamp server.</value>
        [DataMember(Name="TimeStampUserName", EmitDefaultValue=false)]
        public string TimeStampUserName { get; set; }

        /// <summary>
        /// Specifies the optional password associated with the time stamp server.
        /// </summary>
        /// <value>Specifies the optional password associated with the time stamp server.</value>
        [DataMember(Name="TimeStampPassword", EmitDefaultValue=false)]
        public string TimeStampPassword { get; set; }

        /// <summary>
        /// Specifies whether the signed PDF shall be linearized.
        /// </summary>
        /// <value>Specifies whether the signed PDF shall be linearized.</value>
        [DataMember(Name="Linearize", EmitDefaultValue=false)]
        public bool? Linearize { get; set; }

        /// <summary>
        /// Specifies whether the signature shall be drawn on the document.
        /// </summary>
        /// <value>Specifies whether the signature shall be drawn on the document.</value>
        [DataMember(Name="DrawSignature", EmitDefaultValue=false)]
        public bool? DrawSignature { get; set; }

        /// <summary>
        /// Specifies the number of the page on which the signature shall be drawn.
        /// </summary>
        /// <value>Specifies the number of the page on which the signature shall be drawn.</value>
        [DataMember(Name="PageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// Specifies whether a validation mark shall be drawn with the signature.
        /// </summary>
        /// <value>Specifies whether a validation mark shall be drawn with the signature.</value>
        [DataMember(Name="ShowValidationMark", EmitDefaultValue=false)]
        public bool? ShowValidationMark { get; set; }

        /// <summary>
        /// Specifies the data of the image to be drawn at the signature location.
        /// </summary>
        /// <value>Specifies the data of the image to be drawn at the signature location.</value>
        [DataMember(Name="ImageData", EmitDefaultValue=false)]
        public byte[] ImageData { get; set; }

        /// <summary>
        /// Gets or Sets SignatureLayout
        /// </summary>
        [DataMember(Name="SignatureLayout", EmitDefaultValue=false)]
        public DrawableContentLayoutParameters SignatureLayout { get; set; }

        /// <summary>
        /// Gets or Sets SignatureText
        /// </summary>
        [DataMember(Name="SignatureText", EmitDefaultValue=false)]
        public PDFAlignedTextParameters SignatureText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFDigiSignParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  CertificateData: ").Append(CertificateData).Append("\n");
            sb.Append("  CertificatePassword: ").Append(CertificatePassword).Append("\n");
            sb.Append("  SignatureMode: ").Append(SignatureMode).Append("\n");
            sb.Append("  SignatureCertificationLevel: ").Append(SignatureCertificationLevel).Append("\n");
            sb.Append("  SignatureHashAlgorithm: ").Append(SignatureHashAlgorithm).Append("\n");
            sb.Append("  SignerName: ").Append(SignerName).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  ContactInfo: ").Append(ContactInfo).Append("\n");
            sb.Append("  TimeStampURL: ").Append(TimeStampURL).Append("\n");
            sb.Append("  TimeStampUserName: ").Append(TimeStampUserName).Append("\n");
            sb.Append("  TimeStampPassword: ").Append(TimeStampPassword).Append("\n");
            sb.Append("  Linearize: ").Append(Linearize).Append("\n");
            sb.Append("  DrawSignature: ").Append(DrawSignature).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  ShowValidationMark: ").Append(ShowValidationMark).Append("\n");
            sb.Append("  ImageData: ").Append(ImageData).Append("\n");
            sb.Append("  SignatureLayout: ").Append(SignatureLayout).Append("\n");
            sb.Append("  SignatureText: ").Append(SignatureText).Append("\n");
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
            return this.Equals(input as PDFDigiSignParameters);
        }

        /// <summary>
        /// Returns true if PDFDigiSignParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFDigiSignParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFDigiSignParameters input)
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
                    this.CertificateData == input.CertificateData ||
                    (this.CertificateData != null &&
                    this.CertificateData.Equals(input.CertificateData))
                ) && 
                (
                    this.CertificatePassword == input.CertificatePassword ||
                    (this.CertificatePassword != null &&
                    this.CertificatePassword.Equals(input.CertificatePassword))
                ) && 
                (
                    this.SignatureMode == input.SignatureMode ||
                    (this.SignatureMode != null &&
                    this.SignatureMode.Equals(input.SignatureMode))
                ) && 
                (
                    this.SignatureCertificationLevel == input.SignatureCertificationLevel ||
                    (this.SignatureCertificationLevel != null &&
                    this.SignatureCertificationLevel.Equals(input.SignatureCertificationLevel))
                ) && 
                (
                    this.SignatureHashAlgorithm == input.SignatureHashAlgorithm ||
                    (this.SignatureHashAlgorithm != null &&
                    this.SignatureHashAlgorithm.Equals(input.SignatureHashAlgorithm))
                ) && 
                (
                    this.SignerName == input.SignerName ||
                    (this.SignerName != null &&
                    this.SignerName.Equals(input.SignerName))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.ContactInfo == input.ContactInfo ||
                    (this.ContactInfo != null &&
                    this.ContactInfo.Equals(input.ContactInfo))
                ) && 
                (
                    this.TimeStampURL == input.TimeStampURL ||
                    (this.TimeStampURL != null &&
                    this.TimeStampURL.Equals(input.TimeStampURL))
                ) && 
                (
                    this.TimeStampUserName == input.TimeStampUserName ||
                    (this.TimeStampUserName != null &&
                    this.TimeStampUserName.Equals(input.TimeStampUserName))
                ) && 
                (
                    this.TimeStampPassword == input.TimeStampPassword ||
                    (this.TimeStampPassword != null &&
                    this.TimeStampPassword.Equals(input.TimeStampPassword))
                ) && 
                (
                    this.Linearize == input.Linearize ||
                    (this.Linearize != null &&
                    this.Linearize.Equals(input.Linearize))
                ) && 
                (
                    this.DrawSignature == input.DrawSignature ||
                    (this.DrawSignature != null &&
                    this.DrawSignature.Equals(input.DrawSignature))
                ) && 
                (
                    this.PageNumber == input.PageNumber ||
                    (this.PageNumber != null &&
                    this.PageNumber.Equals(input.PageNumber))
                ) && 
                (
                    this.ShowValidationMark == input.ShowValidationMark ||
                    (this.ShowValidationMark != null &&
                    this.ShowValidationMark.Equals(input.ShowValidationMark))
                ) && 
                (
                    this.ImageData == input.ImageData ||
                    (this.ImageData != null &&
                    this.ImageData.Equals(input.ImageData))
                ) && 
                (
                    this.SignatureLayout == input.SignatureLayout ||
                    (this.SignatureLayout != null &&
                    this.SignatureLayout.Equals(input.SignatureLayout))
                ) && 
                (
                    this.SignatureText == input.SignatureText ||
                    (this.SignatureText != null &&
                    this.SignatureText.Equals(input.SignatureText))
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
                if (this.CertificateData != null)
                    hashCode = hashCode * 59 + this.CertificateData.GetHashCode();
                if (this.CertificatePassword != null)
                    hashCode = hashCode * 59 + this.CertificatePassword.GetHashCode();
                if (this.SignatureMode != null)
                    hashCode = hashCode * 59 + this.SignatureMode.GetHashCode();
                if (this.SignatureCertificationLevel != null)
                    hashCode = hashCode * 59 + this.SignatureCertificationLevel.GetHashCode();
                if (this.SignatureHashAlgorithm != null)
                    hashCode = hashCode * 59 + this.SignatureHashAlgorithm.GetHashCode();
                if (this.SignerName != null)
                    hashCode = hashCode * 59 + this.SignerName.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.ContactInfo != null)
                    hashCode = hashCode * 59 + this.ContactInfo.GetHashCode();
                if (this.TimeStampURL != null)
                    hashCode = hashCode * 59 + this.TimeStampURL.GetHashCode();
                if (this.TimeStampUserName != null)
                    hashCode = hashCode * 59 + this.TimeStampUserName.GetHashCode();
                if (this.TimeStampPassword != null)
                    hashCode = hashCode * 59 + this.TimeStampPassword.GetHashCode();
                if (this.Linearize != null)
                    hashCode = hashCode * 59 + this.Linearize.GetHashCode();
                if (this.DrawSignature != null)
                    hashCode = hashCode * 59 + this.DrawSignature.GetHashCode();
                if (this.PageNumber != null)
                    hashCode = hashCode * 59 + this.PageNumber.GetHashCode();
                if (this.ShowValidationMark != null)
                    hashCode = hashCode * 59 + this.ShowValidationMark.GetHashCode();
                if (this.ImageData != null)
                    hashCode = hashCode * 59 + this.ImageData.GetHashCode();
                if (this.SignatureLayout != null)
                    hashCode = hashCode * 59 + this.SignatureLayout.GetHashCode();
                if (this.SignatureText != null)
                    hashCode = hashCode * 59 + this.SignatureText.GetHashCode();
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
