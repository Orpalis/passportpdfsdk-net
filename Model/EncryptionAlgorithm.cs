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
    /// Specifies the encryption algorithm.
    /// </summary>
    /// <value>Specifies the encryption algorithm.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum EncryptionAlgorithm
    {
        /// <summary>
        /// Enum PdfEncryptionNone for value: PdfEncryptionNone
        /// </summary>
        [EnumMember(Value = "PdfEncryptionNone")]
        PdfEncryptionNone = 1,

        /// <summary>
        /// Enum PdfEncryption40BitRC4 for value: PdfEncryption40BitRC4
        /// </summary>
        [EnumMember(Value = "PdfEncryption40BitRC4")]
        PdfEncryption40BitRC4 = 2,

        /// <summary>
        /// Enum PdfEncryption128BitRC4 for value: PdfEncryption128BitRC4
        /// </summary>
        [EnumMember(Value = "PdfEncryption128BitRC4")]
        PdfEncryption128BitRC4 = 3,

        /// <summary>
        /// Enum PdfEncryption128BitAES for value: PdfEncryption128BitAES
        /// </summary>
        [EnumMember(Value = "PdfEncryption128BitAES")]
        PdfEncryption128BitAES = 4,

        /// <summary>
        /// Enum PdfEncryption256BitAES for value: PdfEncryption256BitAES
        /// </summary>
        [EnumMember(Value = "PdfEncryption256BitAES")]
        PdfEncryption256BitAES = 5

    }

}
