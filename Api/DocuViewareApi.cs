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
    public interface IDocuViewareApiSync
    {

        /// <summary>
        /// Gets the HTML dom of a DocuVieware control.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="docuViewareGetControlParameters">A DocuViewareGetControlParameters object specifying the parameters of the action.</param>
        /// <returns>DocuViewareGetControlResponse</returns>
        DocuViewareGetControlResponse DocuViewareGetControl(DocuViewareGetControlParameters docuViewareGetControlParameters);

        /// <summary>
        /// Get the DocuVieware engine version.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>StringResponse</returns>
        StringResponse DocuViewareGetVersion();

        /// <summary>
        /// Saves the document being handled by a specific DocuVieware control, in its current state.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="docuViewareSaveParameters">A DocuViewareSaveParameters object specifying the parameters of the action.</param>
        /// <returns>DocuViewareSaveResponse</returns>
        DocuViewareSaveResponse DocuViewareSave(DocuViewareSaveParameters docuViewareSaveParameters);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDocuViewareApiAsync
    {

        /// <summary>
        /// Gets the HTML dom of a DocuVieware control.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="docuViewareGetControlParameters">A DocuViewareGetControlParameters object specifying the parameters of the action.</param>
        /// <returns>Task of DocuViewareGetControlResponse</returns>
        Task<DocuViewareGetControlResponse> DocuViewareGetControlAsync(DocuViewareGetControlParameters docuViewareGetControlParameters);

        /// <summary>
        /// Get the DocuVieware engine version.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of StringResponse</returns>
        Task<StringResponse> DocuViewareGetVersionAsync();

        /// <summary>
        /// Saves the document being handled by a specific DocuVieware control, in its current state.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="docuViewareSaveParameters">A DocuViewareSaveParameters object specifying the parameters of the action.</param>
        /// <returns>Task of DocuViewareSaveResponse</returns>
        Task<DocuViewareSaveResponse> DocuViewareSaveAsync(DocuViewareSaveParameters docuViewareSaveParameters);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDocuViewareApi : IDocuViewareApiSync, IDocuViewareApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed class DocuViewareApi : IDocuViewareApi
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
        /// Initializes a new instance of the <see cref="DocuViewareApi"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        public DocuViewareApi(string apiKey = "")
        {
            ApiKey = apiKey;
        }

        /// <summary>
        /// Gets the HTML dom of a DocuVieware control. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="docuViewareGetControlParameters">A DocuViewareGetControlParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of DocuViewareGetControlResponse</returns>
        public DocuViewareGetControlResponse DocuViewareGetControl(DocuViewareGetControlParameters docuViewareGetControlParameters)
        {
            // verify the required parameter 'docuViewareGetControlParameters' is set
            if (docuViewareGetControlParameters == null)
                throw new ArgumentNullException("Missing required parameter 'docuViewareGetControlParameters' when calling DocuViewareApi->DocuViewareGetControl");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = docuViewareGetControlParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/docuvieware/DocuViewareGetControl",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/docuvieware/DocuViewareGetControl failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (DocuViewareGetControlResponse)ApiClient.DeserializeResponse(response, typeof(DocuViewareGetControlResponse));
        }

        /// <summary>
        /// Gets the HTML dom of a DocuVieware control. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="docuViewareGetControlParameters">A DocuViewareGetControlParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (DocuViewareGetControlResponse)</returns>
        public async Task<DocuViewareGetControlResponse> DocuViewareGetControlAsync(DocuViewareGetControlParameters docuViewareGetControlParameters)
        {
            // verify the required parameter 'docuViewareGetControlParameters' is set
            if (docuViewareGetControlParameters == null)
                throw new ArgumentNullException("Missing required parameter 'docuViewareGetControlParameters' when calling DocuViewareApi->DocuViewareGetControl");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = docuViewareGetControlParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/docuvieware/DocuViewareGetControl",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/docuvieware/DocuViewareGetControl failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (DocuViewareGetControlResponse)ApiClient.DeserializeResponse(response, typeof(DocuViewareGetControlResponse));
        }

        /// <summary>
        /// Get the DocuVieware engine version. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>IRestResponse of StringResponse</returns>
        public StringResponse DocuViewareGetVersion()
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
             "/api/docuvieware/DocuViewareGetVersion",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/docuvieware/DocuViewareGetVersion failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (StringResponse)ApiClient.DeserializeResponse(response, typeof(StringResponse));
        }

        /// <summary>
        /// Get the DocuVieware engine version. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of IRestResponse (StringResponse)</returns>
        public async Task<StringResponse> DocuViewareGetVersionAsync()
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
            "/api/docuvieware/DocuViewareGetVersion",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/docuvieware/DocuViewareGetVersion failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (StringResponse)ApiClient.DeserializeResponse(response, typeof(StringResponse));
        }

        /// <summary>
        /// Saves the document being handled by a specific DocuVieware control, in its current state. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="docuViewareSaveParameters">A DocuViewareSaveParameters object specifying the parameters of the action.</param>
        /// <returns>IRestResponse of DocuViewareSaveResponse</returns>
        public DocuViewareSaveResponse DocuViewareSave(DocuViewareSaveParameters docuViewareSaveParameters)
        {
            // verify the required parameter 'docuViewareSaveParameters' is set
            if (docuViewareSaveParameters == null)
                throw new ArgumentNullException("Missing required parameter 'docuViewareSaveParameters' when calling DocuViewareApi->DocuViewareSave");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            requestOptions.Data = docuViewareSaveParameters;
            IRestResponse response = ApiClient.CallApi(Method.POST,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/docuvieware/DocuViewareSave",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/docuvieware/DocuViewareSave failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (DocuViewareSaveResponse)ApiClient.DeserializeResponse(response, typeof(DocuViewareSaveResponse));
        }

        /// <summary>
        /// Saves the document being handled by a specific DocuVieware control, in its current state. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="docuViewareSaveParameters">A DocuViewareSaveParameters object specifying the parameters of the action.</param>
        /// <returns>Task of IRestResponse (DocuViewareSaveResponse)</returns>
        public async Task<DocuViewareSaveResponse> DocuViewareSaveAsync(DocuViewareSaveParameters docuViewareSaveParameters)
        {
            // verify the required parameter 'docuViewareSaveParameters' is set
            if (docuViewareSaveParameters == null)
                throw new ArgumentNullException("Missing required parameter 'docuViewareSaveParameters' when calling DocuViewareApi->DocuViewareSave");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] { "application/json-patch+json", "application/json", "text/json", "application/_*+json" };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            requestOptions.Data = docuViewareSaveParameters;

            IRestResponse response = await ApiClient.CallApiAsync(Method.POST,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/docuvieware/DocuViewareSave",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/docuvieware/DocuViewareSave failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (DocuViewareSaveResponse)ApiClient.DeserializeResponse(response, typeof(DocuViewareSaveResponse));
        }
    }
}
