/*
 * PassportPDF API
 *
 * Copyright © 2019 PassportPDF - https://www.passportpdf.com
 *
 */


using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using PassportPDF.Client;
using PassportPDF.Model;

namespace PassportPDF.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPDFApiSync
    {

        /// <summary>
        /// Annotates a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfAnnotateParameters">A PdfAnnotateParameters object specifying the parameters of the action.</param>
        /// <returns>PdfAnnotateResponse</returns>
        PdfAnnotateResponse Annotate(PdfAnnotateParameters pdfAnnotateParameters);

        /// <summary>
        /// Performs auto deskew on a page range of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfAutoDeskewParameters">A PdfAutoDeskewParameters object specifying the parameters of the action.</param>
        /// <returns>PdfAutoDeskewResponse</returns>
        PdfAutoDeskewResponse AutoDeskew(PdfAutoDeskewParameters pdfAutoDeskewParameters);

        /// <summary>
        /// Clears a page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfClearPageParameters">A PdfClearPageParameters object specifying the parameters of the action.</param>
        /// <returns>PdfClearPageResponse</returns>
        PdfClearPageResponse ClearPage(PdfClearPageParameters pdfClearPageParameters);

        /// <summary>
        /// Clones specific pages from a previously uploaded document to another previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfClonePageParameters">A PdfClonePageParameters object specifying the parameters of the action.</param>
        /// <returns>PdfClonePageResponse</returns>
        PdfClonePageResponse ClonePage(PdfClonePageParameters pdfClonePageParameters);

        /// <summary>
        /// Closes a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfCloseDocumentParameters">A PdfCloseDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>PdfCloseDocumentResponse</returns>
        PdfCloseDocumentResponse ClosePDF(PdfCloseDocumentParameters pdfCloseDocumentParameters);

        /// <summary>
        /// Converts a previously uploaded document to PDF/A.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfConvertToPDFAParameters">A PdfConvertToPDFAParameters object specifying the parameters of the action.</param>
        /// <returns>PdfConvertToPDFAResponse</returns>
        PdfConvertToPDFAResponse ConvertToPDFA(PdfConvertToPDFAParameters pdfConvertToPDFAParameters);

        /// <summary>
        /// Deletes a page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfDeletePageParameters">A PdfDeletePageParameters object specifying the parameters of the action.</param>
        /// <returns>PdfDeletePageResponse</returns>
        PdfDeletePageResponse DeletePage(PdfDeletePageParameters pdfDeletePageParameters);

        /// <summary>
        /// Detects the orientation of the page(s) of a previously uploaded document and offers to automatically rotate them.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfDetectPageOrientationParameters">A PdfDetectPageOrientationParameters object specifying the parameters of the action.</param>
        /// <returns>PdfDetectPageOrientationResponse</returns>
        PdfDetectPageOrientationResponse DetectPageOrientation(PdfDetectPageOrientationParameters pdfDetectPageOrientationParameters);

        /// <summary>
        /// Signs a previously uploaded document digitally.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfDigiSignParameters">A PdfDigiSignParameters object specifying the parameters of the action.</param>
        /// <returns>PdfDigiSignResponse</returns>
        PdfDigiSignResponse DigiSign(PdfDigiSignParameters pdfDigiSignParameters);

        /// <summary>
        /// Draws an image on a page range of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfDrawImageParameters">A PdfDrawImageParameters object specifying the parameters of the action.</param>
        /// <returns>PdfDrawImageResponse</returns>
        PdfDrawImageResponse DrawImage(PdfDrawImageParameters pdfDrawImageParameters);

        /// <summary>
        /// Extracts a page range from a previously uploaded document into one or several new documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfExtractPageParameters">A PdfExtractPageParameters object specifying the parameters of the action.</param>
        /// <returns>PdfExtractPageResponse</returns>
        PdfExtractPageResponse ExtractPage(PdfExtractPageParameters pdfExtractPageParameters);

        /// <summary>
        /// Extracts text from the document pages.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfExtractTextParameters">A PdfExtractTextParameters object specifying the parameters of the action.</param>
        /// <returns>PdfExtractTextResponse</returns>
        PdfExtractTextResponse ExtractText(PdfExtractTextParameters pdfExtractTextParameters);

        /// <summary>
        /// Flattens the form-fields, annotations, and/or the layers of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfFlattenParameters">A PdfFlatten object specifying the parameters of the action.</param>
        /// <returns>PdfFlattenResponse</returns>
        PdfFlattenResponse Flatten(PdfFlattenParameters pdfFlattenParameters);

        /// <summary>
        /// Gets information about a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfGetInfoParameters">A PdfGetInfoParameters object specifying the parameters of the action.</param>
        /// <returns>PdfGetInfoResponse</returns>
        PdfGetInfoResponse GetInfo(PdfGetInfoParameters pdfGetInfoParameters);

        /// <summary>
        /// Gets the supported file extensions by the LoadDocumentAsPDF action.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>StringArrayResponse</returns>
        StringArrayResponse GetPDFImportSupportedFileExtensions();

        /// <summary>
        /// Gets a thumbnail of each page within the provided page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfGetPageThumbnailParameters">A PdfGetPageThumbnailParameters object specifying the parameters of the action.</param>
        /// <returns>PdfGetPageThumbnailResponse</returns>
        PdfGetPageThumbnailResponse GetPageThumbnail(PdfGetPageThumbnailParameters pdfGetPageThumbnailParameters);

        /// <summary>
        /// Inserts an image on a new page of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfInsertImageParameters">A PdfInsertImageParameters object specifying the parameters of the action.</param>
        /// <returns>PdfInsertImageResponse</returns>
        PdfInsertImageResponse InsertImage(PdfInsertImageParameters pdfInsertImageParameters);

        /// <summary>
        /// Inserts one or more new blank pages to a specific position in a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfInsertNewPageParameters">A PdfInsertNewPageParameters object specifying the parameters of the action.</param>
        /// <returns>PdfInsertNewPageResponse</returns>
        PdfInsertNewPageResponse InsertNewPage(PdfInsertNewPageParameters pdfInsertNewPageParameters);

        /// <summary>
        /// Inserts page number(s) on a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfInsertPageNumberParameters">A PdfInsertPageNumberParameters object specifying the parameters of the action.</param>
        /// <returns>PdfInsertPageNumberResponse</returns>
        PdfInsertPageNumberResponse InsertPageNumber(PdfInsertPageNumberParameters pdfInsertPageNumberParameters);

        /// <summary>
        /// Inserts text on a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfInsertTextParameters">A PdfInsertTextParameters object specifying the parameters of the action.</param>
        /// <returns>PdfInsertTextResponse</returns>
        PdfInsertTextResponse InsertText(PdfInsertTextParameters pdfInsertTextParameters);

        /// <summary>
        /// Linearizes a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfLinearizeParameters">A PdfLinearizeParameters object specifying the parameters of the action.</param>
        /// <returns>PdfLinearizeResponse</returns>
        PdfLinearizeResponse Linearize(PdfLinearizeParameters pdfLinearizeParameters);

        /// <summary>
        /// Imports the provided document as PDF.  Supported document formats can be retrieved by the GetPDFImportSupportedFileExtensions action.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfLoadDocumentFromByteArrayParameters">A PdfLoadDocumentFromByteArrayParameters object specifying the parameters of the action.</param>
        /// <returns>PdfLoadDocumentResponse</returns>
        PdfLoadDocumentResponse LoadDocumentAsPDF(PdfLoadDocumentFromByteArrayParameters pdfLoadDocumentFromByteArrayParameters);

        /// <summary>
        /// Imports the provided document as PDF using Multipart Upload.  Supported document formats can be retrieved by the GetPDFImportSupportedFileExtensions action.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileData">The data of the document.</param>
        /// <param name="loadDocumentParameters"> (optional)</param>
        /// <returns>PdfLoadDocumentResponse</returns>
        PdfLoadDocumentResponse LoadDocumentAsPDFMultipart(System.IO.Stream fileData, PdfLoadDocumentParameters loadDocumentParameters = null);

        /// <summary>
        /// Merges several previously uploaded documents into a new PDF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfMergeParameters">A PdfMergeParameters object specifying the parameters of the action.</param>
        /// <returns>PdfMergeResponse</returns>
        PdfMergeResponse Merge(PdfMergeParameters pdfMergeParameters);

        /// <summary>
        /// Merges multiple pages, vertically, within a previously uploaded document into one single page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfMergePagesParameters">A PdfMergePages object specifying the parameters of the action.</param>
        /// <returns>PdfMergePagesResponse</returns>
        PdfMergePagesResponse MergePages(PdfMergePagesParameters pdfMergePagesParameters);

        /// <summary>
        /// Moves a page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfMovePageParameters">A PdfMovePageParameters object specifying the parameters of the action.</param>
        /// <returns>PdfMovePageResponse</returns>
        PdfMovePageResponse MovePage(PdfMovePageParameters pdfMovePageParameters);

        /// <summary>
        /// Performs optical character recognition on a page range of a previously uploaded document.  The recognized text is added as invisible text on each processed page.  No token is charged for blank pages.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfOCRParameters">A PdfOCRParameters object specifying the parameters of the action.</param>
        /// <returns>PdfOCRResponse</returns>
        PdfOCRResponse OCR(PdfOCRParameters pdfOCRParameters);

        /// <summary>
        /// Protects a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfProtectParameters">A PdfProtectParameters object specifying the parameters of the action.</param>
        /// <returns>PdfProtectResponse</returns>
        PdfProtectResponse Protect(PdfProtectParameters pdfProtectParameters);

        /// <summary>
        /// Reads barcodes from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfReadBarcodesParameters">A PdfReadBarcodesParameters object specifying the parameters of the action.</param>
        /// <returns>ReadBarcodesResponse</returns>
        ReadBarcodesResponse ReadBarcodes(PdfReadBarcodesParameters pdfReadBarcodesParameters);

        /// <summary>
        /// Reduces the size of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfReduceParameters">A PdfReduceParameters object specifying the parameters of the action.</param>
        /// <returns>PdfReduceResponse</returns>
        PdfReduceResponse Reduce(PdfReduceParameters pdfReduceParameters);

        /// <summary>
        /// Removes the form fields from a page range of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfRemovePageFormFieldsParameters">A PdfRemovePageFormFieldsParameters object specifying the parameters of the action.</param>
        /// <returns>PdfRemovePageFormFieldsResponse</returns>
        PdfRemovePageFormFieldsResponse RemovePageFormFields(PdfRemovePageFormFieldsParameters pdfRemovePageFormFieldsParameters);

        /// <summary>
        /// Reorders pages of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfReorderPagesParameters">A PdfReorderPagesParameters object specifying the parameters of the action.</param>
        /// <returns>PdfReorderPagesResponse</returns>
        PdfReorderPagesResponse ReorderPages(PdfReorderPagesParameters pdfReorderPagesParameters);

        /// <summary>
        /// Repairs a previously uploaded PDF document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfRepairDocumentParameters">A PdfRepairDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>PdfRepairDocumentResponse</returns>
        PdfRepairDocumentResponse RepairDocument(PdfRepairDocumentParameters pdfRepairDocumentParameters);

        /// <summary>
        /// Rotates (standardly) a page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfRotatePageStandardParameters">A PdfRotatePageStandardParameters object specifying the parameters of the action.</param>
        /// <returns>PdfRotatePageStandardResponse</returns>
        PdfRotatePageStandardResponse RotatePageStandard(PdfRotatePageStandardParameters pdfRotatePageStandardParameters);

        /// <summary>
        /// Saves a previously uploaded document as JPEG.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsJPEGParameters">A PdfSaveAsJPEGParameters object specifying the parameters of the action.</param>
        /// <returns>PdfSaveAsJPEGResponse</returns>
        PdfSaveAsJPEGResponse SaveAsJPEG(PdfSaveAsJPEGParameters pdfSaveAsJPEGParameters);

        /// <summary>
        /// Saves a previously uploaded document as JPEG.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsJPEGParameters">A PdfSaveAsJPEGParameters object specifying the parameters of the action.</param>
        void SaveAsJPEGFile(PdfSaveAsJPEGParameters pdfSaveAsJPEGParameters, System.IO.Stream destinationStream);

        /// <summary>
        /// Saves a previously uploaded document as PNG.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsPNGParameters">A PdfSaveAsPNGParameters object specifying the parameters of the action.</param>
        /// <returns>PdfSaveAsPNGResponse</returns>
        PdfSaveAsPNGResponse SaveAsPNG(PdfSaveAsPNGParameters pdfSaveAsPNGParameters);

        /// <summary>
        /// Saves a previously uploaded document as PNG.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsPNGParameters">A PdfSaveAsPNGParameters object specifying the parameters of the action.</param>
        void SaveAsPNGFile(PdfSaveAsPNGParameters pdfSaveAsPNGParameters, System.IO.Stream destinationStream);

        /// <summary>
        /// Saves a previously uploaded document as TIFF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsTIFFParameters">A PdfSaveAsTIFFParameters object specifying the parameters of the action.</param>
        /// <returns>PdfSaveAsTIFFResponse</returns>
        PdfSaveAsTIFFResponse SaveAsTIFF(PdfSaveAsTIFFParameters pdfSaveAsTIFFParameters);

        /// <summary>
        /// Saves a previously uploaded document as TIFF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsTIFFParameters">A PdfSaveAsTIFFParameters object specifying the parameters of the action.</param>
        void SaveAsTIFFFile(PdfSaveAsTIFFParameters pdfSaveAsTIFFParameters, System.IO.Stream destinationStream);

        /// <summary>
        /// Saves a previously uploaded document as multipage TIFF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsTIFFMultipageParameters">A PdfSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        /// <returns>PdfSaveAsTIFFMultipageResponse</returns>
        PdfSaveAsTIFFMultipageResponse SaveAsTIFFMultipage(PdfSaveAsTIFFMultipageParameters pdfSaveAsTIFFMultipageParameters);

        /// <summary>
        /// Saves a previously uploaded document as multipage TIFF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsTIFFMultipageParameters">A PdfSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        void SaveAsTIFFMultipageFile(PdfSaveAsTIFFMultipageParameters pdfSaveAsTIFFMultipageParameters, System.IO.Stream destinationStream);

        /// <summary>
        /// Saves a previously uploaded document as PDF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveDocumentParameters">A PdfSaveDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>PdfSaveDocumentResponse</returns>
        PdfSaveDocumentResponse SaveDocument(PdfSaveDocumentParameters pdfSaveDocumentParameters);

        /// <summary>
        /// Saves a previously uploaded document as PDF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveDocumentParameters">A PdfSaveDocumentParameters object specifying the parameters of the action.</param>
        void SaveDocumentToFile(PdfSaveDocumentParameters pdfSaveDocumentParameters, System.IO.Stream destinationStream);

        /// <summary>
        /// Scales a page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfScalePageParameters">A PdfScalePage object specifying the parameters of the action.</param>
        /// <returns>PdfScalePageResponse</returns>
        PdfScalePageResponse ScalePage(PdfScalePageParameters pdfScalePageParameters);

        /// <summary>
        /// Sets information to a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSetInfoParameters">A PdfSetInfoParameters object specifying the parameters of the action.</param>
        /// <returns>PdfSetInfoResponse</returns>
        PdfSetInfoResponse SetInfo(PdfSetInfoParameters pdfSetInfoParameters);

        /// <summary>
        /// Sets various document level initial view options to a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSetInitialViewParameters">A PdfsetInitialViewParameters object specifying the parameters of the action.</param>
        /// <returns>PdfSetInitialViewResponse</returns>
        PdfSetInitialViewResponse SetInitialView(PdfSetInitialViewParameters pdfSetInitialViewParameters);

        /// <summary>
        /// Sets pagebox to a page range from previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSetPageBoxParameters">A PdfSetPageBoxParameters object specifying the parameters of the action.</param>
        /// <returns>PdfSetPageBoxResponse</returns>
        PdfSetPageBoxResponse SetPageBox(PdfSetPageBoxParameters pdfSetPageBoxParameters);

        /// <summary>
        /// Unprotects a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSetPasswordParameters">A PdfSetPasswordParameters object specifying the parameters of the action.</param>
        /// <returns>PdfSetPasswordResponse</returns>
        PdfSetPasswordResponse SetPassword(PdfSetPasswordParameters pdfSetPasswordParameters);

        /// <summary>
        /// Splits a previously uploaded document into new ones.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSplitParameters">A PdfSplitParameters object specifying the parameters of the action.</param>
        /// <returns>PdfSplitResponse</returns>
        PdfSplitResponse Split(PdfSplitParameters pdfSplitParameters);

        /// <summary>
        /// Swaps two pages from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSwapPagesParameters">A PdfSwapPagesParameters object specifying the parameters of the action.</param>
        /// <returns>PdfSwapPagesResponse</returns>
        PdfSwapPagesResponse SwapPages(PdfSwapPagesParameters pdfSwapPagesParameters);

        /// <summary>
        /// Unprotects a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfUnprotectParameters">A PdfUnprotectParameters object specifying the parameters of the action.</param>
        /// <returns>PdfUnprotectResponse</returns>
        PdfUnprotectResponse Unprotect(PdfUnprotectParameters pdfUnprotectParameters);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPDFApiAsync
    {

        /// <summary>
        /// Annotates a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfAnnotateParameters">A PdfAnnotateParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfAnnotateResponse</returns>
        Task<PdfAnnotateResponse> AnnotateAsync(PdfAnnotateParameters pdfAnnotateParameters);

        /// <summary>
        /// Performs auto deskew on a page range of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfAutoDeskewParameters">A PdfAutoDeskewParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfAutoDeskewResponse</returns>
        Task<PdfAutoDeskewResponse> AutoDeskewAsync(PdfAutoDeskewParameters pdfAutoDeskewParameters);

        /// <summary>
        /// Clears a page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfClearPageParameters">A PdfClearPageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfClearPageResponse</returns>
        Task<PdfClearPageResponse> ClearPageAsync(PdfClearPageParameters pdfClearPageParameters);

        /// <summary>
        /// Clones specific pages from a previously uploaded document to another previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfClonePageParameters">A PdfClonePageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfClonePageResponse</returns>
        Task<PdfClonePageResponse> ClonePageAsync(PdfClonePageParameters pdfClonePageParameters);

        /// <summary>
        /// Closes a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfCloseDocumentParameters">A PdfCloseDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfCloseDocumentResponse</returns>
        Task<PdfCloseDocumentResponse> ClosePDFAsync(PdfCloseDocumentParameters pdfCloseDocumentParameters);

        /// <summary>
        /// Converts a previously uploaded document to PDF/A.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfConvertToPDFAParameters">A PdfConvertToPDFAParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfConvertToPDFAResponse</returns>
        Task<PdfConvertToPDFAResponse> ConvertToPDFAAsync(PdfConvertToPDFAParameters pdfConvertToPDFAParameters);

        /// <summary>
        /// Deletes a page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfDeletePageParameters">A PdfDeletePageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfDeletePageResponse</returns>
        Task<PdfDeletePageResponse> DeletePageAsync(PdfDeletePageParameters pdfDeletePageParameters);

        /// <summary>
        /// Detects the orientation of the page(s) of a previously uploaded document and offers to automatically rotate them.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfDetectPageOrientationParameters">A PdfDetectPageOrientationParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfDetectPageOrientationResponse</returns>
        Task<PdfDetectPageOrientationResponse> DetectPageOrientationAsync(PdfDetectPageOrientationParameters pdfDetectPageOrientationParameters);

        /// <summary>
        /// Signs a previously uploaded document digitally.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfDigiSignParameters">A PdfDigiSignParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfDigiSignResponse</returns>
        Task<PdfDigiSignResponse> DigiSignAsync(PdfDigiSignParameters pdfDigiSignParameters);

        /// <summary>
        /// Draws an image on a page range of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfDrawImageParameters">A PdfDrawImageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfDrawImageResponse</returns>
        Task<PdfDrawImageResponse> DrawImageAsync(PdfDrawImageParameters pdfDrawImageParameters);

        /// <summary>
        /// Extracts a page range from a previously uploaded document into one or several new documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfExtractPageParameters">A PdfExtractPageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfExtractPageResponse</returns>
        Task<PdfExtractPageResponse> ExtractPageAsync(PdfExtractPageParameters pdfExtractPageParameters);

        /// <summary>
        /// Extracts text from the document pages.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfExtractTextParameters">A PdfExtractTextParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfExtractTextResponse</returns>
        Task<PdfExtractTextResponse> ExtractTextAsync(PdfExtractTextParameters pdfExtractTextParameters);

        /// <summary>
        /// Flattens the form-fields, annotations, and/or the layers of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfFlattenParameters">A PdfFlatten object specifying the parameters of the action.</param>
        /// <returns>Task of PdfFlattenResponse</returns>
        Task<PdfFlattenResponse> FlattenAsync(PdfFlattenParameters pdfFlattenParameters);

        /// <summary>
        /// Gets information about a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfGetInfoParameters">A PdfGetInfoParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfGetInfoResponse</returns>
        Task<PdfGetInfoResponse> GetInfoAsync(PdfGetInfoParameters pdfGetInfoParameters);

        /// <summary>
        /// Gets the supported file extensions by the LoadDocumentAsPDF action.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of StringArrayResponse</returns>
        Task<StringArrayResponse> GetPDFImportSupportedFileExtensionsAsync();

        /// <summary>
        /// Gets a thumbnail of each page within the provided page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfGetPageThumbnailParameters">A PdfGetPageThumbnailParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfGetPageThumbnailResponse</returns>
        Task<PdfGetPageThumbnailResponse> GetPageThumbnailAsync(PdfGetPageThumbnailParameters pdfGetPageThumbnailParameters);

        /// <summary>
        /// Inserts an image on a new page of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfInsertImageParameters">A PdfInsertImageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfInsertImageResponse</returns>
        Task<PdfInsertImageResponse> InsertImageAsync(PdfInsertImageParameters pdfInsertImageParameters);

        /// <summary>
        /// Inserts one or more new blank pages to a specific position in a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfInsertNewPageParameters">A PdfInsertNewPageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfInsertNewPageResponse</returns>
        Task<PdfInsertNewPageResponse> InsertNewPageAsync(PdfInsertNewPageParameters pdfInsertNewPageParameters);

        /// <summary>
        /// Inserts page number(s) on a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfInsertPageNumberParameters">A PdfInsertPageNumberParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfInsertPageNumberResponse</returns>
        Task<PdfInsertPageNumberResponse> InsertPageNumberAsync(PdfInsertPageNumberParameters pdfInsertPageNumberParameters);

        /// <summary>
        /// Inserts text on a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfInsertTextParameters">A PdfInsertTextParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfInsertTextResponse</returns>
        Task<PdfInsertTextResponse> InsertTextAsync(PdfInsertTextParameters pdfInsertTextParameters);

        /// <summary>
        /// Linearizes a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfLinearizeParameters">A PdfLinearizeParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfLinearizeResponse</returns>
        Task<PdfLinearizeResponse> LinearizeAsync(PdfLinearizeParameters pdfLinearizeParameters);

        /// <summary>
        /// Imports the provided document as PDF.  Supported document formats can be retrieved by the GetPDFImportSupportedFileExtensions action.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfLoadDocumentFromByteArrayParameters">A PdfLoadDocumentFromByteArrayParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfLoadDocumentResponse</returns>
        Task<PdfLoadDocumentResponse> LoadDocumentAsPDFAsync(PdfLoadDocumentFromByteArrayParameters pdfLoadDocumentFromByteArrayParameters);

        /// <summary>
        /// Imports the provided document as PDF using Multipart Upload.  Supported document formats can be retrieved by the GetPDFImportSupportedFileExtensions action.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileData">The data of the document.</param>
        /// <param name="loadDocumentParameters"> (optional)</param>
        /// <returns>Task of PdfLoadDocumentResponse</returns>
        Task<PdfLoadDocumentResponse> LoadDocumentAsPDFMultipartAsync(System.IO.Stream fileData, PdfLoadDocumentParameters loadDocumentParameters = null);

        /// <summary>
        /// Merges several previously uploaded documents into a new PDF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfMergeParameters">A PdfMergeParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfMergeResponse</returns>
        Task<PdfMergeResponse> MergeAsync(PdfMergeParameters pdfMergeParameters);

        /// <summary>
        /// Merges multiple pages, vertically, within a previously uploaded document into one single page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfMergePagesParameters">A PdfMergePages object specifying the parameters of the action.</param>
        /// <returns>Task of PdfMergePagesResponse</returns>
        Task<PdfMergePagesResponse> MergePagesAsync(PdfMergePagesParameters pdfMergePagesParameters);

        /// <summary>
        /// Moves a page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfMovePageParameters">A PdfMovePageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfMovePageResponse</returns>
        Task<PdfMovePageResponse> MovePageAsync(PdfMovePageParameters pdfMovePageParameters);

        /// <summary>
        /// Performs optical character recognition on a page range of a previously uploaded document.  The recognized text is added as invisible text on each processed page.  No token is charged for blank pages.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfOCRParameters">A PdfOCRParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfOCRResponse</returns>
        Task<PdfOCRResponse> OCRAsync(PdfOCRParameters pdfOCRParameters);

        /// <summary>
        /// Protects a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfProtectParameters">A PdfProtectParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfProtectResponse</returns>
        Task<PdfProtectResponse> ProtectAsync(PdfProtectParameters pdfProtectParameters);

        /// <summary>
        /// Reads barcodes from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfReadBarcodesParameters">A PdfReadBarcodesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ReadBarcodesResponse</returns>
        Task<ReadBarcodesResponse> ReadBarcodesAsync(PdfReadBarcodesParameters pdfReadBarcodesParameters);

        /// <summary>
        /// Reduces the size of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfReduceParameters">A PdfReduceParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfReduceResponse</returns>
        Task<PdfReduceResponse> ReduceAsync(PdfReduceParameters pdfReduceParameters);

        /// <summary>
        /// Removes the form fields from a page range of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfRemovePageFormFieldsParameters">A PdfRemovePageFormFieldsParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfRemovePageFormFieldsResponse</returns>
        Task<PdfRemovePageFormFieldsResponse> RemovePageFormFieldsAsync(PdfRemovePageFormFieldsParameters pdfRemovePageFormFieldsParameters);

        /// <summary>
        /// Reorders pages of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfReorderPagesParameters">A PdfReorderPagesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfReorderPagesResponse</returns>
        Task<PdfReorderPagesResponse> ReorderPagesAsync(PdfReorderPagesParameters pdfReorderPagesParameters);

        /// <summary>
        /// Repairs a previously uploaded PDF document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfRepairDocumentParameters">A PdfRepairDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfRepairDocumentResponse</returns>
        Task<PdfRepairDocumentResponse> RepairDocumentAsync(PdfRepairDocumentParameters pdfRepairDocumentParameters);

        /// <summary>
        /// Rotates (standardly) a page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfRotatePageStandardParameters">A PdfRotatePageStandardParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfRotatePageStandardResponse</returns>
        Task<PdfRotatePageStandardResponse> RotatePageStandardAsync(PdfRotatePageStandardParameters pdfRotatePageStandardParameters);

        /// <summary>
        /// Saves a previously uploaded document as JPEG.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsJPEGParameters">A PdfSaveAsJPEGParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfSaveAsJPEGResponse</returns>
        Task<PdfSaveAsJPEGResponse> SaveAsJPEGAsync(PdfSaveAsJPEGParameters pdfSaveAsJPEGParameters);

        /// <summary>
        /// Saves a previously uploaded document as JPEG.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsJPEGParameters">A PdfSaveAsJPEGParameters object specifying the parameters of the action.</param>
        Task SaveAsJPEGFileAsync(PdfSaveAsJPEGParameters pdfSaveAsJPEGParameters, System.IO.Stream destinationStream);

        /// <summary>
        /// Saves a previously uploaded document as PNG.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsPNGParameters">A PdfSaveAsPNGParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfSaveAsPNGResponse</returns>
        Task<PdfSaveAsPNGResponse> SaveAsPNGAsync(PdfSaveAsPNGParameters pdfSaveAsPNGParameters);

        /// <summary>
        /// Saves a previously uploaded document as PNG.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsPNGParameters">A PdfSaveAsPNGParameters object specifying the parameters of the action.</param>
        Task SaveAsPNGFileAsync(PdfSaveAsPNGParameters pdfSaveAsPNGParameters, System.IO.Stream destinationStream);

        /// <summary>
        /// Saves a previously uploaded document as TIFF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsTIFFParameters">A PdfSaveAsTIFFParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfSaveAsTIFFResponse</returns>
        Task<PdfSaveAsTIFFResponse> SaveAsTIFFAsync(PdfSaveAsTIFFParameters pdfSaveAsTIFFParameters);

        /// <summary>
        /// Saves a previously uploaded document as TIFF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsTIFFParameters">A PdfSaveAsTIFFParameters object specifying the parameters of the action.</param>
        Task SaveAsTIFFFileAsync(PdfSaveAsTIFFParameters pdfSaveAsTIFFParameters, System.IO.Stream destinationStream);

        /// <summary>
        /// Saves a previously uploaded document as multipage TIFF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsTIFFMultipageParameters">A PdfSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfSaveAsTIFFMultipageResponse</returns>
        Task<PdfSaveAsTIFFMultipageResponse> SaveAsTIFFMultipageAsync(PdfSaveAsTIFFMultipageParameters pdfSaveAsTIFFMultipageParameters);

        /// <summary>
        /// Saves a previously uploaded document as multipage TIFF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsTIFFMultipageParameters">A PdfSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        Task SaveAsTIFFMultipageFileAsync(PdfSaveAsTIFFMultipageParameters pdfSaveAsTIFFMultipageParameters, System.IO.Stream destinationStream);

        /// <summary>
        /// Saves a previously uploaded document as PDF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveDocumentParameters">A PdfSaveDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfSaveDocumentResponse</returns>
        Task<PdfSaveDocumentResponse> SaveDocumentAsync(PdfSaveDocumentParameters pdfSaveDocumentParameters);

        /// <summary>
        /// Saves a previously uploaded document as PDF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveDocumentParameters">A PdfSaveDocumentParameters object specifying the parameters of the action.</param>
        Task SaveDocumentToFileAsync(PdfSaveDocumentParameters pdfSaveDocumentParameters, System.IO.Stream destinationStream);

        /// <summary>
        /// Scales a page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfScalePageParameters">A PdfScalePage object specifying the parameters of the action.</param>
        /// <returns>Task of PdfScalePageResponse</returns>
        Task<PdfScalePageResponse> ScalePageAsync(PdfScalePageParameters pdfScalePageParameters);

        /// <summary>
        /// Sets information to a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSetInfoParameters">A PdfSetInfoParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfSetInfoResponse</returns>
        Task<PdfSetInfoResponse> SetInfoAsync(PdfSetInfoParameters pdfSetInfoParameters);

        /// <summary>
        /// Sets various document level initial view options to a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSetInitialViewParameters">A PdfsetInitialViewParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfSetInitialViewResponse</returns>
        Task<PdfSetInitialViewResponse> SetInitialViewAsync(PdfSetInitialViewParameters pdfSetInitialViewParameters);

        /// <summary>
        /// Sets pagebox to a page range from previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSetPageBoxParameters">A PdfSetPageBoxParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfSetPageBoxResponse</returns>
        Task<PdfSetPageBoxResponse> SetPageBoxAsync(PdfSetPageBoxParameters pdfSetPageBoxParameters);

        /// <summary>
        /// Unprotects a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSetPasswordParameters">A PdfSetPasswordParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfSetPasswordResponse</returns>
        Task<PdfSetPasswordResponse> SetPasswordAsync(PdfSetPasswordParameters pdfSetPasswordParameters);

        /// <summary>
        /// Splits a previously uploaded document into new ones.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSplitParameters">A PdfSplitParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfSplitResponse</returns>
        Task<PdfSplitResponse> SplitAsync(PdfSplitParameters pdfSplitParameters);

        /// <summary>
        /// Swaps two pages from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSwapPagesParameters">A PdfSwapPagesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfSwapPagesResponse</returns>
        Task<PdfSwapPagesResponse> SwapPagesAsync(PdfSwapPagesParameters pdfSwapPagesParameters);

        /// <summary>
        /// Unprotects a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfUnprotectParameters">A PdfUnprotectParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PdfUnprotectResponse</returns>
        Task<PdfUnprotectResponse> UnprotectAsync(PdfUnprotectParameters pdfUnprotectParameters);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPDFApi : IPDFApiSync, IPDFApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed class PDFApi : IPDFApi
    {
        /// <summary>
        /// Gets or sets the base path of the API. If not set the value set in GlobalConfiguration will be used.
        /// </summary>
        public string BasePath { get; set; }

        /// <summary>
        /// Gets or sets the API key. If not set the value set in GlobalConfiguration value will be used.
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PDFApi"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        public PDFApi(string apiKey = "")
        {
            ApiKey = apiKey;
        }

        /// <summary>
        /// Annotates a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfAnnotateParameters">A PdfAnnotateParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfAnnotateResponse</returns>
        public PdfAnnotateResponse Annotate(PdfAnnotateParameters pdfAnnotateParameters)
        {
            // verify the required parameter 'pdfAnnotateParameters' is set
            if (pdfAnnotateParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfAnnotateParameters' when calling PDFApi->Annotate");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfAnnotateParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/Annotate",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/Annotate failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfAnnotateResponse)ApiClient.DeserializeResponse(response, typeof(PdfAnnotateResponse));
        }

        /// <summary>
        /// Annotates a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfAnnotateParameters">A PdfAnnotateParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfAnnotateResponse)</returns>
        public async Task<PdfAnnotateResponse> AnnotateAsync(PdfAnnotateParameters pdfAnnotateParameters)
        {
            // verify the required parameter 'pdfAnnotateParameters' is set
            if (pdfAnnotateParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfAnnotateParameters' when calling PDFApi->Annotate");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfAnnotateParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/Annotate",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/Annotate failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfAnnotateResponse)ApiClient.DeserializeResponse(response, typeof(PdfAnnotateResponse));
        }

        /// <summary>
        /// Performs auto deskew on a page range of a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfAutoDeskewParameters">A PdfAutoDeskewParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfAutoDeskewResponse</returns>
        public PdfAutoDeskewResponse AutoDeskew(PdfAutoDeskewParameters pdfAutoDeskewParameters)
        {
            // verify the required parameter 'pdfAutoDeskewParameters' is set
            if (pdfAutoDeskewParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfAutoDeskewParameters' when calling PDFApi->AutoDeskew");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfAutoDeskewParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/AutoDeskew",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/AutoDeskew failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfAutoDeskewResponse)ApiClient.DeserializeResponse(response, typeof(PdfAutoDeskewResponse));
        }

        /// <summary>
        /// Performs auto deskew on a page range of a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfAutoDeskewParameters">A PdfAutoDeskewParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfAutoDeskewResponse)</returns>
        public async Task<PdfAutoDeskewResponse> AutoDeskewAsync(PdfAutoDeskewParameters pdfAutoDeskewParameters)
        {
            // verify the required parameter 'pdfAutoDeskewParameters' is set
            if (pdfAutoDeskewParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfAutoDeskewParameters' when calling PDFApi->AutoDeskew");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfAutoDeskewParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/AutoDeskew",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/AutoDeskew failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfAutoDeskewResponse)ApiClient.DeserializeResponse(response, typeof(PdfAutoDeskewResponse));
        }

        /// <summary>
        /// Clears a page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfClearPageParameters">A PdfClearPageParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfClearPageResponse</returns>
        public PdfClearPageResponse ClearPage(PdfClearPageParameters pdfClearPageParameters)
        {
            // verify the required parameter 'pdfClearPageParameters' is set
            if (pdfClearPageParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfClearPageParameters' when calling PDFApi->ClearPage");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfClearPageParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/ClearPage",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/ClearPage failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfClearPageResponse)ApiClient.DeserializeResponse(response, typeof(PdfClearPageResponse));
        }

        /// <summary>
        /// Clears a page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfClearPageParameters">A PdfClearPageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfClearPageResponse)</returns>
        public async Task<PdfClearPageResponse> ClearPageAsync(PdfClearPageParameters pdfClearPageParameters)
        {
            // verify the required parameter 'pdfClearPageParameters' is set
            if (pdfClearPageParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfClearPageParameters' when calling PDFApi->ClearPage");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfClearPageParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/ClearPage",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/ClearPage failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfClearPageResponse)ApiClient.DeserializeResponse(response, typeof(PdfClearPageResponse));
        }

        /// <summary>
        /// Clones specific pages from a previously uploaded document to another previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfClonePageParameters">A PdfClonePageParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfClonePageResponse</returns>
        public PdfClonePageResponse ClonePage(PdfClonePageParameters pdfClonePageParameters)
        {
            // verify the required parameter 'pdfClonePageParameters' is set
            if (pdfClonePageParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfClonePageParameters' when calling PDFApi->ClonePage");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfClonePageParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/ClonePage",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/ClonePage failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfClonePageResponse)ApiClient.DeserializeResponse(response, typeof(PdfClonePageResponse));
        }

        /// <summary>
        /// Clones specific pages from a previously uploaded document to another previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfClonePageParameters">A PdfClonePageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfClonePageResponse)</returns>
        public async Task<PdfClonePageResponse> ClonePageAsync(PdfClonePageParameters pdfClonePageParameters)
        {
            // verify the required parameter 'pdfClonePageParameters' is set
            if (pdfClonePageParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfClonePageParameters' when calling PDFApi->ClonePage");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfClonePageParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/ClonePage",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/ClonePage failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfClonePageResponse)ApiClient.DeserializeResponse(response, typeof(PdfClonePageResponse));
        }

        /// <summary>
        /// Closes a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfCloseDocumentParameters">A PdfCloseDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfCloseDocumentResponse</returns>
        public PdfCloseDocumentResponse ClosePDF(PdfCloseDocumentParameters pdfCloseDocumentParameters)
        {
            // verify the required parameter 'pdfCloseDocumentParameters' is set
            if (pdfCloseDocumentParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfCloseDocumentParameters' when calling PDFApi->ClosePDF");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfCloseDocumentParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/ClosePDF",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/ClosePDF failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfCloseDocumentResponse)ApiClient.DeserializeResponse(response, typeof(PdfCloseDocumentResponse));
        }

        /// <summary>
        /// Closes a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfCloseDocumentParameters">A PdfCloseDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfCloseDocumentResponse)</returns>
        public async Task<PdfCloseDocumentResponse> ClosePDFAsync(PdfCloseDocumentParameters pdfCloseDocumentParameters)
        {
            // verify the required parameter 'pdfCloseDocumentParameters' is set
            if (pdfCloseDocumentParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfCloseDocumentParameters' when calling PDFApi->ClosePDF");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfCloseDocumentParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/ClosePDF",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/ClosePDF failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfCloseDocumentResponse)ApiClient.DeserializeResponse(response, typeof(PdfCloseDocumentResponse));
        }

        /// <summary>
        /// Converts a previously uploaded document to PDF/A. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfConvertToPDFAParameters">A PdfConvertToPDFAParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfConvertToPDFAResponse</returns>
        public PdfConvertToPDFAResponse ConvertToPDFA(PdfConvertToPDFAParameters pdfConvertToPDFAParameters)
        {
            // verify the required parameter 'pdfConvertToPDFAParameters' is set
            if (pdfConvertToPDFAParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfConvertToPDFAParameters' when calling PDFApi->ConvertToPDFA");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfConvertToPDFAParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/ConvertToPDFA",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/ConvertToPDFA failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfConvertToPDFAResponse)ApiClient.DeserializeResponse(response, typeof(PdfConvertToPDFAResponse));
        }

        /// <summary>
        /// Converts a previously uploaded document to PDF/A. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfConvertToPDFAParameters">A PdfConvertToPDFAParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfConvertToPDFAResponse)</returns>
        public async Task<PdfConvertToPDFAResponse> ConvertToPDFAAsync(PdfConvertToPDFAParameters pdfConvertToPDFAParameters)
        {
            // verify the required parameter 'pdfConvertToPDFAParameters' is set
            if (pdfConvertToPDFAParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfConvertToPDFAParameters' when calling PDFApi->ConvertToPDFA");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfConvertToPDFAParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/ConvertToPDFA",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/ConvertToPDFA failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfConvertToPDFAResponse)ApiClient.DeserializeResponse(response, typeof(PdfConvertToPDFAResponse));
        }

        /// <summary>
        /// Deletes a page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfDeletePageParameters">A PdfDeletePageParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfDeletePageResponse</returns>
        public PdfDeletePageResponse DeletePage(PdfDeletePageParameters pdfDeletePageParameters)
        {
            // verify the required parameter 'pdfDeletePageParameters' is set
            if (pdfDeletePageParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfDeletePageParameters' when calling PDFApi->DeletePage");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfDeletePageParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/DeletePage",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/DeletePage failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfDeletePageResponse)ApiClient.DeserializeResponse(response, typeof(PdfDeletePageResponse));
        }

        /// <summary>
        /// Deletes a page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfDeletePageParameters">A PdfDeletePageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfDeletePageResponse)</returns>
        public async Task<PdfDeletePageResponse> DeletePageAsync(PdfDeletePageParameters pdfDeletePageParameters)
        {
            // verify the required parameter 'pdfDeletePageParameters' is set
            if (pdfDeletePageParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfDeletePageParameters' when calling PDFApi->DeletePage");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfDeletePageParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/DeletePage",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/DeletePage failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfDeletePageResponse)ApiClient.DeserializeResponse(response, typeof(PdfDeletePageResponse));
        }

        /// <summary>
        /// Detects the orientation of the page(s) of a previously uploaded document and offers to automatically rotate them. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfDetectPageOrientationParameters">A PdfDetectPageOrientationParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfDetectPageOrientationResponse</returns>
        public PdfDetectPageOrientationResponse DetectPageOrientation(PdfDetectPageOrientationParameters pdfDetectPageOrientationParameters)
        {
            // verify the required parameter 'pdfDetectPageOrientationParameters' is set
            if (pdfDetectPageOrientationParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfDetectPageOrientationParameters' when calling PDFApi->DetectPageOrientation");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfDetectPageOrientationParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/DetectPageOrientation",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/DetectPageOrientation failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfDetectPageOrientationResponse)ApiClient.DeserializeResponse(response, typeof(PdfDetectPageOrientationResponse));
        }

        /// <summary>
        /// Detects the orientation of the page(s) of a previously uploaded document and offers to automatically rotate them. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfDetectPageOrientationParameters">A PdfDetectPageOrientationParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfDetectPageOrientationResponse)</returns>
        public async Task<PdfDetectPageOrientationResponse> DetectPageOrientationAsync(PdfDetectPageOrientationParameters pdfDetectPageOrientationParameters)
        {
            // verify the required parameter 'pdfDetectPageOrientationParameters' is set
            if (pdfDetectPageOrientationParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfDetectPageOrientationParameters' when calling PDFApi->DetectPageOrientation");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfDetectPageOrientationParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/DetectPageOrientation",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/DetectPageOrientation failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfDetectPageOrientationResponse)ApiClient.DeserializeResponse(response, typeof(PdfDetectPageOrientationResponse));
        }

        /// <summary>
        /// Signs a previously uploaded document digitally. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfDigiSignParameters">A PdfDigiSignParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfDigiSignResponse</returns>
        public PdfDigiSignResponse DigiSign(PdfDigiSignParameters pdfDigiSignParameters)
        {
            // verify the required parameter 'pdfDigiSignParameters' is set
            if (pdfDigiSignParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfDigiSignParameters' when calling PDFApi->DigiSign");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfDigiSignParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/DigiSign",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/DigiSign failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfDigiSignResponse)ApiClient.DeserializeResponse(response, typeof(PdfDigiSignResponse));
        }

        /// <summary>
        /// Signs a previously uploaded document digitally. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfDigiSignParameters">A PdfDigiSignParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfDigiSignResponse)</returns>
        public async Task<PdfDigiSignResponse> DigiSignAsync(PdfDigiSignParameters pdfDigiSignParameters)
        {
            // verify the required parameter 'pdfDigiSignParameters' is set
            if (pdfDigiSignParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfDigiSignParameters' when calling PDFApi->DigiSign");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfDigiSignParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/DigiSign",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/DigiSign failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfDigiSignResponse)ApiClient.DeserializeResponse(response, typeof(PdfDigiSignResponse));
        }

        /// <summary>
        /// Draws an image on a page range of a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfDrawImageParameters">A PdfDrawImageParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfDrawImageResponse</returns>
        public PdfDrawImageResponse DrawImage(PdfDrawImageParameters pdfDrawImageParameters)
        {
            // verify the required parameter 'pdfDrawImageParameters' is set
            if (pdfDrawImageParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfDrawImageParameters' when calling PDFApi->DrawImage");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfDrawImageParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/DrawImage",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/DrawImage failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfDrawImageResponse)ApiClient.DeserializeResponse(response, typeof(PdfDrawImageResponse));
        }

        /// <summary>
        /// Draws an image on a page range of a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfDrawImageParameters">A PdfDrawImageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfDrawImageResponse)</returns>
        public async Task<PdfDrawImageResponse> DrawImageAsync(PdfDrawImageParameters pdfDrawImageParameters)
        {
            // verify the required parameter 'pdfDrawImageParameters' is set
            if (pdfDrawImageParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfDrawImageParameters' when calling PDFApi->DrawImage");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfDrawImageParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/DrawImage",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/DrawImage failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfDrawImageResponse)ApiClient.DeserializeResponse(response, typeof(PdfDrawImageResponse));
        }

        /// <summary>
        /// Extracts a page range from a previously uploaded document into one or several new documents. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfExtractPageParameters">A PdfExtractPageParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfExtractPageResponse</returns>
        public PdfExtractPageResponse ExtractPage(PdfExtractPageParameters pdfExtractPageParameters)
        {
            // verify the required parameter 'pdfExtractPageParameters' is set
            if (pdfExtractPageParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfExtractPageParameters' when calling PDFApi->ExtractPage");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfExtractPageParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/ExtractPage",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/ExtractPage failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfExtractPageResponse)ApiClient.DeserializeResponse(response, typeof(PdfExtractPageResponse));
        }

        /// <summary>
        /// Extracts a page range from a previously uploaded document into one or several new documents. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfExtractPageParameters">A PdfExtractPageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfExtractPageResponse)</returns>
        public async Task<PdfExtractPageResponse> ExtractPageAsync(PdfExtractPageParameters pdfExtractPageParameters)
        {
            // verify the required parameter 'pdfExtractPageParameters' is set
            if (pdfExtractPageParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfExtractPageParameters' when calling PDFApi->ExtractPage");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfExtractPageParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/ExtractPage",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/ExtractPage failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfExtractPageResponse)ApiClient.DeserializeResponse(response, typeof(PdfExtractPageResponse));
        }

        /// <summary>
        /// Extracts text from the document pages. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfExtractTextParameters">A PdfExtractTextParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfExtractTextResponse</returns>
        public PdfExtractTextResponse ExtractText(PdfExtractTextParameters pdfExtractTextParameters)
        {
            // verify the required parameter 'pdfExtractTextParameters' is set
            if (pdfExtractTextParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfExtractTextParameters' when calling PDFApi->ExtractText");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfExtractTextParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/ExtractText",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/ExtractText failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfExtractTextResponse)ApiClient.DeserializeResponse(response, typeof(PdfExtractTextResponse));
        }

        /// <summary>
        /// Extracts text from the document pages. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfExtractTextParameters">A PdfExtractTextParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfExtractTextResponse)</returns>
        public async Task<PdfExtractTextResponse> ExtractTextAsync(PdfExtractTextParameters pdfExtractTextParameters)
        {
            // verify the required parameter 'pdfExtractTextParameters' is set
            if (pdfExtractTextParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfExtractTextParameters' when calling PDFApi->ExtractText");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfExtractTextParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/ExtractText",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/ExtractText failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfExtractTextResponse)ApiClient.DeserializeResponse(response, typeof(PdfExtractTextResponse));
        }

        /// <summary>
        /// Flattens the form-fields, annotations, and/or the layers of a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfFlattenParameters">A PdfFlatten object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfFlattenResponse</returns>
        public PdfFlattenResponse Flatten(PdfFlattenParameters pdfFlattenParameters)
        {
            // verify the required parameter 'pdfFlattenParameters' is set
            if (pdfFlattenParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfFlattenParameters' when calling PDFApi->Flatten");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfFlattenParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/Flatten",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/Flatten failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfFlattenResponse)ApiClient.DeserializeResponse(response, typeof(PdfFlattenResponse));
        }

        /// <summary>
        /// Flattens the form-fields, annotations, and/or the layers of a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfFlattenParameters">A PdfFlatten object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfFlattenResponse)</returns>
        public async Task<PdfFlattenResponse> FlattenAsync(PdfFlattenParameters pdfFlattenParameters)
        {
            // verify the required parameter 'pdfFlattenParameters' is set
            if (pdfFlattenParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfFlattenParameters' when calling PDFApi->Flatten");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfFlattenParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/Flatten",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/Flatten failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfFlattenResponse)ApiClient.DeserializeResponse(response, typeof(PdfFlattenResponse));
        }

        /// <summary>
        /// Gets information about a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfGetInfoParameters">A PdfGetInfoParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfGetInfoResponse</returns>
        public PdfGetInfoResponse GetInfo(PdfGetInfoParameters pdfGetInfoParameters)
        {
            // verify the required parameter 'pdfGetInfoParameters' is set
            if (pdfGetInfoParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfGetInfoParameters' when calling PDFApi->GetInfo");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfGetInfoParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/GetInfo",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/GetInfo failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfGetInfoResponse)ApiClient.DeserializeResponse(response, typeof(PdfGetInfoResponse));
        }

        /// <summary>
        /// Gets information about a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfGetInfoParameters">A PdfGetInfoParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfGetInfoResponse)</returns>
        public async Task<PdfGetInfoResponse> GetInfoAsync(PdfGetInfoParameters pdfGetInfoParameters)
        {
            // verify the required parameter 'pdfGetInfoParameters' is set
            if (pdfGetInfoParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfGetInfoParameters' when calling PDFApi->GetInfo");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfGetInfoParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/GetInfo",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/GetInfo failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfGetInfoResponse)ApiClient.DeserializeResponse(response, typeof(PdfGetInfoResponse));
        }

        /// <summary>
        /// Gets the supported file extensions by the LoadDocumentAsPDF action. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>IRestResponse of StringArrayResponse</returns>
        public StringArrayResponse GetPDFImportSupportedFileExtensions()
        {
            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] {  };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            IRestResponse response = ApiClient.CallApi(Method.GET,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/GetPDFImportSupportedFileExtensions",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/GetPDFImportSupportedFileExtensions failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (StringArrayResponse)ApiClient.DeserializeResponse(response, typeof(StringArrayResponse));
        }

        /// <summary>
        /// Gets the supported file extensions by the LoadDocumentAsPDF action. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of IRestResponse (StringArrayResponse)</returns>
        public async Task<StringArrayResponse> GetPDFImportSupportedFileExtensionsAsync()
        {
            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] {  };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);


            IRestResponse response = await ApiClient.CallApiAsync(Method.GET,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/GetPDFImportSupportedFileExtensions",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/GetPDFImportSupportedFileExtensions failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (StringArrayResponse)ApiClient.DeserializeResponse(response, typeof(StringArrayResponse));
        }

        /// <summary>
        /// Gets a thumbnail of each page within the provided page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfGetPageThumbnailParameters">A PdfGetPageThumbnailParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfGetPageThumbnailResponse</returns>
        public PdfGetPageThumbnailResponse GetPageThumbnail(PdfGetPageThumbnailParameters pdfGetPageThumbnailParameters)
        {
            // verify the required parameter 'pdfGetPageThumbnailParameters' is set
            if (pdfGetPageThumbnailParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfGetPageThumbnailParameters' when calling PDFApi->GetPageThumbnail");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfGetPageThumbnailParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/GetPageThumbnail",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/GetPageThumbnail failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfGetPageThumbnailResponse)ApiClient.DeserializeResponse(response, typeof(PdfGetPageThumbnailResponse));
        }

        /// <summary>
        /// Gets a thumbnail of each page within the provided page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfGetPageThumbnailParameters">A PdfGetPageThumbnailParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfGetPageThumbnailResponse)</returns>
        public async Task<PdfGetPageThumbnailResponse> GetPageThumbnailAsync(PdfGetPageThumbnailParameters pdfGetPageThumbnailParameters)
        {
            // verify the required parameter 'pdfGetPageThumbnailParameters' is set
            if (pdfGetPageThumbnailParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfGetPageThumbnailParameters' when calling PDFApi->GetPageThumbnail");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfGetPageThumbnailParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/GetPageThumbnail",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/GetPageThumbnail failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfGetPageThumbnailResponse)ApiClient.DeserializeResponse(response, typeof(PdfGetPageThumbnailResponse));
        }

        /// <summary>
        /// Inserts an image on a new page of a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfInsertImageParameters">A PdfInsertImageParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfInsertImageResponse</returns>
        public PdfInsertImageResponse InsertImage(PdfInsertImageParameters pdfInsertImageParameters)
        {
            // verify the required parameter 'pdfInsertImageParameters' is set
            if (pdfInsertImageParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfInsertImageParameters' when calling PDFApi->InsertImage");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfInsertImageParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/InsertImage",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/InsertImage failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfInsertImageResponse)ApiClient.DeserializeResponse(response, typeof(PdfInsertImageResponse));
        }

        /// <summary>
        /// Inserts an image on a new page of a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfInsertImageParameters">A PdfInsertImageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfInsertImageResponse)</returns>
        public async Task<PdfInsertImageResponse> InsertImageAsync(PdfInsertImageParameters pdfInsertImageParameters)
        {
            // verify the required parameter 'pdfInsertImageParameters' is set
            if (pdfInsertImageParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfInsertImageParameters' when calling PDFApi->InsertImage");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfInsertImageParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/InsertImage",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/InsertImage failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfInsertImageResponse)ApiClient.DeserializeResponse(response, typeof(PdfInsertImageResponse));
        }

        /// <summary>
        /// Inserts one or more new blank pages to a specific position in a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfInsertNewPageParameters">A PdfInsertNewPageParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfInsertNewPageResponse</returns>
        public PdfInsertNewPageResponse InsertNewPage(PdfInsertNewPageParameters pdfInsertNewPageParameters)
        {
            // verify the required parameter 'pdfInsertNewPageParameters' is set
            if (pdfInsertNewPageParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfInsertNewPageParameters' when calling PDFApi->InsertNewPage");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfInsertNewPageParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/InsertNewPage",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/InsertNewPage failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfInsertNewPageResponse)ApiClient.DeserializeResponse(response, typeof(PdfInsertNewPageResponse));
        }

        /// <summary>
        /// Inserts one or more new blank pages to a specific position in a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfInsertNewPageParameters">A PdfInsertNewPageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfInsertNewPageResponse)</returns>
        public async Task<PdfInsertNewPageResponse> InsertNewPageAsync(PdfInsertNewPageParameters pdfInsertNewPageParameters)
        {
            // verify the required parameter 'pdfInsertNewPageParameters' is set
            if (pdfInsertNewPageParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfInsertNewPageParameters' when calling PDFApi->InsertNewPage");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfInsertNewPageParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/InsertNewPage",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/InsertNewPage failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfInsertNewPageResponse)ApiClient.DeserializeResponse(response, typeof(PdfInsertNewPageResponse));
        }

        /// <summary>
        /// Inserts page number(s) on a document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfInsertPageNumberParameters">A PdfInsertPageNumberParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfInsertPageNumberResponse</returns>
        public PdfInsertPageNumberResponse InsertPageNumber(PdfInsertPageNumberParameters pdfInsertPageNumberParameters)
        {
            // verify the required parameter 'pdfInsertPageNumberParameters' is set
            if (pdfInsertPageNumberParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfInsertPageNumberParameters' when calling PDFApi->InsertPageNumber");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfInsertPageNumberParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/InsertPageNumber",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/InsertPageNumber failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfInsertPageNumberResponse)ApiClient.DeserializeResponse(response, typeof(PdfInsertPageNumberResponse));
        }

        /// <summary>
        /// Inserts page number(s) on a document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfInsertPageNumberParameters">A PdfInsertPageNumberParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfInsertPageNumberResponse)</returns>
        public async Task<PdfInsertPageNumberResponse> InsertPageNumberAsync(PdfInsertPageNumberParameters pdfInsertPageNumberParameters)
        {
            // verify the required parameter 'pdfInsertPageNumberParameters' is set
            if (pdfInsertPageNumberParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfInsertPageNumberParameters' when calling PDFApi->InsertPageNumber");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfInsertPageNumberParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/InsertPageNumber",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/InsertPageNumber failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfInsertPageNumberResponse)ApiClient.DeserializeResponse(response, typeof(PdfInsertPageNumberResponse));
        }

        /// <summary>
        /// Inserts text on a document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfInsertTextParameters">A PdfInsertTextParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfInsertTextResponse</returns>
        public PdfInsertTextResponse InsertText(PdfInsertTextParameters pdfInsertTextParameters)
        {
            // verify the required parameter 'pdfInsertTextParameters' is set
            if (pdfInsertTextParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfInsertTextParameters' when calling PDFApi->InsertText");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfInsertTextParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/InsertText",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/InsertText failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfInsertTextResponse)ApiClient.DeserializeResponse(response, typeof(PdfInsertTextResponse));
        }

        /// <summary>
        /// Inserts text on a document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfInsertTextParameters">A PdfInsertTextParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfInsertTextResponse)</returns>
        public async Task<PdfInsertTextResponse> InsertTextAsync(PdfInsertTextParameters pdfInsertTextParameters)
        {
            // verify the required parameter 'pdfInsertTextParameters' is set
            if (pdfInsertTextParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfInsertTextParameters' when calling PDFApi->InsertText");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfInsertTextParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/InsertText",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/InsertText failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfInsertTextResponse)ApiClient.DeserializeResponse(response, typeof(PdfInsertTextResponse));
        }

        /// <summary>
        /// Linearizes a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfLinearizeParameters">A PdfLinearizeParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfLinearizeResponse</returns>
        public PdfLinearizeResponse Linearize(PdfLinearizeParameters pdfLinearizeParameters)
        {
            // verify the required parameter 'pdfLinearizeParameters' is set
            if (pdfLinearizeParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfLinearizeParameters' when calling PDFApi->Linearize");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfLinearizeParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/Linearize",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/Linearize failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfLinearizeResponse)ApiClient.DeserializeResponse(response, typeof(PdfLinearizeResponse));
        }

        /// <summary>
        /// Linearizes a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfLinearizeParameters">A PdfLinearizeParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfLinearizeResponse)</returns>
        public async Task<PdfLinearizeResponse> LinearizeAsync(PdfLinearizeParameters pdfLinearizeParameters)
        {
            // verify the required parameter 'pdfLinearizeParameters' is set
            if (pdfLinearizeParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfLinearizeParameters' when calling PDFApi->Linearize");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfLinearizeParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/Linearize",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/Linearize failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfLinearizeResponse)ApiClient.DeserializeResponse(response, typeof(PdfLinearizeResponse));
        }

        /// <summary>
        /// Imports the provided document as PDF.  Supported document formats can be retrieved by the GetPDFImportSupportedFileExtensions action. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfLoadDocumentFromByteArrayParameters">A PdfLoadDocumentFromByteArrayParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfLoadDocumentResponse</returns>
        public PdfLoadDocumentResponse LoadDocumentAsPDF(PdfLoadDocumentFromByteArrayParameters pdfLoadDocumentFromByteArrayParameters)
        {
            // verify the required parameter 'pdfLoadDocumentFromByteArrayParameters' is set
            if (pdfLoadDocumentFromByteArrayParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfLoadDocumentFromByteArrayParameters' when calling PDFApi->LoadDocumentAsPDF");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfLoadDocumentFromByteArrayParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/LoadDocument",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/LoadDocument failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfLoadDocumentResponse)ApiClient.DeserializeResponse(response, typeof(PdfLoadDocumentResponse));
        }

        /// <summary>
        /// Imports the provided document as PDF.  Supported document formats can be retrieved by the GetPDFImportSupportedFileExtensions action. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfLoadDocumentFromByteArrayParameters">A PdfLoadDocumentFromByteArrayParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfLoadDocumentResponse)</returns>
        public async Task<PdfLoadDocumentResponse> LoadDocumentAsPDFAsync(PdfLoadDocumentFromByteArrayParameters pdfLoadDocumentFromByteArrayParameters)
        {
            // verify the required parameter 'pdfLoadDocumentFromByteArrayParameters' is set
            if (pdfLoadDocumentFromByteArrayParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfLoadDocumentFromByteArrayParameters' when calling PDFApi->LoadDocumentAsPDF");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfLoadDocumentFromByteArrayParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/LoadDocument",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/LoadDocument failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfLoadDocumentResponse)ApiClient.DeserializeResponse(response, typeof(PdfLoadDocumentResponse));
        }

        /// <summary>
        /// Imports the provided document as PDF using Multipart Upload.  Supported document formats can be retrieved by the GetPDFImportSupportedFileExtensions action. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileData">The data of the document.</param>
        /// <param name="loadDocumentParameters"> (optional)</param>
        /// <returns>IRestResponse of PdfLoadDocumentResponse</returns>
        public PdfLoadDocumentResponse LoadDocumentAsPDFMultipart(System.IO.Stream fileData, PdfLoadDocumentParameters loadDocumentParameters = null)
        {
            // verify the required parameter 'fileData' is set
            if (fileData == null)
                throw new ArgumentNullException("Missing required parameter 'fileData' when calling PDFApi->LoadDocumentAsPDFMultipart");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "multipart/form-data" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            if (fileData != null)
            {
                requestOptions.FileParameters.Add("fileData", fileData);
            }
            if (loadDocumentParameters != null)
            {
                requestOptions.FormParameters.Add("loadDocumentParameters", ClientUtils.ParameterToString(loadDocumentParameters)); // form parameter
            }
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/LoadDocumentAsPDFMultipart",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/LoadDocumentAsPDFMultipart failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfLoadDocumentResponse)ApiClient.DeserializeResponse(response, typeof(PdfLoadDocumentResponse));
        }

        /// <summary>
        /// Imports the provided document as PDF using Multipart Upload.  Supported document formats can be retrieved by the GetPDFImportSupportedFileExtensions action. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileData">The data of the document.</param>
        /// <param name="loadDocumentParameters"> (optional)</param>
        /// <returns>Task of IRestResponse (PdfLoadDocumentResponse)</returns>
        public async Task<PdfLoadDocumentResponse> LoadDocumentAsPDFMultipartAsync(System.IO.Stream fileData, PdfLoadDocumentParameters loadDocumentParameters = null)
        {
            // verify the required parameter 'fileData' is set
            if (fileData == null)
                throw new ArgumentNullException("Missing required parameter 'fileData' when calling PDFApi->LoadDocumentAsPDFMultipart");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "multipart/form-data" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            if (fileData != null)
            {
                requestOptions.FileParameters.Add("fileData", fileData);
            }
            if (loadDocumentParameters != null)
            {
                requestOptions.FormParameters.Add("loadDocumentParameters", ClientUtils.ParameterToString(loadDocumentParameters)); // form parameter
            }

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/LoadDocumentAsPDFMultipart",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/LoadDocumentAsPDFMultipart failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfLoadDocumentResponse)ApiClient.DeserializeResponse(response, typeof(PdfLoadDocumentResponse));
        }

        /// <summary>
        /// Merges several previously uploaded documents into a new PDF. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfMergeParameters">A PdfMergeParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfMergeResponse</returns>
        public PdfMergeResponse Merge(PdfMergeParameters pdfMergeParameters)
        {
            // verify the required parameter 'pdfMergeParameters' is set
            if (pdfMergeParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfMergeParameters' when calling PDFApi->Merge");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfMergeParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/Merge",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/Merge failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfMergeResponse)ApiClient.DeserializeResponse(response, typeof(PdfMergeResponse));
        }

        /// <summary>
        /// Merges several previously uploaded documents into a new PDF. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfMergeParameters">A PdfMergeParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfMergeResponse)</returns>
        public async Task<PdfMergeResponse> MergeAsync(PdfMergeParameters pdfMergeParameters)
        {
            // verify the required parameter 'pdfMergeParameters' is set
            if (pdfMergeParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfMergeParameters' when calling PDFApi->Merge");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfMergeParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/Merge",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/Merge failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfMergeResponse)ApiClient.DeserializeResponse(response, typeof(PdfMergeResponse));
        }

        /// <summary>
        /// Merges multiple pages, vertically, within a previously uploaded document into one single page. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfMergePagesParameters">A PdfMergePages object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfMergePagesResponse</returns>
        public PdfMergePagesResponse MergePages(PdfMergePagesParameters pdfMergePagesParameters)
        {
            // verify the required parameter 'pdfMergePagesParameters' is set
            if (pdfMergePagesParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfMergePagesParameters' when calling PDFApi->MergePages");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfMergePagesParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/MergePages",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/MergePages failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfMergePagesResponse)ApiClient.DeserializeResponse(response, typeof(PdfMergePagesResponse));
        }

        /// <summary>
        /// Merges multiple pages, vertically, within a previously uploaded document into one single page. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfMergePagesParameters">A PdfMergePages object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfMergePagesResponse)</returns>
        public async Task<PdfMergePagesResponse> MergePagesAsync(PdfMergePagesParameters pdfMergePagesParameters)
        {
            // verify the required parameter 'pdfMergePagesParameters' is set
            if (pdfMergePagesParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfMergePagesParameters' when calling PDFApi->MergePages");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfMergePagesParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/MergePages",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/MergePages failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfMergePagesResponse)ApiClient.DeserializeResponse(response, typeof(PdfMergePagesResponse));
        }

        /// <summary>
        /// Moves a page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfMovePageParameters">A PdfMovePageParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfMovePageResponse</returns>
        public PdfMovePageResponse MovePage(PdfMovePageParameters pdfMovePageParameters)
        {
            // verify the required parameter 'pdfMovePageParameters' is set
            if (pdfMovePageParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfMovePageParameters' when calling PDFApi->MovePage");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfMovePageParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/MovePage",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/MovePage failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfMovePageResponse)ApiClient.DeserializeResponse(response, typeof(PdfMovePageResponse));
        }

        /// <summary>
        /// Moves a page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfMovePageParameters">A PdfMovePageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfMovePageResponse)</returns>
        public async Task<PdfMovePageResponse> MovePageAsync(PdfMovePageParameters pdfMovePageParameters)
        {
            // verify the required parameter 'pdfMovePageParameters' is set
            if (pdfMovePageParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfMovePageParameters' when calling PDFApi->MovePage");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfMovePageParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/MovePage",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/MovePage failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfMovePageResponse)ApiClient.DeserializeResponse(response, typeof(PdfMovePageResponse));
        }

        /// <summary>
        /// Performs optical character recognition on a page range of a previously uploaded document.  The recognized text is added as invisible text on each processed page.  No token is charged for blank pages. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfOCRParameters">A PdfOCRParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfOCRResponse</returns>
        public PdfOCRResponse OCR(PdfOCRParameters pdfOCRParameters)
        {
            // verify the required parameter 'pdfOCRParameters' is set
            if (pdfOCRParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfOCRParameters' when calling PDFApi->OCR");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfOCRParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/OCR",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/OCR failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfOCRResponse)ApiClient.DeserializeResponse(response, typeof(PdfOCRResponse));
        }

        /// <summary>
        /// Performs optical character recognition on a page range of a previously uploaded document.  The recognized text is added as invisible text on each processed page.  No token is charged for blank pages. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfOCRParameters">A PdfOCRParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfOCRResponse)</returns>
        public async Task<PdfOCRResponse> OCRAsync(PdfOCRParameters pdfOCRParameters)
        {
            // verify the required parameter 'pdfOCRParameters' is set
            if (pdfOCRParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfOCRParameters' when calling PDFApi->OCR");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfOCRParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/OCR",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/OCR failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfOCRResponse)ApiClient.DeserializeResponse(response, typeof(PdfOCRResponse));
        }

        /// <summary>
        /// Protects a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfProtectParameters">A PdfProtectParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfProtectResponse</returns>
        public PdfProtectResponse Protect(PdfProtectParameters pdfProtectParameters)
        {
            // verify the required parameter 'pdfProtectParameters' is set
            if (pdfProtectParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfProtectParameters' when calling PDFApi->Protect");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfProtectParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/Protect",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/Protect failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfProtectResponse)ApiClient.DeserializeResponse(response, typeof(PdfProtectResponse));
        }

        /// <summary>
        /// Protects a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfProtectParameters">A PdfProtectParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfProtectResponse)</returns>
        public async Task<PdfProtectResponse> ProtectAsync(PdfProtectParameters pdfProtectParameters)
        {
            // verify the required parameter 'pdfProtectParameters' is set
            if (pdfProtectParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfProtectParameters' when calling PDFApi->Protect");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfProtectParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/Protect",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/Protect failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfProtectResponse)ApiClient.DeserializeResponse(response, typeof(PdfProtectResponse));
        }

        /// <summary>
        /// Reads barcodes from a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfReadBarcodesParameters">A PdfReadBarcodesParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of ReadBarcodesResponse</returns>
        public ReadBarcodesResponse ReadBarcodes(PdfReadBarcodesParameters pdfReadBarcodesParameters)
        {
            // verify the required parameter 'pdfReadBarcodesParameters' is set
            if (pdfReadBarcodesParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfReadBarcodesParameters' when calling PDFApi->ReadBarcodes");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfReadBarcodesParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/ReadBarcodes",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/ReadBarcodes failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ReadBarcodesResponse)ApiClient.DeserializeResponse(response, typeof(ReadBarcodesResponse));
        }

        /// <summary>
        /// Reads barcodes from a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfReadBarcodesParameters">A PdfReadBarcodesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (ReadBarcodesResponse)</returns>
        public async Task<ReadBarcodesResponse> ReadBarcodesAsync(PdfReadBarcodesParameters pdfReadBarcodesParameters)
        {
            // verify the required parameter 'pdfReadBarcodesParameters' is set
            if (pdfReadBarcodesParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfReadBarcodesParameters' when calling PDFApi->ReadBarcodes");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfReadBarcodesParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/ReadBarcodes",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/ReadBarcodes failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ReadBarcodesResponse)ApiClient.DeserializeResponse(response, typeof(ReadBarcodesResponse));
        }

        /// <summary>
        /// Reduces the size of a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfReduceParameters">A PdfReduceParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfReduceResponse</returns>
        public PdfReduceResponse Reduce(PdfReduceParameters pdfReduceParameters)
        {
            // verify the required parameter 'pdfReduceParameters' is set
            if (pdfReduceParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfReduceParameters' when calling PDFApi->Reduce");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfReduceParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/Reduce",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/Reduce failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfReduceResponse)ApiClient.DeserializeResponse(response, typeof(PdfReduceResponse));
        }

        /// <summary>
        /// Reduces the size of a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfReduceParameters">A PdfReduceParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfReduceResponse)</returns>
        public async Task<PdfReduceResponse> ReduceAsync(PdfReduceParameters pdfReduceParameters)
        {
            // verify the required parameter 'pdfReduceParameters' is set
            if (pdfReduceParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfReduceParameters' when calling PDFApi->Reduce");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfReduceParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/Reduce",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/Reduce failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfReduceResponse)ApiClient.DeserializeResponse(response, typeof(PdfReduceResponse));
        }

        /// <summary>
        /// Removes the form fields from a page range of a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfRemovePageFormFieldsParameters">A PdfRemovePageFormFieldsParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfRemovePageFormFieldsResponse</returns>
        public PdfRemovePageFormFieldsResponse RemovePageFormFields(PdfRemovePageFormFieldsParameters pdfRemovePageFormFieldsParameters)
        {
            // verify the required parameter 'pdfRemovePageFormFieldsParameters' is set
            if (pdfRemovePageFormFieldsParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfRemovePageFormFieldsParameters' when calling PDFApi->RemovePageFormFields");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfRemovePageFormFieldsParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/RemovePageFormFields",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/RemovePageFormFields failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfRemovePageFormFieldsResponse)ApiClient.DeserializeResponse(response, typeof(PdfRemovePageFormFieldsResponse));
        }

        /// <summary>
        /// Removes the form fields from a page range of a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfRemovePageFormFieldsParameters">A PdfRemovePageFormFieldsParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfRemovePageFormFieldsResponse)</returns>
        public async Task<PdfRemovePageFormFieldsResponse> RemovePageFormFieldsAsync(PdfRemovePageFormFieldsParameters pdfRemovePageFormFieldsParameters)
        {
            // verify the required parameter 'pdfRemovePageFormFieldsParameters' is set
            if (pdfRemovePageFormFieldsParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfRemovePageFormFieldsParameters' when calling PDFApi->RemovePageFormFields");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfRemovePageFormFieldsParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/RemovePageFormFields",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/RemovePageFormFields failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfRemovePageFormFieldsResponse)ApiClient.DeserializeResponse(response, typeof(PdfRemovePageFormFieldsResponse));
        }

        /// <summary>
        /// Reorders pages of a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfReorderPagesParameters">A PdfReorderPagesParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfReorderPagesResponse</returns>
        public PdfReorderPagesResponse ReorderPages(PdfReorderPagesParameters pdfReorderPagesParameters)
        {
            // verify the required parameter 'pdfReorderPagesParameters' is set
            if (pdfReorderPagesParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfReorderPagesParameters' when calling PDFApi->ReorderPages");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfReorderPagesParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/ReorderPages",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/ReorderPages failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfReorderPagesResponse)ApiClient.DeserializeResponse(response, typeof(PdfReorderPagesResponse));
        }

        /// <summary>
        /// Reorders pages of a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfReorderPagesParameters">A PdfReorderPagesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfReorderPagesResponse)</returns>
        public async Task<PdfReorderPagesResponse> ReorderPagesAsync(PdfReorderPagesParameters pdfReorderPagesParameters)
        {
            // verify the required parameter 'pdfReorderPagesParameters' is set
            if (pdfReorderPagesParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfReorderPagesParameters' when calling PDFApi->ReorderPages");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfReorderPagesParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/ReorderPages",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/ReorderPages failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfReorderPagesResponse)ApiClient.DeserializeResponse(response, typeof(PdfReorderPagesResponse));
        }

        /// <summary>
        /// Repairs a previously uploaded PDF document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfRepairDocumentParameters">A PdfRepairDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfRepairDocumentResponse</returns>
        public PdfRepairDocumentResponse RepairDocument(PdfRepairDocumentParameters pdfRepairDocumentParameters)
        {
            // verify the required parameter 'pdfRepairDocumentParameters' is set
            if (pdfRepairDocumentParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfRepairDocumentParameters' when calling PDFApi->RepairDocument");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfRepairDocumentParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/RepairDocument",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/RepairDocument failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfRepairDocumentResponse)ApiClient.DeserializeResponse(response, typeof(PdfRepairDocumentResponse));
        }

        /// <summary>
        /// Repairs a previously uploaded PDF document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfRepairDocumentParameters">A PdfRepairDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfRepairDocumentResponse)</returns>
        public async Task<PdfRepairDocumentResponse> RepairDocumentAsync(PdfRepairDocumentParameters pdfRepairDocumentParameters)
        {
            // verify the required parameter 'pdfRepairDocumentParameters' is set
            if (pdfRepairDocumentParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfRepairDocumentParameters' when calling PDFApi->RepairDocument");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfRepairDocumentParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/RepairDocument",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/RepairDocument failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfRepairDocumentResponse)ApiClient.DeserializeResponse(response, typeof(PdfRepairDocumentResponse));
        }

        /// <summary>
        /// Rotates (standardly) a page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfRotatePageStandardParameters">A PdfRotatePageStandardParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfRotatePageStandardResponse</returns>
        public PdfRotatePageStandardResponse RotatePageStandard(PdfRotatePageStandardParameters pdfRotatePageStandardParameters)
        {
            // verify the required parameter 'pdfRotatePageStandardParameters' is set
            if (pdfRotatePageStandardParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfRotatePageStandardParameters' when calling PDFApi->RotatePageStandard");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfRotatePageStandardParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/RotatePageStandard",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/RotatePageStandard failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfRotatePageStandardResponse)ApiClient.DeserializeResponse(response, typeof(PdfRotatePageStandardResponse));
        }

        /// <summary>
        /// Rotates (standardly) a page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfRotatePageStandardParameters">A PdfRotatePageStandardParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfRotatePageStandardResponse)</returns>
        public async Task<PdfRotatePageStandardResponse> RotatePageStandardAsync(PdfRotatePageStandardParameters pdfRotatePageStandardParameters)
        {
            // verify the required parameter 'pdfRotatePageStandardParameters' is set
            if (pdfRotatePageStandardParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfRotatePageStandardParameters' when calling PDFApi->RotatePageStandard");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfRotatePageStandardParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/RotatePageStandard",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/RotatePageStandard failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfRotatePageStandardResponse)ApiClient.DeserializeResponse(response, typeof(PdfRotatePageStandardResponse));
        }

        /// <summary>
        /// Saves a previously uploaded document as JPEG. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsJPEGParameters">A PdfSaveAsJPEGParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfSaveAsJPEGResponse</returns>
        public PdfSaveAsJPEGResponse SaveAsJPEG(PdfSaveAsJPEGParameters pdfSaveAsJPEGParameters)
        {
            // verify the required parameter 'pdfSaveAsJPEGParameters' is set
            if (pdfSaveAsJPEGParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSaveAsJPEGParameters' when calling PDFApi->SaveAsJPEG");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfSaveAsJPEGParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/SaveAsJPEG",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SaveAsJPEG failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfSaveAsJPEGResponse)ApiClient.DeserializeResponse(response, typeof(PdfSaveAsJPEGResponse));
        }

        /// <summary>
        /// Saves a previously uploaded document as JPEG. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsJPEGParameters">A PdfSaveAsJPEGParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfSaveAsJPEGResponse)</returns>
        public async Task<PdfSaveAsJPEGResponse> SaveAsJPEGAsync(PdfSaveAsJPEGParameters pdfSaveAsJPEGParameters)
        {
            // verify the required parameter 'pdfSaveAsJPEGParameters' is set
            if (pdfSaveAsJPEGParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSaveAsJPEGParameters' when calling PDFApi->SaveAsJPEG");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfSaveAsJPEGParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/SaveAsJPEG",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SaveAsJPEG failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfSaveAsJPEGResponse)ApiClient.DeserializeResponse(response, typeof(PdfSaveAsJPEGResponse));
        }

        /// <summary>
        /// Saves a previously uploaded document as JPEG. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsJPEGParameters">A PdfSaveAsJPEGParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of System.IO.Stream</returns>
        public void SaveAsJPEGFile(PdfSaveAsJPEGParameters pdfSaveAsJPEGParameters, System.IO.Stream destinationStream)
        {
            // verify the required parameter 'pdfSaveAsJPEGParameters' is set
            if (pdfSaveAsJPEGParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSaveAsJPEGParameters' when calling PDFApi->SaveAsJPEGFile");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfSaveAsJPEGParameters;

            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
              "/api/pdf/SaveAsJPEGFile",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SaveAsJPEGFile failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            try
            {
                destinationStream.Write(response.RawBytes, 0, response.RawBytes.Length);
            }
            catch (Exception exception)
            {
                throw new ApiException("Failed to write the file content returned by the API to the destination stream", exception);
            }
        }

        /// <summary>
        /// Saves a previously uploaded document as JPEG. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsJPEGParameters">A PdfSaveAsJPEGParameters object specifying the parameters of the action.</param>
        public async Task SaveAsJPEGFileAsync(PdfSaveAsJPEGParameters pdfSaveAsJPEGParameters, System.IO.Stream destinationStream)
        {
            // verify the required parameter 'pdfSaveAsJPEGParameters' is set
            if (pdfSaveAsJPEGParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSaveAsJPEGParameters' when calling PDFApi->SaveAsJPEGFile");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);


            requestOptions.Data = pdfSaveAsJPEGParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/SaveAsJPEGFile",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SaveAsJPEGFile failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            try
            {
                await destinationStream.WriteAsync(response.RawBytes, 0, response.RawBytes.Length);
            }
            catch (Exception exception)
            {
                throw new ApiException("Failed to write the file content returned by the API to the destination stream", exception);
            }
        }

        /// <summary>
        /// Saves a previously uploaded document as PNG. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsPNGParameters">A PdfSaveAsPNGParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfSaveAsPNGResponse</returns>
        public PdfSaveAsPNGResponse SaveAsPNG(PdfSaveAsPNGParameters pdfSaveAsPNGParameters)
        {
            // verify the required parameter 'pdfSaveAsPNGParameters' is set
            if (pdfSaveAsPNGParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSaveAsPNGParameters' when calling PDFApi->SaveAsPNG");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfSaveAsPNGParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/SaveAsPNG",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SaveAsPNG failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfSaveAsPNGResponse)ApiClient.DeserializeResponse(response, typeof(PdfSaveAsPNGResponse));
        }

        /// <summary>
        /// Saves a previously uploaded document as PNG. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsPNGParameters">A PdfSaveAsPNGParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfSaveAsPNGResponse)</returns>
        public async Task<PdfSaveAsPNGResponse> SaveAsPNGAsync(PdfSaveAsPNGParameters pdfSaveAsPNGParameters)
        {
            // verify the required parameter 'pdfSaveAsPNGParameters' is set
            if (pdfSaveAsPNGParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSaveAsPNGParameters' when calling PDFApi->SaveAsPNG");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfSaveAsPNGParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/SaveAsPNG",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SaveAsPNG failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfSaveAsPNGResponse)ApiClient.DeserializeResponse(response, typeof(PdfSaveAsPNGResponse));
        }

        /// <summary>
        /// Saves a previously uploaded document as PNG. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsPNGParameters">A PdfSaveAsPNGParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of System.IO.Stream</returns>
        public void SaveAsPNGFile(PdfSaveAsPNGParameters pdfSaveAsPNGParameters, System.IO.Stream destinationStream)
        {
            // verify the required parameter 'pdfSaveAsPNGParameters' is set
            if (pdfSaveAsPNGParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSaveAsPNGParameters' when calling PDFApi->SaveAsPNGFile");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfSaveAsPNGParameters;

            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
              "/api/pdf/SaveAsPNGFile",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SaveAsPNGFile failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            try
            {
                destinationStream.Write(response.RawBytes, 0, response.RawBytes.Length);
            }
            catch (Exception exception)
            {
                throw new ApiException("Failed to write the file content returned by the API to the destination stream", exception);
            }
        }

        /// <summary>
        /// Saves a previously uploaded document as PNG. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsPNGParameters">A PdfSaveAsPNGParameters object specifying the parameters of the action.</param>
        public async Task SaveAsPNGFileAsync(PdfSaveAsPNGParameters pdfSaveAsPNGParameters, System.IO.Stream destinationStream)
        {
            // verify the required parameter 'pdfSaveAsPNGParameters' is set
            if (pdfSaveAsPNGParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSaveAsPNGParameters' when calling PDFApi->SaveAsPNGFile");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);


            requestOptions.Data = pdfSaveAsPNGParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/SaveAsPNGFile",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SaveAsPNGFile failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            try
            {
                await destinationStream.WriteAsync(response.RawBytes, 0, response.RawBytes.Length);
            }
            catch (Exception exception)
            {
                throw new ApiException("Failed to write the file content returned by the API to the destination stream", exception);
            }
        }

        /// <summary>
        /// Saves a previously uploaded document as TIFF. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsTIFFParameters">A PdfSaveAsTIFFParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfSaveAsTIFFResponse</returns>
        public PdfSaveAsTIFFResponse SaveAsTIFF(PdfSaveAsTIFFParameters pdfSaveAsTIFFParameters)
        {
            // verify the required parameter 'pdfSaveAsTIFFParameters' is set
            if (pdfSaveAsTIFFParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSaveAsTIFFParameters' when calling PDFApi->SaveAsTIFF");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfSaveAsTIFFParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/SaveAsTIFF",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SaveAsTIFF failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfSaveAsTIFFResponse)ApiClient.DeserializeResponse(response, typeof(PdfSaveAsTIFFResponse));
        }

        /// <summary>
        /// Saves a previously uploaded document as TIFF. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsTIFFParameters">A PdfSaveAsTIFFParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfSaveAsTIFFResponse)</returns>
        public async Task<PdfSaveAsTIFFResponse> SaveAsTIFFAsync(PdfSaveAsTIFFParameters pdfSaveAsTIFFParameters)
        {
            // verify the required parameter 'pdfSaveAsTIFFParameters' is set
            if (pdfSaveAsTIFFParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSaveAsTIFFParameters' when calling PDFApi->SaveAsTIFF");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfSaveAsTIFFParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/SaveAsTIFF",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SaveAsTIFF failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfSaveAsTIFFResponse)ApiClient.DeserializeResponse(response, typeof(PdfSaveAsTIFFResponse));
        }

        /// <summary>
        /// Saves a previously uploaded document as TIFF. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsTIFFParameters">A PdfSaveAsTIFFParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of System.IO.Stream</returns>
        public void SaveAsTIFFFile(PdfSaveAsTIFFParameters pdfSaveAsTIFFParameters, System.IO.Stream destinationStream)
        {
            // verify the required parameter 'pdfSaveAsTIFFParameters' is set
            if (pdfSaveAsTIFFParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSaveAsTIFFParameters' when calling PDFApi->SaveAsTIFFFile");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfSaveAsTIFFParameters;

            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
              "/api/pdf/SaveAsTIFFFile",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SaveAsTIFFFile failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            try
            {
                destinationStream.Write(response.RawBytes, 0, response.RawBytes.Length);
            }
            catch (Exception exception)
            {
                throw new ApiException("Failed to write the file content returned by the API to the destination stream", exception);
            }
        }

        /// <summary>
        /// Saves a previously uploaded document as TIFF. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsTIFFParameters">A PdfSaveAsTIFFParameters object specifying the parameters of the action.</param>
        public async Task SaveAsTIFFFileAsync(PdfSaveAsTIFFParameters pdfSaveAsTIFFParameters, System.IO.Stream destinationStream)
        {
            // verify the required parameter 'pdfSaveAsTIFFParameters' is set
            if (pdfSaveAsTIFFParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSaveAsTIFFParameters' when calling PDFApi->SaveAsTIFFFile");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);


            requestOptions.Data = pdfSaveAsTIFFParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/SaveAsTIFFFile",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SaveAsTIFFFile failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            try
            {
                await destinationStream.WriteAsync(response.RawBytes, 0, response.RawBytes.Length);
            }
            catch (Exception exception)
            {
                throw new ApiException("Failed to write the file content returned by the API to the destination stream", exception);
            }
        }

        /// <summary>
        /// Saves a previously uploaded document as multipage TIFF. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsTIFFMultipageParameters">A PdfSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfSaveAsTIFFMultipageResponse</returns>
        public PdfSaveAsTIFFMultipageResponse SaveAsTIFFMultipage(PdfSaveAsTIFFMultipageParameters pdfSaveAsTIFFMultipageParameters)
        {
            // verify the required parameter 'pdfSaveAsTIFFMultipageParameters' is set
            if (pdfSaveAsTIFFMultipageParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSaveAsTIFFMultipageParameters' when calling PDFApi->SaveAsTIFFMultipage");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfSaveAsTIFFMultipageParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/SaveAsTIFFMultipage",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SaveAsTIFFMultipage failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfSaveAsTIFFMultipageResponse)ApiClient.DeserializeResponse(response, typeof(PdfSaveAsTIFFMultipageResponse));
        }

        /// <summary>
        /// Saves a previously uploaded document as multipage TIFF. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsTIFFMultipageParameters">A PdfSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfSaveAsTIFFMultipageResponse)</returns>
        public async Task<PdfSaveAsTIFFMultipageResponse> SaveAsTIFFMultipageAsync(PdfSaveAsTIFFMultipageParameters pdfSaveAsTIFFMultipageParameters)
        {
            // verify the required parameter 'pdfSaveAsTIFFMultipageParameters' is set
            if (pdfSaveAsTIFFMultipageParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSaveAsTIFFMultipageParameters' when calling PDFApi->SaveAsTIFFMultipage");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfSaveAsTIFFMultipageParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/SaveAsTIFFMultipage",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SaveAsTIFFMultipage failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfSaveAsTIFFMultipageResponse)ApiClient.DeserializeResponse(response, typeof(PdfSaveAsTIFFMultipageResponse));
        }

        /// <summary>
        /// Saves a previously uploaded document as multipage TIFF. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsTIFFMultipageParameters">A PdfSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of System.IO.Stream</returns>
        public void SaveAsTIFFMultipageFile(PdfSaveAsTIFFMultipageParameters pdfSaveAsTIFFMultipageParameters, System.IO.Stream destinationStream)
        {
            // verify the required parameter 'pdfSaveAsTIFFMultipageParameters' is set
            if (pdfSaveAsTIFFMultipageParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSaveAsTIFFMultipageParameters' when calling PDFApi->SaveAsTIFFMultipageFile");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfSaveAsTIFFMultipageParameters;

            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
              "/api/pdf/SaveAsTIFFMultipageFile",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SaveAsTIFFMultipageFile failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            try
            {
                destinationStream.Write(response.RawBytes, 0, response.RawBytes.Length);
            }
            catch (Exception exception)
            {
                throw new ApiException("Failed to write the file content returned by the API to the destination stream", exception);
            }
        }

        /// <summary>
        /// Saves a previously uploaded document as multipage TIFF. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveAsTIFFMultipageParameters">A PdfSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        public async Task SaveAsTIFFMultipageFileAsync(PdfSaveAsTIFFMultipageParameters pdfSaveAsTIFFMultipageParameters, System.IO.Stream destinationStream)
        {
            // verify the required parameter 'pdfSaveAsTIFFMultipageParameters' is set
            if (pdfSaveAsTIFFMultipageParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSaveAsTIFFMultipageParameters' when calling PDFApi->SaveAsTIFFMultipageFile");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);


            requestOptions.Data = pdfSaveAsTIFFMultipageParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/SaveAsTIFFMultipageFile",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SaveAsTIFFMultipageFile failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            try
            {
                await destinationStream.WriteAsync(response.RawBytes, 0, response.RawBytes.Length);
            }
            catch (Exception exception)
            {
                throw new ApiException("Failed to write the file content returned by the API to the destination stream", exception);
            }
        }

        /// <summary>
        /// Saves a previously uploaded document as PDF. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveDocumentParameters">A PdfSaveDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfSaveDocumentResponse</returns>
        public PdfSaveDocumentResponse SaveDocument(PdfSaveDocumentParameters pdfSaveDocumentParameters)
        {
            // verify the required parameter 'pdfSaveDocumentParameters' is set
            if (pdfSaveDocumentParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSaveDocumentParameters' when calling PDFApi->SaveDocument");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfSaveDocumentParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/SaveDocument",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SaveDocument failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfSaveDocumentResponse)ApiClient.DeserializeResponse(response, typeof(PdfSaveDocumentResponse));
        }

        /// <summary>
        /// Saves a previously uploaded document as PDF. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveDocumentParameters">A PdfSaveDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfSaveDocumentResponse)</returns>
        public async Task<PdfSaveDocumentResponse> SaveDocumentAsync(PdfSaveDocumentParameters pdfSaveDocumentParameters)
        {
            // verify the required parameter 'pdfSaveDocumentParameters' is set
            if (pdfSaveDocumentParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSaveDocumentParameters' when calling PDFApi->SaveDocument");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfSaveDocumentParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/SaveDocument",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SaveDocument failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfSaveDocumentResponse)ApiClient.DeserializeResponse(response, typeof(PdfSaveDocumentResponse));
        }

        /// <summary>
        /// Saves a previously uploaded document as PDF. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveDocumentParameters">A PdfSaveDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of System.IO.Stream</returns>
        public void SaveDocumentToFile(PdfSaveDocumentParameters pdfSaveDocumentParameters, System.IO.Stream destinationStream)
        {
            // verify the required parameter 'pdfSaveDocumentParameters' is set
            if (pdfSaveDocumentParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSaveDocumentParameters' when calling PDFApi->SaveDocumentToFile");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfSaveDocumentParameters;

            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
              "/api/pdf/SaveDocumentToFile",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SaveDocumentToFile failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            try
            {
                destinationStream.Write(response.RawBytes, 0, response.RawBytes.Length);
            }
            catch (Exception exception)
            {
                throw new ApiException("Failed to write the file content returned by the API to the destination stream", exception);
            }
        }

        /// <summary>
        /// Saves a previously uploaded document as PDF. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSaveDocumentParameters">A PdfSaveDocumentParameters object specifying the parameters of the action.</param>
        public async Task SaveDocumentToFileAsync(PdfSaveDocumentParameters pdfSaveDocumentParameters, System.IO.Stream destinationStream)
        {
            // verify the required parameter 'pdfSaveDocumentParameters' is set
            if (pdfSaveDocumentParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSaveDocumentParameters' when calling PDFApi->SaveDocumentToFile");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);


            requestOptions.Data = pdfSaveDocumentParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/SaveDocumentToFile",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SaveDocumentToFile failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            try
            {
                await destinationStream.WriteAsync(response.RawBytes, 0, response.RawBytes.Length);
            }
            catch (Exception exception)
            {
                throw new ApiException("Failed to write the file content returned by the API to the destination stream", exception);
            }
        }

        /// <summary>
        /// Scales a page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfScalePageParameters">A PdfScalePage object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfScalePageResponse</returns>
        public PdfScalePageResponse ScalePage(PdfScalePageParameters pdfScalePageParameters)
        {
            // verify the required parameter 'pdfScalePageParameters' is set
            if (pdfScalePageParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfScalePageParameters' when calling PDFApi->ScalePage");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfScalePageParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/ScalePage",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/ScalePage failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfScalePageResponse)ApiClient.DeserializeResponse(response, typeof(PdfScalePageResponse));
        }

        /// <summary>
        /// Scales a page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfScalePageParameters">A PdfScalePage object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfScalePageResponse)</returns>
        public async Task<PdfScalePageResponse> ScalePageAsync(PdfScalePageParameters pdfScalePageParameters)
        {
            // verify the required parameter 'pdfScalePageParameters' is set
            if (pdfScalePageParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfScalePageParameters' when calling PDFApi->ScalePage");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfScalePageParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/ScalePage",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/ScalePage failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfScalePageResponse)ApiClient.DeserializeResponse(response, typeof(PdfScalePageResponse));
        }

        /// <summary>
        /// Sets information to a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSetInfoParameters">A PdfSetInfoParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfSetInfoResponse</returns>
        public PdfSetInfoResponse SetInfo(PdfSetInfoParameters pdfSetInfoParameters)
        {
            // verify the required parameter 'pdfSetInfoParameters' is set
            if (pdfSetInfoParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSetInfoParameters' when calling PDFApi->SetInfo");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfSetInfoParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/SetInfo",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SetInfo failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfSetInfoResponse)ApiClient.DeserializeResponse(response, typeof(PdfSetInfoResponse));
        }

        /// <summary>
        /// Sets information to a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSetInfoParameters">A PdfSetInfoParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfSetInfoResponse)</returns>
        public async Task<PdfSetInfoResponse> SetInfoAsync(PdfSetInfoParameters pdfSetInfoParameters)
        {
            // verify the required parameter 'pdfSetInfoParameters' is set
            if (pdfSetInfoParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSetInfoParameters' when calling PDFApi->SetInfo");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfSetInfoParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/SetInfo",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SetInfo failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfSetInfoResponse)ApiClient.DeserializeResponse(response, typeof(PdfSetInfoResponse));
        }

        /// <summary>
        /// Sets various document level initial view options to a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSetInitialViewParameters">A PdfsetInitialViewParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfSetInitialViewResponse</returns>
        public PdfSetInitialViewResponse SetInitialView(PdfSetInitialViewParameters pdfSetInitialViewParameters)
        {
            // verify the required parameter 'pdfSetInitialViewParameters' is set
            if (pdfSetInitialViewParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSetInitialViewParameters' when calling PDFApi->SetInitialView");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfSetInitialViewParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/SetInitialView",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SetInitialView failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfSetInitialViewResponse)ApiClient.DeserializeResponse(response, typeof(PdfSetInitialViewResponse));
        }

        /// <summary>
        /// Sets various document level initial view options to a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSetInitialViewParameters">A PdfsetInitialViewParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfSetInitialViewResponse)</returns>
        public async Task<PdfSetInitialViewResponse> SetInitialViewAsync(PdfSetInitialViewParameters pdfSetInitialViewParameters)
        {
            // verify the required parameter 'pdfSetInitialViewParameters' is set
            if (pdfSetInitialViewParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSetInitialViewParameters' when calling PDFApi->SetInitialView");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfSetInitialViewParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/SetInitialView",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SetInitialView failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfSetInitialViewResponse)ApiClient.DeserializeResponse(response, typeof(PdfSetInitialViewResponse));
        }

        /// <summary>
        /// Sets pagebox to a page range from previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSetPageBoxParameters">A PdfSetPageBoxParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfSetPageBoxResponse</returns>
        public PdfSetPageBoxResponse SetPageBox(PdfSetPageBoxParameters pdfSetPageBoxParameters)
        {
            // verify the required parameter 'pdfSetPageBoxParameters' is set
            if (pdfSetPageBoxParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSetPageBoxParameters' when calling PDFApi->SetPageBox");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfSetPageBoxParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/SetPageBox",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SetPageBox failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfSetPageBoxResponse)ApiClient.DeserializeResponse(response, typeof(PdfSetPageBoxResponse));
        }

        /// <summary>
        /// Sets pagebox to a page range from previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSetPageBoxParameters">A PdfSetPageBoxParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfSetPageBoxResponse)</returns>
        public async Task<PdfSetPageBoxResponse> SetPageBoxAsync(PdfSetPageBoxParameters pdfSetPageBoxParameters)
        {
            // verify the required parameter 'pdfSetPageBoxParameters' is set
            if (pdfSetPageBoxParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSetPageBoxParameters' when calling PDFApi->SetPageBox");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfSetPageBoxParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/SetPageBox",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SetPageBox failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfSetPageBoxResponse)ApiClient.DeserializeResponse(response, typeof(PdfSetPageBoxResponse));
        }

        /// <summary>
        /// Unprotects a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSetPasswordParameters">A PdfSetPasswordParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfSetPasswordResponse</returns>
        public PdfSetPasswordResponse SetPassword(PdfSetPasswordParameters pdfSetPasswordParameters)
        {
            // verify the required parameter 'pdfSetPasswordParameters' is set
            if (pdfSetPasswordParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSetPasswordParameters' when calling PDFApi->SetPassword");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfSetPasswordParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/SetPassword",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SetPassword failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfSetPasswordResponse)ApiClient.DeserializeResponse(response, typeof(PdfSetPasswordResponse));
        }

        /// <summary>
        /// Unprotects a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSetPasswordParameters">A PdfSetPasswordParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfSetPasswordResponse)</returns>
        public async Task<PdfSetPasswordResponse> SetPasswordAsync(PdfSetPasswordParameters pdfSetPasswordParameters)
        {
            // verify the required parameter 'pdfSetPasswordParameters' is set
            if (pdfSetPasswordParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSetPasswordParameters' when calling PDFApi->SetPassword");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfSetPasswordParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/SetPassword",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SetPassword failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfSetPasswordResponse)ApiClient.DeserializeResponse(response, typeof(PdfSetPasswordResponse));
        }

        /// <summary>
        /// Splits a previously uploaded document into new ones. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSplitParameters">A PdfSplitParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfSplitResponse</returns>
        public PdfSplitResponse Split(PdfSplitParameters pdfSplitParameters)
        {
            // verify the required parameter 'pdfSplitParameters' is set
            if (pdfSplitParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSplitParameters' when calling PDFApi->Split");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfSplitParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/Split",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/Split failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfSplitResponse)ApiClient.DeserializeResponse(response, typeof(PdfSplitResponse));
        }

        /// <summary>
        /// Splits a previously uploaded document into new ones. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSplitParameters">A PdfSplitParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfSplitResponse)</returns>
        public async Task<PdfSplitResponse> SplitAsync(PdfSplitParameters pdfSplitParameters)
        {
            // verify the required parameter 'pdfSplitParameters' is set
            if (pdfSplitParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSplitParameters' when calling PDFApi->Split");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfSplitParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/Split",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/Split failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfSplitResponse)ApiClient.DeserializeResponse(response, typeof(PdfSplitResponse));
        }

        /// <summary>
        /// Swaps two pages from a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSwapPagesParameters">A PdfSwapPagesParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfSwapPagesResponse</returns>
        public PdfSwapPagesResponse SwapPages(PdfSwapPagesParameters pdfSwapPagesParameters)
        {
            // verify the required parameter 'pdfSwapPagesParameters' is set
            if (pdfSwapPagesParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSwapPagesParameters' when calling PDFApi->SwapPages");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfSwapPagesParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/SwapPages",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SwapPages failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfSwapPagesResponse)ApiClient.DeserializeResponse(response, typeof(PdfSwapPagesResponse));
        }

        /// <summary>
        /// Swaps two pages from a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfSwapPagesParameters">A PdfSwapPagesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfSwapPagesResponse)</returns>
        public async Task<PdfSwapPagesResponse> SwapPagesAsync(PdfSwapPagesParameters pdfSwapPagesParameters)
        {
            // verify the required parameter 'pdfSwapPagesParameters' is set
            if (pdfSwapPagesParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfSwapPagesParameters' when calling PDFApi->SwapPages");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfSwapPagesParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/SwapPages",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/SwapPages failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfSwapPagesResponse)ApiClient.DeserializeResponse(response, typeof(PdfSwapPagesResponse));
        }

        /// <summary>
        /// Unprotects a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfUnprotectParameters">A PdfUnprotectParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of PdfUnprotectResponse</returns>
        public PdfUnprotectResponse Unprotect(PdfUnprotectParameters pdfUnprotectParameters)
        {
            // verify the required parameter 'pdfUnprotectParameters' is set
            if (pdfUnprotectParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfUnprotectParameters' when calling PDFApi->Unprotect");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = pdfUnprotectParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/pdf/Unprotect",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/Unprotect failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfUnprotectResponse)ApiClient.DeserializeResponse(response, typeof(PdfUnprotectResponse));
        }

        /// <summary>
        /// Unprotects a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="pdfUnprotectParameters">A PdfUnprotectParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (PdfUnprotectResponse)</returns>
        public async Task<PdfUnprotectResponse> UnprotectAsync(PdfUnprotectParameters pdfUnprotectParameters)
        {
            // verify the required parameter 'pdfUnprotectParameters' is set
            if (pdfUnprotectParameters == null)
                throw new ArgumentNullException("Missing required parameter 'pdfUnprotectParameters' when calling PDFApi->Unprotect");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = pdfUnprotectParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/pdf/Unprotect",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/pdf/Unprotect failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PdfUnprotectResponse)ApiClient.DeserializeResponse(response, typeof(PdfUnprotectResponse));
        }
    }
}
