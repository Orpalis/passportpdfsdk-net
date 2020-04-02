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
    /// Contains all the information related to an error which has occured.
    /// </summary>
    [DataContract]
    public partial class Error :  IEquatable<Error>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        public Error()
        {
        }

        /// <summary>
        /// Gets or Sets ResultCode
        /// </summary>
        [DataMember(Name="ResultCode")]
        public PassportPDFStatus ResultCode { get; set; }

        /// <summary>
        /// Specifies a result code related to an error which occured in an external component.
        /// </summary>
        [DataMember(Name="ExtResultStatus")]
        public string ExtResultStatus { get; private set; }

        /// <summary>
        /// Specifies a message which further describes the error.
        /// </summary>
        [DataMember(Name="ExtResultMessage")]
        public string ExtResultMessage { get; set; }

        /// <summary>
        /// Specifies a unique identifier, allowing to easily assess the error.
        /// </summary>
        [DataMember(Name="InternalErrorId")]
        public string InternalErrorId { get; set; }

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
            return Equals(input as Error);
        }

        /// <summary>
        /// Returns true if Error instances are equal
        /// </summary>
        /// <param name="input">Instance of Error to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Error input)
        {
            if (input == null)
                return false;

            return 
                (
                    ResultCode == input.ResultCode ||
                    ResultCode.Equals(input.ResultCode)
                ) && 
                (
                    ExtResultStatus == input.ExtResultStatus ||
                    (ExtResultStatus != null &&
                    ExtResultStatus.Equals(input.ExtResultStatus))
                ) && 
                (
                    ExtResultMessage == input.ExtResultMessage ||
                    (ExtResultMessage != null &&
                    ExtResultMessage.Equals(input.ExtResultMessage))
                ) && 
                (
                    InternalErrorId == input.InternalErrorId ||
                    (InternalErrorId != null &&
                    InternalErrorId.Equals(input.InternalErrorId))
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
                hashCode = hashCode * 59 + ResultCode.GetHashCode();
                if (ExtResultStatus != null)
                    hashCode = hashCode * 59 + ExtResultStatus.GetHashCode();
                if (ExtResultMessage != null)
                    hashCode = hashCode * 59 + ExtResultMessage.GetHashCode();
                if (InternalErrorId != null)
                    hashCode = hashCode * 59 + InternalErrorId.GetHashCode();
                return hashCode;
            }
        }
    }

}
