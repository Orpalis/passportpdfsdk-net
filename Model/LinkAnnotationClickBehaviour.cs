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
    /// Defines LinkAnnotationClickBehaviour
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum LinkAnnotationClickBehaviour
    {
        /// <summary>
        /// Enum Default for value: Default
        /// </summary>
        [EnumMember(Value = "Default")]
        Default = 1,

        /// <summary>
        /// Enum ClickNavigation for value: ClickNavigation
        /// </summary>
        [EnumMember(Value = "ClickNavigation")]
        ClickNavigation = 2,

        /// <summary>
        /// Enum DoubleClickNavigation for value: DoubleClickNavigation
        /// </summary>
        [EnumMember(Value = "DoubleClickNavigation")]
        DoubleClickNavigation = 3

    }

}
