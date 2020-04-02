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
    /// Specifies the level of the signature certification.
    /// </summary>
    /// <value>Specifies the level of the signature certification.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SignatureCertificationLevel
    {
        /// <summary>
        /// Enum NotCertified for value: NotCertified
        /// </summary>
        [EnumMember(Value = "NotCertified")]
        NotCertified = 1,

        /// <summary>
        /// Enum NoChanges for value: NoChanges
        /// </summary>
        [EnumMember(Value = "NoChanges")]
        NoChanges = 2,

        /// <summary>
        /// Enum FormFilling for value: FormFilling
        /// </summary>
        [EnumMember(Value = "FormFilling")]
        FormFilling = 3,

        /// <summary>
        /// Enum FormFillingAndAnnotations for value: FormFillingAndAnnotations
        /// </summary>
        [EnumMember(Value = "FormFillingAndAnnotations")]
        FormFillingAndAnnotations = 4

    }

}
