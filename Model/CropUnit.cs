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
    /// Specifies the unit in which a crop box is expressed.
    /// </summary>
    /// <value>Specifies the unit in which a crop box is expressed.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CropUnit
    {
        /// <summary>
        /// Enum Pixel for value: Pixel
        /// </summary>
        [EnumMember(Value = "Pixel")]
        Pixel = 1,

        /// <summary>
        /// Enum Percent for value: Percent
        /// </summary>
        [EnumMember(Value = "Percent")]
        Percent = 2

    }

}
