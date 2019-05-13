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
    /// Represents the parameters for a load document action request.
    /// </summary>
    [DataContract]
    public partial class PDFLoadDocumentFromByteArrayParameters :  IEquatable<PDFLoadDocumentFromByteArrayParameters>, IValidatableObject
    {
        /// <summary>
        /// Specifies the level of PDF conformance to be used for converting the input document as PDF.  If the input document is a PDF its conformance is not changed.
        /// </summary>
        /// <value>Specifies the level of PDF conformance to be used for converting the input document as PDF.  If the input document is a PDF its conformance is not changed.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConformanceEnum
        {
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,

            /// <summary>
            /// Enum PDF10 for value: PDF1_0
            /// </summary>
            [EnumMember(Value = "PDF1_0")]
            PDF10 = 2,

            /// <summary>
            /// Enum PDF11 for value: PDF1_1
            /// </summary>
            [EnumMember(Value = "PDF1_1")]
            PDF11 = 3,

            /// <summary>
            /// Enum PDF12 for value: PDF1_2
            /// </summary>
            [EnumMember(Value = "PDF1_2")]
            PDF12 = 4,

            /// <summary>
            /// Enum PDF13 for value: PDF1_3
            /// </summary>
            [EnumMember(Value = "PDF1_3")]
            PDF13 = 5,

            /// <summary>
            /// Enum PDF14 for value: PDF1_4
            /// </summary>
            [EnumMember(Value = "PDF1_4")]
            PDF14 = 6,

            /// <summary>
            /// Enum PDF15 for value: PDF1_5
            /// </summary>
            [EnumMember(Value = "PDF1_5")]
            PDF15 = 7,

            /// <summary>
            /// Enum PDF16 for value: PDF1_6
            /// </summary>
            [EnumMember(Value = "PDF1_6")]
            PDF16 = 8,

            /// <summary>
            /// Enum PDF17 for value: PDF1_7
            /// </summary>
            [EnumMember(Value = "PDF1_7")]
            PDF17 = 9,

            /// <summary>
            /// Enum PDF20 for value: PDF2_0
            /// </summary>
            [EnumMember(Value = "PDF2_0")]
            PDF20 = 10,

            /// <summary>
            /// Enum PDFA1a for value: PDF_A_1a
            /// </summary>
            [EnumMember(Value = "PDF_A_1a")]
            PDFA1a = 11,

            /// <summary>
            /// Enum PDFA1b for value: PDF_A_1b
            /// </summary>
            [EnumMember(Value = "PDF_A_1b")]
            PDFA1b = 12,

            /// <summary>
            /// Enum PDFA2a for value: PDF_A_2a
            /// </summary>
            [EnumMember(Value = "PDF_A_2a")]
            PDFA2a = 13,

            /// <summary>
            /// Enum PDFA2u for value: PDF_A_2u
            /// </summary>
            [EnumMember(Value = "PDF_A_2u")]
            PDFA2u = 14,

            /// <summary>
            /// Enum PDFA2b for value: PDF_A_2b
            /// </summary>
            [EnumMember(Value = "PDF_A_2b")]
            PDFA2b = 15,

            /// <summary>
            /// Enum PDFA3a for value: PDF_A_3a
            /// </summary>
            [EnumMember(Value = "PDF_A_3a")]
            PDFA3a = 16,

            /// <summary>
            /// Enum PDFA3u for value: PDF_A_3u
            /// </summary>
            [EnumMember(Value = "PDF_A_3u")]
            PDFA3u = 17,

            /// <summary>
            /// Enum PDFA3b for value: PDF_A_3b
            /// </summary>
            [EnumMember(Value = "PDF_A_3b")]
            PDFA3b = 18,

            /// <summary>
            /// Enum PDFUA1 for value: PDF_UA_1
            /// </summary>
            [EnumMember(Value = "PDF_UA_1")]
            PDFUA1 = 19

        }

        /// <summary>
        /// Specifies the level of PDF conformance to be used for converting the input document as PDF.  If the input document is a PDF its conformance is not changed.
        /// </summary>
        /// <value>Specifies the level of PDF conformance to be used for converting the input document as PDF.  If the input document is a PDF its conformance is not changed.</value>
        [DataMember(Name="Conformance", EmitDefaultValue=false)]
        public ConformanceEnum? Conformance { get; set; }
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
        /// Initializes a new instance of the <see cref="PDFLoadDocumentFromByteArrayParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PDFLoadDocumentFromByteArrayParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFLoadDocumentFromByteArrayParameters" /> class.
        /// </summary>
        /// <param name="content">Specifies the data of the document. (required).</param>
        /// <param name="fileName">Specifies the name of the document..</param>
        /// <param name="password">Specifies the password of the document..</param>
        /// <param name="conformance">Specifies the level of PDF conformance to be used for converting the input document as PDF.  If the input document is a PDF its conformance is not changed. (default to ConformanceEnum.PDF15).</param>
        /// <param name="contentEncoding">Specifies the encoding of the document data. (default to ContentEncodingEnum.Identity).</param>
        public PDFLoadDocumentFromByteArrayParameters(byte[] content = default(byte[]), string fileName = default(string), string password = default(string), ConformanceEnum? conformance = ConformanceEnum.PDF15, ContentEncodingEnum? contentEncoding = ContentEncodingEnum.Identity)
        {
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new InvalidDataException("content is a required property for PDFLoadDocumentFromByteArrayParameters and cannot be null");
            }
            else
            {
                this.Content = content;
            }
            
            this.FileName = fileName;
            this.Password = password;
            // use default value if no "conformance" provided
            if (conformance == null)
            {
                this.Conformance = ConformanceEnum.PDF15;
            }
            else
            {
                this.Conformance = conformance;
            }
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
        /// Specifies the data of the document.
        /// </summary>
        /// <value>Specifies the data of the document.</value>
        [DataMember(Name="Content", EmitDefaultValue=false)]
        public byte[] Content { get; set; }

        /// <summary>
        /// Specifies the name of the document.
        /// </summary>
        /// <value>Specifies the name of the document.</value>
        [DataMember(Name="FileName", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// Specifies the password of the document.
        /// </summary>
        /// <value>Specifies the password of the document.</value>
        [DataMember(Name="Password", EmitDefaultValue=false)]
        public string Password { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PDFLoadDocumentFromByteArrayParameters {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Conformance: ").Append(Conformance).Append("\n");
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
            return this.Equals(input as PDFLoadDocumentFromByteArrayParameters);
        }

        /// <summary>
        /// Returns true if PDFLoadDocumentFromByteArrayParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PDFLoadDocumentFromByteArrayParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PDFLoadDocumentFromByteArrayParameters input)
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
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Conformance == input.Conformance ||
                    (this.Conformance != null &&
                    this.Conformance.Equals(input.Conformance))
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
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Conformance != null)
                    hashCode = hashCode * 59 + this.Conformance.GetHashCode();
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
