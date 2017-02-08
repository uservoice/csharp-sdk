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
    /// ExternalAccount
    /// </summary>
    [DataContract]
    public partial class ExternalAccount :  IEquatable<ExternalAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalAccount" /> class.
        /// </summary>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="ExternalCreatedAt">ExternalCreatedAt.</param>
        /// <param name="ExternalId">ExternalId.</param>
        /// <param name="Id">Id.</param>
        /// <param name="LastActiveAt">LastActiveAt.</param>
        /// <param name="LtvCents">LtvCents.</param>
        /// <param name="MrrCents">MrrCents.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Plan">Plan.</param>
        /// <param name="RequestsCount">RequestsCount.</param>
        /// <param name="SupportedIdeasCount">SupportedIdeasCount.</param>
        /// <param name="UpdatedAt">UpdatedAt.</param>
        /// <param name="UsersCount">UsersCount.</param>
        public ExternalAccount(DateTime? CreatedAt = null, DateTime? ExternalCreatedAt = null, string ExternalId = null, long? Id = null, DateTime? LastActiveAt = null, long? LtvCents = null, long? MrrCents = null, string Name = null, string Plan = null, long? RequestsCount = null, long? SupportedIdeasCount = null, DateTime? UpdatedAt = null, long? UsersCount = null)
        {
            this.CreatedAt = CreatedAt;
            this.ExternalCreatedAt = ExternalCreatedAt;
            this.ExternalId = ExternalId;
            this.Id = Id;
            this.LastActiveAt = LastActiveAt;
            this.LtvCents = LtvCents;
            this.MrrCents = MrrCents;
            this.Name = Name;
            this.Plan = Plan;
            this.RequestsCount = RequestsCount;
            this.SupportedIdeasCount = SupportedIdeasCount;
            this.UpdatedAt = UpdatedAt;
            this.UsersCount = UsersCount;
        }
        
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }
        /// <summary>
        /// Gets or Sets ExternalCreatedAt
        /// </summary>
        [DataMember(Name="external_created_at", EmitDefaultValue=false)]
        public DateTime? ExternalCreatedAt { get; set; }
        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [DataMember(Name="external_id", EmitDefaultValue=false)]
        public string ExternalId { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
        /// <summary>
        /// Gets or Sets LastActiveAt
        /// </summary>
        [DataMember(Name="last_active_at", EmitDefaultValue=false)]
        public DateTime? LastActiveAt { get; set; }
        /// <summary>
        /// Gets or Sets LtvCents
        /// </summary>
        [DataMember(Name="ltv_cents", EmitDefaultValue=false)]
        public long? LtvCents { get; set; }
        /// <summary>
        /// Gets or Sets MrrCents
        /// </summary>
        [DataMember(Name="mrr_cents", EmitDefaultValue=false)]
        public long? MrrCents { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Plan
        /// </summary>
        [DataMember(Name="plan", EmitDefaultValue=false)]
        public string Plan { get; set; }
        /// <summary>
        /// Gets or Sets RequestsCount
        /// </summary>
        [DataMember(Name="requests_count", EmitDefaultValue=false)]
        public long? RequestsCount { get; set; }
        /// <summary>
        /// Gets or Sets SupportedIdeasCount
        /// </summary>
        [DataMember(Name="supported_ideas_count", EmitDefaultValue=false)]
        public long? SupportedIdeasCount { get; set; }
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
            sb.Append("class ExternalAccount {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ExternalCreatedAt: ").Append(ExternalCreatedAt).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastActiveAt: ").Append(LastActiveAt).Append("\n");
            sb.Append("  LtvCents: ").Append(LtvCents).Append("\n");
            sb.Append("  MrrCents: ").Append(MrrCents).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Plan: ").Append(Plan).Append("\n");
            sb.Append("  RequestsCount: ").Append(RequestsCount).Append("\n");
            sb.Append("  SupportedIdeasCount: ").Append(SupportedIdeasCount).Append("\n");
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
            return this.Equals(obj as ExternalAccount);
        }

        /// <summary>
        /// Returns true if ExternalAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalAccount other)
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
                    this.ExternalCreatedAt == other.ExternalCreatedAt ||
                    this.ExternalCreatedAt != null &&
                    this.ExternalCreatedAt.Equals(other.ExternalCreatedAt)
                ) && 
                (
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LastActiveAt == other.LastActiveAt ||
                    this.LastActiveAt != null &&
                    this.LastActiveAt.Equals(other.LastActiveAt)
                ) && 
                (
                    this.LtvCents == other.LtvCents ||
                    this.LtvCents != null &&
                    this.LtvCents.Equals(other.LtvCents)
                ) && 
                (
                    this.MrrCents == other.MrrCents ||
                    this.MrrCents != null &&
                    this.MrrCents.Equals(other.MrrCents)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Plan == other.Plan ||
                    this.Plan != null &&
                    this.Plan.Equals(other.Plan)
                ) && 
                (
                    this.RequestsCount == other.RequestsCount ||
                    this.RequestsCount != null &&
                    this.RequestsCount.Equals(other.RequestsCount)
                ) && 
                (
                    this.SupportedIdeasCount == other.SupportedIdeasCount ||
                    this.SupportedIdeasCount != null &&
                    this.SupportedIdeasCount.Equals(other.SupportedIdeasCount)
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
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.ExternalCreatedAt != null)
                    hash = hash * 59 + this.ExternalCreatedAt.GetHashCode();
                if (this.ExternalId != null)
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LastActiveAt != null)
                    hash = hash * 59 + this.LastActiveAt.GetHashCode();
                if (this.LtvCents != null)
                    hash = hash * 59 + this.LtvCents.GetHashCode();
                if (this.MrrCents != null)
                    hash = hash * 59 + this.MrrCents.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Plan != null)
                    hash = hash * 59 + this.Plan.GetHashCode();
                if (this.RequestsCount != null)
                    hash = hash * 59 + this.RequestsCount.GetHashCode();
                if (this.SupportedIdeasCount != null)
                    hash = hash * 59 + this.SupportedIdeasCount.GetHashCode();
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
