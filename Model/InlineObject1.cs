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
    /// InlineObject1
    /// </summary>
    [DataContract]
    public partial class InlineObject1 :  IEquatable<InlineObject1>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject1() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject1" /> class.
        /// </summary>
        /// <param name="fileData">The data of the document. (required).</param>
        public InlineObject1(System.IO.Stream fileData)
        {
            fileData = fileData;
        }

        /// <summary>
        /// The data of the document.
        /// </summary>
        [DataMember(Name="fileData")]
        public System.IO.Stream fileData { get; set; }

        /// <summary>
        /// Gets or Sets loadDocumentParameters
        /// </summary>
        [DataMember(Name="loadDocumentParameters")]
        public PdfLoadDocumentParameters loadDocumentParameters { get; set; }

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
            return Equals(input as InlineObject1);
        }

        /// <summary>
        /// Returns true if InlineObject1 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject1 input)
        {
            if (input == null)
                return false;

            return 
                (
                    fileData == input.fileData ||
                    (fileData != null &&
                    fileData.Equals(input.fileData))
                ) && 
                (
                    loadDocumentParameters == input.loadDocumentParameters ||
                    (loadDocumentParameters != null &&
                    loadDocumentParameters.Equals(input.loadDocumentParameters))
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
                if (fileData != null)
                    hashCode = hashCode * 59 + fileData.GetHashCode();
                if (loadDocumentParameters != null)
                    hashCode = hashCode * 59 + loadDocumentParameters.GetHashCode();
                return hashCode;
            }
        }
    }

}
