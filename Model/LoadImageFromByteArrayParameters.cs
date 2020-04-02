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
    /// Represents the parameters for an image loading request.
    /// </summary>
    [DataContract]
    public partial class LoadImageFromByteArrayParameters :  IEquatable<LoadImageFromByteArrayParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoadImageFromByteArrayParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LoadImageFromByteArrayParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadImageFromByteArrayParameters" /> class.
        /// </summary>
        /// <param name="content">Specifies the data of the image. (required).</param>
        public LoadImageFromByteArrayParameters(byte[] content)
        {
            Content = content;
        }

        /// <summary>
        /// Specifies the data of the image.
        /// </summary>
        [DataMember(Name="Content")]
        public byte[] Content { get; set; }

        /// <summary>
        /// Specifies the name of the document.
        /// </summary>
        [DataMember(Name="FileName")]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or Sets ContentEncoding
        /// </summary>
        [DataMember(Name="ContentEncoding")]
        public ContentEncoding ContentEncoding { get; set; }

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
            return Equals(input as LoadImageFromByteArrayParameters);
        }

        /// <summary>
        /// Returns true if LoadImageFromByteArrayParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of LoadImageFromByteArrayParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoadImageFromByteArrayParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    Content == input.Content ||
                    (Content != null &&
                    Content.Equals(input.Content))
                ) && 
                (
                    FileName == input.FileName ||
                    (FileName != null &&
                    FileName.Equals(input.FileName))
                ) && 
                (
                    ContentEncoding == input.ContentEncoding ||
                    ContentEncoding.Equals(input.ContentEncoding)
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
                if (Content != null)
                    hashCode = hashCode * 59 + Content.GetHashCode();
                if (FileName != null)
                    hashCode = hashCode * 59 + FileName.GetHashCode();
                hashCode = hashCode * 59 + ContentEncoding.GetHashCode();
                return hashCode;
            }
        }
    }

}
