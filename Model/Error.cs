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
    /// Contains all the information related to an error which has occured.
    /// </summary>
    [DataContract]
    public partial class Error :  IEquatable<Error>, IValidatableObject
    {
        /// <summary>
        /// Specifies the last result status provided by the PassportPDF API.
        /// </summary>
        /// <value>Specifies the last result status provided by the PassportPDF API.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResultcodeEnum
        {
            /// <summary>
            /// Enum OK for value: OK
            /// </summary>
            [EnumMember(Value = "OK")]
            OK = 1,

            /// <summary>
            /// Enum ActionTimedOut for value: ActionTimedOut
            /// </summary>
            [EnumMember(Value = "ActionTimedOut")]
            ActionTimedOut = 2,

            /// <summary>
            /// Enum EmptyParameter for value: EmptyParameter
            /// </summary>
            [EnumMember(Value = "EmptyParameter")]
            EmptyParameter = 3,

            /// <summary>
            /// Enum InvalidAPIKey for value: InvalidAPIKey
            /// </summary>
            [EnumMember(Value = "InvalidAPIKey")]
            InvalidAPIKey = 4,

            /// <summary>
            /// Enum NotEnoughTokens for value: NotEnoughTokens
            /// </summary>
            [EnumMember(Value = "NotEnoughTokens")]
            NotEnoughTokens = 5,

            /// <summary>
            /// Enum GenericError for value: GenericError
            /// </summary>
            [EnumMember(Value = "GenericError")]
            GenericError = 6,

            /// <summary>
            /// Enum InvalidParameter for value: InvalidParameter
            /// </summary>
            [EnumMember(Value = "InvalidParameter")]
            InvalidParameter = 7,

            /// <summary>
            /// Enum InvalidColor for value: InvalidColor
            /// </summary>
            [EnumMember(Value = "InvalidColor")]
            InvalidColor = 8,

            /// <summary>
            /// Enum OutOfMemory for value: OutOfMemory
            /// </summary>
            [EnumMember(Value = "OutOfMemory")]
            OutOfMemory = 9,

            /// <summary>
            /// Enum NotImplemented for value: NotImplemented
            /// </summary>
            [EnumMember(Value = "NotImplemented")]
            NotImplemented = 10,

            /// <summary>
            /// Enum FileNotFound for value: FileNotFound
            /// </summary>
            [EnumMember(Value = "FileNotFound")]
            FileNotFound = 11,

            /// <summary>
            /// Enum AccessDenied for value: AccessDenied
            /// </summary>
            [EnumMember(Value = "AccessDenied")]
            AccessDenied = 12,

            /// <summary>
            /// Enum CanNotImportFileToPDF for value: CanNotImportFileToPDF
            /// </summary>
            [EnumMember(Value = "CanNotImportFileToPDF")]
            CanNotImportFileToPDF = 13,

            /// <summary>
            /// Enum PdfCanNotBeDecrypted for value: PdfCanNotBeDecrypted
            /// </summary>
            [EnumMember(Value = "PdfCanNotBeDecrypted")]
            PdfCanNotBeDecrypted = 14,

            /// <summary>
            /// Enum PdfOperationNotAllowed for value: PdfOperationNotAllowed
            /// </summary>
            [EnumMember(Value = "PdfOperationNotAllowed")]
            PdfOperationNotAllowed = 15,

            /// <summary>
            /// Enum PdfCanNotOpenFile for value: PdfCanNotOpenFile
            /// </summary>
            [EnumMember(Value = "PdfCanNotOpenFile")]
            PdfCanNotOpenFile = 16,

            /// <summary>
            /// Enum PdfCanNotSaveFile for value: PdfCanNotSaveFile
            /// </summary>
            [EnumMember(Value = "PdfCanNotSaveFile")]
            PdfCanNotSaveFile = 17,

            /// <summary>
            /// Enum CanNotCreateFile for value: CanNotCreateFile
            /// </summary>
            [EnumMember(Value = "CanNotCreateFile")]
            CanNotCreateFile = 18,

            /// <summary>
            /// Enum NoDocumentProvided for value: NoDocumentProvided
            /// </summary>
            [EnumMember(Value = "NoDocumentProvided")]
            NoDocumentProvided = 19,

            /// <summary>
            /// Enum CanNotRemovePage for value: CanNotRemovePage
            /// </summary>
            [EnumMember(Value = "CanNotRemovePage")]
            CanNotRemovePage = 20,

            /// <summary>
            /// Enum CanNotSwapPages for value: CanNotSwapPages
            /// </summary>
            [EnumMember(Value = "CanNotSwapPages")]
            CanNotSwapPages = 21,

            /// <summary>
            /// Enum CanNotMovePage for value: CanNotMovePage
            /// </summary>
            [EnumMember(Value = "CanNotMovePage")]
            CanNotMovePage = 22,

            /// <summary>
            /// Enum CanNotRotatePage for value: CanNotRotatePage
            /// </summary>
            [EnumMember(Value = "CanNotRotatePage")]
            CanNotRotatePage = 23,

            /// <summary>
            /// Enum CanNotFlipPage for value: CanNotFlipPage
            /// </summary>
            [EnumMember(Value = "CanNotFlipPage")]
            CanNotFlipPage = 24,

            /// <summary>
            /// Enum InvalidPageRange for value: InvalidPageRange
            /// </summary>
            [EnumMember(Value = "InvalidPageRange")]
            InvalidPageRange = 25,

            /// <summary>
            /// Enum CanNotReducePDF for value: CanNotReducePDF
            /// </summary>
            [EnumMember(Value = "CanNotReducePDF")]
            CanNotReducePDF = 26,

            /// <summary>
            /// Enum CanNotAutoDeskew for value: CanNotAutoDeskew
            /// </summary>
            [EnumMember(Value = "CanNotAutoDeskew")]
            CanNotAutoDeskew = 27,

            /// <summary>
            /// Enum CanNotSplit for value: CanNotSplit
            /// </summary>
            [EnumMember(Value = "CanNotSplit")]
            CanNotSplit = 28,

            /// <summary>
            /// Enum CanNotSaveAsJPEG for value: CanNotSaveAsJPEG
            /// </summary>
            [EnumMember(Value = "CanNotSaveAsJPEG")]
            CanNotSaveAsJPEG = 29,

            /// <summary>
            /// Enum CanNotDigiSign for value: CanNotDigiSign
            /// </summary>
            [EnumMember(Value = "CanNotDigiSign")]
            CanNotDigiSign = 30,

            /// <summary>
            /// Enum CanNotProtect for value: CanNotProtect
            /// </summary>
            [EnumMember(Value = "CanNotProtect")]
            CanNotProtect = 31,

            /// <summary>
            /// Enum CanNotConvertToPDFA for value: CanNotConvertToPDFA
            /// </summary>
            [EnumMember(Value = "CanNotConvertToPDFA")]
            CanNotConvertToPDFA = 32,

            /// <summary>
            /// Enum CanNotAnnotate for value: CanNotAnnotate
            /// </summary>
            [EnumMember(Value = "CanNotAnnotate")]
            CanNotAnnotate = 33,

            /// <summary>
            /// Enum CanNotClearPage for value: CanNotClearPage
            /// </summary>
            [EnumMember(Value = "CanNotClearPage")]
            CanNotClearPage = 34,

            /// <summary>
            /// Enum CanNotMerge for value: CanNotMerge
            /// </summary>
            [EnumMember(Value = "CanNotMerge")]
            CanNotMerge = 35,

            /// <summary>
            /// Enum CanNotGetPageThumbnail for value: CanNotGetPageThumbnail
            /// </summary>
            [EnumMember(Value = "CanNotGetPageThumbnail")]
            CanNotGetPageThumbnail = 36,

            /// <summary>
            /// Enum CanNotGetDocumentPreview for value: CanNotGetDocumentPreview
            /// </summary>
            [EnumMember(Value = "CanNotGetDocumentPreview")]
            CanNotGetDocumentPreview = 37,

            /// <summary>
            /// Enum CanNotRemovePageFormFields for value: CanNotRemovePageFormFields
            /// </summary>
            [EnumMember(Value = "CanNotRemovePageFormFields")]
            CanNotRemovePageFormFields = 38,

            /// <summary>
            /// Enum CanNotInsertImage for value: CanNotInsertImage
            /// </summary>
            [EnumMember(Value = "CanNotInsertImage")]
            CanNotInsertImage = 39,

            /// <summary>
            /// Enum CanNotDrawImage for value: CanNotDrawImage
            /// </summary>
            [EnumMember(Value = "CanNotDrawImage")]
            CanNotDrawImage = 40,

            /// <summary>
            /// Enum CanNotInsertPageNumber for value: CanNotInsertPageNumber
            /// </summary>
            [EnumMember(Value = "CanNotInsertPageNumber")]
            CanNotInsertPageNumber = 41,

            /// <summary>
            /// Enum CanNotInsertText for value: CanNotInsertText
            /// </summary>
            [EnumMember(Value = "CanNotInsertText")]
            CanNotInsertText = 42,

            /// <summary>
            /// Enum CanNotReadBarcode for value: CanNotReadBarcode
            /// </summary>
            [EnumMember(Value = "CanNotReadBarcode")]
            CanNotReadBarcode = 43,

            /// <summary>
            /// Enum CanNotFlattenFormFields for value: CanNotFlattenFormFields
            /// </summary>
            [EnumMember(Value = "CanNotFlattenFormFields")]
            CanNotFlattenFormFields = 44,

            /// <summary>
            /// Enum CanNotExportMoreThan2GigabyteFile for value: CanNotExportMoreThan2GigabyteFile
            /// </summary>
            [EnumMember(Value = "CanNotExportMoreThan2GigabyteFile")]
            CanNotExportMoreThan2GigabyteFile = 45,

            /// <summary>
            /// Enum CanNotOpenSession for value: CanNotOpenSession
            /// </summary>
            [EnumMember(Value = "CanNotOpenSession")]
            CanNotOpenSession = 46,

            /// <summary>
            /// Enum UnknownOrExpiredSession for value: UnknownOrExpiredSession
            /// </summary>
            [EnumMember(Value = "UnknownOrExpiredSession")]
            UnknownOrExpiredSession = 47,

            /// <summary>
            /// Enum CanNotSaveFile for value: CanNotSaveFile
            /// </summary>
            [EnumMember(Value = "CanNotSaveFile")]
            CanNotSaveFile = 48,

            /// <summary>
            /// Enum CanNotRepairPDF for value: CanNotRepairPDF
            /// </summary>
            [EnumMember(Value = "CanNotRepairPDF")]
            CanNotRepairPDF = 49,

            /// <summary>
            /// Enum UnsupportedImageFormat for value: UnsupportedImageFormat
            /// </summary>
            [EnumMember(Value = "UnsupportedImageFormat")]
            UnsupportedImageFormat = 50,

            /// <summary>
            /// Enum CanNotOCR for value: CanNotOCR
            /// </summary>
            [EnumMember(Value = "CanNotOCR")]
            CanNotOCR = 51,

            /// <summary>
            /// Enum CanNotOpenImage for value: CanNotOpenImage
            /// </summary>
            [EnumMember(Value = "CanNotOpenImage")]
            CanNotOpenImage = 52,

            /// <summary>
            /// Enum CanNotSaveAsPNG for value: CanNotSaveAsPNG
            /// </summary>
            [EnumMember(Value = "CanNotSaveAsPNG")]
            CanNotSaveAsPNG = 53,

            /// <summary>
            /// Enum CanNotSaveAsTIFF for value: CanNotSaveAsTIFF
            /// </summary>
            [EnumMember(Value = "CanNotSaveAsTIFF")]
            CanNotSaveAsTIFF = 54,

            /// <summary>
            /// Enum CanNotSaveAsTIFFMultipage for value: CanNotSaveAsTIFFMultipage
            /// </summary>
            [EnumMember(Value = "CanNotSaveAsTIFFMultipage")]
            CanNotSaveAsTIFFMultipage = 55,

            /// <summary>
            /// Enum CanNotSetInfo for value: CanNotSetInfo
            /// </summary>
            [EnumMember(Value = "CanNotSetInfo")]
            CanNotSetInfo = 56,

            /// <summary>
            /// Enum CanNotSetPageBox for value: CanNotSetPageBox
            /// </summary>
            [EnumMember(Value = "CanNotSetPageBox")]
            CanNotSetPageBox = 57,

            /// <summary>
            /// Enum CanNotExtractPage for value: CanNotExtractPage
            /// </summary>
            [EnumMember(Value = "CanNotExtractPage")]
            CanNotExtractPage = 58,

            /// <summary>
            /// Enum CanNotInsertNewPage for value: CanNotInsertNewPage
            /// </summary>
            [EnumMember(Value = "CanNotInsertNewPage")]
            CanNotInsertNewPage = 59,

            /// <summary>
            /// Enum CanNotClonePage for value: CanNotClonePage
            /// </summary>
            [EnumMember(Value = "CanNotClonePage")]
            CanNotClonePage = 60,

            /// <summary>
            /// Enum CanNotSetInitialView for value: CanNotSetInitialView
            /// </summary>
            [EnumMember(Value = "CanNotSetInitialView")]
            CanNotSetInitialView = 61,

            /// <summary>
            /// Enum CanNotAdjust for value: CanNotAdjust
            /// </summary>
            [EnumMember(Value = "CanNotAdjust")]
            CanNotAdjust = 62,

            /// <summary>
            /// Enum CanNotResize for value: CanNotResize
            /// </summary>
            [EnumMember(Value = "CanNotResize")]
            CanNotResize = 63,

            /// <summary>
            /// Enum CanNotFilter for value: CanNotFilter
            /// </summary>
            [EnumMember(Value = "CanNotFilter")]
            CanNotFilter = 64,

            /// <summary>
            /// Enum CanNotCleanupDocument for value: CanNotCleanupDocument
            /// </summary>
            [EnumMember(Value = "CanNotCleanupDocument")]
            CanNotCleanupDocument = 65,

            /// <summary>
            /// Enum UnknownDocumentFormat for value: UnknownDocumentFormat
            /// </summary>
            [EnumMember(Value = "UnknownDocumentFormat")]
            UnknownDocumentFormat = 66,

            /// <summary>
            /// Enum CanNotCrop for value: CanNotCrop
            /// </summary>
            [EnumMember(Value = "CanNotCrop")]
            CanNotCrop = 67,

            /// <summary>
            /// Enum CanNotRotate for value: CanNotRotate
            /// </summary>
            [EnumMember(Value = "CanNotRotate")]
            CanNotRotate = 68,

            /// <summary>
            /// Enum CanNotDetectColor for value: CanNotDetectColor
            /// </summary>
            [EnumMember(Value = "CanNotDetectColor")]
            CanNotDetectColor = 69,

            /// <summary>
            /// Enum CanNotConvertColorDepth for value: CanNotConvertColorDepth
            /// </summary>
            [EnumMember(Value = "CanNotConvertColorDepth")]
            CanNotConvertColorDepth = 70,

            /// <summary>
            /// Enum PdfCanNotAddFont for value: PdfCanNotAddFont
            /// </summary>
            [EnumMember(Value = "PdfCanNotAddFont")]
            PdfCanNotAddFont = 71,

            /// <summary>
            /// Enum ActionExecutionRejected for value: ActionExecutionRejected
            /// </summary>
            [EnumMember(Value = "ActionExecutionRejected")]
            ActionExecutionRejected = 72,

            /// <summary>
            /// Enum CanNotExtractText for value: CanNotExtractText
            /// </summary>
            [EnumMember(Value = "CanNotExtractText")]
            CanNotExtractText = 73,

            /// <summary>
            /// Enum CanNotDetectBlankPages for value: CanNotDetectBlankPages
            /// </summary>
            [EnumMember(Value = "CanNotDetectBlankPages")]
            CanNotDetectBlankPages = 74,

            /// <summary>
            /// Enum CanNotMICR for value: CanNotMICR
            /// </summary>
            [EnumMember(Value = "CanNotMICR")]
            CanNotMICR = 75,

            /// <summary>
            /// Enum CanNotDetectPageOrientation for value: CanNotDetectPageOrientation
            /// </summary>
            [EnumMember(Value = "CanNotDetectPageOrientation")]
            CanNotDetectPageOrientation = 76,

            /// <summary>
            /// Enum CanNotDeletePage for value: CanNotDeletePage
            /// </summary>
            [EnumMember(Value = "CanNotDeletePage")]
            CanNotDeletePage = 77,

            /// <summary>
            /// Enum CanNotSaveAsPDF for value: CanNotSaveAsPDF
            /// </summary>
            [EnumMember(Value = "CanNotSaveAsPDF")]
            CanNotSaveAsPDF = 78,

            /// <summary>
            /// Enum CanNotExtractImage for value: CanNotExtractImage
            /// </summary>
            [EnumMember(Value = "CanNotExtractImage")]
            CanNotExtractImage = 79,

            /// <summary>
            /// Enum CanNotCloneImageRegion for value: CanNotCloneImageRegion
            /// </summary>
            [EnumMember(Value = "CanNotCloneImageRegion")]
            CanNotCloneImageRegion = 80

        }

        /// <summary>
        /// Specifies the last result status provided by the PassportPDF API.
        /// </summary>
        /// <value>Specifies the last result status provided by the PassportPDF API.</value>
        [DataMember(Name="resultcode", EmitDefaultValue=false)]
        public ResultcodeEnum? resultcode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Error()
        {
        }
        

        /// <summary>
        /// Specifies a result code related to an error which occured in an external component.
        /// </summary>
        /// <value>Specifies a result code related to an error which occured in an external component.</value>
        [DataMember(Name="extResultStatus", EmitDefaultValue=false)]
        public string extResultStatus { get; private set; }

        /// <summary>
        /// Specifies a message which further describes the error.
        /// </summary>
        /// <value>Specifies a message which further describes the error.</value>
        [DataMember(Name="extResultMessage", EmitDefaultValue=false)]
        public string extResultMessage { get; private set; }

        /// <summary>
        /// Specifies a unique identifier, allowing to easily assess the error.
        /// </summary>
        /// <value>Specifies a unique identifier, allowing to easily assess the error.</value>
        [DataMember(Name="internalErrorId", EmitDefaultValue=false)]
        public string internalErrorId { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Error {\n");
            sb.Append("  resultcode: ").Append(resultcode).Append("\n");
            sb.Append("  extResultStatus: ").Append(extResultStatus).Append("\n");
            sb.Append("  extResultMessage: ").Append(extResultMessage).Append("\n");
            sb.Append("  internalErrorId: ").Append(internalErrorId).Append("\n");
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
            return this.Equals(input as Error);
        }

        /// <summary>
        /// Returns true if Error instances are equal
        /// </summary>
        /// <param name="input">Instance of Error to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Error input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.resultcode == input.resultcode ||
                    (this.resultcode != null &&
                    this.resultcode.Equals(input.resultcode))
                ) && 
                (
                    this.extResultStatus == input.extResultStatus ||
                    (this.extResultStatus != null &&
                    this.extResultStatus.Equals(input.extResultStatus))
                ) && 
                (
                    this.extResultMessage == input.extResultMessage ||
                    (this.extResultMessage != null &&
                    this.extResultMessage.Equals(input.extResultMessage))
                ) && 
                (
                    this.internalErrorId == input.internalErrorId ||
                    (this.internalErrorId != null &&
                    this.internalErrorId.Equals(input.internalErrorId))
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
                if (this.resultcode != null)
                    hashCode = hashCode * 59 + this.resultcode.GetHashCode();
                if (this.extResultStatus != null)
                    hashCode = hashCode * 59 + this.extResultStatus.GetHashCode();
                if (this.extResultMessage != null)
                    hashCode = hashCode * 59 + this.extResultMessage.GetHashCode();
                if (this.internalErrorId != null)
                    hashCode = hashCode * 59 + this.internalErrorId.GetHashCode();
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
