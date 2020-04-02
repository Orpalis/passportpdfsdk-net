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
    /// Defines RotateFlip
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum RotateFlip
    {
        /// <summary>
        /// Enum RotateNoneFlipNone for value: RotateNoneFlipNone
        /// </summary>
        [EnumMember(Value = "RotateNoneFlipNone")]
        RotateNoneFlipNone = 1,

        /// <summary>
        /// Enum Rotate90FlipNone for value: Rotate90FlipNone
        /// </summary>
        [EnumMember(Value = "Rotate90FlipNone")]
        Rotate90FlipNone = 2,

        /// <summary>
        /// Enum Rotate180FlipNone for value: Rotate180FlipNone
        /// </summary>
        [EnumMember(Value = "Rotate180FlipNone")]
        Rotate180FlipNone = 3,

        /// <summary>
        /// Enum Rotate270FlipNone for value: Rotate270FlipNone
        /// </summary>
        [EnumMember(Value = "Rotate270FlipNone")]
        Rotate270FlipNone = 4,

        /// <summary>
        /// Enum RotateNoneFlipX for value: RotateNoneFlipX
        /// </summary>
        [EnumMember(Value = "RotateNoneFlipX")]
        RotateNoneFlipX = 5,

        /// <summary>
        /// Enum Rotate90FlipX for value: Rotate90FlipX
        /// </summary>
        [EnumMember(Value = "Rotate90FlipX")]
        Rotate90FlipX = 6,

        /// <summary>
        /// Enum Rotate180FlipX for value: Rotate180FlipX
        /// </summary>
        [EnumMember(Value = "Rotate180FlipX")]
        Rotate180FlipX = 7,

        /// <summary>
        /// Enum Rotate270FlipX for value: Rotate270FlipX
        /// </summary>
        [EnumMember(Value = "Rotate270FlipX")]
        Rotate270FlipX = 8

    }

}
