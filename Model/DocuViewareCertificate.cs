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
    /// DocuViewareCertificate
    /// </summary>
    [DataContract]
    public partial class DocuViewareCertificate :  IEquatable<DocuViewareCertificate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocuViewareCertificate" /> class.
        /// </summary>
        public DocuViewareCertificate()
        {
        }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="Data")]
        public byte[] Data { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="Password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets TimestampServerURI
        /// </summary>
        [DataMember(Name="TimestampServerURI")]
        public string TimestampServerURI { get; set; }

        /// <summary>
        /// Gets or Sets TimestampServerUserName
        /// </summary>
        [DataMember(Name="TimestampServerUserName")]
        public string TimestampServerUserName { get; set; }

        /// <summary>
        /// Gets or Sets TimestampServerUserPassword
        /// </summary>
        [DataMember(Name="TimestampServerUserPassword")]
        public string TimestampServerUserPassword { get; set; }

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
            return Equals(input as DocuViewareCertificate);
        }

        /// <summary>
        /// Returns true if DocuViewareCertificate instances are equal
        /// </summary>
        /// <param name="input">Instance of DocuViewareCertificate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocuViewareCertificate input)
        {
            if (input == null)
                return false;

            return 
                (
                    DisplayName == input.DisplayName ||
                    (DisplayName != null &&
                    DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    Data == input.Data ||
                    (Data != null &&
                    Data.Equals(input.Data))
                ) && 
                (
                    Password == input.Password ||
                    (Password != null &&
                    Password.Equals(input.Password))
                ) && 
                (
                    TimestampServerURI == input.TimestampServerURI ||
                    (TimestampServerURI != null &&
                    TimestampServerURI.Equals(input.TimestampServerURI))
                ) && 
                (
                    TimestampServerUserName == input.TimestampServerUserName ||
                    (TimestampServerUserName != null &&
                    TimestampServerUserName.Equals(input.TimestampServerUserName))
                ) && 
                (
                    TimestampServerUserPassword == input.TimestampServerUserPassword ||
                    (TimestampServerUserPassword != null &&
                    TimestampServerUserPassword.Equals(input.TimestampServerUserPassword))
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
                if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
                if (Data != null)
                    hashCode = hashCode * 59 + Data.GetHashCode();
                if (Password != null)
                    hashCode = hashCode * 59 + Password.GetHashCode();
                if (TimestampServerURI != null)
                    hashCode = hashCode * 59 + TimestampServerURI.GetHashCode();
                if (TimestampServerUserName != null)
                    hashCode = hashCode * 59 + TimestampServerUserName.GetHashCode();
                if (TimestampServerUserPassword != null)
                    hashCode = hashCode * 59 + TimestampServerUserPassword.GetHashCode();
                return hashCode;
            }
        }
    }

}
