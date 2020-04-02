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
    /// Specifies the quality to be used for the compression of the images of the docuent.
    /// </summary>
    /// <value>Specifies the quality to be used for the compression of the images of the docuent.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ImageQuality
    {
        /// <summary>
        /// Enum ImageQualityLow for value: ImageQualityLow
        /// </summary>
        [EnumMember(Value = "ImageQualityLow")]
        ImageQualityLow = 1,

        /// <summary>
        /// Enum ImageQualityMedium for value: ImageQualityMedium
        /// </summary>
        [EnumMember(Value = "ImageQualityMedium")]
        ImageQualityMedium = 2,

        /// <summary>
        /// Enum ImageQualityHigh for value: ImageQualityHigh
        /// </summary>
        [EnumMember(Value = "ImageQualityHigh")]
        ImageQualityHigh = 3,

        /// <summary>
        /// Enum ImageQualityVeryHigh for value: ImageQualityVeryHigh
        /// </summary>
        [EnumMember(Value = "ImageQualityVeryHigh")]
        ImageQualityVeryHigh = 4

    }

}
