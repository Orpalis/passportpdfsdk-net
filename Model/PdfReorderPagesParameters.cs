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
    /// Represents the parameters for a reorder pages action.
    /// </summary>
    [DataContract]
    public partial class PdfReorderPagesParameters :  IEquatable<PdfReorderPagesParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfReorderPagesParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfReorderPagesParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfReorderPagesParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="pageOrder">Specifies the new pages order. Must contains page numbers separated by ';' or ','.  Example for a 6-pages document: \"1;2;4;3;6;5\". (required).</param>
        public PdfReorderPagesParameters(string fileId, string pageOrder)
        {
            FileId = fileId;
            PageOrder = pageOrder;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the new pages order. Must contains page numbers separated by ';' or ','.  Example for a 6-pages document: \"1;2;4;3;6;5\".
        /// </summary>
        [DataMember(Name="PageOrder")]
        public string PageOrder { get; set; }

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
            return Equals(input as PdfReorderPagesParameters);
        }

        /// <summary>
        /// Returns true if PdfReorderPagesParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfReorderPagesParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfReorderPagesParameters input)
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
                    PageOrder == input.PageOrder ||
                    (PageOrder != null &&
                    PageOrder.Equals(input.PageOrder))
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
                if (PageOrder != null)
                    hashCode = hashCode * 59 + PageOrder.GetHashCode();
                return hashCode;
            }
        }
    }

}
