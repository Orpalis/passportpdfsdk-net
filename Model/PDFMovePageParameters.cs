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
    /// Represents the parameters for a move pages action.
    /// </summary>
    [DataContract]
    public partial class PdfMovePageParameters :  IEquatable<PdfMovePageParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfMovePageParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PdfMovePageParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfMovePageParameters" /> class.
        /// </summary>
        /// <param name="fileId">The identifier of the previously uploaded file to be processed. (required).</param>
        /// <param name="sourcePageRange">Specifies the number of the page, or the range of pages to be moved. (required).</param>
        /// <param name="destinationPage">Specifies the number of the destination page. (required).</param>
        public PdfMovePageParameters(string fileId, string sourcePageRange, int destinationPage)
        {
            FileId = fileId;
            SourcePageRange = sourcePageRange;
            DestinationPage = destinationPage;
        }

        /// <summary>
        /// The identifier of the previously uploaded file to be processed.
        /// </summary>
        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies the number of the page, or the range of pages to be moved.
        /// </summary>
        [DataMember(Name="SourcePageRange")]
        public string SourcePageRange { get; set; }

        /// <summary>
        /// Specifies the number of the destination page.
        /// </summary>
        [DataMember(Name="DestinationPage")]
        public int DestinationPage { get; set; }

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
            return Equals(input as PdfMovePageParameters);
        }

        /// <summary>
        /// Returns true if PdfMovePageParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfMovePageParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfMovePageParameters input)
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
                    SourcePageRange == input.SourcePageRange ||
                    (SourcePageRange != null &&
                    SourcePageRange.Equals(input.SourcePageRange))
                ) && 
                (
                    DestinationPage == input.DestinationPage ||
                    DestinationPage.Equals(input.DestinationPage)
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
                if (SourcePageRange != null)
                    hashCode = hashCode * 59 + SourcePageRange.GetHashCode();
                hashCode = hashCode * 59 + DestinationPage.GetHashCode();
                return hashCode;
            }
        }
    }

}
