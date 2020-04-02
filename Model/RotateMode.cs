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
    /// Specifies the rotation mode.
    /// </summary>
    /// <value>Specifies the rotation mode.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum RotateMode
    {
        /// <summary>
        /// Enum View for value: View
        /// </summary>
        [EnumMember(Value = "View")]
        View = 1,

        /// <summary>
        /// Enum CurrentPage for value: CurrentPage
        /// </summary>
        [EnumMember(Value = "CurrentPage")]
        CurrentPage = 2

    }

}
