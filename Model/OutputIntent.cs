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
    /// Defines the intent (color detection) of the image.
    /// </summary>
    /// <value>Defines the intent (color detection) of the image.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum OutputIntent
    {
        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown = 1,

        /// <summary>
        /// Enum BlackWhite for value: BlackWhite
        /// </summary>
        [EnumMember(Value = "BlackWhite")]
        BlackWhite = 2,

        /// <summary>
        /// Enum Grayscale for value: Grayscale
        /// </summary>
        [EnumMember(Value = "Grayscale")]
        Grayscale = 3,

        /// <summary>
        /// Enum Palletized for value: Palletized
        /// </summary>
        [EnumMember(Value = "Palletized")]
        Palletized = 4,

        /// <summary>
        /// Enum Color for value: Color
        /// </summary>
        [EnumMember(Value = "Color")]
        Color = 5,

        /// <summary>
        /// Enum White for value: White
        /// </summary>
        [EnumMember(Value = "White")]
        White = 6

    }

}
