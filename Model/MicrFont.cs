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
    /// Specifies the two major MICR fonts in use.
    /// </summary>
    /// <value>Specifies the two major MICR fonts in use.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum MicrFont
    {
        /// <summary>
        /// Enum CMC7 for value: CMC7
        /// </summary>
        [EnumMember(Value = "CMC7")]
        CMC7 = 1,

        /// <summary>
        /// Enum E13B for value: E13B
        /// </summary>
        [EnumMember(Value = "E13B")]
        E13B = 2

    }

}
