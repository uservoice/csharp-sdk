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
    /// UserResponsePaginated
    /// </summary>
    [DataContract]
    public partial class UserResponsePaginated :  IEquatable<UserResponsePaginated>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponsePaginated" /> class.
        /// </summary>
        /// <param name="ExternalUsers">ExternalUsers.</param>
        /// <param name="NpsRatings">NpsRatings.</param>
        /// <param name="Teams">Teams.</param>
        /// <param name="Users">Users.</param>
        /// <param name="Pagination">Pagination.</param>
        public UserResponsePaginated(List<ExternalUser> ExternalUsers = null, List<NPSRating> NpsRatings = null, List<Team> Teams = null, List<User> Users = null, Pagination Pagination = null)
        {
            this.ExternalUsers = ExternalUsers;
            this.NpsRatings = NpsRatings;
            this.Teams = Teams;
            this.Users = Users;
            this.Pagination = Pagination;
        }
        
        /// <summary>
        /// Gets or Sets ExternalUsers
        /// </summary>
        [DataMember(Name="external_users", EmitDefaultValue=false)]
        public List<ExternalUser> ExternalUsers { get; set; }
        /// <summary>
        /// Gets or Sets NpsRatings
        /// </summary>
        [DataMember(Name="nps_ratings", EmitDefaultValue=false)]
        public List<NPSRating> NpsRatings { get; set; }
        /// <summary>
        /// Gets or Sets Teams
        /// </summary>
        [DataMember(Name="teams", EmitDefaultValue=false)]
        public List<Team> Teams { get; set; }
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
            sb.Append("class UserResponsePaginated {\n");
            sb.Append("  ExternalUsers: ").Append(ExternalUsers).Append("\n");
            sb.Append("  NpsRatings: ").Append(NpsRatings).Append("\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
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
            return this.Equals(obj as UserResponsePaginated);
        }

        /// <summary>
        /// Returns true if UserResponsePaginated instances are equal
        /// </summary>
        /// <param name="other">Instance of UserResponsePaginated to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserResponsePaginated other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ExternalUsers == other.ExternalUsers ||
                    this.ExternalUsers != null &&
                    this.ExternalUsers.SequenceEqual(other.ExternalUsers)
                ) && 
                (
                    this.NpsRatings == other.NpsRatings ||
                    this.NpsRatings != null &&
                    this.NpsRatings.SequenceEqual(other.NpsRatings)
                ) && 
                (
                    this.Teams == other.Teams ||
                    this.Teams != null &&
                    this.Teams.SequenceEqual(other.Teams)
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
                if (this.ExternalUsers != null)
                    hash = hash * 59 + this.ExternalUsers.GetHashCode();
                if (this.NpsRatings != null)
                    hash = hash * 59 + this.NpsRatings.GetHashCode();
                if (this.Teams != null)
                    hash = hash * 59 + this.Teams.GetHashCode();
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
