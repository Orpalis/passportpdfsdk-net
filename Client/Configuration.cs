/* 
 * PassportPDF API
 *
 * Copyright © 2019 PassportPDF - https://www.passportpdf.com
 *
 */

using System.Collections.Concurrent;
using System.Collections.Generic;

namespace PassportPDF.Client
{
    /// <summary>
    /// Represents a set of configuration settings
    /// </summary>
    internal class Configuration
    {
        /// <summary>
        /// Identifier for ISO 8601 DateTime Format
        /// </summary>
        /// <remarks>See https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8 for more information.</remarks>
        public const string ISO8601_DATETIME_FORMAT = "o";

        private string _dateTimeFormat = ISO8601_DATETIME_FORMAT;

        /// <summary>
        /// Gets or sets the default headers.
        /// </summary>
        public IDictionary<string, string> DefaultHeaders { get; set; } = new ConcurrentDictionary<string, string>();

        public int Timeout { get; set; }

        public string UserAgent { get; set; }

        public string BasePath { get; set; }

        /// <summary>
        /// Gets or sets the date time format used when serializing in the ApiClient
        /// By default, it's set to ISO 8601 - "o", for others see:
        /// https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx
        /// and https://msdn.microsoft.com/en-us/library/8kb3ddd4(v=vs.110).aspx
        /// No validation is done to ensure that the string you're providing is valid
        /// </summary>
        /// <value>The DateTimeFormat string</value>
        public string DateTimeFormat
        {
            get { return _dateTimeFormat; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    // Never allow a blank or null string, go back to the default
                    _dateTimeFormat = ISO8601_DATETIME_FORMAT;
                    return;
                }

                // Caution, no validation when you choose date time format other than ISO 8601
                // Take a look at the above links
                _dateTimeFormat = value;
            }
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration" /> class
        /// </summary>
        public Configuration()
        {
        }


        public Configuration(Configuration other)
        {
            _dateTimeFormat = ISO8601_DATETIME_FORMAT;
            DefaultHeaders = new ConcurrentDictionary<string, string>(other.DefaultHeaders);
            Timeout = other.Timeout;
            UserAgent = other.UserAgent;
            BasePath = other.BasePath;
        }
    }
}
