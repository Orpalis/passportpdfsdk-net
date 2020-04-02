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
    /// Defines the different available modes for text extraction.
    /// </summary>
    /// <value>Defines the different available modes for text extraction.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PdfExtractTextMode
    {
        /// <summary>
        /// Enum WholePageReadable for value: WholePageReadable
        /// </summary>
        [EnumMember(Value = "WholePageReadable")]
        WholePageReadable = 1,

        /// <summary>
        /// Enum PageAreaReadable for value: PageAreaReadable
        /// </summary>
        [EnumMember(Value = "PageAreaReadable")]
        PageAreaReadable = 2,

        /// <summary>
        /// Enum WholePageCSV for value: WholePageCSV
        /// </summary>
        [EnumMember(Value = "WholePageCSV")]
        WholePageCSV = 3

    }

}
