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
        DocuViewareGetControlResponse GetControl (DocuViewareGetControlParameters getControlParameters);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getControlParameters"></param>
        /// <returns>ApiResponse of DocuViewareGetControlResponse</returns>
        ApiResponse<DocuViewareGetControlResponse> GetControlWithHttpInfo (DocuViewareGetControlParameters getControlParameters);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>StringResponse</returns>
        StringResponse GetVersion ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of StringResponse</returns>
        ApiResponse<StringResponse> GetVersionWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveParameters"></param>
        /// <returns>DocuViewareSaveResponse</returns>
        DocuViewareSaveResponse Save (DocuViewareSaveParameters saveParameters);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveParameters"></param>
        /// <returns>ApiResponse of DocuViewareSaveResponse</returns>
        ApiResponse<DocuViewareSaveResponse> SaveWithHttpInfo (DocuViewareSaveParameters saveParameters);
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
        System.Threading.Tasks.Task<DocuViewareGetControlResponse> GetControlAsync (DocuViewareGetControlParameters getControlParameters);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getControlParameters"></param>
        /// <returns>Task of ApiResponse (DocuViewareGetControlResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocuViewareGetControlResponse>> GetControlAsyncWithHttpInfo (DocuViewareGetControlParameters getControlParameters);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of StringResponse</returns>
        System.Threading.Tasks.Task<StringResponse> GetVersionAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (StringResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StringResponse>> GetVersionAsyncWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveParameters"></param>
        /// <returns>Task of DocuViewareSaveResponse</returns>
        System.Threading.Tasks.Task<DocuViewareSaveResponse> SaveAsync (DocuViewareSaveParameters saveParameters);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveParameters"></param>
        /// <returns>Task of ApiResponse (DocuViewareSaveResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocuViewareSaveResponse>> SaveAsyncWithHttpInfo (DocuViewareSaveParameters saveParameters);
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
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = PassportPDF.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocuViewareApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DocuViewareApi(Configuration configuration = null)
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
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getControlParameters"></param>
        /// <returns>DocuViewareGetControlResponse</returns>
        public DocuViewareGetControlResponse GetControl (DocuViewareGetControlParameters getControlParameters)
        {
             ApiResponse<DocuViewareGetControlResponse> localVarResponse = GetControlWithHttpInfo(getControlParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getControlParameters"></param>
        /// <returns>ApiResponse of DocuViewareGetControlResponse</returns>
        public ApiResponse< DocuViewareGetControlResponse > GetControlWithHttpInfo (DocuViewareGetControlParameters getControlParameters)
        {
            // verify the required parameter 'getControlParameters' is set
            if (getControlParameters == null)
                throw new ApiException(400, "Missing required parameter 'getControlParameters' when calling DocuViewareApi->GetControl");

            var localVarPath = "/api/docuvieware/GetControl";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
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

            if (getControlParameters != null && getControlParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(getControlParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = getControlParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetControl", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocuViewareGetControlResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocuViewareGetControlResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocuViewareGetControlResponse)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getControlParameters"></param>
        /// <returns>Task of DocuViewareGetControlResponse</returns>
        public async System.Threading.Tasks.Task<DocuViewareGetControlResponse> GetControlAsync (DocuViewareGetControlParameters getControlParameters)
        {
             ApiResponse<DocuViewareGetControlResponse> localVarResponse = await GetControlAsyncWithHttpInfo(getControlParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getControlParameters"></param>
        /// <returns>Task of ApiResponse (DocuViewareGetControlResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocuViewareGetControlResponse>> GetControlAsyncWithHttpInfo (DocuViewareGetControlParameters getControlParameters)
        {
            // verify the required parameter 'getControlParameters' is set
            if (getControlParameters == null)
                throw new ApiException(400, "Missing required parameter 'getControlParameters' when calling DocuViewareApi->GetControl");

            var localVarPath = "/api/docuvieware/GetControl";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
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

            if (getControlParameters != null && getControlParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(getControlParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = getControlParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetControl", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocuViewareGetControlResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocuViewareGetControlResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocuViewareGetControlResponse)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>StringResponse</returns>
        public StringResponse GetVersion ()
        {
             ApiResponse<StringResponse> localVarResponse = GetVersionWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of StringResponse</returns>
        public ApiResponse< StringResponse > GetVersionWithHttpInfo ()
        {

            var localVarPath = "/api/docuvieware/GetVersion";
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
                Exception exception = ExceptionFactory("GetVersion", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StringResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StringResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StringResponse)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of StringResponse</returns>
        public async System.Threading.Tasks.Task<StringResponse> GetVersionAsync ()
        {
             ApiResponse<StringResponse> localVarResponse = await GetVersionAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (StringResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StringResponse>> GetVersionAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/docuvieware/GetVersion";
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
                Exception exception = ExceptionFactory("GetVersion", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StringResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StringResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StringResponse)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveParameters"></param>
        /// <returns>DocuViewareSaveResponse</returns>
        public DocuViewareSaveResponse Save (DocuViewareSaveParameters saveParameters)
        {
             ApiResponse<DocuViewareSaveResponse> localVarResponse = SaveWithHttpInfo(saveParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveParameters"></param>
        /// <returns>ApiResponse of DocuViewareSaveResponse</returns>
        public ApiResponse< DocuViewareSaveResponse > SaveWithHttpInfo (DocuViewareSaveParameters saveParameters)
        {
            // verify the required parameter 'saveParameters' is set
            if (saveParameters == null)
                throw new ApiException(400, "Missing required parameter 'saveParameters' when calling DocuViewareApi->Save");

            var localVarPath = "/api/docuvieware/Save";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
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

            if (saveParameters != null && saveParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(saveParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = saveParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Save", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocuViewareSaveResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocuViewareSaveResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocuViewareSaveResponse)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveParameters"></param>
        /// <returns>Task of DocuViewareSaveResponse</returns>
        public async System.Threading.Tasks.Task<DocuViewareSaveResponse> SaveAsync (DocuViewareSaveParameters saveParameters)
        {
             ApiResponse<DocuViewareSaveResponse> localVarResponse = await SaveAsyncWithHttpInfo(saveParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveParameters"></param>
        /// <returns>Task of ApiResponse (DocuViewareSaveResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocuViewareSaveResponse>> SaveAsyncWithHttpInfo (DocuViewareSaveParameters saveParameters)
        {
            // verify the required parameter 'saveParameters' is set
            if (saveParameters == null)
                throw new ApiException(400, "Missing required parameter 'saveParameters' when calling DocuViewareApi->Save");

            var localVarPath = "/api/docuvieware/Save";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
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

            if (saveParameters != null && saveParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(saveParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = saveParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Save", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocuViewareSaveResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocuViewareSaveResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocuViewareSaveResponse)));
        }

    }
}
