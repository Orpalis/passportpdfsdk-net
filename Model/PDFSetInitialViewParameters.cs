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
using OpenAPIDateConverter = PassportPDF.Client.OpenAPIDateConverter;

namespace PassportPDF.Model
{
    /// <summary>
    /// Represents the parameters for a set initial view action.
    /// </summary>
    [DataContract]
    public partial class PDFSetInitialViewParameters :  IEquatable<PDFSetInitialViewParameters>, IValidatableObject
    {
        /// <summary>
        /// Specifies how the document shall be displayed when opened.
        /// </summary>
        /// <value>Specifies how the document shall be displayed when opened.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PageModeEnum
        {
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,

            /// <summary>
            /// Enum Outline for value: Outline
            /// </summary>
            [EnumMember(Value = "Outline")]
            Outline = 2,

            /// <summary>
            /// Enum Thumbnails for value: Thumbnails
            /// </summary>
            [EnumMember(Value = "Thumbnails")]
            Thumbnails = 3,

            /// <summary>
            /// Enum FullScreen for value: FullScreen
            /// </summary>
            [EnumMember(Value = "FullScreen")]
            FullScreen = 4,

            /// <summary>
            /// Enum OC for value: OC
            /// </summary>
            [EnumMember(Value = "OC")]
            OC = 5,

            /// <summary>
            /// Enum Attachments for value: Attachments
            /// </summary>
            [EnumMember(Value = "Attachments")]
            Attachments = 6

        }

        /// <summary>
        /// Specifies how the document shall be displayed when opened.
        /// </summary>
        /// <value>Specifies how the document shall be displayed when opened.</value>
        [DataMember(Name="PageMode", EmitDefaultValue=false)]
        public PageModeEnum? PageMode { get; set; }
        /// <summary>
        /// Specifies the page layout to be used when the document is opened.
        /// </summary>
        /// <value>Specifies the page layout to be used when the document is opened.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LayoutModeEnum
        {
            /// <summary>
            /// Enum SinglePage for value: SinglePage
            /// </summary>
            [EnumMember(Value = "SinglePage")]
            SinglePage = 1,

            /// <summary>
            /// Enum OneColumn for value: OneColumn
            /// </summary>
            [EnumMember(Value = "OneColumn")]
            OneColumn = 2,

            /// <summary>
            /// Enum TwoColumnLeft for value: TwoColumnLeft
            /// </summary>
            [EnumMember(Value = "TwoColumnLeft")]
            TwoColumnLeft = 3,

            /// <summary>
            /// Enum TwoColumnRight for value: TwoColumnRight
            /// </summary>
            [EnumMember(Value = "TwoColumnRight")]
            TwoColumnRight = 4,

            /// <summary>
            /// Enum TwoPageLeft for value: TwoPageLeft
            /// </summary>
            [EnumMember(Value = "TwoPageLeft")]
            TwoPageLeft = 5,

            /// <summary>
            /// Enum TwoPageRight for value: TwoPageRight
            /// </summary>
            [EnumMember(Value = "TwoPageRight")]
            TwoPageRight = 6

        }

        /// <summary>
        /// Specifies the page layout to be used when the document is opened.
        /// </summary>
        /// <value>Specifies the page layout to be used when the document is opened.</value>
        [DataMember(Name="LayoutMode", EmitDefaultValue=false)]
        public LayoutModeEnum? LayoutMode { get; set; }
        /// <summary>
        /// Specifies how the document shall be displayed when exiting full-screen mode.
        /// </summary>
        /// <value>Specifies how the document shall be displayed when exiting full-screen mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NonFullScreenPageModeEnum
        {
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,

            /// <summary>
            /// Enum Outline for value: Outline
            /// </summary>
            [EnumMember(Value = "Outline")]
            Outline = 2,

            /// <summary>
            /// Enum Thumbnails for value: Thumbnails
            /// </summary>
            [EnumMember(Value = "Thumbnails")]
            Thumbnails = 3,

            /// <summary>
            /// Enum OC for value: OC
            /// </summary>
            [EnumMember(Value = "OC")]
            OC = 4

        }

