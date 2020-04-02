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
    /// User specific locale.
    /// </summary>
    /// <value>User specific locale.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DocuViewareLocale
    {
        /// <summary>
        /// Enum Auto for value: Auto
        /// </summary>
        [EnumMember(Value = "Auto")]
        Auto = 1,

        /// <summary>
        /// Enum Fr for value: Fr
        /// </summary>
        [EnumMember(Value = "Fr")]
        Fr = 2,

        /// <summary>
        /// Enum En for value: En
        /// </summary>
        [EnumMember(Value = "En")]
        En = 3,

        /// <summary>
        /// Enum Ro for value: Ro
        /// </summary>
        [EnumMember(Value = "Ro")]
        Ro = 4,

        /// <summary>
        /// Enum Ar for value: Ar
        /// </summary>
        [EnumMember(Value = "Ar")]
        Ar = 5,

        /// <summary>
        /// Enum De for value: De
        /// </summary>
        [EnumMember(Value = "De")]
        De = 6,

        /// <summary>
        /// Enum It for value: It
        /// </summary>
        [EnumMember(Value = "It")]
        It = 7,

        /// <summary>
        /// Enum Tr for value: Tr
        /// </summary>
        [EnumMember(Value = "Tr")]
        Tr = 8,

        /// <summary>
        /// Enum Sk for value: Sk
        /// </summary>
        [EnumMember(Value = "Sk")]
        Sk = 9,

        /// <summary>
        /// Enum Cs for value: Cs
        /// </summary>
        [EnumMember(Value = "Cs")]
        Cs = 10,

        /// <summary>
        /// Enum Es for value: Es
        /// </summary>
        [EnumMember(Value = "Es")]
        Es = 11,

        /// <summary>
        /// Enum Da for value: Da
        /// </summary>
        [EnumMember(Value = "Da")]
        Da = 12,

        /// <summary>
        /// Enum Ru for value: Ru
        /// </summary>
        [EnumMember(Value = "Ru")]
        Ru = 13,

        /// <summary>
        /// Enum Pt for value: Pt
        /// </summary>
        [EnumMember(Value = "Pt")]
        Pt = 14,

        /// <summary>
        /// Enum Nl for value: Nl
        /// </summary>
        [EnumMember(Value = "Nl")]
        Nl = 15,

        /// <summary>
        /// Enum Pl for value: Pl
        /// </summary>
        [EnumMember(Value = "Pl")]
        Pl = 16,

        /// <summary>
        /// Enum Hu for value: Hu
        /// </summary>
        [EnumMember(Value = "Hu")]
        Hu = 17,

        /// <summary>
        /// Enum Bg for value: Bg
        /// </summary>
        [EnumMember(Value = "Bg")]
        Bg = 18,

        /// <summary>
        /// Enum El for value: El
        /// </summary>
        [EnumMember(Value = "El")]
        El = 19,

        /// <summary>
        /// Enum Zh for value: Zh
        /// </summary>
        [EnumMember(Value = "Zh")]
        Zh = 20,

        /// <summary>
        /// Enum Ja for value: Ja
        /// </summary>
        [EnumMember(Value = "Ja")]
        Ja = 21,

        /// <summary>
        /// Enum Sv for value: Sv
        /// </summary>
        [EnumMember(Value = "Sv")]
        Sv = 22,

        /// <summary>
        /// Enum No for value: No
        /// </summary>
        [EnumMember(Value = "No")]
        No = 23,

        /// <summary>
        /// Enum Ko for value: Ko
        /// </summary>
        [EnumMember(Value = "Ko")]
        Ko = 24,

        /// <summary>
        /// Enum He for value: He
        /// </summary>
        [EnumMember(Value = "He")]
        He = 25,

        /// <summary>
        /// Enum Fi for value: Fi
        /// </summary>
        [EnumMember(Value = "Fi")]
        Fi = 26,

        /// <summary>
        /// Enum Sl for value: Sl
        /// </summary>
        [EnumMember(Value = "Sl")]
        Sl = 27

    }

}
