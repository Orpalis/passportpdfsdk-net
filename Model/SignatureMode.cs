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
    /// Specifies the security handler of a signature.
    /// </summary>
    /// <value>Specifies the security handler of a signature.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SignatureMode
    {
        /// <summary>
        /// Enum AdobePPKMS for value: AdobePPKMS
        /// </summary>
        [EnumMember(Value = "AdobePPKMS")]
        AdobePPKMS = 1,

        /// <summary>
        /// Enum AdobePPKLite for value: AdobePPKLite
        /// </summary>
        [EnumMember(Value = "AdobePPKLite")]
        AdobePPKLite = 2,

        /// <summary>
        /// Enum AdobeCADES for value: AdobeCADES
        /// </summary>
        [EnumMember(Value = "AdobeCADES")]
        AdobeCADES = 3

    }

}
