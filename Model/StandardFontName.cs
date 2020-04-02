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
    /// Defines the different available standard fonts (Standard Type 1) which can be used without prior definition.
    /// </summary>
    /// <value>Defines the different available standard fonts (Standard Type 1) which can be used without prior definition.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum StandardFontName
    {
        /// <summary>
        /// Enum Courier for value: Courier
        /// </summary>
        [EnumMember(Value = "Courier")]
        Courier = 1,

        /// <summary>
        /// Enum Helvetica for value: Helvetica
        /// </summary>
        [EnumMember(Value = "Helvetica")]
        Helvetica = 2,

        /// <summary>
        /// Enum Times for value: Times
        /// </summary>
        [EnumMember(Value = "Times")]
        Times = 3,

        /// <summary>
        /// Enum Symbol for value: Symbol
        /// </summary>
        [EnumMember(Value = "Symbol")]
        Symbol = 4,

        /// <summary>
        /// Enum ZapfDingbats for value: ZapfDingbats
        /// </summary>
        [EnumMember(Value = "ZapfDingbats")]
        ZapfDingbats = 5

    }

}
