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
    /// Defines the different type of barcodes which can be read.
    /// </summary>
    /// <value>Defines the different type of barcodes which can be read.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum BarcodeType
    {
        /// <summary>
        /// Enum Linear for value: Linear
        /// </summary>
        [EnumMember(Value = "Linear")]
        Linear = 1,

        /// <summary>
        /// Enum DataMatrix for value: DataMatrix
        /// </summary>
        [EnumMember(Value = "DataMatrix")]
        DataMatrix = 2,

        /// <summary>
        /// Enum QR for value: QR
        /// </summary>
        [EnumMember(Value = "QR")]
        QR = 3,

        /// <summary>
        /// Enum MicroQR for value: MicroQR
        /// </summary>
        [EnumMember(Value = "MicroQR")]
        MicroQR = 4,

        /// <summary>
        /// Enum PDF417 for value: PDF417
        /// </summary>
        [EnumMember(Value = "PDF417")]
        PDF417 = 5,

        /// <summary>
        /// Enum Aztec for value: Aztec
        /// </summary>
        [EnumMember(Value = "Aztec")]
        Aztec = 6

    }

}
