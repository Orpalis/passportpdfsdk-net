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
    /// Specifies the quality level to be used to print documents.
    /// </summary>
    /// <value>Specifies the quality level to be used to print documents.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PrintQuality
    {
        /// <summary>
        /// Enum Low for value: Low
        /// </summary>
        [EnumMember(Value = "Low")]
        Low = 1,

        /// <summary>
        /// Enum Medium for value: Medium
        /// </summary>
        [EnumMember(Value = "Medium")]
        Medium = 2,

        /// <summary>
        /// Enum High for value: High
        /// </summary>
        [EnumMember(Value = "High")]
        High = 3,

        /// <summary>
        /// Enum VeryHigh for value: VeryHigh
        /// </summary>
        [EnumMember(Value = "VeryHigh")]
        VeryHigh = 4

    }

}
