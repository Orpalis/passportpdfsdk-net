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
    public interface IPassportManagerApiSync
    {

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="passportId"></param>
        /// <returns>PassportPDFPassport</returns>
        PassportPDFPassport PassportManagerGetPassportInfo(string passportId);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPassportManagerApiAsync
    {

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="passportId"></param>
        /// <returns>Task of PassportPDFPassport</returns>
        Task<PassportPDFPassport> PassportManagerGetPassportInfoAsync(string passportId);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPassportManagerApi : IPassportManagerApiSync, IPassportManagerApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed class PassportManagerApi : IPassportManagerApi
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
        /// Initializes a new instance of the <see cref="PassportManagerApi"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        public PassportManagerApi(string apiKey = "")
        {
            ApiKey = apiKey;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="passportId"></param>
        /// <returns>IRestResponse of PassportPDFPassport</returns>
        public PassportPDFPassport PassportManagerGetPassportInfo(string passportId)
        {
            // verify the required parameter 'passportId' is set
            if (passportId == null)
                throw new ArgumentNullException("Missing required parameter 'passportId' when calling PassportManagerApi->PassportManagerGetPassportInfo");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] {  };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null)
              requestOptions.AddHeaderParameter("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null)
              requestOptions.AddHeaderParameter("Accept", localVarAccept);

            if (passportId != null)
            {
                foreach (var kvp in ClientUtils.ParameterToMultiMap("", "passportId", passportId))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.AddQueryParameter(kvp.Key, value);
                    }
                }
            }
            IRestResponse response = ApiClient.CallApi(Method.GET,
             !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
             "/api/passportmanager/PassportManagerGetPassportInfo",
              !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
               requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/passportmanager/PassportManagerGetPassportInfo failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PassportPDFPassport)ApiClient.DeserializeResponse(response, typeof(PassportPDFPassport));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="passportId"></param>
        /// <returns>Task of IRestResponse (PassportPDFPassport)</returns>
        public async Task<PassportPDFPassport> PassportManagerGetPassportInfoAsync(string passportId)
        {
            // verify the required parameter 'passportId' is set
            if (passportId == null)
                throw new ArgumentNullException("Missing required parameter 'passportId' when calling PassportManagerApi->PassportManagerGetPassportInfo");

            RequestOptions requestOptions = new RequestOptions();

            string[] contentTypes = new string[] {  };
            string[] accepts = new string[] { "text/plain","application/json","text/json" };

            foreach (var contentType in contentTypes)
                requestOptions.AddHeaderParameter("Content-Type", contentType);

            foreach (var accept in accepts)
                requestOptions.AddHeaderParameter("Accept", accept);

            if (passportId != null)
            {
                foreach (var kvp in ClientUtils.ParameterToMultiMap("", "passportId", passportId))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.AddQueryParameter(kvp.Key, value);
                    }
                }
            }

            IRestResponse response = await ApiClient.CallApiAsync(Method.GET,
            !string.IsNullOrEmpty(BasePath) ? BasePath : GlobalConfiguration.BasePath,
            "/api/passportmanager/PassportManagerGetPassportInfo",
            !string.IsNullOrEmpty(ApiKey) ? ApiKey : GlobalConfiguration.ApiKey,
            requestOptions);

            if (!response.IsSuccessful)
            {
                throw new ApiException(response.StatusCode, string.Format("API call to /api/passportmanager/PassportManagerGetPassportInfo failed: {0}", response.ErrorMessage, response.ErrorException));
            }

            return (PassportPDFPassport)ApiClient.DeserializeResponse(response, typeof(PassportPDFPassport));
        }
    }
}
