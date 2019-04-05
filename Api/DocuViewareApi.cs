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
    public interface IDocuViewareApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getControlParameters"></param>
        /// <returns>DocuViewareGetControlResponse</returns>
        DocuViewareGetControlResponse DocuViewareGetControl (DocuViewareGetControlParameters getControlParameters);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getControlParameters"></param>
        /// <returns>ApiResponse of DocuViewareGetControlResponse</returns>
        ApiResponse<DocuViewareGetControlResponse> DocuViewareGetControlWithHttpInfo (DocuViewareGetControlParameters getControlParameters);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>StringResponse</returns>
        StringResponse DocuViewareGetVersion ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of StringResponse</returns>
        ApiResponse<StringResponse> DocuViewareGetVersionWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveParameters"></param>
        /// <returns>DocuViewareSaveResponse</returns>
        DocuViewareSaveResponse DocuViewareSave (DocuViewareSaveParameters saveParameters);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveParameters"></param>
        /// <returns>ApiResponse of DocuViewareSaveResponse</returns>
        ApiResponse<DocuViewareSaveResponse> DocuViewareSaveWithHttpInfo (DocuViewareSaveParameters saveParameters);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getControlParameters"></param>
        /// <returns>Task of DocuViewareGetControlResponse</returns>
        System.Threading.Tasks.Task<DocuViewareGetControlResponse> DocuViewareGetControlAsync (DocuViewareGetControlParameters getControlParameters);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getControlParameters"></param>
        /// <returns>Task of ApiResponse (DocuViewareGetControlResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocuViewareGetControlResponse>> DocuViewareGetControlAsyncWithHttpInfo (DocuViewareGetControlParameters getControlParameters);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of StringResponse</returns>
        System.Threading.Tasks.Task<StringResponse> DocuViewareGetVersionAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (StringResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StringResponse>> DocuViewareGetVersionAsyncWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveParameters"></param>
        /// <returns>Task of DocuViewareSaveResponse</returns>
        System.Threading.Tasks.Task<DocuViewareSaveResponse> DocuViewareSaveAsync (DocuViewareSaveParameters saveParameters);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveParameters"></param>
        /// <returns>Task of ApiResponse (DocuViewareSaveResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocuViewareSaveResponse>> DocuViewareSaveAsyncWithHttpInfo (DocuViewareSaveParameters saveParameters);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DocuViewareApi : IDocuViewareApi
    {
        private PassportPDF.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DocuViewareApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DocuViewareApi(String basePath)
        {
            this.Configuration = new PassportPDF.Client.Configuration { BasePath = basePath };

            ExceptionFactory = PassportPDF.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocuViewareApi"/> class
        /// </summary>
        /// <returns></returns>
        public DocuViewareApi()
        {
            this.Configuration = PassportPDF.Client.Configuration.Default;

            ExceptionFactory = PassportPDF.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocuViewareApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DocuViewareApi(PassportPDF.Client.Configuration configuration = null)
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
        /// <param name="getControlParameters"></param>
        /// <returns>DocuViewareGetControlResponse</returns>
        public DocuViewareGetControlResponse DocuViewareGetControl (DocuViewareGetControlParameters getControlParameters)
        {
             ApiResponse<DocuViewareGetControlResponse> localVarResponse = DocuViewareGetControlWithHttpInfo(getControlParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getControlParameters"></param>
        /// <returns>ApiResponse of DocuViewareGetControlResponse</returns>
        public ApiResponse< DocuViewareGetControlResponse > DocuViewareGetControlWithHttpInfo (DocuViewareGetControlParameters getControlParameters)
        {
            // verify the required parameter 'getControlParameters' is set
            if (getControlParameters == null)
                throw new ApiException(400, "Missing required parameter 'getControlParameters' when calling DocuViewareApi->DocuViewareGetControl");

            var localVarPath = "/api/docuvieware/DocuViewareGetControl";
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

            if (getControlParameters != null && getControlParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(getControlParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = getControlParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DocuViewareGetControl", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocuViewareGetControlResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (DocuViewareGetControlResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocuViewareGetControlResponse)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getControlParameters"></param>
        /// <returns>Task of DocuViewareGetControlResponse</returns>
        public async System.Threading.Tasks.Task<DocuViewareGetControlResponse> DocuViewareGetControlAsync (DocuViewareGetControlParameters getControlParameters)
        {
             ApiResponse<DocuViewareGetControlResponse> localVarResponse = await DocuViewareGetControlAsyncWithHttpInfo(getControlParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getControlParameters"></param>
        /// <returns>Task of ApiResponse (DocuViewareGetControlResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocuViewareGetControlResponse>> DocuViewareGetControlAsyncWithHttpInfo (DocuViewareGetControlParameters getControlParameters)
        {
            // verify the required parameter 'getControlParameters' is set
            if (getControlParameters == null)
                throw new ApiException(400, "Missing required parameter 'getControlParameters' when calling DocuViewareApi->DocuViewareGetControl");

            var localVarPath = "/api/docuvieware/DocuViewareGetControl";
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

            if (getControlParameters != null && getControlParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(getControlParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = getControlParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DocuViewareGetControl", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocuViewareGetControlResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (DocuViewareGetControlResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocuViewareGetControlResponse)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>StringResponse</returns>
        public StringResponse DocuViewareGetVersion ()
        {
             ApiResponse<StringResponse> localVarResponse = DocuViewareGetVersionWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of StringResponse</returns>
        public ApiResponse< StringResponse > DocuViewareGetVersionWithHttpInfo ()
        {

            var localVarPath = "/api/docuvieware/DocuViewareGetVersion";
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
                Exception exception = ExceptionFactory("DocuViewareGetVersion", localVarResponse);
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
        /// <returns>Task of StringResponse</returns>
        public async System.Threading.Tasks.Task<StringResponse> DocuViewareGetVersionAsync ()
        {
             ApiResponse<StringResponse> localVarResponse = await DocuViewareGetVersionAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (StringResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StringResponse>> DocuViewareGetVersionAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/docuvieware/DocuViewareGetVersion";
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
                Exception exception = ExceptionFactory("DocuViewareGetVersion", localVarResponse);
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
        /// <param name="saveParameters"></param>
        /// <returns>DocuViewareSaveResponse</returns>
        public DocuViewareSaveResponse DocuViewareSave (DocuViewareSaveParameters saveParameters)
        {
             ApiResponse<DocuViewareSaveResponse> localVarResponse = DocuViewareSaveWithHttpInfo(saveParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveParameters"></param>
        /// <returns>ApiResponse of DocuViewareSaveResponse</returns>
        public ApiResponse< DocuViewareSaveResponse > DocuViewareSaveWithHttpInfo (DocuViewareSaveParameters saveParameters)
        {
            // verify the required parameter 'saveParameters' is set
            if (saveParameters == null)
                throw new ApiException(400, "Missing required parameter 'saveParameters' when calling DocuViewareApi->DocuViewareSave");

            var localVarPath = "/api/docuvieware/DocuViewareSave";
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

            if (saveParameters != null && saveParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(saveParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = saveParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DocuViewareSave", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocuViewareSaveResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (DocuViewareSaveResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocuViewareSaveResponse)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveParameters"></param>
        /// <returns>Task of DocuViewareSaveResponse</returns>
        public async System.Threading.Tasks.Task<DocuViewareSaveResponse> DocuViewareSaveAsync (DocuViewareSaveParameters saveParameters)
        {
             ApiResponse<DocuViewareSaveResponse> localVarResponse = await DocuViewareSaveAsyncWithHttpInfo(saveParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveParameters"></param>
        /// <returns>Task of ApiResponse (DocuViewareSaveResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocuViewareSaveResponse>> DocuViewareSaveAsyncWithHttpInfo (DocuViewareSaveParameters saveParameters)
        {
            // verify the required parameter 'saveParameters' is set
            if (saveParameters == null)
                throw new ApiException(400, "Missing required parameter 'saveParameters' when calling DocuViewareApi->DocuViewareSave");

            var localVarPath = "/api/docuvieware/DocuViewareSave";
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

            if (saveParameters != null && saveParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(saveParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = saveParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DocuViewareSave", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocuViewareSaveResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (DocuViewareSaveResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocuViewareSaveResponse)));
        }

    }
}
