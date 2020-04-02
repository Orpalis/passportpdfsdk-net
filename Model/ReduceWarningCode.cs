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
    /// Specifies the different warnings which can occur during the process of a reduce action.
    /// </summary>
    /// <value>Specifies the different warnings which can occur during the process of a reduce action.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ReduceWarningCode
    {
        /// <summary>
        /// Enum OK for value: OK
        /// </summary>
        [EnumMember(Value = "OK")]
        OK = 1,

        /// <summary>
        /// Enum ImageExtractionFailure for value: ImageExtractionFailure
        /// </summary>
        [EnumMember(Value = "ImageExtractionFailure")]
        ImageExtractionFailure = 2,

        /// <summary>
        /// Enum ColorDetectionFailure for value: ColorDetectionFailure
        /// </summary>
        [EnumMember(Value = "ColorDetectionFailure")]
        ColorDetectionFailure = 3,

        /// <summary>
        /// Enum ImageResizeFailure for value: ImageResizeFailure
        /// </summary>
        [EnumMember(Value = "ImageResizeFailure")]
        ImageResizeFailure = 4,

        /// <summary>
        /// Enum ImageCropFailure for value: ImageCropFailure
        /// </summary>
        [EnumMember(Value = "ImageCropFailure")]
        ImageCropFailure = 5,

        /// <summary>
        /// Enum ImageResolutionObtentionFailure for value: ImageResolutionObtentionFailure
        /// </summary>
        [EnumMember(Value = "ImageResolutionObtentionFailure")]
        ImageResolutionObtentionFailure = 6,

        /// <summary>
        /// Enum ImageReplacementFailure for value: ImageReplacementFailure
        /// </summary>
        [EnumMember(Value = "ImageReplacementFailure")]
        ImageReplacementFailure = 7,

        /// <summary>
        /// Enum MRCImageReplacementFailure for value: MRCImageReplacementFailure
        /// </summary>
        [EnumMember(Value = "MRCImageReplacementFailure")]
        MRCImageReplacementFailure = 8,

        /// <summary>
        /// Enum PageSelectionFailure for value: PageSelectionFailure
        /// </summary>
        [EnumMember(Value = "PageSelectionFailure")]
        PageSelectionFailure = 9,

        /// <summary>
        /// Enum ImageObtentionFailure for value: ImageObtentionFailure
        /// </summary>
        [EnumMember(Value = "ImageObtentionFailure")]
        ImageObtentionFailure = 10,

        /// <summary>
        /// Enum FileSizeReductionFailure for value: FileSizeReductionFailure
        /// </summary>
        [EnumMember(Value = "FileSizeReductionFailure")]
        FileSizeReductionFailure = 11,

        /// <summary>
        /// Enum BlankPageRemovalFailure for value: BlankPageRemovalFailure
        /// </summary>
        [EnumMember(Value = "BlankPageRemovalFailure")]
        BlankPageRemovalFailure = 12

    }

}
