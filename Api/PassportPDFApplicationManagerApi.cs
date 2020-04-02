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
    public interface IPassportPDFApplicationManagerApiSync
    {

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>StringResponse</returns>
        StringResponse PassportPDFApplicationManagerGetApplicationDownloadLink(string applicationId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>StringResponse</returns>
        StringResponse PassportPDFApplicationManagerGetApplicationLatestVersion(string applicationId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>StringResponse</returns>
        StringResponse PassportPDFApplicationManagerGetApplicationMinimumSupportedVersion(string applicationId);

        /// <summary>
        /// Gets the maximum number of threads to be used simultaneously by a client application.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>IntegerResponse</returns>
        IntegerResponse PassportPDFApplicationManagerGetMaxClientThreads(string applicationId);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPassportPDFApplicationManagerApiAsync
    {

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>Task of StringResponse</returns>
        Task<StringResponse> PassportPDFApplicationManagerGetApplicationDownloadLinkAsync(string applicationId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>Task of StringResponse</returns>
        Task<StringResponse> PassportPDFApplicationManagerGetApplicationLatestVersionAsync(string applicationId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>Task of StringResponse</returns>
        Task<StringResponse> PassportPDFApplicationManagerGetApplicationMinimumSupportedVersionAsync(string applicationId);

        /// <summary>
        /// Gets the maximum number of threads to be used simultaneously by a client application.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>Task of IntegerResponse</returns>
        Task<IntegerResponse> PassportPDFApplicationManagerGetMaxClientThreadsAsync(string applicationId);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPassportPDFApplicationManagerApi : IPassportPDFApplicationManagerApiSync, IPassportPDFApplicationManagerApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed class PassportPDFApplicationManagerApi : IPassportPDFApplicationManagerApi
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
        /// Initializes a new instance of the <see cref="PassportPDFApplicationManagerApi"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        public PassportPDFApplicationManagerApi(string apiKey = "")
        {
            ApiKey = apiKey;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>IRestResponse of StringResponse</returns>
        public StringResponse PassportPDFApplicationManagerGetApplicationDownloadLink(string applicationId)
        {
            // verify the required parameter 'applicationId' is set
            if (applicationId == null)
                throw new ArgumentNullException("Missing required parameter 'applicationId' when calling PassportPDFApplicationManagerApi->PassportPDFApplicationManagerGetApplicationDownloadLink");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] {  };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            if (applicationId != null)
            {
                foreach (var kvp in ClientUtils.ParameterToMultiMap("", "applicationId", applicationId))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.AddQueryParameter(kvp.Key, value);
                    }
                }
            }
            IRestResponse response = ApiClient.CallApi(Method.GET,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/passportpdfapplicationmanager/PassportPDFApplicationManagerGetApplicationDownloadLink",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/passportpdfapplicationmanager/PassportPDFApplicationManagerGetApplicationDownloadLink failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (StringResponse)ApiClient.DeserializeResponse(response, typeof(StringResponse));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>Task of IRestResponse (StringResponse)</returns>
        public async Task<StringResponse> PassportPDFApplicationManagerGetApplicationDownloadLinkAsync(string applicationId)
        {
            // verify the required parameter 'applicationId' is set
            if (applicationId == null)
                throw new ArgumentNullException("Missing required parameter 'applicationId' when calling PassportPDFApplicationManagerApi->PassportPDFApplicationManagerGetApplicationDownloadLink");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] {  };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            if (applicationId != null)
            {
                foreach (var kvp in ClientUtils.ParameterToMultiMap("", "applicationId", applicationId))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.AddQueryParameter(kvp.Key, value);
                    }
                }
            }

            IRestResponse response = await ApiClient.CallApiAsync(Method.GET,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/passportpdfapplicationmanager/PassportPDFApplicationManagerGetApplicationDownloadLink",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/passportpdfapplicationmanager/PassportPDFApplicationManagerGetApplicationDownloadLink failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (StringResponse)ApiClient.DeserializeResponse(response, typeof(StringResponse));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>IRestResponse of StringResponse</returns>
        public StringResponse PassportPDFApplicationManagerGetApplicationLatestVersion(string applicationId)
        {
            // verify the required parameter 'applicationId' is set
            if (applicationId == null)
                throw new ArgumentNullException("Missing required parameter 'applicationId' when calling PassportPDFApplicationManagerApi->PassportPDFApplicationManagerGetApplicationLatestVersion");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] {  };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            if (applicationId != null)
            {
                foreach (var kvp in ClientUtils.ParameterToMultiMap("", "applicationId", applicationId))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.AddQueryParameter(kvp.Key, value);
                    }
                }
            }
            IRestResponse response = ApiClient.CallApi(Method.GET,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/passportpdfapplicationmanager/PassportPDFApplicationManagerGetApplicationLatestVersion",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/passportpdfapplicationmanager/PassportPDFApplicationManagerGetApplicationLatestVersion failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (StringResponse)ApiClient.DeserializeResponse(response, typeof(StringResponse));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>Task of IRestResponse (StringResponse)</returns>
        public async Task<StringResponse> PassportPDFApplicationManagerGetApplicationLatestVersionAsync(string applicationId)
        {
            // verify the required parameter 'applicationId' is set
            if (applicationId == null)
                throw new ArgumentNullException("Missing required parameter 'applicationId' when calling PassportPDFApplicationManagerApi->PassportPDFApplicationManagerGetApplicationLatestVersion");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] {  };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            if (applicationId != null)
            {
                foreach (var kvp in ClientUtils.ParameterToMultiMap("", "applicationId", applicationId))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.AddQueryParameter(kvp.Key, value);
                    }
                }
            }

            IRestResponse response = await ApiClient.CallApiAsync(Method.GET,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/passportpdfapplicationmanager/PassportPDFApplicationManagerGetApplicationLatestVersion",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/passportpdfapplicationmanager/PassportPDFApplicationManagerGetApplicationLatestVersion failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (StringResponse)ApiClient.DeserializeResponse(response, typeof(StringResponse));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>IRestResponse of StringResponse</returns>
        public StringResponse PassportPDFApplicationManagerGetApplicationMinimumSupportedVersion(string applicationId)
        {
            // verify the required parameter 'applicationId' is set
            if (applicationId == null)
                throw new ArgumentNullException("Missing required parameter 'applicationId' when calling PassportPDFApplicationManagerApi->PassportPDFApplicationManagerGetApplicationMinimumSupportedVersion");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] {  };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            if (applicationId != null)
            {
                foreach (var kvp in ClientUtils.ParameterToMultiMap("", "applicationId", applicationId))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.AddQueryParameter(kvp.Key, value);
                    }
                }
            }
            IRestResponse response = ApiClient.CallApi(Method.GET,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/passportpdfapplicationmanager/PassportPDFApplicationManagerGetApplicationMinimumSupportedVersion",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/passportpdfapplicationmanager/PassportPDFApplicationManagerGetApplicationMinimumSupportedVersion failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (StringResponse)ApiClient.DeserializeResponse(response, typeof(StringResponse));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>Task of IRestResponse (StringResponse)</returns>
        public async Task<StringResponse> PassportPDFApplicationManagerGetApplicationMinimumSupportedVersionAsync(string applicationId)
        {
            // verify the required parameter 'applicationId' is set
            if (applicationId == null)
                throw new ArgumentNullException("Missing required parameter 'applicationId' when calling PassportPDFApplicationManagerApi->PassportPDFApplicationManagerGetApplicationMinimumSupportedVersion");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] {  };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            if (applicationId != null)
            {
                foreach (var kvp in ClientUtils.ParameterToMultiMap("", "applicationId", applicationId))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.AddQueryParameter(kvp.Key, value);
                    }
                }
            }

            IRestResponse response = await ApiClient.CallApiAsync(Method.GET,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/passportpdfapplicationmanager/PassportPDFApplicationManagerGetApplicationMinimumSupportedVersion",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/passportpdfapplicationmanager/PassportPDFApplicationManagerGetApplicationMinimumSupportedVersion failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (StringResponse)ApiClient.DeserializeResponse(response, typeof(StringResponse));
        }

        /// <summary>
        /// Gets the maximum number of threads to be used simultaneously by a client application. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>IRestResponse of IntegerResponse</returns>
        public IntegerResponse PassportPDFApplicationManagerGetMaxClientThreads(string applicationId)
        {
            // verify the required parameter 'applicationId' is set
            if (applicationId == null)
                throw new ArgumentNullException("Missing required parameter 'applicationId' when calling PassportPDFApplicationManagerApi->PassportPDFApplicationManagerGetMaxClientThreads");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] {  };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            if (applicationId != null)
            {
                foreach (var kvp in ClientUtils.ParameterToMultiMap("", "applicationId", applicationId))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.AddQueryParameter(kvp.Key, value);
                    }
                }
            }
            IRestResponse response = ApiClient.CallApi(Method.GET,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/passportpdfapplicationmanager/PassportPDFApplicationManagerGetMaxClientThreads",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/passportpdfapplicationmanager/PassportPDFApplicationManagerGetMaxClientThreads failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (IntegerResponse)ApiClient.DeserializeResponse(response, typeof(IntegerResponse));
        }

        /// <summary>
        /// Gets the maximum number of threads to be used simultaneously by a client application. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"></param>
        /// <returns>Task of IRestResponse (IntegerResponse)</returns>
        public async Task<IntegerResponse> PassportPDFApplicationManagerGetMaxClientThreadsAsync(string applicationId)
        {
            // verify the required parameter 'applicationId' is set
            if (applicationId == null)
                throw new ArgumentNullException("Missing required parameter 'applicationId' when calling PassportPDFApplicationManagerApi->PassportPDFApplicationManagerGetMaxClientThreads");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] {  };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            if (applicationId != null)
            {
                foreach (var kvp in ClientUtils.ParameterToMultiMap("", "applicationId", applicationId))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.AddQueryParameter(kvp.Key, value);
                    }
                }
            }

            IRestResponse response = await ApiClient.CallApiAsync(Method.GET,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/passportpdfapplicationmanager/PassportPDFApplicationManagerGetMaxClientThreads",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/passportpdfapplicationmanager/PassportPDFApplicationManagerGetMaxClientThreads failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (IntegerResponse)ApiClient.DeserializeResponse(response, typeof(IntegerResponse));
        }
    }
}
