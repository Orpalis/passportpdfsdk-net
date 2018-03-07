/* 
 * PassportPDF
 *
 * Copyright © 2018 ORPALIS - http://www.orpalis.com
 *
 * OpenAPI spec version: v1
 * Contact: contact@orpalis.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
    public interface IConfigApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Gets the maximal length of a request content, in bytes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>LongResponse</returns>
        LongResponse GetMaxAllowedContentLength ();

        /// <summary>
        /// Gets the maximal length of a request content, in bytes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of LongResponse</returns>
        ApiResponse<LongResponse> GetMaxAllowedContentLengthWithHttpInfo ();
        /// <summary>
        /// Gets the suggested client API timeout, in milliseconds.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>IntegerResponse</returns>
        IntegerResponse GetSuggestedClientTimeout ();

        /// <summary>
        /// Gets the suggested client API timeout, in milliseconds.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of IntegerResponse</returns>
        ApiResponse<IntegerResponse> GetSuggestedClientTimeoutWithHttpInfo ();
        /// <summary>
        /// Gets the suggested maximum number of threads to be used simultaneously by a client application.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>IntegerResponse</returns>
        IntegerResponse GetSuggestedMaxClientThreads ();

        /// <summary>
        /// Gets the suggested maximum number of threads to be used simultaneously by a client application.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of IntegerResponse</returns>
        ApiResponse<IntegerResponse> GetSuggestedMaxClientThreadsWithHttpInfo ();
        /// <summary>
        /// Get the list of supported languages for OCR.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>StringArrayResponse</returns>
        StringArrayResponse GetSupportedOCRLanguages ();

        /// <summary>
        /// Get the list of supported languages for OCR.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of StringArrayResponse</returns>
        ApiResponse<StringArrayResponse> GetSupportedOCRLanguagesWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Gets the maximal length of a request content, in bytes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of LongResponse</returns>
        System.Threading.Tasks.Task<LongResponse> GetMaxAllowedContentLengthAsync ();

        /// <summary>
        /// Gets the maximal length of a request content, in bytes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (LongResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LongResponse>> GetMaxAllowedContentLengthAsyncWithHttpInfo ();
        /// <summary>
        /// Gets the suggested client API timeout, in milliseconds.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of IntegerResponse</returns>
        System.Threading.Tasks.Task<IntegerResponse> GetSuggestedClientTimeoutAsync ();

        /// <summary>
        /// Gets the suggested client API timeout, in milliseconds.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (IntegerResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntegerResponse>> GetSuggestedClientTimeoutAsyncWithHttpInfo ();
        /// <summary>
        /// Gets the suggested maximum number of threads to be used simultaneously by a client application.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of IntegerResponse</returns>
        System.Threading.Tasks.Task<IntegerResponse> GetSuggestedMaxClientThreadsAsync ();

        /// <summary>
        /// Gets the suggested maximum number of threads to be used simultaneously by a client application.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (IntegerResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntegerResponse>> GetSuggestedMaxClientThreadsAsyncWithHttpInfo ();
        /// <summary>
        /// Get the list of supported languages for OCR.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of StringArrayResponse</returns>
        System.Threading.Tasks.Task<StringArrayResponse> GetSupportedOCRLanguagesAsync ();

        /// <summary>
        /// Get the list of supported languages for OCR.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (StringArrayResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StringArrayResponse>> GetSupportedOCRLanguagesAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ConfigApi : IConfigApi
    {
        private PassportPDF.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConfigApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = PassportPDF.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ConfigApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
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
        public Configuration Configuration {get; set;}

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
        /// Gets the maximal length of a request content, in bytes. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>LongResponse</returns>
        public LongResponse GetMaxAllowedContentLength ()
        {
             ApiResponse<LongResponse> localVarResponse = GetMaxAllowedContentLengthWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the maximal length of a request content, in bytes. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of LongResponse</returns>
        public ApiResponse< LongResponse > GetMaxAllowedContentLengthWithHttpInfo ()
        {

            var localVarPath = "/api/config/GetMaxAllowedContentLength";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetMaxAllowedContentLength", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<LongResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LongResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LongResponse)));
        }

        /// <summary>
        /// Gets the maximal length of a request content, in bytes. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of LongResponse</returns>
        public async System.Threading.Tasks.Task<LongResponse> GetMaxAllowedContentLengthAsync ()
        {
             ApiResponse<LongResponse> localVarResponse = await GetMaxAllowedContentLengthAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets the maximal length of a request content, in bytes. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (LongResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LongResponse>> GetMaxAllowedContentLengthAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/config/GetMaxAllowedContentLength";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetMaxAllowedContentLength", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<LongResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LongResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LongResponse)));
        }

        /// <summary>
        /// Gets the suggested client API timeout, in milliseconds. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>IntegerResponse</returns>
        public IntegerResponse GetSuggestedClientTimeout ()
        {
             ApiResponse<IntegerResponse> localVarResponse = GetSuggestedClientTimeoutWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the suggested client API timeout, in milliseconds. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of IntegerResponse</returns>
        public ApiResponse< IntegerResponse > GetSuggestedClientTimeoutWithHttpInfo ()
        {

            var localVarPath = "/api/config/GetSuggestedClientTimeout";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSuggestedClientTimeout", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<IntegerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegerResponse)));
        }

        /// <summary>
        /// Gets the suggested client API timeout, in milliseconds. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of IntegerResponse</returns>
        public async System.Threading.Tasks.Task<IntegerResponse> GetSuggestedClientTimeoutAsync ()
        {
             ApiResponse<IntegerResponse> localVarResponse = await GetSuggestedClientTimeoutAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets the suggested client API timeout, in milliseconds. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (IntegerResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IntegerResponse>> GetSuggestedClientTimeoutAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/config/GetSuggestedClientTimeout";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSuggestedClientTimeout", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<IntegerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegerResponse)));
        }

        /// <summary>
        /// Gets the suggested maximum number of threads to be used simultaneously by a client application. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>IntegerResponse</returns>
        public IntegerResponse GetSuggestedMaxClientThreads ()
        {
             ApiResponse<IntegerResponse> localVarResponse = GetSuggestedMaxClientThreadsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the suggested maximum number of threads to be used simultaneously by a client application. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of IntegerResponse</returns>
        public ApiResponse< IntegerResponse > GetSuggestedMaxClientThreadsWithHttpInfo ()
        {

            var localVarPath = "/api/config/GetSuggestedMaxClientThreads";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSuggestedMaxClientThreads", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<IntegerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegerResponse)));
        }

        /// <summary>
        /// Gets the suggested maximum number of threads to be used simultaneously by a client application. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of IntegerResponse</returns>
        public async System.Threading.Tasks.Task<IntegerResponse> GetSuggestedMaxClientThreadsAsync ()
        {
             ApiResponse<IntegerResponse> localVarResponse = await GetSuggestedMaxClientThreadsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets the suggested maximum number of threads to be used simultaneously by a client application. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (IntegerResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IntegerResponse>> GetSuggestedMaxClientThreadsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/config/GetSuggestedMaxClientThreads";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSuggestedMaxClientThreads", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<IntegerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegerResponse)));
        }

        /// <summary>
        /// Get the list of supported languages for OCR. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>StringArrayResponse</returns>
        public StringArrayResponse GetSupportedOCRLanguages ()
        {
             ApiResponse<StringArrayResponse> localVarResponse = GetSupportedOCRLanguagesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of supported languages for OCR. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of StringArrayResponse</returns>
        public ApiResponse< StringArrayResponse > GetSupportedOCRLanguagesWithHttpInfo ()
        {

            var localVarPath = "/api/config/GetSupportedOCRLanguages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSupportedOCRLanguages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StringArrayResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StringArrayResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StringArrayResponse)));
        }

        /// <summary>
        /// Get the list of supported languages for OCR. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of StringArrayResponse</returns>
        public async System.Threading.Tasks.Task<StringArrayResponse> GetSupportedOCRLanguagesAsync ()
        {
             ApiResponse<StringArrayResponse> localVarResponse = await GetSupportedOCRLanguagesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of supported languages for OCR. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (StringArrayResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StringArrayResponse>> GetSupportedOCRLanguagesAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/config/GetSupportedOCRLanguages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSupportedOCRLanguages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StringArrayResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StringArrayResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StringArrayResponse)));
        }

    }
}
