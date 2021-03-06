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
    /// SuggestionResponse
    /// </summary>
    [DataContract]
    public partial class SuggestionResponse :  IEquatable<SuggestionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestionResponse" /> class.
        /// </summary>
        /// <param name="Categories">Categories.</param>
        /// <param name="Forums">Forums.</param>
        /// <param name="Labels">Labels.</param>
        /// <param name="StatusUpdates">StatusUpdates.</param>
        /// <param name="Statuses">Statuses.</param>
        /// <param name="Suggestions">Suggestions.</param>
        /// <param name="Tickets">Tickets.</param>
        /// <param name="Users">Users.</param>
        public SuggestionResponse(List<Category> Categories = null, List<Forum> Forums = null, List<Label> Labels = null, List<StatusUpdate> StatusUpdates = null, List<Status> Statuses = null, List<Suggestion> Suggestions = null, List<Ticket> Tickets = null, List<User> Users = null)
        {
            this.Categories = Categories;
            this.Forums = Forums;
            this.Labels = Labels;
            this.StatusUpdates = StatusUpdates;
            this.Statuses = Statuses;
            this.Suggestions = Suggestions;
            this.Tickets = Tickets;
            this.Users = Users;
        }
        
        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<Category> Categories { get; set; }
        /// <summary>
        /// Gets or Sets Forums
        /// </summary>
        [DataMember(Name="forums", EmitDefaultValue=false)]
        public List<Forum> Forums { get; set; }
        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name="labels", EmitDefaultValue=false)]
        public List<Label> Labels { get; set; }
        /// <summary>
        /// Gets or Sets StatusUpdates
        /// </summary>
        [DataMember(Name="status_updates", EmitDefaultValue=false)]
        public List<StatusUpdate> StatusUpdates { get; set; }
        /// <summary>
        /// Gets or Sets Statuses
        /// </summary>
        [DataMember(Name="statuses", EmitDefaultValue=false)]
        public List<Status> Statuses { get; set; }
        /// <summary>
        /// Gets or Sets Suggestions
        /// </summary>
        [DataMember(Name="suggestions", EmitDefaultValue=false)]
        public List<Suggestion> Suggestions { get; set; }
        /// <summary>
        /// Gets or Sets Tickets
        /// </summary>
        [DataMember(Name="tickets", EmitDefaultValue=false)]
        public List<Ticket> Tickets { get; set; }
        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<User> Users { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SuggestionResponse {\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Forums: ").Append(Forums).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  StatusUpdates: ").Append(StatusUpdates).Append("\n");
            sb.Append("  Statuses: ").Append(Statuses).Append("\n");
            sb.Append("  Suggestions: ").Append(Suggestions).Append("\n");
            sb.Append("  Tickets: ").Append(Tickets).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
            return this.Equals(obj as SuggestionResponse);
        }

        /// <summary>
        /// Returns true if SuggestionResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SuggestionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SuggestionResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Categories == other.Categories ||
                    this.Categories != null &&
                    this.Categories.SequenceEqual(other.Categories)
                ) && 
                (
                    this.Forums == other.Forums ||
                    this.Forums != null &&
                    this.Forums.SequenceEqual(other.Forums)
                ) && 
                (
                    this.Labels == other.Labels ||
                    this.Labels != null &&
                    this.Labels.SequenceEqual(other.Labels)
                ) && 
                (
                    this.StatusUpdates == other.StatusUpdates ||
                    this.StatusUpdates != null &&
                    this.StatusUpdates.SequenceEqual(other.StatusUpdates)
                ) && 
                (
                    this.Statuses == other.Statuses ||
                    this.Statuses != null &&
                    this.Statuses.SequenceEqual(other.Statuses)
                ) && 
                (
                    this.Suggestions == other.Suggestions ||
                    this.Suggestions != null &&
                    this.Suggestions.SequenceEqual(other.Suggestions)
                ) && 
                (
                    this.Tickets == other.Tickets ||
                    this.Tickets != null &&
                    this.Tickets.SequenceEqual(other.Tickets)
                ) && 
                (
                    this.Users == other.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(other.Users)
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
                if (this.Categories != null)
                    hash = hash * 59 + this.Categories.GetHashCode();
                if (this.Forums != null)
                    hash = hash * 59 + this.Forums.GetHashCode();
                if (this.Labels != null)
                    hash = hash * 59 + this.Labels.GetHashCode();
                if (this.StatusUpdates != null)
                    hash = hash * 59 + this.StatusUpdates.GetHashCode();
                if (this.Statuses != null)
                    hash = hash * 59 + this.Statuses.GetHashCode();
                if (this.Suggestions != null)
                    hash = hash * 59 + this.Suggestions.GetHashCode();
                if (this.Tickets != null)
                    hash = hash * 59 + this.Tickets.GetHashCode();
                if (this.Users != null)
                    hash = hash * 59 + this.Users.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
