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
    /// Defines the boundary boxes (page boxes) that relate to the size of the pages in the PDF document.
    /// </summary>
    /// <value>Defines the boundary boxes (page boxes) that relate to the size of the pages in the PDF document.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PdfPageBox
    {
        /// <summary>
        /// Enum MediaBox for value: MediaBox
        /// </summary>
        [EnumMember(Value = "MediaBox")]
        MediaBox = 1,

        /// <summary>
        /// Enum CropBox for value: CropBox
        /// </summary>
        [EnumMember(Value = "CropBox")]
        CropBox = 2,

        /// <summary>
        /// Enum BleedBox for value: BleedBox
        /// </summary>
        [EnumMember(Value = "BleedBox")]
        BleedBox = 3,

        /// <summary>
        /// Enum TrimBox for value: TrimBox
        /// </summary>
        [EnumMember(Value = "TrimBox")]
        TrimBox = 4,

        /// <summary>
        /// Enum ArtBox for value: ArtBox
        /// </summary>
        [EnumMember(Value = "ArtBox")]
        ArtBox = 5

    }

}
