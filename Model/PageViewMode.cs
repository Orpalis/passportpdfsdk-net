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
    /// Defines how the pages are displayed on the screen.
    /// </summary>
    /// <value>Defines how the pages are displayed on the screen.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PageViewMode
    {
        /// <summary>
        /// Enum SinglePageView for value: SinglePageView
        /// </summary>
        [EnumMember(Value = "SinglePageView")]
        SinglePageView = 1,

        /// <summary>
        /// Enum MultiplePagesView for value: MultiplePagesView
        /// </summary>
        [EnumMember(Value = "MultiplePagesView")]
        MultiplePagesView = 2

    }

}
