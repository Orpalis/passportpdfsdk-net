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
    /// Specifies the different available PDF/A conformance levels.
    /// </summary>
    /// <value>Specifies the different available PDF/A conformance levels.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PdfAConformance
    {
        /// <summary>
        /// Enum PDFA1a for value: PDFA1a
        /// </summary>
        [EnumMember(Value = "PDFA1a")]
        PDFA1a = 1,

        /// <summary>
        /// Enum PDFA1b for value: PDFA1b
        /// </summary>
        [EnumMember(Value = "PDFA1b")]
        PDFA1b = 2,

        /// <summary>
        /// Enum PDFA2a for value: PDFA2a
        /// </summary>
        [EnumMember(Value = "PDFA2a")]
        PDFA2a = 3,

        /// <summary>
        /// Enum PDFA2b for value: PDFA2b
        /// </summary>
        [EnumMember(Value = "PDFA2b")]
        PDFA2b = 4,

        /// <summary>
        /// Enum PDFA2u for value: PDFA2u
        /// </summary>
        [EnumMember(Value = "PDFA2u")]
        PDFA2u = 5,

        /// <summary>
        /// Enum PDFA3a for value: PDFA3a
        /// </summary>
        [EnumMember(Value = "PDFA3a")]
        PDFA3a = 6,

        /// <summary>
        /// Enum PDFA3b for value: PDFA3b
        /// </summary>
        [EnumMember(Value = "PDFA3b")]
        PDFA3b = 7,

        /// <summary>
        /// Enum PDFA3u for value: PDFA3u
        /// </summary>
        [EnumMember(Value = "PDFA3u")]
        PDFA3u = 8

    }

}
