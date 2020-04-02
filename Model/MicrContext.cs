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
    /// Specifies the MICR context, i.e. the layout type of the data to be recognized.  .
    /// </summary>
    /// <value>Specifies the MICR context, i.e. the layout type of the data to be recognized.  .</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum MicrContext
    {
        /// <summary>
        /// Enum WholeDocument for value: WholeDocument
        /// </summary>
        [EnumMember(Value = "WholeDocument")]
        WholeDocument = 1,

        /// <summary>
        /// Enum LineFinding for value: LineFinding
        /// </summary>
        [EnumMember(Value = "LineFinding")]
        LineFinding = 2

    }

}
