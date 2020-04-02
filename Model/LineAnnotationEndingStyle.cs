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
    /// Specifies an line annotation&#39;s ending style.
    /// </summary>
    /// <value>Specifies an line annotation&#39;s ending style.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum LineAnnotationEndingStyle
    {
        /// <summary>
        /// Enum Square for value: Square
        /// </summary>
        [EnumMember(Value = "Square")]
        Square = 1,

        /// <summary>
        /// Enum Circle for value: Circle
        /// </summary>
        [EnumMember(Value = "Circle")]
        Circle = 2,

        /// <summary>
        /// Enum Diamond for value: Diamond
        /// </summary>
        [EnumMember(Value = "Diamond")]
        Diamond = 3,

        /// <summary>
        /// Enum OpenArrow for value: OpenArrow
        /// </summary>
        [EnumMember(Value = "OpenArrow")]
        OpenArrow = 4,

        /// <summary>
        /// Enum ClosedArrow for value: ClosedArrow
        /// </summary>
        [EnumMember(Value = "ClosedArrow")]
        ClosedArrow = 5,

        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 6,

        /// <summary>
        /// Enum Butt for value: Butt
        /// </summary>
        [EnumMember(Value = "Butt")]
        Butt = 7,

        /// <summary>
        /// Enum ReversedOpenArrow for value: ReversedOpenArrow
        /// </summary>
        [EnumMember(Value = "ReversedOpenArrow")]
        ReversedOpenArrow = 8,

        /// <summary>
        /// Enum ReversedClosedArrow for value: ReversedClosedArrow
        /// </summary>
        [EnumMember(Value = "ReversedClosedArrow")]
        ReversedClosedArrow = 9,

        /// <summary>
        /// Enum Slash for value: Slash
        /// </summary>
        [EnumMember(Value = "Slash")]
        Slash = 10

    }

}
