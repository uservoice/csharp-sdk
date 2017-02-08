/* 
 * UserVoice API
 *
 * A RESTful API to interface with UserVoice's feedback system. Online documentation available here: https://developer.uservoice.com/docs/api/v2/reference/.
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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

namespace UserVoiceSdk.Models
{
    /// <summary>
    /// FeedbackRanking
    /// </summary>
    [DataContract]
    public partial class FeedbackRanking :  IEquatable<FeedbackRanking>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackRanking" /> class.
        /// </summary>
        /// <param name="CountDelta">CountDelta.</param>
        /// <param name="CountLifetime">CountLifetime.</param>
        /// <param name="CountPeriod1">CountPeriod1.</param>
        /// <param name="CountPeriod2">CountPeriod2.</param>
        /// <param name="Links">Links.</param>
        /// <param name="RankDelta">RankDelta.</param>
        /// <param name="RankPeriod1">RankPeriod1.</param>
        /// <param name="RankPeriod2">RankPeriod2.</param>
        public FeedbackRanking(long? CountDelta = null, long? CountLifetime = null, long? CountPeriod1 = null, long? CountPeriod2 = null, FeedbackRankingLinks Links = null, long? RankDelta = null, long? RankPeriod1 = null, long? RankPeriod2 = null)
        {
            this.CountDelta = CountDelta;
            this.CountLifetime = CountLifetime;
            this.CountPeriod1 = CountPeriod1;
            this.CountPeriod2 = CountPeriod2;
            this.Links = Links;
            this.RankDelta = RankDelta;
            this.RankPeriod1 = RankPeriod1;
            this.RankPeriod2 = RankPeriod2;
        }
        
        /// <summary>
        /// Gets or Sets CountDelta
        /// </summary>
        [DataMember(Name="count_delta", EmitDefaultValue=false)]
        public long? CountDelta { get; set; }
        /// <summary>
        /// Gets or Sets CountLifetime
        /// </summary>
        [DataMember(Name="count_lifetime", EmitDefaultValue=false)]
        public long? CountLifetime { get; set; }
        /// <summary>
        /// Gets or Sets CountPeriod1
        /// </summary>
        [DataMember(Name="count_period1", EmitDefaultValue=false)]
        public long? CountPeriod1 { get; set; }
        /// <summary>
        /// Gets or Sets CountPeriod2
        /// </summary>
        [DataMember(Name="count_period2", EmitDefaultValue=false)]
        public long? CountPeriod2 { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public FeedbackRankingLinks Links { get; set; }
        /// <summary>
        /// Gets or Sets RankDelta
        /// </summary>
        [DataMember(Name="rank_delta", EmitDefaultValue=false)]
        public long? RankDelta { get; set; }
        /// <summary>
        /// Gets or Sets RankPeriod1
        /// </summary>
        [DataMember(Name="rank_period1", EmitDefaultValue=false)]
        public long? RankPeriod1 { get; set; }
        /// <summary>
        /// Gets or Sets RankPeriod2
        /// </summary>
        [DataMember(Name="rank_period2", EmitDefaultValue=false)]
        public long? RankPeriod2 { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeedbackRanking {\n");
            sb.Append("  CountDelta: ").Append(CountDelta).Append("\n");
            sb.Append("  CountLifetime: ").Append(CountLifetime).Append("\n");
            sb.Append("  CountPeriod1: ").Append(CountPeriod1).Append("\n");
            sb.Append("  CountPeriod2: ").Append(CountPeriod2).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  RankDelta: ").Append(RankDelta).Append("\n");
            sb.Append("  RankPeriod1: ").Append(RankPeriod1).Append("\n");
            sb.Append("  RankPeriod2: ").Append(RankPeriod2).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as FeedbackRanking);
        }

        /// <summary>
        /// Returns true if FeedbackRanking instances are equal
        /// </summary>
        /// <param name="other">Instance of FeedbackRanking to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeedbackRanking other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CountDelta == other.CountDelta ||
                    this.CountDelta != null &&
                    this.CountDelta.Equals(other.CountDelta)
                ) && 
                (
                    this.CountLifetime == other.CountLifetime ||
                    this.CountLifetime != null &&
                    this.CountLifetime.Equals(other.CountLifetime)
                ) && 
                (
                    this.CountPeriod1 == other.CountPeriod1 ||
                    this.CountPeriod1 != null &&
                    this.CountPeriod1.Equals(other.CountPeriod1)
                ) && 
                (
                    this.CountPeriod2 == other.CountPeriod2 ||
                    this.CountPeriod2 != null &&
                    this.CountPeriod2.Equals(other.CountPeriod2)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.RankDelta == other.RankDelta ||
                    this.RankDelta != null &&
                    this.RankDelta.Equals(other.RankDelta)
                ) && 
                (
                    this.RankPeriod1 == other.RankPeriod1 ||
                    this.RankPeriod1 != null &&
                    this.RankPeriod1.Equals(other.RankPeriod1)
                ) && 
                (
                    this.RankPeriod2 == other.RankPeriod2 ||
                    this.RankPeriod2 != null &&
                    this.RankPeriod2.Equals(other.RankPeriod2)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.CountDelta != null)
                    hash = hash * 59 + this.CountDelta.GetHashCode();
                if (this.CountLifetime != null)
                    hash = hash * 59 + this.CountLifetime.GetHashCode();
                if (this.CountPeriod1 != null)
                    hash = hash * 59 + this.CountPeriod1.GetHashCode();
                if (this.CountPeriod2 != null)
                    hash = hash * 59 + this.CountPeriod2.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.RankDelta != null)
                    hash = hash * 59 + this.RankDelta.GetHashCode();
                if (this.RankPeriod1 != null)
                    hash = hash * 59 + this.RankPeriod1.GetHashCode();
                if (this.RankPeriod2 != null)
                    hash = hash * 59 + this.RankPeriod2.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}