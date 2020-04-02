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
    public interface IDocumentApiSync
    {

        /// <summary>
        /// Closes a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentCloseParameters">A DocumentCloseParameters object specifying the parameters of the action.</param>
        /// <returns>DocumentCloseResponse</returns>
        DocumentCloseResponse DocumentClose(DocumentCloseParameters documentCloseParameters);

        /// <summary>
        /// Gets the format, the page count, and a thumbnail of the provided, or a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="getDocumentPreviewParameters">A GetDocumentPreviewParameters object specifying the parameters of the action.</param>
        /// <returns>DocumentGetPreviewResponse</returns>
        DocumentGetPreviewResponse DocumentGetPreview(GetDocumentPreviewParameters getDocumentPreviewParameters);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDocumentApiAsync
    {

        /// <summary>
        /// Closes a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentCloseParameters">A DocumentCloseParameters object specifying the parameters of the action.</param>
        /// <returns>Task of DocumentCloseResponse</returns>
        Task<DocumentCloseResponse> DocumentCloseAsync(DocumentCloseParameters documentCloseParameters);

        /// <summary>
        /// Gets the format, the page count, and a thumbnail of the provided, or a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="getDocumentPreviewParameters">A GetDocumentPreviewParameters object specifying the parameters of the action.</param>
        /// <returns>Task of DocumentGetPreviewResponse</returns>
        Task<DocumentGetPreviewResponse> DocumentGetPreviewAsync(GetDocumentPreviewParameters getDocumentPreviewParameters);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDocumentApi : IDocumentApiSync, IDocumentApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed class DocumentApi : IDocumentApi
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
        /// Initializes a new instance of the <see cref="DocumentApi"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        public DocumentApi(string apiKey = "")
        {
            ApiKey = apiKey;
        }

        /// <summary>
        /// Closes a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentCloseParameters">A DocumentCloseParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of DocumentCloseResponse</returns>
        public DocumentCloseResponse DocumentClose(DocumentCloseParameters documentCloseParameters)
        {
            // verify the required parameter 'documentCloseParameters' is set
            if (documentCloseParameters == null)
                throw new ArgumentNullException("Missing required parameter 'documentCloseParameters' when calling DocumentApi->DocumentClose");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = documentCloseParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/document/DocumentClose",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/document/DocumentClose failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (DocumentCloseResponse)ApiClient.DeserializeResponse(response, typeof(DocumentCloseResponse));
        }

        /// <summary>
        /// Closes a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentCloseParameters">A DocumentCloseParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (DocumentCloseResponse)</returns>
        public async Task<DocumentCloseResponse> DocumentCloseAsync(DocumentCloseParameters documentCloseParameters)
        {
            // verify the required parameter 'documentCloseParameters' is set
            if (documentCloseParameters == null)
                throw new ArgumentNullException("Missing required parameter 'documentCloseParameters' when calling DocumentApi->DocumentClose");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = documentCloseParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/document/DocumentClose",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/document/DocumentClose failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (DocumentCloseResponse)ApiClient.DeserializeResponse(response, typeof(DocumentCloseResponse));
        }

        /// <summary>
        /// Gets the format, the page count, and a thumbnail of the provided, or a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="getDocumentPreviewParameters">A GetDocumentPreviewParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of DocumentGetPreviewResponse</returns>
        public DocumentGetPreviewResponse DocumentGetPreview(GetDocumentPreviewParameters getDocumentPreviewParameters)
        {
            // verify the required parameter 'getDocumentPreviewParameters' is set
            if (getDocumentPreviewParameters == null)
                throw new ArgumentNullException("Missing required parameter 'getDocumentPreviewParameters' when calling DocumentApi->DocumentGetPreview");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = getDocumentPreviewParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/document/DocumentGetPreview",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/document/DocumentGetPreview failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (DocumentGetPreviewResponse)ApiClient.DeserializeResponse(response, typeof(DocumentGetPreviewResponse));
        }

        /// <summary>
        /// Gets the format, the page count, and a thumbnail of the provided, or a previously uploaded document. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="getDocumentPreviewParameters">A GetDocumentPreviewParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (DocumentGetPreviewResponse)</returns>
        public async Task<DocumentGetPreviewResponse> DocumentGetPreviewAsync(GetDocumentPreviewParameters getDocumentPreviewParameters)
        {
            // verify the required parameter 'getDocumentPreviewParameters' is set
            if (getDocumentPreviewParameters == null)
                throw new ArgumentNullException("Missing required parameter 'getDocumentPreviewParameters' when calling DocumentApi->DocumentGetPreview");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = getDocumentPreviewParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/document/DocumentGetPreview",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/document/DocumentGetPreview failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (DocumentGetPreviewResponse)ApiClient.DeserializeResponse(response, typeof(DocumentGetPreviewResponse));
        }
    }
}