        /// <summary>
        /// Specifies how the document shall be displayed when exiting full-screen mode.
        /// </summary>
        /// <value>Specifies how the document shall be displayed when exiting full-screen mode.</value>
        [DataMember(Name="NonFullScreenPageMode", EmitDefaultValue=false)]
        public NonFullScreenPageModeEnum? NonFullScreenPageMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFSetInitialViewParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFSetInitialViewParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFSetInitialViewParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageMode">Specifies how the document shall be displayed when opened. (default to PageModeEnum.None).</param>
        /// <param name="layoutMode">Specifies the page layout to be used when the document is opened. (default to LayoutModeEnum.SinglePage).</param>
        /// <param name="nonFullScreenPageMode">Specifies how the document shall be displayed when exiting full-screen mode. (default to NonFullScreenPageModeEnum.None).</param>
        /// <param name="openPage">Specifies which page should be displayed when the document is opened. (default to 1).</param>
        /// <param name="openZoom">Specifies the default zoom factor to be used when the document is opened. Value of 1 to represent the 100% zoom, 2 means 200%, 0,5 means 50%, etc. (default to 1.0F).</param>
        /// <param name="hideToolbar">A flag specifying whether to hide the viewer application’s tool bars when the document is active. Default value: false..</param>
        /// <param name="hideMenubar">(Optional) A flag specifying whether to hide the viewer application’s menu bar when the document is active. Default value: false..</param>
        /// <param name="hideWindowUI">(Optional) A flag specifying whether to hide user interface elements in the document’s window (such as scroll bars and navigation controls),  leaving only the document’s contents displayed. Default value: false..</param>
        /// <param name="fitWindow">(Optional) A flag specifying whether to resize the document’s window to fit the size of the first displayed page. Default value: false..</param>
        /// <param name="centerWindow">(Optional) A flag specifying whether to position the document’s window in the center of the screen. Default value: false..</param>
        /// <param name="displayDocTitle">(Optional; PDF 1.4) A flag specifying whether the window’s title bar should display the document title taken from the Title entry of the document information dictionary.  If false, the title bar should instead display the name of the PDF file containing the document. Default value: false..</param>
        public PDFSetInitialViewParameters(string fileId = default(string), PageModeEnum? pageMode = PageModeEnum.None, LayoutModeEnum? layoutMode = LayoutModeEnum.SinglePage, NonFullScreenPageModeEnum? nonFullScreenPageMode = NonFullScreenPageModeEnum.None, int? openPage = 1, float? openZoom = 1.0F, bool? hideToolbar = default(bool?), bool? hideMenubar = default(bool?), bool? hideWindowUI = default(bool?), bool? fitWindow = default(bool?), bool? centerWindow = default(bool?), bool? displayDocTitle = default(bool?))
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for PDFSetInitialViewParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            // use default value if no "pageMode" provided
            if (pageMode == null)
            {
                this.PageMode = PageModeEnum.None;
            }
            else
            {
                this.PageMode = pageMode;
            }
            // use default value if no "layoutMode" provided
            if (layoutMode == null)
            {
                this.LayoutMode = LayoutModeEnum.SinglePage;
            }
            else
            {
                this.LayoutMode = layoutMode;
            }
            // use default value if no "nonFullScreenPageMode" provided
            if (nonFullScreenPageMode == null)
            {
                this.NonFullScreenPageMode = NonFullScreenPageModeEnum.None;
            }
            else
            {
                this.NonFullScreenPageMode = nonFullScreenPageMode;
            }
            // use default value if no "openPage" provided
            if (openPage == null)
            {
                this.OpenPage = 1;
            }
            else
            {
                this.OpenPage = openPage;
            }
            // use default value if no "openZoom" provided
            if (openZoom == null)
            {
                this.OpenZoom = 1.0F;
            }
            else
            {
                this.OpenZoom = openZoom;
            }
            this.HideToolbar = hideToolbar;
            this.HideMenubar = hideMenubar;
            this.HideWindowUI = hideWindowUI;
            this.FitWindow = fitWindow;
            this.CenterWindow = centerWindow;
            this.DisplayDocTitle = displayDocTitle;
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }




