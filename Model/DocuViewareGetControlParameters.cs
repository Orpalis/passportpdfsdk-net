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
    /// Represents the parameters for a GetControl action.
    /// </summary>
    [DataContract]
    public partial class DocuViewareGetControlParameters :  IEquatable<DocuViewareGetControlParameters>, IValidatableObject
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
        public DocuViewareGetControlParameters(string sessionID = default(string), DocuViewareControlState controlState = default(DocuViewareControlState))
        {
            // to ensure "sessionID" is required (not null)
            if (sessionID == null)
            {
                throw new InvalidDataException("sessionID is a required property for DocuViewareGetControlParameters and cannot be null");
            }
            else
            {
                this.SessionID = sessionID;
            }
            // to ensure "controlState" is required (not null)
            if (controlState == null)
            {
                throw new InvalidDataException("controlState is a required property for DocuViewareGetControlParameters and cannot be null");
            }
            else
            {
                this.ControlState = controlState;
            }
        }
        
        /// <summary>
        /// Specifies the unique identifier used to identify the user session.
        /// </summary>
        /// <value>Specifies the unique identifier used to identify the user session.</value>
        [DataMember(Name="SessionID", EmitDefaultValue=false)]
        public string SessionID { get; set; }

        /// <summary>
        /// Gets or Sets ControlState
        /// </summary>
        [DataMember(Name="ControlState", EmitDefaultValue=false)]
        public DocuViewareControlState ControlState { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocuViewareGetControlParameters {\n");
            sb.Append("  SessionID: ").Append(SessionID).Append("\n");
            sb.Append("  ControlState: ").Append(ControlState).Append("\n");
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
            return this.Equals(input as DocuViewareGetControlParameters);
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
                    this.SessionID == input.SessionID ||
                    (this.SessionID != null &&
                    this.SessionID.Equals(input.SessionID))
                ) && 
                (
                    this.ControlState == input.ControlState ||
                    (this.ControlState != null &&
                    this.ControlState.Equals(input.ControlState))
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
                if (this.SessionID != null)
                    hashCode = hashCode * 59 + this.SessionID.GetHashCode();
                if (this.ControlState != null)
                    hashCode = hashCode * 59 + this.ControlState.GetHashCode();
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
