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
    /// Defines the different available scan modes.
    /// </summary>
    /// <value>Defines the different available scan modes.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ScanMode
    {
        /// <summary>
        /// Enum FavorSpeed for value: FavorSpeed
        /// </summary>
        [EnumMember(Value = "FavorSpeed")]
        FavorSpeed = 1,

        /// <summary>
        /// Enum FavorAccuracy for value: FavorAccuracy
        /// </summary>
        [EnumMember(Value = "FavorAccuracy")]
        FavorAccuracy = 2

    }

}
