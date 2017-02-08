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
    /// StatusUpdateResponsePaginated
    /// </summary>
    [DataContract]
    public partial class StatusUpdateResponsePaginated :  IEquatable<StatusUpdateResponsePaginated>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusUpdateResponsePaginated" /> class.
        /// </summary>
        /// <param name="StatusUpdates">StatusUpdates.</param>
        /// <param name="Statuses">Statuses.</param>
        /// <param name="Suggestions">Suggestions.</param>
        /// <param name="Users">Users.</param>
        /// <param name="Pagination">Pagination.</param>
        public StatusUpdateResponsePaginated(List<StatusUpdate> StatusUpdates = null, List<Status> Statuses = null, List<Suggestion> Suggestions = null, List<User> Users = null, Pagination Pagination = null)
        {
            this.StatusUpdates = StatusUpdates;
            this.Statuses = Statuses;
            this.Suggestions = Suggestions;
            this.Users = Users;
            this.Pagination = Pagination;
        }
        
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
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<User> Users { get; set; }
        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name="pagination", EmitDefaultValue=false)]
        public Pagination Pagination { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusUpdateResponsePaginated {\n");
            sb.Append("  StatusUpdates: ").Append(StatusUpdates).Append("\n");
            sb.Append("  Statuses: ").Append(Statuses).Append("\n");
            sb.Append("  Suggestions: ").Append(Suggestions).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
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
            return this.Equals(obj as StatusUpdateResponsePaginated);
        }

        /// <summary>
        /// Returns true if StatusUpdateResponsePaginated instances are equal
        /// </summary>
        /// <param name="other">Instance of StatusUpdateResponsePaginated to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusUpdateResponsePaginated other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.Users == other.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(other.Users)
                ) && 
                (
                    this.Pagination == other.Pagination ||
                    this.Pagination != null &&
                    this.Pagination.Equals(other.Pagination)
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
                if (this.StatusUpdates != null)
                    hash = hash * 59 + this.StatusUpdates.GetHashCode();
                if (this.Statuses != null)
                    hash = hash * 59 + this.Statuses.GetHashCode();
                if (this.Suggestions != null)
                    hash = hash * 59 + this.Suggestions.GetHashCode();
                if (this.Users != null)
                    hash = hash * 59 + this.Users.GetHashCode();
                if (this.Pagination != null)
                    hash = hash * 59 + this.Pagination.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}