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
    public interface IDocumentApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Closes a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeParameters">A DocumentCloseParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>DocumentCloseResponse</returns>
        DocumentCloseResponse DocumentClose (DocumentCloseParameters closeParameters = null);

        /// <summary>
        /// Closes a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeParameters">A DocumentCloseParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>ApiResponse of DocumentCloseResponse</returns>
        ApiResponse<DocumentCloseResponse> DocumentCloseWithHttpInfo (DocumentCloseParameters closeParameters = null);
        /// <summary>
        /// Gets the format, the page count, and a thumbnail of the provided, or a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getDocumentPreviewParameters">A GetDocumentPreviewParameters object specifying the parameters of the action.</param>
        /// <returns>DocumentGetPreviewResponse</returns>
        DocumentGetPreviewResponse DocumentGetPreview (GetDocumentPreviewParameters getDocumentPreviewParameters);

        /// <summary>
        /// Gets the format, the page count, and a thumbnail of the provided, or a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getDocumentPreviewParameters">A GetDocumentPreviewParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of DocumentGetPreviewResponse</returns>
        ApiResponse<DocumentGetPreviewResponse> DocumentGetPreviewWithHttpInfo (GetDocumentPreviewParameters getDocumentPreviewParameters);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Closes a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeParameters">A DocumentCloseParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of DocumentCloseResponse</returns>
        System.Threading.Tasks.Task<DocumentCloseResponse> DocumentCloseAsync (DocumentCloseParameters closeParameters = null);

        /// <summary>
        /// Closes a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeParameters">A DocumentCloseParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of ApiResponse (DocumentCloseResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentCloseResponse>> DocumentCloseAsyncWithHttpInfo (DocumentCloseParameters closeParameters = null);
        /// <summary>
        /// Gets the format, the page count, and a thumbnail of the provided, or a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getDocumentPreviewParameters">A GetDocumentPreviewParameters object specifying the parameters of the action.</param>
        /// <returns>Task of DocumentGetPreviewResponse</returns>
        System.Threading.Tasks.Task<DocumentGetPreviewResponse> DocumentGetPreviewAsync (GetDocumentPreviewParameters getDocumentPreviewParameters);

        /// <summary>
        /// Gets the format, the page count, and a thumbnail of the provided, or a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getDocumentPreviewParameters">A GetDocumentPreviewParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (DocumentGetPreviewResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentGetPreviewResponse>> DocumentGetPreviewAsyncWithHttpInfo (GetDocumentPreviewParameters getDocumentPreviewParameters);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DocumentApi : IDocumentApi
    {
        private PassportPDF.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DocumentApi(String basePath)
        {
            this.Configuration = new PassportPDF.Client.Configuration { BasePath = basePath };

            ExceptionFactory = PassportPDF.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentApi"/> class
        /// </summary>
        /// <returns></returns>
        public DocumentApi()
        {
            this.Configuration = PassportPDF.Client.Configuration.Default;

            ExceptionFactory = PassportPDF.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DocumentApi(PassportPDF.Client.Configuration configuration = null)
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
        /// Closes a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeParameters">A DocumentCloseParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>DocumentCloseResponse</returns>
        public DocumentCloseResponse DocumentClose (DocumentCloseParameters closeParameters = null)
        {
             ApiResponse<DocumentCloseResponse> localVarResponse = DocumentCloseWithHttpInfo(closeParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Closes a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeParameters">A DocumentCloseParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>ApiResponse of DocumentCloseResponse</returns>
        public ApiResponse< DocumentCloseResponse > DocumentCloseWithHttpInfo (DocumentCloseParameters closeParameters = null)
        {

            var localVarPath = "/api/document/DocumentClose";
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
                Exception exception = ExceptionFactory("DocumentClose", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentCloseResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (DocumentCloseResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentCloseResponse)));
        }

        /// <summary>
        /// Closes a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeParameters">A DocumentCloseParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of DocumentCloseResponse</returns>
        public async System.Threading.Tasks.Task<DocumentCloseResponse> DocumentCloseAsync (DocumentCloseParameters closeParameters = null)
        {
             ApiResponse<DocumentCloseResponse> localVarResponse = await DocumentCloseAsyncWithHttpInfo(closeParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Closes a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeParameters">A DocumentCloseParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of ApiResponse (DocumentCloseResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentCloseResponse>> DocumentCloseAsyncWithHttpInfo (DocumentCloseParameters closeParameters = null)
        {

            var localVarPath = "/api/document/DocumentClose";
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
                Exception exception = ExceptionFactory("DocumentClose", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentCloseResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (DocumentCloseResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentCloseResponse)));
        }

        /// <summary>
        /// Gets the format, the page count, and a thumbnail of the provided, or a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getDocumentPreviewParameters">A GetDocumentPreviewParameters object specifying the parameters of the action.</param>
        /// <returns>DocumentGetPreviewResponse</returns>
        public DocumentGetPreviewResponse DocumentGetPreview (GetDocumentPreviewParameters getDocumentPreviewParameters)
        {
             ApiResponse<DocumentGetPreviewResponse> localVarResponse = DocumentGetPreviewWithHttpInfo(getDocumentPreviewParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the format, the page count, and a thumbnail of the provided, or a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getDocumentPreviewParameters">A GetDocumentPreviewParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of DocumentGetPreviewResponse</returns>
        public ApiResponse< DocumentGetPreviewResponse > DocumentGetPreviewWithHttpInfo (GetDocumentPreviewParameters getDocumentPreviewParameters)
        {
            // verify the required parameter 'getDocumentPreviewParameters' is set
            if (getDocumentPreviewParameters == null)
                throw new ApiException(400, "Missing required parameter 'getDocumentPreviewParameters' when calling DocumentApi->DocumentGetPreview");

            var localVarPath = "/api/document/DocumentGetPreview";
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

            if (getDocumentPreviewParameters != null && getDocumentPreviewParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(getDocumentPreviewParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = getDocumentPreviewParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DocumentGetPreview", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentGetPreviewResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (DocumentGetPreviewResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentGetPreviewResponse)));
        }

        /// <summary>
        /// Gets the format, the page count, and a thumbnail of the provided, or a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getDocumentPreviewParameters">A GetDocumentPreviewParameters object specifying the parameters of the action.</param>
        /// <returns>Task of DocumentGetPreviewResponse</returns>
        public async System.Threading.Tasks.Task<DocumentGetPreviewResponse> DocumentGetPreviewAsync (GetDocumentPreviewParameters getDocumentPreviewParameters)
        {
             ApiResponse<DocumentGetPreviewResponse> localVarResponse = await DocumentGetPreviewAsyncWithHttpInfo(getDocumentPreviewParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets the format, the page count, and a thumbnail of the provided, or a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getDocumentPreviewParameters">A GetDocumentPreviewParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (DocumentGetPreviewResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentGetPreviewResponse>> DocumentGetPreviewAsyncWithHttpInfo (GetDocumentPreviewParameters getDocumentPreviewParameters)
        {
            // verify the required parameter 'getDocumentPreviewParameters' is set
            if (getDocumentPreviewParameters == null)
                throw new ApiException(400, "Missing required parameter 'getDocumentPreviewParameters' when calling DocumentApi->DocumentGetPreview");

            var localVarPath = "/api/document/DocumentGetPreview";
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

            if (getDocumentPreviewParameters != null && getDocumentPreviewParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(getDocumentPreviewParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = getDocumentPreviewParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DocumentGetPreview", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentGetPreviewResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (DocumentGetPreviewResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentGetPreviewResponse)));
        }

    }
}
