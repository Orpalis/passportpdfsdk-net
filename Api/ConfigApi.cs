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
    public interface IConfigApiSync
    {

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>string</returns>
        string ConfigGetAPIVersion();

        /// <summary>
        /// Gets the maximal length of a request content, in bytes.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>LongResponse</returns>
        LongResponse ConfigGetMaxAllowedContentLength();

        /// <summary>
        /// Gets the suggested client API timeout, in milliseconds.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>IntegerResponse</returns>
        IntegerResponse ConfigGetSuggestedClientTimeout();

        /// <summary>
        /// Gets the suggested maximum number of threads to be used simultaneously by a client application.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>IntegerResponse</returns>
        IntegerResponse ConfigGetSuggestedMaxClientThreads();

        /// <summary>
        /// Gets the list of supported fonts for text drawing operations.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Font&gt;</returns>
        List<Font> ConfigGetSupportedFonts();

        /// <summary>
        /// Gets the list of supported languages for OCR.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>StringArrayResponse</returns>
        StringArrayResponse ConfigGetSupportedOCRLanguages();
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConfigApiAsync
    {

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of string</returns>
        Task<string> ConfigGetAPIVersionAsync();

        /// <summary>
        /// Gets the maximal length of a request content, in bytes.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of LongResponse</returns>
        Task<LongResponse> ConfigGetMaxAllowedContentLengthAsync();

        /// <summary>
        /// Gets the suggested client API timeout, in milliseconds.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of IntegerResponse</returns>
        Task<IntegerResponse> ConfigGetSuggestedClientTimeoutAsync();

        /// <summary>
        /// Gets the suggested maximum number of threads to be used simultaneously by a client application.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of IntegerResponse</returns>
        Task<IntegerResponse> ConfigGetSuggestedMaxClientThreadsAsync();

        /// <summary>
        /// Gets the list of supported fonts for text drawing operations.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Font&gt;</returns>
        Task<List<Font>> ConfigGetSupportedFontsAsync();

        /// <summary>
        /// Gets the list of supported languages for OCR.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of StringArrayResponse</returns>
        Task<StringArrayResponse> ConfigGetSupportedOCRLanguagesAsync();
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConfigApi : IConfigApiSync, IConfigApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed class ConfigApi : IConfigApi
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
        /// Initializes a new instance of the <see cref="ConfigApi"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        public ConfigApi(string apiKey = "")
        {
            ApiKey = apiKey;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>IRestResponse of string</returns>
        public string ConfigGetAPIVersion()
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
             "/api/config/ConfigGetAPIVersion",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/config/ConfigGetAPIVersion failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (string)ApiClient.DeserializeResponse(response, typeof(string));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of IRestResponse (string)</returns>
        public async Task<string> ConfigGetAPIVersionAsync()
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
            "/api/config/ConfigGetAPIVersion",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/config/ConfigGetAPIVersion failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (string)ApiClient.DeserializeResponse(response, typeof(string));
        }

        /// <summary>
        /// Gets the maximal length of a request content, in bytes. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>IRestResponse of LongResponse</returns>
        public LongResponse ConfigGetMaxAllowedContentLength()
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
             "/api/config/ConfigGetMaxAllowedContentLength",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/config/ConfigGetMaxAllowedContentLength failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (LongResponse)ApiClient.DeserializeResponse(response, typeof(LongResponse));
        }

        /// <summary>
        /// Gets the maximal length of a request content, in bytes. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of IRestResponse (LongResponse)</returns>
        public async Task<LongResponse> ConfigGetMaxAllowedContentLengthAsync()
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
            "/api/config/ConfigGetMaxAllowedContentLength",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/config/ConfigGetMaxAllowedContentLength failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (LongResponse)ApiClient.DeserializeResponse(response, typeof(LongResponse));
        }

        /// <summary>
        /// Gets the suggested client API timeout, in milliseconds. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>IRestResponse of IntegerResponse</returns>
        public IntegerResponse ConfigGetSuggestedClientTimeout()
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
             "/api/config/ConfigGetSuggestedClientTimeout",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/config/ConfigGetSuggestedClientTimeout failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (IntegerResponse)ApiClient.DeserializeResponse(response, typeof(IntegerResponse));
        }

        /// <summary>
        /// Gets the suggested client API timeout, in milliseconds. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of IRestResponse (IntegerResponse)</returns>
        public async Task<IntegerResponse> ConfigGetSuggestedClientTimeoutAsync()
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
            "/api/config/ConfigGetSuggestedClientTimeout",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/config/ConfigGetSuggestedClientTimeout failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (IntegerResponse)ApiClient.DeserializeResponse(response, typeof(IntegerResponse));
        }

        /// <summary>
        /// Gets the suggested maximum number of threads to be used simultaneously by a client application. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>IRestResponse of IntegerResponse</returns>
        public IntegerResponse ConfigGetSuggestedMaxClientThreads()
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
             "/api/config/ConfigGetSuggestedMaxClientThreads",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/config/ConfigGetSuggestedMaxClientThreads failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (IntegerResponse)ApiClient.DeserializeResponse(response, typeof(IntegerResponse));
        }

        /// <summary>
        /// Gets the suggested maximum number of threads to be used simultaneously by a client application. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of IRestResponse (IntegerResponse)</returns>
        public async Task<IntegerResponse> ConfigGetSuggestedMaxClientThreadsAsync()
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
            "/api/config/ConfigGetSuggestedMaxClientThreads",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/config/ConfigGetSuggestedMaxClientThreads failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (IntegerResponse)ApiClient.DeserializeResponse(response, typeof(IntegerResponse));
        }

        /// <summary>
        /// Gets the list of supported fonts for text drawing operations. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>IRestResponse of List&lt;Font&gt;</returns>
        public List<Font> ConfigGetSupportedFonts()
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
             "/api/config/ConfigGetSupportedFonts",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/config/ConfigGetSupportedFonts failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (List<Font>)ApiClient.DeserializeResponse(response, typeof(List<Font>));
        }

        /// <summary>
        /// Gets the list of supported fonts for text drawing operations. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of IRestResponse (List&lt;Font&gt;)</returns>
        public async Task<List<Font>> ConfigGetSupportedFontsAsync()
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
            "/api/config/ConfigGetSupportedFonts",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/config/ConfigGetSupportedFonts failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (List<Font>)ApiClient.DeserializeResponse(response, typeof(List<Font>));
        }

        /// <summary>
        /// Gets the list of supported languages for OCR. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>IRestResponse of StringArrayResponse</returns>
        public StringArrayResponse ConfigGetSupportedOCRLanguages()
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
             "/api/config/ConfigGetSupportedOCRLanguages",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/config/ConfigGetSupportedOCRLanguages failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (StringArrayResponse)ApiClient.DeserializeResponse(response, typeof(StringArrayResponse));
        }

        /// <summary>
        /// Gets the list of supported languages for OCR. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of IRestResponse (StringArrayResponse)</returns>
        public async Task<StringArrayResponse> ConfigGetSupportedOCRLanguagesAsync()
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
            "/api/config/ConfigGetSupportedOCRLanguages",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/config/ConfigGetSupportedOCRLanguages failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (StringArrayResponse)ApiClient.DeserializeResponse(response, typeof(StringArrayResponse));
        }
    }
}
