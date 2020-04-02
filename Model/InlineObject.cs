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
    /// InlineObject
    /// </summary>
    [DataContract]
    public partial class InlineObject :  IEquatable<InlineObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject" /> class.
        /// </summary>
        /// <param name="fileData">The data of the document. (required).</param>
        public InlineObject(System.IO.Stream fileData)
        {
            fileData = fileData;
        }

        /// <summary>
        /// The data of the document.
        /// </summary>
        [DataMember(Name="fileData")]
        public System.IO.Stream fileData { get; set; }

        /// <summary>
        /// Gets or Sets loadImageParameters
        /// </summary>
        [DataMember(Name="loadImageParameters")]
        public LoadImageParameters loadImageParameters { get; set; }

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
            return Equals(input as InlineObject);
        }

        /// <summary>
        /// Returns true if InlineObject instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject input)
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
                    loadImageParameters == input.loadImageParameters ||
                    (loadImageParameters != null &&
                    loadImageParameters.Equals(input.loadImageParameters))
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
                if (loadImageParameters != null)
                    hashCode = hashCode * 59 + loadImageParameters.GetHashCode();
                return hashCode;
            }
        }
    }

}
