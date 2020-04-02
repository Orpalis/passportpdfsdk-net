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
    /// Specifies the modes when changing the color depth of an image.
    /// </summary>
    /// <value>Specifies the modes when changing the color depth of an image.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ColorDepthConversionMethod
    {
        /// <summary>
        /// Enum Depth1Bpp for value: Depth1Bpp
        /// </summary>
        [EnumMember(Value = "Depth1Bpp")]
        Depth1Bpp = 1,

        /// <summary>
        /// Enum Depth1BppOtsu for value: Depth1BppOtsu
        /// </summary>
        [EnumMember(Value = "Depth1BppOtsu")]
        Depth1BppOtsu = 2,

        /// <summary>
        /// Enum Depth1BppBradley for value: Depth1BppBradley
        /// </summary>
        [EnumMember(Value = "Depth1BppBradley")]
        Depth1BppBradley = 3,

        /// <summary>
        /// Enum Depth1BppSauvola for value: Depth1BppSauvola
        /// </summary>
        [EnumMember(Value = "Depth1BppSauvola")]
        Depth1BppSauvola = 4,

        /// <summary>
        /// Enum Depth1BppFast for value: Depth1BppFast
        /// </summary>
        [EnumMember(Value = "Depth1BppFast")]
        Depth1BppFast = 5,

        /// <summary>
        /// Enum Depth4Bpp16 for value: Depth4Bpp16
        /// </summary>
        [EnumMember(Value = "Depth4Bpp16")]
        Depth4Bpp16 = 6,

        /// <summary>
        /// Enum Depth4BppQ for value: Depth4BppQ
        /// </summary>
        [EnumMember(Value = "Depth4BppQ")]
        Depth4BppQ = 7,

        /// <summary>
        /// Enum Depth8BppGrayScale for value: Depth8BppGrayScale
        /// </summary>
        [EnumMember(Value = "Depth8BppGrayScale")]
        Depth8BppGrayScale = 8,

        /// <summary>
        /// Enum Depth8BppGrayScaleAdv for value: Depth8BppGrayScaleAdv
        /// </summary>
        [EnumMember(Value = "Depth8BppGrayScaleAdv")]
        Depth8BppGrayScaleAdv = 9,

        /// <summary>
        /// Enum Depth8Bpp216 for value: Depth8Bpp216
        /// </summary>
        [EnumMember(Value = "Depth8Bpp216")]
        Depth8Bpp216 = 10,

        /// <summary>
        /// Enum Depth8BppQ for value: Depth8BppQ
        /// </summary>
        [EnumMember(Value = "Depth8BppQ")]
        Depth8BppQ = 11,

        /// <summary>
        /// Enum Depth16BppRGB555 for value: Depth16BppRGB555
        /// </summary>
        [EnumMember(Value = "Depth16BppRGB555")]
        Depth16BppRGB555 = 12,

        /// <summary>
        /// Enum Depth16BppRGB565 for value: Depth16BppRGB565
        /// </summary>
        [EnumMember(Value = "Depth16BppRGB565")]
        Depth16BppRGB565 = 13,

        /// <summary>
        /// Enum Depth24BppRGB for value: Depth24BppRGB
        /// </summary>
        [EnumMember(Value = "Depth24BppRGB")]
        Depth24BppRGB = 14,

        /// <summary>
        /// Enum Depth32BppARGB for value: Depth32BppARGB
        /// </summary>
        [EnumMember(Value = "Depth32BppARGB")]
        Depth32BppARGB = 15,

        /// <summary>
        /// Enum Depth32BppRGB for value: Depth32BppRGB
        /// </summary>
        [EnumMember(Value = "Depth32BppRGB")]
        Depth32BppRGB = 16,

        /// <summary>
        /// Enum Depth32BppPARGB for value: Depth32BppPARGB
        /// </summary>
        [EnumMember(Value = "Depth32BppPARGB")]
        Depth32BppPARGB = 17,

        /// <summary>
        /// Enum Depth48BppRGB for value: Depth48BppRGB
        /// </summary>
        [EnumMember(Value = "Depth48BppRGB")]
        Depth48BppRGB = 18,

        /// <summary>
        /// Enum Depth64BppARGB for value: Depth64BppARGB
        /// </summary>
        [EnumMember(Value = "Depth64BppARGB")]
        Depth64BppARGB = 19,

        /// <summary>
        /// Enum Depth64BppPARGB for value: Depth64BppPARGB
        /// </summary>
        [EnumMember(Value = "Depth64BppPARGB")]
        Depth64BppPARGB = 20

    }

}
