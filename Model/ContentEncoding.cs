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
    /// Indicates the encoding mode of data.
    /// </summary>
    /// <value>Indicates the encoding mode of data.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ContentEncoding
    {
        /// <summary>
        /// Enum Identity for value: Identity
        /// </summary>
        [EnumMember(Value = "Identity")]
        Identity = 1,

        /// <summary>
        /// Enum Gzip for value: Gzip
        /// </summary>
        [EnumMember(Value = "Gzip")]
        Gzip = 2

    }

}
