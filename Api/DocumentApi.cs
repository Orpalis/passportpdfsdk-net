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
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentCloseParameters">A DocumentCloseParameters object specifying the parameters of the action.</param>
        /// <returns>DocumentCloseResponse</returns>
        DocumentCloseResponse DocumentClose(DocumentCloseParameters documentCloseParameters);

        /// <summary>
        /// Gets the format, the page count and a thumbnail of a previously uploaded document.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="getDocumentPreviewParameters">A GetDocumentPreviewParameters object specifying the parameters of the action.</param>
        /// <returns>DocumentGetPreviewResponse</returns>
        DocumentGetPreviewResponse DocumentGetPreview(GetDocumentPreviewParameters getDocumentPreviewParameters);

        /// <summary>
        /// Loads the provided document file.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loadDocumentFromByteArrayParameters">A LoadDocumentFromByteArrayParameters object specifying the parameters of the action.</param>
        /// <returns>DocumentLoadResponse</returns>
        DocumentLoadResponse DocumentLoad(LoadDocumentFromByteArrayParameters loadDocumentFromByteArrayParameters);

        /// <summary>
        /// Loads the provided document file from an URI.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loadDocumentFromURIParameters">A LoadDocumentFromURIParameters object specifying the parameters of the action.</param>
        /// <returns>DocumentLoadResponse</returns>
        DocumentLoadResponse DocumentLoadFromURI(LoadDocumentFromURIParameters loadDocumentFromURIParameters);

        /// <summary>
        /// Loads the provided document file using Multipart Upload.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileData">The data of the document.</param>
        /// <param name="loadDocumentParameters"> (optional)</param>
        /// <returns>DocumentLoadResponse</returns>
        DocumentLoadResponse DocumentLoadMultipart(System.IO.Stream fileData, LoadDocumentParameters loadDocumentParameters = null);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDocumentApiAsync
    {

        /// <summary>
        /// Closes a previously uploaded document.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentCloseParameters">A DocumentCloseParameters object specifying the parameters of the action.</param>
        /// <returns>Task of DocumentCloseResponse</returns>
        Task<DocumentCloseResponse> DocumentCloseAsync(DocumentCloseParameters documentCloseParameters);

        /// <summary>
        /// Gets the format, the page count and a thumbnail of a previously uploaded document.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="getDocumentPreviewParameters">A GetDocumentPreviewParameters object specifying the parameters of the action.</param>
        /// <returns>Task of DocumentGetPreviewResponse</returns>
        Task<DocumentGetPreviewResponse> DocumentGetPreviewAsync(GetDocumentPreviewParameters getDocumentPreviewParameters);

        /// <summary>
        /// Loads the provided document file.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loadDocumentFromByteArrayParameters">A LoadDocumentFromByteArrayParameters object specifying the parameters of the action.</param>
        /// <returns>Task of DocumentLoadResponse</returns>
        Task<DocumentLoadResponse> DocumentLoadAsync(LoadDocumentFromByteArrayParameters loadDocumentFromByteArrayParameters);

        /// <summary>
        /// Loads the provided document file from an URI.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loadDocumentFromURIParameters">A LoadDocumentFromURIParameters object specifying the parameters of the action.</param>
        /// <returns>Task of DocumentLoadResponse</returns>
        Task<DocumentLoadResponse> DocumentLoadFromURIAsync(LoadDocumentFromURIParameters loadDocumentFromURIParameters);

        /// <summary>
        /// Loads the provided document file using Multipart Upload.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileData">The data of the document.</param>
        /// <param name="loadDocumentParameters"> (optional)</param>
        /// <returns>Task of DocumentLoadResponse</returns>
        Task<DocumentLoadResponse> DocumentLoadMultipartAsync(System.IO.Stream fileData, LoadDocumentParameters loadDocumentParameters = null);
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
        /// Gets the format, the page count and a thumbnail of a previously uploaded document. 
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
        /// Gets the format, the page count and a thumbnail of a previously uploaded document. 
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

        /// <summary>
        /// Loads the provided document file. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loadDocumentFromByteArrayParameters">A LoadDocumentFromByteArrayParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of DocumentLoadResponse</returns>
        public DocumentLoadResponse DocumentLoad(LoadDocumentFromByteArrayParameters loadDocumentFromByteArrayParameters)
        {
            // verify the required parameter 'loadDocumentFromByteArrayParameters' is set
            if (loadDocumentFromByteArrayParameters == null)
                throw new ArgumentNullException("Missing required parameter 'loadDocumentFromByteArrayParameters' when calling DocumentApi->DocumentLoad");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = loadDocumentFromByteArrayParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/document/DocumentLoad",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/document/DocumentLoad failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (DocumentLoadResponse)ApiClient.DeserializeResponse(response, typeof(DocumentLoadResponse));
        }

        /// <summary>
        /// Loads the provided document file. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loadDocumentFromByteArrayParameters">A LoadDocumentFromByteArrayParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (DocumentLoadResponse)</returns>
        public async Task<DocumentLoadResponse> DocumentLoadAsync(LoadDocumentFromByteArrayParameters loadDocumentFromByteArrayParameters)
        {
            // verify the required parameter 'loadDocumentFromByteArrayParameters' is set
            if (loadDocumentFromByteArrayParameters == null)
                throw new ArgumentNullException("Missing required parameter 'loadDocumentFromByteArrayParameters' when calling DocumentApi->DocumentLoad");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = loadDocumentFromByteArrayParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/document/DocumentLoad",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/document/DocumentLoad failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (DocumentLoadResponse)ApiClient.DeserializeResponse(response, typeof(DocumentLoadResponse));
        }

        /// <summary>
        /// Loads the provided document file from an URI. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loadDocumentFromURIParameters">A LoadDocumentFromURIParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of DocumentLoadResponse</returns>
        public DocumentLoadResponse DocumentLoadFromURI(LoadDocumentFromURIParameters loadDocumentFromURIParameters)
        {
            // verify the required parameter 'loadDocumentFromURIParameters' is set
            if (loadDocumentFromURIParameters == null)
                throw new ArgumentNullException("Missing required parameter 'loadDocumentFromURIParameters' when calling DocumentApi->DocumentLoadFromURI");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = loadDocumentFromURIParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/document/DocumentLoadFromURI",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/document/DocumentLoadFromURI failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (DocumentLoadResponse)ApiClient.DeserializeResponse(response, typeof(DocumentLoadResponse));
        }

        /// <summary>
        /// Loads the provided document file from an URI. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loadDocumentFromURIParameters">A LoadDocumentFromURIParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (DocumentLoadResponse)</returns>
        public async Task<DocumentLoadResponse> DocumentLoadFromURIAsync(LoadDocumentFromURIParameters loadDocumentFromURIParameters)
        {
            // verify the required parameter 'loadDocumentFromURIParameters' is set
            if (loadDocumentFromURIParameters == null)
                throw new ArgumentNullException("Missing required parameter 'loadDocumentFromURIParameters' when calling DocumentApi->DocumentLoadFromURI");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = loadDocumentFromURIParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/document/DocumentLoadFromURI",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/document/DocumentLoadFromURI failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (DocumentLoadResponse)ApiClient.DeserializeResponse(response, typeof(DocumentLoadResponse));
        }

        /// <summary>
        /// Loads the provided document file using Multipart Upload. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileData">The data of the document.</param>
        /// <param name="loadDocumentParameters"> (optional)</param>
        /// <returns>IRestResponse of DocumentLoadResponse</returns>
        public DocumentLoadResponse DocumentLoadMultipart(System.IO.Stream fileData, LoadDocumentParameters loadDocumentParameters = null)
        {
            // verify the required parameter 'fileData' is set
            if (fileData == null)
                throw new ArgumentNullException("Missing required parameter 'fileData' when calling DocumentApi->DocumentLoadMultipart");

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
             "/api/document/DocumentLoadMultipart",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/document/DocumentLoadMultipart failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (DocumentLoadResponse)ApiClient.DeserializeResponse(response, typeof(DocumentLoadResponse));
        }

        /// <summary>
        /// Loads the provided document file using Multipart Upload. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileData">The data of the document.</param>
        /// <param name="loadDocumentParameters"> (optional)</param>
        /// <returns>Task of IRestResponse (DocumentLoadResponse)</returns>
        public async Task<DocumentLoadResponse> DocumentLoadMultipartAsync(System.IO.Stream fileData, LoadDocumentParameters loadDocumentParameters = null)
        {
            // verify the required parameter 'fileData' is set
            if (fileData == null)
                throw new ArgumentNullException("Missing required parameter 'fileData' when calling DocumentApi->DocumentLoadMultipart");

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
            "/api/document/DocumentLoadMultipart",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/document/DocumentLoadMultipart failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (DocumentLoadResponse)ApiClient.DeserializeResponse(response, typeof(DocumentLoadResponse));
        }
    }
}
