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
    /// Represents the parameters for an image loading request.
    /// </summary>
    [DataContract]
    public partial class LoadImageFromByteArrayParameters :  IEquatable<LoadImageFromByteArrayParameters>, IValidatableObject
    {
        /// <summary>
        /// Specifies the encoding of the document data.
        /// </summary>
        /// <value>Specifies the encoding of the document data.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ContentEncodingEnum
        {
            /// <summary>
            /// Enum Identity for value: Identity
            /// </summary>
            [EnumMember(Value = "Identity")]
            Identity = 1,

            /// <summary>
            /// Enum Gzip for value: Gzip
            /// </summary>
            [EnumMember(Value = "Gzip")]
            Gzip = 2

        }

        /// <summary>
        /// Specifies the encoding of the document data.
        /// </summary>
        /// <value>Specifies the encoding of the document data.</value>
        [DataMember(Name="ContentEncoding", EmitDefaultValue=false)]
        public ContentEncodingEnum? ContentEncoding { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoadImageFromByteArrayParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LoadImageFromByteArrayParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoadImageFromByteArrayParameters" /> class.
        /// </summary>
        /// <param name="content">Specifies the data of the image. (required).</param>
        /// <param name="fileName">Specifies the name of the document..</param>
        /// <param name="contentEncoding">Specifies the encoding of the document data. (default to ContentEncodingEnum.Identity).</param>
        public LoadImageFromByteArrayParameters(byte[] content = default(byte[]), string fileName = default(string), ContentEncodingEnum? contentEncoding = ContentEncodingEnum.Identity)
        {
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new InvalidDataException("content is a required property for LoadImageFromByteArrayParameters and cannot be null");
            }
            else
            {
                this.Content = content;
            }
            this.FileName = fileName;
            // use default value if no "contentEncoding" provided
            if (contentEncoding == null)
            {
                this.ContentEncoding = ContentEncodingEnum.Identity;
            }
            else
            {
                this.ContentEncoding = contentEncoding;
            }
        }
        
        /// <summary>
        /// Specifies the data of the image.
        /// </summary>
        /// <value>Specifies the data of the image.</value>
        [DataMember(Name="Content", EmitDefaultValue=false)]
        public byte[] Content { get; set; }

        /// <summary>
        /// Specifies the name of the document.
        /// </summary>
        /// <value>Specifies the name of the document.</value>
        [DataMember(Name="FileName", EmitDefaultValue=false)]
        public string FileName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoadImageFromByteArrayParameters {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  ContentEncoding: ").Append(ContentEncoding).Append("\n");
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
            return this.Equals(input as LoadImageFromByteArrayParameters);
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
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.ContentEncoding == input.ContentEncoding ||
                    (this.ContentEncoding != null &&
                    this.ContentEncoding.Equals(input.ContentEncoding))
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
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.ContentEncoding != null)
                    hashCode = hashCode * 59 + this.ContentEncoding.GetHashCode();
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
