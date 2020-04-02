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
    /// Defines the different formats available for the page number insertion.
    /// </summary>
    /// <value>Defines the different formats available for the page number insertion.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PageNumberFormat
    {
        /// <summary>
        /// Enum PageNumber for value: PageNumber
        /// </summary>
        [EnumMember(Value = "PageNumber")]
        PageNumber = 1,

        /// <summary>
        /// Enum PagePageNumber for value: PagePageNumber
        /// </summary>
        [EnumMember(Value = "PagePageNumber")]
        PagePageNumber = 2,

        /// <summary>
        /// Enum PagePageNumberOfPageCount for value: PagePageNumberOfPageCount
        /// </summary>
        [EnumMember(Value = "PagePageNumberOfPageCount")]
        PagePageNumberOfPageCount = 3,

        /// <summary>
        /// Enum CustomFormatting for value: CustomFormatting
        /// </summary>
        [EnumMember(Value = "CustomFormatting")]
        CustomFormatting = 4

    }

}