        /// <summary>
        /// Specifies which page should be displayed when the document is opened.
        /// </summary>
        /// <value>Specifies which page should be displayed when the document is opened.</value>
        [DataMember(Name="OpenPage", EmitDefaultValue=false)]
        public int? OpenPage { get; set; }

        /// <summary>
        /// Specifies the default zoom factor to be used when the document is opened. Value of 1 to represent the 100% zoom, 2 means 200%, 0,5 means 50%, etc.
        /// </summary>
        /// <value>Specifies the default zoom factor to be used when the document is opened. Value of 1 to represent the 100% zoom, 2 means 200%, 0,5 means 50%, etc.</value>
        [DataMember(Name="OpenZoom", EmitDefaultValue=false)]
        public float? OpenZoom { get; set; }

        /// <summary>
        /// A flag specifying whether to hide the viewer application’s tool bars when the document is active. Default value: false.
        /// </summary>
        /// <value>A flag specifying whether to hide the viewer application’s tool bars when the document is active. Default value: false.</value>
        [DataMember(Name="HideToolbar", EmitDefaultValue=false)]
        public bool? HideToolbar { get; set; }

        /// <summary>
        /// (Optional) A flag specifying whether to hide the viewer application’s menu bar when the document is active. Default value: false.
        /// </summary>
        /// <value>(Optional) A flag specifying whether to hide the viewer application’s menu bar when the document is active. Default value: false.</value>
        [DataMember(Name="HideMenubar", EmitDefaultValue=false)]
        public bool? HideMenubar { get; set; }

        /// <summary>
        /// (Optional) A flag specifying whether to hide user interface elements in the document’s window (such as scroll bars and navigation controls),  leaving only the document’s contents displayed. Default value: false.
        /// </summary>
        /// <value>(Optional) A flag specifying whether to hide user interface elements in the document’s window (such as scroll bars and navigation controls),  leaving only the document’s contents displayed. Default value: false.</value>
        [DataMember(Name="HideWindowUI", EmitDefaultValue=false)]
        public bool? HideWindowUI { get; set; }

        /// <summary>
        /// (Optional) A flag specifying whether to resize the document’s window to fit the size of the first displayed page. Default value: false.
        /// </summary>
        /// <value>(Optional) A flag specifying whether to resize the document’s window to fit the size of the first displayed page. Default value: false.</value>
        [DataMember(Name="FitWindow", EmitDefaultValue=false)]
        public bool? FitWindow { get; set; }

        /// <summary>
        /// (Optional) A flag specifying whether to position the document’s window in the center of the screen. Default value: false.
        /// </summary>
        /// <value>(Optional) A flag specifying whether to position the document’s window in the center of the screen. Default value: false.</value>
        [DataMember(Name="CenterWindow", EmitDefaultValue=false)]
        public bool? CenterWindow { get; set; }

