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
    /// SmartvoteExperiment
    /// </summary>
    [DataContract]
    public partial class SmartvoteExperiment :  IEquatable<SmartvoteExperiment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmartvoteExperiment" /> class.
        /// </summary>
        /// <param name="Comparisons">Comparisons.</param>
        /// <param name="CompletedAt">CompletedAt.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="GroupsCount">GroupsCount.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Links">Links.</param>
        /// <param name="Name">Name.</param>
        /// <param name="PublicUrl">PublicUrl.</param>
        /// <param name="State">State.</param>
        /// <param name="SuggestionListModifiedAt">SuggestionListModifiedAt.</param>
        /// <param name="SuggestionsCount">SuggestionsCount.</param>
        /// <param name="UpdatedAt">UpdatedAt.</param>
        /// <param name="UsersCount">UsersCount.</param>
        public SmartvoteExperiment(long? Comparisons = null, DateTime? CompletedAt = null, DateTime? CreatedAt = null, long? GroupsCount = null, long? Id = null, SmartvoteExperimentLinks Links = null, string Name = null, string PublicUrl = null, string State = null, DateTime? SuggestionListModifiedAt = null, long? SuggestionsCount = null, DateTime? UpdatedAt = null, long? UsersCount = null)
        {
            this.Comparisons = Comparisons;
            this.CompletedAt = CompletedAt;
            this.CreatedAt = CreatedAt;
            this.GroupsCount = GroupsCount;
            this.Id = Id;
            this.Links = Links;
            this.Name = Name;
            this.PublicUrl = PublicUrl;
            this.State = State;
            this.SuggestionListModifiedAt = SuggestionListModifiedAt;
            this.SuggestionsCount = SuggestionsCount;
            this.UpdatedAt = UpdatedAt;
            this.UsersCount = UsersCount;
        }
        
        /// <summary>
        /// Gets or Sets Comparisons
        /// </summary>
        [DataMember(Name="comparisons", EmitDefaultValue=false)]
        public long? Comparisons { get; set; }
        /// <summary>
        /// Gets or Sets CompletedAt
        /// </summary>
        [DataMember(Name="completed_at", EmitDefaultValue=false)]
        public DateTime? CompletedAt { get; set; }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }
        /// <summary>
        /// Gets or Sets GroupsCount
        /// </summary>
        [DataMember(Name="groups_count", EmitDefaultValue=false)]
        public long? GroupsCount { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public SmartvoteExperimentLinks Links { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets PublicUrl
        /// </summary>
        [DataMember(Name="public_url", EmitDefaultValue=false)]
        public string PublicUrl { get; set; }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
        /// <summary>
        /// Gets or Sets SuggestionListModifiedAt
        /// </summary>
        [DataMember(Name="suggestion_list_modified_at", EmitDefaultValue=false)]
        public DateTime? SuggestionListModifiedAt { get; set; }
        /// <summary>
        /// Gets or Sets SuggestionsCount
        /// </summary>
        [DataMember(Name="suggestions_count", EmitDefaultValue=false)]
        public long? SuggestionsCount { get; set; }
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }
        /// <summary>
        /// Gets or Sets UsersCount
        /// </summary>
        [DataMember(Name="users_count", EmitDefaultValue=false)]
        public long? UsersCount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartvoteExperiment {\n");
            sb.Append("  Comparisons: ").Append(Comparisons).Append("\n");
            sb.Append("  CompletedAt: ").Append(CompletedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  GroupsCount: ").Append(GroupsCount).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PublicUrl: ").Append(PublicUrl).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  SuggestionListModifiedAt: ").Append(SuggestionListModifiedAt).Append("\n");
            sb.Append("  SuggestionsCount: ").Append(SuggestionsCount).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  UsersCount: ").Append(UsersCount).Append("\n");
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
            return this.Equals(obj as SmartvoteExperiment);
        }

        /// <summary>
        /// Returns true if SmartvoteExperiment instances are equal
        /// </summary>
        /// <param name="other">Instance of SmartvoteExperiment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmartvoteExperiment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Comparisons == other.Comparisons ||
                    this.Comparisons != null &&
                    this.Comparisons.Equals(other.Comparisons)
                ) && 
                (
                    this.CompletedAt == other.CompletedAt ||
                    this.CompletedAt != null &&
                    this.CompletedAt.Equals(other.CompletedAt)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.GroupsCount == other.GroupsCount ||
                    this.GroupsCount != null &&
                    this.GroupsCount.Equals(other.GroupsCount)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PublicUrl == other.PublicUrl ||
                    this.PublicUrl != null &&
                    this.PublicUrl.Equals(other.PublicUrl)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.SuggestionListModifiedAt == other.SuggestionListModifiedAt ||
                    this.SuggestionListModifiedAt != null &&
                    this.SuggestionListModifiedAt.Equals(other.SuggestionListModifiedAt)
                ) && 
                (
                    this.SuggestionsCount == other.SuggestionsCount ||
                    this.SuggestionsCount != null &&
                    this.SuggestionsCount.Equals(other.SuggestionsCount)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    this.UsersCount == other.UsersCount ||
                    this.UsersCount != null &&
                    this.UsersCount.Equals(other.UsersCount)
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
                if (this.Comparisons != null)
                    hash = hash * 59 + this.Comparisons.GetHashCode();
                if (this.CompletedAt != null)
                    hash = hash * 59 + this.CompletedAt.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.GroupsCount != null)
                    hash = hash * 59 + this.GroupsCount.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.PublicUrl != null)
                    hash = hash * 59 + this.PublicUrl.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.SuggestionListModifiedAt != null)
                    hash = hash * 59 + this.SuggestionListModifiedAt.GetHashCode();
                if (this.SuggestionsCount != null)
                    hash = hash * 59 + this.SuggestionsCount.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                if (this.UsersCount != null)
                    hash = hash * 59 + this.UsersCount.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
