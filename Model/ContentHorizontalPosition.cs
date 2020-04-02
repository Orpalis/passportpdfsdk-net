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
    /// Defines the different horizontal positions for content added on a page.
    /// </summary>
    /// <value>Defines the different horizontal positions for content added on a page.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ContentHorizontalPosition
    {
        /// <summary>
        /// Enum Center for value: Center
        /// </summary>
        [EnumMember(Value = "Center")]
        Center = 1,

        /// <summary>
        /// Enum Left for value: Left
        /// </summary>
        [EnumMember(Value = "Left")]
        Left = 2,

        /// <summary>
        /// Enum Right for value: Right
        /// </summary>
        [EnumMember(Value = "Right")]
        Right = 3,

        /// <summary>
        /// Enum Absolute for value: Absolute
        /// </summary>
        [EnumMember(Value = "Absolute")]
        Absolute = 4

    }

}
