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
    /// Specifies the page layout to be used when the document is opened.
    /// </summary>
    /// <value>Specifies the page layout to be used when the document is opened.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PdfInitViewLayoutMode
    {
        /// <summary>
        /// Enum SinglePage for value: SinglePage
        /// </summary>
        [EnumMember(Value = "SinglePage")]
        SinglePage = 1,

        /// <summary>
        /// Enum OneColumn for value: OneColumn
        /// </summary>
        [EnumMember(Value = "OneColumn")]
        OneColumn = 2,

        /// <summary>
        /// Enum TwoColumnLeft for value: TwoColumnLeft
        /// </summary>
        [EnumMember(Value = "TwoColumnLeft")]
        TwoColumnLeft = 3,

        /// <summary>
        /// Enum TwoColumnRight for value: TwoColumnRight
        /// </summary>
        [EnumMember(Value = "TwoColumnRight")]
        TwoColumnRight = 4,

        /// <summary>
        /// Enum TwoPageLeft for value: TwoPageLeft
        /// </summary>
        [EnumMember(Value = "TwoPageLeft")]
        TwoPageLeft = 5,

        /// <summary>
        /// Enum TwoPageRight for value: TwoPageRight
        /// </summary>
        [EnumMember(Value = "TwoPageRight")]
        TwoPageRight = 6

    }

}