        /// <summary>
        /// (Optional; PDF 1.4) A flag specifying whether the window’s title bar should display the document title taken from the Title entry of the document information dictionary.  If false, the title bar should instead display the name of the PDF file containing the document. Default value: false.
        /// </summary>
        /// <value>(Optional; PDF 1.4) A flag specifying whether the window’s title bar should display the document title taken from the Title entry of the document information dictionary.  If false, the title bar should instead display the name of the PDF file containing the document. Default value: false.</value>
        [DataMember(Name="DisplayDocTitle", EmitDefaultValue=false)]
        public bool? DisplayDocTitle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFSetInitialViewParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageMode: ").Append(PageMode).Append("\n");
            sb.Append("  LayoutMode: ").Append(LayoutMode).Append("\n");
            sb.Append("  NonFullScreenPageMode: ").Append(NonFullScreenPageMode).Append("\n");
            sb.Append("  OpenPage: ").Append(OpenPage).Append("\n");
            sb.Append("  OpenZoom: ").Append(OpenZoom).Append("\n");
            sb.Append("  HideToolbar: ").Append(HideToolbar).Append("\n");
            sb.Append("  HideMenubar: ").Append(HideMenubar).Append("\n");
            sb.Append("  HideWindowUI: ").Append(HideWindowUI).Append("\n");
            sb.Append("  FitWindow: ").Append(FitWindow).Append("\n");
            sb.Append("  CenterWindow: ").Append(CenterWindow).Append("\n");
            sb.Append("  DisplayDocTitle: ").Append(DisplayDocTitle).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(input as PDFSetInitialViewParameters);
        }

        /// <summary>
        /// Returns true if PDFSetInitialViewParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFSetInitialViewParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFSetInitialViewParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileId == input.FileId ||
                    (this.FileId != null &&
                    this.FileId.Equals(input.FileId))
                ) && 
                (
                    this.PageMode == input.PageMode ||
                    (this.PageMode != null &&
                    this.PageMode.Equals(input.PageMode))
                ) && 
                (
                    this.LayoutMode == input.LayoutMode ||
                    (this.LayoutMode != null &&
                    this.LayoutMode.Equals(input.LayoutMode))
                ) && 
                (
                    this.NonFullScreenPageMode == input.NonFullScreenPageMode ||
                    (this.NonFullScreenPageMode != null &&
                    this.NonFullScreenPageMode.Equals(input.NonFullScreenPageMode))
                ) && 
                (
                    this.OpenPage == input.OpenPage ||
                    (this.OpenPage != null &&
                    this.OpenPage.Equals(input.OpenPage))
                ) && 
                (
                    this.OpenZoom == input.OpenZoom ||
                    (this.OpenZoom != null &&
                    this.OpenZoom.Equals(input.OpenZoom))
                ) && 
                (
                    this.HideToolbar == input.HideToolbar ||
                    (this.HideToolbar != null &&
                    this.HideToolbar.Equals(input.HideToolbar))
                ) && 
                (
                    this.HideMenubar == input.HideMenubar ||
                    (this.HideMenubar != null &&
                    this.HideMenubar.Equals(input.HideMenubar))
                ) && 
                (
                    this.HideWindowUI == input.HideWindowUI ||
                    (this.HideWindowUI != null &&
                    this.HideWindowUI.Equals(input.HideWindowUI))
                ) && 
                (
                    this.FitWindow == input.FitWindow ||
                    (this.FitWindow != null &&
                    this.FitWindow.Equals(input.FitWindow))
                ) && 
                (
                    this.CenterWindow == input.CenterWindow ||
                    (this.CenterWindow != null &&
                    this.CenterWindow.Equals(input.CenterWindow))
                ) && 
                (
                    this.DisplayDocTitle == input.DisplayDocTitle ||
                    (this.DisplayDocTitle != null &&
                    this.DisplayDocTitle.Equals(input.DisplayDocTitle))
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
                if (this.FileId != null)
                    hashCode = hashCode * 59 + this.FileId.GetHashCode();
                if (this.PageMode != null)
                    hashCode = hashCode * 59 + this.PageMode.GetHashCode();
                if (this.LayoutMode != null)
                    hashCode = hashCode * 59 + this.LayoutMode.GetHashCode();
                if (this.NonFullScreenPageMode != null)
                    hashCode = hashCode * 59 + this.NonFullScreenPageMode.GetHashCode();
                if (this.OpenPage != null)
                    hashCode = hashCode * 59 + this.OpenPage.GetHashCode();
                if (this.OpenZoom != null)
                    hashCode = hashCode * 59 + this.OpenZoom.GetHashCode();
                if (this.HideToolbar != null)
                    hashCode = hashCode * 59 + this.HideToolbar.GetHashCode();
                if (this.HideMenubar != null)
                    hashCode = hashCode * 59 + this.HideMenubar.GetHashCode();
                if (this.HideWindowUI != null)
                    hashCode = hashCode * 59 + this.HideWindowUI.GetHashCode();
                if (this.FitWindow != null)
                    hashCode = hashCode * 59 + this.FitWindow.GetHashCode();
                if (this.CenterWindow != null)
                    hashCode = hashCode * 59 + this.CenterWindow.GetHashCode();
                if (this.DisplayDocTitle != null)
                    hashCode = hashCode * 59 + this.DisplayDocTitle.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
