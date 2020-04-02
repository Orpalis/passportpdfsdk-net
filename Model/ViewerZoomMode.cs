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
    /// Defines ViewerZoomMode
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ViewerZoomMode
    {
        /// <summary>
        /// Enum ZoomMode100 for value: ZoomMode100
        /// </summary>
        [EnumMember(Value = "ZoomMode100")]
        ZoomMode100 = 1,

        /// <summary>
        /// Enum ZoomModeFitToViewer for value: ZoomModeFitToViewer
        /// </summary>
        [EnumMember(Value = "ZoomModeFitToViewer")]
        ZoomModeFitToViewer = 2,

        /// <summary>
        /// Enum ZoomModeWidthViewer for value: ZoomModeWidthViewer
        /// </summary>
        [EnumMember(Value = "ZoomModeWidthViewer")]
        ZoomModeWidthViewer = 3,

        /// <summary>
        /// Enum ZoomModeCustom for value: ZoomModeCustom
        /// </summary>
        [EnumMember(Value = "ZoomModeCustom")]
        ZoomModeCustom = 4,

        /// <summary>
        /// Enum ZoomModeHeightViewer for value: ZoomModeHeightViewer
        /// </summary>
        [EnumMember(Value = "ZoomModeHeightViewer")]
        ZoomModeHeightViewer = 5,

        /// <summary>
        /// Enum ZoomModeToViewer for value: ZoomModeToViewer
        /// </summary>
        [EnumMember(Value = "ZoomModeToViewer")]
        ZoomModeToViewer = 6,

        /// <summary>
        /// Enum ZoomModeShrinkToViewerWidth for value: ZoomModeShrinkToViewerWidth
        /// </summary>
        [EnumMember(Value = "ZoomModeShrinkToViewerWidth")]
        ZoomModeShrinkToViewerWidth = 7

    }

}
