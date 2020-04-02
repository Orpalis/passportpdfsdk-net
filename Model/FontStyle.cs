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
    /// Defines the different available font styles.
    /// </summary>
    /// <value>Defines the different available font styles.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FontStyle
    {
        /// <summary>
        /// Enum Regular for value: Regular
        /// </summary>
        [EnumMember(Value = "Regular")]
        Regular = 1,

        /// <summary>
        /// Enum Bold for value: Bold
        /// </summary>
        [EnumMember(Value = "Bold")]
        Bold = 2,

        /// <summary>
        /// Enum Italic for value: Italic
        /// </summary>
        [EnumMember(Value = "Italic")]
        Italic = 3,

        /// <summary>
        /// Enum BoldItalic for value: BoldItalic
        /// </summary>
        [EnumMember(Value = "BoldItalic")]
        BoldItalic = 4

    }

}
