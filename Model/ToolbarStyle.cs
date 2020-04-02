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
    /// Specifies the toolbar style.
    /// </summary>
    /// <value>Specifies the toolbar style.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ToolbarStyle
    {
        /// <summary>
        /// Enum Auto for value: Auto
        /// </summary>
        [EnumMember(Value = "Auto")]
        Auto = 1,

        /// <summary>
        /// Enum Desktop for value: Desktop
        /// </summary>
        [EnumMember(Value = "Desktop")]
        Desktop = 2,

        /// <summary>
        /// Enum Mobile for value: Mobile
        /// </summary>
        [EnumMember(Value = "Mobile")]
        Mobile = 3

    }

}
