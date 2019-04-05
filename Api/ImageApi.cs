/* 
 * PassportPDF API
 *
 * Copyright © 2019 PassportPDF - https://www.passportpdf.com
 *
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using PassportPDF.Client;
using PassportPDF.Model;

namespace PassportPDF.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IImageApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Adjusts a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageAdjustParameters">An ImageAdjustParameters object specifying the parameters for the action.</param>
        /// <returns>ImageAdjustResponse</returns>
        ImageAdjustResponse ImageAdjust (ImageAdjustParameters imageAdjustParameters);

        /// <summary>
        /// Adjusts a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageAdjustParameters">An ImageAdjustParameters object specifying the parameters for the action.</param>
        /// <returns>ApiResponse of ImageAdjustResponse</returns>
        ApiResponse<ImageAdjustResponse> ImageAdjustWithHttpInfo (ImageAdjustParameters imageAdjustParameters);
        /// <summary>
        /// Cleanup a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cleanupDocumentParameters">An ImageCleanupDocumentParameters object specifying the parameters for the action.</param>
        /// <returns>ImageCleanupDocumentResponse</returns>
        ImageCleanupDocumentResponse ImageCleanupDocument (ImageCleanupDocumentParameters cleanupDocumentParameters);

        /// <summary>
        /// Cleanup a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cleanupDocumentParameters">An ImageCleanupDocumentParameters object specifying the parameters for the action.</param>
        /// <returns>ApiResponse of ImageCleanupDocumentResponse</returns>
        ApiResponse<ImageCleanupDocumentResponse> ImageCleanupDocumentWithHttpInfo (ImageCleanupDocumentParameters cleanupDocumentParameters);
        /// <summary>
        /// Clones regions from a previously uploaded image into new images.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloneRegionsParameters">An ImageCloneRegionsParameters object specifying the parameters of the action.</param>
        /// <returns>ImageCloneRegionsResponse</returns>
        ImageCloneRegionsResponse ImageCloneRegions (ImageCloneRegionsParameters cloneRegionsParameters);

        /// <summary>
        /// Clones regions from a previously uploaded image into new images.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloneRegionsParameters">An ImageCloneRegionsParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ImageCloneRegionsResponse</returns>
        ApiResponse<ImageCloneRegionsResponse> ImageCloneRegionsWithHttpInfo (ImageCloneRegionsParameters cloneRegionsParameters);
        /// <summary>
        /// Closes a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeParameters">An ImageCloseParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>ImageCloseResponse</returns>
        ImageCloseResponse ImageClose (ImageCloseParameters closeParameters = null);

        /// <summary>
        /// Closes a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeParameters">An ImageCloseParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>ApiResponse of ImageCloseResponse</returns>
        ApiResponse<ImageCloseResponse> ImageCloseWithHttpInfo (ImageCloseParameters closeParameters = null);
        /// <summary>
        /// Converts the color depth of a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageConvertColorDepthParameters">An ImageConvertColorDepthParameters object specifying the parameters for the action.</param>
        /// <returns>ImageConvertColorDepthResponse</returns>
        ImageConvertColorDepthResponse ImageConvertColorDepth (ImageConvertColorDepthParameters imageConvertColorDepthParameters);

        /// <summary>
        /// Converts the color depth of a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageConvertColorDepthParameters">An ImageConvertColorDepthParameters object specifying the parameters for the action.</param>
        /// <returns>ApiResponse of ImageConvertColorDepthResponse</returns>
        ApiResponse<ImageConvertColorDepthResponse> ImageConvertColorDepthWithHttpInfo (ImageConvertColorDepthParameters imageConvertColorDepthParameters);
        /// <summary>
        /// Crops a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageCropParameters">An ImageCropParameters object specifying the parameters for the action.</param>
        /// <returns>ImageCropResponse</returns>
        ImageCropResponse ImageCrop (ImageCropParameters imageCropParameters);

        /// <summary>
        /// Crops a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageCropParameters">An ImageCropParameters object specifying the parameters for the action.</param>
        /// <returns>ApiResponse of ImageCropResponse</returns>
        ApiResponse<ImageCropResponse> ImageCropWithHttpInfo (ImageCropParameters imageCropParameters);
        /// <summary>
        /// Deletes a page range from a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deletePageParameters">An ImageDeletePageParameters object specifying the parameters of the action.</param>
        /// <returns>ImageDeletePageResponse</returns>
        ImageDeletePageResponse ImageDeletePage (ImageDeletePageParameters deletePageParameters);

        /// <summary>
        /// Deletes a page range from a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deletePageParameters">An ImageDeletePageParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ImageDeletePageResponse</returns>
        ApiResponse<ImageDeletePageResponse> ImageDeletePageWithHttpInfo (ImageDeletePageParameters deletePageParameters);
        /// <summary>
        /// Detects the blank page(s) from a previously uploaded image and offers to remove them.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectBlankPagesParameters">An ImageDetectBlankPagesParameters object specifying the parameters of the action.</param>
        /// <returns>ImageDetectBlankPagesResponse</returns>
        ImageDetectBlankPagesResponse ImageDetectBlankPages (ImageDetectBlankPagesParameters detectBlankPagesParameters);

        /// <summary>
        /// Detects the blank page(s) from a previously uploaded image and offers to remove them.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectBlankPagesParameters">An ImageDetectBlankPagesParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ImageDetectBlankPagesResponse</returns>
        ApiResponse<ImageDetectBlankPagesResponse> ImageDetectBlankPagesWithHttpInfo (ImageDetectBlankPagesParameters detectBlankPagesParameters);
        /// <summary>
        /// Performs color detection  on a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageDetectColorParameters">An ImageDetectColorParameters object specifying the parameters for the action.</param>
        /// <returns>ImageDetectColorResponse</returns>
        ImageDetectColorResponse ImageDetectColor (ImageDetectColorParameters imageDetectColorParameters);

        /// <summary>
        /// Performs color detection  on a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageDetectColorParameters">An ImageDetectColorParameters object specifying the parameters for the action.</param>
        /// <returns>ApiResponse of ImageDetectColorResponse</returns>
        ApiResponse<ImageDetectColorResponse> ImageDetectColorWithHttpInfo (ImageDetectColorParameters imageDetectColorParameters);
        /// <summary>
        /// Detects the orientation of the page(s) of a previously uploaded image and offers to automatically rotate them.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectPageOrientationParameters">An ImagedetectPageOrientationParameters object specifying the parameters of the action.</param>
        /// <returns>ImageDetectPageOrientationResponse</returns>
        ImageDetectPageOrientationResponse ImageDetectPageOrientation (ImageDetectPageOrientationParameters detectPageOrientationParameters);

        /// <summary>
        /// Detects the orientation of the page(s) of a previously uploaded image and offers to automatically rotate them.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectPageOrientationParameters">An ImagedetectPageOrientationParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ImageDetectPageOrientationResponse</returns>
        ApiResponse<ImageDetectPageOrientationResponse> ImageDetectPageOrientationWithHttpInfo (ImageDetectPageOrientationParameters detectPageOrientationParameters);
        /// <summary>
        /// Applies filters to a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageFilterParameters">An ImageFilterParameters object specifying the parameters for the action.</param>
        /// <returns>ImageFilterResponse</returns>
        ImageFilterResponse ImageFilter (ImageFilterParameters imageFilterParameters);

        /// <summary>
        /// Applies filters to a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageFilterParameters">An ImageFilterParameters object specifying the parameters for the action.</param>
        /// <returns>ApiResponse of ImageFilterResponse</returns>
        ApiResponse<ImageFilterResponse> ImageFilterWithHttpInfo (ImageFilterParameters imageFilterParameters);
        /// <summary>
        /// Gets a thumbnail of each page within the provided page range from a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPageThumbnailParameters">A PDFGetPageThumbnailParameters object specifying the parameters of the action.</param>
        /// <returns>ImageGetPageThumbnailResponse</returns>
        ImageGetPageThumbnailResponse ImageGetPageThumbnail (ImageGetPageThumbnailParameters getPageThumbnailParameters);

        /// <summary>
        /// Gets a thumbnail of each page within the provided page range from a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPageThumbnailParameters">A PDFGetPageThumbnailParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ImageGetPageThumbnailResponse</returns>
        ApiResponse<ImageGetPageThumbnailResponse> ImageGetPageThumbnailWithHttpInfo (ImageGetPageThumbnailParameters getPageThumbnailParameters);
        /// <summary>
        /// Gets the supported file extensions by the image loading actions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>StringArrayResponse</returns>
        StringArrayResponse ImageGetSupportedFileExtensions ();

        /// <summary>
        /// Gets the supported file extensions by the image loading actions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of StringArrayResponse</returns>
        ApiResponse<StringArrayResponse> ImageGetSupportedFileExtensionsWithHttpInfo ();
        /// <summary>
        /// Loads the provided image file.  Supported image formats can be retrieved by the GetSupportedImageFileExtensions action.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loadImageParameters">A LoadImageFromByteArrayParameters object specifying the parameters of the action.</param>
        /// <returns>ImageLoadResponse</returns>
        ImageLoadResponse ImageLoad (LoadImageFromByteArrayParameters loadImageParameters);

        /// <summary>
        /// Loads the provided image file.  Supported image formats can be retrieved by the GetSupportedImageFileExtensions action.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loadImageParameters">A LoadImageFromByteArrayParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ImageLoadResponse</returns>
        ApiResponse<ImageLoadResponse> ImageLoadWithHttpInfo (LoadImageFromByteArrayParameters loadImageParameters);
        /// <summary>
        /// Loads the provided image file using Multipart Upload.  Supported image formats can be retrieved by the GetSupportedImageFileExtensions action.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileData">Specifies the stream of data of the file to be uploaded.</param>
        /// <param name="contentEncoding">Specifies the encoding of the fileData content. (optional, default to &quot;Identity&quot;)</param>
        /// <param name="fileName">Specifies the name of the file to be uploaded. (optional)</param>
        /// <returns>ImageLoadResponse</returns>
        ImageLoadResponse ImageLoadMultipart (System.IO.Stream fileData, string contentEncoding = null, string fileName = null);

        /// <summary>
        /// Loads the provided image file using Multipart Upload.  Supported image formats can be retrieved by the GetSupportedImageFileExtensions action.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileData">Specifies the stream of data of the file to be uploaded.</param>
        /// <param name="contentEncoding">Specifies the encoding of the fileData content. (optional, default to &quot;Identity&quot;)</param>
        /// <param name="fileName">Specifies the name of the file to be uploaded. (optional)</param>
        /// <returns>ApiResponse of ImageLoadResponse</returns>
        ApiResponse<ImageLoadResponse> ImageLoadMultipartWithHttpInfo (System.IO.Stream fileData, string contentEncoding = null, string fileName = null);
        /// <summary>
        /// Performs MICR (Magnetic Ink Character Recognition) on a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="micrParameters">An ImageMICRParameters object specifying the parameters of the action.</param>
        /// <returns>ImageMICRResponse</returns>
        ImageMICRResponse ImageMICR (ImageMICRParameters micrParameters);

        /// <summary>
        /// Performs MICR (Magnetic Ink Character Recognition) on a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="micrParameters">An ImageMICRParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ImageMICRResponse</returns>
        ApiResponse<ImageMICRResponse> ImageMICRWithHttpInfo (ImageMICRParameters micrParameters);
        /// <summary>
        /// Reads barcodes from a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readBarcodeParameters">An ImageReadBarcodesParameters object specifying the parameters of the action.</param>
        /// <returns>ReadBarcodesResponse</returns>
        ReadBarcodesResponse ImageReadBarcodes (ImageReadBarcodesParameters readBarcodeParameters);

        /// <summary>
        /// Reads barcodes from a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readBarcodeParameters">An ImageReadBarcodesParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ReadBarcodesResponse</returns>
        ApiResponse<ReadBarcodesResponse> ImageReadBarcodesWithHttpInfo (ImageReadBarcodesParameters readBarcodeParameters);
        /// <summary>
        /// Resizes a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageResizeParameters">An ImageResizeParameters object specifying the parameters for the action.</param>
        /// <returns>ImageResizeResponse</returns>
        ImageResizeResponse ImageResize (ImageResizeParameters imageResizeParameters);

        /// <summary>
        /// Resizes a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageResizeParameters">An ImageResizeParameters object specifying the parameters for the action.</param>
        /// <returns>ApiResponse of ImageResizeResponse</returns>
        ApiResponse<ImageResizeResponse> ImageResizeWithHttpInfo (ImageResizeParameters imageResizeParameters);
        /// <summary>
        /// Rotates and/or flips a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageRotateParameters">An ImageRotateParameters object specifying the parameters for the action.</param>
        /// <returns>ImageRotateResponse</returns>
        ImageRotateResponse ImageRotate (ImageRotateParameters imageRotateParameters);

        /// <summary>
        /// Rotates and/or flips a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageRotateParameters">An ImageRotateParameters object specifying the parameters for the action.</param>
        /// <returns>ApiResponse of ImageRotateResponse</returns>
        ApiResponse<ImageRotateResponse> ImageRotateWithHttpInfo (ImageRotateParameters imageRotateParameters);
        /// <summary>
        /// Saves a previously uploaded image as JPEG.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsJPEGParameters">An ImageSaveAsJPEGParameters object specifying the parameters of the action.</param>
        /// <returns>ImageSaveAsJPEGResponse</returns>
        ImageSaveAsJPEGResponse ImageSaveAsJPEG (ImageSaveAsJPEGParameters saveAsJPEGParameters);

        /// <summary>
        /// Saves a previously uploaded image as JPEG.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsJPEGParameters">An ImageSaveAsJPEGParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ImageSaveAsJPEGResponse</returns>
        ApiResponse<ImageSaveAsJPEGResponse> ImageSaveAsJPEGWithHttpInfo (ImageSaveAsJPEGParameters saveAsJPEGParameters);
        /// <summary>
        /// Saves a previously uploaded image as PDF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPDFParameters">An ImagesaveAsPDFParameters object specifying the parameters of the action.</param>
        /// <returns>ImageSaveAsPDFResponse</returns>
        ImageSaveAsPDFResponse ImageSaveAsPDF (ImageSaveAsPDFParameters saveAsPDFParameters);

        /// <summary>
        /// Saves a previously uploaded image as PDF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPDFParameters">An ImagesaveAsPDFParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ImageSaveAsPDFResponse</returns>
        ApiResponse<ImageSaveAsPDFResponse> ImageSaveAsPDFWithHttpInfo (ImageSaveAsPDFParameters saveAsPDFParameters);
        /// <summary>
        /// Saves a previously uploaded image as PDF using MRC compression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPDFMRCParameters">An ImagesaveAsPDFMRCParameters object specifying the parameters of the action.</param>
        /// <returns>ImageSaveAsPDFMRCResponse</returns>
        ImageSaveAsPDFMRCResponse ImageSaveAsPDFMRC (ImageSaveAsPDFMRCParameters saveAsPDFMRCParameters);

        /// <summary>
        /// Saves a previously uploaded image as PDF using MRC compression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPDFMRCParameters">An ImagesaveAsPDFMRCParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ImageSaveAsPDFMRCResponse</returns>
        ApiResponse<ImageSaveAsPDFMRCResponse> ImageSaveAsPDFMRCWithHttpInfo (ImageSaveAsPDFMRCParameters saveAsPDFMRCParameters);
        /// <summary>
        /// Saves a previously uploaded image as PNG.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPNGParameters">An ImageSaveAsPNGParameters object specifying the parameters of the action.</param>
        /// <returns>ImageSaveAsPNGResponse</returns>
        ImageSaveAsPNGResponse ImageSaveAsPNG (ImageSaveAsPNGParameters saveAsPNGParameters);

        /// <summary>
        /// Saves a previously uploaded image as PNG.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPNGParameters">An ImageSaveAsPNGParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ImageSaveAsPNGResponse</returns>
        ApiResponse<ImageSaveAsPNGResponse> ImageSaveAsPNGWithHttpInfo (ImageSaveAsPNGParameters saveAsPNGParameters);
        /// <summary>
        /// Saves a previously uploaded image as TIFF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFParameters">An ImageSaveAsTIFFParameters object specifying the parameters of the action.</param>
        /// <returns>ImageSaveAsTIFFResponse</returns>
        ImageSaveAsTIFFResponse ImageSaveAsTIFF (ImageSaveAsTIFFParameters saveAsTIFFParameters);

        /// <summary>
        /// Saves a previously uploaded image as TIFF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFParameters">An ImageSaveAsTIFFParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ImageSaveAsTIFFResponse</returns>
        ApiResponse<ImageSaveAsTIFFResponse> ImageSaveAsTIFFWithHttpInfo (ImageSaveAsTIFFParameters saveAsTIFFParameters);
        /// <summary>
        /// Saves a previously uploaded image as multipage TIFF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFMultipageParameters">An ImageSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        /// <returns>ImageSaveAsTIFFMultipageResponse</returns>
        ImageSaveAsTIFFMultipageResponse ImageSaveAsTIFFMultipage (ImageSaveAsTIFFMultipageParameters saveAsTIFFMultipageParameters);

        /// <summary>
        /// Saves a previously uploaded image as multipage TIFF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFMultipageParameters">An ImageSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ImageSaveAsTIFFMultipageResponse</returns>
        ApiResponse<ImageSaveAsTIFFMultipageResponse> ImageSaveAsTIFFMultipageWithHttpInfo (ImageSaveAsTIFFMultipageParameters saveAsTIFFMultipageParameters);
        /// <summary>
        /// Swaps two pages from a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="swapPagesParameters">An ImageSwapPagesParameters object specifying the parameters of the action.</param>
        /// <returns>ImageSwapPagesResponse</returns>
        ImageSwapPagesResponse ImageSwapPages (ImageSwapPagesParameters swapPagesParameters);

        /// <summary>
        /// Swaps two pages from a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="swapPagesParameters">An ImageSwapPagesParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ImageSwapPagesResponse</returns>
        ApiResponse<ImageSwapPagesResponse> ImageSwapPagesWithHttpInfo (ImageSwapPagesParameters swapPagesParameters);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Adjusts a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageAdjustParameters">An ImageAdjustParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ImageAdjustResponse</returns>
        System.Threading.Tasks.Task<ImageAdjustResponse> ImageAdjustAsync (ImageAdjustParameters imageAdjustParameters);

        /// <summary>
        /// Adjusts a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageAdjustParameters">An ImageAdjustParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ApiResponse (ImageAdjustResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageAdjustResponse>> ImageAdjustAsyncWithHttpInfo (ImageAdjustParameters imageAdjustParameters);
        /// <summary>
        /// Cleanup a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cleanupDocumentParameters">An ImageCleanupDocumentParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ImageCleanupDocumentResponse</returns>
        System.Threading.Tasks.Task<ImageCleanupDocumentResponse> ImageCleanupDocumentAsync (ImageCleanupDocumentParameters cleanupDocumentParameters);

        /// <summary>
        /// Cleanup a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cleanupDocumentParameters">An ImageCleanupDocumentParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ApiResponse (ImageCleanupDocumentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageCleanupDocumentResponse>> ImageCleanupDocumentAsyncWithHttpInfo (ImageCleanupDocumentParameters cleanupDocumentParameters);
        /// <summary>
        /// Clones regions from a previously uploaded image into new images.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloneRegionsParameters">An ImageCloneRegionsParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageCloneRegionsResponse</returns>
        System.Threading.Tasks.Task<ImageCloneRegionsResponse> ImageCloneRegionsAsync (ImageCloneRegionsParameters cloneRegionsParameters);

        /// <summary>
        /// Clones regions from a previously uploaded image into new images.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloneRegionsParameters">An ImageCloneRegionsParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ImageCloneRegionsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageCloneRegionsResponse>> ImageCloneRegionsAsyncWithHttpInfo (ImageCloneRegionsParameters cloneRegionsParameters);
        /// <summary>
        /// Closes a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeParameters">An ImageCloseParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of ImageCloseResponse</returns>
        System.Threading.Tasks.Task<ImageCloseResponse> ImageCloseAsync (ImageCloseParameters closeParameters = null);

        /// <summary>
        /// Closes a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeParameters">An ImageCloseParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of ApiResponse (ImageCloseResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageCloseResponse>> ImageCloseAsyncWithHttpInfo (ImageCloseParameters closeParameters = null);
        /// <summary>
        /// Converts the color depth of a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageConvertColorDepthParameters">An ImageConvertColorDepthParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ImageConvertColorDepthResponse</returns>
        System.Threading.Tasks.Task<ImageConvertColorDepthResponse> ImageConvertColorDepthAsync (ImageConvertColorDepthParameters imageConvertColorDepthParameters);

        /// <summary>
        /// Converts the color depth of a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageConvertColorDepthParameters">An ImageConvertColorDepthParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ApiResponse (ImageConvertColorDepthResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageConvertColorDepthResponse>> ImageConvertColorDepthAsyncWithHttpInfo (ImageConvertColorDepthParameters imageConvertColorDepthParameters);
        /// <summary>
        /// Crops a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageCropParameters">An ImageCropParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ImageCropResponse</returns>
        System.Threading.Tasks.Task<ImageCropResponse> ImageCropAsync (ImageCropParameters imageCropParameters);

        /// <summary>
        /// Crops a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageCropParameters">An ImageCropParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ApiResponse (ImageCropResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageCropResponse>> ImageCropAsyncWithHttpInfo (ImageCropParameters imageCropParameters);
        /// <summary>
        /// Deletes a page range from a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deletePageParameters">An ImageDeletePageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageDeletePageResponse</returns>
        System.Threading.Tasks.Task<ImageDeletePageResponse> ImageDeletePageAsync (ImageDeletePageParameters deletePageParameters);

        /// <summary>
        /// Deletes a page range from a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deletePageParameters">An ImageDeletePageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ImageDeletePageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageDeletePageResponse>> ImageDeletePageAsyncWithHttpInfo (ImageDeletePageParameters deletePageParameters);
        /// <summary>
        /// Detects the blank page(s) from a previously uploaded image and offers to remove them.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectBlankPagesParameters">An ImageDetectBlankPagesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageDetectBlankPagesResponse</returns>
        System.Threading.Tasks.Task<ImageDetectBlankPagesResponse> ImageDetectBlankPagesAsync (ImageDetectBlankPagesParameters detectBlankPagesParameters);

        /// <summary>
        /// Detects the blank page(s) from a previously uploaded image and offers to remove them.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectBlankPagesParameters">An ImageDetectBlankPagesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ImageDetectBlankPagesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageDetectBlankPagesResponse>> ImageDetectBlankPagesAsyncWithHttpInfo (ImageDetectBlankPagesParameters detectBlankPagesParameters);
        /// <summary>
        /// Performs color detection  on a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageDetectColorParameters">An ImageDetectColorParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ImageDetectColorResponse</returns>
        System.Threading.Tasks.Task<ImageDetectColorResponse> ImageDetectColorAsync (ImageDetectColorParameters imageDetectColorParameters);

        /// <summary>
        /// Performs color detection  on a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageDetectColorParameters">An ImageDetectColorParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ApiResponse (ImageDetectColorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageDetectColorResponse>> ImageDetectColorAsyncWithHttpInfo (ImageDetectColorParameters imageDetectColorParameters);
        /// <summary>
        /// Detects the orientation of the page(s) of a previously uploaded image and offers to automatically rotate them.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectPageOrientationParameters">An ImagedetectPageOrientationParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageDetectPageOrientationResponse</returns>
        System.Threading.Tasks.Task<ImageDetectPageOrientationResponse> ImageDetectPageOrientationAsync (ImageDetectPageOrientationParameters detectPageOrientationParameters);

        /// <summary>
        /// Detects the orientation of the page(s) of a previously uploaded image and offers to automatically rotate them.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectPageOrientationParameters">An ImagedetectPageOrientationParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ImageDetectPageOrientationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageDetectPageOrientationResponse>> ImageDetectPageOrientationAsyncWithHttpInfo (ImageDetectPageOrientationParameters detectPageOrientationParameters);
        /// <summary>
        /// Applies filters to a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageFilterParameters">An ImageFilterParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ImageFilterResponse</returns>
        System.Threading.Tasks.Task<ImageFilterResponse> ImageFilterAsync (ImageFilterParameters imageFilterParameters);

        /// <summary>
        /// Applies filters to a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageFilterParameters">An ImageFilterParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ApiResponse (ImageFilterResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageFilterResponse>> ImageFilterAsyncWithHttpInfo (ImageFilterParameters imageFilterParameters);
        /// <summary>
        /// Gets a thumbnail of each page within the provided page range from a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPageThumbnailParameters">A PDFGetPageThumbnailParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageGetPageThumbnailResponse</returns>
        System.Threading.Tasks.Task<ImageGetPageThumbnailResponse> ImageGetPageThumbnailAsync (ImageGetPageThumbnailParameters getPageThumbnailParameters);

        /// <summary>
        /// Gets a thumbnail of each page within the provided page range from a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPageThumbnailParameters">A PDFGetPageThumbnailParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ImageGetPageThumbnailResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageGetPageThumbnailResponse>> ImageGetPageThumbnailAsyncWithHttpInfo (ImageGetPageThumbnailParameters getPageThumbnailParameters);
        /// <summary>
        /// Gets the supported file extensions by the image loading actions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of StringArrayResponse</returns>
        System.Threading.Tasks.Task<StringArrayResponse> ImageGetSupportedFileExtensionsAsync ();

        /// <summary>
        /// Gets the supported file extensions by the image loading actions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (StringArrayResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StringArrayResponse>> ImageGetSupportedFileExtensionsAsyncWithHttpInfo ();
        /// <summary>
        /// Loads the provided image file.  Supported image formats can be retrieved by the GetSupportedImageFileExtensions action.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loadImageParameters">A LoadImageFromByteArrayParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageLoadResponse</returns>
        System.Threading.Tasks.Task<ImageLoadResponse> ImageLoadAsync (LoadImageFromByteArrayParameters loadImageParameters);

        /// <summary>
        /// Loads the provided image file.  Supported image formats can be retrieved by the GetSupportedImageFileExtensions action.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loadImageParameters">A LoadImageFromByteArrayParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ImageLoadResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageLoadResponse>> ImageLoadAsyncWithHttpInfo (LoadImageFromByteArrayParameters loadImageParameters);
        /// <summary>
        /// Loads the provided image file using Multipart Upload.  Supported image formats can be retrieved by the GetSupportedImageFileExtensions action.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileData">Specifies the stream of data of the file to be uploaded.</param>
        /// <param name="contentEncoding">Specifies the encoding of the fileData content. (optional, default to &quot;Identity&quot;)</param>
        /// <param name="fileName">Specifies the name of the file to be uploaded. (optional)</param>
        /// <returns>Task of ImageLoadResponse</returns>
        System.Threading.Tasks.Task<ImageLoadResponse> ImageLoadMultipartAsync (System.IO.Stream fileData, string contentEncoding = null, string fileName = null);

        /// <summary>
        /// Loads the provided image file using Multipart Upload.  Supported image formats can be retrieved by the GetSupportedImageFileExtensions action.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileData">Specifies the stream of data of the file to be uploaded.</param>
        /// <param name="contentEncoding">Specifies the encoding of the fileData content. (optional, default to &quot;Identity&quot;)</param>
        /// <param name="fileName">Specifies the name of the file to be uploaded. (optional)</param>
        /// <returns>Task of ApiResponse (ImageLoadResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageLoadResponse>> ImageLoadMultipartAsyncWithHttpInfo (System.IO.Stream fileData, string contentEncoding = null, string fileName = null);
        /// <summary>
        /// Performs MICR (Magnetic Ink Character Recognition) on a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="micrParameters">An ImageMICRParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageMICRResponse</returns>
        System.Threading.Tasks.Task<ImageMICRResponse> ImageMICRAsync (ImageMICRParameters micrParameters);

        /// <summary>
        /// Performs MICR (Magnetic Ink Character Recognition) on a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="micrParameters">An ImageMICRParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ImageMICRResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageMICRResponse>> ImageMICRAsyncWithHttpInfo (ImageMICRParameters micrParameters);
        /// <summary>
        /// Reads barcodes from a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readBarcodeParameters">An ImageReadBarcodesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ReadBarcodesResponse</returns>
        System.Threading.Tasks.Task<ReadBarcodesResponse> ImageReadBarcodesAsync (ImageReadBarcodesParameters readBarcodeParameters);

        /// <summary>
        /// Reads barcodes from a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readBarcodeParameters">An ImageReadBarcodesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ReadBarcodesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReadBarcodesResponse>> ImageReadBarcodesAsyncWithHttpInfo (ImageReadBarcodesParameters readBarcodeParameters);
        /// <summary>
        /// Resizes a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageResizeParameters">An ImageResizeParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ImageResizeResponse</returns>
        System.Threading.Tasks.Task<ImageResizeResponse> ImageResizeAsync (ImageResizeParameters imageResizeParameters);

        /// <summary>
        /// Resizes a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageResizeParameters">An ImageResizeParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ApiResponse (ImageResizeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageResizeResponse>> ImageResizeAsyncWithHttpInfo (ImageResizeParameters imageResizeParameters);
        /// <summary>
        /// Rotates and/or flips a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageRotateParameters">An ImageRotateParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ImageRotateResponse</returns>
        System.Threading.Tasks.Task<ImageRotateResponse> ImageRotateAsync (ImageRotateParameters imageRotateParameters);

        /// <summary>
        /// Rotates and/or flips a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageRotateParameters">An ImageRotateParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ApiResponse (ImageRotateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageRotateResponse>> ImageRotateAsyncWithHttpInfo (ImageRotateParameters imageRotateParameters);
        /// <summary>
        /// Saves a previously uploaded image as JPEG.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsJPEGParameters">An ImageSaveAsJPEGParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageSaveAsJPEGResponse</returns>
        System.Threading.Tasks.Task<ImageSaveAsJPEGResponse> ImageSaveAsJPEGAsync (ImageSaveAsJPEGParameters saveAsJPEGParameters);

        /// <summary>
        /// Saves a previously uploaded image as JPEG.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsJPEGParameters">An ImageSaveAsJPEGParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ImageSaveAsJPEGResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageSaveAsJPEGResponse>> ImageSaveAsJPEGAsyncWithHttpInfo (ImageSaveAsJPEGParameters saveAsJPEGParameters);
        /// <summary>
        /// Saves a previously uploaded image as PDF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPDFParameters">An ImagesaveAsPDFParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageSaveAsPDFResponse</returns>
        System.Threading.Tasks.Task<ImageSaveAsPDFResponse> ImageSaveAsPDFAsync (ImageSaveAsPDFParameters saveAsPDFParameters);

        /// <summary>
        /// Saves a previously uploaded image as PDF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPDFParameters">An ImagesaveAsPDFParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ImageSaveAsPDFResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageSaveAsPDFResponse>> ImageSaveAsPDFAsyncWithHttpInfo (ImageSaveAsPDFParameters saveAsPDFParameters);
        /// <summary>
        /// Saves a previously uploaded image as PDF using MRC compression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPDFMRCParameters">An ImagesaveAsPDFMRCParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageSaveAsPDFMRCResponse</returns>
        System.Threading.Tasks.Task<ImageSaveAsPDFMRCResponse> ImageSaveAsPDFMRCAsync (ImageSaveAsPDFMRCParameters saveAsPDFMRCParameters);

        /// <summary>
        /// Saves a previously uploaded image as PDF using MRC compression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPDFMRCParameters">An ImagesaveAsPDFMRCParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ImageSaveAsPDFMRCResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageSaveAsPDFMRCResponse>> ImageSaveAsPDFMRCAsyncWithHttpInfo (ImageSaveAsPDFMRCParameters saveAsPDFMRCParameters);
        /// <summary>
        /// Saves a previously uploaded image as PNG.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPNGParameters">An ImageSaveAsPNGParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageSaveAsPNGResponse</returns>
        System.Threading.Tasks.Task<ImageSaveAsPNGResponse> ImageSaveAsPNGAsync (ImageSaveAsPNGParameters saveAsPNGParameters);

        /// <summary>
        /// Saves a previously uploaded image as PNG.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPNGParameters">An ImageSaveAsPNGParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ImageSaveAsPNGResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageSaveAsPNGResponse>> ImageSaveAsPNGAsyncWithHttpInfo (ImageSaveAsPNGParameters saveAsPNGParameters);
        /// <summary>
        /// Saves a previously uploaded image as TIFF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFParameters">An ImageSaveAsTIFFParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageSaveAsTIFFResponse</returns>
        System.Threading.Tasks.Task<ImageSaveAsTIFFResponse> ImageSaveAsTIFFAsync (ImageSaveAsTIFFParameters saveAsTIFFParameters);

        /// <summary>
        /// Saves a previously uploaded image as TIFF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFParameters">An ImageSaveAsTIFFParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ImageSaveAsTIFFResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageSaveAsTIFFResponse>> ImageSaveAsTIFFAsyncWithHttpInfo (ImageSaveAsTIFFParameters saveAsTIFFParameters);
        /// <summary>
        /// Saves a previously uploaded image as multipage TIFF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFMultipageParameters">An ImageSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageSaveAsTIFFMultipageResponse</returns>
        System.Threading.Tasks.Task<ImageSaveAsTIFFMultipageResponse> ImageSaveAsTIFFMultipageAsync (ImageSaveAsTIFFMultipageParameters saveAsTIFFMultipageParameters);

        /// <summary>
        /// Saves a previously uploaded image as multipage TIFF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFMultipageParameters">An ImageSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ImageSaveAsTIFFMultipageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageSaveAsTIFFMultipageResponse>> ImageSaveAsTIFFMultipageAsyncWithHttpInfo (ImageSaveAsTIFFMultipageParameters saveAsTIFFMultipageParameters);
        /// <summary>
        /// Swaps two pages from a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="swapPagesParameters">An ImageSwapPagesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageSwapPagesResponse</returns>
        System.Threading.Tasks.Task<ImageSwapPagesResponse> ImageSwapPagesAsync (ImageSwapPagesParameters swapPagesParameters);

        /// <summary>
        /// Swaps two pages from a previously uploaded image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="swapPagesParameters">An ImageSwapPagesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ImageSwapPagesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageSwapPagesResponse>> ImageSwapPagesAsyncWithHttpInfo (ImageSwapPagesParameters swapPagesParameters);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ImageApi : IImageApi
    {
        private PassportPDF.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ImageApi(String basePath)
        {
            this.Configuration = new PassportPDF.Client.Configuration { BasePath = basePath };

            ExceptionFactory = PassportPDF.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageApi"/> class
        /// </summary>
        /// <returns></returns>
        public ImageApi()
        {
            this.Configuration = PassportPDF.Client.Configuration.Default;

            ExceptionFactory = PassportPDF.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ImageApi(PassportPDF.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = PassportPDF.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = PassportPDF.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public PassportPDF.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public PassportPDF.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Adjusts a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageAdjustParameters">An ImageAdjustParameters object specifying the parameters for the action.</param>
        /// <returns>ImageAdjustResponse</returns>
        public ImageAdjustResponse ImageAdjust (ImageAdjustParameters imageAdjustParameters)
        {
             ApiResponse<ImageAdjustResponse> localVarResponse = ImageAdjustWithHttpInfo(imageAdjustParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Adjusts a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageAdjustParameters">An ImageAdjustParameters object specifying the parameters for the action.</param>
        /// <returns>ApiResponse of ImageAdjustResponse</returns>
        public ApiResponse< ImageAdjustResponse > ImageAdjustWithHttpInfo (ImageAdjustParameters imageAdjustParameters)
        {
            // verify the required parameter 'imageAdjustParameters' is set
            if (imageAdjustParameters == null)
                throw new ApiException(400, "Missing required parameter 'imageAdjustParameters' when calling ImageApi->ImageAdjust");

            var localVarPath = "/api/image/ImageAdjust";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (imageAdjustParameters != null && imageAdjustParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(imageAdjustParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = imageAdjustParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageAdjust", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageAdjustResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageAdjustResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageAdjustResponse)));
        }

        /// <summary>
        /// Adjusts a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageAdjustParameters">An ImageAdjustParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ImageAdjustResponse</returns>
        public async System.Threading.Tasks.Task<ImageAdjustResponse> ImageAdjustAsync (ImageAdjustParameters imageAdjustParameters)
        {
             ApiResponse<ImageAdjustResponse> localVarResponse = await ImageAdjustAsyncWithHttpInfo(imageAdjustParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Adjusts a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageAdjustParameters">An ImageAdjustParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ApiResponse (ImageAdjustResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageAdjustResponse>> ImageAdjustAsyncWithHttpInfo (ImageAdjustParameters imageAdjustParameters)
        {
            // verify the required parameter 'imageAdjustParameters' is set
            if (imageAdjustParameters == null)
                throw new ApiException(400, "Missing required parameter 'imageAdjustParameters' when calling ImageApi->ImageAdjust");

            var localVarPath = "/api/image/ImageAdjust";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (imageAdjustParameters != null && imageAdjustParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(imageAdjustParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = imageAdjustParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageAdjust", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageAdjustResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageAdjustResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageAdjustResponse)));
        }

        /// <summary>
        /// Cleanup a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cleanupDocumentParameters">An ImageCleanupDocumentParameters object specifying the parameters for the action.</param>
        /// <returns>ImageCleanupDocumentResponse</returns>
        public ImageCleanupDocumentResponse ImageCleanupDocument (ImageCleanupDocumentParameters cleanupDocumentParameters)
        {
             ApiResponse<ImageCleanupDocumentResponse> localVarResponse = ImageCleanupDocumentWithHttpInfo(cleanupDocumentParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cleanup a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cleanupDocumentParameters">An ImageCleanupDocumentParameters object specifying the parameters for the action.</param>
        /// <returns>ApiResponse of ImageCleanupDocumentResponse</returns>
        public ApiResponse< ImageCleanupDocumentResponse > ImageCleanupDocumentWithHttpInfo (ImageCleanupDocumentParameters cleanupDocumentParameters)
        {
            // verify the required parameter 'cleanupDocumentParameters' is set
            if (cleanupDocumentParameters == null)
                throw new ApiException(400, "Missing required parameter 'cleanupDocumentParameters' when calling ImageApi->ImageCleanupDocument");

            var localVarPath = "/api/image/ImageCleanupDocument";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (cleanupDocumentParameters != null && cleanupDocumentParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(cleanupDocumentParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cleanupDocumentParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageCleanupDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageCleanupDocumentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageCleanupDocumentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageCleanupDocumentResponse)));
        }

        /// <summary>
        /// Cleanup a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cleanupDocumentParameters">An ImageCleanupDocumentParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ImageCleanupDocumentResponse</returns>
        public async System.Threading.Tasks.Task<ImageCleanupDocumentResponse> ImageCleanupDocumentAsync (ImageCleanupDocumentParameters cleanupDocumentParameters)
        {
             ApiResponse<ImageCleanupDocumentResponse> localVarResponse = await ImageCleanupDocumentAsyncWithHttpInfo(cleanupDocumentParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cleanup a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cleanupDocumentParameters">An ImageCleanupDocumentParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ApiResponse (ImageCleanupDocumentResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageCleanupDocumentResponse>> ImageCleanupDocumentAsyncWithHttpInfo (ImageCleanupDocumentParameters cleanupDocumentParameters)
        {
            // verify the required parameter 'cleanupDocumentParameters' is set
            if (cleanupDocumentParameters == null)
                throw new ApiException(400, "Missing required parameter 'cleanupDocumentParameters' when calling ImageApi->ImageCleanupDocument");

            var localVarPath = "/api/image/ImageCleanupDocument";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (cleanupDocumentParameters != null && cleanupDocumentParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(cleanupDocumentParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cleanupDocumentParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageCleanupDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageCleanupDocumentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageCleanupDocumentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageCleanupDocumentResponse)));
        }

        /// <summary>
        /// Clones regions from a previously uploaded image into new images. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloneRegionsParameters">An ImageCloneRegionsParameters object specifying the parameters of the action.</param>
        /// <returns>ImageCloneRegionsResponse</returns>
        public ImageCloneRegionsResponse ImageCloneRegions (ImageCloneRegionsParameters cloneRegionsParameters)
        {
             ApiResponse<ImageCloneRegionsResponse> localVarResponse = ImageCloneRegionsWithHttpInfo(cloneRegionsParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Clones regions from a previously uploaded image into new images. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloneRegionsParameters">An ImageCloneRegionsParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ImageCloneRegionsResponse</returns>
        public ApiResponse< ImageCloneRegionsResponse > ImageCloneRegionsWithHttpInfo (ImageCloneRegionsParameters cloneRegionsParameters)
        {
            // verify the required parameter 'cloneRegionsParameters' is set
            if (cloneRegionsParameters == null)
                throw new ApiException(400, "Missing required parameter 'cloneRegionsParameters' when calling ImageApi->ImageCloneRegions");

            var localVarPath = "/api/image/ImageCloneRegions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (cloneRegionsParameters != null && cloneRegionsParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(cloneRegionsParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cloneRegionsParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageCloneRegions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageCloneRegionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageCloneRegionsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageCloneRegionsResponse)));
        }

        /// <summary>
        /// Clones regions from a previously uploaded image into new images. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloneRegionsParameters">An ImageCloneRegionsParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageCloneRegionsResponse</returns>
        public async System.Threading.Tasks.Task<ImageCloneRegionsResponse> ImageCloneRegionsAsync (ImageCloneRegionsParameters cloneRegionsParameters)
        {
             ApiResponse<ImageCloneRegionsResponse> localVarResponse = await ImageCloneRegionsAsyncWithHttpInfo(cloneRegionsParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Clones regions from a previously uploaded image into new images. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloneRegionsParameters">An ImageCloneRegionsParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ImageCloneRegionsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageCloneRegionsResponse>> ImageCloneRegionsAsyncWithHttpInfo (ImageCloneRegionsParameters cloneRegionsParameters)
        {
            // verify the required parameter 'cloneRegionsParameters' is set
            if (cloneRegionsParameters == null)
                throw new ApiException(400, "Missing required parameter 'cloneRegionsParameters' when calling ImageApi->ImageCloneRegions");

            var localVarPath = "/api/image/ImageCloneRegions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (cloneRegionsParameters != null && cloneRegionsParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(cloneRegionsParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cloneRegionsParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageCloneRegions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageCloneRegionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageCloneRegionsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageCloneRegionsResponse)));
        }

        /// <summary>
        /// Closes a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeParameters">An ImageCloseParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>ImageCloseResponse</returns>
        public ImageCloseResponse ImageClose (ImageCloseParameters closeParameters = null)
        {
             ApiResponse<ImageCloseResponse> localVarResponse = ImageCloseWithHttpInfo(closeParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Closes a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeParameters">An ImageCloseParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>ApiResponse of ImageCloseResponse</returns>
        public ApiResponse< ImageCloseResponse > ImageCloseWithHttpInfo (ImageCloseParameters closeParameters = null)
        {

            var localVarPath = "/api/image/ImageClose";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (closeParameters != null && closeParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(closeParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = closeParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageClose", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageCloseResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageCloseResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageCloseResponse)));
        }

        /// <summary>
        /// Closes a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeParameters">An ImageCloseParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of ImageCloseResponse</returns>
        public async System.Threading.Tasks.Task<ImageCloseResponse> ImageCloseAsync (ImageCloseParameters closeParameters = null)
        {
             ApiResponse<ImageCloseResponse> localVarResponse = await ImageCloseAsyncWithHttpInfo(closeParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Closes a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeParameters">An ImageCloseParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of ApiResponse (ImageCloseResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageCloseResponse>> ImageCloseAsyncWithHttpInfo (ImageCloseParameters closeParameters = null)
        {

            var localVarPath = "/api/image/ImageClose";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (closeParameters != null && closeParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(closeParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = closeParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageClose", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageCloseResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageCloseResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageCloseResponse)));
        }

        /// <summary>
        /// Converts the color depth of a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageConvertColorDepthParameters">An ImageConvertColorDepthParameters object specifying the parameters for the action.</param>
        /// <returns>ImageConvertColorDepthResponse</returns>
        public ImageConvertColorDepthResponse ImageConvertColorDepth (ImageConvertColorDepthParameters imageConvertColorDepthParameters)
        {
             ApiResponse<ImageConvertColorDepthResponse> localVarResponse = ImageConvertColorDepthWithHttpInfo(imageConvertColorDepthParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Converts the color depth of a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageConvertColorDepthParameters">An ImageConvertColorDepthParameters object specifying the parameters for the action.</param>
        /// <returns>ApiResponse of ImageConvertColorDepthResponse</returns>
        public ApiResponse< ImageConvertColorDepthResponse > ImageConvertColorDepthWithHttpInfo (ImageConvertColorDepthParameters imageConvertColorDepthParameters)
        {
            // verify the required parameter 'imageConvertColorDepthParameters' is set
            if (imageConvertColorDepthParameters == null)
                throw new ApiException(400, "Missing required parameter 'imageConvertColorDepthParameters' when calling ImageApi->ImageConvertColorDepth");

            var localVarPath = "/api/image/ImageConvertColorDepth";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (imageConvertColorDepthParameters != null && imageConvertColorDepthParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(imageConvertColorDepthParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = imageConvertColorDepthParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageConvertColorDepth", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageConvertColorDepthResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageConvertColorDepthResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageConvertColorDepthResponse)));
        }

        /// <summary>
        /// Converts the color depth of a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageConvertColorDepthParameters">An ImageConvertColorDepthParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ImageConvertColorDepthResponse</returns>
        public async System.Threading.Tasks.Task<ImageConvertColorDepthResponse> ImageConvertColorDepthAsync (ImageConvertColorDepthParameters imageConvertColorDepthParameters)
        {
             ApiResponse<ImageConvertColorDepthResponse> localVarResponse = await ImageConvertColorDepthAsyncWithHttpInfo(imageConvertColorDepthParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Converts the color depth of a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageConvertColorDepthParameters">An ImageConvertColorDepthParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ApiResponse (ImageConvertColorDepthResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageConvertColorDepthResponse>> ImageConvertColorDepthAsyncWithHttpInfo (ImageConvertColorDepthParameters imageConvertColorDepthParameters)
        {
            // verify the required parameter 'imageConvertColorDepthParameters' is set
            if (imageConvertColorDepthParameters == null)
                throw new ApiException(400, "Missing required parameter 'imageConvertColorDepthParameters' when calling ImageApi->ImageConvertColorDepth");

            var localVarPath = "/api/image/ImageConvertColorDepth";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (imageConvertColorDepthParameters != null && imageConvertColorDepthParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(imageConvertColorDepthParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = imageConvertColorDepthParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageConvertColorDepth", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageConvertColorDepthResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageConvertColorDepthResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageConvertColorDepthResponse)));
        }

        /// <summary>
        /// Crops a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageCropParameters">An ImageCropParameters object specifying the parameters for the action.</param>
        /// <returns>ImageCropResponse</returns>
        public ImageCropResponse ImageCrop (ImageCropParameters imageCropParameters)
        {
             ApiResponse<ImageCropResponse> localVarResponse = ImageCropWithHttpInfo(imageCropParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Crops a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageCropParameters">An ImageCropParameters object specifying the parameters for the action.</param>
        /// <returns>ApiResponse of ImageCropResponse</returns>
        public ApiResponse< ImageCropResponse > ImageCropWithHttpInfo (ImageCropParameters imageCropParameters)
        {
            // verify the required parameter 'imageCropParameters' is set
            if (imageCropParameters == null)
                throw new ApiException(400, "Missing required parameter 'imageCropParameters' when calling ImageApi->ImageCrop");

            var localVarPath = "/api/image/ImageCrop";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (imageCropParameters != null && imageCropParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(imageCropParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = imageCropParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageCrop", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageCropResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageCropResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageCropResponse)));
        }

        /// <summary>
        /// Crops a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageCropParameters">An ImageCropParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ImageCropResponse</returns>
        public async System.Threading.Tasks.Task<ImageCropResponse> ImageCropAsync (ImageCropParameters imageCropParameters)
        {
             ApiResponse<ImageCropResponse> localVarResponse = await ImageCropAsyncWithHttpInfo(imageCropParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Crops a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageCropParameters">An ImageCropParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ApiResponse (ImageCropResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageCropResponse>> ImageCropAsyncWithHttpInfo (ImageCropParameters imageCropParameters)
        {
            // verify the required parameter 'imageCropParameters' is set
            if (imageCropParameters == null)
                throw new ApiException(400, "Missing required parameter 'imageCropParameters' when calling ImageApi->ImageCrop");

            var localVarPath = "/api/image/ImageCrop";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (imageCropParameters != null && imageCropParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(imageCropParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = imageCropParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageCrop", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageCropResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageCropResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageCropResponse)));
        }

        /// <summary>
        /// Deletes a page range from a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deletePageParameters">An ImageDeletePageParameters object specifying the parameters of the action.</param>
        /// <returns>ImageDeletePageResponse</returns>
        public ImageDeletePageResponse ImageDeletePage (ImageDeletePageParameters deletePageParameters)
        {
             ApiResponse<ImageDeletePageResponse> localVarResponse = ImageDeletePageWithHttpInfo(deletePageParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Deletes a page range from a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deletePageParameters">An ImageDeletePageParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ImageDeletePageResponse</returns>
        public ApiResponse< ImageDeletePageResponse > ImageDeletePageWithHttpInfo (ImageDeletePageParameters deletePageParameters)
        {
            // verify the required parameter 'deletePageParameters' is set
            if (deletePageParameters == null)
                throw new ApiException(400, "Missing required parameter 'deletePageParameters' when calling ImageApi->ImageDeletePage");

            var localVarPath = "/api/image/ImageDeletePage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (deletePageParameters != null && deletePageParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(deletePageParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = deletePageParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageDeletePage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageDeletePageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageDeletePageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageDeletePageResponse)));
        }

        /// <summary>
        /// Deletes a page range from a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deletePageParameters">An ImageDeletePageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageDeletePageResponse</returns>
        public async System.Threading.Tasks.Task<ImageDeletePageResponse> ImageDeletePageAsync (ImageDeletePageParameters deletePageParameters)
        {
             ApiResponse<ImageDeletePageResponse> localVarResponse = await ImageDeletePageAsyncWithHttpInfo(deletePageParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Deletes a page range from a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deletePageParameters">An ImageDeletePageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ImageDeletePageResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageDeletePageResponse>> ImageDeletePageAsyncWithHttpInfo (ImageDeletePageParameters deletePageParameters)
        {
            // verify the required parameter 'deletePageParameters' is set
            if (deletePageParameters == null)
                throw new ApiException(400, "Missing required parameter 'deletePageParameters' when calling ImageApi->ImageDeletePage");

            var localVarPath = "/api/image/ImageDeletePage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (deletePageParameters != null && deletePageParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(deletePageParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = deletePageParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageDeletePage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageDeletePageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageDeletePageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageDeletePageResponse)));
        }

        /// <summary>
        /// Detects the blank page(s) from a previously uploaded image and offers to remove them. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectBlankPagesParameters">An ImageDetectBlankPagesParameters object specifying the parameters of the action.</param>
        /// <returns>ImageDetectBlankPagesResponse</returns>
        public ImageDetectBlankPagesResponse ImageDetectBlankPages (ImageDetectBlankPagesParameters detectBlankPagesParameters)
        {
             ApiResponse<ImageDetectBlankPagesResponse> localVarResponse = ImageDetectBlankPagesWithHttpInfo(detectBlankPagesParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Detects the blank page(s) from a previously uploaded image and offers to remove them. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectBlankPagesParameters">An ImageDetectBlankPagesParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ImageDetectBlankPagesResponse</returns>
        public ApiResponse< ImageDetectBlankPagesResponse > ImageDetectBlankPagesWithHttpInfo (ImageDetectBlankPagesParameters detectBlankPagesParameters)
        {
            // verify the required parameter 'detectBlankPagesParameters' is set
            if (detectBlankPagesParameters == null)
                throw new ApiException(400, "Missing required parameter 'detectBlankPagesParameters' when calling ImageApi->ImageDetectBlankPages");

            var localVarPath = "/api/image/ImageDetectBlankPages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (detectBlankPagesParameters != null && detectBlankPagesParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(detectBlankPagesParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = detectBlankPagesParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageDetectBlankPages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageDetectBlankPagesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageDetectBlankPagesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageDetectBlankPagesResponse)));
        }

        /// <summary>
        /// Detects the blank page(s) from a previously uploaded image and offers to remove them. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectBlankPagesParameters">An ImageDetectBlankPagesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageDetectBlankPagesResponse</returns>
        public async System.Threading.Tasks.Task<ImageDetectBlankPagesResponse> ImageDetectBlankPagesAsync (ImageDetectBlankPagesParameters detectBlankPagesParameters)
        {
             ApiResponse<ImageDetectBlankPagesResponse> localVarResponse = await ImageDetectBlankPagesAsyncWithHttpInfo(detectBlankPagesParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Detects the blank page(s) from a previously uploaded image and offers to remove them. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectBlankPagesParameters">An ImageDetectBlankPagesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ImageDetectBlankPagesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageDetectBlankPagesResponse>> ImageDetectBlankPagesAsyncWithHttpInfo (ImageDetectBlankPagesParameters detectBlankPagesParameters)
        {
            // verify the required parameter 'detectBlankPagesParameters' is set
            if (detectBlankPagesParameters == null)
                throw new ApiException(400, "Missing required parameter 'detectBlankPagesParameters' when calling ImageApi->ImageDetectBlankPages");

            var localVarPath = "/api/image/ImageDetectBlankPages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (detectBlankPagesParameters != null && detectBlankPagesParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(detectBlankPagesParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = detectBlankPagesParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageDetectBlankPages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageDetectBlankPagesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageDetectBlankPagesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageDetectBlankPagesResponse)));
        }

        /// <summary>
        /// Performs color detection  on a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageDetectColorParameters">An ImageDetectColorParameters object specifying the parameters for the action.</param>
        /// <returns>ImageDetectColorResponse</returns>
        public ImageDetectColorResponse ImageDetectColor (ImageDetectColorParameters imageDetectColorParameters)
        {
             ApiResponse<ImageDetectColorResponse> localVarResponse = ImageDetectColorWithHttpInfo(imageDetectColorParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Performs color detection  on a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageDetectColorParameters">An ImageDetectColorParameters object specifying the parameters for the action.</param>
        /// <returns>ApiResponse of ImageDetectColorResponse</returns>
        public ApiResponse< ImageDetectColorResponse > ImageDetectColorWithHttpInfo (ImageDetectColorParameters imageDetectColorParameters)
        {
            // verify the required parameter 'imageDetectColorParameters' is set
            if (imageDetectColorParameters == null)
                throw new ApiException(400, "Missing required parameter 'imageDetectColorParameters' when calling ImageApi->ImageDetectColor");

            var localVarPath = "/api/image/ImageDetectColor";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (imageDetectColorParameters != null && imageDetectColorParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(imageDetectColorParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = imageDetectColorParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageDetectColor", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageDetectColorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageDetectColorResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageDetectColorResponse)));
        }

        /// <summary>
        /// Performs color detection  on a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageDetectColorParameters">An ImageDetectColorParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ImageDetectColorResponse</returns>
        public async System.Threading.Tasks.Task<ImageDetectColorResponse> ImageDetectColorAsync (ImageDetectColorParameters imageDetectColorParameters)
        {
             ApiResponse<ImageDetectColorResponse> localVarResponse = await ImageDetectColorAsyncWithHttpInfo(imageDetectColorParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Performs color detection  on a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageDetectColorParameters">An ImageDetectColorParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ApiResponse (ImageDetectColorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageDetectColorResponse>> ImageDetectColorAsyncWithHttpInfo (ImageDetectColorParameters imageDetectColorParameters)
        {
            // verify the required parameter 'imageDetectColorParameters' is set
            if (imageDetectColorParameters == null)
                throw new ApiException(400, "Missing required parameter 'imageDetectColorParameters' when calling ImageApi->ImageDetectColor");

            var localVarPath = "/api/image/ImageDetectColor";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (imageDetectColorParameters != null && imageDetectColorParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(imageDetectColorParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = imageDetectColorParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageDetectColor", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageDetectColorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageDetectColorResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageDetectColorResponse)));
        }

        /// <summary>
        /// Detects the orientation of the page(s) of a previously uploaded image and offers to automatically rotate them. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectPageOrientationParameters">An ImagedetectPageOrientationParameters object specifying the parameters of the action.</param>
        /// <returns>ImageDetectPageOrientationResponse</returns>
        public ImageDetectPageOrientationResponse ImageDetectPageOrientation (ImageDetectPageOrientationParameters detectPageOrientationParameters)
        {
             ApiResponse<ImageDetectPageOrientationResponse> localVarResponse = ImageDetectPageOrientationWithHttpInfo(detectPageOrientationParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Detects the orientation of the page(s) of a previously uploaded image and offers to automatically rotate them. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectPageOrientationParameters">An ImagedetectPageOrientationParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ImageDetectPageOrientationResponse</returns>
        public ApiResponse< ImageDetectPageOrientationResponse > ImageDetectPageOrientationWithHttpInfo (ImageDetectPageOrientationParameters detectPageOrientationParameters)
        {
            // verify the required parameter 'detectPageOrientationParameters' is set
            if (detectPageOrientationParameters == null)
                throw new ApiException(400, "Missing required parameter 'detectPageOrientationParameters' when calling ImageApi->ImageDetectPageOrientation");

            var localVarPath = "/api/image/ImageDetectPageOrientation";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (detectPageOrientationParameters != null && detectPageOrientationParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(detectPageOrientationParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = detectPageOrientationParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageDetectPageOrientation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageDetectPageOrientationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageDetectPageOrientationResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageDetectPageOrientationResponse)));
        }

        /// <summary>
        /// Detects the orientation of the page(s) of a previously uploaded image and offers to automatically rotate them. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectPageOrientationParameters">An ImagedetectPageOrientationParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageDetectPageOrientationResponse</returns>
        public async System.Threading.Tasks.Task<ImageDetectPageOrientationResponse> ImageDetectPageOrientationAsync (ImageDetectPageOrientationParameters detectPageOrientationParameters)
        {
             ApiResponse<ImageDetectPageOrientationResponse> localVarResponse = await ImageDetectPageOrientationAsyncWithHttpInfo(detectPageOrientationParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Detects the orientation of the page(s) of a previously uploaded image and offers to automatically rotate them. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectPageOrientationParameters">An ImagedetectPageOrientationParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ImageDetectPageOrientationResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageDetectPageOrientationResponse>> ImageDetectPageOrientationAsyncWithHttpInfo (ImageDetectPageOrientationParameters detectPageOrientationParameters)
        {
            // verify the required parameter 'detectPageOrientationParameters' is set
            if (detectPageOrientationParameters == null)
                throw new ApiException(400, "Missing required parameter 'detectPageOrientationParameters' when calling ImageApi->ImageDetectPageOrientation");

            var localVarPath = "/api/image/ImageDetectPageOrientation";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (detectPageOrientationParameters != null && detectPageOrientationParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(detectPageOrientationParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = detectPageOrientationParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageDetectPageOrientation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageDetectPageOrientationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageDetectPageOrientationResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageDetectPageOrientationResponse)));
        }

        /// <summary>
        /// Applies filters to a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageFilterParameters">An ImageFilterParameters object specifying the parameters for the action.</param>
        /// <returns>ImageFilterResponse</returns>
        public ImageFilterResponse ImageFilter (ImageFilterParameters imageFilterParameters)
        {
             ApiResponse<ImageFilterResponse> localVarResponse = ImageFilterWithHttpInfo(imageFilterParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Applies filters to a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageFilterParameters">An ImageFilterParameters object specifying the parameters for the action.</param>
        /// <returns>ApiResponse of ImageFilterResponse</returns>
        public ApiResponse< ImageFilterResponse > ImageFilterWithHttpInfo (ImageFilterParameters imageFilterParameters)
        {
            // verify the required parameter 'imageFilterParameters' is set
            if (imageFilterParameters == null)
                throw new ApiException(400, "Missing required parameter 'imageFilterParameters' when calling ImageApi->ImageFilter");

            var localVarPath = "/api/image/ImageFilter";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (imageFilterParameters != null && imageFilterParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(imageFilterParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = imageFilterParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageFilter", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageFilterResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageFilterResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageFilterResponse)));
        }

        /// <summary>
        /// Applies filters to a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageFilterParameters">An ImageFilterParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ImageFilterResponse</returns>
        public async System.Threading.Tasks.Task<ImageFilterResponse> ImageFilterAsync (ImageFilterParameters imageFilterParameters)
        {
             ApiResponse<ImageFilterResponse> localVarResponse = await ImageFilterAsyncWithHttpInfo(imageFilterParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Applies filters to a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageFilterParameters">An ImageFilterParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ApiResponse (ImageFilterResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageFilterResponse>> ImageFilterAsyncWithHttpInfo (ImageFilterParameters imageFilterParameters)
        {
            // verify the required parameter 'imageFilterParameters' is set
            if (imageFilterParameters == null)
                throw new ApiException(400, "Missing required parameter 'imageFilterParameters' when calling ImageApi->ImageFilter");

            var localVarPath = "/api/image/ImageFilter";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (imageFilterParameters != null && imageFilterParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(imageFilterParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = imageFilterParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageFilter", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageFilterResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageFilterResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageFilterResponse)));
        }

        /// <summary>
        /// Gets a thumbnail of each page within the provided page range from a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPageThumbnailParameters">A PDFGetPageThumbnailParameters object specifying the parameters of the action.</param>
        /// <returns>ImageGetPageThumbnailResponse</returns>
        public ImageGetPageThumbnailResponse ImageGetPageThumbnail (ImageGetPageThumbnailParameters getPageThumbnailParameters)
        {
             ApiResponse<ImageGetPageThumbnailResponse> localVarResponse = ImageGetPageThumbnailWithHttpInfo(getPageThumbnailParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a thumbnail of each page within the provided page range from a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPageThumbnailParameters">A PDFGetPageThumbnailParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ImageGetPageThumbnailResponse</returns>
        public ApiResponse< ImageGetPageThumbnailResponse > ImageGetPageThumbnailWithHttpInfo (ImageGetPageThumbnailParameters getPageThumbnailParameters)
        {
            // verify the required parameter 'getPageThumbnailParameters' is set
            if (getPageThumbnailParameters == null)
                throw new ApiException(400, "Missing required parameter 'getPageThumbnailParameters' when calling ImageApi->ImageGetPageThumbnail");

            var localVarPath = "/api/image/ImageGetPageThumbnail";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (getPageThumbnailParameters != null && getPageThumbnailParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(getPageThumbnailParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = getPageThumbnailParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageGetPageThumbnail", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageGetPageThumbnailResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageGetPageThumbnailResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageGetPageThumbnailResponse)));
        }

        /// <summary>
        /// Gets a thumbnail of each page within the provided page range from a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPageThumbnailParameters">A PDFGetPageThumbnailParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageGetPageThumbnailResponse</returns>
        public async System.Threading.Tasks.Task<ImageGetPageThumbnailResponse> ImageGetPageThumbnailAsync (ImageGetPageThumbnailParameters getPageThumbnailParameters)
        {
             ApiResponse<ImageGetPageThumbnailResponse> localVarResponse = await ImageGetPageThumbnailAsyncWithHttpInfo(getPageThumbnailParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a thumbnail of each page within the provided page range from a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPageThumbnailParameters">A PDFGetPageThumbnailParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ImageGetPageThumbnailResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageGetPageThumbnailResponse>> ImageGetPageThumbnailAsyncWithHttpInfo (ImageGetPageThumbnailParameters getPageThumbnailParameters)
        {
            // verify the required parameter 'getPageThumbnailParameters' is set
            if (getPageThumbnailParameters == null)
                throw new ApiException(400, "Missing required parameter 'getPageThumbnailParameters' when calling ImageApi->ImageGetPageThumbnail");

            var localVarPath = "/api/image/ImageGetPageThumbnail";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (getPageThumbnailParameters != null && getPageThumbnailParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(getPageThumbnailParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = getPageThumbnailParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageGetPageThumbnail", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageGetPageThumbnailResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageGetPageThumbnailResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageGetPageThumbnailResponse)));
        }

        /// <summary>
        /// Gets the supported file extensions by the image loading actions. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>StringArrayResponse</returns>
        public StringArrayResponse ImageGetSupportedFileExtensions ()
        {
             ApiResponse<StringArrayResponse> localVarResponse = ImageGetSupportedFileExtensionsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the supported file extensions by the image loading actions. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of StringArrayResponse</returns>
        public ApiResponse< StringArrayResponse > ImageGetSupportedFileExtensionsWithHttpInfo ()
        {

            var localVarPath = "/api/image/ImageGetSupportedFileExtensions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageGetSupportedFileExtensions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StringArrayResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (StringArrayResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StringArrayResponse)));
        }

        /// <summary>
        /// Gets the supported file extensions by the image loading actions. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of StringArrayResponse</returns>
        public async System.Threading.Tasks.Task<StringArrayResponse> ImageGetSupportedFileExtensionsAsync ()
        {
             ApiResponse<StringArrayResponse> localVarResponse = await ImageGetSupportedFileExtensionsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets the supported file extensions by the image loading actions. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (StringArrayResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StringArrayResponse>> ImageGetSupportedFileExtensionsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/image/ImageGetSupportedFileExtensions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageGetSupportedFileExtensions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StringArrayResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (StringArrayResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StringArrayResponse)));
        }

        /// <summary>
        /// Loads the provided image file.  Supported image formats can be retrieved by the GetSupportedImageFileExtensions action. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loadImageParameters">A LoadImageFromByteArrayParameters object specifying the parameters of the action.</param>
        /// <returns>ImageLoadResponse</returns>
        public ImageLoadResponse ImageLoad (LoadImageFromByteArrayParameters loadImageParameters)
        {
             ApiResponse<ImageLoadResponse> localVarResponse = ImageLoadWithHttpInfo(loadImageParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Loads the provided image file.  Supported image formats can be retrieved by the GetSupportedImageFileExtensions action. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loadImageParameters">A LoadImageFromByteArrayParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ImageLoadResponse</returns>
        public ApiResponse< ImageLoadResponse > ImageLoadWithHttpInfo (LoadImageFromByteArrayParameters loadImageParameters)
        {
            // verify the required parameter 'loadImageParameters' is set
            if (loadImageParameters == null)
                throw new ApiException(400, "Missing required parameter 'loadImageParameters' when calling ImageApi->ImageLoad");

            var localVarPath = "/api/image/ImageLoad";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (loadImageParameters != null && loadImageParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(loadImageParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = loadImageParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageLoad", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageLoadResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageLoadResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageLoadResponse)));
        }

        /// <summary>
        /// Loads the provided image file.  Supported image formats can be retrieved by the GetSupportedImageFileExtensions action. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loadImageParameters">A LoadImageFromByteArrayParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageLoadResponse</returns>
        public async System.Threading.Tasks.Task<ImageLoadResponse> ImageLoadAsync (LoadImageFromByteArrayParameters loadImageParameters)
        {
             ApiResponse<ImageLoadResponse> localVarResponse = await ImageLoadAsyncWithHttpInfo(loadImageParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Loads the provided image file.  Supported image formats can be retrieved by the GetSupportedImageFileExtensions action. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loadImageParameters">A LoadImageFromByteArrayParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ImageLoadResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageLoadResponse>> ImageLoadAsyncWithHttpInfo (LoadImageFromByteArrayParameters loadImageParameters)
        {
            // verify the required parameter 'loadImageParameters' is set
            if (loadImageParameters == null)
                throw new ApiException(400, "Missing required parameter 'loadImageParameters' when calling ImageApi->ImageLoad");

            var localVarPath = "/api/image/ImageLoad";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (loadImageParameters != null && loadImageParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(loadImageParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = loadImageParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageLoad", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageLoadResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageLoadResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageLoadResponse)));
        }

        /// <summary>
        /// Loads the provided image file using Multipart Upload.  Supported image formats can be retrieved by the GetSupportedImageFileExtensions action. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileData">Specifies the stream of data of the file to be uploaded.</param>
        /// <param name="contentEncoding">Specifies the encoding of the fileData content. (optional, default to &quot;Identity&quot;)</param>
        /// <param name="fileName">Specifies the name of the file to be uploaded. (optional)</param>
        /// <returns>ImageLoadResponse</returns>
        public ImageLoadResponse ImageLoadMultipart (System.IO.Stream fileData, string contentEncoding = null, string fileName = null)
        {
             ApiResponse<ImageLoadResponse> localVarResponse = ImageLoadMultipartWithHttpInfo(fileData, contentEncoding, fileName);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Loads the provided image file using Multipart Upload.  Supported image formats can be retrieved by the GetSupportedImageFileExtensions action. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileData">Specifies the stream of data of the file to be uploaded.</param>
        /// <param name="contentEncoding">Specifies the encoding of the fileData content. (optional, default to &quot;Identity&quot;)</param>
        /// <param name="fileName">Specifies the name of the file to be uploaded. (optional)</param>
        /// <returns>ApiResponse of ImageLoadResponse</returns>
        public ApiResponse< ImageLoadResponse > ImageLoadMultipartWithHttpInfo (System.IO.Stream fileData, string contentEncoding = null, string fileName = null)
        {
            // verify the required parameter 'fileData' is set
            if (fileData == null)
                throw new ApiException(400, "Missing required parameter 'fileData' when calling ImageApi->ImageLoadMultipart");

            var localVarPath = "/api/image/ImageLoadMultipart";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fileData != null) localVarFileParams.Add("FileData", this.Configuration.ApiClient.ParameterToFile("FileData", fileData));
            if (contentEncoding != null) localVarFormParams.Add("ContentEncoding", this.Configuration.ApiClient.ParameterToString(contentEncoding)); // form parameter
            if (fileName != null) localVarFormParams.Add("FileName", this.Configuration.ApiClient.ParameterToString(fileName)); // form parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageLoadMultipart", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageLoadResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageLoadResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageLoadResponse)));
        }

        /// <summary>
        /// Loads the provided image file using Multipart Upload.  Supported image formats can be retrieved by the GetSupportedImageFileExtensions action. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileData">Specifies the stream of data of the file to be uploaded.</param>
        /// <param name="contentEncoding">Specifies the encoding of the fileData content. (optional, default to &quot;Identity&quot;)</param>
        /// <param name="fileName">Specifies the name of the file to be uploaded. (optional)</param>
        /// <returns>Task of ImageLoadResponse</returns>
        public async System.Threading.Tasks.Task<ImageLoadResponse> ImageLoadMultipartAsync (System.IO.Stream fileData, string contentEncoding = null, string fileName = null)
        {
             ApiResponse<ImageLoadResponse> localVarResponse = await ImageLoadMultipartAsyncWithHttpInfo(fileData, contentEncoding, fileName);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Loads the provided image file using Multipart Upload.  Supported image formats can be retrieved by the GetSupportedImageFileExtensions action. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileData">Specifies the stream of data of the file to be uploaded.</param>
        /// <param name="contentEncoding">Specifies the encoding of the fileData content. (optional, default to &quot;Identity&quot;)</param>
        /// <param name="fileName">Specifies the name of the file to be uploaded. (optional)</param>
        /// <returns>Task of ApiResponse (ImageLoadResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageLoadResponse>> ImageLoadMultipartAsyncWithHttpInfo (System.IO.Stream fileData, string contentEncoding = null, string fileName = null)
        {
            // verify the required parameter 'fileData' is set
            if (fileData == null)
                throw new ApiException(400, "Missing required parameter 'fileData' when calling ImageApi->ImageLoadMultipart");

            var localVarPath = "/api/image/ImageLoadMultipart";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fileData != null) localVarFileParams.Add("FileData", this.Configuration.ApiClient.ParameterToFile("FileData", fileData));
            if (contentEncoding != null) localVarFormParams.Add("ContentEncoding", this.Configuration.ApiClient.ParameterToString(contentEncoding)); // form parameter
            if (fileName != null) localVarFormParams.Add("FileName", this.Configuration.ApiClient.ParameterToString(fileName)); // form parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageLoadMultipart", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageLoadResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageLoadResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageLoadResponse)));
        }

        /// <summary>
        /// Performs MICR (Magnetic Ink Character Recognition) on a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="micrParameters">An ImageMICRParameters object specifying the parameters of the action.</param>
        /// <returns>ImageMICRResponse</returns>
        public ImageMICRResponse ImageMICR (ImageMICRParameters micrParameters)
        {
             ApiResponse<ImageMICRResponse> localVarResponse = ImageMICRWithHttpInfo(micrParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Performs MICR (Magnetic Ink Character Recognition) on a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="micrParameters">An ImageMICRParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ImageMICRResponse</returns>
        public ApiResponse< ImageMICRResponse > ImageMICRWithHttpInfo (ImageMICRParameters micrParameters)
        {
            // verify the required parameter 'micrParameters' is set
            if (micrParameters == null)
                throw new ApiException(400, "Missing required parameter 'micrParameters' when calling ImageApi->ImageMICR");

            var localVarPath = "/api/image/ImageMICR";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (micrParameters != null && micrParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(micrParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = micrParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageMICR", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageMICRResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageMICRResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageMICRResponse)));
        }

        /// <summary>
        /// Performs MICR (Magnetic Ink Character Recognition) on a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="micrParameters">An ImageMICRParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageMICRResponse</returns>
        public async System.Threading.Tasks.Task<ImageMICRResponse> ImageMICRAsync (ImageMICRParameters micrParameters)
        {
             ApiResponse<ImageMICRResponse> localVarResponse = await ImageMICRAsyncWithHttpInfo(micrParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Performs MICR (Magnetic Ink Character Recognition) on a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="micrParameters">An ImageMICRParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ImageMICRResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageMICRResponse>> ImageMICRAsyncWithHttpInfo (ImageMICRParameters micrParameters)
        {
            // verify the required parameter 'micrParameters' is set
            if (micrParameters == null)
                throw new ApiException(400, "Missing required parameter 'micrParameters' when calling ImageApi->ImageMICR");

            var localVarPath = "/api/image/ImageMICR";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (micrParameters != null && micrParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(micrParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = micrParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageMICR", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageMICRResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageMICRResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageMICRResponse)));
        }

        /// <summary>
        /// Reads barcodes from a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readBarcodeParameters">An ImageReadBarcodesParameters object specifying the parameters of the action.</param>
        /// <returns>ReadBarcodesResponse</returns>
        public ReadBarcodesResponse ImageReadBarcodes (ImageReadBarcodesParameters readBarcodeParameters)
        {
             ApiResponse<ReadBarcodesResponse> localVarResponse = ImageReadBarcodesWithHttpInfo(readBarcodeParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Reads barcodes from a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readBarcodeParameters">An ImageReadBarcodesParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ReadBarcodesResponse</returns>
        public ApiResponse< ReadBarcodesResponse > ImageReadBarcodesWithHttpInfo (ImageReadBarcodesParameters readBarcodeParameters)
        {
            // verify the required parameter 'readBarcodeParameters' is set
            if (readBarcodeParameters == null)
                throw new ApiException(400, "Missing required parameter 'readBarcodeParameters' when calling ImageApi->ImageReadBarcodes");

            var localVarPath = "/api/image/ImageReadBarcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (readBarcodeParameters != null && readBarcodeParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(readBarcodeParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = readBarcodeParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageReadBarcodes", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ReadBarcodesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ReadBarcodesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReadBarcodesResponse)));
        }

        /// <summary>
        /// Reads barcodes from a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readBarcodeParameters">An ImageReadBarcodesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ReadBarcodesResponse</returns>
        public async System.Threading.Tasks.Task<ReadBarcodesResponse> ImageReadBarcodesAsync (ImageReadBarcodesParameters readBarcodeParameters)
        {
             ApiResponse<ReadBarcodesResponse> localVarResponse = await ImageReadBarcodesAsyncWithHttpInfo(readBarcodeParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Reads barcodes from a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readBarcodeParameters">An ImageReadBarcodesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ReadBarcodesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReadBarcodesResponse>> ImageReadBarcodesAsyncWithHttpInfo (ImageReadBarcodesParameters readBarcodeParameters)
        {
            // verify the required parameter 'readBarcodeParameters' is set
            if (readBarcodeParameters == null)
                throw new ApiException(400, "Missing required parameter 'readBarcodeParameters' when calling ImageApi->ImageReadBarcodes");

            var localVarPath = "/api/image/ImageReadBarcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (readBarcodeParameters != null && readBarcodeParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(readBarcodeParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = readBarcodeParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageReadBarcodes", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ReadBarcodesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ReadBarcodesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReadBarcodesResponse)));
        }

        /// <summary>
        /// Resizes a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageResizeParameters">An ImageResizeParameters object specifying the parameters for the action.</param>
        /// <returns>ImageResizeResponse</returns>
        public ImageResizeResponse ImageResize (ImageResizeParameters imageResizeParameters)
        {
             ApiResponse<ImageResizeResponse> localVarResponse = ImageResizeWithHttpInfo(imageResizeParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Resizes a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageResizeParameters">An ImageResizeParameters object specifying the parameters for the action.</param>
        /// <returns>ApiResponse of ImageResizeResponse</returns>
        public ApiResponse< ImageResizeResponse > ImageResizeWithHttpInfo (ImageResizeParameters imageResizeParameters)
        {
            // verify the required parameter 'imageResizeParameters' is set
            if (imageResizeParameters == null)
                throw new ApiException(400, "Missing required parameter 'imageResizeParameters' when calling ImageApi->ImageResize");

            var localVarPath = "/api/image/ImageResize";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (imageResizeParameters != null && imageResizeParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(imageResizeParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = imageResizeParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageResize", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageResizeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageResizeResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageResizeResponse)));
        }

        /// <summary>
        /// Resizes a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageResizeParameters">An ImageResizeParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ImageResizeResponse</returns>
        public async System.Threading.Tasks.Task<ImageResizeResponse> ImageResizeAsync (ImageResizeParameters imageResizeParameters)
        {
             ApiResponse<ImageResizeResponse> localVarResponse = await ImageResizeAsyncWithHttpInfo(imageResizeParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Resizes a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageResizeParameters">An ImageResizeParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ApiResponse (ImageResizeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageResizeResponse>> ImageResizeAsyncWithHttpInfo (ImageResizeParameters imageResizeParameters)
        {
            // verify the required parameter 'imageResizeParameters' is set
            if (imageResizeParameters == null)
                throw new ApiException(400, "Missing required parameter 'imageResizeParameters' when calling ImageApi->ImageResize");

            var localVarPath = "/api/image/ImageResize";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (imageResizeParameters != null && imageResizeParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(imageResizeParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = imageResizeParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageResize", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageResizeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageResizeResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageResizeResponse)));
        }

        /// <summary>
        /// Rotates and/or flips a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageRotateParameters">An ImageRotateParameters object specifying the parameters for the action.</param>
        /// <returns>ImageRotateResponse</returns>
        public ImageRotateResponse ImageRotate (ImageRotateParameters imageRotateParameters)
        {
             ApiResponse<ImageRotateResponse> localVarResponse = ImageRotateWithHttpInfo(imageRotateParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Rotates and/or flips a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageRotateParameters">An ImageRotateParameters object specifying the parameters for the action.</param>
        /// <returns>ApiResponse of ImageRotateResponse</returns>
        public ApiResponse< ImageRotateResponse > ImageRotateWithHttpInfo (ImageRotateParameters imageRotateParameters)
        {
            // verify the required parameter 'imageRotateParameters' is set
            if (imageRotateParameters == null)
                throw new ApiException(400, "Missing required parameter 'imageRotateParameters' when calling ImageApi->ImageRotate");

            var localVarPath = "/api/image/ImageRotate";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (imageRotateParameters != null && imageRotateParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(imageRotateParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = imageRotateParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageRotate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageRotateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageRotateResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageRotateResponse)));
        }

        /// <summary>
        /// Rotates and/or flips a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageRotateParameters">An ImageRotateParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ImageRotateResponse</returns>
        public async System.Threading.Tasks.Task<ImageRotateResponse> ImageRotateAsync (ImageRotateParameters imageRotateParameters)
        {
             ApiResponse<ImageRotateResponse> localVarResponse = await ImageRotateAsyncWithHttpInfo(imageRotateParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Rotates and/or flips a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageRotateParameters">An ImageRotateParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ApiResponse (ImageRotateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageRotateResponse>> ImageRotateAsyncWithHttpInfo (ImageRotateParameters imageRotateParameters)
        {
            // verify the required parameter 'imageRotateParameters' is set
            if (imageRotateParameters == null)
                throw new ApiException(400, "Missing required parameter 'imageRotateParameters' when calling ImageApi->ImageRotate");

            var localVarPath = "/api/image/ImageRotate";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (imageRotateParameters != null && imageRotateParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(imageRotateParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = imageRotateParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageRotate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageRotateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageRotateResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageRotateResponse)));
        }

        /// <summary>
        /// Saves a previously uploaded image as JPEG. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsJPEGParameters">An ImageSaveAsJPEGParameters object specifying the parameters of the action.</param>
        /// <returns>ImageSaveAsJPEGResponse</returns>
        public ImageSaveAsJPEGResponse ImageSaveAsJPEG (ImageSaveAsJPEGParameters saveAsJPEGParameters)
        {
             ApiResponse<ImageSaveAsJPEGResponse> localVarResponse = ImageSaveAsJPEGWithHttpInfo(saveAsJPEGParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Saves a previously uploaded image as JPEG. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsJPEGParameters">An ImageSaveAsJPEGParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ImageSaveAsJPEGResponse</returns>
        public ApiResponse< ImageSaveAsJPEGResponse > ImageSaveAsJPEGWithHttpInfo (ImageSaveAsJPEGParameters saveAsJPEGParameters)
        {
            // verify the required parameter 'saveAsJPEGParameters' is set
            if (saveAsJPEGParameters == null)
                throw new ApiException(400, "Missing required parameter 'saveAsJPEGParameters' when calling ImageApi->ImageSaveAsJPEG");

            var localVarPath = "/api/image/ImageSaveAsJPEG";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (saveAsJPEGParameters != null && saveAsJPEGParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(saveAsJPEGParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = saveAsJPEGParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageSaveAsJPEG", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageSaveAsJPEGResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageSaveAsJPEGResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageSaveAsJPEGResponse)));
        }

        /// <summary>
        /// Saves a previously uploaded image as JPEG. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsJPEGParameters">An ImageSaveAsJPEGParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageSaveAsJPEGResponse</returns>
        public async System.Threading.Tasks.Task<ImageSaveAsJPEGResponse> ImageSaveAsJPEGAsync (ImageSaveAsJPEGParameters saveAsJPEGParameters)
        {
             ApiResponse<ImageSaveAsJPEGResponse> localVarResponse = await ImageSaveAsJPEGAsyncWithHttpInfo(saveAsJPEGParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Saves a previously uploaded image as JPEG. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsJPEGParameters">An ImageSaveAsJPEGParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ImageSaveAsJPEGResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageSaveAsJPEGResponse>> ImageSaveAsJPEGAsyncWithHttpInfo (ImageSaveAsJPEGParameters saveAsJPEGParameters)
        {
            // verify the required parameter 'saveAsJPEGParameters' is set
            if (saveAsJPEGParameters == null)
                throw new ApiException(400, "Missing required parameter 'saveAsJPEGParameters' when calling ImageApi->ImageSaveAsJPEG");

            var localVarPath = "/api/image/ImageSaveAsJPEG";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (saveAsJPEGParameters != null && saveAsJPEGParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(saveAsJPEGParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = saveAsJPEGParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageSaveAsJPEG", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageSaveAsJPEGResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageSaveAsJPEGResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageSaveAsJPEGResponse)));
        }

        /// <summary>
        /// Saves a previously uploaded image as PDF. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPDFParameters">An ImagesaveAsPDFParameters object specifying the parameters of the action.</param>
        /// <returns>ImageSaveAsPDFResponse</returns>
        public ImageSaveAsPDFResponse ImageSaveAsPDF (ImageSaveAsPDFParameters saveAsPDFParameters)
        {
             ApiResponse<ImageSaveAsPDFResponse> localVarResponse = ImageSaveAsPDFWithHttpInfo(saveAsPDFParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Saves a previously uploaded image as PDF. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPDFParameters">An ImagesaveAsPDFParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ImageSaveAsPDFResponse</returns>
        public ApiResponse< ImageSaveAsPDFResponse > ImageSaveAsPDFWithHttpInfo (ImageSaveAsPDFParameters saveAsPDFParameters)
        {
            // verify the required parameter 'saveAsPDFParameters' is set
            if (saveAsPDFParameters == null)
                throw new ApiException(400, "Missing required parameter 'saveAsPDFParameters' when calling ImageApi->ImageSaveAsPDF");

            var localVarPath = "/api/image/ImageSaveAsPDF";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (saveAsPDFParameters != null && saveAsPDFParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(saveAsPDFParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = saveAsPDFParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageSaveAsPDF", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageSaveAsPDFResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageSaveAsPDFResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageSaveAsPDFResponse)));
        }

        /// <summary>
        /// Saves a previously uploaded image as PDF. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPDFParameters">An ImagesaveAsPDFParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageSaveAsPDFResponse</returns>
        public async System.Threading.Tasks.Task<ImageSaveAsPDFResponse> ImageSaveAsPDFAsync (ImageSaveAsPDFParameters saveAsPDFParameters)
        {
             ApiResponse<ImageSaveAsPDFResponse> localVarResponse = await ImageSaveAsPDFAsyncWithHttpInfo(saveAsPDFParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Saves a previously uploaded image as PDF. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPDFParameters">An ImagesaveAsPDFParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ImageSaveAsPDFResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageSaveAsPDFResponse>> ImageSaveAsPDFAsyncWithHttpInfo (ImageSaveAsPDFParameters saveAsPDFParameters)
        {
            // verify the required parameter 'saveAsPDFParameters' is set
            if (saveAsPDFParameters == null)
                throw new ApiException(400, "Missing required parameter 'saveAsPDFParameters' when calling ImageApi->ImageSaveAsPDF");

            var localVarPath = "/api/image/ImageSaveAsPDF";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (saveAsPDFParameters != null && saveAsPDFParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(saveAsPDFParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = saveAsPDFParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageSaveAsPDF", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageSaveAsPDFResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageSaveAsPDFResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageSaveAsPDFResponse)));
        }

        /// <summary>
        /// Saves a previously uploaded image as PDF using MRC compression. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPDFMRCParameters">An ImagesaveAsPDFMRCParameters object specifying the parameters of the action.</param>
        /// <returns>ImageSaveAsPDFMRCResponse</returns>
        public ImageSaveAsPDFMRCResponse ImageSaveAsPDFMRC (ImageSaveAsPDFMRCParameters saveAsPDFMRCParameters)
        {
             ApiResponse<ImageSaveAsPDFMRCResponse> localVarResponse = ImageSaveAsPDFMRCWithHttpInfo(saveAsPDFMRCParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Saves a previously uploaded image as PDF using MRC compression. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPDFMRCParameters">An ImagesaveAsPDFMRCParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ImageSaveAsPDFMRCResponse</returns>
        public ApiResponse< ImageSaveAsPDFMRCResponse > ImageSaveAsPDFMRCWithHttpInfo (ImageSaveAsPDFMRCParameters saveAsPDFMRCParameters)
        {
            // verify the required parameter 'saveAsPDFMRCParameters' is set
            if (saveAsPDFMRCParameters == null)
                throw new ApiException(400, "Missing required parameter 'saveAsPDFMRCParameters' when calling ImageApi->ImageSaveAsPDFMRC");

            var localVarPath = "/api/image/ImageSaveAsPDFMRC";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (saveAsPDFMRCParameters != null && saveAsPDFMRCParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(saveAsPDFMRCParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = saveAsPDFMRCParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageSaveAsPDFMRC", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageSaveAsPDFMRCResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageSaveAsPDFMRCResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageSaveAsPDFMRCResponse)));
        }

        /// <summary>
        /// Saves a previously uploaded image as PDF using MRC compression. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPDFMRCParameters">An ImagesaveAsPDFMRCParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageSaveAsPDFMRCResponse</returns>
        public async System.Threading.Tasks.Task<ImageSaveAsPDFMRCResponse> ImageSaveAsPDFMRCAsync (ImageSaveAsPDFMRCParameters saveAsPDFMRCParameters)
        {
             ApiResponse<ImageSaveAsPDFMRCResponse> localVarResponse = await ImageSaveAsPDFMRCAsyncWithHttpInfo(saveAsPDFMRCParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Saves a previously uploaded image as PDF using MRC compression. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPDFMRCParameters">An ImagesaveAsPDFMRCParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ImageSaveAsPDFMRCResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageSaveAsPDFMRCResponse>> ImageSaveAsPDFMRCAsyncWithHttpInfo (ImageSaveAsPDFMRCParameters saveAsPDFMRCParameters)
        {
            // verify the required parameter 'saveAsPDFMRCParameters' is set
            if (saveAsPDFMRCParameters == null)
                throw new ApiException(400, "Missing required parameter 'saveAsPDFMRCParameters' when calling ImageApi->ImageSaveAsPDFMRC");

            var localVarPath = "/api/image/ImageSaveAsPDFMRC";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (saveAsPDFMRCParameters != null && saveAsPDFMRCParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(saveAsPDFMRCParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = saveAsPDFMRCParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageSaveAsPDFMRC", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageSaveAsPDFMRCResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageSaveAsPDFMRCResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageSaveAsPDFMRCResponse)));
        }

        /// <summary>
        /// Saves a previously uploaded image as PNG. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPNGParameters">An ImageSaveAsPNGParameters object specifying the parameters of the action.</param>
        /// <returns>ImageSaveAsPNGResponse</returns>
        public ImageSaveAsPNGResponse ImageSaveAsPNG (ImageSaveAsPNGParameters saveAsPNGParameters)
        {
             ApiResponse<ImageSaveAsPNGResponse> localVarResponse = ImageSaveAsPNGWithHttpInfo(saveAsPNGParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Saves a previously uploaded image as PNG. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPNGParameters">An ImageSaveAsPNGParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ImageSaveAsPNGResponse</returns>
        public ApiResponse< ImageSaveAsPNGResponse > ImageSaveAsPNGWithHttpInfo (ImageSaveAsPNGParameters saveAsPNGParameters)
        {
            // verify the required parameter 'saveAsPNGParameters' is set
            if (saveAsPNGParameters == null)
                throw new ApiException(400, "Missing required parameter 'saveAsPNGParameters' when calling ImageApi->ImageSaveAsPNG");

            var localVarPath = "/api/image/ImageSaveAsPNG";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (saveAsPNGParameters != null && saveAsPNGParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(saveAsPNGParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = saveAsPNGParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageSaveAsPNG", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageSaveAsPNGResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageSaveAsPNGResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageSaveAsPNGResponse)));
        }

        /// <summary>
        /// Saves a previously uploaded image as PNG. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPNGParameters">An ImageSaveAsPNGParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageSaveAsPNGResponse</returns>
        public async System.Threading.Tasks.Task<ImageSaveAsPNGResponse> ImageSaveAsPNGAsync (ImageSaveAsPNGParameters saveAsPNGParameters)
        {
             ApiResponse<ImageSaveAsPNGResponse> localVarResponse = await ImageSaveAsPNGAsyncWithHttpInfo(saveAsPNGParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Saves a previously uploaded image as PNG. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPNGParameters">An ImageSaveAsPNGParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ImageSaveAsPNGResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageSaveAsPNGResponse>> ImageSaveAsPNGAsyncWithHttpInfo (ImageSaveAsPNGParameters saveAsPNGParameters)
        {
            // verify the required parameter 'saveAsPNGParameters' is set
            if (saveAsPNGParameters == null)
                throw new ApiException(400, "Missing required parameter 'saveAsPNGParameters' when calling ImageApi->ImageSaveAsPNG");

            var localVarPath = "/api/image/ImageSaveAsPNG";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (saveAsPNGParameters != null && saveAsPNGParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(saveAsPNGParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = saveAsPNGParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageSaveAsPNG", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageSaveAsPNGResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageSaveAsPNGResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageSaveAsPNGResponse)));
        }

        /// <summary>
        /// Saves a previously uploaded image as TIFF. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFParameters">An ImageSaveAsTIFFParameters object specifying the parameters of the action.</param>
        /// <returns>ImageSaveAsTIFFResponse</returns>
        public ImageSaveAsTIFFResponse ImageSaveAsTIFF (ImageSaveAsTIFFParameters saveAsTIFFParameters)
        {
             ApiResponse<ImageSaveAsTIFFResponse> localVarResponse = ImageSaveAsTIFFWithHttpInfo(saveAsTIFFParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Saves a previously uploaded image as TIFF. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFParameters">An ImageSaveAsTIFFParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ImageSaveAsTIFFResponse</returns>
        public ApiResponse< ImageSaveAsTIFFResponse > ImageSaveAsTIFFWithHttpInfo (ImageSaveAsTIFFParameters saveAsTIFFParameters)
        {
            // verify the required parameter 'saveAsTIFFParameters' is set
            if (saveAsTIFFParameters == null)
                throw new ApiException(400, "Missing required parameter 'saveAsTIFFParameters' when calling ImageApi->ImageSaveAsTIFF");

            var localVarPath = "/api/image/ImageSaveAsTIFF";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (saveAsTIFFParameters != null && saveAsTIFFParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(saveAsTIFFParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = saveAsTIFFParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageSaveAsTIFF", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageSaveAsTIFFResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageSaveAsTIFFResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageSaveAsTIFFResponse)));
        }

        /// <summary>
        /// Saves a previously uploaded image as TIFF. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFParameters">An ImageSaveAsTIFFParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageSaveAsTIFFResponse</returns>
        public async System.Threading.Tasks.Task<ImageSaveAsTIFFResponse> ImageSaveAsTIFFAsync (ImageSaveAsTIFFParameters saveAsTIFFParameters)
        {
             ApiResponse<ImageSaveAsTIFFResponse> localVarResponse = await ImageSaveAsTIFFAsyncWithHttpInfo(saveAsTIFFParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Saves a previously uploaded image as TIFF. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFParameters">An ImageSaveAsTIFFParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ImageSaveAsTIFFResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageSaveAsTIFFResponse>> ImageSaveAsTIFFAsyncWithHttpInfo (ImageSaveAsTIFFParameters saveAsTIFFParameters)
        {
            // verify the required parameter 'saveAsTIFFParameters' is set
            if (saveAsTIFFParameters == null)
                throw new ApiException(400, "Missing required parameter 'saveAsTIFFParameters' when calling ImageApi->ImageSaveAsTIFF");

            var localVarPath = "/api/image/ImageSaveAsTIFF";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (saveAsTIFFParameters != null && saveAsTIFFParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(saveAsTIFFParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = saveAsTIFFParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageSaveAsTIFF", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageSaveAsTIFFResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageSaveAsTIFFResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageSaveAsTIFFResponse)));
        }

        /// <summary>
        /// Saves a previously uploaded image as multipage TIFF. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFMultipageParameters">An ImageSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        /// <returns>ImageSaveAsTIFFMultipageResponse</returns>
        public ImageSaveAsTIFFMultipageResponse ImageSaveAsTIFFMultipage (ImageSaveAsTIFFMultipageParameters saveAsTIFFMultipageParameters)
        {
             ApiResponse<ImageSaveAsTIFFMultipageResponse> localVarResponse = ImageSaveAsTIFFMultipageWithHttpInfo(saveAsTIFFMultipageParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Saves a previously uploaded image as multipage TIFF. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFMultipageParameters">An ImageSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ImageSaveAsTIFFMultipageResponse</returns>
        public ApiResponse< ImageSaveAsTIFFMultipageResponse > ImageSaveAsTIFFMultipageWithHttpInfo (ImageSaveAsTIFFMultipageParameters saveAsTIFFMultipageParameters)
        {
            // verify the required parameter 'saveAsTIFFMultipageParameters' is set
            if (saveAsTIFFMultipageParameters == null)
                throw new ApiException(400, "Missing required parameter 'saveAsTIFFMultipageParameters' when calling ImageApi->ImageSaveAsTIFFMultipage");

            var localVarPath = "/api/image/ImageSaveAsTIFFMultipage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (saveAsTIFFMultipageParameters != null && saveAsTIFFMultipageParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(saveAsTIFFMultipageParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = saveAsTIFFMultipageParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageSaveAsTIFFMultipage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageSaveAsTIFFMultipageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageSaveAsTIFFMultipageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageSaveAsTIFFMultipageResponse)));
        }

        /// <summary>
        /// Saves a previously uploaded image as multipage TIFF. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFMultipageParameters">An ImageSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageSaveAsTIFFMultipageResponse</returns>
        public async System.Threading.Tasks.Task<ImageSaveAsTIFFMultipageResponse> ImageSaveAsTIFFMultipageAsync (ImageSaveAsTIFFMultipageParameters saveAsTIFFMultipageParameters)
        {
             ApiResponse<ImageSaveAsTIFFMultipageResponse> localVarResponse = await ImageSaveAsTIFFMultipageAsyncWithHttpInfo(saveAsTIFFMultipageParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Saves a previously uploaded image as multipage TIFF. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFMultipageParameters">An ImageSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ImageSaveAsTIFFMultipageResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageSaveAsTIFFMultipageResponse>> ImageSaveAsTIFFMultipageAsyncWithHttpInfo (ImageSaveAsTIFFMultipageParameters saveAsTIFFMultipageParameters)
        {
            // verify the required parameter 'saveAsTIFFMultipageParameters' is set
            if (saveAsTIFFMultipageParameters == null)
                throw new ApiException(400, "Missing required parameter 'saveAsTIFFMultipageParameters' when calling ImageApi->ImageSaveAsTIFFMultipage");

            var localVarPath = "/api/image/ImageSaveAsTIFFMultipage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (saveAsTIFFMultipageParameters != null && saveAsTIFFMultipageParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(saveAsTIFFMultipageParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = saveAsTIFFMultipageParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageSaveAsTIFFMultipage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageSaveAsTIFFMultipageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageSaveAsTIFFMultipageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageSaveAsTIFFMultipageResponse)));
        }

        /// <summary>
        /// Swaps two pages from a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="swapPagesParameters">An ImageSwapPagesParameters object specifying the parameters of the action.</param>
        /// <returns>ImageSwapPagesResponse</returns>
        public ImageSwapPagesResponse ImageSwapPages (ImageSwapPagesParameters swapPagesParameters)
        {
             ApiResponse<ImageSwapPagesResponse> localVarResponse = ImageSwapPagesWithHttpInfo(swapPagesParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Swaps two pages from a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="swapPagesParameters">An ImageSwapPagesParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ImageSwapPagesResponse</returns>
        public ApiResponse< ImageSwapPagesResponse > ImageSwapPagesWithHttpInfo (ImageSwapPagesParameters swapPagesParameters)
        {
            // verify the required parameter 'swapPagesParameters' is set
            if (swapPagesParameters == null)
                throw new ApiException(400, "Missing required parameter 'swapPagesParameters' when calling ImageApi->ImageSwapPages");

            var localVarPath = "/api/image/ImageSwapPages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (swapPagesParameters != null && swapPagesParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(swapPagesParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = swapPagesParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageSwapPages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageSwapPagesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageSwapPagesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageSwapPagesResponse)));
        }

        /// <summary>
        /// Swaps two pages from a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="swapPagesParameters">An ImageSwapPagesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageSwapPagesResponse</returns>
        public async System.Threading.Tasks.Task<ImageSwapPagesResponse> ImageSwapPagesAsync (ImageSwapPagesParameters swapPagesParameters)
        {
             ApiResponse<ImageSwapPagesResponse> localVarResponse = await ImageSwapPagesAsyncWithHttpInfo(swapPagesParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Swaps two pages from a previously uploaded image. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="swapPagesParameters">An ImageSwapPagesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ImageSwapPagesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageSwapPagesResponse>> ImageSwapPagesAsyncWithHttpInfo (ImageSwapPagesParameters swapPagesParameters)
        {
            // verify the required parameter 'swapPagesParameters' is set
            if (swapPagesParameters == null)
                throw new ApiException(400, "Missing required parameter 'swapPagesParameters' when calling ImageApi->ImageSwapPages");

            var localVarPath = "/api/image/ImageSwapPages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (swapPagesParameters != null && swapPagesParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(swapPagesParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = swapPagesParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImageSwapPages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageSwapPagesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageSwapPagesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageSwapPagesResponse)));
        }

    }
}
