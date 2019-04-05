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
    /// Represents the parameters for an image filtering action.
    /// </summary>
    [DataContract]
    public partial class ImageFilterParameters :  IEquatable<ImageFilterParameters>, IValidatableObject
    {
        /// <summary>
        /// Defines Filters
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FiltersEnum
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


        /// <summary>
        /// Specifies an array of filters to be applied.  A maximum of 5 entries is supported.
        /// </summary>
        /// <value>Specifies an array of filters to be applied.  A maximum of 5 entries is supported.</value>
        [DataMember(Name="Filters", EmitDefaultValue=false)]
        public List<FiltersEnum> Filters { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageFilterParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageFilterParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageFilterParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageRange">Specifies the number of the page, or the range of pages to apply the filter(s) to. (required).</param>
        /// <param name="filters">Specifies an array of filters to be applied.  A maximum of 5 entries is supported. (required).</param>
        /// <param name="roiLeft">Specifies the left coordinate, in pixel, of the region to process..</param>
        /// <param name="roiTop">Specifies the top coordinate, in pixel, of the region to process..</param>
        /// <param name="roiWidth">Specifies the width, in pixel, of the region to process. 0 causes the entire image to be processed..</param>
        /// <param name="roiHeight">Specifies the height, in pixel, of the region to process. 0 causes the entire image to be processed..</param>
        /// <param name="gaussianKernelSize">Specifies the kernel size for the Gaussian filter (if enabled). The size of the square kernel to use. Should be a odd value. For example, a size of 3 will involve 3 * 3 pixels in each pass. The larger the value the more blur you get. The range is larger or equal than 3, and less than the Image&#39;s Smaller Dimension (Width, Height) divided by 2. Suggested value is 3 for a [96-120] DPI image and 5 for a [200-250] dpi bitmap. (default to 3).</param>
        /// <param name="unsharpMaskRadius">Size of Edges to become after the unsharp mask effect is applied. It controls how wide they get after the filter is applied. Radius and Amount interact, reducing one, allows more of the other. Minimum Value of Radius should be 3 or more to allow for enough pixels surrounding the edge to be investigated. If value passed less than 3 is passed it will be ammended automatically to 3. Proper value is 5. Value &amp;gt;&#x3D; 3. (default to 5).</param>
        /// <param name="unsharpMaskAmount">Amount of Contrast to be added to areas of edges where filter will be applies. It controls how much darker and how much brighter the edges become. Proper value is 0.5, Value between 0.0-5.0. (default to 0.5D).</param>
        /// <param name="unsharpMaskThreshold">Specifies the amount of edges to be sharpened. Smaller values sharpen more, higher values exclude the subtle edges from being sharpened. Proper value is 40. Value between 0-255. (default to 40).</param>
        /// <param name="subtractBackgroundRollingBallSize">Size of ball rolled under the image. Controlled the amount of subtraction. Value &amp;gt;&#x3D; 50. (default to 50).</param>
        /// <param name="subtractBackgroundLightBackground">Whether a background is lighter or not than the foreground.Value &amp;gt;&#x3D; true. (default to true).</param>
        /// <param name="medianKernelSize">Specifies the kernel size for the median filter (if enabled). Level corresponding to number of pixels to include in the median operation, where Level &#x3D; n, corresponds to (n*2+1)^2 pixels to be included. For Example, KernelSize &#x3D; 1 includes 9 pixels in the median operation, KernelSize &#x3D; 2 includes 25 pixels in the median operation. Range from 1 to 60. (default to 4).</param>
        /// <param name="minKernelSize">Specifies the kernel size for the minimum filter (if enabled). How large should objects grow in each direction of the four directions, left, right, top, and bottom This value should be larger than 1 and smaller than Image&#39;s Smaller Dimension (Width or Height) divided by 2. (default to 2).</param>
        /// <param name="maxKernelSize">Specifies the kernel size for the maximum filter (if enabled). How much smaller should objects become in each direction of the four directions, left, right, top, and bottom. This value should be larger than 1 and smaller than Image&#39;s Smaller Dimension (Width or Height) divided by 2. (default to 2).</param>
        /// <param name="softenValue">Specifies the value for the soften filter (if enabled). Factor between 1 and 100..</param>
        /// <param name="colorizeHue">Hue for the colorization effect (if enabled) [0..100]..</param>
        /// <param name="colorizeSaturation">Saturation for the colorization effect (if enabled) [0..100]..</param>
        /// <param name="colorizeLuminosity">Luminosity for the colorization effect  (if enabled) [0..100]..</param>
        public ImageFilterParameters(string fileId = default(string), string pageRange = default(string), List<FiltersEnum> filters = default(List<FiltersEnum>), int? roiLeft = default(int?), int? roiTop = default(int?), int? roiWidth = default(int?), int? roiHeight = default(int?), int? gaussianKernelSize = 3, int? unsharpMaskRadius = 5, double? unsharpMaskAmount = 0.5D, int? unsharpMaskThreshold = 40, int? subtractBackgroundRollingBallSize = 50, bool? subtractBackgroundLightBackground = true, int? medianKernelSize = 4, int? minKernelSize = 2, int? maxKernelSize = 2, int? softenValue = default(int?), float? colorizeHue = default(float?), float? colorizeSaturation = default(float?), float? colorizeLuminosity = default(float?))
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new InvalidDataException("fileId is a required property for ImageFilterParameters and cannot be null");
            }
            else
            {
                this.FileId = fileId;
            }
            // to ensure "pageRange" is required (not null)
            if (pageRange == null)
            {
                throw new InvalidDataException("pageRange is a required property for ImageFilterParameters and cannot be null");
            }
            else
            {
                this.PageRange = pageRange;
            }
            // to ensure "filters" is required (not null)
            if (filters == null)
            {
                throw new InvalidDataException("filters is a required property for ImageFilterParameters and cannot be null");
            }
            else
            {
                this.Filters = filters;
            }
            this.RoiLeft = roiLeft;
            this.RoiTop = roiTop;
            this.RoiWidth = roiWidth;
            this.RoiHeight = roiHeight;
            // use default value if no "gaussianKernelSize" provided
            if (gaussianKernelSize == null)
            {
                this.GaussianKernelSize = 3;
            }
            else
            {
                this.GaussianKernelSize = gaussianKernelSize;
            }
            // use default value if no "unsharpMaskRadius" provided
            if (unsharpMaskRadius == null)
            {
                this.UnsharpMaskRadius = 5;
            }
            else
            {
                this.UnsharpMaskRadius = unsharpMaskRadius;
            }
            // use default value if no "unsharpMaskAmount" provided
            if (unsharpMaskAmount == null)
            {
                this.UnsharpMaskAmount = 0.5D;
            }
            else
            {
                this.UnsharpMaskAmount = unsharpMaskAmount;
            }
            // use default value if no "unsharpMaskThreshold" provided
            if (unsharpMaskThreshold == null)
            {
                this.UnsharpMaskThreshold = 40;
            }
            else
            {
                this.UnsharpMaskThreshold = unsharpMaskThreshold;
            }
            // use default value if no "subtractBackgroundRollingBallSize" provided
            if (subtractBackgroundRollingBallSize == null)
            {
                this.SubtractBackgroundRollingBallSize = 50;
            }
            else
            {
                this.SubtractBackgroundRollingBallSize = subtractBackgroundRollingBallSize;
            }
            // use default value if no "subtractBackgroundLightBackground" provided
            if (subtractBackgroundLightBackground == null)
            {
                this.SubtractBackgroundLightBackground = true;
            }
            else
            {
                this.SubtractBackgroundLightBackground = subtractBackgroundLightBackground;
            }
            // use default value if no "medianKernelSize" provided
            if (medianKernelSize == null)
            {
                this.MedianKernelSize = 4;
            }
            else
            {
                this.MedianKernelSize = medianKernelSize;
            }
            // use default value if no "minKernelSize" provided
            if (minKernelSize == null)
            {
                this.MinKernelSize = 2;
            }
            else
            {
                this.MinKernelSize = minKernelSize;
            }
            // use default value if no "maxKernelSize" provided
            if (maxKernelSize == null)
            {
                this.MaxKernelSize = 2;
            }
            else
            {
                this.MaxKernelSize = maxKernelSize;
            }
            this.SoftenValue = softenValue;
            this.ColorizeHue = colorizeHue;
            this.ColorizeSaturation = colorizeSaturation;
            this.ColorizeLuminosity = colorizeLuminosity;
        }
        
        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        /// <value>The identifier of the previously uploaded file to be processed.</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to apply the filter(s) to.
        /// </summary>
        /// <value>Specifies the number of the page, or the range of pages to apply the filter(s) to.</value>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }


        /// <summary>
        /// Specifies the left coordinate, in pixel, of the region to process.
        /// </summary>
        /// <value>Specifies the left coordinate, in pixel, of the region to process.</value>
        [DataMember(Name="RoiLeft", EmitDefaultValue=false)]
        public int? RoiLeft { get; set; }

        /// <summary>
        /// Specifies the top coordinate, in pixel, of the region to process.
        /// </summary>
        /// <value>Specifies the top coordinate, in pixel, of the region to process.</value>
        [DataMember(Name="RoiTop", EmitDefaultValue=false)]
        public int? RoiTop { get; set; }

        /// <summary>
        /// Specifies the width, in pixel, of the region to process. 0 causes the entire image to be processed.
        /// </summary>
        /// <value>Specifies the width, in pixel, of the region to process. 0 causes the entire image to be processed.</value>
        [DataMember(Name="RoiWidth", EmitDefaultValue=false)]
        public int? RoiWidth { get; set; }

        /// <summary>
        /// Specifies the height, in pixel, of the region to process. 0 causes the entire image to be processed.
        /// </summary>
        /// <value>Specifies the height, in pixel, of the region to process. 0 causes the entire image to be processed.</value>
        [DataMember(Name="RoiHeight", EmitDefaultValue=false)]
        public int? RoiHeight { get; set; }

        /// <summary>
        /// Specifies the kernel size for the Gaussian filter (if enabled). The size of the square kernel to use. Should be a odd value. For example, a size of 3 will involve 3 * 3 pixels in each pass. The larger the value the more blur you get. The range is larger or equal than 3, and less than the Image&#39;s Smaller Dimension (Width, Height) divided by 2. Suggested value is 3 for a [96-120] DPI image and 5 for a [200-250] dpi bitmap.
        /// </summary>
        /// <value>Specifies the kernel size for the Gaussian filter (if enabled). The size of the square kernel to use. Should be a odd value. For example, a size of 3 will involve 3 * 3 pixels in each pass. The larger the value the more blur you get. The range is larger or equal than 3, and less than the Image&#39;s Smaller Dimension (Width, Height) divided by 2. Suggested value is 3 for a [96-120] DPI image and 5 for a [200-250] dpi bitmap.</value>
        [DataMember(Name="GaussianKernelSize", EmitDefaultValue=false)]
        public int? GaussianKernelSize { get; set; }

        /// <summary>
        /// Size of Edges to become after the unsharp mask effect is applied. It controls how wide they get after the filter is applied. Radius and Amount interact, reducing one, allows more of the other. Minimum Value of Radius should be 3 or more to allow for enough pixels surrounding the edge to be investigated. If value passed less than 3 is passed it will be ammended automatically to 3. Proper value is 5. Value &amp;gt;&#x3D; 3.
        /// </summary>
        /// <value>Size of Edges to become after the unsharp mask effect is applied. It controls how wide they get after the filter is applied. Radius and Amount interact, reducing one, allows more of the other. Minimum Value of Radius should be 3 or more to allow for enough pixels surrounding the edge to be investigated. If value passed less than 3 is passed it will be ammended automatically to 3. Proper value is 5. Value &amp;gt;&#x3D; 3.</value>
        [DataMember(Name="UnsharpMaskRadius", EmitDefaultValue=false)]
        public int? UnsharpMaskRadius { get; set; }

        /// <summary>
        /// Amount of Contrast to be added to areas of edges where filter will be applies. It controls how much darker and how much brighter the edges become. Proper value is 0.5, Value between 0.0-5.0.
        /// </summary>
        /// <value>Amount of Contrast to be added to areas of edges where filter will be applies. It controls how much darker and how much brighter the edges become. Proper value is 0.5, Value between 0.0-5.0.</value>
        [DataMember(Name="UnsharpMaskAmount", EmitDefaultValue=false)]
        public double? UnsharpMaskAmount { get; set; }

        /// <summary>
        /// Specifies the amount of edges to be sharpened. Smaller values sharpen more, higher values exclude the subtle edges from being sharpened. Proper value is 40. Value between 0-255.
        /// </summary>
        /// <value>Specifies the amount of edges to be sharpened. Smaller values sharpen more, higher values exclude the subtle edges from being sharpened. Proper value is 40. Value between 0-255.</value>
        [DataMember(Name="UnsharpMaskThreshold", EmitDefaultValue=false)]
        public int? UnsharpMaskThreshold { get; set; }

        /// <summary>
        /// Size of ball rolled under the image. Controlled the amount of subtraction. Value &amp;gt;&#x3D; 50.
        /// </summary>
        /// <value>Size of ball rolled under the image. Controlled the amount of subtraction. Value &amp;gt;&#x3D; 50.</value>
        [DataMember(Name="SubtractBackgroundRollingBallSize", EmitDefaultValue=false)]
        public int? SubtractBackgroundRollingBallSize { get; set; }

        /// <summary>
        /// Whether a background is lighter or not than the foreground.Value &amp;gt;&#x3D; true.
        /// </summary>
        /// <value>Whether a background is lighter or not than the foreground.Value &amp;gt;&#x3D; true.</value>
        [DataMember(Name="SubtractBackgroundLightBackground", EmitDefaultValue=false)]
        public bool? SubtractBackgroundLightBackground { get; set; }

        /// <summary>
        /// Specifies the kernel size for the median filter (if enabled). Level corresponding to number of pixels to include in the median operation, where Level &#x3D; n, corresponds to (n*2+1)^2 pixels to be included. For Example, KernelSize &#x3D; 1 includes 9 pixels in the median operation, KernelSize &#x3D; 2 includes 25 pixels in the median operation. Range from 1 to 60.
        /// </summary>
        /// <value>Specifies the kernel size for the median filter (if enabled). Level corresponding to number of pixels to include in the median operation, where Level &#x3D; n, corresponds to (n*2+1)^2 pixels to be included. For Example, KernelSize &#x3D; 1 includes 9 pixels in the median operation, KernelSize &#x3D; 2 includes 25 pixels in the median operation. Range from 1 to 60.</value>
        [DataMember(Name="MedianKernelSize", EmitDefaultValue=false)]
        public int? MedianKernelSize { get; set; }

        /// <summary>
        /// Specifies the kernel size for the minimum filter (if enabled). How large should objects grow in each direction of the four directions, left, right, top, and bottom This value should be larger than 1 and smaller than Image&#39;s Smaller Dimension (Width or Height) divided by 2.
        /// </summary>
        /// <value>Specifies the kernel size for the minimum filter (if enabled). How large should objects grow in each direction of the four directions, left, right, top, and bottom This value should be larger than 1 and smaller than Image&#39;s Smaller Dimension (Width or Height) divided by 2.</value>
        [DataMember(Name="MinKernelSize", EmitDefaultValue=false)]
        public int? MinKernelSize { get; set; }

        /// <summary>
        /// Specifies the kernel size for the maximum filter (if enabled). How much smaller should objects become in each direction of the four directions, left, right, top, and bottom. This value should be larger than 1 and smaller than Image&#39;s Smaller Dimension (Width or Height) divided by 2.
        /// </summary>
        /// <value>Specifies the kernel size for the maximum filter (if enabled). How much smaller should objects become in each direction of the four directions, left, right, top, and bottom. This value should be larger than 1 and smaller than Image&#39;s Smaller Dimension (Width or Height) divided by 2.</value>
        [DataMember(Name="MaxKernelSize", EmitDefaultValue=false)]
        public int? MaxKernelSize { get; set; }

        /// <summary>
        /// Specifies the value for the soften filter (if enabled). Factor between 1 and 100.
        /// </summary>
        /// <value>Specifies the value for the soften filter (if enabled). Factor between 1 and 100.</value>
        [DataMember(Name="SoftenValue", EmitDefaultValue=false)]
        public int? SoftenValue { get; set; }

        /// <summary>
        /// Hue for the colorization effect (if enabled) [0..100].
        /// </summary>
        /// <value>Hue for the colorization effect (if enabled) [0..100].</value>
        [DataMember(Name="ColorizeHue", EmitDefaultValue=false)]
        public float? ColorizeHue { get; set; }

        /// <summary>
        /// Saturation for the colorization effect (if enabled) [0..100].
        /// </summary>
        /// <value>Saturation for the colorization effect (if enabled) [0..100].</value>
        [DataMember(Name="ColorizeSaturation", EmitDefaultValue=false)]
        public float? ColorizeSaturation { get; set; }

        /// <summary>
        /// Luminosity for the colorization effect  (if enabled) [0..100].
        /// </summary>
        /// <value>Luminosity for the colorization effect  (if enabled) [0..100].</value>
        [DataMember(Name="ColorizeLuminosity", EmitDefaultValue=false)]
        public float? ColorizeLuminosity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageFilterParameters {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  RoiLeft: ").Append(RoiLeft).Append("\n");
            sb.Append("  RoiTop: ").Append(RoiTop).Append("\n");
            sb.Append("  RoiWidth: ").Append(RoiWidth).Append("\n");
            sb.Append("  RoiHeight: ").Append(RoiHeight).Append("\n");
            sb.Append("  GaussianKernelSize: ").Append(GaussianKernelSize).Append("\n");
            sb.Append("  UnsharpMaskRadius: ").Append(UnsharpMaskRadius).Append("\n");
            sb.Append("  UnsharpMaskAmount: ").Append(UnsharpMaskAmount).Append("\n");
            sb.Append("  UnsharpMaskThreshold: ").Append(UnsharpMaskThreshold).Append("\n");
            sb.Append("  SubtractBackgroundRollingBallSize: ").Append(SubtractBackgroundRollingBallSize).Append("\n");
            sb.Append("  SubtractBackgroundLightBackground: ").Append(SubtractBackgroundLightBackground).Append("\n");
            sb.Append("  MedianKernelSize: ").Append(MedianKernelSize).Append("\n");
            sb.Append("  MinKernelSize: ").Append(MinKernelSize).Append("\n");
            sb.Append("  MaxKernelSize: ").Append(MaxKernelSize).Append("\n");
            sb.Append("  SoftenValue: ").Append(SoftenValue).Append("\n");
            sb.Append("  ColorizeHue: ").Append(ColorizeHue).Append("\n");
            sb.Append("  ColorizeSaturation: ").Append(ColorizeSaturation).Append("\n");
            sb.Append("  ColorizeLuminosity: ").Append(ColorizeLuminosity).Append("\n");
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
            return this.Equals(input as ImageFilterParameters);
        }

        /// <summary>
        /// Returns true if ImageFilterParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageFilterParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageFilterParameters input)
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
                    this.PageRange == input.PageRange ||
                    (this.PageRange != null &&
                    this.PageRange.Equals(input.PageRange))
                ) && 
                (
                    this.Filters == input.Filters ||
                    this.Filters != null &&
                    this.Filters.SequenceEqual(input.Filters)
                ) && 
                (
                    this.RoiLeft == input.RoiLeft ||
                    (this.RoiLeft != null &&
                    this.RoiLeft.Equals(input.RoiLeft))
                ) && 
                (
                    this.RoiTop == input.RoiTop ||
                    (this.RoiTop != null &&
                    this.RoiTop.Equals(input.RoiTop))
                ) && 
                (
                    this.RoiWidth == input.RoiWidth ||
                    (this.RoiWidth != null &&
                    this.RoiWidth.Equals(input.RoiWidth))
                ) && 
                (
                    this.RoiHeight == input.RoiHeight ||
                    (this.RoiHeight != null &&
                    this.RoiHeight.Equals(input.RoiHeight))
                ) && 
                (
                    this.GaussianKernelSize == input.GaussianKernelSize ||
                    (this.GaussianKernelSize != null &&
                    this.GaussianKernelSize.Equals(input.GaussianKernelSize))
                ) && 
                (
                    this.UnsharpMaskRadius == input.UnsharpMaskRadius ||
                    (this.UnsharpMaskRadius != null &&
                    this.UnsharpMaskRadius.Equals(input.UnsharpMaskRadius))
                ) && 
                (
                    this.UnsharpMaskAmount == input.UnsharpMaskAmount ||
                    (this.UnsharpMaskAmount != null &&
                    this.UnsharpMaskAmount.Equals(input.UnsharpMaskAmount))
                ) && 
                (
                    this.UnsharpMaskThreshold == input.UnsharpMaskThreshold ||
                    (this.UnsharpMaskThreshold != null &&
                    this.UnsharpMaskThreshold.Equals(input.UnsharpMaskThreshold))
                ) && 
                (
                    this.SubtractBackgroundRollingBallSize == input.SubtractBackgroundRollingBallSize ||
                    (this.SubtractBackgroundRollingBallSize != null &&
                    this.SubtractBackgroundRollingBallSize.Equals(input.SubtractBackgroundRollingBallSize))
                ) && 
                (
                    this.SubtractBackgroundLightBackground == input.SubtractBackgroundLightBackground ||
                    (this.SubtractBackgroundLightBackground != null &&
                    this.SubtractBackgroundLightBackground.Equals(input.SubtractBackgroundLightBackground))
                ) && 
                (
                    this.MedianKernelSize == input.MedianKernelSize ||
                    (this.MedianKernelSize != null &&
                    this.MedianKernelSize.Equals(input.MedianKernelSize))
                ) && 
                (
                    this.MinKernelSize == input.MinKernelSize ||
                    (this.MinKernelSize != null &&
                    this.MinKernelSize.Equals(input.MinKernelSize))
                ) && 
                (
                    this.MaxKernelSize == input.MaxKernelSize ||
                    (this.MaxKernelSize != null &&
                    this.MaxKernelSize.Equals(input.MaxKernelSize))
                ) && 
                (
                    this.SoftenValue == input.SoftenValue ||
                    (this.SoftenValue != null &&
                    this.SoftenValue.Equals(input.SoftenValue))
                ) && 
                (
                    this.ColorizeHue == input.ColorizeHue ||
                    (this.ColorizeHue != null &&
                    this.ColorizeHue.Equals(input.ColorizeHue))
                ) && 
                (
                    this.ColorizeSaturation == input.ColorizeSaturation ||
                    (this.ColorizeSaturation != null &&
                    this.ColorizeSaturation.Equals(input.ColorizeSaturation))
                ) && 
                (
                    this.ColorizeLuminosity == input.ColorizeLuminosity ||
                    (this.ColorizeLuminosity != null &&
                    this.ColorizeLuminosity.Equals(input.ColorizeLuminosity))
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
                if (this.PageRange != null)
                    hashCode = hashCode * 59 + this.PageRange.GetHashCode();
                if (this.Filters != null)
                    hashCode = hashCode * 59 + this.Filters.GetHashCode();
                if (this.RoiLeft != null)
                    hashCode = hashCode * 59 + this.RoiLeft.GetHashCode();
                if (this.RoiTop != null)
                    hashCode = hashCode * 59 + this.RoiTop.GetHashCode();
                if (this.RoiWidth != null)
                    hashCode = hashCode * 59 + this.RoiWidth.GetHashCode();
                if (this.RoiHeight != null)
                    hashCode = hashCode * 59 + this.RoiHeight.GetHashCode();
                if (this.GaussianKernelSize != null)
                    hashCode = hashCode * 59 + this.GaussianKernelSize.GetHashCode();
                if (this.UnsharpMaskRadius != null)
                    hashCode = hashCode * 59 + this.UnsharpMaskRadius.GetHashCode();
                if (this.UnsharpMaskAmount != null)
                    hashCode = hashCode * 59 + this.UnsharpMaskAmount.GetHashCode();
                if (this.UnsharpMaskThreshold != null)
                    hashCode = hashCode * 59 + this.UnsharpMaskThreshold.GetHashCode();
                if (this.SubtractBackgroundRollingBallSize != null)
                    hashCode = hashCode * 59 + this.SubtractBackgroundRollingBallSize.GetHashCode();
                if (this.SubtractBackgroundLightBackground != null)
                    hashCode = hashCode * 59 + this.SubtractBackgroundLightBackground.GetHashCode();
                if (this.MedianKernelSize != null)
                    hashCode = hashCode * 59 + this.MedianKernelSize.GetHashCode();
                if (this.MinKernelSize != null)
                    hashCode = hashCode * 59 + this.MinKernelSize.GetHashCode();
                if (this.MaxKernelSize != null)
                    hashCode = hashCode * 59 + this.MaxKernelSize.GetHashCode();
                if (this.SoftenValue != null)
                    hashCode = hashCode * 59 + this.SoftenValue.GetHashCode();
                if (this.ColorizeHue != null)
                    hashCode = hashCode * 59 + this.ColorizeHue.GetHashCode();
                if (this.ColorizeSaturation != null)
                    hashCode = hashCode * 59 + this.ColorizeSaturation.GetHashCode();
                if (this.ColorizeLuminosity != null)
                    hashCode = hashCode * 59 + this.ColorizeLuminosity.GetHashCode();
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
