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
    /// Represents a cloned image region.
    /// </summary>
    [DataContract]
    public partial class ClonedImageRegion :  IEquatable<ClonedImageRegion>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClonedImageRegion" /> class.
        /// </summary>
        public ClonedImageRegion()
        {
        }

        /// <summary>
        /// Gets or Sets ImageRegion
        /// </summary>
        [DataMember(Name="ImageRegion")]
        public ImageRegion ImageRegion { get; set; }

        /// <summary>
        /// The file identifier of the image.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

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
            return Equals(input as ClonedImageRegion);
        }

        /// <summary>
        /// Returns true if ClonedImageRegion instances are equal
        /// </summary>
        /// <param name="input">Instance of ClonedImageRegion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClonedImageRegion input)
        {
            if (input == null)
                return false;

            return 
                (
                    ImageRegion == input.ImageRegion ||
                    (ImageRegion != null &&
                    ImageRegion.Equals(input.ImageRegion))
                ) && 
                (
                    FileId == input.FileId ||
                    (FileId != null &&
                    FileId.Equals(input.FileId))
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
                if (ImageRegion != null)
                    hashCode = hashCode * 59 + ImageRegion.GetHashCode();
                if (FileId != null)
                    hashCode = hashCode * 59 + FileId.GetHashCode();
                return hashCode;
            }
        }
    }

}
