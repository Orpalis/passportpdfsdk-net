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
    /// Specifies the standard scheme to be used to compress image data in PDF documents.
    /// </summary>
    /// <value>Specifies the standard scheme to be used to compress image data in PDF documents.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PdfImageCompressionScheme
    {
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,

        /// <summary>
        /// Enum Flate for value: Flate
        /// </summary>
        [EnumMember(Value = "Flate")]
        Flate = 2,

        /// <summary>
        /// Enum CCIT4 for value: CCIT4
        /// </summary>
        [EnumMember(Value = "CCIT4")]
        CCIT4 = 3,

        /// <summary>
        /// Enum JPEG for value: JPEG
        /// </summary>
        [EnumMember(Value = "JPEG")]
        JPEG = 4,

        /// <summary>
        /// Enum JBIG2 for value: JBIG2
        /// </summary>
        [EnumMember(Value = "JBIG2")]
        JBIG2 = 5,

        /// <summary>
        /// Enum JPEG2000 for value: JPEG2000
        /// </summary>
        [EnumMember(Value = "JPEG2000")]
        JPEG2000 = 6

    }

}
