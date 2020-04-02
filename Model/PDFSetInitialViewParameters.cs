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
    /// Represents the parameters for a set initial view action.
    /// </summary>
    [DataContract]
    public partial class PdfSetInitialViewParameters :  IEquatable<PdfSetInitialViewParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfSetInitialViewParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfSetInitialViewParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfSetInitialViewParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        public PdfSetInitialViewParameters(string fileId)
        {
            FileId = fileId;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Gets or Sets PageMode
        /// </summary>
        [DataMember(Name="PageMode")]
        public PdfInitViewPageMode PageMode { get; set; }

        /// <summary>
        /// Gets or Sets LayoutMode
        /// </summary>
        [DataMember(Name="LayoutMode")]
        public PdfInitViewLayoutMode LayoutMode { get; set; }

        /// <summary>
        /// Gets or Sets NonFullScreenPageMode
        /// </summary>
        [DataMember(Name="NonFullScreenPageMode")]
        public PdfInitViewNonFullScreenPageMode NonFullScreenPageMode { get; set; }

        /// <summary>
        /// Specifies which page should be displayed when the document is opened.
        /// </summary>
        [DataMember(Name="OpenPage")]
        public int OpenPage { get; set; } = 1;

        /// <summary>
        /// Specifies the default zoom factor to be used when the document is opened. Value of 1 to represent the 100% zoom, 2 means 200%, 0,5 means 50%, etc.
        /// </summary>
        [DataMember(Name="OpenZoom")]
        public float OpenZoom { get; set; } = 1F;

        /// <summary>
        /// A flag specifying whether to hide the viewer application’s tool bars when the document is active. Default value: false.
        /// </summary>
        [DataMember(Name="HideToolbar")]
        public bool HideToolbar { get; set; } = false;

        /// <summary>
        /// (Optional) A flag specifying whether to hide the viewer application’s menu bar when the document is active. Default value: false.
        /// </summary>
        [DataMember(Name="HideMenubar")]
        public bool HideMenubar { get; set; } = false;

        /// <summary>
        /// (Optional) A flag specifying whether to hide user interface elements in the document’s window (such as scroll bars and navigation controls),  leaving only the document’s contents displayed. Default value: false.
        /// </summary>
        [DataMember(Name="HideWindowUI")]
        public bool HideWindowUI { get; set; } = false;

        /// <summary>
        /// (Optional) A flag specifying whether to resize the document’s window to fit the size of the first displayed page. Default value: false.
        /// </summary>
        [DataMember(Name="FitWindow")]
        public bool FitWindow { get; set; } = false;

        /// <summary>
        /// (Optional) A flag specifying whether to position the document’s window in the center of the screen. Default value: false.
        /// </summary>
        [DataMember(Name="CenterWindow")]
        public bool CenterWindow { get; set; } = false;

        /// <summary>
        /// (Optional; PDF 1.4) A flag specifying whether the window’s title bar should display the document title taken from the Title entry of the document information dictionary.  If false, the title bar should instead display the name of the PDF file containing the document. Default value: false.
        /// </summary>
        [DataMember(Name="DisplayDocTitle")]
        public bool DisplayDocTitle { get; set; } = false;

        /// <summary>
        /// Returns the String presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as PdfSetInitialViewParameters);
        }

        /// <summary>
        /// Returns true if PdfSetInitialViewParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfSetInitialViewParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfSetInitialViewParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    FileId == input.FileId ||
                    (FileId != null &&
                    FileId.Equals(input.FileId))
                ) && 
                (
                    PageMode == input.PageMode ||
                    PageMode.Equals(input.PageMode)
                ) && 
                (
                    LayoutMode == input.LayoutMode ||
                    LayoutMode.Equals(input.LayoutMode)
                ) && 
                (
                    NonFullScreenPageMode == input.NonFullScreenPageMode ||
                    NonFullScreenPageMode.Equals(input.NonFullScreenPageMode)
                ) && 
                (
                    OpenPage == input.OpenPage ||
                    OpenPage.Equals(input.OpenPage)
                ) && 
                (
                    OpenZoom == input.OpenZoom ||
                    OpenZoom.Equals(input.OpenZoom)
                ) && 
                (
                    HideToolbar == input.HideToolbar ||
                    HideToolbar.Equals(input.HideToolbar)
                ) && 
                (
                    HideMenubar == input.HideMenubar ||
                    HideMenubar.Equals(input.HideMenubar)
                ) && 
                (
                    HideWindowUI == input.HideWindowUI ||
                    HideWindowUI.Equals(input.HideWindowUI)
                ) && 
                (
                    FitWindow == input.FitWindow ||
                    FitWindow.Equals(input.FitWindow)
                ) && 
                (
                    CenterWindow == input.CenterWindow ||
                    CenterWindow.Equals(input.CenterWindow)
                ) && 
                (
                    DisplayDocTitle == input.DisplayDocTitle ||
                    DisplayDocTitle.Equals(input.DisplayDocTitle)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (FileId != null)
                    hashCode = hashCode * 59 + FileId.GetHashCode();
                hashCode = hashCode * 59 + PageMode.GetHashCode();
                hashCode = hashCode * 59 + LayoutMode.GetHashCode();
                hashCode = hashCode * 59 + NonFullScreenPageMode.GetHashCode();
                hashCode = hashCode * 59 + OpenPage.GetHashCode();
                hashCode = hashCode * 59 + OpenZoom.GetHashCode();
                hashCode = hashCode * 59 + HideToolbar.GetHashCode();
                hashCode = hashCode * 59 + HideMenubar.GetHashCode();
                hashCode = hashCode * 59 + HideWindowUI.GetHashCode();
                hashCode = hashCode * 59 + FitWindow.GetHashCode();
                hashCode = hashCode * 59 + CenterWindow.GetHashCode();
                hashCode = hashCode * 59 + DisplayDocTitle.GetHashCode();
                return hashCode;
            }
        }
    }

}
