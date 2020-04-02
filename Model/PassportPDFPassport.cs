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
    /// PassportPDFPassport
    /// </summary>
    [DataContract]
    public partial class PassportPDFPassport :  IEquatable<PassportPDFPassport>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PassportPDFPassport" /> class.
        /// </summary>
        public PassportPDFPassport()
        {
        }

        /// <summary>
        /// Gets or Sets PassportId
        /// </summary>
        [DataMember(Name="PassportId")]
        public string PassportId { get; set; }

        /// <summary>
        /// Gets or Sets PlanId
        /// </summary>
        [DataMember(Name="PlanId")]
        public int PlanId { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionDate
        /// </summary>
        [DataMember(Name="SubscriptionDate")]
        public DateTime SubscriptionDate { get; set; }

        /// <summary>
        /// Gets or Sets CurrentTokensUsed
        /// </summary>
        [DataMember(Name="CurrentTokensUsed")]
        public long CurrentTokensUsed { get; set; }

        /// <summary>
        /// Gets or Sets ExtraTokens
        /// </summary>
        [DataMember(Name="ExtraTokens")]
        public long ExtraTokens { get; set; }

        /// <summary>
        /// Gets or Sets ExtraTokensEndDate
        /// </summary>
        [DataMember(Name="ExtraTokensEndDate")]
        public DateTime ExtraTokensEndDate { get; set; }

        /// <summary>
        /// Gets or Sets IsYearlyPaid
        /// </summary>
        [DataMember(Name="IsYearlyPaid")]
        public bool IsYearlyPaid { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="IsActive")]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or Sets TokensPercentUsageAlert
        /// </summary>
        [DataMember(Name="TokensPercentUsageAlert")]
        public int TokensPercentUsageAlert { get; set; }

        /// <summary>
        /// Gets or Sets TokensPercentUsageAlertSent
        /// </summary>
        [DataMember(Name="TokensPercentUsageAlertSent")]
        public bool TokensPercentUsageAlertSent { get; set; }

        /// <summary>
        /// Gets or Sets NextMonthlyTerm
        /// </summary>
        [DataMember(Name="NextMonthlyTerm")]
        public DateTime NextMonthlyTerm { get; private set; }

        /// <summary>
        /// Gets or Sets RemainingTokens
        /// </summary>
        [DataMember(Name="RemainingTokens")]
        public long RemainingTokens { get; private set; }

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
            return Equals(input as PassportPDFPassport);
        }

        /// <summary>
        /// Returns true if PassportPDFPassport instances are equal
        /// </summary>
        /// <param name="input">Instance of PassportPDFPassport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PassportPDFPassport input)
        {
            if (input == null)
                return false;

            return 
                (
                    PassportId == input.PassportId ||
                    (PassportId != null &&
                    PassportId.Equals(input.PassportId))
                ) && 
                (
                    PlanId == input.PlanId ||
                    PlanId.Equals(input.PlanId)
                ) && 
                (
                    SubscriptionDate == input.SubscriptionDate ||
                    (SubscriptionDate != null &&
                    SubscriptionDate.Equals(input.SubscriptionDate))
                ) && 
                (
                    CurrentTokensUsed == input.CurrentTokensUsed ||
                    CurrentTokensUsed.Equals(input.CurrentTokensUsed)
                ) && 
                (
                    ExtraTokens == input.ExtraTokens ||
                    ExtraTokens.Equals(input.ExtraTokens)
                ) && 
                (
                    ExtraTokensEndDate == input.ExtraTokensEndDate ||
                    (ExtraTokensEndDate != null &&
                    ExtraTokensEndDate.Equals(input.ExtraTokensEndDate))
                ) && 
                (
                    IsYearlyPaid == input.IsYearlyPaid ||
                    IsYearlyPaid.Equals(input.IsYearlyPaid)
                ) && 
                (
                    IsActive == input.IsActive ||
                    IsActive.Equals(input.IsActive)
                ) && 
                (
                    TokensPercentUsageAlert == input.TokensPercentUsageAlert ||
                    TokensPercentUsageAlert.Equals(input.TokensPercentUsageAlert)
                ) && 
                (
                    TokensPercentUsageAlertSent == input.TokensPercentUsageAlertSent ||
                    TokensPercentUsageAlertSent.Equals(input.TokensPercentUsageAlertSent)
                ) && 
                (
                    NextMonthlyTerm == input.NextMonthlyTerm ||
                    (NextMonthlyTerm != null &&
                    NextMonthlyTerm.Equals(input.NextMonthlyTerm))
                ) && 
                (
                    RemainingTokens == input.RemainingTokens ||
                    RemainingTokens.Equals(input.RemainingTokens)
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
                if (PassportId != null)
                    hashCode = hashCode * 59 + PassportId.GetHashCode();
                hashCode = hashCode * 59 + PlanId.GetHashCode();
                if (SubscriptionDate != null)
                    hashCode = hashCode * 59 + SubscriptionDate.GetHashCode();
                hashCode = hashCode * 59 + CurrentTokensUsed.GetHashCode();
                hashCode = hashCode * 59 + ExtraTokens.GetHashCode();
                if (ExtraTokensEndDate != null)
                    hashCode = hashCode * 59 + ExtraTokensEndDate.GetHashCode();
                hashCode = hashCode * 59 + IsYearlyPaid.GetHashCode();
                hashCode = hashCode * 59 + IsActive.GetHashCode();
                hashCode = hashCode * 59 + TokensPercentUsageAlert.GetHashCode();
                hashCode = hashCode * 59 + TokensPercentUsageAlertSent.GetHashCode();
                if (NextMonthlyTerm != null)
                    hashCode = hashCode * 59 + NextMonthlyTerm.GetHashCode();
                hashCode = hashCode * 59 + RemainingTokens.GetHashCode();
                return hashCode;
            }
        }
    }

}
