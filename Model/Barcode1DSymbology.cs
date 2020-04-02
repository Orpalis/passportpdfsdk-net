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
    /// Defines the different supported linear barcode symbologies.
    /// </summary>
    /// <value>Defines the different supported linear barcode symbologies.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum Barcode1DSymbology
    {
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,

        /// <summary>
        /// Enum Industrial2of5 for value: Industrial2of5
        /// </summary>
        [EnumMember(Value = "Industrial2of5")]
        Industrial2of5 = 2,

        /// <summary>
        /// Enum Inverted2of5 for value: Inverted2of5
        /// </summary>
        [EnumMember(Value = "Inverted2of5")]
        Inverted2of5 = 3,

        /// <summary>
        /// Enum Interleaved2of5 for value: Interleaved2of5
        /// </summary>
        [EnumMember(Value = "Interleaved2of5")]
        Interleaved2of5 = 4,

        /// <summary>
        /// Enum Iata2of5 for value: Iata2of5
        /// </summary>
        [EnumMember(Value = "Iata2of5")]
        Iata2of5 = 5,

        /// <summary>
        /// Enum Matrix2of5 for value: Matrix2of5
        /// </summary>
        [EnumMember(Value = "Matrix2of5")]
        Matrix2of5 = 6,

        /// <summary>
        /// Enum Code39 for value: Code39
        /// </summary>
        [EnumMember(Value = "Code39")]
        Code39 = 7,

        /// <summary>
        /// Enum Codeabar for value: Codeabar
        /// </summary>
        [EnumMember(Value = "Codeabar")]
        Codeabar = 8,

        /// <summary>
        /// Enum BcdMatrix for value: BcdMatrix
        /// </summary>
        [EnumMember(Value = "BcdMatrix")]
        BcdMatrix = 9,

        /// <summary>
        /// Enum DataLogic2of5 for value: DataLogic2of5
        /// </summary>
        [EnumMember(Value = "DataLogic2of5")]
        DataLogic2of5 = 10,

        /// <summary>
        /// Enum Code128 for value: Code128
        /// </summary>
        [EnumMember(Value = "Code128")]
        Code128 = 11,

        /// <summary>
        /// Enum CODE93 for value: CODE93
        /// </summary>
        [EnumMember(Value = "CODE93")]
        CODE93 = 12,

        /// <summary>
        /// Enum EAN13 for value: EAN13
        /// </summary>
        [EnumMember(Value = "EAN13")]
        EAN13 = 13,

        /// <summary>
        /// Enum UPCA for value: UPCA
        /// </summary>
        [EnumMember(Value = "UPCA")]
        UPCA = 14,

        /// <summary>
        /// Enum EAN8 for value: EAN8
        /// </summary>
        [EnumMember(Value = "EAN8")]
        EAN8 = 15,

        /// <summary>
        /// Enum UPCE for value: UPCE
        /// </summary>
        [EnumMember(Value = "UPCE")]
        UPCE = 16,

        /// <summary>
        /// Enum ADD5 for value: ADD5
        /// </summary>
        [EnumMember(Value = "ADD5")]
        ADD5 = 17,

        /// <summary>
        /// Enum ADD2 for value: ADD2
        /// </summary>
        [EnumMember(Value = "ADD2")]
        ADD2 = 18

    }

}
