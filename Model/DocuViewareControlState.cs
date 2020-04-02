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
    /// Specifies configuration and appearance state of a DocuVieware control.
    /// </summary>
    [DataContract]
    public partial class DocuViewareControlState :  IEquatable<DocuViewareControlState>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocuViewareControlState" /> class.
        /// </summary>
        public DocuViewareControlState()
        {
        }

        /// <summary>
        /// Specifies the amount of time, in minutes, allowed between requests before the DocuVieware session-state provider terminates the session.<br />
        /// </summary>
        [DataMember(Name="Timeout")]
        public int Timeout { get; set; } = 20;

        /// <summary>
        /// Specifies client the identifier associated with the control.
        /// </summary>
        [DataMember(Name="ControlID")]
        public string ControlID { get; set; } = "DocuVieware1";

        /// <summary>
        /// Specifies if the DocuVieware logo is displayed in the toolbar.
        /// </summary>
        [DataMember(Name="ShowLogo")]
        public bool ShowLogo { get; set; } = true;

        /// <summary>
        /// Specifies the remote IP. This property can be leaved empty if user requests don't need to be traced.
        /// </summary>
        [DataMember(Name="RemoteIP")]
        public string RemoteIP { get; set; } = "";

        /// <summary>
        /// Gets or Sets FileHostingURI
        /// </summary>
        [DataMember(Name="FileHostingURI")]
        public string FileHostingURI { get; set; } = "";

        /// <summary>
        /// Specifies the URI of a document to load into the control.  This can be an empty string if a document is already loaded.  Use the prefix 'fileid:' to load a document from a file ID handled by PassportPDF. ie: 'fileid:00000-00000-00000-00000-00000'.
        /// </summary>
        [DataMember(Name="DocumentURI")]
        public string DocumentURI { get; set; } = "";

        /// <summary>
        /// Specifies the file name of the input document. The file name can help to determine the input document format.  Default value is an empty string.
        /// </summary>
        [DataMember(Name="DocumentFileName")]
        public string DocumentFileName { get; set; } = "";

        /// <summary>
        /// A flag specifying if the control should display a loading progress status bar to the end user while a document is being loaded.
        /// </summary>
        [DataMember(Name="DisableDownloadProgress")]
        public bool DisableDownloadProgress { get; set; } = false;

        /// <summary>
        /// Gets or Sets DocumentAlignment
        /// </summary>
        [DataMember(Name="DocumentAlignment")]
        public DocumentAlignment DocumentAlignment { get; set; }

        /// <summary>
        /// Gets or Sets DocumentPosition
        /// </summary>
        [DataMember(Name="DocumentPosition")]
        public DocumentPosition DocumentPosition { get; set; }

        /// <summary>
        /// Specifies if GdPicture/XMP annotations support is activated.
        /// </summary>
        [DataMember(Name="EnableGdPictureAnnotations")]
        public bool EnableGdPictureAnnotations { get; set; } = true;

        /// <summary>
        /// Specifies whether printing support is disabled for annotations.
        /// </summary>
        [DataMember(Name="DisableAnnotationPrinting")]
        public bool DisableAnnotationPrinting { get; set; } = false;

        /// <summary>
        /// Specifies whether form fields can be edited into the client browser or not.
        /// </summary>
        [DataMember(Name="EnableFormFieldsEdition")]
        public bool EnableFormFieldsEdition { get; set; } = true;

        /// <summary>
        /// Specifies the editor mode for the GdPicture/XMP annotation support.<br />
        /// </summary>
        [DataMember(Name="AnnotationEditorMode")]
        public bool AnnotationEditorMode { get; set; } = true;

        /// <summary>
        /// Gets or Sets LinkAnnotationClickBehaviour
        /// </summary>
        [DataMember(Name="LinkAnnotationClickBehaviour")]
        public LinkAnnotationClickBehaviour LinkAnnotationClickBehaviour { get; set; }

        /// <summary>
        /// Specifies the current factor of zoom applied during page rendering operations: 1 for 100%, 1.5 for 150%, 2 for 200%...
        /// </summary>
        [DataMember(Name="Zoom")]
        public double Zoom { get; set; } = 1D;

        /// <summary>
        /// Gets or Sets ZoomMode
        /// </summary>
        [DataMember(Name="ZoomMode")]
        public ViewerZoomMode ZoomMode { get; set; }

        /// <summary>
        /// Gets or Sets OpenZoomMode
        /// </summary>
        [DataMember(Name="OpenZoomMode")]
        public ViewerZoomMode OpenZoomMode { get; set; }

        /// <summary>
        /// Gets or Sets ViewRotation
        /// </summary>
        [DataMember(Name="ViewRotation")]
        public RotateFlip ViewRotation { get; set; }

        /// <summary>
        /// Gets or Sets PageRotation
        /// </summary>
        [DataMember(Name="PageRotation")]
        public RotateFlip PageRotation { get; set; }

        /// <summary>
        /// Defines the percentage of increasing or decreasing level of zoom for 'Zoom In' and 'Zoom Out' operations.
        /// </summary>
        [DataMember(Name="ZoomStep")]
        public int ZoomStep { get; set; } = 30;

        /// <summary>
        /// Specifies whether scrollbars can be displayed or not within the viewer.<br />
        /// </summary>
        [DataMember(Name="ScrollBars")]
        public bool ScrollBars { get; set; } = true;

        /// <summary>
        /// Specifies whether the viewer shall always show scrollbars.
        /// </summary>
        [DataMember(Name="ForceScrollBars")]
        public bool ForceScrollBars { get; set; } = false;

        /// <summary>
        /// Gets or Sets PageViewMode
        /// </summary>
        [DataMember(Name="PageViewMode")]
        public PageViewMode PageViewMode { get; set; }

        /// <summary>
        /// Specifies if text selection is permitted.
        /// </summary>
        [DataMember(Name="EnableTextSelection")]
        public bool EnableTextSelection { get; set; } = true;

        /// <summary>
        /// Specifies whether the selected text context menu options should contain annotations entries.
        /// </summary>
        [DataMember(Name="EnableTextSelectionAnnotation")]
        public bool EnableTextSelectionAnnotation { get; set; } = true;

        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name="Locale")]
        public DocuViewareLocale Locale { get; set; }

        /// <summary>
        /// Specifies the different languages used by the user's browser.
        /// </summary>
        [DataMember(Name="UserLanguages")]
        public List<string> UserLanguages { get; set; }

        /// <summary>
        /// Specifies the width of the control within its container.
        /// </summary>
        [DataMember(Name="ControlWidth")]
        public string ControlWidth { get; set; } = "100%";

        /// <summary>
        /// Specifies, the height of the control within its container.
        /// </summary>
        [DataMember(Name="ControlHeight")]
        public string ControlHeight { get; set; } = "100%";

        /// <summary>
        /// Specifies whether GdPicture/XMP annotations are rendered with a drop shadow effect.
        /// </summary>
        [DataMember(Name="AnnotationDropShadow")]
        public bool AnnotationDropShadow { get; set; } = true;

        /// <summary>
        /// Specifies whether printing is allowed.
        /// </summary>
        [DataMember(Name="AllowPrint")]
        public bool AllowPrint { get; set; } = true;

        /// <summary>
        /// Specifies whether file upload is allowed.
        /// </summary>
        [DataMember(Name="AllowUpload")]
        public bool AllowUpload { get; set; } = true;

        /// <summary>
        /// Specifies whether multiple thumbnails selection is allowed.
        /// </summary>
        [DataMember(Name="EnableMultipleThumbnailSelection")]
        public bool EnableMultipleThumbnailSelection { get; set; } = false;

        /// <summary>
        /// Specifies whether the thumbnails can be moved by drag and drop.
        /// </summary>
        [DataMember(Name="EnableThumbnailDragDrop")]
        public bool EnableThumbnailDragDrop { get; set; } = false;

        /// <summary>
        /// Specifies whether the open button shall be enabled.
        /// </summary>
        [DataMember(Name="EnableFileUploadButton")]
        public bool EnableFileUploadButton { get; set; } = true;

        /// <summary>
        /// Specifies whether the 'open from uri' button shall be enabled.
        /// </summary>
        [DataMember(Name="EnableLoadFromUriButton")]
        public bool EnableLoadFromUriButton { get; set; } = true;

        /// <summary>
        /// Specifies whether the save button shall be enabled.
        /// </summary>
        [DataMember(Name="EnableSaveButton")]
        public bool EnableSaveButton { get; set; } = true;

        /// <summary>
        /// Specifies whether the save button shall be enabled.
        /// </summary>
        [DataMember(Name="EnablePagesNavigationButtons")]
        public bool EnablePagesNavigationButtons { get; set; } = true;

        /// <summary>
        /// Specifies whether the print button shall be enabled.
        /// </summary>
        [DataMember(Name="EnablePrintButton")]
        public bool EnablePrintButton { get; set; } = true;

        /// <summary>
        /// Specifies whether the print to pdf option shall be enabled.
        /// </summary>
        [DataMember(Name="EnablePrintToPDF")]
        public bool EnablePrintToPDF { get; set; } = true;

        /// <summary>
        /// Specifies whether the fit width button shall be enabled.
        /// </summary>
        [DataMember(Name="EnableFitWidthButton")]
        public bool EnableFitWidthButton { get; set; } = true;

        /// <summary>
        /// Specifies whether the fit original size button shall be enabled.
        /// </summary>
        [DataMember(Name="EnableZoom100Button")]
        public bool EnableZoom100Button { get; set; } = true;

        /// <summary>
        /// Specifies whether the mouse mode button group shall be enabled.
        /// </summary>
        [DataMember(Name="EnableMouseModeButtons")]
        public bool EnableMouseModeButtons { get; set; } = true;

        /// <summary>
        /// Specifies whether the pan mode button shall be enabled.
        /// </summary>
        [DataMember(Name="EnablePanModeButton")]
        public bool EnablePanModeButton { get; set; } = true;

        /// <summary>
        /// Specifies whether the select mode button shall be enabled.
        /// </summary>
        [DataMember(Name="EnableSelectModeButton")]
        public bool EnableSelectModeButton { get; set; } = true;

        /// <summary>
        /// Specifies whether the marquee zoom mode button shall be enabled.
        /// </summary>
        [DataMember(Name="EnableMarqueeZoomModeButton")]
        public bool EnableMarqueeZoomModeButton { get; set; } = true;

        /// <summary>
        /// Specifies whether the fullscreen button shall be enabled.
        /// </summary>
        [DataMember(Name="EnableFullScreenButton")]
        public bool EnableFullScreenButton { get; set; } = true;

        /// <summary>
        /// Specifies whether the 'Fit Page' button shall be enabled.
        /// </summary>
        [DataMember(Name="EnableFitPageButton")]
        public bool EnableFitPageButton { get; set; } = true;

        /// <summary>
        /// Specifies whether the zoom button group shall be enabled.
        /// </summary>
        [DataMember(Name="EnableZoomButtons")]
        public bool EnableZoomButtons { get; set; } = true;

        /// <summary>
        /// Specifies whether the page view mode button shall be enabled.
        /// </summary>
        [DataMember(Name="EnablePageViewButtons")]
        public bool EnablePageViewButtons { get; set; } = true;

        /// <summary>
        /// Gets or Sets RotateButtonsMode
        /// </summary>
        [DataMember(Name="RotateButtonsMode")]
        public RotateMode RotateButtonsMode { get; set; }

        /// <summary>
        /// Specifies whether the rotation button group shall be enabled.
        /// </summary>
        [DataMember(Name="EnableRotateButtons")]
        public bool EnableRotateButtons { get; set; } = true;

        /// <summary>
        /// Specifies whether the action buttons shall be enabled when an annotation is selected.  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        [DataMember(Name="EnableAnnotationActionButtons")]
        public bool EnableAnnotationActionButtons { get; set; } = true;

        /// <summary>
        /// Specifies whether the selected text annotations shall be editable.
        /// </summary>
        [DataMember(Name="EnableSelectedTextAnnotationEdition")]
        public bool EnableSelectedTextAnnotationEdition { get; set; } = true;

        /// <summary>
        /// Specifies whether the rectangle highlighter annotation button shall be enabled. <br />  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        [DataMember(Name="EnableRectangleHighlighterAnnotationButton")]
        public bool EnableRectangleHighlighterAnnotationButton { get; set; } = true;

        /// <summary>
        /// Specifies whether the freehand highlighter annotation button shall be enabled.<br />  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        [DataMember(Name="EnableFreehandHighlighterAnnotationButton")]
        public bool EnableFreehandHighlighterAnnotationButton { get; set; } = true;

        /// <summary>
        /// Specifies whether the rubber stamp annotation button shall be enabled.<br />  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        [DataMember(Name="EnableRubberStampAnnotationButton")]
        public bool EnableRubberStampAnnotationButton { get; set; } = true;

        /// <summary>
        /// Specifies whether the rectangle annotation button shall be enabled.<br />  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        [DataMember(Name="EnableRectangleAnnotationButton")]
        public bool EnableRectangleAnnotationButton { get; set; } = true;

        /// <summary>
        /// Specifies whether the ellipse annotation button shall be enabled.<br />  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        [DataMember(Name="EnableEllipseAnnotationButton")]
        public bool EnableEllipseAnnotationButton { get; set; } = true;

        /// <summary>
        /// Specifies whether the line annotation button shall be enabled.<br />  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        [DataMember(Name="EnableLineAnnotationButton")]
        public bool EnableLineAnnotationButton { get; set; } = true;

        /// <summary>
        /// Specifies whether the connected line annotation button shall be enabled.<br />  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        [DataMember(Name="EnableConnectedLineAnnotationButton")]
        public bool EnableConnectedLineAnnotationButton { get; set; } = true;

        /// <summary>
        /// Specifies whether the freehand annotation button shall be enabled.<br />  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        [DataMember(Name="EnableFreehandAnnotationButton")]
        public bool EnableFreehandAnnotationButton { get; set; } = true;

        /// <summary>
        /// Specifies whether the line arrow annotation button shall be enabled.<br />  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        [DataMember(Name="EnableLineArrowAnnotationButton")]
        public bool EnableLineArrowAnnotationButton { get; set; } = true;

        /// <summary>
        /// Specifies whether the link annotation button shall be enabled.<br />  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        [DataMember(Name="EnableLinkAnnotationButton")]
        public bool EnableLinkAnnotationButton { get; set; } = true;

        /// <summary>
        /// Specifies whether the ruler annotation button shall be enabled.<br />  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        [DataMember(Name="EnableRulerAnnotationButton")]
        public bool EnableRulerAnnotationButton { get; set; } = true;

        /// <summary>
        /// Gets or Sets EnablePolyRulerAnnotationButton
        /// </summary>
        [DataMember(Name="EnablePolyRulerAnnotationButton")]
        public bool EnablePolyRulerAnnotationButton { get; set; } = true;

        /// <summary>
        /// Specifies whether the text annotation button shall be enabled.<br />  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        [DataMember(Name="EnableTextAnnotationButton")]
        public bool EnableTextAnnotationButton { get; set; } = true;

        /// <summary>
        /// Specifies whether the sticky note annotation button shall be enabled.<br />  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        [DataMember(Name="EnableStickyNoteAnnotationButton")]
        public bool EnableStickyNoteAnnotationButton { get; set; } = true;

        /// <summary>
        /// Specifies whether the TWAIN acquisition button shall be enabled.
        /// </summary>
        [DataMember(Name="EnableTwainAcquisitionButton")]
        public bool EnableTwainAcquisitionButton { get; set; } = true;

        /// <summary>
        /// Enables the custom configuration support for the TWAIN source.
        /// </summary>
        [DataMember(Name="TwainSourceEnableCustomConfiguration")]
        public bool TwainSourceEnableCustomConfiguration { get; set; } = false;

        /// <summary>
        /// Specifies whether the TWAIN acquisition source shall acquire from the document feeder or the flatbed.  This property is only effective if TwainSourceSetCustomConfiguration is set to true.
        /// </summary>
        [DataMember(Name="TwainSourceSelectFeeder")]
        public bool TwainSourceSelectFeeder { get; set; } = true;

        /// <summary>
        /// Specifies the bit depth the TWAIN acquisition source should acquire at. <br />  This property is only effective if TwainSourceSetCustomConfiguration is set to true.
        /// </summary>
        [DataMember(Name="TwainSourceBitDepth")]
        public int TwainSourceBitDepth { get; set; } = 24;

        /// <summary>
        /// Specifies the resolution the TWAIN acquisition source should acquire at. <br />  This property is only effective if TwainSourceSetCustomConfiguration is set to true.
        /// </summary>
        [DataMember(Name="TwainSourceResolution")]
        public int TwainSourceResolution { get; set; } = 200;

        /// <summary>
        /// Specifies whether the TWAIN acquisition source shall enable duplex acquisition. <br />  This property is only effective if TwainSourceSetCustomConfiguration is set to true.
        /// </summary>
        [DataMember(Name="TwainSourceEnableDuplex")]
        public bool TwainSourceEnableDuplex { get; set; } = false;

        /// <summary>
        /// Specifies whether the TWAIN acquisition source shall hide or show the device driver user interface before acquisition. <br />  This property is only effective if TwainSourceSetCustomConfiguration is set to true.
        /// </summary>
        [DataMember(Name="TwainSourceHideUI")]
        public bool TwainSourceHideUI { get; set; } = true;

        /// <summary>
        /// Specifies whether the drawing mode for freehand annotation is multi line or not.<br />  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        [DataMember(Name="FreeHandContinuousDrawingMode")]
        public bool FreeHandContinuousDrawingMode { get; set; } = true;

        /// <summary>
        /// Specifies whether the text search SnapIn is enabled.
        /// </summary>
        [DataMember(Name="ShowTextSearchSnapIn")]
        public bool ShowTextSearchSnapIn { get; set; } = true;

        /// <summary>
        /// Specifies whether the Thumbnails SnapIn is enabled.
        /// </summary>
        [DataMember(Name="ShowThumbnailsSnapIn")]
        public bool ShowThumbnailsSnapIn { get; set; } = true;

        /// <summary>
        /// Specifies whether the Bookmarks SnapIn is enabled.
        /// </summary>
        [DataMember(Name="ShowBookmarksSnapIn")]
        public bool ShowBookmarksSnapIn { get; set; } = true;

        /// <summary>
        /// Specifies whether the annotations SnapIn is enabled.
        /// </summary>
        [DataMember(Name="ShowAnnotationsSnapIn")]
        public bool ShowAnnotationsSnapIn { get; set; } = true;

        /// <summary>
        /// Specifies whether the Annotations Comments SnapIn is enabled.
        /// </summary>
        [DataMember(Name="ShowAnnotationsCommentsSnapIn")]
        public bool ShowAnnotationsCommentsSnapIn { get; set; } = true;

        /// <summary>
        /// Specifies whether the Redaction Snap-In is enabled or not.  <remarks>  Default value is true.  </remarks>
        /// </summary>
        [DataMember(Name="ShowRedactionSnapIn")]
        public bool ShowRedactionSnapIn { get; set; } = true;

        /// <summary>
        /// Specifies whether the Digital Signature Snap-In is enabled or not.  <remarks>  Default value is false.  </remarks>
        /// </summary>
        [DataMember(Name="ShowDigitalSignatureSnapIn")]
        public bool ShowDigitalSignatureSnapIn { get; set; } = false;

        /// <summary>
        /// The width, in pixels, of each thumbnail.
        /// </summary>
        [DataMember(Name="ThumbnailWidth")]
        public int ThumbnailWidth { get; set; } = 192;

        /// <summary>
        /// The height, in pixels, of each thumbnail.
        /// </summary>
        [DataMember(Name="ThumbnailHeight")]
        public int ThumbnailHeight { get; set; } = 256;

        /// <summary>
        /// Specifies the Snap-in panel default width.
        /// </summary>
        [DataMember(Name="SnapInPanelDefaultWidth")]
        public string SnapInPanelDefaultWidth { get; set; } = "280px";

        /// <summary>
        /// Specifies whether the Snap-in panel is collapsed or not.
        /// </summary>
        [DataMember(Name="CollapsedSnapIn")]
        public bool CollapsedSnapIn { get; set; } = false;

        /// <summary>
        /// Specifies whether the Snap-in panel should be automatically collapsed when the displayed document is closed.
        /// </summary>
        [DataMember(Name="CollapseSnapinOnDocumentClosed")]
        public bool CollapseSnapinOnDocumentClosed { get; set; } = true;

        /// <summary>
        /// Specifies whether the button that collapses the Snap-in panel is displayed or not.
        /// </summary>
        [DataMember(Name="ShowSnapInCollapseButton")]
        public bool ShowSnapInCollapseButton { get; set; } = true;

        /// <summary>
        /// Specifies whether the header of the Snap-in panel is displayed or not.
        /// </summary>
        [DataMember(Name="ShowSnapInPanelHeader")]
        public bool ShowSnapInPanelHeader { get; set; } = true;

        /// <summary>
        /// Specifies whether the Snap-in button strip is displayed or not.
        /// </summary>
        [DataMember(Name="ShowSnapInButtonStrip")]
        public bool ShowSnapInButtonStrip { get; set; } = true;

        /// <summary>
        /// Specifies whether the Toolbars are visible or not.
        /// </summary>
        [DataMember(Name="ShowToolbar")]
        public bool ShowToolbar { get; set; } = true;

        /// <summary>
        /// Gets or Sets ToolbarStyle
        /// </summary>
        [DataMember(Name="ToolbarStyle")]
        public ToolbarStyle ToolbarStyle { get; set; }

        /// <summary>
        /// The space, in pixels, between each button of the toolbar.
        /// </summary>
        [DataMember(Name="ToolbarButtonsSpacing")]
        public int ToolbarButtonsSpacing { get; set; } = 12;

        /// <summary>
        /// The height, in pixels, of the toolbar.
        /// </summary>
        [DataMember(Name="ToolbarHeight")]
        public int ToolbarHeight { get; set; } = 48;

        /// <summary>
        /// Specifies the color used to stroke viewer elements such borders, toolbar icons and thumbnail text.
        /// </summary>
        [DataMember(Name="StrokeColor")]
        public string StrokeColor { get; set; } = "#646464";

        /// <summary>
        /// Specifies the color used to define dropdowns borders, buttons separators, line separators.
        /// </summary>
        [DataMember(Name="MiscBorderColor")]
        public string MiscBorderColor { get; set; } = "#DCDCDC";

        /// <summary>
        /// Specifies the color used in both dialogs and snap-ins headers.
        /// </summary>
        [DataMember(Name="HeaderColor")]
        public string HeaderColor { get; set; } = "#213E4E";

        /// <summary>
        /// Specifies the color used in both dialogs and snap-ins body background.
        /// </summary>
        [DataMember(Name="PanelBackColor")]
        public string PanelBackColor { get; set; } = "#FFFFFF";

        /// <summary>
        /// Specifies the viewer area background color.
        /// </summary>
        [DataMember(Name="ViewerBackColor")]
        public string ViewerBackColor { get; set; } = "#565656";

        /// <summary>
        /// Specifies the selected and active elements stroke color.
        /// </summary>
        [DataMember(Name="ActiveSelectedColor")]
        public string ActiveSelectedColor { get; set; } = "#0382D4";

        /// <summary>
        /// Viewer Toolbar Background Color.
        /// </summary>
        [DataMember(Name="ToolbarBackColor")]
        public string ToolbarBackColor { get; set; } = "#F2F2F2";

        /// <summary>
        /// Custom error notification icon.<br />  Used to specify a custom icon within errors notification boxes.
        /// </summary>
        [DataMember(Name="CustomNotificationIconError")]
        public string CustomNotificationIconError { get; set; } = "";

        /// <summary>
        /// Custom question notification icon.<br />  Used to specify a custom icon within questions notification boxes.
        /// </summary>
        [DataMember(Name="CustomNotificationIconQuestion")]
        public string CustomNotificationIconQuestion { get; set; } = "";

        /// <summary>
        /// Custom warning notification icon.<br />  Used to specify a custom icon within warnings notification boxes.
        /// </summary>
        [DataMember(Name="CustomNotificationIconWarning")]
        public string CustomNotificationIconWarning { get; set; } = "";

        /// <summary>
        /// Custom info notification icon.<br />  Used to specify a custom icon within information notification boxes.
        /// </summary>
        [DataMember(Name="CustomNotificationIconInfo")]
        public string CustomNotificationIconInfo { get; set; } = "";

        /// <summary>
        /// Custom success notification icon.<br />  Used to specify a custom icon within success notification boxes.
        /// </summary>
        [DataMember(Name="CustomNotificationIconOk")]
        public string CustomNotificationIconOk { get; set; } = "";

        /// <summary>
        /// Specifies extensions of the allowed formats for export. Each extension must be separated by a coma.<br />  Wildcard character '*' can be used to specify any supported format.<br />  The following extensions are currently supported: \"PDF\", \"TIFF\".<br />  For example use \"*\" to allow all supported format for export, \"PDF\" to allow only PDF export and \"PDF,TIFF\" to allow PDF and TIFF export.
        /// </summary>
        [DataMember(Name="AllowedExportFormats")]
        public string AllowedExportFormats { get; set; } = "*";

        /// <summary>
        /// Specifies whether the drawing mode panel shall be enabled while user is drawing a free hand annotation.<br />  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        [DataMember(Name="DisableAnnotationDrawingModePanel")]
        public bool DisableAnnotationDrawingModePanel { get; set; } = false;

        /// <summary>
        /// Gets or Sets ImageQuality
        /// </summary>
        [DataMember(Name="ImageQuality")]
        public int ImageQuality { get; set; } = 10;

        /// <summary>
        /// Gets or Sets PrintQuality
        /// </summary>
        [DataMember(Name="PrintQuality")]
        public PrintQuality PrintQuality { get; set; }

        /// <summary>
        /// Specifies whether documents drag & drop is allowed into the viewer area.
        /// </summary>
        [DataMember(Name="EnableDocumentsDrop")]
        public bool EnableDocumentsDrop { get; set; } = true;

        /// <summary>
        /// Specifies custom headers for the generated AJAX requests.  Value must be a (properly escaped) JSON-formatted string. Default value is null.
        /// </summary>
        [DataMember(Name="AjaxCustomHeaders")]
        public string AjaxCustomHeaders { get; set; } = "";

        /// <summary>
        /// Specifies custom headers to be used for the file download JavaScript API requests (for instance LoadFromUri and LoadFromUriEx). Headers that are set through this property won't be exposed client-side.  Value must be a (properly escaped) JSON-formatted string. Default value is null.
        /// </summary>
        [DataMember(Name="FileDownloadCustomHeaders")]
        public string FileDownloadCustomHeaders { get; set; } = "";

        /// <summary>
        /// Specifies the maximum number of results provided by a text search request.
        /// </summary>
        [DataMember(Name="TextSearchMaxResults")]
        public int TextSearchMaxResults { get; set; } = 100;

        /// <summary>
        /// Specifies, in bytes, the upload size limit.
        /// </summary>
        [DataMember(Name="MaxUploadSize")]
        public int MaxUploadSize { get; set; } = 10485760;

        /// <summary>
        /// Specifies, in bytes, the download size limit.
        /// </summary>
        [DataMember(Name="MaxDownloadSize")]
        public int MaxDownloadSize { get; set; } = 10485760;

        /// <summary>
        /// Specifies the maximum of pages per loaded document.
        /// </summary>
        [DataMember(Name="MaxPages")]
        public int MaxPages { get; set; } = 3000;

        /// <summary>
        /// Specifies a list of certificates to be made available on the client side to apply digital signature to documents.
        /// </summary>
        [DataMember(Name="Certificates")]
        public List<DocuViewareCertificate> Certificates { get; set; }

        /// <summary>
        /// A formatted string specifying undocumented extra features to handle.
        /// </summary>
        [DataMember(Name="ExtraFeatures")]
        public string ExtraFeatures { get; set; } = "";

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
            return Equals(input as DocuViewareControlState);
        }

        /// <summary>
        /// Returns true if DocuViewareControlState instances are equal
        /// </summary>
        /// <param name="input">Instance of DocuViewareControlState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocuViewareControlState input)
        {
            if (input == null)
                return false;

            return 
                (
                    Timeout == input.Timeout ||
                    Timeout.Equals(input.Timeout)
                ) && 
                (
                    ControlID == input.ControlID ||
                    (ControlID != null &&
                    ControlID.Equals(input.ControlID))
                ) && 
                (
                    ShowLogo == input.ShowLogo ||
                    ShowLogo.Equals(input.ShowLogo)
                ) && 
                (
                    RemoteIP == input.RemoteIP ||
                    (RemoteIP != null &&
                    RemoteIP.Equals(input.RemoteIP))
                ) && 
                (
                    FileHostingURI == input.FileHostingURI ||
                    (FileHostingURI != null &&
                    FileHostingURI.Equals(input.FileHostingURI))
                ) && 
                (
                    DocumentURI == input.DocumentURI ||
                    (DocumentURI != null &&
                    DocumentURI.Equals(input.DocumentURI))
                ) && 
                (
                    DocumentFileName == input.DocumentFileName ||
                    (DocumentFileName != null &&
                    DocumentFileName.Equals(input.DocumentFileName))
                ) && 
                (
                    DisableDownloadProgress == input.DisableDownloadProgress ||
                    DisableDownloadProgress.Equals(input.DisableDownloadProgress)
                ) && 
                (
                    DocumentAlignment == input.DocumentAlignment ||
                    DocumentAlignment.Equals(input.DocumentAlignment)
                ) && 
                (
                    DocumentPosition == input.DocumentPosition ||
                    DocumentPosition.Equals(input.DocumentPosition)
                ) && 
                (
                    EnableGdPictureAnnotations == input.EnableGdPictureAnnotations ||
                    EnableGdPictureAnnotations.Equals(input.EnableGdPictureAnnotations)
                ) && 
                (
                    DisableAnnotationPrinting == input.DisableAnnotationPrinting ||
                    DisableAnnotationPrinting.Equals(input.DisableAnnotationPrinting)
                ) && 
                (
                    EnableFormFieldsEdition == input.EnableFormFieldsEdition ||
                    EnableFormFieldsEdition.Equals(input.EnableFormFieldsEdition)
                ) && 
                (
                    AnnotationEditorMode == input.AnnotationEditorMode ||
                    AnnotationEditorMode.Equals(input.AnnotationEditorMode)
                ) && 
                (
                    LinkAnnotationClickBehaviour == input.LinkAnnotationClickBehaviour ||
                    LinkAnnotationClickBehaviour.Equals(input.LinkAnnotationClickBehaviour)
                ) && 
                (
                    Zoom == input.Zoom ||
                    Zoom.Equals(input.Zoom)
                ) && 
                (
                    ZoomMode == input.ZoomMode ||
                    ZoomMode.Equals(input.ZoomMode)
                ) && 
                (
                    OpenZoomMode == input.OpenZoomMode ||
                    OpenZoomMode.Equals(input.OpenZoomMode)
                ) && 
                (
                    ViewRotation == input.ViewRotation ||
                    ViewRotation.Equals(input.ViewRotation)
                ) && 
                (
                    PageRotation == input.PageRotation ||
                    PageRotation.Equals(input.PageRotation)
                ) && 
                (
                    ZoomStep == input.ZoomStep ||
                    ZoomStep.Equals(input.ZoomStep)
                ) && 
                (
                    ScrollBars == input.ScrollBars ||
                    ScrollBars.Equals(input.ScrollBars)
                ) && 
                (
                    ForceScrollBars == input.ForceScrollBars ||
                    ForceScrollBars.Equals(input.ForceScrollBars)
                ) && 
                (
                    PageViewMode == input.PageViewMode ||
                    PageViewMode.Equals(input.PageViewMode)
                ) && 
                (
                    EnableTextSelection == input.EnableTextSelection ||
                    EnableTextSelection.Equals(input.EnableTextSelection)
                ) && 
                (
                    EnableTextSelectionAnnotation == input.EnableTextSelectionAnnotation ||
                    EnableTextSelectionAnnotation.Equals(input.EnableTextSelectionAnnotation)
                ) && 
                (
                    Locale == input.Locale ||
                    Locale.Equals(input.Locale)
                ) && 
                (
                    UserLanguages == input.UserLanguages ||
                    UserLanguages != null &&
                    input.UserLanguages != null &&
                    UserLanguages.SequenceEqual(input.UserLanguages)
                ) && 
                (
                    ControlWidth == input.ControlWidth ||
                    (ControlWidth != null &&
                    ControlWidth.Equals(input.ControlWidth))
                ) && 
                (
                    ControlHeight == input.ControlHeight ||
                    (ControlHeight != null &&
                    ControlHeight.Equals(input.ControlHeight))
                ) && 
                (
                    AnnotationDropShadow == input.AnnotationDropShadow ||
                    AnnotationDropShadow.Equals(input.AnnotationDropShadow)
                ) && 
                (
                    AllowPrint == input.AllowPrint ||
                    AllowPrint.Equals(input.AllowPrint)
                ) && 
                (
                    AllowUpload == input.AllowUpload ||
                    AllowUpload.Equals(input.AllowUpload)
                ) && 
                (
                    EnableMultipleThumbnailSelection == input.EnableMultipleThumbnailSelection ||
                    EnableMultipleThumbnailSelection.Equals(input.EnableMultipleThumbnailSelection)
                ) && 
                (
                    EnableThumbnailDragDrop == input.EnableThumbnailDragDrop ||
                    EnableThumbnailDragDrop.Equals(input.EnableThumbnailDragDrop)
                ) && 
                (
                    EnableFileUploadButton == input.EnableFileUploadButton ||
                    EnableFileUploadButton.Equals(input.EnableFileUploadButton)
                ) && 
                (
                    EnableLoadFromUriButton == input.EnableLoadFromUriButton ||
                    EnableLoadFromUriButton.Equals(input.EnableLoadFromUriButton)
                ) && 
                (
                    EnableSaveButton == input.EnableSaveButton ||
                    EnableSaveButton.Equals(input.EnableSaveButton)
                ) && 
                (
                    EnablePagesNavigationButtons == input.EnablePagesNavigationButtons ||
                    EnablePagesNavigationButtons.Equals(input.EnablePagesNavigationButtons)
                ) && 
                (
                    EnablePrintButton == input.EnablePrintButton ||
                    EnablePrintButton.Equals(input.EnablePrintButton)
                ) && 
                (
                    EnablePrintToPDF == input.EnablePrintToPDF ||
                    EnablePrintToPDF.Equals(input.EnablePrintToPDF)
                ) && 
                (
                    EnableFitWidthButton == input.EnableFitWidthButton ||
                    EnableFitWidthButton.Equals(input.EnableFitWidthButton)
                ) && 
                (
                    EnableZoom100Button == input.EnableZoom100Button ||
                    EnableZoom100Button.Equals(input.EnableZoom100Button)
                ) && 
                (
                    EnableMouseModeButtons == input.EnableMouseModeButtons ||
                    EnableMouseModeButtons.Equals(input.EnableMouseModeButtons)
                ) && 
                (
                    EnablePanModeButton == input.EnablePanModeButton ||
                    EnablePanModeButton.Equals(input.EnablePanModeButton)
                ) && 
                (
                    EnableSelectModeButton == input.EnableSelectModeButton ||
                    EnableSelectModeButton.Equals(input.EnableSelectModeButton)
                ) && 
                (
                    EnableMarqueeZoomModeButton == input.EnableMarqueeZoomModeButton ||
                    EnableMarqueeZoomModeButton.Equals(input.EnableMarqueeZoomModeButton)
                ) && 
                (
                    EnableFullScreenButton == input.EnableFullScreenButton ||
                    EnableFullScreenButton.Equals(input.EnableFullScreenButton)
                ) && 
                (
                    EnableFitPageButton == input.EnableFitPageButton ||
                    EnableFitPageButton.Equals(input.EnableFitPageButton)
                ) && 
                (
                    EnableZoomButtons == input.EnableZoomButtons ||
                    EnableZoomButtons.Equals(input.EnableZoomButtons)
                ) && 
                (
                    EnablePageViewButtons == input.EnablePageViewButtons ||
                    EnablePageViewButtons.Equals(input.EnablePageViewButtons)
                ) && 
                (
                    RotateButtonsMode == input.RotateButtonsMode ||
                    RotateButtonsMode.Equals(input.RotateButtonsMode)
                ) && 
                (
                    EnableRotateButtons == input.EnableRotateButtons ||
                    EnableRotateButtons.Equals(input.EnableRotateButtons)
                ) && 
                (
                    EnableAnnotationActionButtons == input.EnableAnnotationActionButtons ||
                    EnableAnnotationActionButtons.Equals(input.EnableAnnotationActionButtons)
                ) && 
                (
                    EnableSelectedTextAnnotationEdition == input.EnableSelectedTextAnnotationEdition ||
                    EnableSelectedTextAnnotationEdition.Equals(input.EnableSelectedTextAnnotationEdition)
                ) && 
                (
                    EnableRectangleHighlighterAnnotationButton == input.EnableRectangleHighlighterAnnotationButton ||
                    EnableRectangleHighlighterAnnotationButton.Equals(input.EnableRectangleHighlighterAnnotationButton)
                ) && 
                (
                    EnableFreehandHighlighterAnnotationButton == input.EnableFreehandHighlighterAnnotationButton ||
                    EnableFreehandHighlighterAnnotationButton.Equals(input.EnableFreehandHighlighterAnnotationButton)
                ) && 
                (
                    EnableRubberStampAnnotationButton == input.EnableRubberStampAnnotationButton ||
                    EnableRubberStampAnnotationButton.Equals(input.EnableRubberStampAnnotationButton)
                ) && 
                (
                    EnableRectangleAnnotationButton == input.EnableRectangleAnnotationButton ||
                    EnableRectangleAnnotationButton.Equals(input.EnableRectangleAnnotationButton)
                ) && 
                (
                    EnableEllipseAnnotationButton == input.EnableEllipseAnnotationButton ||
                    EnableEllipseAnnotationButton.Equals(input.EnableEllipseAnnotationButton)
                ) && 
                (
                    EnableLineAnnotationButton == input.EnableLineAnnotationButton ||
                    EnableLineAnnotationButton.Equals(input.EnableLineAnnotationButton)
                ) && 
                (
                    EnableConnectedLineAnnotationButton == input.EnableConnectedLineAnnotationButton ||
                    EnableConnectedLineAnnotationButton.Equals(input.EnableConnectedLineAnnotationButton)
                ) && 
                (
                    EnableFreehandAnnotationButton == input.EnableFreehandAnnotationButton ||
                    EnableFreehandAnnotationButton.Equals(input.EnableFreehandAnnotationButton)
                ) && 
                (
                    EnableLineArrowAnnotationButton == input.EnableLineArrowAnnotationButton ||
                    EnableLineArrowAnnotationButton.Equals(input.EnableLineArrowAnnotationButton)
                ) && 
                (
                    EnableLinkAnnotationButton == input.EnableLinkAnnotationButton ||
                    EnableLinkAnnotationButton.Equals(input.EnableLinkAnnotationButton)
                ) && 
                (
                    EnableRulerAnnotationButton == input.EnableRulerAnnotationButton ||
                    EnableRulerAnnotationButton.Equals(input.EnableRulerAnnotationButton)
                ) && 
                (
                    EnablePolyRulerAnnotationButton == input.EnablePolyRulerAnnotationButton ||
                    EnablePolyRulerAnnotationButton.Equals(input.EnablePolyRulerAnnotationButton)
                ) && 
                (
                    EnableTextAnnotationButton == input.EnableTextAnnotationButton ||
                    EnableTextAnnotationButton.Equals(input.EnableTextAnnotationButton)
                ) && 
                (
                    EnableStickyNoteAnnotationButton == input.EnableStickyNoteAnnotationButton ||
                    EnableStickyNoteAnnotationButton.Equals(input.EnableStickyNoteAnnotationButton)
                ) && 
                (
                    EnableTwainAcquisitionButton == input.EnableTwainAcquisitionButton ||
                    EnableTwainAcquisitionButton.Equals(input.EnableTwainAcquisitionButton)
                ) && 
                (
                    TwainSourceEnableCustomConfiguration == input.TwainSourceEnableCustomConfiguration ||
                    TwainSourceEnableCustomConfiguration.Equals(input.TwainSourceEnableCustomConfiguration)
                ) && 
                (
                    TwainSourceSelectFeeder == input.TwainSourceSelectFeeder ||
                    TwainSourceSelectFeeder.Equals(input.TwainSourceSelectFeeder)
                ) && 
                (
                    TwainSourceBitDepth == input.TwainSourceBitDepth ||
                    TwainSourceBitDepth.Equals(input.TwainSourceBitDepth)
                ) && 
                (
                    TwainSourceResolution == input.TwainSourceResolution ||
                    TwainSourceResolution.Equals(input.TwainSourceResolution)
                ) && 
                (
                    TwainSourceEnableDuplex == input.TwainSourceEnableDuplex ||
                    TwainSourceEnableDuplex.Equals(input.TwainSourceEnableDuplex)
                ) && 
                (
                    TwainSourceHideUI == input.TwainSourceHideUI ||
                    TwainSourceHideUI.Equals(input.TwainSourceHideUI)
                ) && 
                (
                    FreeHandContinuousDrawingMode == input.FreeHandContinuousDrawingMode ||
                    FreeHandContinuousDrawingMode.Equals(input.FreeHandContinuousDrawingMode)
                ) && 
                (
                    ShowTextSearchSnapIn == input.ShowTextSearchSnapIn ||
                    ShowTextSearchSnapIn.Equals(input.ShowTextSearchSnapIn)
                ) && 
                (
                    ShowThumbnailsSnapIn == input.ShowThumbnailsSnapIn ||
                    ShowThumbnailsSnapIn.Equals(input.ShowThumbnailsSnapIn)
                ) && 
                (
                    ShowBookmarksSnapIn == input.ShowBookmarksSnapIn ||
                    ShowBookmarksSnapIn.Equals(input.ShowBookmarksSnapIn)
                ) && 
                (
                    ShowAnnotationsSnapIn == input.ShowAnnotationsSnapIn ||
                    ShowAnnotationsSnapIn.Equals(input.ShowAnnotationsSnapIn)
                ) && 
                (
                    ShowAnnotationsCommentsSnapIn == input.ShowAnnotationsCommentsSnapIn ||
                    ShowAnnotationsCommentsSnapIn.Equals(input.ShowAnnotationsCommentsSnapIn)
                ) && 
                (
                    ShowRedactionSnapIn == input.ShowRedactionSnapIn ||
                    ShowRedactionSnapIn.Equals(input.ShowRedactionSnapIn)
                ) && 
                (
                    ShowDigitalSignatureSnapIn == input.ShowDigitalSignatureSnapIn ||
                    ShowDigitalSignatureSnapIn.Equals(input.ShowDigitalSignatureSnapIn)
                ) && 
                (
                    ThumbnailWidth == input.ThumbnailWidth ||
                    ThumbnailWidth.Equals(input.ThumbnailWidth)
                ) && 
                (
                    ThumbnailHeight == input.ThumbnailHeight ||
                    ThumbnailHeight.Equals(input.ThumbnailHeight)
                ) && 
                (
                    SnapInPanelDefaultWidth == input.SnapInPanelDefaultWidth ||
                    (SnapInPanelDefaultWidth != null &&
                    SnapInPanelDefaultWidth.Equals(input.SnapInPanelDefaultWidth))
                ) && 
                (
                    CollapsedSnapIn == input.CollapsedSnapIn ||
                    CollapsedSnapIn.Equals(input.CollapsedSnapIn)
                ) && 
                (
                    CollapseSnapinOnDocumentClosed == input.CollapseSnapinOnDocumentClosed ||
                    CollapseSnapinOnDocumentClosed.Equals(input.CollapseSnapinOnDocumentClosed)
                ) && 
                (
                    ShowSnapInCollapseButton == input.ShowSnapInCollapseButton ||
                    ShowSnapInCollapseButton.Equals(input.ShowSnapInCollapseButton)
                ) && 
                (
                    ShowSnapInPanelHeader == input.ShowSnapInPanelHeader ||
                    ShowSnapInPanelHeader.Equals(input.ShowSnapInPanelHeader)
                ) && 
                (
                    ShowSnapInButtonStrip == input.ShowSnapInButtonStrip ||
                    ShowSnapInButtonStrip.Equals(input.ShowSnapInButtonStrip)
                ) && 
                (
                    ShowToolbar == input.ShowToolbar ||
                    ShowToolbar.Equals(input.ShowToolbar)
                ) && 
                (
                    ToolbarStyle == input.ToolbarStyle ||
                    ToolbarStyle.Equals(input.ToolbarStyle)
                ) && 
                (
                    ToolbarButtonsSpacing == input.ToolbarButtonsSpacing ||
                    ToolbarButtonsSpacing.Equals(input.ToolbarButtonsSpacing)
                ) && 
                (
                    ToolbarHeight == input.ToolbarHeight ||
                    ToolbarHeight.Equals(input.ToolbarHeight)
                ) && 
                (
                    StrokeColor == input.StrokeColor ||
                    (StrokeColor != null &&
                    StrokeColor.Equals(input.StrokeColor))
                ) && 
                (
                    MiscBorderColor == input.MiscBorderColor ||
                    (MiscBorderColor != null &&
                    MiscBorderColor.Equals(input.MiscBorderColor))
                ) && 
                (
                    HeaderColor == input.HeaderColor ||
                    (HeaderColor != null &&
                    HeaderColor.Equals(input.HeaderColor))
                ) && 
                (
                    PanelBackColor == input.PanelBackColor ||
                    (PanelBackColor != null &&
                    PanelBackColor.Equals(input.PanelBackColor))
                ) && 
                (
                    ViewerBackColor == input.ViewerBackColor ||
                    (ViewerBackColor != null &&
                    ViewerBackColor.Equals(input.ViewerBackColor))
                ) && 
                (
                    ActiveSelectedColor == input.ActiveSelectedColor ||
                    (ActiveSelectedColor != null &&
                    ActiveSelectedColor.Equals(input.ActiveSelectedColor))
                ) && 
                (
                    ToolbarBackColor == input.ToolbarBackColor ||
                    (ToolbarBackColor != null &&
                    ToolbarBackColor.Equals(input.ToolbarBackColor))
                ) && 
                (
                    CustomNotificationIconError == input.CustomNotificationIconError ||
                    (CustomNotificationIconError != null &&
                    CustomNotificationIconError.Equals(input.CustomNotificationIconError))
                ) && 
                (
                    CustomNotificationIconQuestion == input.CustomNotificationIconQuestion ||
                    (CustomNotificationIconQuestion != null &&
                    CustomNotificationIconQuestion.Equals(input.CustomNotificationIconQuestion))
                ) && 
                (
                    CustomNotificationIconWarning == input.CustomNotificationIconWarning ||
                    (CustomNotificationIconWarning != null &&
                    CustomNotificationIconWarning.Equals(input.CustomNotificationIconWarning))
                ) && 
                (
                    CustomNotificationIconInfo == input.CustomNotificationIconInfo ||
                    (CustomNotificationIconInfo != null &&
                    CustomNotificationIconInfo.Equals(input.CustomNotificationIconInfo))
                ) && 
                (
                    CustomNotificationIconOk == input.CustomNotificationIconOk ||
                    (CustomNotificationIconOk != null &&
                    CustomNotificationIconOk.Equals(input.CustomNotificationIconOk))
                ) && 
                (
                    AllowedExportFormats == input.AllowedExportFormats ||
                    (AllowedExportFormats != null &&
                    AllowedExportFormats.Equals(input.AllowedExportFormats))
                ) && 
                (
                    DisableAnnotationDrawingModePanel == input.DisableAnnotationDrawingModePanel ||
                    DisableAnnotationDrawingModePanel.Equals(input.DisableAnnotationDrawingModePanel)
                ) && 
                (
                    ImageQuality == input.ImageQuality ||
                    ImageQuality.Equals(input.ImageQuality)
                ) && 
                (
                    PrintQuality == input.PrintQuality ||
                    PrintQuality.Equals(input.PrintQuality)
                ) && 
                (
                    EnableDocumentsDrop == input.EnableDocumentsDrop ||
                    EnableDocumentsDrop.Equals(input.EnableDocumentsDrop)
                ) && 
                (
                    AjaxCustomHeaders == input.AjaxCustomHeaders ||
                    (AjaxCustomHeaders != null &&
                    AjaxCustomHeaders.Equals(input.AjaxCustomHeaders))
                ) && 
                (
                    FileDownloadCustomHeaders == input.FileDownloadCustomHeaders ||
                    (FileDownloadCustomHeaders != null &&
                    FileDownloadCustomHeaders.Equals(input.FileDownloadCustomHeaders))
                ) && 
                (
                    TextSearchMaxResults == input.TextSearchMaxResults ||
                    TextSearchMaxResults.Equals(input.TextSearchMaxResults)
                ) && 
                (
                    MaxUploadSize == input.MaxUploadSize ||
                    MaxUploadSize.Equals(input.MaxUploadSize)
                ) && 
                (
                    MaxDownloadSize == input.MaxDownloadSize ||
                    MaxDownloadSize.Equals(input.MaxDownloadSize)
                ) && 
                (
                    MaxPages == input.MaxPages ||
                    MaxPages.Equals(input.MaxPages)
                ) && 
                (
                    Certificates == input.Certificates ||
                    Certificates != null &&
                    input.Certificates != null &&
                    Certificates.SequenceEqual(input.Certificates)
                ) && 
                (
                    ExtraFeatures == input.ExtraFeatures ||
                    (ExtraFeatures != null &&
                    ExtraFeatures.Equals(input.ExtraFeatures))
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
                hashCode = hashCode * 59 + Timeout.GetHashCode();
                if (ControlID != null)
                    hashCode = hashCode * 59 + ControlID.GetHashCode();
                hashCode = hashCode * 59 + ShowLogo.GetHashCode();
                if (RemoteIP != null)
                    hashCode = hashCode * 59 + RemoteIP.GetHashCode();
                if (FileHostingURI != null)
                    hashCode = hashCode * 59 + FileHostingURI.GetHashCode();
                if (DocumentURI != null)
                    hashCode = hashCode * 59 + DocumentURI.GetHashCode();
                if (DocumentFileName != null)
                    hashCode = hashCode * 59 + DocumentFileName.GetHashCode();
                hashCode = hashCode * 59 + DisableDownloadProgress.GetHashCode();
                hashCode = hashCode * 59 + DocumentAlignment.GetHashCode();
                hashCode = hashCode * 59 + DocumentPosition.GetHashCode();
                hashCode = hashCode * 59 + EnableGdPictureAnnotations.GetHashCode();
                hashCode = hashCode * 59 + DisableAnnotationPrinting.GetHashCode();
                hashCode = hashCode * 59 + EnableFormFieldsEdition.GetHashCode();
                hashCode = hashCode * 59 + AnnotationEditorMode.GetHashCode();
                hashCode = hashCode * 59 + LinkAnnotationClickBehaviour.GetHashCode();
                hashCode = hashCode * 59 + Zoom.GetHashCode();
                hashCode = hashCode * 59 + ZoomMode.GetHashCode();
                hashCode = hashCode * 59 + OpenZoomMode.GetHashCode();
                hashCode = hashCode * 59 + ViewRotation.GetHashCode();
                hashCode = hashCode * 59 + PageRotation.GetHashCode();
                hashCode = hashCode * 59 + ZoomStep.GetHashCode();
                hashCode = hashCode * 59 + ScrollBars.GetHashCode();
                hashCode = hashCode * 59 + ForceScrollBars.GetHashCode();
                hashCode = hashCode * 59 + PageViewMode.GetHashCode();
                hashCode = hashCode * 59 + EnableTextSelection.GetHashCode();
                hashCode = hashCode * 59 + EnableTextSelectionAnnotation.GetHashCode();
                hashCode = hashCode * 59 + Locale.GetHashCode();
                if (UserLanguages != null)
                    hashCode = hashCode * 59 + UserLanguages.GetHashCode();
                if (ControlWidth != null)
                    hashCode = hashCode * 59 + ControlWidth.GetHashCode();
                if (ControlHeight != null)
                    hashCode = hashCode * 59 + ControlHeight.GetHashCode();
                hashCode = hashCode * 59 + AnnotationDropShadow.GetHashCode();
                hashCode = hashCode * 59 + AllowPrint.GetHashCode();
                hashCode = hashCode * 59 + AllowUpload.GetHashCode();
                hashCode = hashCode * 59 + EnableMultipleThumbnailSelection.GetHashCode();
                hashCode = hashCode * 59 + EnableThumbnailDragDrop.GetHashCode();
                hashCode = hashCode * 59 + EnableFileUploadButton.GetHashCode();
                hashCode = hashCode * 59 + EnableLoadFromUriButton.GetHashCode();
                hashCode = hashCode * 59 + EnableSaveButton.GetHashCode();
                hashCode = hashCode * 59 + EnablePagesNavigationButtons.GetHashCode();
                hashCode = hashCode * 59 + EnablePrintButton.GetHashCode();
                hashCode = hashCode * 59 + EnablePrintToPDF.GetHashCode();
                hashCode = hashCode * 59 + EnableFitWidthButton.GetHashCode();
                hashCode = hashCode * 59 + EnableZoom100Button.GetHashCode();
                hashCode = hashCode * 59 + EnableMouseModeButtons.GetHashCode();
                hashCode = hashCode * 59 + EnablePanModeButton.GetHashCode();
                hashCode = hashCode * 59 + EnableSelectModeButton.GetHashCode();
                hashCode = hashCode * 59 + EnableMarqueeZoomModeButton.GetHashCode();
                hashCode = hashCode * 59 + EnableFullScreenButton.GetHashCode();
                hashCode = hashCode * 59 + EnableFitPageButton.GetHashCode();
                hashCode = hashCode * 59 + EnableZoomButtons.GetHashCode();
                hashCode = hashCode * 59 + EnablePageViewButtons.GetHashCode();
                hashCode = hashCode * 59 + RotateButtonsMode.GetHashCode();
                hashCode = hashCode * 59 + EnableRotateButtons.GetHashCode();
                hashCode = hashCode * 59 + EnableAnnotationActionButtons.GetHashCode();
                hashCode = hashCode * 59 + EnableSelectedTextAnnotationEdition.GetHashCode();
                hashCode = hashCode * 59 + EnableRectangleHighlighterAnnotationButton.GetHashCode();
                hashCode = hashCode * 59 + EnableFreehandHighlighterAnnotationButton.GetHashCode();
                hashCode = hashCode * 59 + EnableRubberStampAnnotationButton.GetHashCode();
                hashCode = hashCode * 59 + EnableRectangleAnnotationButton.GetHashCode();
                hashCode = hashCode * 59 + EnableEllipseAnnotationButton.GetHashCode();
                hashCode = hashCode * 59 + EnableLineAnnotationButton.GetHashCode();
                hashCode = hashCode * 59 + EnableConnectedLineAnnotationButton.GetHashCode();
                hashCode = hashCode * 59 + EnableFreehandAnnotationButton.GetHashCode();
                hashCode = hashCode * 59 + EnableLineArrowAnnotationButton.GetHashCode();
                hashCode = hashCode * 59 + EnableLinkAnnotationButton.GetHashCode();
                hashCode = hashCode * 59 + EnableRulerAnnotationButton.GetHashCode();
                hashCode = hashCode * 59 + EnablePolyRulerAnnotationButton.GetHashCode();
                hashCode = hashCode * 59 + EnableTextAnnotationButton.GetHashCode();
                hashCode = hashCode * 59 + EnableStickyNoteAnnotationButton.GetHashCode();
                hashCode = hashCode * 59 + EnableTwainAcquisitionButton.GetHashCode();
                hashCode = hashCode * 59 + TwainSourceEnableCustomConfiguration.GetHashCode();
                hashCode = hashCode * 59 + TwainSourceSelectFeeder.GetHashCode();
                hashCode = hashCode * 59 + TwainSourceBitDepth.GetHashCode();
                hashCode = hashCode * 59 + TwainSourceResolution.GetHashCode();
                hashCode = hashCode * 59 + TwainSourceEnableDuplex.GetHashCode();
                hashCode = hashCode * 59 + TwainSourceHideUI.GetHashCode();
                hashCode = hashCode * 59 + FreeHandContinuousDrawingMode.GetHashCode();
                hashCode = hashCode * 59 + ShowTextSearchSnapIn.GetHashCode();
                hashCode = hashCode * 59 + ShowThumbnailsSnapIn.GetHashCode();
                hashCode = hashCode * 59 + ShowBookmarksSnapIn.GetHashCode();
                hashCode = hashCode * 59 + ShowAnnotationsSnapIn.GetHashCode();
                hashCode = hashCode * 59 + ShowAnnotationsCommentsSnapIn.GetHashCode();
                hashCode = hashCode * 59 + ShowRedactionSnapIn.GetHashCode();
                hashCode = hashCode * 59 + ShowDigitalSignatureSnapIn.GetHashCode();
                hashCode = hashCode * 59 + ThumbnailWidth.GetHashCode();
                hashCode = hashCode * 59 + ThumbnailHeight.GetHashCode();
                if (SnapInPanelDefaultWidth != null)
                    hashCode = hashCode * 59 + SnapInPanelDefaultWidth.GetHashCode();
                hashCode = hashCode * 59 + CollapsedSnapIn.GetHashCode();
                hashCode = hashCode * 59 + CollapseSnapinOnDocumentClosed.GetHashCode();
                hashCode = hashCode * 59 + ShowSnapInCollapseButton.GetHashCode();
                hashCode = hashCode * 59 + ShowSnapInPanelHeader.GetHashCode();
                hashCode = hashCode * 59 + ShowSnapInButtonStrip.GetHashCode();
                hashCode = hashCode * 59 + ShowToolbar.GetHashCode();
                hashCode = hashCode * 59 + ToolbarStyle.GetHashCode();
                hashCode = hashCode * 59 + ToolbarButtonsSpacing.GetHashCode();
                hashCode = hashCode * 59 + ToolbarHeight.GetHashCode();
                if (StrokeColor != null)
                    hashCode = hashCode * 59 + StrokeColor.GetHashCode();
                if (MiscBorderColor != null)
                    hashCode = hashCode * 59 + MiscBorderColor.GetHashCode();
                if (HeaderColor != null)
                    hashCode = hashCode * 59 + HeaderColor.GetHashCode();
                if (PanelBackColor != null)
                    hashCode = hashCode * 59 + PanelBackColor.GetHashCode();
                if (ViewerBackColor != null)
                    hashCode = hashCode * 59 + ViewerBackColor.GetHashCode();
                if (ActiveSelectedColor != null)
                    hashCode = hashCode * 59 + ActiveSelectedColor.GetHashCode();
                if (ToolbarBackColor != null)
                    hashCode = hashCode * 59 + ToolbarBackColor.GetHashCode();
                if (CustomNotificationIconError != null)
                    hashCode = hashCode * 59 + CustomNotificationIconError.GetHashCode();
                if (CustomNotificationIconQuestion != null)
                    hashCode = hashCode * 59 + CustomNotificationIconQuestion.GetHashCode();
                if (CustomNotificationIconWarning != null)
                    hashCode = hashCode * 59 + CustomNotificationIconWarning.GetHashCode();
                if (CustomNotificationIconInfo != null)
                    hashCode = hashCode * 59 + CustomNotificationIconInfo.GetHashCode();
                if (CustomNotificationIconOk != null)
                    hashCode = hashCode * 59 + CustomNotificationIconOk.GetHashCode();
                if (AllowedExportFormats != null)
                    hashCode = hashCode * 59 + AllowedExportFormats.GetHashCode();
                hashCode = hashCode * 59 + DisableAnnotationDrawingModePanel.GetHashCode();
                hashCode = hashCode * 59 + ImageQuality.GetHashCode();
                hashCode = hashCode * 59 + PrintQuality.GetHashCode();
                hashCode = hashCode * 59 + EnableDocumentsDrop.GetHashCode();
                if (AjaxCustomHeaders != null)
                    hashCode = hashCode * 59 + AjaxCustomHeaders.GetHashCode();
                if (FileDownloadCustomHeaders != null)
                    hashCode = hashCode * 59 + FileDownloadCustomHeaders.GetHashCode();
                hashCode = hashCode * 59 + TextSearchMaxResults.GetHashCode();
                hashCode = hashCode * 59 + MaxUploadSize.GetHashCode();
                hashCode = hashCode * 59 + MaxDownloadSize.GetHashCode();
                hashCode = hashCode * 59 + MaxPages.GetHashCode();
                if (Certificates != null)
                    hashCode = hashCode * 59 + Certificates.GetHashCode();
                if (ExtraFeatures != null)
                    hashCode = hashCode * 59 + ExtraFeatures.GetHashCode();
                return hashCode;
            }
        }
    }

}
