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
    /// Defines the different possible sizes for content added on a page.
    /// </summary>
    /// <value>Defines the different possible sizes for content added on a page.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ContentSize
    {
        /// <summary>
        /// Enum Small for value: Small
        /// </summary>
        [EnumMember(Value = "Small")]
        Small = 1,

        /// <summary>
        /// Enum Medium for value: Medium
        /// </summary>
        [EnumMember(Value = "Medium")]
        Medium = 2,

        /// <summary>
        /// Enum Large for value: Large
        /// </summary>
        [EnumMember(Value = "Large")]
        Large = 3,

        /// <summary>
        /// Enum Absolute for value: Absolute
        /// </summary>
        [EnumMember(Value = "Absolute")]
        Absolute = 4,

        /// <summary>
        /// Enum AutoFit for value: AutoFit
        /// </summary>
        [EnumMember(Value = "AutoFit")]
        AutoFit = 5

    }

}
