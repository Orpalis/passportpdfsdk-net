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
    /// Represents the parameters for a GetControl action.
    /// </summary>
    [DataContract]
    public partial class DocuViewareGetControlParameters :  IEquatable<DocuViewareGetControlParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocuViewareGetControlParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocuViewareGetControlParameters() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocuViewareGetControlParameters" /> class.
        /// </summary>
        /// <param name="sessionID">Specifies the unique identifier used to identify the user session. (required).</param>
        /// <param name="controlState">controlState (required).</param>
        public DocuViewareGetControlParameters(string sessionID, DocuViewareControlState controlState)
        {
            SessionID = sessionID;
            ControlState = controlState;
        }

        /// <summary>
        /// Specifies the unique identifier used to identify the user session.
        /// </summary>
        [DataMember(Name="SessionID")]
        public string SessionID { get; set; }

        /// <summary>
        /// Gets or Sets ControlState
        /// </summary>
        [DataMember(Name="ControlState")]
        public DocuViewareControlState ControlState { get; set; }

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
            return Equals(input as DocuViewareGetControlParameters);
        }

        /// <summary>
        /// Returns true if DocuViewareGetControlParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of DocuViewareGetControlParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocuViewareGetControlParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    SessionID == input.SessionID ||
                    (SessionID != null &&
                    SessionID.Equals(input.SessionID))
                ) && 
                (
                    ControlState == input.ControlState ||
                    (ControlState != null &&
                    ControlState.Equals(input.ControlState))
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
                if (SessionID != null)
                    hashCode = hashCode * 59 + SessionID.GetHashCode();
                if (ControlState != null)
                    hashCode = hashCode * 59 + ControlState.GetHashCode();
                return hashCode;
            }
        }
    }

}
