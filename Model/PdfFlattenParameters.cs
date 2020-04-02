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
    /// Represents the parameters for a flatten action.
    /// </summary>
    [DataContract]
    public partial class PdfFlattenParameters :  IEquatable<PdfFlattenParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfFlattenParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfFlattenParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfFlattenParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        public PdfFlattenParameters(string fileId)
        {
            FileId = fileId;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies whether the annotations shall be flattened.
        /// </summary>
        [DataMember(Name="FlattenAnnotations")]
        public bool FlattenAnnotations { get; set; } = false;

        /// <summary>
        /// Specifies whether the form-fields shall be flattened.
        /// </summary>
        [DataMember(Name="FlattenFormFields")]
        public bool FlattenFormFields { get; set; } = false;

        /// <summary>
        /// Specifies whether the layers shall be flattened.
        /// </summary>
        [DataMember(Name="FlattenLayers")]
        public bool FlattenLayers { get; set; } = false;

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
            return Equals(input as PdfFlattenParameters);
        }

        /// <summary>
        /// Returns true if PdfFlattenParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfFlattenParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfFlattenParameters input)
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
                    FlattenAnnotations == input.FlattenAnnotations ||
                    FlattenAnnotations.Equals(input.FlattenAnnotations)
                ) && 
                (
                    FlattenFormFields == input.FlattenFormFields ||
                    FlattenFormFields.Equals(input.FlattenFormFields)
                ) && 
                (
                    FlattenLayers == input.FlattenLayers ||
                    FlattenLayers.Equals(input.FlattenLayers)
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
                hashCode = hashCode * 59 + FlattenAnnotations.GetHashCode();
                hashCode = hashCode * 59 + FlattenFormFields.GetHashCode();
                hashCode = hashCode * 59 + FlattenLayers.GetHashCode();
                return hashCode;
            }
        }
    }

}
