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
    public interface IConfigApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>string</returns>
        string ConfigGetAPIVersion ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ConfigGetAPIVersionWithHttpInfo ();
        /// <summary>
        /// Gets the maximal length of a request content, in bytes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>LongResponse</returns>
        LongResponse ConfigGetMaxAllowedContentLength ();

        /// <summary>
        /// Gets the maximal length of a request content, in bytes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of LongResponse</returns>
        ApiResponse<LongResponse> ConfigGetMaxAllowedContentLengthWithHttpInfo ();
        /// <summary>
        /// Gets the suggested client API timeout, in milliseconds.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>IntegerResponse</returns>
        IntegerResponse ConfigGetSuggestedClientTimeout ();

        /// <summary>
        /// Gets the suggested client API timeout, in milliseconds.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of IntegerResponse</returns>
        ApiResponse<IntegerResponse> ConfigGetSuggestedClientTimeoutWithHttpInfo ();
        /// <summary>
        /// Gets the suggested maximum number of threads to be used simultaneously by a client application.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>IntegerResponse</returns>
        IntegerResponse ConfigGetSuggestedMaxClientThreads ();

        /// <summary>
        /// Gets the suggested maximum number of threads to be used simultaneously by a client application.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of IntegerResponse</returns>
        ApiResponse<IntegerResponse> ConfigGetSuggestedMaxClientThreadsWithHttpInfo ();
        /// <summary>
        /// Gets the list of supported fonts for text drawing operations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Font&gt;</returns>
        List<Font> ConfigGetSupportedFonts ();

        /// <summary>
        /// Gets the list of supported fonts for text drawing operations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Font&gt;</returns>
        ApiResponse<List<Font>> ConfigGetSupportedFontsWithHttpInfo ();
        /// <summary>
        /// Gets the list of supported languages for OCR.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>StringArrayResponse</returns>
        StringArrayResponse ConfigGetSupportedOCRLanguages ();

        /// <summary>
        /// Gets the list of supported languages for OCR.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of StringArrayResponse</returns>
        ApiResponse<StringArrayResponse> ConfigGetSupportedOCRLanguagesWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ConfigGetAPIVersionAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ConfigGetAPIVersionAsyncWithHttpInfo ();
        /// <summary>
        /// Gets the maximal length of a request content, in bytes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of LongResponse</returns>
        System.Threading.Tasks.Task<LongResponse> ConfigGetMaxAllowedContentLengthAsync ();

        /// <summary>
        /// Gets the maximal length of a request content, in bytes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (LongResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LongResponse>> ConfigGetMaxAllowedContentLengthAsyncWithHttpInfo ();
        /// <summary>
        /// Gets the suggested client API timeout, in milliseconds.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of IntegerResponse</returns>
        System.Threading.Tasks.Task<IntegerResponse> ConfigGetSuggestedClientTimeoutAsync ();

        /// <summary>
        /// Gets the suggested client API timeout, in milliseconds.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (IntegerResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntegerResponse>> ConfigGetSuggestedClientTimeoutAsyncWithHttpInfo ();
        /// <summary>
        /// Gets the suggested maximum number of threads to be used simultaneously by a client application.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of IntegerResponse</returns>
        System.Threading.Tasks.Task<IntegerResponse> ConfigGetSuggestedMaxClientThreadsAsync ();

        /// <summary>
        /// Gets the suggested maximum number of threads to be used simultaneously by a client application.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (IntegerResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntegerResponse>> ConfigGetSuggestedMaxClientThreadsAsyncWithHttpInfo ();
        /// <summary>
        /// Gets the list of supported fonts for text drawing operations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Font&gt;</returns>
        System.Threading.Tasks.Task<List<Font>> ConfigGetSupportedFontsAsync ();

        /// <summary>
        /// Gets the list of supported fonts for text drawing operations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Font&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Font>>> ConfigGetSupportedFontsAsyncWithHttpInfo ();
        /// <summary>
        /// Gets the list of supported languages for OCR.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of StringArrayResponse</returns>
        System.Threading.Tasks.Task<StringArrayResponse> ConfigGetSupportedOCRLanguagesAsync ();

        /// <summary>
        /// Gets the list of supported languages for OCR.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (StringArrayResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StringArrayResponse>> ConfigGetSupportedOCRLanguagesAsyncWithHttpInfo ();
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
            this.Configuration = new PassportPDF.Client.Configuration { BasePath = basePath };

            ExceptionFactory = PassportPDF.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigApi"/> class
        /// </summary>
        /// <returns></returns>
        public ConfigApi()
        {
            this.Configuration = PassportPDF.Client.Configuration.Default;

            ExceptionFactory = PassportPDF.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ConfigApi(PassportPDF.Client.Configuration configuration = null)
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
        /// <returns>string</returns>
        public string ConfigGetAPIVersion ()
        {
             ApiResponse<string> localVarResponse = ConfigGetAPIVersionWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ConfigGetAPIVersionWithHttpInfo ()
        {

            var localVarPath = "/api/config/ConfigGetAPIVersion";
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
                Exception exception = ExceptionFactory("ConfigGetAPIVersion", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ConfigGetAPIVersionAsync ()
        {
             ApiResponse<string> localVarResponse = await ConfigGetAPIVersionAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ConfigGetAPIVersionAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/config/ConfigGetAPIVersion";
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
                Exception exception = ExceptionFactory("ConfigGetAPIVersion", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Gets the maximal length of a request content, in bytes. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>LongResponse</returns>
        public LongResponse ConfigGetMaxAllowedContentLength ()
        {
             ApiResponse<LongResponse> localVarResponse = ConfigGetMaxAllowedContentLengthWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the maximal length of a request content, in bytes. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of LongResponse</returns>
        public ApiResponse< LongResponse > ConfigGetMaxAllowedContentLengthWithHttpInfo ()
        {

            var localVarPath = "/api/config/ConfigGetMaxAllowedContentLength";
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
                Exception exception = ExceptionFactory("ConfigGetMaxAllowedContentLength", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<LongResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (LongResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LongResponse)));
        }

        /// <summary>
        /// Gets the maximal length of a request content, in bytes. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of LongResponse</returns>
        public async System.Threading.Tasks.Task<LongResponse> ConfigGetMaxAllowedContentLengthAsync ()
        {
             ApiResponse<LongResponse> localVarResponse = await ConfigGetMaxAllowedContentLengthAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets the maximal length of a request content, in bytes. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (LongResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LongResponse>> ConfigGetMaxAllowedContentLengthAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/config/ConfigGetMaxAllowedContentLength";
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
                Exception exception = ExceptionFactory("ConfigGetMaxAllowedContentLength", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<LongResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (LongResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LongResponse)));
        }

        /// <summary>
        /// Gets the suggested client API timeout, in milliseconds. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>IntegerResponse</returns>
        public IntegerResponse ConfigGetSuggestedClientTimeout ()
        {
             ApiResponse<IntegerResponse> localVarResponse = ConfigGetSuggestedClientTimeoutWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the suggested client API timeout, in milliseconds. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of IntegerResponse</returns>
        public ApiResponse< IntegerResponse > ConfigGetSuggestedClientTimeoutWithHttpInfo ()
        {

            var localVarPath = "/api/config/ConfigGetSuggestedClientTimeout";
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
                Exception exception = ExceptionFactory("ConfigGetSuggestedClientTimeout", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<IntegerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (IntegerResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegerResponse)));
        }

        /// <summary>
        /// Gets the suggested client API timeout, in milliseconds. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of IntegerResponse</returns>
        public async System.Threading.Tasks.Task<IntegerResponse> ConfigGetSuggestedClientTimeoutAsync ()
        {
             ApiResponse<IntegerResponse> localVarResponse = await ConfigGetSuggestedClientTimeoutAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets the suggested client API timeout, in milliseconds. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (IntegerResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IntegerResponse>> ConfigGetSuggestedClientTimeoutAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/config/ConfigGetSuggestedClientTimeout";
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
                Exception exception = ExceptionFactory("ConfigGetSuggestedClientTimeout", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<IntegerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (IntegerResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegerResponse)));
        }

        /// <summary>
        /// Gets the suggested maximum number of threads to be used simultaneously by a client application. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>IntegerResponse</returns>
        public IntegerResponse ConfigGetSuggestedMaxClientThreads ()
        {
             ApiResponse<IntegerResponse> localVarResponse = ConfigGetSuggestedMaxClientThreadsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the suggested maximum number of threads to be used simultaneously by a client application. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of IntegerResponse</returns>
        public ApiResponse< IntegerResponse > ConfigGetSuggestedMaxClientThreadsWithHttpInfo ()
        {

            var localVarPath = "/api/config/ConfigGetSuggestedMaxClientThreads";
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
                Exception exception = ExceptionFactory("ConfigGetSuggestedMaxClientThreads", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<IntegerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (IntegerResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegerResponse)));
        }

        /// <summary>
        /// Gets the suggested maximum number of threads to be used simultaneously by a client application. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of IntegerResponse</returns>
        public async System.Threading.Tasks.Task<IntegerResponse> ConfigGetSuggestedMaxClientThreadsAsync ()
        {
             ApiResponse<IntegerResponse> localVarResponse = await ConfigGetSuggestedMaxClientThreadsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets the suggested maximum number of threads to be used simultaneously by a client application. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (IntegerResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IntegerResponse>> ConfigGetSuggestedMaxClientThreadsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/config/ConfigGetSuggestedMaxClientThreads";
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
                Exception exception = ExceptionFactory("ConfigGetSuggestedMaxClientThreads", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<IntegerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (IntegerResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegerResponse)));
        }

        /// <summary>
        /// Gets the list of supported fonts for text drawing operations. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Font&gt;</returns>
        public List<Font> ConfigGetSupportedFonts ()
        {
             ApiResponse<List<Font>> localVarResponse = ConfigGetSupportedFontsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the list of supported fonts for text drawing operations. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Font&gt;</returns>
        public ApiResponse< List<Font> > ConfigGetSupportedFontsWithHttpInfo ()
        {

            var localVarPath = "/api/config/ConfigGetSupportedFonts";
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
                Exception exception = ExceptionFactory("ConfigGetSupportedFonts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Font>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<Font>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Font>)));
        }

        /// <summary>
        /// Gets the list of supported fonts for text drawing operations. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Font&gt;</returns>
        public async System.Threading.Tasks.Task<List<Font>> ConfigGetSupportedFontsAsync ()
        {
             ApiResponse<List<Font>> localVarResponse = await ConfigGetSupportedFontsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets the list of supported fonts for text drawing operations. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Font&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Font>>> ConfigGetSupportedFontsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/config/ConfigGetSupportedFonts";
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
                Exception exception = ExceptionFactory("ConfigGetSupportedFonts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Font>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<Font>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Font>)));
        }

        /// <summary>
        /// Gets the list of supported languages for OCR. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>StringArrayResponse</returns>
        public StringArrayResponse ConfigGetSupportedOCRLanguages ()
        {
             ApiResponse<StringArrayResponse> localVarResponse = ConfigGetSupportedOCRLanguagesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the list of supported languages for OCR. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of StringArrayResponse</returns>
        public ApiResponse< StringArrayResponse > ConfigGetSupportedOCRLanguagesWithHttpInfo ()
        {

            var localVarPath = "/api/config/ConfigGetSupportedOCRLanguages";
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
                Exception exception = ExceptionFactory("ConfigGetSupportedOCRLanguages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StringArrayResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (StringArrayResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StringArrayResponse)));
        }

        /// <summary>
        /// Gets the list of supported languages for OCR. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of StringArrayResponse</returns>
        public async System.Threading.Tasks.Task<StringArrayResponse> ConfigGetSupportedOCRLanguagesAsync ()
        {
             ApiResponse<StringArrayResponse> localVarResponse = await ConfigGetSupportedOCRLanguagesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets the list of supported languages for OCR. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (StringArrayResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StringArrayResponse>> ConfigGetSupportedOCRLanguagesAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/config/ConfigGetSupportedOCRLanguages";
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
                Exception exception = ExceptionFactory("ConfigGetSupportedOCRLanguages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StringArrayResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (StringArrayResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StringArrayResponse)));
        }

    }
}
