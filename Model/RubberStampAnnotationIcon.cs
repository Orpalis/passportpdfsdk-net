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
    /// Defines the different available icons for a rubber stamp annotation.
    /// </summary>
    /// <value>Defines the different available icons for a rubber stamp annotation.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum RubberStampAnnotationIcon
    {
        /// <summary>
        /// Enum Approved for value: Approved
        /// </summary>
        [EnumMember(Value = "Approved")]
        Approved = 1,

        /// <summary>
        /// Enum NotApproved for value: NotApproved
        /// </summary>
        [EnumMember(Value = "NotApproved")]
        NotApproved = 2,

        /// <summary>
        /// Enum NotForPublicRelease for value: NotForPublicRelease
        /// </summary>
        [EnumMember(Value = "NotForPublicRelease")]
        NotForPublicRelease = 3,

        /// <summary>
        /// Enum Confidential for value: Confidential
        /// </summary>
        [EnumMember(Value = "Confidential")]
        Confidential = 4,

        /// <summary>
        /// Enum Final for value: Final
        /// </summary>
        [EnumMember(Value = "Final")]
        Final = 5,

        /// <summary>
        /// Enum ForComment for value: ForComment
        /// </summary>
        [EnumMember(Value = "ForComment")]
        ForComment = 6,

        /// <summary>
        /// Enum Draft for value: Draft
        /// </summary>
        [EnumMember(Value = "Draft")]
        Draft = 7,

        /// <summary>
        /// Enum ForPublicRelease for value: ForPublicRelease
        /// </summary>
        [EnumMember(Value = "ForPublicRelease")]
        ForPublicRelease = 8,

        /// <summary>
        /// Enum SBCompleted for value: SBCompleted
        /// </summary>
        [EnumMember(Value = "SBCompleted")]
        SBCompleted = 9,

        /// <summary>
        /// Enum SBInformationOnly for value: SBInformationOnly
        /// </summary>
        [EnumMember(Value = "SBInformationOnly")]
        SBInformationOnly = 10,

        /// <summary>
        /// Enum SBVoid for value: SBVoid
        /// </summary>
        [EnumMember(Value = "SBVoid")]
        SBVoid = 11,

        /// <summary>
        /// Enum SBPreliminaryResults for value: SBPreliminaryResults
        /// </summary>
        [EnumMember(Value = "SBPreliminaryResults")]
        SBPreliminaryResults = 12,

        /// <summary>
        /// Enum SBRejected for value: SBRejected
        /// </summary>
        [EnumMember(Value = "SBRejected")]
        SBRejected = 13,

        /// <summary>
        /// Enum SHAccepted for value: SHAccepted
        /// </summary>
        [EnumMember(Value = "SHAccepted")]
        SHAccepted = 14,

        /// <summary>
        /// Enum SHInitialHere for value: SHInitialHere
        /// </summary>
        [EnumMember(Value = "SHInitialHere")]
        SHInitialHere = 15,

        /// <summary>
        /// Enum SHSignHere for value: SHSignHere
        /// </summary>
        [EnumMember(Value = "SHSignHere")]
        SHSignHere = 16,

        /// <summary>
        /// Enum SHWitness for value: SHWitness
        /// </summary>
        [EnumMember(Value = "SHWitness")]
        SHWitness = 17,

        /// <summary>
        /// Enum DApproved for value: DApproved
        /// </summary>
        [EnumMember(Value = "DApproved")]
        DApproved = 18,

        /// <summary>
        /// Enum DConfidential for value: DConfidential
        /// </summary>
        [EnumMember(Value = "DConfidential")]
        DConfidential = 19,

        /// <summary>
        /// Enum DReceived for value: DReceived
        /// </summary>
        [EnumMember(Value = "DReceived")]
        DReceived = 20,

        /// <summary>
        /// Enum DReviewed for value: DReviewed
        /// </summary>
        [EnumMember(Value = "DReviewed")]
        DReviewed = 21

    }

}
