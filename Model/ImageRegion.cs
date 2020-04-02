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
    /// Represents a region of a given page of an image.
    /// </summary>
    [DataContract]
    public partial class ImageRegion :  IEquatable<ImageRegion>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageRegion" /> class.
        /// </summary>
        public ImageRegion()
        {
        }

        /// <summary>
        /// Specifies the number of the page.
        /// </summary>
        [DataMember(Name="PageNumber")]
        public int PageNumber { get; set; }

        /// <summary>
        /// Specifies, in pixels, the left coordinate of the region.
        /// </summary>
        [DataMember(Name="Left")]
        public int Left { get; set; }

        /// <summary>
        /// Specifies, in pixels, the top coordinate of the region.
        /// </summary>
        [DataMember(Name="Top")]
        public int Top { get; set; }

        /// <summary>
        /// Specifies, in pixels, the width of the region.
        /// </summary>
        [DataMember(Name="Width")]
        public int Width { get; set; }

        /// <summary>
        /// Specifies, in pixels, the height of the region.
        /// </summary>
        [DataMember(Name="Height")]
        public int Height { get; set; }

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
            return Equals(input as ImageRegion);
        }

        /// <summary>
        /// Returns true if ImageRegion instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageRegion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageRegion input)
        {
            if (input == null)
                return false;

            return 
                (
                    PageNumber == input.PageNumber ||
                    PageNumber.Equals(input.PageNumber)
                ) && 
                (
                    Left == input.Left ||
                    Left.Equals(input.Left)
                ) && 
                (
                    Top == input.Top ||
                    Top.Equals(input.Top)
                ) && 
                (
                    Width == input.Width ||
                    Width.Equals(input.Width)
                ) && 
                (
                    Height == input.Height ||
                    Height.Equals(input.Height)
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
                hashCode = hashCode * 59 + PageNumber.GetHashCode();
                hashCode = hashCode * 59 + Left.GetHashCode();
                hashCode = hashCode * 59 + Top.GetHashCode();
                hashCode = hashCode * 59 + Width.GetHashCode();
                hashCode = hashCode * 59 + Height.GetHashCode();
                return hashCode;
            }
        }
    }

}
