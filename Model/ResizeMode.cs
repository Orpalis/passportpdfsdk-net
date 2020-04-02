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
    /// The algorithm to be used during resizing.
    /// </summary>
    /// <value>The algorithm to be used during resizing.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ResizeMode
    {
        /// <summary>
        /// Enum Auto for value: Auto
        /// </summary>
        [EnumMember(Value = "Auto")]
        Auto = 1,

        /// <summary>
        /// Enum NearestNeighbor for value: NearestNeighbor
        /// </summary>
        [EnumMember(Value = "NearestNeighbor")]
        NearestNeighbor = 2,

        /// <summary>
        /// Enum Box for value: Box
        /// </summary>
        [EnumMember(Value = "Box")]
        Box = 3,

        /// <summary>
        /// Enum Lanczos3 for value: Lanczos3
        /// </summary>
        [EnumMember(Value = "Lanczos3")]
        Lanczos3 = 4,

        /// <summary>
        /// Enum Bilinear for value: Bilinear
        /// </summary>
        [EnumMember(Value = "Bilinear")]
        Bilinear = 5,

        /// <summary>
        /// Enum Bicubic for value: Bicubic
        /// </summary>
        [EnumMember(Value = "Bicubic")]
        Bicubic = 6,

        /// <summary>
        /// Enum Bspline for value: Bspline
        /// </summary>
        [EnumMember(Value = "Bspline")]
        Bspline = 7,

        /// <summary>
        /// Enum CatmullRomSpline for value: CatmullRomSpline
        /// </summary>
        [EnumMember(Value = "CatmullRomSpline")]
        CatmullRomSpline = 8

    }

}
