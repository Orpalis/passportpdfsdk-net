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
    /// Defines the different available icons for a sticky note annotation.
    /// </summary>
    /// <value>Defines the different available icons for a sticky note annotation.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum StickyNoteAnnotationIcon
    {
        /// <summary>
        /// Enum Comment for value: Comment
        /// </summary>
        [EnumMember(Value = "Comment")]
        Comment = 1,

        /// <summary>
        /// Enum Key for value: Key
        /// </summary>
        [EnumMember(Value = "Key")]
        Key = 2,

        /// <summary>
        /// Enum Note for value: Note
        /// </summary>
        [EnumMember(Value = "Note")]
        Note = 3,

        /// <summary>
        /// Enum Help for value: Help
        /// </summary>
        [EnumMember(Value = "Help")]
        Help = 4,

        /// <summary>
        /// Enum NewParagraph for value: NewParagraph
        /// </summary>
        [EnumMember(Value = "NewParagraph")]
        NewParagraph = 5,

        /// <summary>
        /// Enum Paragraph for value: Paragraph
        /// </summary>
        [EnumMember(Value = "Paragraph")]
        Paragraph = 6,

        /// <summary>
        /// Enum Insert for value: Insert
        /// </summary>
        [EnumMember(Value = "Insert")]
        Insert = 7,

        /// <summary>
        /// Enum Check for value: Check
        /// </summary>
        [EnumMember(Value = "Check")]
        Check = 8,

        /// <summary>
        /// Enum Circle for value: Circle
        /// </summary>
        [EnumMember(Value = "Circle")]
        Circle = 9,

        /// <summary>
        /// Enum Cross for value: Cross
        /// </summary>
        [EnumMember(Value = "Cross")]
        Cross = 10,

        /// <summary>
        /// Enum CrossHairs for value: CrossHairs
        /// </summary>
        [EnumMember(Value = "CrossHairs")]
        CrossHairs = 11,

        /// <summary>
        /// Enum RightArrow for value: RightArrow
        /// </summary>
        [EnumMember(Value = "RightArrow")]
        RightArrow = 12,

        /// <summary>
        /// Enum RightPointer for value: RightPointer
        /// </summary>
        [EnumMember(Value = "RightPointer")]
        RightPointer = 13,

        /// <summary>
        /// Enum Star for value: Star
        /// </summary>
        [EnumMember(Value = "Star")]
        Star = 14,

        /// <summary>
        /// Enum UpArrow for value: UpArrow
        /// </summary>
        [EnumMember(Value = "UpArrow")]
        UpArrow = 15,

        /// <summary>
        /// Enum UpLeftArrow for value: UpLeftArrow
        /// </summary>
        [EnumMember(Value = "UpLeftArrow")]
        UpLeftArrow = 16

    }

}
