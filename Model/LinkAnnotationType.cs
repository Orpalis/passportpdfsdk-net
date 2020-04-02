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
    /// Defines the supported types of Link Annotation.
    /// </summary>
    /// <value>Defines the supported types of Link Annotation.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum LinkAnnotationType
    {
        /// <summary>
        /// Enum Page for value: Page
        /// </summary>
        [EnumMember(Value = "Page")]
        Page = 1,

        /// <summary>
        /// Enum Web for value: Web
        /// </summary>
        [EnumMember(Value = "Web")]
        Web = 2

    }

}
