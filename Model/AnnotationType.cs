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
    /// Defines the different available types of annotations.
    /// </summary>
    /// <value>Defines the different available types of annotations.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AnnotationType
    {
        /// <summary>
        /// Enum StickyNote for value: StickyNote
        /// </summary>
        [EnumMember(Value = "StickyNote")]
        StickyNote = 1,

        /// <summary>
        /// Enum Link for value: Link
        /// </summary>
        [EnumMember(Value = "Link")]
        Link = 2,

        /// <summary>
        /// Enum FreeText for value: FreeText
        /// </summary>
        [EnumMember(Value = "FreeText")]
        FreeText = 3,

        /// <summary>
        /// Enum Line for value: Line
        /// </summary>
        [EnumMember(Value = "Line")]
        Line = 4,

        /// <summary>
        /// Enum Square for value: Square
        /// </summary>
        [EnumMember(Value = "Square")]
        Square = 5,

        /// <summary>
        /// Enum Circle for value: Circle
        /// </summary>
        [EnumMember(Value = "Circle")]
        Circle = 6,

        /// <summary>
        /// Enum RubberStamp for value: RubberStamp
        /// </summary>
        [EnumMember(Value = "RubberStamp")]
        RubberStamp = 7

    }

}
