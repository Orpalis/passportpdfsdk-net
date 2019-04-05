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
    public interface IPassportPDFApplicationManagerApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>StringResponse</returns>
        StringResponse PassportPDFApplicationManagerGetApplicationDownloadLink (string applicationId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>ApiResponse of StringResponse</returns>
        ApiResponse<StringResponse> PassportPDFApplicationManagerGetApplicationDownloadLinkWithHttpInfo (string applicationId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>StringResponse</returns>
        StringResponse PassportPDFApplicationManagerGetApplicationLatestVersion (string applicationId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>ApiResponse of StringResponse</returns>
        ApiResponse<StringResponse> PassportPDFApplicationManagerGetApplicationLatestVersionWithHttpInfo (string applicationId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>StringResponse</returns>
        StringResponse PassportPDFApplicationManagerGetApplicationMinimumSupportedVersion (string applicationId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>ApiResponse of StringResponse</returns>
        ApiResponse<StringResponse> PassportPDFApplicationManagerGetApplicationMinimumSupportedVersionWithHttpInfo (string applicationId);
        /// <summary>
        /// Gets the maximum number of threads to be used simultaneously by a client application.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>IntegerResponse</returns>
        IntegerResponse PassportPDFApplicationManagerGetMaxClientThreads (string applicationId);

        /// <summary>
        /// Gets the maximum number of threads to be used simultaneously by a client application.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>ApiResponse of IntegerResponse</returns>
        ApiResponse<IntegerResponse> PassportPDFApplicationManagerGetMaxClientThreadsWithHttpInfo (string applicationId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>Task of StringResponse</returns>
        System.Threading.Tasks.Task<StringResponse> PassportPDFApplicationManagerGetApplicationDownloadLinkAsync (string applicationId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>Task of ApiResponse (StringResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StringResponse>> PassportPDFApplicationManagerGetApplicationDownloadLinkAsyncWithHttpInfo (string applicationId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>Task of StringResponse</returns>
        System.Threading.Tasks.Task<StringResponse> PassportPDFApplicationManagerGetApplicationLatestVersionAsync (string applicationId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>Task of ApiResponse (StringResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StringResponse>> PassportPDFApplicationManagerGetApplicationLatestVersionAsyncWithHttpInfo (string applicationId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>Task of StringResponse</returns>
        System.Threading.Tasks.Task<StringResponse> PassportPDFApplicationManagerGetApplicationMinimumSupportedVersionAsync (string applicationId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>Task of ApiResponse (StringResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StringResponse>> PassportPDFApplicationManagerGetApplicationMinimumSupportedVersionAsyncWithHttpInfo (string applicationId);
        /// <summary>
        /// Gets the maximum number of threads to be used simultaneously by a client application.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>Task of IntegerResponse</returns>
        System.Threading.Tasks.Task<IntegerResponse> PassportPDFApplicationManagerGetMaxClientThreadsAsync (string applicationId);

        /// <summary>
        /// Gets the maximum number of threads to be used simultaneously by a client application.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>Task of ApiResponse (IntegerResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntegerResponse>> PassportPDFApplicationManagerGetMaxClientThreadsAsyncWithHttpInfo (string applicationId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PassportPDFApplicationManagerApi : IPassportPDFApplicationManagerApi
    {
        private PassportPDF.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PassportPDFApplicationManagerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PassportPDFApplicationManagerApi(String basePath)
        {
            this.Configuration = new PassportPDF.Client.Configuration { BasePath = basePath };

            ExceptionFactory = PassportPDF.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PassportPDFApplicationManagerApi"/> class
        /// </summary>
        /// <returns></returns>
        public PassportPDFApplicationManagerApi()
        {
            this.Configuration = PassportPDF.Client.Configuration.Default;

            ExceptionFactory = PassportPDF.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PassportPDFApplicationManagerApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PassportPDFApplicationManagerApi(PassportPDF.Client.Configuration configuration = null)
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
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>StringResponse</returns>
        public StringResponse PassportPDFApplicationManagerGetApplicationDownloadLink (string applicationId)
        {
             ApiResponse<StringResponse> localVarResponse = PassportPDFApplicationManagerGetApplicationDownloadLinkWithHttpInfo(applicationId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>ApiResponse of StringResponse</returns>
        public ApiResponse< StringResponse > PassportPDFApplicationManagerGetApplicationDownloadLinkWithHttpInfo (string applicationId)
        {
            // verify the required parameter 'applicationId' is set
            if (applicationId == null)
                throw new ApiException(400, "Missing required parameter 'applicationId' when calling PassportPDFApplicationManagerApi->PassportPDFApplicationManagerGetApplicationDownloadLink");

            var localVarPath = "/api/passportpdfapplicationmanager/PassportPDFApplicationManagerGetApplicationDownloadLink";
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

            if (applicationId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "applicationId", applicationId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PassportPDFApplicationManagerGetApplicationDownloadLink", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StringResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (StringResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StringResponse)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>Task of StringResponse</returns>
        public async System.Threading.Tasks.Task<StringResponse> PassportPDFApplicationManagerGetApplicationDownloadLinkAsync (string applicationId)
        {
             ApiResponse<StringResponse> localVarResponse = await PassportPDFApplicationManagerGetApplicationDownloadLinkAsyncWithHttpInfo(applicationId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>Task of ApiResponse (StringResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StringResponse>> PassportPDFApplicationManagerGetApplicationDownloadLinkAsyncWithHttpInfo (string applicationId)
        {
            // verify the required parameter 'applicationId' is set
            if (applicationId == null)
                throw new ApiException(400, "Missing required parameter 'applicationId' when calling PassportPDFApplicationManagerApi->PassportPDFApplicationManagerGetApplicationDownloadLink");

            var localVarPath = "/api/passportpdfapplicationmanager/PassportPDFApplicationManagerGetApplicationDownloadLink";
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

            if (applicationId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "applicationId", applicationId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PassportPDFApplicationManagerGetApplicationDownloadLink", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StringResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (StringResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StringResponse)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>StringResponse</returns>
        public StringResponse PassportPDFApplicationManagerGetApplicationLatestVersion (string applicationId)
        {
             ApiResponse<StringResponse> localVarResponse = PassportPDFApplicationManagerGetApplicationLatestVersionWithHttpInfo(applicationId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>ApiResponse of StringResponse</returns>
        public ApiResponse< StringResponse > PassportPDFApplicationManagerGetApplicationLatestVersionWithHttpInfo (string applicationId)
        {
            // verify the required parameter 'applicationId' is set
            if (applicationId == null)
                throw new ApiException(400, "Missing required parameter 'applicationId' when calling PassportPDFApplicationManagerApi->PassportPDFApplicationManagerGetApplicationLatestVersion");

            var localVarPath = "/api/passportpdfapplicationmanager/PassportPDFApplicationManagerGetApplicationLatestVersion";
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

            if (applicationId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "applicationId", applicationId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PassportPDFApplicationManagerGetApplicationLatestVersion", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StringResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (StringResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StringResponse)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>Task of StringResponse</returns>
        public async System.Threading.Tasks.Task<StringResponse> PassportPDFApplicationManagerGetApplicationLatestVersionAsync (string applicationId)
        {
             ApiResponse<StringResponse> localVarResponse = await PassportPDFApplicationManagerGetApplicationLatestVersionAsyncWithHttpInfo(applicationId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>Task of ApiResponse (StringResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StringResponse>> PassportPDFApplicationManagerGetApplicationLatestVersionAsyncWithHttpInfo (string applicationId)
        {
            // verify the required parameter 'applicationId' is set
            if (applicationId == null)
                throw new ApiException(400, "Missing required parameter 'applicationId' when calling PassportPDFApplicationManagerApi->PassportPDFApplicationManagerGetApplicationLatestVersion");

            var localVarPath = "/api/passportpdfapplicationmanager/PassportPDFApplicationManagerGetApplicationLatestVersion";
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

            if (applicationId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "applicationId", applicationId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PassportPDFApplicationManagerGetApplicationLatestVersion", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StringResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (StringResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StringResponse)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>StringResponse</returns>
        public StringResponse PassportPDFApplicationManagerGetApplicationMinimumSupportedVersion (string applicationId)
        {
             ApiResponse<StringResponse> localVarResponse = PassportPDFApplicationManagerGetApplicationMinimumSupportedVersionWithHttpInfo(applicationId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>ApiResponse of StringResponse</returns>
        public ApiResponse< StringResponse > PassportPDFApplicationManagerGetApplicationMinimumSupportedVersionWithHttpInfo (string applicationId)
        {
            // verify the required parameter 'applicationId' is set
            if (applicationId == null)
                throw new ApiException(400, "Missing required parameter 'applicationId' when calling PassportPDFApplicationManagerApi->PassportPDFApplicationManagerGetApplicationMinimumSupportedVersion");

            var localVarPath = "/api/passportpdfapplicationmanager/PassportPDFApplicationManagerGetApplicationMinimumSupportedVersion";
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

            if (applicationId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "applicationId", applicationId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PassportPDFApplicationManagerGetApplicationMinimumSupportedVersion", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StringResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (StringResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StringResponse)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>Task of StringResponse</returns>
        public async System.Threading.Tasks.Task<StringResponse> PassportPDFApplicationManagerGetApplicationMinimumSupportedVersionAsync (string applicationId)
        {
             ApiResponse<StringResponse> localVarResponse = await PassportPDFApplicationManagerGetApplicationMinimumSupportedVersionAsyncWithHttpInfo(applicationId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>Task of ApiResponse (StringResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StringResponse>> PassportPDFApplicationManagerGetApplicationMinimumSupportedVersionAsyncWithHttpInfo (string applicationId)
        {
            // verify the required parameter 'applicationId' is set
            if (applicationId == null)
                throw new ApiException(400, "Missing required parameter 'applicationId' when calling PassportPDFApplicationManagerApi->PassportPDFApplicationManagerGetApplicationMinimumSupportedVersion");

            var localVarPath = "/api/passportpdfapplicationmanager/PassportPDFApplicationManagerGetApplicationMinimumSupportedVersion";
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

            if (applicationId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "applicationId", applicationId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PassportPDFApplicationManagerGetApplicationMinimumSupportedVersion", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StringResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (StringResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StringResponse)));
        }

        /// <summary>
        /// Gets the maximum number of threads to be used simultaneously by a client application. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>IntegerResponse</returns>
        public IntegerResponse PassportPDFApplicationManagerGetMaxClientThreads (string applicationId)
        {
             ApiResponse<IntegerResponse> localVarResponse = PassportPDFApplicationManagerGetMaxClientThreadsWithHttpInfo(applicationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the maximum number of threads to be used simultaneously by a client application. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>ApiResponse of IntegerResponse</returns>
        public ApiResponse< IntegerResponse > PassportPDFApplicationManagerGetMaxClientThreadsWithHttpInfo (string applicationId)
        {
            // verify the required parameter 'applicationId' is set
            if (applicationId == null)
                throw new ApiException(400, "Missing required parameter 'applicationId' when calling PassportPDFApplicationManagerApi->PassportPDFApplicationManagerGetMaxClientThreads");

            var localVarPath = "/api/passportpdfapplicationmanager/PassportPDFApplicationManagerGetMaxClientThreads";
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

            if (applicationId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "applicationId", applicationId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PassportPDFApplicationManagerGetMaxClientThreads", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<IntegerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (IntegerResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegerResponse)));
        }

        /// <summary>
        /// Gets the maximum number of threads to be used simultaneously by a client application. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>Task of IntegerResponse</returns>
        public async System.Threading.Tasks.Task<IntegerResponse> PassportPDFApplicationManagerGetMaxClientThreadsAsync (string applicationId)
        {
             ApiResponse<IntegerResponse> localVarResponse = await PassportPDFApplicationManagerGetMaxClientThreadsAsyncWithHttpInfo(applicationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets the maximum number of threads to be used simultaneously by a client application. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>Task of ApiResponse (IntegerResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IntegerResponse>> PassportPDFApplicationManagerGetMaxClientThreadsAsyncWithHttpInfo (string applicationId)
        {
            // verify the required parameter 'applicationId' is set
            if (applicationId == null)
                throw new ApiException(400, "Missing required parameter 'applicationId' when calling PassportPDFApplicationManagerApi->PassportPDFApplicationManagerGetMaxClientThreads");

            var localVarPath = "/api/passportpdfapplicationmanager/PassportPDFApplicationManagerGetMaxClientThreads";
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

            if (applicationId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "applicationId", applicationId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PassportPDFApplicationManagerGetMaxClientThreads", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<IntegerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (IntegerResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegerResponse)));
        }

    }
}
