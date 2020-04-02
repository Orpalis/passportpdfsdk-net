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
    /// Defines the different possible vertical positions for content added on a page.
    /// </summary>
    /// <value>Defines the different possible vertical positions for content added on a page.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ContentVerticalPosition
    {
        /// <summary>
        /// Enum Center for value: Center
        /// </summary>
        [EnumMember(Value = "Center")]
        Center = 1,

        /// <summary>
        /// Enum Top for value: Top
        /// </summary>
        [EnumMember(Value = "Top")]
        Top = 2,

        /// <summary>
        /// Enum Bottom for value: Bottom
        /// </summary>
        [EnumMember(Value = "Bottom")]
        Bottom = 3,

        /// <summary>
        /// Enum Absolute for value: Absolute
        /// </summary>
        [EnumMember(Value = "Absolute")]
        Absolute = 4

    }

}
