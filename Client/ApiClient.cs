/* 
 * PassportPDF API
 *
 * Copyright © 2019 PassportPDF - https://www.passportpdf.com
 *
 */


using System;
using System.Globalization;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;

namespace PassportPDF.Client
{
    /// <summary>
    /// Provides a default implementation of an Api client (both synchronous and asynchronous implementatios) encapsulating general REST accessor use cases.
    /// </summary>
    internal sealed class ApiClient
    {
        /// <summary>
        /// Make a request to the API (async).
        /// </summary>
        /// <param name="baseUrl">The base URL of the API.</param>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <returns>A Task containing IRestResponse</returns>
        public static IRestResponse CallApi(Method method, string baseUrl, string path, string apiKey, RequestOptions options)
        {
            RestClient client = new RestClient(baseUrl)
            {
                Timeout = GlobalConfiguration.Timeout
            };

            if (GlobalConfiguration.Instance.UserAgent != null)
            {
                client.UserAgent = GlobalConfiguration.Instance.UserAgent;
            }

            RestRequest request;

            try
            {
                request = CreateRequest(method, path, options, apiKey);
            }
            catch (Exception exception)
            {
                throw new ApiException(string.Format("Error while preparing request for {0}", path), exception);
            }

            try
            {
                return client.Execute(request);
            }
            catch (Exception exception)
            {
                throw new ApiException(string.Format("Error while executing the request for {0}", path), exception);
            }
        }

        /// <summary>
        /// <summary>
        /// Make a request to the API (async).
        /// </summary>
        /// <param name="baseUrl"/>The base URL of the API. </param>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <returns>A Task containing IRestResponse</returns>
        public static async Task<IRestResponse> CallApiAsync(Method method, string baseUrl, string path, string apiKey, RequestOptions options)
        {
            RestClient client = new RestClient(baseUrl)
            {
                Timeout = GlobalConfiguration.Instance.Timeout
            };

            if (GlobalConfiguration.Instance.UserAgent != null)
            {
                client.UserAgent = GlobalConfiguration.Instance.UserAgent;
            }

            RestRequest request;

            try
            {
                request = CreateRequest(method, path, options, apiKey);
            }
            catch (Exception exception)
            {
                throw new ApiException(string.Format("Error while preparing request for {0}", path), exception);
            }

            try
            {
                return await client.ExecuteTaskAsync(request);
            }
            catch (Exception exception)
            {
                throw new ApiException(string.Format("Error while executing the request for {0}", path), exception);
            }
        }

        /// <summary>
        /// Deserialize the JSON string into a proper object.
        /// </summary>
        /// <param name="response">The HTTP response.</param>
        /// <param name="type">Object type.</param>
        /// <returns>Object representation of the JSON string.</returns>
        internal static object DeserializeResponse(IRestResponse response, Type type)
        {
            if (type == typeof(byte[])) // return byte array
            {
                return response.RawBytes;
            }

            if (type.Name.StartsWith("System.Nullable`1[[System.DateTime")) // return a datetime object
            {
                return DateTime.Parse(response.Content, null, DateTimeStyles.RoundtripKind);
            }

            if (type == typeof(string) || type.Name.StartsWith("System.Nullable")) // return primitive type
            {
                return Convert.ChangeType(response.Content, type);
            }

            // at this point, it must be a model (json)
            JsonSerializerSettings serializerSettings = new JsonSerializerSettings()
            {
                ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                    {
                        OverrideSpecifiedNames = true
                    }
                }
            };

            try
            {
                return JsonConvert.DeserializeObject(response.Content, type, serializerSettings);
            }
            catch (Exception exception)
            {
                throw new ApiException("Error while deserializing the response from the server", exception);
            }
        }

        /// <summary>
        /// Provides all logic for constructing a new RestSharp <see cref="RestRequest"/>.
        /// At this point, all information for querying the service is known. Here, it is simply mapped into the RestSharp request.
        /// </summary>
        /// <param name="method">The http verb.</param>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="apiKey">The API key.</param>
        /// <exception cref="ArgumentNullException"></exception>
        private static RestRequest CreateRequest(Method method, string path, RequestOptions options, string apiKey)
        {
            if (path == null) throw new ArgumentNullException("path");
            if (options == null) throw new ArgumentNullException("options");

            RestRequest request = new RestRequest(method)
            {
                Resource = path
            };

            if (options.PathParameters != null)
            {
                foreach (var pathParam in options.PathParameters)
                {
                    request.AddParameter(pathParam.Key, pathParam.Value, ParameterType.UrlSegment);
                }
            }

            if (options.QueryParameters != null)
            {
                foreach (var queryParam in options.QueryParameters)
                {
                    foreach (var value in queryParam.Value)
                    {
                        request.AddQueryParameter(queryParam.Key, value);
                    }
                }
            }

            if (!string.IsNullOrEmpty(apiKey))
            {
                request.AddHeader("X-PassportPdf-API-Key", apiKey);
            }

            if (options.HeaderParameters != null)
            {
                foreach (var headerParam in options.HeaderParameters)
                {
                    foreach (var value in headerParam.Value)
                    {
                        request.AddHeader(headerParam.Key, value);
                    }
                }
            }

            if (options.FormParameters != null)
            {
                foreach (var formParam in options.FormParameters)
                {
                    request.AddParameter(formParam.Key, formParam.Value);
                }
            }

            if (options.Data != null)
            {
                if (options.HeaderParameters != null)
                {
                    var contentTypes = options.HeaderParameters["Content-Type"];
                    if (contentTypes == null || contentTypes.Any(header => header.Contains("application/json")))
                    {
                        request.RequestFormat = DataFormat.Json;
                    }
                    else
                    {
                        // TODO: Generated client user should add additional handlers. RestSharp only supports XML and JSON, with XML as default.
                    }
                }
                else
                {
                    // Here, we'll assume JSON APIs are more common. XML can be forced by adding produces/consumes to openapi spec explicitly.
                    request.RequestFormat = DataFormat.Json;
                }

                request.AddJsonBody(options.Data);
            }

            if (options.FileParameters != null)
            {
                foreach (var fileParam in options.FileParameters)
                {
                    var fileStream = fileParam.Value as FileStream;

                    request.AddFile(fileParam.Key,
                       s =>
                       {
                           using (var file = new StreamReader(fileParam.Value))
                           {
                               file.BaseStream.CopyTo(s);
                           }
                       },
                       fileStream != null ? Path.GetFileName(fileStream.Name) : "no_file_name_provided",
                       fileParam.Value.Length);
                }
            }

            if (options.Cookies != null && options.Cookies.Count > 0)
            {
                foreach (var cookie in options.Cookies)
                {
                    request.AddCookie(cookie.Name, cookie.Value);
                }
            }

            return request;
        }
    }
}
