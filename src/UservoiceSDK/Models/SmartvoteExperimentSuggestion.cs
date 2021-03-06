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
    /// SmartvoteExperimentSuggestion
    /// </summary>
    [DataContract]
    public partial class SmartvoteExperimentSuggestion :  IEquatable<SmartvoteExperimentSuggestion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmartvoteExperimentSuggestion" /> class.
        /// </summary>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="Deviation">Deviation.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Links">Links.</param>
        /// <param name="Losses">Losses.</param>
        /// <param name="Rank">Rank.</param>
        /// <param name="RankIsConfident">RankIsConfident.</param>
        /// <param name="Rating">Rating.</param>
        /// <param name="UpdatedAt">UpdatedAt.</param>
        /// <param name="Wins">Wins.</param>
        public SmartvoteExperimentSuggestion(DateTime? CreatedAt = null, long? Deviation = null, long? Id = null, SmartvoteExperimentSuggestionLinks Links = null, long? Losses = null, long? Rank = null, bool? RankIsConfident = null, long? Rating = null, DateTime? UpdatedAt = null, long? Wins = null)
        {
            this.CreatedAt = CreatedAt;
            this.Deviation = Deviation;
            this.Id = Id;
            this.Links = Links;
            this.Losses = Losses;
            this.Rank = Rank;
            this.RankIsConfident = RankIsConfident;
            this.Rating = Rating;
            this.UpdatedAt = UpdatedAt;
            this.Wins = Wins;
        }
        
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }
        /// <summary>
        /// Gets or Sets Deviation
        /// </summary>
        [DataMember(Name="deviation", EmitDefaultValue=false)]
        public long? Deviation { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public SmartvoteExperimentSuggestionLinks Links { get; set; }
        /// <summary>
        /// Gets or Sets Losses
        /// </summary>
        [DataMember(Name="losses", EmitDefaultValue=false)]
        public long? Losses { get; set; }
        /// <summary>
        /// Gets or Sets Rank
        /// </summary>
        [DataMember(Name="rank", EmitDefaultValue=false)]
        public long? Rank { get; set; }
        /// <summary>
        /// Gets or Sets RankIsConfident
        /// </summary>
        [DataMember(Name="rank_is_confident", EmitDefaultValue=false)]
        public bool? RankIsConfident { get; set; }
        /// <summary>
        /// Gets or Sets Rating
        /// </summary>
        [DataMember(Name="rating", EmitDefaultValue=false)]
        public long? Rating { get; set; }
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }
        /// <summary>
        /// Gets or Sets Wins
        /// </summary>
        [DataMember(Name="wins", EmitDefaultValue=false)]
        public long? Wins { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartvoteExperimentSuggestion {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Deviation: ").Append(Deviation).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Losses: ").Append(Losses).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  RankIsConfident: ").Append(RankIsConfident).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Wins: ").Append(Wins).Append("\n");
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
            return this.Equals(obj as SmartvoteExperimentSuggestion);
        }

        /// <summary>
        /// Returns true if SmartvoteExperimentSuggestion instances are equal
        /// </summary>
        /// <param name="other">Instance of SmartvoteExperimentSuggestion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmartvoteExperimentSuggestion other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.Deviation == other.Deviation ||
                    this.Deviation != null &&
                    this.Deviation.Equals(other.Deviation)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.Losses == other.Losses ||
                    this.Losses != null &&
                    this.Losses.Equals(other.Losses)
                ) && 
                (
                    this.Rank == other.Rank ||
                    this.Rank != null &&
                    this.Rank.Equals(other.Rank)
                ) && 
                (
                    this.RankIsConfident == other.RankIsConfident ||
                    this.RankIsConfident != null &&
                    this.RankIsConfident.Equals(other.RankIsConfident)
                ) && 
                (
                    this.Rating == other.Rating ||
                    this.Rating != null &&
                    this.Rating.Equals(other.Rating)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    this.Wins == other.Wins ||
                    this.Wins != null &&
                    this.Wins.Equals(other.Wins)
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
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.Deviation != null)
                    hash = hash * 59 + this.Deviation.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.Losses != null)
                    hash = hash * 59 + this.Losses.GetHashCode();
                if (this.Rank != null)
                    hash = hash * 59 + this.Rank.GetHashCode();
                if (this.RankIsConfident != null)
                    hash = hash * 59 + this.RankIsConfident.GetHashCode();
                if (this.Rating != null)
                    hash = hash * 59 + this.Rating.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                if (this.Wins != null)
                    hash = hash * 59 + this.Wins.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
