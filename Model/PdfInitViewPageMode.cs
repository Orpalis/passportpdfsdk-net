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
    /// Defines how the document shall be displayed when opened.
    /// </summary>
    /// <value>Defines how the document shall be displayed when opened.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PdfInitViewPageMode
    {
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,

        /// <summary>
        /// Enum Outline for value: Outline
        /// </summary>
        [EnumMember(Value = "Outline")]
        Outline = 2,

        /// <summary>
        /// Enum Thumbnails for value: Thumbnails
        /// </summary>
        [EnumMember(Value = "Thumbnails")]
        Thumbnails = 3,

        /// <summary>
        /// Enum FullScreen for value: FullScreen
        /// </summary>
        [EnumMember(Value = "FullScreen")]
        FullScreen = 4,

        /// <summary>
        /// Enum OC for value: OC
        /// </summary>
        [EnumMember(Value = "OC")]
        OC = 5,

        /// <summary>
        /// Enum Attachments for value: Attachments
        /// </summary>
        [EnumMember(Value = "Attachments")]
        Attachments = 6

    }

}
