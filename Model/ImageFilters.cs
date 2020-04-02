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
    /// Specifies a list of available image filters and effects.
    /// </summary>
    /// <value>Specifies a list of available image filters and effects.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ImageFilters
    {
        /// <summary>
        /// Enum AddNoise for value: addNoise
        /// </summary>
        [EnumMember(Value = "addNoise")]
        AddNoise = 1,

        /// <summary>
        /// Enum Aqua for value: aqua
        /// </summary>
        [EnumMember(Value = "aqua")]
        Aqua = 2,

        /// <summary>
        /// Enum Blur for value: blur
        /// </summary>
        [EnumMember(Value = "blur")]
        Blur = 3,

        /// <summary>
        /// Enum Diffuse for value: diffuse
        /// </summary>
        [EnumMember(Value = "diffuse")]
        Diffuse = 4,

        /// <summary>
        /// Enum Fire for value: fire
        /// </summary>
        [EnumMember(Value = "fire")]
        Fire = 5,

        /// <summary>
        /// Enum Grayscale for value: grayscale
        /// </summary>
        [EnumMember(Value = "grayscale")]
        Grayscale = 6,

        /// <summary>
        /// Enum Sepia for value: sepia
        /// </summary>
        [EnumMember(Value = "sepia")]
        Sepia = 7,

        /// <summary>
        /// Enum Negative for value: negative
        /// </summary>
        [EnumMember(Value = "negative")]
        Negative = 8,

        /// <summary>
        /// Enum Pixelize for value: pixelize
        /// </summary>
        [EnumMember(Value = "pixelize")]
        Pixelize = 9,

        /// <summary>
        /// Enum Relief for value: relief
        /// </summary>
        [EnumMember(Value = "relief")]
        Relief = 10,

        /// <summary>
        /// Enum ScanLine for value: scanLine
        /// </summary>
        [EnumMember(Value = "scanLine")]
        ScanLine = 11,

        /// <summary>
        /// Enum Sharpen for value: sharpen
        /// </summary>
        [EnumMember(Value = "sharpen")]
        Sharpen = 12,

        /// <summary>
        /// Enum Smooth for value: smooth
        /// </summary>
        [EnumMember(Value = "smooth")]
        Smooth = 13,

        /// <summary>
        /// Enum EdgeEnhancement for value: edgeEnhancement
        /// </summary>
        [EnumMember(Value = "edgeEnhancement")]
        EdgeEnhancement = 14,

        /// <summary>
        /// Enum Contour for value: contour
        /// </summary>
        [EnumMember(Value = "contour")]
        Contour = 15,

        /// <summary>
        /// Enum Emboss for value: emboss
        /// </summary>
        [EnumMember(Value = "emboss")]
        Emboss = 16,

        /// <summary>
        /// Enum Engrave for value: engrave
        /// </summary>
        [EnumMember(Value = "engrave")]
        Engrave = 17,

        /// <summary>
        /// Enum Dilate for value: dilate
        /// </summary>
        [EnumMember(Value = "dilate")]
        Dilate = 18,

        /// <summary>
        /// Enum Erode for value: erode
        /// </summary>
        [EnumMember(Value = "erode")]
        Erode = 19,

        /// <summary>
        /// Enum ConnectedContour for value: connectedContour
        /// </summary>
        [EnumMember(Value = "connectedContour")]
        ConnectedContour = 20,

        /// <summary>
        /// Enum Soften for value: soften
        /// </summary>
        [EnumMember(Value = "soften")]
        Soften = 21,

        /// <summary>
        /// Enum Colorize for value: colorize
        /// </summary>
        [EnumMember(Value = "colorize")]
        Colorize = 22,

        /// <summary>
        /// Enum Gaussian for value: gaussian
        /// </summary>
        [EnumMember(Value = "gaussian")]
        Gaussian = 23,

        /// <summary>
        /// Enum Max for value: max
        /// </summary>
        [EnumMember(Value = "max")]
        Max = 24,

        /// <summary>
        /// Enum Min for value: min
        /// </summary>
        [EnumMember(Value = "min")]
        Min = 25,

        /// <summary>
        /// Enum Median for value: median
        /// </summary>
        [EnumMember(Value = "median")]
        Median = 26,

        /// <summary>
        /// Enum SubtractBackground for value: subtractBackground
        /// </summary>
        [EnumMember(Value = "subtractBackground")]
        SubtractBackground = 27,

        /// <summary>
        /// Enum Unsharpmask for value: unsharpmask
        /// </summary>
        [EnumMember(Value = "unsharpmask")]
        Unsharpmask = 28

    }

}
