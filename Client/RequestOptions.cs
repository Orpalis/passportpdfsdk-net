/* 
 * PassportPDF API
 *
 * Copyright © 2019 PassportPDF - https://www.passportpdf.com
 *
 */


using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace PassportPDF.Client
{
    /// <summary>
    /// A container for generalized request inputs.
    /// </summary>
    internal sealed class RequestOptions
    {
        /// <summary>
        /// Parameters to be bound to path parts of the Request's URL
        /// </summary>
        public Dictionary<string, string> PathParameters { get; set; }

        /// <summary>
        /// Query parameters to be applied to the request.
        /// Keys may have 1 or more values associated.
        /// </summary>
        public Dictionary<string, List<string>> QueryParameters { get; set; }

        /// <summary>
        /// Header parameters to be applied to to the request.
        /// Keys may have 1 or more values associated.
        /// </summary>
        public Dictionary<string, List<string>> HeaderParameters { get; set; }

        /// <summary>
        /// Form parameters to be sent along with the request.
        /// </summary>
        public Dictionary<string, string> FormParameters { get; set; }

        /// <summary>
        /// File parameters to be sent along with the request.
        /// </summary>
        public Dictionary<string, Stream> FileParameters { get; set; }

        /// <summary>
        /// Cookies to be sent along with the request.
        /// </summary>
        public List<Cookie> Cookies { get; set; }

        /// <summary>
        /// Any data associated with a request body.
        /// </summary>
        public Object Data { get; set; }

        /// <summary>
        /// Constructs a new instance of <see cref="RequestOptions"/>
        /// </summary>
        public RequestOptions()
        {
            PathParameters = new Dictionary<string, string>();
            QueryParameters = new Dictionary<string, List<string>>();
            HeaderParameters = new Dictionary<string, List<string>>();
            FormParameters = new Dictionary<string, string>();
            FileParameters = new Dictionary<string, Stream>();
            Cookies = new List<Cookie>();
        }


        public void AddHeaderParameter(string key, string value)
        {
            if (!HeaderParameters.ContainsKey(key))
            {
                HeaderParameters.Add(key, new List<string>());
            }

            HeaderParameters[key].Add(value);
        }


        public void AddQueryParameter(string key, string value)
        {
            if (!QueryParameters.ContainsKey(key))
            {
                QueryParameters.Add(key, new List<string>());
            }

            QueryParameters[key].Add(value);
        }
    }
}