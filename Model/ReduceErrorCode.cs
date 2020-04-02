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
    /// Specifies the different errors which can cause the failure of a reduce action.
    /// </summary>
    /// <value>Specifies the different errors which can cause the failure of a reduce action.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ReduceErrorCode
    {
        /// <summary>
        /// Enum OK for value: OK
        /// </summary>
        [EnumMember(Value = "OK")]
        OK = 1,

        /// <summary>
        /// Enum GetPageImagesCount for value: GetPageImagesCount
        /// </summary>
        [EnumMember(Value = "GetPageImagesCount")]
        GetPageImagesCount = 2,

        /// <summary>
        /// Enum MRCPostOperationsFailure for value: MRCPostOperationsFailure
        /// </summary>
        [EnumMember(Value = "MRCPostOperationsFailure")]
        MRCPostOperationsFailure = 3,

        /// <summary>
        /// Enum PageConversionFailure for value: PageConversionFailure
        /// </summary>
        [EnumMember(Value = "PageConversionFailure")]
        PageConversionFailure = 4,

        /// <summary>
        /// Enum DocumentEncrypted for value: DocumentEncrypted
        /// </summary>
        [EnumMember(Value = "DocumentEncrypted")]
        DocumentEncrypted = 5,

        /// <summary>
        /// Enum UnexpectedError for value: UnexpectedError
        /// </summary>
        [EnumMember(Value = "UnexpectedError")]
        UnexpectedError = 6

    }

}
