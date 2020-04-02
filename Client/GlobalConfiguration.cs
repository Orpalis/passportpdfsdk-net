/* 
 * PassportPDF API
 *
 * Copyright © 2019 PassportPDF - https://www.passportpdf.com
 *
 */

namespace PassportPDF.Client
{
    /// <summary>
    /// <see cref="GlobalConfiguration"/> provides a compile-time extension point for globally configuring API Clients.
    /// </summary>
    public sealed class GlobalConfiguration
    {
        private static readonly object _locker = new object();

        internal static Configuration Instance { get; } = new Configuration()
        {
            BasePath = "https://passportpdfapi.com",
            UserAgent = "PassportPDF csharp SDK",
            Timeout = 100000,
        };

        /// <summary>
        /// Gets or sets the base path for API access. Default to "https://passportpdfapi.com".
        /// </summary>
        public static string BasePath
        {
            get
            {
                lock (_locker)
                {
                    return Instance.BasePath;
                }
            }
            set
            {
                lock (_locker)
                {
                    Instance.BasePath = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the HTTP timeout (milliseconds) for the requests. Default to 100000 milliseconds.
        /// </summary>
        public static int Timeout
        {
            get
            {
                lock (_locker)
                {
                    return Instance.Timeout;
                }
            }
            set
            {
                lock (_locker)
                {
                    Instance.Timeout = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the API key.
        /// </summary>
        public static string ApiKey
        {
            get
            {
                lock (_locker)
                {
                    return Instance.DefaultHeaders.ContainsKey("X-PassportPdf-API-Key") ? Instance.DefaultHeaders["X-PassportPdf-API-Key"] : null;
                }
            }
            set
            {
                lock (_locker)
                {
                    if (!Instance.DefaultHeaders.ContainsKey("X-PassportPdf-API-Key"))
                    {
                        Instance.DefaultHeaders.Add("X-PassportPdf-API-Key", value);
                    }
                    else
                    {
                        Instance.DefaultHeaders["X-PassportPdf-API-Key"] = value;
                    }
                }
            }
        }
    }
}