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
    /// Specifies a PassportPDF status.
    /// </summary>
    /// <value>Specifies a PassportPDF status.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PassportPDFStatus
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
        /// Enum CanNotFlatten for value: CanNotFlatten
        /// </summary>
        [EnumMember(Value = "CanNotFlatten")]
        CanNotFlatten = 44,

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
        CanNotCloneImageRegion = 80,

        /// <summary>
        /// Enum CanNotReorderPages for value: CanNotReorderPages
        /// </summary>
        [EnumMember(Value = "CanNotReorderPages")]
        CanNotReorderPages = 81,

        /// <summary>
        /// Enum CanNotAutoCrop for value: CanNotAutoCrop
        /// </summary>
        [EnumMember(Value = "CanNotAutoCrop")]
        CanNotAutoCrop = 82,

        /// <summary>
        /// Enum CanNotScalePage for value: CanNotScalePage
        /// </summary>
        [EnumMember(Value = "CanNotScalePage")]
        CanNotScalePage = 83,

        /// <summary>
        /// Enum CanNotMergePages for value: CanNotMergePages
        /// </summary>
        [EnumMember(Value = "CanNotMergePages")]
        CanNotMergePages = 84,

        /// <summary>
        /// Enum CanNotGetMetaData for value: CanNotGetMetaData
        /// </summary>
        [EnumMember(Value = "CanNotGetMetaData")]
        CanNotGetMetaData = 85,

        /// <summary>
        /// Enum CanNotSetMetadata for value: CanNotSetMetadata
        /// </summary>
        [EnumMember(Value = "CanNotSetMetadata")]
        CanNotSetMetadata = 86,

        /// <summary>
        /// Enum CanNotRemoveText for value: CanNotRemoveText
        /// </summary>
        [EnumMember(Value = "CanNotRemoveText")]
        CanNotRemoveText = 87,

        /// <summary>
        /// Enum CanNotDownloadDocument for value: CanNotDownloadDocument
        /// </summary>
        [EnumMember(Value = "CanNotDownloadDocument")]
        CanNotDownloadDocument = 88

    }

}
