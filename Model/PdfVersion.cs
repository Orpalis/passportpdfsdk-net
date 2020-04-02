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
    /// Specifies a PDF version for a reduced document.
    /// </summary>
    /// <value>Specifies a PDF version for a reduced document.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PdfVersion
    {
        /// <summary>
        /// Enum PdfVersionRetainExisting for value: PdfVersionRetainExisting
        /// </summary>
        [EnumMember(Value = "PdfVersionRetainExisting")]
        PdfVersionRetainExisting = 1,

        /// <summary>
        /// Enum PdfVersion14 for value: PdfVersion14
        /// </summary>
        [EnumMember(Value = "PdfVersion14")]
        PdfVersion14 = 2,

        /// <summary>
        /// Enum PdfVersion15 for value: PdfVersion15
        /// </summary>
        [EnumMember(Value = "PdfVersion15")]
        PdfVersion15 = 3,

        /// <summary>
        /// Enum PdfVersion16 for value: PdfVersion16
        /// </summary>
        [EnumMember(Value = "PdfVersion16")]
        PdfVersion16 = 4,

        /// <summary>
        /// Enum PdfVersion17 for value: PdfVersion17
        /// </summary>
        [EnumMember(Value = "PdfVersion17")]
        PdfVersion17 = 5,

        /// <summary>
        /// Enum PdfVersionA1a for value: PdfVersionA1a
        /// </summary>
        [EnumMember(Value = "PdfVersionA1a")]
        PdfVersionA1a = 6,

        /// <summary>
        /// Enum PdfVersionA1b for value: PdfVersionA1b
        /// </summary>
        [EnumMember(Value = "PdfVersionA1b")]
        PdfVersionA1b = 7,

        /// <summary>
        /// Enum PdfVersionA2a for value: PdfVersionA2a
        /// </summary>
        [EnumMember(Value = "PdfVersionA2a")]
        PdfVersionA2a = 8,

        /// <summary>
        /// Enum PdfVersionA2b for value: PdfVersionA2b
        /// </summary>
        [EnumMember(Value = "PdfVersionA2b")]
        PdfVersionA2b = 9

    }

}
