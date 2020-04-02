/*
 * PassportPDF API
 *
 * Copyright © 2019 PassportPDF - https://www.passportpdf.com
 *
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace PassportPDF.Model
{
    /// <summary>
    /// Specifies the SHA (hash) algorithm to use while signing.
    /// </summary>
    /// <value>Specifies the SHA (hash) algorithm to use while signing.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SignatureHash
    {
        /// <summary>
        /// Enum SHA1 for value: SHA1
        /// </summary>
        [EnumMember(Value = "SHA1")]
        SHA1 = 1,

        /// <summary>
        /// Enum SHA256 for value: SHA256
        /// </summary>
        [EnumMember(Value = "SHA256")]
        SHA256 = 2,

        /// <summary>
        /// Enum SHA512 for value: SHA512
        /// </summary>
        [EnumMember(Value = "SHA512")]
        SHA512 = 3,

        /// <summary>
        /// Enum SHA224 for value: SHA224
        /// </summary>
        [EnumMember(Value = "SHA224")]
        SHA224 = 4,

        /// <summary>
        /// Enum SHA384 for value: SHA384
        /// </summary>
        [EnumMember(Value = "SHA384")]
        SHA384 = 5

    }

}
