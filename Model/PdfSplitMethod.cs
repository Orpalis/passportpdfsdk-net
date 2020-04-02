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
    /// Defines the different available methods for splitting a PDF.
    /// </summary>
    /// <value>Defines the different available methods for splitting a PDF.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PdfSplitMethod
    {
        /// <summary>
        /// Enum SplitByNumberOfPages for value: SplitByNumberOfPages
        /// </summary>
        [EnumMember(Value = "SplitByNumberOfPages")]
        SplitByNumberOfPages = 1,

        /// <summary>
        /// Enum SplitByFileSize for value: SplitByFileSize
        /// </summary>
        [EnumMember(Value = "SplitByFileSize")]
        SplitByFileSize = 2,

        /// <summary>
        /// Enum SplitByTopLevelBookmarks for value: SplitByTopLevelBookmarks
        /// </summary>
        [EnumMember(Value = "SplitByTopLevelBookmarks")]
        SplitByTopLevelBookmarks = 3

    }

}
