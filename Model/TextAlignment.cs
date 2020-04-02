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
    /// Defines the different available text alignments.
    /// </summary>
    /// <value>Defines the different available text alignments.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TextAlignment
    {
        /// <summary>
        /// Enum Near for value: Near
        /// </summary>
        [EnumMember(Value = "Near")]
        Near = 1,

        /// <summary>
        /// Enum Center for value: Center
        /// </summary>
        [EnumMember(Value = "Center")]
        Center = 2,

        /// <summary>
        /// Enum Far for value: Far
        /// </summary>
        [EnumMember(Value = "Far")]
        Far = 3

    }

}
