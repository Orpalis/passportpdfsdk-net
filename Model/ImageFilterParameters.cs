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
    /// Represents the parameters for an image filtering action.
    /// </summary>
    [DataContract]
    public partial class ImageFilterParameters :  IEquatable<ImageFilterParameters>
    {
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
        public ImageFilterParameters(string fileId, string pageRange, List<ImageFilters> filters)
        {
            FileId = fileId;
            PageRange = pageRange;
            Filters = filters;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to apply the filter(s) to.
        /// </summary>
        [DataMember(Name="PageRange")]
        public string PageRange { get; set; }

        /// <summary>
        /// Specifies an array of filters to be applied.  A maximum of 5 entries is supported.
        /// </summary>
        [DataMember(Name="Filters")]
        public List<ImageFilters> Filters { get; set; }

        /// <summary>
        /// Specifies the left coordinate, in pixel, of the region to process.
        /// </summary>
        [DataMember(Name="RoiLeft")]
        public int RoiLeft { get; set; } = 0;

        /// <summary>
        /// Specifies the top coordinate, in pixel, of the region to process.
        /// </summary>
        [DataMember(Name="RoiTop")]
        public int RoiTop { get; set; } = 0;

        /// <summary>
        /// Specifies the width, in pixel, of the region to process. 0 causes the entire image to be processed.
        /// </summary>
        [DataMember(Name="RoiWidth")]
        public int RoiWidth { get; set; } = 0;

        /// <summary>
        /// Specifies the height, in pixel, of the region to process. 0 causes the entire image to be processed.
        /// </summary>
        [DataMember(Name="RoiHeight")]
        public int RoiHeight { get; set; } = 0;

        /// <summary>
        /// Specifies the kernel size for the Gaussian filter (if enabled). The size of the square kernel to use. Should be a odd value. For example, a size of 3 will involve 3 * 3 pixels in each pass. The larger the value the more blur you get. The range is larger or equal than 3, and less than the Image's Smaller Dimension (Width, Height) divided by 2. Suggested value is 3 for a [96-120] DPI image and 5 for a [200-250] dpi bitmap.
        /// </summary>
        [DataMember(Name="GaussianKernelSize")]
        public int GaussianKernelSize { get; set; } = 3;

        /// <summary>
        /// Size of Edges to become after the unsharp mask effect is applied. It controls how wide they get after the filter is applied. Radius and Amount interact, reducing one, allows more of the other. Minimum Value of Radius should be 3 or more to allow for enough pixels surrounding the edge to be investigated. If value passed less than 3 is passed it will be ammended automatically to 3. Proper value is 5. Value >= 3.
        /// </summary>
        [DataMember(Name="UnsharpMaskRadius")]
        public int UnsharpMaskRadius { get; set; } = 5;

        /// <summary>
        /// Amount of Contrast to be added to areas of edges where filter will be applies. It controls how much darker and how much brighter the edges become. Proper value is 0.5, Value between 0.0-5.0.
        /// </summary>
        [DataMember(Name="UnsharpMaskAmount")]
        public double UnsharpMaskAmount { get; set; } = 0.5D;

        /// <summary>
        /// Specifies the amount of edges to be sharpened. Smaller values sharpen more, higher values exclude the subtle edges from being sharpened. Proper value is 40. Value between 0-255.
        /// </summary>
        [DataMember(Name="UnsharpMaskThreshold")]
        public int UnsharpMaskThreshold { get; set; } = 40;

        /// <summary>
        /// Size of ball rolled under the image. Controlled the amount of subtraction. Value >= 50.
        /// </summary>
        [DataMember(Name="SubtractBackgroundRollingBallSize")]
        public int SubtractBackgroundRollingBallSize { get; set; } = 50;

        /// <summary>
        /// Whether a background is lighter or not than the foreground.Value >= true.
        /// </summary>
        [DataMember(Name="SubtractBackgroundLightBackground")]
        public bool SubtractBackgroundLightBackground { get; set; } = true;

        /// <summary>
        /// Specifies the kernel size for the median filter (if enabled). Level corresponding to number of pixels to include in the median operation, where Level = n, corresponds to (n*2+1)^2 pixels to be included. For Example, KernelSize = 1 includes 9 pixels in the median operation, KernelSize = 2 includes 25 pixels in the median operation. Range from 1 to 60.
        /// </summary>
        [DataMember(Name="MedianKernelSize")]
        public int MedianKernelSize { get; set; } = 4;

        /// <summary>
        /// Specifies the kernel size for the minimum filter (if enabled). How large should objects grow in each direction of the four directions, left, right, top, and bottom This value should be larger than 1 and smaller than Image's Smaller Dimension (Width or Height) divided by 2.
        /// </summary>
        [DataMember(Name="MinKernelSize")]
        public int MinKernelSize { get; set; } = 2;

        /// <summary>
        /// Specifies the kernel size for the maximum filter (if enabled). How much smaller should objects become in each direction of the four directions, left, right, top, and bottom. This value should be larger than 1 and smaller than Image's Smaller Dimension (Width or Height) divided by 2.
        /// </summary>
        [DataMember(Name="MaxKernelSize")]
        public int MaxKernelSize { get; set; } = 2;

        /// <summary>
        /// Specifies the value for the soften filter (if enabled). Factor between 1 and 100.
        /// </summary>
        [DataMember(Name="SoftenValue")]
        public int SoftenValue { get; set; } = 0;

        /// <summary>
        /// Hue for the colorization effect (if enabled) [0..100].
        /// </summary>
        [DataMember(Name="ColorizeHue")]
        public float ColorizeHue { get; set; } = 0F;

        /// <summary>
        /// Saturation for the colorization effect (if enabled) [0..100].
        /// </summary>
        [DataMember(Name="ColorizeSaturation")]
        public float ColorizeSaturation { get; set; } = 0F;

        /// <summary>
        /// Luminosity for the colorization effect  (if enabled) [0..100].
        /// </summary>
        [DataMember(Name="ColorizeLuminosity")]
        public float ColorizeLuminosity { get; set; } = 0F;

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
            return Equals(input as ImageFilterParameters);
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
                    FileId == input.FileId ||
                    (FileId != null &&
                    FileId.Equals(input.FileId))
                ) && 
                (
                    PageRange == input.PageRange ||
                    (PageRange != null &&
                    PageRange.Equals(input.PageRange))
                ) && 
                (
                    Filters == input.Filters ||
                    Filters != null &&
                    input.Filters != null &&
                    Filters.SequenceEqual(input.Filters)
                ) && 
                (
                    RoiLeft == input.RoiLeft ||
                    RoiLeft.Equals(input.RoiLeft)
                ) && 
                (
                    RoiTop == input.RoiTop ||
                    RoiTop.Equals(input.RoiTop)
                ) && 
                (
                    RoiWidth == input.RoiWidth ||
                    RoiWidth.Equals(input.RoiWidth)
                ) && 
                (
                    RoiHeight == input.RoiHeight ||
                    RoiHeight.Equals(input.RoiHeight)
                ) && 
                (
                    GaussianKernelSize == input.GaussianKernelSize ||
                    GaussianKernelSize.Equals(input.GaussianKernelSize)
                ) && 
                (
                    UnsharpMaskRadius == input.UnsharpMaskRadius ||
                    UnsharpMaskRadius.Equals(input.UnsharpMaskRadius)
                ) && 
                (
                    UnsharpMaskAmount == input.UnsharpMaskAmount ||
                    UnsharpMaskAmount.Equals(input.UnsharpMaskAmount)
                ) && 
                (
                    UnsharpMaskThreshold == input.UnsharpMaskThreshold ||
                    UnsharpMaskThreshold.Equals(input.UnsharpMaskThreshold)
                ) && 
                (
                    SubtractBackgroundRollingBallSize == input.SubtractBackgroundRollingBallSize ||
                    SubtractBackgroundRollingBallSize.Equals(input.SubtractBackgroundRollingBallSize)
                ) && 
                (
                    SubtractBackgroundLightBackground == input.SubtractBackgroundLightBackground ||
                    SubtractBackgroundLightBackground.Equals(input.SubtractBackgroundLightBackground)
                ) && 
                (
                    MedianKernelSize == input.MedianKernelSize ||
                    MedianKernelSize.Equals(input.MedianKernelSize)
                ) && 
                (
                    MinKernelSize == input.MinKernelSize ||
                    MinKernelSize.Equals(input.MinKernelSize)
                ) && 
                (
                    MaxKernelSize == input.MaxKernelSize ||
                    MaxKernelSize.Equals(input.MaxKernelSize)
                ) && 
                (
                    SoftenValue == input.SoftenValue ||
                    SoftenValue.Equals(input.SoftenValue)
                ) && 
                (
                    ColorizeHue == input.ColorizeHue ||
                    ColorizeHue.Equals(input.ColorizeHue)
                ) && 
                (
                    ColorizeSaturation == input.ColorizeSaturation ||
                    ColorizeSaturation.Equals(input.ColorizeSaturation)
                ) && 
                (
                    ColorizeLuminosity == input.ColorizeLuminosity ||
                    ColorizeLuminosity.Equals(input.ColorizeLuminosity)
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
                if (PageRange != null)
                    hashCode = hashCode * 59 + PageRange.GetHashCode();
                if (Filters != null)
                    hashCode = hashCode * 59 + Filters.GetHashCode();
                hashCode = hashCode * 59 + RoiLeft.GetHashCode();
                hashCode = hashCode * 59 + RoiTop.GetHashCode();
                hashCode = hashCode * 59 + RoiWidth.GetHashCode();
                hashCode = hashCode * 59 + RoiHeight.GetHashCode();
                hashCode = hashCode * 59 + GaussianKernelSize.GetHashCode();
                hashCode = hashCode * 59 + UnsharpMaskRadius.GetHashCode();
                hashCode = hashCode * 59 + UnsharpMaskAmount.GetHashCode();
                hashCode = hashCode * 59 + UnsharpMaskThreshold.GetHashCode();
                hashCode = hashCode * 59 + SubtractBackgroundRollingBallSize.GetHashCode();
                hashCode = hashCode * 59 + SubtractBackgroundLightBackground.GetHashCode();
                hashCode = hashCode * 59 + MedianKernelSize.GetHashCode();
                hashCode = hashCode * 59 + MinKernelSize.GetHashCode();
                hashCode = hashCode * 59 + MaxKernelSize.GetHashCode();
                hashCode = hashCode * 59 + SoftenValue.GetHashCode();
                hashCode = hashCode * 59 + ColorizeHue.GetHashCode();
                hashCode = hashCode * 59 + ColorizeSaturation.GetHashCode();
                hashCode = hashCode * 59 + ColorizeLuminosity.GetHashCode();
                return hashCode;
            }
        }
    }

}
