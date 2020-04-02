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
    /// Defines DocumentPosition
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DocumentPosition
    {
        /// <summary>
        /// Enum MiddleLeft for value: MiddleLeft
        /// </summary>
        [EnumMember(Value = "MiddleLeft")]
        MiddleLeft = 1,

        /// <summary>
        /// Enum MiddleRight for value: MiddleRight
        /// </summary>
        [EnumMember(Value = "MiddleRight")]
        MiddleRight = 2,

        /// <summary>
        /// Enum MiddleCenter for value: MiddleCenter
        /// </summary>
        [EnumMember(Value = "MiddleCenter")]
        MiddleCenter = 3,

        /// <summary>
        /// Enum TopLeft for value: TopLeft
        /// </summary>
        [EnumMember(Value = "TopLeft")]
        TopLeft = 4,

        /// <summary>
        /// Enum TopRight for value: TopRight
        /// </summary>
        [EnumMember(Value = "TopRight")]
        TopRight = 5,

        /// <summary>
        /// Enum TopCenter for value: TopCenter
        /// </summary>
        [EnumMember(Value = "TopCenter")]
        TopCenter = 6,

        /// <summary>
        /// Enum BottomLeft for value: BottomLeft
        /// </summary>
        [EnumMember(Value = "BottomLeft")]
        BottomLeft = 7,

        /// <summary>
        /// Enum BottomRight for value: BottomRight
        /// </summary>
        [EnumMember(Value = "BottomRight")]
        BottomRight = 8,

        /// <summary>
        /// Enum BottomCenter for value: BottomCenter
        /// </summary>
        [EnumMember(Value = "BottomCenter")]
        BottomCenter = 9

    }

}
