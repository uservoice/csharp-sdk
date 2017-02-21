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
    /// User
    /// </summary>
    [DataContract]
    public partial class User :  IEquatable<User>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="AllowedState">AllowedState.</param>
        /// <param name="AvatarUrl">AvatarUrl.</param>
        /// <param name="City">City.</param>
        /// <param name="Country">Country.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="EmailAddress">EmailAddress.</param>
        /// <param name="Guid">Guid.</param>
        /// <param name="Id">Id.</param>
        /// <param name="IsAdmin">IsAdmin.</param>
        /// <param name="IsOwner">IsOwner.</param>
        /// <param name="JobTitle">JobTitle.</param>
        /// <param name="LastIp">LastIp.</param>
        /// <param name="LastLogin">LastLogin.</param>
        /// <param name="Links">Links.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Region">Region.</param>
        /// <param name="SatisfactionScore">SatisfactionScore.</param>
        /// <param name="SuggestionVotes">SuggestionVotes.</param>
        /// <param name="SupportedSuggestionsCount">SupportedSuggestionsCount.</param>
        /// <param name="UpdatedAt">UpdatedAt.</param>
        public User(string AllowedState = null, string AvatarUrl = null, string City = null, string Country = null, DateTime? CreatedAt = null, string EmailAddress = null, string Guid = null, long? Id = null, bool? IsAdmin = null, bool? IsOwner = null, string JobTitle = null, string LastIp = null, DateTime? LastLogin = null, UserLinks Links = null, string Name = null, string Region = null, long? SatisfactionScore = null, long? SuggestionVotes = null, long? SupportedSuggestionsCount = null, DateTime? UpdatedAt = null)
        {
            this.AllowedState = AllowedState;
            this.AvatarUrl = AvatarUrl;
            this.City = City;
            this.Country = Country;
            this.CreatedAt = CreatedAt;
            this.EmailAddress = EmailAddress;
            this.Guid = Guid;
            this.Id = Id;
            this.IsAdmin = IsAdmin;
            this.IsOwner = IsOwner;
            this.JobTitle = JobTitle;
            this.LastIp = LastIp;
            this.LastLogin = LastLogin;
            this.Links = Links;
            this.Name = Name;
            this.Region = Region;
            this.SatisfactionScore = SatisfactionScore;
            this.SuggestionVotes = SuggestionVotes;
            this.SupportedSuggestionsCount = SupportedSuggestionsCount;
            this.UpdatedAt = UpdatedAt;
        }
        
        /// <summary>
        /// Gets or Sets AllowedState
        /// </summary>
        [DataMember(Name="allowed_state", EmitDefaultValue=false)]
        public string AllowedState { get; set; }
        /// <summary>
        /// Gets or Sets AvatarUrl
        /// </summary>
        [DataMember(Name="avatar_url", EmitDefaultValue=false)]
        public string AvatarUrl { get; set; }
        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }
        /// <summary>
        /// Gets or Sets EmailAddress
        /// </summary>
        [DataMember(Name="email_address", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }
        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        [DataMember(Name="guid", EmitDefaultValue=false)]
        public string Guid { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
        /// <summary>
        /// Gets or Sets IsAdmin
        /// </summary>
        [DataMember(Name="is_admin", EmitDefaultValue=false)]
        public bool? IsAdmin { get; set; }
        /// <summary>
        /// Gets or Sets IsOwner
        /// </summary>
        [DataMember(Name="is_owner", EmitDefaultValue=false)]
        public bool? IsOwner { get; set; }
        /// <summary>
        /// Gets or Sets JobTitle
        /// </summary>
        [DataMember(Name="job_title", EmitDefaultValue=false)]
        public string JobTitle { get; set; }
        /// <summary>
        /// Gets or Sets LastIp
        /// </summary>
        [DataMember(Name="last_ip", EmitDefaultValue=false)]
        public string LastIp { get; set; }
        /// <summary>
        /// Gets or Sets LastLogin
        /// </summary>
        [DataMember(Name="last_login", EmitDefaultValue=false)]
        public DateTime? LastLogin { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public UserLinks Links { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public string Region { get; set; }
        /// <summary>
        /// Gets or Sets SatisfactionScore
        /// </summary>
        [DataMember(Name="satisfaction_score", EmitDefaultValue=false)]
        public long? SatisfactionScore { get; set; }
        /// <summary>
        /// Gets or Sets SuggestionVotes
        /// </summary>
        [DataMember(Name="suggestion_votes", EmitDefaultValue=false)]
        public long? SuggestionVotes { get; set; }
        /// <summary>
        /// Gets or Sets SupportedSuggestionsCount
        /// </summary>
        [DataMember(Name="supported_suggestions_count", EmitDefaultValue=false)]
        public long? SupportedSuggestionsCount { get; set; }
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  AllowedState: ").Append(AllowedState).Append("\n");
            sb.Append("  AvatarUrl: ").Append(AvatarUrl).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsAdmin: ").Append(IsAdmin).Append("\n");
            sb.Append("  IsOwner: ").Append(IsOwner).Append("\n");
            sb.Append("  JobTitle: ").Append(JobTitle).Append("\n");
            sb.Append("  LastIp: ").Append(LastIp).Append("\n");
            sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  SatisfactionScore: ").Append(SatisfactionScore).Append("\n");
            sb.Append("  SuggestionVotes: ").Append(SuggestionVotes).Append("\n");
            sb.Append("  SupportedSuggestionsCount: ").Append(SupportedSuggestionsCount).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(obj as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="other">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AllowedState == other.AllowedState ||
                    this.AllowedState != null &&
                    this.AllowedState.Equals(other.AllowedState)
                ) && 
                (
                    this.AvatarUrl == other.AvatarUrl ||
                    this.AvatarUrl != null &&
                    this.AvatarUrl.Equals(other.AvatarUrl)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.EmailAddress == other.EmailAddress ||
                    this.EmailAddress != null &&
                    this.EmailAddress.Equals(other.EmailAddress)
                ) && 
                (
                    this.Guid == other.Guid ||
                    this.Guid != null &&
                    this.Guid.Equals(other.Guid)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IsAdmin == other.IsAdmin ||
                    this.IsAdmin != null &&
                    this.IsAdmin.Equals(other.IsAdmin)
                ) && 
                (
                    this.IsOwner == other.IsOwner ||
                    this.IsOwner != null &&
                    this.IsOwner.Equals(other.IsOwner)
                ) && 
                (
                    this.JobTitle == other.JobTitle ||
                    this.JobTitle != null &&
                    this.JobTitle.Equals(other.JobTitle)
                ) && 
                (
                    this.LastIp == other.LastIp ||
                    this.LastIp != null &&
                    this.LastIp.Equals(other.LastIp)
                ) && 
                (
                    this.LastLogin == other.LastLogin ||
                    this.LastLogin != null &&
                    this.LastLogin.Equals(other.LastLogin)
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
                    this.Region == other.Region ||
                    this.Region != null &&
                    this.Region.Equals(other.Region)
                ) && 
                (
                    this.SatisfactionScore == other.SatisfactionScore ||
                    this.SatisfactionScore != null &&
                    this.SatisfactionScore.Equals(other.SatisfactionScore)
                ) && 
                (
                    this.SuggestionVotes == other.SuggestionVotes ||
                    this.SuggestionVotes != null &&
                    this.SuggestionVotes.Equals(other.SuggestionVotes)
                ) && 
                (
                    this.SupportedSuggestionsCount == other.SupportedSuggestionsCount ||
                    this.SupportedSuggestionsCount != null &&
                    this.SupportedSuggestionsCount.Equals(other.SupportedSuggestionsCount)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
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
                if (this.AllowedState != null)
                    hash = hash * 59 + this.AllowedState.GetHashCode();
                if (this.AvatarUrl != null)
                    hash = hash * 59 + this.AvatarUrl.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.EmailAddress != null)
                    hash = hash * 59 + this.EmailAddress.GetHashCode();
                if (this.Guid != null)
                    hash = hash * 59 + this.Guid.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.IsAdmin != null)
                    hash = hash * 59 + this.IsAdmin.GetHashCode();
                if (this.IsOwner != null)
                    hash = hash * 59 + this.IsOwner.GetHashCode();
                if (this.JobTitle != null)
                    hash = hash * 59 + this.JobTitle.GetHashCode();
                if (this.LastIp != null)
                    hash = hash * 59 + this.LastIp.GetHashCode();
                if (this.LastLogin != null)
                    hash = hash * 59 + this.LastLogin.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Region != null)
                    hash = hash * 59 + this.Region.GetHashCode();
                if (this.SatisfactionScore != null)
                    hash = hash * 59 + this.SatisfactionScore.GetHashCode();
                if (this.SuggestionVotes != null)
                    hash = hash * 59 + this.SuggestionVotes.GetHashCode();
                if (this.SupportedSuggestionsCount != null)
                    hash = hash * 59 + this.SupportedSuggestionsCount.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
