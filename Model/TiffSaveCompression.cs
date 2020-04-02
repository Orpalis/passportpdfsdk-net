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
    /// Specifies the TIFF compression when saving images in TIFF format.
    /// </summary>
    /// <value>Specifies the TIFF compression when saving images in TIFF format.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TiffSaveCompression
    {
        /// <summary>
        /// Enum Deflate for value: Deflate
        /// </summary>
        [EnumMember(Value = "Deflate")]
        Deflate = 1,

        /// <summary>
        /// Enum CCITT3 for value: CCITT3
        /// </summary>
        [EnumMember(Value = "CCITT3")]
        CCITT3 = 2,

        /// <summary>
        /// Enum CCITT4 for value: CCITT4
        /// </summary>
        [EnumMember(Value = "CCITT4")]
        CCITT4 = 3,

        /// <summary>
        /// Enum LZW for value: LZW
        /// </summary>
        [EnumMember(Value = "LZW")]
        LZW = 4,

        /// <summary>
        /// Enum JPEG for value: JPEG
        /// </summary>
        [EnumMember(Value = "JPEG")]
        JPEG = 5,

        /// <summary>
        /// Enum RLE for value: RLE
        /// </summary>
        [EnumMember(Value = "RLE")]
        RLE = 6,

        /// <summary>
        /// Enum Auto for value: Auto
        /// </summary>
        [EnumMember(Value = "Auto")]
        Auto = 7

    }

}
