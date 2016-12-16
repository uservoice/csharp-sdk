/* 
 * UserVoice API
 *
 * No descripton provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
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

namespace UservoiceSDK.Models
{
    /// <summary>
    /// UserResponse
    /// </summary>
    [DataContract]
    public partial class UserResponse :  IEquatable<UserResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponse" /> class.
        /// </summary>
        /// <param name="ExternalUsers">ExternalUsers.</param>
        /// <param name="NpsRatings">NpsRatings.</param>
        /// <param name="Teams">Teams.</param>
        /// <param name="Users">Users.</param>
        public UserResponse(List<ExternalUser> ExternalUsers = null, List<NPSRating> NpsRatings = null, List<Team> Teams = null, List<User> Users = null)
        {
            this.ExternalUsers = ExternalUsers;
            this.NpsRatings = NpsRatings;
            this.Teams = Teams;
            this.Users = Users;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserResponse {\n");
            sb.Append("  ExternalUsers: ").Append(ExternalUsers).Append("\n");
            sb.Append("  NpsRatings: ").Append(NpsRatings).Append("\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
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
            return this.Equals(obj as UserResponse);
        }

        /// <summary>
        /// Returns true if UserResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of UserResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserResponse other)
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
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
