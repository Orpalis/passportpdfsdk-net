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
    public interface IImageApiSync
    {

        /// <summary>
        /// Adjusts a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageAdjustParameters">An ImageAdjustParameters object specifying the parameters for the action.</param>
        /// <returns>ImageAdjustResponse</returns>
        ImageAdjustResponse ImageAdjust(ImageAdjustParameters imageAdjustParameters);

        /// <summary>
        /// Automatically crops a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageAutoCropParameters">An ImageAutoCropParameters object specifying the parameters for the action.</param>
        /// <returns>ImageAutoCropResponse</returns>
        ImageAutoCropResponse ImageAutoCrop(ImageAutoCropParameters imageAutoCropParameters);

        /// <summary>
        /// Cleanup a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageCleanupDocumentParameters">An ImageCleanupDocumentParameters object specifying the parameters for the action.</param>
        /// <returns>ImageCleanupDocumentResponse</returns>
        ImageCleanupDocumentResponse ImageCleanupDocument(ImageCleanupDocumentParameters imageCleanupDocumentParameters);

        /// <summary>
        /// Clones regions from a previously uploaded image into new images.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageCloneRegionsParameters">An ImageCloneRegionsParameters object specifying the parameters of the action.</param>
        /// <returns>ImageCloneRegionsResponse</returns>
        ImageCloneRegionsResponse ImageCloneRegions(ImageCloneRegionsParameters imageCloneRegionsParameters);

        /// <summary>
        /// Closes a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageCloseParameters">An ImageCloseParameters object specifying the parameters of the action.</param>
        /// <returns>ImageCloseResponse</returns>
        ImageCloseResponse ImageClose(ImageCloseParameters imageCloseParameters);

        /// <summary>
        /// Converts the color depth of a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageConvertColorDepthParameters">An ImageConvertColorDepthParameters object specifying the parameters for the action.</param>
        /// <returns>ImageConvertColorDepthResponse</returns>
        ImageConvertColorDepthResponse ImageConvertColorDepth(ImageConvertColorDepthParameters imageConvertColorDepthParameters);

        /// <summary>
        /// Crops a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageCropParameters">An ImageCropParameters object specifying the parameters for the action.</param>
        /// <returns>ImageCropResponse</returns>
        ImageCropResponse ImageCrop(ImageCropParameters imageCropParameters);

        /// <summary>
        /// Deletes a page range from a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageDeletePageParameters">An ImageDeletePageParameters object specifying the parameters of the action.</param>
        /// <returns>ImageDeletePageResponse</returns>
        ImageDeletePageResponse ImageDeletePage(ImageDeletePageParameters imageDeletePageParameters);

        /// <summary>
        /// Detects the blank page(s) from a previously uploaded image and offers to remove them.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageDetectBlankPagesParameters">An ImageDetectBlankPagesParameters object specifying the parameters of the action.</param>
        /// <returns>ImageDetectBlankPagesResponse</returns>
        ImageDetectBlankPagesResponse ImageDetectBlankPages(ImageDetectBlankPagesParameters imageDetectBlankPagesParameters);

        /// <summary>
        /// Performs color detection  on a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageDetectColorParameters">An ImageDetectColorParameters object specifying the parameters for the action.</param>
        /// <returns>ImageDetectColorResponse</returns>
        ImageDetectColorResponse ImageDetectColor(ImageDetectColorParameters imageDetectColorParameters);

        /// <summary>
        /// Detects the orientation of the page(s) of a previously uploaded image and offers to automatically rotate them.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageDetectPageOrientationParameters">An ImagedetectPageOrientationParameters object specifying the parameters of the action.</param>
        /// <returns>ImageDetectPageOrientationResponse</returns>
        ImageDetectPageOrientationResponse ImageDetectPageOrientation(ImageDetectPageOrientationParameters imageDetectPageOrientationParameters);

        /// <summary>
        /// Applies filters to a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageFilterParameters">An ImageFilterParameters object specifying the parameters for the action.</param>
        /// <returns>ImageFilterResponse</returns>
        ImageFilterResponse ImageFilter(ImageFilterParameters imageFilterParameters);

        /// <summary>
        /// Gets a thumbnail of each page within the provided page range from a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageGetPageThumbnailParameters">A PDFGetPageThumbnailParameters object specifying the parameters of the action.</param>
        /// <returns>ImageGetPageThumbnailResponse</returns>
        ImageGetPageThumbnailResponse ImageGetPageThumbnail(ImageGetPageThumbnailParameters imageGetPageThumbnailParameters);

        /// <summary>
        /// Gets the supported file extensions by the image loading actions.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>StringArrayResponse</returns>
        StringArrayResponse ImageGetSupportedFileExtensions();

        /// <summary>
        /// Loads the provided image file.  Supported image formats can be retrieved by the GetSupportedImageFileExtensions action.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loadImageFromByteArrayParameters">A LoadImageFromByteArrayParameters object specifying the parameters of the action.</param>
        /// <returns>ImageLoadResponse</returns>
        ImageLoadResponse ImageLoad(LoadImageFromByteArrayParameters loadImageFromByteArrayParameters);

        /// <summary>
        /// Loads the provided image file using Multipart Upload.  Supported image formats can be retrieved by the GetSupportedImageFileExtensions action.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileData">The data of the document.</param>
        /// <param name="loadImageParameters"> (optional)</param>
        /// <returns>ImageLoadResponse</returns>
        ImageLoadResponse ImageLoadMultipart(System.IO.Stream fileData, LoadImageParameters loadImageParameters = null);

        /// <summary>
        /// Performs MICR (Magnetic Ink Character Recognition) on a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageMICRParameters">An ImageMICRParameters object specifying the parameters of the action.</param>
        /// <returns>ImageMICRResponse</returns>
        ImageMICRResponse ImageMICR(ImageMICRParameters imageMICRParameters);

        /// <summary>
        /// Reads barcodes from a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageReadBarcodesParameters">An ImageReadBarcodesParameters object specifying the parameters of the action.</param>
        /// <returns>ReadBarcodesResponse</returns>
        ReadBarcodesResponse ImageReadBarcodes(ImageReadBarcodesParameters imageReadBarcodesParameters);

        /// <summary>
        /// Resizes a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageResizeParameters">An ImageResizeParameters object specifying the parameters for the action.</param>
        /// <returns>ImageResizeResponse</returns>
        ImageResizeResponse ImageResize(ImageResizeParameters imageResizeParameters);

        /// <summary>
        /// Rotates and/or flips a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageRotateParameters">An ImageRotateParameters object specifying the parameters for the action.</param>
        /// <returns>ImageRotateResponse</returns>
        ImageRotateResponse ImageRotate(ImageRotateParameters imageRotateParameters);

        /// <summary>
        /// Saves a previously uploaded image as JPEG, and sends the file data in a JSON-serialized object.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsJPEGParameters">An ImageSaveAsJPEGParameters object specifying the parameters of the action.</param>
        /// <returns>ImageSaveAsJPEGResponse</returns>
        ImageSaveAsJPEGResponse ImageSaveAsJPEG(ImageSaveAsJPEGParameters imageSaveAsJPEGParameters);

        /// <summary>
        /// Saves a previously uploaded image as JPEG, and streams the file binary data to the response (this is the most efficient download method).
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsJPEGParameters">An ImageSaveAsJPEGParameters object specifying the parameters of the action.</param>
        void ImageSaveAsJPEGFile(ImageSaveAsJPEGParameters imageSaveAsJPEGParameters, System.IO.Stream destinationStream);

        /// <summary>
        /// Saves a previously uploaded image as PDF, and sends the file data in a JSON-serialized object.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsPDFParameters">An ImagesaveAsPDFParameters object specifying the parameters of the action.</param>
        /// <returns>ImageSaveAsPDFResponse</returns>
        ImageSaveAsPDFResponse ImageSaveAsPDF(ImageSaveAsPDFParameters imageSaveAsPDFParameters);

        /// <summary>
        /// Saves a previously uploaded image as PDF, and streams the file binary data to the response (this is the most efficient download method).
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsPDFParameters">An ImagesaveAsPDFParameters object specifying the parameters of the action.</param>
        void ImageSaveAsPDFFile(ImageSaveAsPDFParameters imageSaveAsPDFParameters, System.IO.Stream destinationStream);

        /// <summary>
        /// Saves a previously uploaded image as PDF using MRC compression, and sends the file data in a JSON-serialized object.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsPDFMRCParameters">An ImagesaveAsPDFMRCParameters object specifying the parameters of the action.</param>
        /// <returns>ImageSaveAsPDFMRCResponse</returns>
        ImageSaveAsPDFMRCResponse ImageSaveAsPDFMRC(ImageSaveAsPDFMRCParameters imageSaveAsPDFMRCParameters);

        /// <summary>
        /// Saves a previously uploaded image as PDF using MRC compression, and streams the file binary data to the response (this is the most efficient download method).
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsPDFMRCParameters">An ImagesaveAsPDFMRCParameters object specifying the parameters of the action.</param>
        void ImageSaveAsPDFMRCFile(ImageSaveAsPDFMRCParameters imageSaveAsPDFMRCParameters, System.IO.Stream destinationStream);

        /// <summary>
        /// Saves a previously uploaded image as PNG, and sends the file data in a JSON-serialized object.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsPNGParameters">An ImageSaveAsPNGParameters object specifying the parameters of the action.</param>
        /// <returns>ImageSaveAsPNGResponse</returns>
        ImageSaveAsPNGResponse ImageSaveAsPNG(ImageSaveAsPNGParameters imageSaveAsPNGParameters);

        /// <summary>
        /// Saves a previously uploaded image as PNG, and streams the file binary data to the response (this is the most efficient download method).
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsPNGParameters">An ImageSaveAsPNGParameters object specifying the parameters of the action.</param>
        void ImageSaveAsPNGFile(ImageSaveAsPNGParameters imageSaveAsPNGParameters, System.IO.Stream destinationStream);

        /// <summary>
        /// Saves a previously uploaded image as TIFF, and sends the file data in a JSON-serialized object.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsTIFFParameters">An ImageSaveAsTIFFParameters object specifying the parameters of the action.</param>
        /// <returns>ImageSaveAsTIFFResponse</returns>
        ImageSaveAsTIFFResponse ImageSaveAsTIFF(ImageSaveAsTIFFParameters imageSaveAsTIFFParameters);

        /// <summary>
        /// Saves a previously uploaded image as TIFF, and streams the file binary data to the response (this is the most efficient download method).
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsTIFFParameters">An ImageSaveAsTIFFParameters object specifying the parameters of the action.</param>
        void ImageSaveAsTIFFFile(ImageSaveAsTIFFParameters imageSaveAsTIFFParameters, System.IO.Stream destinationStream);

        /// <summary>
        /// Saves a previously uploaded image as multipage TIFF, and sends the file data in a JSON-serialized object.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsTIFFMultipageParameters">An ImageSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        /// <returns>ImageSaveAsTIFFMultipageResponse</returns>
        ImageSaveAsTIFFMultipageResponse ImageSaveAsTIFFMultipage(ImageSaveAsTIFFMultipageParameters imageSaveAsTIFFMultipageParameters);

        /// <summary>
        /// Saves a previously uploaded image as multipage TIFF, and streams the file binary data to the response (this is the most efficient download method).
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsTIFFMultipageParameters">An ImageSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        void ImageSaveAsTIFFMultipageFile(ImageSaveAsTIFFMultipageParameters imageSaveAsTIFFMultipageParameters, System.IO.Stream destinationStream);

        /// <summary>
        /// Swaps two pages from a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSwapPagesParameters">An ImageSwapPagesParameters object specifying the parameters of the action.</param>
        /// <returns>ImageSwapPagesResponse</returns>
        ImageSwapPagesResponse ImageSwapPages(ImageSwapPagesParameters imageSwapPagesParameters);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IImageApiAsync
    {

        /// <summary>
        /// Adjusts a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageAdjustParameters">An ImageAdjustParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ImageAdjustResponse</returns>
        Task<ImageAdjustResponse> ImageAdjustAsync(ImageAdjustParameters imageAdjustParameters);

        /// <summary>
        /// Automatically crops a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageAutoCropParameters">An ImageAutoCropParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ImageAutoCropResponse</returns>
        Task<ImageAutoCropResponse> ImageAutoCropAsync(ImageAutoCropParameters imageAutoCropParameters);

        /// <summary>
        /// Cleanup a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageCleanupDocumentParameters">An ImageCleanupDocumentParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ImageCleanupDocumentResponse</returns>
        Task<ImageCleanupDocumentResponse> ImageCleanupDocumentAsync(ImageCleanupDocumentParameters imageCleanupDocumentParameters);

        /// <summary>
        /// Clones regions from a previously uploaded image into new images.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageCloneRegionsParameters">An ImageCloneRegionsParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageCloneRegionsResponse</returns>
        Task<ImageCloneRegionsResponse> ImageCloneRegionsAsync(ImageCloneRegionsParameters imageCloneRegionsParameters);

        /// <summary>
        /// Closes a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageCloseParameters">An ImageCloseParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageCloseResponse</returns>
        Task<ImageCloseResponse> ImageCloseAsync(ImageCloseParameters imageCloseParameters);

        /// <summary>
        /// Converts the color depth of a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageConvertColorDepthParameters">An ImageConvertColorDepthParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ImageConvertColorDepthResponse</returns>
        Task<ImageConvertColorDepthResponse> ImageConvertColorDepthAsync(ImageConvertColorDepthParameters imageConvertColorDepthParameters);

        /// <summary>
        /// Crops a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageCropParameters">An ImageCropParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ImageCropResponse</returns>
        Task<ImageCropResponse> ImageCropAsync(ImageCropParameters imageCropParameters);

        /// <summary>
        /// Deletes a page range from a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageDeletePageParameters">An ImageDeletePageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageDeletePageResponse</returns>
        Task<ImageDeletePageResponse> ImageDeletePageAsync(ImageDeletePageParameters imageDeletePageParameters);

        /// <summary>
        /// Detects the blank page(s) from a previously uploaded image and offers to remove them.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageDetectBlankPagesParameters">An ImageDetectBlankPagesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageDetectBlankPagesResponse</returns>
        Task<ImageDetectBlankPagesResponse> ImageDetectBlankPagesAsync(ImageDetectBlankPagesParameters imageDetectBlankPagesParameters);

        /// <summary>
        /// Performs color detection  on a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageDetectColorParameters">An ImageDetectColorParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ImageDetectColorResponse</returns>
        Task<ImageDetectColorResponse> ImageDetectColorAsync(ImageDetectColorParameters imageDetectColorParameters);

        /// <summary>
        /// Detects the orientation of the page(s) of a previously uploaded image and offers to automatically rotate them.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageDetectPageOrientationParameters">An ImagedetectPageOrientationParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageDetectPageOrientationResponse</returns>
        Task<ImageDetectPageOrientationResponse> ImageDetectPageOrientationAsync(ImageDetectPageOrientationParameters imageDetectPageOrientationParameters);

        /// <summary>
        /// Applies filters to a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageFilterParameters">An ImageFilterParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ImageFilterResponse</returns>
        Task<ImageFilterResponse> ImageFilterAsync(ImageFilterParameters imageFilterParameters);

        /// <summary>
        /// Gets a thumbnail of each page within the provided page range from a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageGetPageThumbnailParameters">A PDFGetPageThumbnailParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageGetPageThumbnailResponse</returns>
        Task<ImageGetPageThumbnailResponse> ImageGetPageThumbnailAsync(ImageGetPageThumbnailParameters imageGetPageThumbnailParameters);

        /// <summary>
        /// Gets the supported file extensions by the image loading actions.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of StringArrayResponse</returns>
        Task<StringArrayResponse> ImageGetSupportedFileExtensionsAsync();

        /// <summary>
        /// Loads the provided image file.  Supported image formats can be retrieved by the GetSupportedImageFileExtensions action.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loadImageFromByteArrayParameters">A LoadImageFromByteArrayParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageLoadResponse</returns>
        Task<ImageLoadResponse> ImageLoadAsync(LoadImageFromByteArrayParameters loadImageFromByteArrayParameters);

        /// <summary>
        /// Loads the provided image file using Multipart Upload.  Supported image formats can be retrieved by the GetSupportedImageFileExtensions action.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileData">The data of the document.</param>
        /// <param name="loadImageParameters"> (optional)</param>
        /// <returns>Task of ImageLoadResponse</returns>
        Task<ImageLoadResponse> ImageLoadMultipartAsync(System.IO.Stream fileData, LoadImageParameters loadImageParameters = null);

        /// <summary>
        /// Performs MICR (Magnetic Ink Character Recognition) on a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageMICRParameters">An ImageMICRParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageMICRResponse</returns>
        Task<ImageMICRResponse> ImageMICRAsync(ImageMICRParameters imageMICRParameters);

        /// <summary>
        /// Reads barcodes from a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageReadBarcodesParameters">An ImageReadBarcodesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ReadBarcodesResponse</returns>
        Task<ReadBarcodesResponse> ImageReadBarcodesAsync(ImageReadBarcodesParameters imageReadBarcodesParameters);

        /// <summary>
        /// Resizes a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageResizeParameters">An ImageResizeParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ImageResizeResponse</returns>
        Task<ImageResizeResponse> ImageResizeAsync(ImageResizeParameters imageResizeParameters);

        /// <summary>
        /// Rotates and/or flips a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageRotateParameters">An ImageRotateParameters object specifying the parameters for the action.</param>
        /// <returns>Task of ImageRotateResponse</returns>
        Task<ImageRotateResponse> ImageRotateAsync(ImageRotateParameters imageRotateParameters);

        /// <summary>
        /// Saves a previously uploaded image as JPEG, and sends the file data in a JSON-serialized object.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsJPEGParameters">An ImageSaveAsJPEGParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageSaveAsJPEGResponse</returns>
        Task<ImageSaveAsJPEGResponse> ImageSaveAsJPEGAsync(ImageSaveAsJPEGParameters imageSaveAsJPEGParameters);

        /// <summary>
        /// Saves a previously uploaded image as JPEG, and streams the file binary data to the response (this is the most efficient download method).
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsJPEGParameters">An ImageSaveAsJPEGParameters object specifying the parameters of the action.</param>
        Task ImageSaveAsJPEGFileAsync(ImageSaveAsJPEGParameters imageSaveAsJPEGParameters, System.IO.Stream destinationStream);

        /// <summary>
        /// Saves a previously uploaded image as PDF, and sends the file data in a JSON-serialized object.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsPDFParameters">An ImagesaveAsPDFParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageSaveAsPDFResponse</returns>
        Task<ImageSaveAsPDFResponse> ImageSaveAsPDFAsync(ImageSaveAsPDFParameters imageSaveAsPDFParameters);

        /// <summary>
        /// Saves a previously uploaded image as PDF, and streams the file binary data to the response (this is the most efficient download method).
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsPDFParameters">An ImagesaveAsPDFParameters object specifying the parameters of the action.</param>
        Task ImageSaveAsPDFFileAsync(ImageSaveAsPDFParameters imageSaveAsPDFParameters, System.IO.Stream destinationStream);

        /// <summary>
        /// Saves a previously uploaded image as PDF using MRC compression, and sends the file data in a JSON-serialized object.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsPDFMRCParameters">An ImagesaveAsPDFMRCParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageSaveAsPDFMRCResponse</returns>
        Task<ImageSaveAsPDFMRCResponse> ImageSaveAsPDFMRCAsync(ImageSaveAsPDFMRCParameters imageSaveAsPDFMRCParameters);

        /// <summary>
        /// Saves a previously uploaded image as PDF using MRC compression, and streams the file binary data to the response (this is the most efficient download method).
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsPDFMRCParameters">An ImagesaveAsPDFMRCParameters object specifying the parameters of the action.</param>
        Task ImageSaveAsPDFMRCFileAsync(ImageSaveAsPDFMRCParameters imageSaveAsPDFMRCParameters, System.IO.Stream destinationStream);

        /// <summary>
        /// Saves a previously uploaded image as PNG, and sends the file data in a JSON-serialized object.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsPNGParameters">An ImageSaveAsPNGParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageSaveAsPNGResponse</returns>
        Task<ImageSaveAsPNGResponse> ImageSaveAsPNGAsync(ImageSaveAsPNGParameters imageSaveAsPNGParameters);

        /// <summary>
        /// Saves a previously uploaded image as PNG, and streams the file binary data to the response (this is the most efficient download method).
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsPNGParameters">An ImageSaveAsPNGParameters object specifying the parameters of the action.</param>
        Task ImageSaveAsPNGFileAsync(ImageSaveAsPNGParameters imageSaveAsPNGParameters, System.IO.Stream destinationStream);

        /// <summary>
        /// Saves a previously uploaded image as TIFF, and sends the file data in a JSON-serialized object.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsTIFFParameters">An ImageSaveAsTIFFParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageSaveAsTIFFResponse</returns>
        Task<ImageSaveAsTIFFResponse> ImageSaveAsTIFFAsync(ImageSaveAsTIFFParameters imageSaveAsTIFFParameters);

        /// <summary>
        /// Saves a previously uploaded image as TIFF, and streams the file binary data to the response (this is the most efficient download method).
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsTIFFParameters">An ImageSaveAsTIFFParameters object specifying the parameters of the action.</param>
        Task ImageSaveAsTIFFFileAsync(ImageSaveAsTIFFParameters imageSaveAsTIFFParameters, System.IO.Stream destinationStream);

        /// <summary>
        /// Saves a previously uploaded image as multipage TIFF, and sends the file data in a JSON-serialized object.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsTIFFMultipageParameters">An ImageSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageSaveAsTIFFMultipageResponse</returns>
        Task<ImageSaveAsTIFFMultipageResponse> ImageSaveAsTIFFMultipageAsync(ImageSaveAsTIFFMultipageParameters imageSaveAsTIFFMultipageParameters);

        /// <summary>
        /// Saves a previously uploaded image as multipage TIFF, and streams the file binary data to the response (this is the most efficient download method).
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsTIFFMultipageParameters">An ImageSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        Task ImageSaveAsTIFFMultipageFileAsync(ImageSaveAsTIFFMultipageParameters imageSaveAsTIFFMultipageParameters, System.IO.Stream destinationStream);

        /// <summary>
        /// Swaps two pages from a previously uploaded image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSwapPagesParameters">An ImageSwapPagesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ImageSwapPagesResponse</returns>
        Task<ImageSwapPagesResponse> ImageSwapPagesAsync(ImageSwapPagesParameters imageSwapPagesParameters);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IImageApi : IImageApiSync, IImageApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed class ImageApi : IImageApi
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
        /// Initializes a new instance of the <see cref="ImageApi"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        public ImageApi(string apiKey = "")
        {
            ApiKey = apiKey;
        }

        /// <summary>
        /// Adjusts a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageAdjustParameters">An ImageAdjustParameters object specifying the parameters for the action.</param>
        /// <returns>IRestResponse of ImageAdjustResponse</returns>
        public ImageAdjustResponse ImageAdjust(ImageAdjustParameters imageAdjustParameters)
        {
            // verify the required parameter 'imageAdjustParameters' is set
            if (imageAdjustParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageAdjustParameters' when calling ImageApi->ImageAdjust");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageAdjustParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/image/ImageAdjust",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageAdjust failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageAdjustResponse)ApiClient.DeserializeResponse(response, typeof(ImageAdjustResponse));
        }

        /// <summary>
        /// Adjusts a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageAdjustParameters">An ImageAdjustParameters object specifying the parameters for the action.</param>
        /// <returns>Task of IRestResponse (ImageAdjustResponse)</returns>
        public async Task<ImageAdjustResponse> ImageAdjustAsync(ImageAdjustParameters imageAdjustParameters)
        {
            // verify the required parameter 'imageAdjustParameters' is set
            if (imageAdjustParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageAdjustParameters' when calling ImageApi->ImageAdjust");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = imageAdjustParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageAdjust",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageAdjust failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageAdjustResponse)ApiClient.DeserializeResponse(response, typeof(ImageAdjustResponse));
        }

        /// <summary>
        /// Automatically crops a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageAutoCropParameters">An ImageAutoCropParameters object specifying the parameters for the action.</param>
        /// <returns>IRestResponse of ImageAutoCropResponse</returns>
        public ImageAutoCropResponse ImageAutoCrop(ImageAutoCropParameters imageAutoCropParameters)
        {
            // verify the required parameter 'imageAutoCropParameters' is set
            if (imageAutoCropParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageAutoCropParameters' when calling ImageApi->ImageAutoCrop");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageAutoCropParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/image/ImageAutoCrop",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageAutoCrop failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageAutoCropResponse)ApiClient.DeserializeResponse(response, typeof(ImageAutoCropResponse));
        }

        /// <summary>
        /// Automatically crops a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageAutoCropParameters">An ImageAutoCropParameters object specifying the parameters for the action.</param>
        /// <returns>Task of IRestResponse (ImageAutoCropResponse)</returns>
        public async Task<ImageAutoCropResponse> ImageAutoCropAsync(ImageAutoCropParameters imageAutoCropParameters)
        {
            // verify the required parameter 'imageAutoCropParameters' is set
            if (imageAutoCropParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageAutoCropParameters' when calling ImageApi->ImageAutoCrop");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = imageAutoCropParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageAutoCrop",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageAutoCrop failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageAutoCropResponse)ApiClient.DeserializeResponse(response, typeof(ImageAutoCropResponse));
        }

        /// <summary>
        /// Cleanup a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageCleanupDocumentParameters">An ImageCleanupDocumentParameters object specifying the parameters for the action.</param>
        /// <returns>IRestResponse of ImageCleanupDocumentResponse</returns>
        public ImageCleanupDocumentResponse ImageCleanupDocument(ImageCleanupDocumentParameters imageCleanupDocumentParameters)
        {
            // verify the required parameter 'imageCleanupDocumentParameters' is set
            if (imageCleanupDocumentParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageCleanupDocumentParameters' when calling ImageApi->ImageCleanupDocument");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageCleanupDocumentParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/image/ImageCleanupDocument",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageCleanupDocument failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageCleanupDocumentResponse)ApiClient.DeserializeResponse(response, typeof(ImageCleanupDocumentResponse));
        }

        /// <summary>
        /// Cleanup a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageCleanupDocumentParameters">An ImageCleanupDocumentParameters object specifying the parameters for the action.</param>
        /// <returns>Task of IRestResponse (ImageCleanupDocumentResponse)</returns>
        public async Task<ImageCleanupDocumentResponse> ImageCleanupDocumentAsync(ImageCleanupDocumentParameters imageCleanupDocumentParameters)
        {
            // verify the required parameter 'imageCleanupDocumentParameters' is set
            if (imageCleanupDocumentParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageCleanupDocumentParameters' when calling ImageApi->ImageCleanupDocument");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = imageCleanupDocumentParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageCleanupDocument",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageCleanupDocument failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageCleanupDocumentResponse)ApiClient.DeserializeResponse(response, typeof(ImageCleanupDocumentResponse));
        }

        /// <summary>
        /// Clones regions from a previously uploaded image into new images. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageCloneRegionsParameters">An ImageCloneRegionsParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of ImageCloneRegionsResponse</returns>
        public ImageCloneRegionsResponse ImageCloneRegions(ImageCloneRegionsParameters imageCloneRegionsParameters)
        {
            // verify the required parameter 'imageCloneRegionsParameters' is set
            if (imageCloneRegionsParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageCloneRegionsParameters' when calling ImageApi->ImageCloneRegions");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageCloneRegionsParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/image/ImageCloneRegions",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageCloneRegions failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageCloneRegionsResponse)ApiClient.DeserializeResponse(response, typeof(ImageCloneRegionsResponse));
        }

        /// <summary>
        /// Clones regions from a previously uploaded image into new images. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageCloneRegionsParameters">An ImageCloneRegionsParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (ImageCloneRegionsResponse)</returns>
        public async Task<ImageCloneRegionsResponse> ImageCloneRegionsAsync(ImageCloneRegionsParameters imageCloneRegionsParameters)
        {
            // verify the required parameter 'imageCloneRegionsParameters' is set
            if (imageCloneRegionsParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageCloneRegionsParameters' when calling ImageApi->ImageCloneRegions");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = imageCloneRegionsParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageCloneRegions",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageCloneRegions failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageCloneRegionsResponse)ApiClient.DeserializeResponse(response, typeof(ImageCloneRegionsResponse));
        }

        /// <summary>
        /// Closes a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageCloseParameters">An ImageCloseParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of ImageCloseResponse</returns>
        public ImageCloseResponse ImageClose(ImageCloseParameters imageCloseParameters)
        {
            // verify the required parameter 'imageCloseParameters' is set
            if (imageCloseParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageCloseParameters' when calling ImageApi->ImageClose");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageCloseParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/image/ImageClose",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageClose failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageCloseResponse)ApiClient.DeserializeResponse(response, typeof(ImageCloseResponse));
        }

        /// <summary>
        /// Closes a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageCloseParameters">An ImageCloseParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (ImageCloseResponse)</returns>
        public async Task<ImageCloseResponse> ImageCloseAsync(ImageCloseParameters imageCloseParameters)
        {
            // verify the required parameter 'imageCloseParameters' is set
            if (imageCloseParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageCloseParameters' when calling ImageApi->ImageClose");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = imageCloseParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageClose",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageClose failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageCloseResponse)ApiClient.DeserializeResponse(response, typeof(ImageCloseResponse));
        }

        /// <summary>
        /// Converts the color depth of a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageConvertColorDepthParameters">An ImageConvertColorDepthParameters object specifying the parameters for the action.</param>
        /// <returns>IRestResponse of ImageConvertColorDepthResponse</returns>
        public ImageConvertColorDepthResponse ImageConvertColorDepth(ImageConvertColorDepthParameters imageConvertColorDepthParameters)
        {
            // verify the required parameter 'imageConvertColorDepthParameters' is set
            if (imageConvertColorDepthParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageConvertColorDepthParameters' when calling ImageApi->ImageConvertColorDepth");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageConvertColorDepthParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/image/ImageConvertColorDepth",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageConvertColorDepth failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageConvertColorDepthResponse)ApiClient.DeserializeResponse(response, typeof(ImageConvertColorDepthResponse));
        }

        /// <summary>
        /// Converts the color depth of a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageConvertColorDepthParameters">An ImageConvertColorDepthParameters object specifying the parameters for the action.</param>
        /// <returns>Task of IRestResponse (ImageConvertColorDepthResponse)</returns>
        public async Task<ImageConvertColorDepthResponse> ImageConvertColorDepthAsync(ImageConvertColorDepthParameters imageConvertColorDepthParameters)
        {
            // verify the required parameter 'imageConvertColorDepthParameters' is set
            if (imageConvertColorDepthParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageConvertColorDepthParameters' when calling ImageApi->ImageConvertColorDepth");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = imageConvertColorDepthParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageConvertColorDepth",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageConvertColorDepth failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageConvertColorDepthResponse)ApiClient.DeserializeResponse(response, typeof(ImageConvertColorDepthResponse));
        }

        /// <summary>
        /// Crops a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageCropParameters">An ImageCropParameters object specifying the parameters for the action.</param>
        /// <returns>IRestResponse of ImageCropResponse</returns>
        public ImageCropResponse ImageCrop(ImageCropParameters imageCropParameters)
        {
            // verify the required parameter 'imageCropParameters' is set
            if (imageCropParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageCropParameters' when calling ImageApi->ImageCrop");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageCropParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/image/ImageCrop",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageCrop failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageCropResponse)ApiClient.DeserializeResponse(response, typeof(ImageCropResponse));
        }

        /// <summary>
        /// Crops a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageCropParameters">An ImageCropParameters object specifying the parameters for the action.</param>
        /// <returns>Task of IRestResponse (ImageCropResponse)</returns>
        public async Task<ImageCropResponse> ImageCropAsync(ImageCropParameters imageCropParameters)
        {
            // verify the required parameter 'imageCropParameters' is set
            if (imageCropParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageCropParameters' when calling ImageApi->ImageCrop");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = imageCropParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageCrop",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageCrop failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageCropResponse)ApiClient.DeserializeResponse(response, typeof(ImageCropResponse));
        }

        /// <summary>
        /// Deletes a page range from a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageDeletePageParameters">An ImageDeletePageParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of ImageDeletePageResponse</returns>
        public ImageDeletePageResponse ImageDeletePage(ImageDeletePageParameters imageDeletePageParameters)
        {
            // verify the required parameter 'imageDeletePageParameters' is set
            if (imageDeletePageParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageDeletePageParameters' when calling ImageApi->ImageDeletePage");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageDeletePageParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/image/ImageDeletePage",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageDeletePage failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageDeletePageResponse)ApiClient.DeserializeResponse(response, typeof(ImageDeletePageResponse));
        }

        /// <summary>
        /// Deletes a page range from a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageDeletePageParameters">An ImageDeletePageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (ImageDeletePageResponse)</returns>
        public async Task<ImageDeletePageResponse> ImageDeletePageAsync(ImageDeletePageParameters imageDeletePageParameters)
        {
            // verify the required parameter 'imageDeletePageParameters' is set
            if (imageDeletePageParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageDeletePageParameters' when calling ImageApi->ImageDeletePage");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = imageDeletePageParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageDeletePage",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageDeletePage failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageDeletePageResponse)ApiClient.DeserializeResponse(response, typeof(ImageDeletePageResponse));
        }

        /// <summary>
        /// Detects the blank page(s) from a previously uploaded image and offers to remove them. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageDetectBlankPagesParameters">An ImageDetectBlankPagesParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of ImageDetectBlankPagesResponse</returns>
        public ImageDetectBlankPagesResponse ImageDetectBlankPages(ImageDetectBlankPagesParameters imageDetectBlankPagesParameters)
        {
            // verify the required parameter 'imageDetectBlankPagesParameters' is set
            if (imageDetectBlankPagesParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageDetectBlankPagesParameters' when calling ImageApi->ImageDetectBlankPages");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageDetectBlankPagesParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/image/ImageDetectBlankPages",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageDetectBlankPages failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageDetectBlankPagesResponse)ApiClient.DeserializeResponse(response, typeof(ImageDetectBlankPagesResponse));
        }

        /// <summary>
        /// Detects the blank page(s) from a previously uploaded image and offers to remove them. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageDetectBlankPagesParameters">An ImageDetectBlankPagesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (ImageDetectBlankPagesResponse)</returns>
        public async Task<ImageDetectBlankPagesResponse> ImageDetectBlankPagesAsync(ImageDetectBlankPagesParameters imageDetectBlankPagesParameters)
        {
            // verify the required parameter 'imageDetectBlankPagesParameters' is set
            if (imageDetectBlankPagesParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageDetectBlankPagesParameters' when calling ImageApi->ImageDetectBlankPages");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = imageDetectBlankPagesParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageDetectBlankPages",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageDetectBlankPages failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageDetectBlankPagesResponse)ApiClient.DeserializeResponse(response, typeof(ImageDetectBlankPagesResponse));
        }

        /// <summary>
        /// Performs color detection  on a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageDetectColorParameters">An ImageDetectColorParameters object specifying the parameters for the action.</param>
        /// <returns>IRestResponse of ImageDetectColorResponse</returns>
        public ImageDetectColorResponse ImageDetectColor(ImageDetectColorParameters imageDetectColorParameters)
        {
            // verify the required parameter 'imageDetectColorParameters' is set
            if (imageDetectColorParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageDetectColorParameters' when calling ImageApi->ImageDetectColor");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageDetectColorParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/image/ImageDetectColor",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageDetectColor failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageDetectColorResponse)ApiClient.DeserializeResponse(response, typeof(ImageDetectColorResponse));
        }

        /// <summary>
        /// Performs color detection  on a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageDetectColorParameters">An ImageDetectColorParameters object specifying the parameters for the action.</param>
        /// <returns>Task of IRestResponse (ImageDetectColorResponse)</returns>
        public async Task<ImageDetectColorResponse> ImageDetectColorAsync(ImageDetectColorParameters imageDetectColorParameters)
        {
            // verify the required parameter 'imageDetectColorParameters' is set
            if (imageDetectColorParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageDetectColorParameters' when calling ImageApi->ImageDetectColor");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = imageDetectColorParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageDetectColor",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageDetectColor failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageDetectColorResponse)ApiClient.DeserializeResponse(response, typeof(ImageDetectColorResponse));
        }

        /// <summary>
        /// Detects the orientation of the page(s) of a previously uploaded image and offers to automatically rotate them. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageDetectPageOrientationParameters">An ImagedetectPageOrientationParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of ImageDetectPageOrientationResponse</returns>
        public ImageDetectPageOrientationResponse ImageDetectPageOrientation(ImageDetectPageOrientationParameters imageDetectPageOrientationParameters)
        {
            // verify the required parameter 'imageDetectPageOrientationParameters' is set
            if (imageDetectPageOrientationParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageDetectPageOrientationParameters' when calling ImageApi->ImageDetectPageOrientation");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageDetectPageOrientationParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/image/ImageDetectPageOrientation",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageDetectPageOrientation failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageDetectPageOrientationResponse)ApiClient.DeserializeResponse(response, typeof(ImageDetectPageOrientationResponse));
        }

        /// <summary>
        /// Detects the orientation of the page(s) of a previously uploaded image and offers to automatically rotate them. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageDetectPageOrientationParameters">An ImagedetectPageOrientationParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (ImageDetectPageOrientationResponse)</returns>
        public async Task<ImageDetectPageOrientationResponse> ImageDetectPageOrientationAsync(ImageDetectPageOrientationParameters imageDetectPageOrientationParameters)
        {
            // verify the required parameter 'imageDetectPageOrientationParameters' is set
            if (imageDetectPageOrientationParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageDetectPageOrientationParameters' when calling ImageApi->ImageDetectPageOrientation");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = imageDetectPageOrientationParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageDetectPageOrientation",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageDetectPageOrientation failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageDetectPageOrientationResponse)ApiClient.DeserializeResponse(response, typeof(ImageDetectPageOrientationResponse));
        }

        /// <summary>
        /// Applies filters to a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageFilterParameters">An ImageFilterParameters object specifying the parameters for the action.</param>
        /// <returns>IRestResponse of ImageFilterResponse</returns>
        public ImageFilterResponse ImageFilter(ImageFilterParameters imageFilterParameters)
        {
            // verify the required parameter 'imageFilterParameters' is set
            if (imageFilterParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageFilterParameters' when calling ImageApi->ImageFilter");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageFilterParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/image/ImageFilter",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageFilter failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageFilterResponse)ApiClient.DeserializeResponse(response, typeof(ImageFilterResponse));
        }

        /// <summary>
        /// Applies filters to a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageFilterParameters">An ImageFilterParameters object specifying the parameters for the action.</param>
        /// <returns>Task of IRestResponse (ImageFilterResponse)</returns>
        public async Task<ImageFilterResponse> ImageFilterAsync(ImageFilterParameters imageFilterParameters)
        {
            // verify the required parameter 'imageFilterParameters' is set
            if (imageFilterParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageFilterParameters' when calling ImageApi->ImageFilter");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = imageFilterParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageFilter",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageFilter failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageFilterResponse)ApiClient.DeserializeResponse(response, typeof(ImageFilterResponse));
        }

        /// <summary>
        /// Gets a thumbnail of each page within the provided page range from a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageGetPageThumbnailParameters">A PDFGetPageThumbnailParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of ImageGetPageThumbnailResponse</returns>
        public ImageGetPageThumbnailResponse ImageGetPageThumbnail(ImageGetPageThumbnailParameters imageGetPageThumbnailParameters)
        {
            // verify the required parameter 'imageGetPageThumbnailParameters' is set
            if (imageGetPageThumbnailParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageGetPageThumbnailParameters' when calling ImageApi->ImageGetPageThumbnail");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageGetPageThumbnailParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/image/ImageGetPageThumbnail",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageGetPageThumbnail failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageGetPageThumbnailResponse)ApiClient.DeserializeResponse(response, typeof(ImageGetPageThumbnailResponse));
        }

        /// <summary>
        /// Gets a thumbnail of each page within the provided page range from a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageGetPageThumbnailParameters">A PDFGetPageThumbnailParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (ImageGetPageThumbnailResponse)</returns>
        public async Task<ImageGetPageThumbnailResponse> ImageGetPageThumbnailAsync(ImageGetPageThumbnailParameters imageGetPageThumbnailParameters)
        {
            // verify the required parameter 'imageGetPageThumbnailParameters' is set
            if (imageGetPageThumbnailParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageGetPageThumbnailParameters' when calling ImageApi->ImageGetPageThumbnail");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = imageGetPageThumbnailParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageGetPageThumbnail",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageGetPageThumbnail failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageGetPageThumbnailResponse)ApiClient.DeserializeResponse(response, typeof(ImageGetPageThumbnailResponse));
        }

        /// <summary>
        /// Gets the supported file extensions by the image loading actions. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>IRestResponse of StringArrayResponse</returns>
        public StringArrayResponse ImageGetSupportedFileExtensions()
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
             "/api/image/ImageGetSupportedFileExtensions",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageGetSupportedFileExtensions failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (StringArrayResponse)ApiClient.DeserializeResponse(response, typeof(StringArrayResponse));
        }

        /// <summary>
        /// Gets the supported file extensions by the image loading actions. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of IRestResponse (StringArrayResponse)</returns>
        public async Task<StringArrayResponse> ImageGetSupportedFileExtensionsAsync()
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
            "/api/image/ImageGetSupportedFileExtensions",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageGetSupportedFileExtensions failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (StringArrayResponse)ApiClient.DeserializeResponse(response, typeof(StringArrayResponse));
        }

        /// <summary>
        /// Loads the provided image file.  Supported image formats can be retrieved by the GetSupportedImageFileExtensions action. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loadImageFromByteArrayParameters">A LoadImageFromByteArrayParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of ImageLoadResponse</returns>
        public ImageLoadResponse ImageLoad(LoadImageFromByteArrayParameters loadImageFromByteArrayParameters)
        {
            // verify the required parameter 'loadImageFromByteArrayParameters' is set
            if (loadImageFromByteArrayParameters == null)
                throw new ArgumentNullException("Missing required parameter 'loadImageFromByteArrayParameters' when calling ImageApi->ImageLoad");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = loadImageFromByteArrayParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/image/ImageLoad",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageLoad failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageLoadResponse)ApiClient.DeserializeResponse(response, typeof(ImageLoadResponse));
        }

        /// <summary>
        /// Loads the provided image file.  Supported image formats can be retrieved by the GetSupportedImageFileExtensions action. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loadImageFromByteArrayParameters">A LoadImageFromByteArrayParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (ImageLoadResponse)</returns>
        public async Task<ImageLoadResponse> ImageLoadAsync(LoadImageFromByteArrayParameters loadImageFromByteArrayParameters)
        {
            // verify the required parameter 'loadImageFromByteArrayParameters' is set
            if (loadImageFromByteArrayParameters == null)
                throw new ArgumentNullException("Missing required parameter 'loadImageFromByteArrayParameters' when calling ImageApi->ImageLoad");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = loadImageFromByteArrayParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageLoad",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageLoad failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageLoadResponse)ApiClient.DeserializeResponse(response, typeof(ImageLoadResponse));
        }

        /// <summary>
        /// Loads the provided image file using Multipart Upload.  Supported image formats can be retrieved by the GetSupportedImageFileExtensions action. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileData">The data of the document.</param>
        /// <param name="loadImageParameters"> (optional)</param>
        /// <returns>IRestResponse of ImageLoadResponse</returns>
        public ImageLoadResponse ImageLoadMultipart(System.IO.Stream fileData, LoadImageParameters loadImageParameters = null)
        {
            // verify the required parameter 'fileData' is set
            if (fileData == null)
                throw new ArgumentNullException("Missing required parameter 'fileData' when calling ImageApi->ImageLoadMultipart");

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
            if (loadImageParameters != null)
            {
                requestOptions.FormParameters.Add("loadImageParameters", ClientUtils.ParameterToString(loadImageParameters)); // form parameter
            }
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/image/ImageLoadMultipart",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageLoadMultipart failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageLoadResponse)ApiClient.DeserializeResponse(response, typeof(ImageLoadResponse));
        }

        /// <summary>
        /// Loads the provided image file using Multipart Upload.  Supported image formats can be retrieved by the GetSupportedImageFileExtensions action. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileData">The data of the document.</param>
        /// <param name="loadImageParameters"> (optional)</param>
        /// <returns>Task of IRestResponse (ImageLoadResponse)</returns>
        public async Task<ImageLoadResponse> ImageLoadMultipartAsync(System.IO.Stream fileData, LoadImageParameters loadImageParameters = null)
        {
            // verify the required parameter 'fileData' is set
            if (fileData == null)
                throw new ArgumentNullException("Missing required parameter 'fileData' when calling ImageApi->ImageLoadMultipart");

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
            if (loadImageParameters != null)
            {
                requestOptions.FormParameters.Add("loadImageParameters", ClientUtils.ParameterToString(loadImageParameters)); // form parameter
            }

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageLoadMultipart",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageLoadMultipart failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageLoadResponse)ApiClient.DeserializeResponse(response, typeof(ImageLoadResponse));
        }

        /// <summary>
        /// Performs MICR (Magnetic Ink Character Recognition) on a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageMICRParameters">An ImageMICRParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of ImageMICRResponse</returns>
        public ImageMICRResponse ImageMICR(ImageMICRParameters imageMICRParameters)
        {
            // verify the required parameter 'imageMICRParameters' is set
            if (imageMICRParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageMICRParameters' when calling ImageApi->ImageMICR");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageMICRParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/image/ImageMICR",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageMICR failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageMICRResponse)ApiClient.DeserializeResponse(response, typeof(ImageMICRResponse));
        }

        /// <summary>
        /// Performs MICR (Magnetic Ink Character Recognition) on a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageMICRParameters">An ImageMICRParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (ImageMICRResponse)</returns>
        public async Task<ImageMICRResponse> ImageMICRAsync(ImageMICRParameters imageMICRParameters)
        {
            // verify the required parameter 'imageMICRParameters' is set
            if (imageMICRParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageMICRParameters' when calling ImageApi->ImageMICR");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = imageMICRParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageMICR",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageMICR failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageMICRResponse)ApiClient.DeserializeResponse(response, typeof(ImageMICRResponse));
        }

        /// <summary>
        /// Reads barcodes from a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageReadBarcodesParameters">An ImageReadBarcodesParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of ReadBarcodesResponse</returns>
        public ReadBarcodesResponse ImageReadBarcodes(ImageReadBarcodesParameters imageReadBarcodesParameters)
        {
            // verify the required parameter 'imageReadBarcodesParameters' is set
            if (imageReadBarcodesParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageReadBarcodesParameters' when calling ImageApi->ImageReadBarcodes");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageReadBarcodesParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/image/ImageReadBarcodes",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageReadBarcodes failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ReadBarcodesResponse)ApiClient.DeserializeResponse(response, typeof(ReadBarcodesResponse));
        }

        /// <summary>
        /// Reads barcodes from a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageReadBarcodesParameters">An ImageReadBarcodesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (ReadBarcodesResponse)</returns>
        public async Task<ReadBarcodesResponse> ImageReadBarcodesAsync(ImageReadBarcodesParameters imageReadBarcodesParameters)
        {
            // verify the required parameter 'imageReadBarcodesParameters' is set
            if (imageReadBarcodesParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageReadBarcodesParameters' when calling ImageApi->ImageReadBarcodes");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = imageReadBarcodesParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageReadBarcodes",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageReadBarcodes failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ReadBarcodesResponse)ApiClient.DeserializeResponse(response, typeof(ReadBarcodesResponse));
        }

        /// <summary>
        /// Resizes a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageResizeParameters">An ImageResizeParameters object specifying the parameters for the action.</param>
        /// <returns>IRestResponse of ImageResizeResponse</returns>
        public ImageResizeResponse ImageResize(ImageResizeParameters imageResizeParameters)
        {
            // verify the required parameter 'imageResizeParameters' is set
            if (imageResizeParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageResizeParameters' when calling ImageApi->ImageResize");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageResizeParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/image/ImageResize",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageResize failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageResizeResponse)ApiClient.DeserializeResponse(response, typeof(ImageResizeResponse));
        }

        /// <summary>
        /// Resizes a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageResizeParameters">An ImageResizeParameters object specifying the parameters for the action.</param>
        /// <returns>Task of IRestResponse (ImageResizeResponse)</returns>
        public async Task<ImageResizeResponse> ImageResizeAsync(ImageResizeParameters imageResizeParameters)
        {
            // verify the required parameter 'imageResizeParameters' is set
            if (imageResizeParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageResizeParameters' when calling ImageApi->ImageResize");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = imageResizeParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageResize",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageResize failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageResizeResponse)ApiClient.DeserializeResponse(response, typeof(ImageResizeResponse));
        }

        /// <summary>
        /// Rotates and/or flips a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageRotateParameters">An ImageRotateParameters object specifying the parameters for the action.</param>
        /// <returns>IRestResponse of ImageRotateResponse</returns>
        public ImageRotateResponse ImageRotate(ImageRotateParameters imageRotateParameters)
        {
            // verify the required parameter 'imageRotateParameters' is set
            if (imageRotateParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageRotateParameters' when calling ImageApi->ImageRotate");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageRotateParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/image/ImageRotate",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageRotate failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageRotateResponse)ApiClient.DeserializeResponse(response, typeof(ImageRotateResponse));
        }

        /// <summary>
        /// Rotates and/or flips a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageRotateParameters">An ImageRotateParameters object specifying the parameters for the action.</param>
        /// <returns>Task of IRestResponse (ImageRotateResponse)</returns>
        public async Task<ImageRotateResponse> ImageRotateAsync(ImageRotateParameters imageRotateParameters)
        {
            // verify the required parameter 'imageRotateParameters' is set
            if (imageRotateParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageRotateParameters' when calling ImageApi->ImageRotate");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = imageRotateParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageRotate",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageRotate failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageRotateResponse)ApiClient.DeserializeResponse(response, typeof(ImageRotateResponse));
        }

        /// <summary>
        /// Saves a previously uploaded image as JPEG, and sends the file data in a JSON-serialized object. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsJPEGParameters">An ImageSaveAsJPEGParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of ImageSaveAsJPEGResponse</returns>
        public ImageSaveAsJPEGResponse ImageSaveAsJPEG(ImageSaveAsJPEGParameters imageSaveAsJPEGParameters)
        {
            // verify the required parameter 'imageSaveAsJPEGParameters' is set
            if (imageSaveAsJPEGParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageSaveAsJPEGParameters' when calling ImageApi->ImageSaveAsJPEG");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageSaveAsJPEGParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/image/ImageSaveAsJPEG",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageSaveAsJPEG failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageSaveAsJPEGResponse)ApiClient.DeserializeResponse(response, typeof(ImageSaveAsJPEGResponse));
        }

        /// <summary>
        /// Saves a previously uploaded image as JPEG, and sends the file data in a JSON-serialized object. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsJPEGParameters">An ImageSaveAsJPEGParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (ImageSaveAsJPEGResponse)</returns>
        public async Task<ImageSaveAsJPEGResponse> ImageSaveAsJPEGAsync(ImageSaveAsJPEGParameters imageSaveAsJPEGParameters)
        {
            // verify the required parameter 'imageSaveAsJPEGParameters' is set
            if (imageSaveAsJPEGParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageSaveAsJPEGParameters' when calling ImageApi->ImageSaveAsJPEG");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = imageSaveAsJPEGParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageSaveAsJPEG",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageSaveAsJPEG failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageSaveAsJPEGResponse)ApiClient.DeserializeResponse(response, typeof(ImageSaveAsJPEGResponse));
        }

        /// <summary>
        /// Saves a previously uploaded image as JPEG, and streams the file binary data to the response (this is the most efficient download method). 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsJPEGParameters">An ImageSaveAsJPEGParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of System.IO.Stream</returns>
        public void ImageSaveAsJPEGFile(ImageSaveAsJPEGParameters imageSaveAsJPEGParameters, System.IO.Stream destinationStream)
        {
            // verify the required parameter 'imageSaveAsJPEGParameters' is set
            if (imageSaveAsJPEGParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageSaveAsJPEGParameters' when calling ImageApi->ImageSaveAsJPEGFile");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageSaveAsJPEGParameters;

            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
              "/api/image/ImageSaveAsJPEGFile",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageSaveAsJPEGFile failed: {0}", response.ErrorMessage, response.ErrorException));
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
        /// Saves a previously uploaded image as JPEG, and streams the file binary data to the response (this is the most efficient download method). 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsJPEGParameters">An ImageSaveAsJPEGParameters object specifying the parameters of the action.</param>
        public async Task ImageSaveAsJPEGFileAsync(ImageSaveAsJPEGParameters imageSaveAsJPEGParameters, System.IO.Stream destinationStream)
        {
            // verify the required parameter 'imageSaveAsJPEGParameters' is set
            if (imageSaveAsJPEGParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageSaveAsJPEGParameters' when calling ImageApi->ImageSaveAsJPEGFile");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);


            requestOptions.Data = imageSaveAsJPEGParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageSaveAsJPEGFile",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageSaveAsJPEGFile failed: {0}", response.ErrorMessage, response.ErrorException));
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
        /// Saves a previously uploaded image as PDF, and sends the file data in a JSON-serialized object. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsPDFParameters">An ImagesaveAsPDFParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of ImageSaveAsPDFResponse</returns>
        public ImageSaveAsPDFResponse ImageSaveAsPDF(ImageSaveAsPDFParameters imageSaveAsPDFParameters)
        {
            // verify the required parameter 'imageSaveAsPDFParameters' is set
            if (imageSaveAsPDFParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageSaveAsPDFParameters' when calling ImageApi->ImageSaveAsPDF");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageSaveAsPDFParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/image/ImageSaveAsPDF",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageSaveAsPDF failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageSaveAsPDFResponse)ApiClient.DeserializeResponse(response, typeof(ImageSaveAsPDFResponse));
        }

        /// <summary>
        /// Saves a previously uploaded image as PDF, and sends the file data in a JSON-serialized object. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsPDFParameters">An ImagesaveAsPDFParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (ImageSaveAsPDFResponse)</returns>
        public async Task<ImageSaveAsPDFResponse> ImageSaveAsPDFAsync(ImageSaveAsPDFParameters imageSaveAsPDFParameters)
        {
            // verify the required parameter 'imageSaveAsPDFParameters' is set
            if (imageSaveAsPDFParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageSaveAsPDFParameters' when calling ImageApi->ImageSaveAsPDF");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = imageSaveAsPDFParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageSaveAsPDF",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageSaveAsPDF failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageSaveAsPDFResponse)ApiClient.DeserializeResponse(response, typeof(ImageSaveAsPDFResponse));
        }

        /// <summary>
        /// Saves a previously uploaded image as PDF, and streams the file binary data to the response (this is the most efficient download method). 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsPDFParameters">An ImagesaveAsPDFParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of System.IO.Stream</returns>
        public void ImageSaveAsPDFFile(ImageSaveAsPDFParameters imageSaveAsPDFParameters, System.IO.Stream destinationStream)
        {
            // verify the required parameter 'imageSaveAsPDFParameters' is set
            if (imageSaveAsPDFParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageSaveAsPDFParameters' when calling ImageApi->ImageSaveAsPDFFile");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageSaveAsPDFParameters;

            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
              "/api/image/ImageSaveAsPDFFile",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageSaveAsPDFFile failed: {0}", response.ErrorMessage, response.ErrorException));
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
        /// Saves a previously uploaded image as PDF, and streams the file binary data to the response (this is the most efficient download method). 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsPDFParameters">An ImagesaveAsPDFParameters object specifying the parameters of the action.</param>
        public async Task ImageSaveAsPDFFileAsync(ImageSaveAsPDFParameters imageSaveAsPDFParameters, System.IO.Stream destinationStream)
        {
            // verify the required parameter 'imageSaveAsPDFParameters' is set
            if (imageSaveAsPDFParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageSaveAsPDFParameters' when calling ImageApi->ImageSaveAsPDFFile");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);


            requestOptions.Data = imageSaveAsPDFParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageSaveAsPDFFile",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageSaveAsPDFFile failed: {0}", response.ErrorMessage, response.ErrorException));
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
        /// Saves a previously uploaded image as PDF using MRC compression, and sends the file data in a JSON-serialized object. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsPDFMRCParameters">An ImagesaveAsPDFMRCParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of ImageSaveAsPDFMRCResponse</returns>
        public ImageSaveAsPDFMRCResponse ImageSaveAsPDFMRC(ImageSaveAsPDFMRCParameters imageSaveAsPDFMRCParameters)
        {
            // verify the required parameter 'imageSaveAsPDFMRCParameters' is set
            if (imageSaveAsPDFMRCParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageSaveAsPDFMRCParameters' when calling ImageApi->ImageSaveAsPDFMRC");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageSaveAsPDFMRCParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/image/ImageSaveAsPDFMRC",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageSaveAsPDFMRC failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageSaveAsPDFMRCResponse)ApiClient.DeserializeResponse(response, typeof(ImageSaveAsPDFMRCResponse));
        }

        /// <summary>
        /// Saves a previously uploaded image as PDF using MRC compression, and sends the file data in a JSON-serialized object. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsPDFMRCParameters">An ImagesaveAsPDFMRCParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (ImageSaveAsPDFMRCResponse)</returns>
        public async Task<ImageSaveAsPDFMRCResponse> ImageSaveAsPDFMRCAsync(ImageSaveAsPDFMRCParameters imageSaveAsPDFMRCParameters)
        {
            // verify the required parameter 'imageSaveAsPDFMRCParameters' is set
            if (imageSaveAsPDFMRCParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageSaveAsPDFMRCParameters' when calling ImageApi->ImageSaveAsPDFMRC");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = imageSaveAsPDFMRCParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageSaveAsPDFMRC",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageSaveAsPDFMRC failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageSaveAsPDFMRCResponse)ApiClient.DeserializeResponse(response, typeof(ImageSaveAsPDFMRCResponse));
        }

        /// <summary>
        /// Saves a previously uploaded image as PDF using MRC compression, and streams the file binary data to the response (this is the most efficient download method). 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsPDFMRCParameters">An ImagesaveAsPDFMRCParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of System.IO.Stream</returns>
        public void ImageSaveAsPDFMRCFile(ImageSaveAsPDFMRCParameters imageSaveAsPDFMRCParameters, System.IO.Stream destinationStream)
        {
            // verify the required parameter 'imageSaveAsPDFMRCParameters' is set
            if (imageSaveAsPDFMRCParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageSaveAsPDFMRCParameters' when calling ImageApi->ImageSaveAsPDFMRCFile");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageSaveAsPDFMRCParameters;

            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
              "/api/image/ImageSaveAsPDFMRCFile",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageSaveAsPDFMRCFile failed: {0}", response.ErrorMessage, response.ErrorException));
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
        /// Saves a previously uploaded image as PDF using MRC compression, and streams the file binary data to the response (this is the most efficient download method). 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsPDFMRCParameters">An ImagesaveAsPDFMRCParameters object specifying the parameters of the action.</param>
        public async Task ImageSaveAsPDFMRCFileAsync(ImageSaveAsPDFMRCParameters imageSaveAsPDFMRCParameters, System.IO.Stream destinationStream)
        {
            // verify the required parameter 'imageSaveAsPDFMRCParameters' is set
            if (imageSaveAsPDFMRCParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageSaveAsPDFMRCParameters' when calling ImageApi->ImageSaveAsPDFMRCFile");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);


            requestOptions.Data = imageSaveAsPDFMRCParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageSaveAsPDFMRCFile",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageSaveAsPDFMRCFile failed: {0}", response.ErrorMessage, response.ErrorException));
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
        /// Saves a previously uploaded image as PNG, and sends the file data in a JSON-serialized object. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsPNGParameters">An ImageSaveAsPNGParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of ImageSaveAsPNGResponse</returns>
        public ImageSaveAsPNGResponse ImageSaveAsPNG(ImageSaveAsPNGParameters imageSaveAsPNGParameters)
        {
            // verify the required parameter 'imageSaveAsPNGParameters' is set
            if (imageSaveAsPNGParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageSaveAsPNGParameters' when calling ImageApi->ImageSaveAsPNG");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageSaveAsPNGParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/image/ImageSaveAsPNG",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageSaveAsPNG failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageSaveAsPNGResponse)ApiClient.DeserializeResponse(response, typeof(ImageSaveAsPNGResponse));
        }

        /// <summary>
        /// Saves a previously uploaded image as PNG, and sends the file data in a JSON-serialized object. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsPNGParameters">An ImageSaveAsPNGParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (ImageSaveAsPNGResponse)</returns>
        public async Task<ImageSaveAsPNGResponse> ImageSaveAsPNGAsync(ImageSaveAsPNGParameters imageSaveAsPNGParameters)
        {
            // verify the required parameter 'imageSaveAsPNGParameters' is set
            if (imageSaveAsPNGParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageSaveAsPNGParameters' when calling ImageApi->ImageSaveAsPNG");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = imageSaveAsPNGParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageSaveAsPNG",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageSaveAsPNG failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageSaveAsPNGResponse)ApiClient.DeserializeResponse(response, typeof(ImageSaveAsPNGResponse));
        }

        /// <summary>
        /// Saves a previously uploaded image as PNG, and streams the file binary data to the response (this is the most efficient download method). 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsPNGParameters">An ImageSaveAsPNGParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of System.IO.Stream</returns>
        public void ImageSaveAsPNGFile(ImageSaveAsPNGParameters imageSaveAsPNGParameters, System.IO.Stream destinationStream)
        {
            // verify the required parameter 'imageSaveAsPNGParameters' is set
            if (imageSaveAsPNGParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageSaveAsPNGParameters' when calling ImageApi->ImageSaveAsPNGFile");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageSaveAsPNGParameters;

            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
              "/api/image/ImageSaveAsPNGFile",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageSaveAsPNGFile failed: {0}", response.ErrorMessage, response.ErrorException));
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
        /// Saves a previously uploaded image as PNG, and streams the file binary data to the response (this is the most efficient download method). 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsPNGParameters">An ImageSaveAsPNGParameters object specifying the parameters of the action.</param>
        public async Task ImageSaveAsPNGFileAsync(ImageSaveAsPNGParameters imageSaveAsPNGParameters, System.IO.Stream destinationStream)
        {
            // verify the required parameter 'imageSaveAsPNGParameters' is set
            if (imageSaveAsPNGParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageSaveAsPNGParameters' when calling ImageApi->ImageSaveAsPNGFile");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);


            requestOptions.Data = imageSaveAsPNGParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageSaveAsPNGFile",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageSaveAsPNGFile failed: {0}", response.ErrorMessage, response.ErrorException));
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
        /// Saves a previously uploaded image as TIFF, and sends the file data in a JSON-serialized object. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsTIFFParameters">An ImageSaveAsTIFFParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of ImageSaveAsTIFFResponse</returns>
        public ImageSaveAsTIFFResponse ImageSaveAsTIFF(ImageSaveAsTIFFParameters imageSaveAsTIFFParameters)
        {
            // verify the required parameter 'imageSaveAsTIFFParameters' is set
            if (imageSaveAsTIFFParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageSaveAsTIFFParameters' when calling ImageApi->ImageSaveAsTIFF");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageSaveAsTIFFParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/image/ImageSaveAsTIFF",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageSaveAsTIFF failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageSaveAsTIFFResponse)ApiClient.DeserializeResponse(response, typeof(ImageSaveAsTIFFResponse));
        }

        /// <summary>
        /// Saves a previously uploaded image as TIFF, and sends the file data in a JSON-serialized object. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsTIFFParameters">An ImageSaveAsTIFFParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (ImageSaveAsTIFFResponse)</returns>
        public async Task<ImageSaveAsTIFFResponse> ImageSaveAsTIFFAsync(ImageSaveAsTIFFParameters imageSaveAsTIFFParameters)
        {
            // verify the required parameter 'imageSaveAsTIFFParameters' is set
            if (imageSaveAsTIFFParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageSaveAsTIFFParameters' when calling ImageApi->ImageSaveAsTIFF");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = imageSaveAsTIFFParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageSaveAsTIFF",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageSaveAsTIFF failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageSaveAsTIFFResponse)ApiClient.DeserializeResponse(response, typeof(ImageSaveAsTIFFResponse));
        }

        /// <summary>
        /// Saves a previously uploaded image as TIFF, and streams the file binary data to the response (this is the most efficient download method). 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsTIFFParameters">An ImageSaveAsTIFFParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of System.IO.Stream</returns>
        public void ImageSaveAsTIFFFile(ImageSaveAsTIFFParameters imageSaveAsTIFFParameters, System.IO.Stream destinationStream)
        {
            // verify the required parameter 'imageSaveAsTIFFParameters' is set
            if (imageSaveAsTIFFParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageSaveAsTIFFParameters' when calling ImageApi->ImageSaveAsTIFFFile");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageSaveAsTIFFParameters;

            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
              "/api/image/ImageSaveAsTIFFFile",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageSaveAsTIFFFile failed: {0}", response.ErrorMessage, response.ErrorException));
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
        /// Saves a previously uploaded image as TIFF, and streams the file binary data to the response (this is the most efficient download method). 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsTIFFParameters">An ImageSaveAsTIFFParameters object specifying the parameters of the action.</param>
        public async Task ImageSaveAsTIFFFileAsync(ImageSaveAsTIFFParameters imageSaveAsTIFFParameters, System.IO.Stream destinationStream)
        {
            // verify the required parameter 'imageSaveAsTIFFParameters' is set
            if (imageSaveAsTIFFParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageSaveAsTIFFParameters' when calling ImageApi->ImageSaveAsTIFFFile");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);


            requestOptions.Data = imageSaveAsTIFFParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageSaveAsTIFFFile",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageSaveAsTIFFFile failed: {0}", response.ErrorMessage, response.ErrorException));
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
        /// Saves a previously uploaded image as multipage TIFF, and sends the file data in a JSON-serialized object. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsTIFFMultipageParameters">An ImageSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of ImageSaveAsTIFFMultipageResponse</returns>
        public ImageSaveAsTIFFMultipageResponse ImageSaveAsTIFFMultipage(ImageSaveAsTIFFMultipageParameters imageSaveAsTIFFMultipageParameters)
        {
            // verify the required parameter 'imageSaveAsTIFFMultipageParameters' is set
            if (imageSaveAsTIFFMultipageParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageSaveAsTIFFMultipageParameters' when calling ImageApi->ImageSaveAsTIFFMultipage");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageSaveAsTIFFMultipageParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/image/ImageSaveAsTIFFMultipage",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageSaveAsTIFFMultipage failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageSaveAsTIFFMultipageResponse)ApiClient.DeserializeResponse(response, typeof(ImageSaveAsTIFFMultipageResponse));
        }

        /// <summary>
        /// Saves a previously uploaded image as multipage TIFF, and sends the file data in a JSON-serialized object. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsTIFFMultipageParameters">An ImageSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (ImageSaveAsTIFFMultipageResponse)</returns>
        public async Task<ImageSaveAsTIFFMultipageResponse> ImageSaveAsTIFFMultipageAsync(ImageSaveAsTIFFMultipageParameters imageSaveAsTIFFMultipageParameters)
        {
            // verify the required parameter 'imageSaveAsTIFFMultipageParameters' is set
            if (imageSaveAsTIFFMultipageParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageSaveAsTIFFMultipageParameters' when calling ImageApi->ImageSaveAsTIFFMultipage");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = imageSaveAsTIFFMultipageParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageSaveAsTIFFMultipage",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageSaveAsTIFFMultipage failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageSaveAsTIFFMultipageResponse)ApiClient.DeserializeResponse(response, typeof(ImageSaveAsTIFFMultipageResponse));
        }

        /// <summary>
        /// Saves a previously uploaded image as multipage TIFF, and streams the file binary data to the response (this is the most efficient download method). 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsTIFFMultipageParameters">An ImageSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of System.IO.Stream</returns>
        public void ImageSaveAsTIFFMultipageFile(ImageSaveAsTIFFMultipageParameters imageSaveAsTIFFMultipageParameters, System.IO.Stream destinationStream)
        {
            // verify the required parameter 'imageSaveAsTIFFMultipageParameters' is set
            if (imageSaveAsTIFFMultipageParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageSaveAsTIFFMultipageParameters' when calling ImageApi->ImageSaveAsTIFFMultipageFile");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageSaveAsTIFFMultipageParameters;

            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
              "/api/image/ImageSaveAsTIFFMultipageFile",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageSaveAsTIFFMultipageFile failed: {0}", response.ErrorMessage, response.ErrorException));
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
        /// Saves a previously uploaded image as multipage TIFF, and streams the file binary data to the response (this is the most efficient download method). 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSaveAsTIFFMultipageParameters">An ImageSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        public async Task ImageSaveAsTIFFMultipageFileAsync(ImageSaveAsTIFFMultipageParameters imageSaveAsTIFFMultipageParameters, System.IO.Stream destinationStream)
        {
            // verify the required parameter 'imageSaveAsTIFFMultipageParameters' is set
            if (imageSaveAsTIFFMultipageParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageSaveAsTIFFMultipageParameters' when calling ImageApi->ImageSaveAsTIFFMultipageFile");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);


            requestOptions.Data = imageSaveAsTIFFMultipageParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageSaveAsTIFFMultipageFile",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageSaveAsTIFFMultipageFile failed: {0}", response.ErrorMessage, response.ErrorException));
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
        /// Swaps two pages from a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSwapPagesParameters">An ImageSwapPagesParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of ImageSwapPagesResponse</returns>
        public ImageSwapPagesResponse ImageSwapPages(ImageSwapPagesParameters imageSwapPagesParameters)
        {
            // verify the required parameter 'imageSwapPagesParameters' is set
            if (imageSwapPagesParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageSwapPagesParameters' when calling ImageApi->ImageSwapPages");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = imageSwapPagesParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/image/ImageSwapPages",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageSwapPages failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageSwapPagesResponse)ApiClient.DeserializeResponse(response, typeof(ImageSwapPagesResponse));
        }

        /// <summary>
        /// Swaps two pages from a previously uploaded image. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageSwapPagesParameters">An ImageSwapPagesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (ImageSwapPagesResponse)</returns>
        public async Task<ImageSwapPagesResponse> ImageSwapPagesAsync(ImageSwapPagesParameters imageSwapPagesParameters)
        {
            // verify the required parameter 'imageSwapPagesParameters' is set
            if (imageSwapPagesParameters == null)
                throw new ArgumentNullException("Missing required parameter 'imageSwapPagesParameters' when calling ImageApi->ImageSwapPages");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = imageSwapPagesParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/image/ImageSwapPages",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/image/ImageSwapPages failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (ImageSwapPagesResponse)ApiClient.DeserializeResponse(response, typeof(ImageSwapPagesResponse));
        }
    }
}
