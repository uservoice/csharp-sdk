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
    /// UserLinks
    /// </summary>
    [DataContract]
    public partial class UserLinks :  IEquatable<UserLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserLinks" /> class.
        /// </summary>
        /// <param name="CurrentNpsRating">CurrentNpsRating.</param>
        /// <param name="ExternalUsers">ExternalUsers.</param>
        /// <param name="PreviousNpsRating">PreviousNpsRating.</param>
        /// <param name="Supporter">Supporter.</param>
        /// <param name="Teams">Teams.</param>
        public UserLinks(long? CurrentNpsRating = null, List<long?> ExternalUsers = null, long? PreviousNpsRating = null, long? Supporter = null, List<long?> Teams = null)
        {
            this.CurrentNpsRating = CurrentNpsRating;
            this.ExternalUsers = ExternalUsers;
            this.PreviousNpsRating = PreviousNpsRating;
            this.Supporter = Supporter;
            this.Teams = Teams;
        }
        
        /// <summary>
        /// Gets or Sets CurrentNpsRating
        /// </summary>
        [DataMember(Name="current_nps_rating", EmitDefaultValue=false)]
        public long? CurrentNpsRating { get; set; }
        /// <summary>
        /// Gets or Sets ExternalUsers
        /// </summary>
        [DataMember(Name="external_users", EmitDefaultValue=false)]
        public List<long?> ExternalUsers { get; set; }
        /// <summary>
        /// Gets or Sets PreviousNpsRating
        /// </summary>
        [DataMember(Name="previous_nps_rating", EmitDefaultValue=false)]
        public long? PreviousNpsRating { get; set; }
        /// <summary>
        /// Gets or Sets Supporter
        /// </summary>
        [DataMember(Name="supporter", EmitDefaultValue=false)]
        public long? Supporter { get; set; }
        /// <summary>
        /// Gets or Sets Teams
        /// </summary>
        [DataMember(Name="teams", EmitDefaultValue=false)]
        public List<long?> Teams { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserLinks {\n");
            sb.Append("  CurrentNpsRating: ").Append(CurrentNpsRating).Append("\n");
            sb.Append("  ExternalUsers: ").Append(ExternalUsers).Append("\n");
            sb.Append("  PreviousNpsRating: ").Append(PreviousNpsRating).Append("\n");
            sb.Append("  Supporter: ").Append(Supporter).Append("\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
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
            return this.Equals(obj as UserLinks);
        }

        /// <summary>
        /// Returns true if UserLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of UserLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CurrentNpsRating == other.CurrentNpsRating ||
                    this.CurrentNpsRating != null &&
                    this.CurrentNpsRating.Equals(other.CurrentNpsRating)
                ) && 
                (
                    this.ExternalUsers == other.ExternalUsers ||
                    this.ExternalUsers != null &&
                    this.ExternalUsers.SequenceEqual(other.ExternalUsers)
                ) && 
                (
                    this.PreviousNpsRating == other.PreviousNpsRating ||
                    this.PreviousNpsRating != null &&
                    this.PreviousNpsRating.Equals(other.PreviousNpsRating)
                ) && 
                (
                    this.Supporter == other.Supporter ||
                    this.Supporter != null &&
                    this.Supporter.Equals(other.Supporter)
                ) && 
                (
                    this.Teams == other.Teams ||
                    this.Teams != null &&
                    this.Teams.SequenceEqual(other.Teams)
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
                if (this.CurrentNpsRating != null)
                    hash = hash * 59 + this.CurrentNpsRating.GetHashCode();
                if (this.ExternalUsers != null)
                    hash = hash * 59 + this.ExternalUsers.GetHashCode();
                if (this.PreviousNpsRating != null)
                    hash = hash * 59 + this.PreviousNpsRating.GetHashCode();
                if (this.Supporter != null)
                    hash = hash * 59 + this.Supporter.GetHashCode();
                if (this.Teams != null)
                    hash = hash * 59 + this.Teams.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
