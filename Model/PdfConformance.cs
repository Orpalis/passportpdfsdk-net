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
    /// Specifies PDF versions and conformance levels of a PDF document.
    /// </summary>
    /// <value>Specifies PDF versions and conformance levels of a PDF document.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PdfConformance
    {
        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown = 1,

        /// <summary>
        /// Enum PDF10 for value: PDF10
        /// </summary>
        [EnumMember(Value = "PDF10")]
        PDF10 = 2,

        /// <summary>
        /// Enum PDF11 for value: PDF11
        /// </summary>
        [EnumMember(Value = "PDF11")]
        PDF11 = 3,

        /// <summary>
        /// Enum PDF12 for value: PDF12
        /// </summary>
        [EnumMember(Value = "PDF12")]
        PDF12 = 4,

        /// <summary>
        /// Enum PDF13 for value: PDF13
        /// </summary>
        [EnumMember(Value = "PDF13")]
        PDF13 = 5,

        /// <summary>
        /// Enum PDF14 for value: PDF14
        /// </summary>
        [EnumMember(Value = "PDF14")]
        PDF14 = 6,

        /// <summary>
        /// Enum PDF15 for value: PDF15
        /// </summary>
        [EnumMember(Value = "PDF15")]
        PDF15 = 7,

        /// <summary>
        /// Enum PDF16 for value: PDF16
        /// </summary>
        [EnumMember(Value = "PDF16")]
        PDF16 = 8,

        /// <summary>
        /// Enum PDF17 for value: PDF17
        /// </summary>
        [EnumMember(Value = "PDF17")]
        PDF17 = 9,

        /// <summary>
        /// Enum PDF20 for value: PDF20
        /// </summary>
        [EnumMember(Value = "PDF20")]
        PDF20 = 10,

        /// <summary>
        /// Enum PDFA1a for value: PDFA1a
        /// </summary>
        [EnumMember(Value = "PDFA1a")]
        PDFA1a = 11,

        /// <summary>
        /// Enum PDFA1b for value: PDFA1b
        /// </summary>
        [EnumMember(Value = "PDFA1b")]
        PDFA1b = 12,

        /// <summary>
        /// Enum PDFA2a for value: PDFA2a
        /// </summary>
        [EnumMember(Value = "PDFA2a")]
        PDFA2a = 13,

        /// <summary>
        /// Enum PDFA2u for value: PDFA2u
        /// </summary>
        [EnumMember(Value = "PDFA2u")]
        PDFA2u = 14,

        /// <summary>
        /// Enum PDFA2b for value: PDFA2b
        /// </summary>
        [EnumMember(Value = "PDFA2b")]
        PDFA2b = 15,

        /// <summary>
        /// Enum PDFA3a for value: PDFA3a
        /// </summary>
        [EnumMember(Value = "PDFA3a")]
        PDFA3a = 16,

        /// <summary>
        /// Enum PDFA3u for value: PDFA3u
        /// </summary>
        [EnumMember(Value = "PDFA3u")]
        PDFA3u = 17,

        /// <summary>
        /// Enum PDFA3b for value: PDFA3b
        /// </summary>
        [EnumMember(Value = "PDFA3b")]
        PDFA3b = 18,

        /// <summary>
        /// Enum PDFUA1 for value: PDFUA1
        /// </summary>
        [EnumMember(Value = "PDFUA1")]
        PDFUA1 = 19

    }

}
