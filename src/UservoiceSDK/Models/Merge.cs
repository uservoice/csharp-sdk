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
    /// Merge
    /// </summary>
    [DataContract]
    public partial class Merge :  IEquatable<Merge>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Merge" /> class.
        /// </summary>
        /// <param name="CommentsCount">CommentsCount.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Links">Links.</param>
        /// <param name="SupportingUsersCount">SupportingUsersCount.</param>
        /// <param name="VotesCount">VotesCount.</param>
        public Merge(long? CommentsCount = null, DateTime? CreatedAt = null, long? Id = null, MergeLinks Links = null, long? SupportingUsersCount = null, long? VotesCount = null)
        {
            this.CommentsCount = CommentsCount;
            this.CreatedAt = CreatedAt;
            this.Id = Id;
            this.Links = Links;
            this.SupportingUsersCount = SupportingUsersCount;
            this.VotesCount = VotesCount;
        }
        
        /// <summary>
        /// Gets or Sets CommentsCount
        /// </summary>
        [DataMember(Name="comments_count", EmitDefaultValue=false)]
        public long? CommentsCount { get; set; }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public MergeLinks Links { get; set; }
        /// <summary>
        /// Gets or Sets SupportingUsersCount
        /// </summary>
        [DataMember(Name="supporting_users_count", EmitDefaultValue=false)]
        public long? SupportingUsersCount { get; set; }
        /// <summary>
        /// Gets or Sets VotesCount
        /// </summary>
        [DataMember(Name="votes_count", EmitDefaultValue=false)]
        public long? VotesCount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Merge {\n");
            sb.Append("  CommentsCount: ").Append(CommentsCount).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  SupportingUsersCount: ").Append(SupportingUsersCount).Append("\n");
            sb.Append("  VotesCount: ").Append(VotesCount).Append("\n");
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
            return this.Equals(obj as Merge);
        }

        /// <summary>
        /// Returns true if Merge instances are equal
        /// </summary>
        /// <param name="other">Instance of Merge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Merge other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CommentsCount == other.CommentsCount ||
                    this.CommentsCount != null &&
                    this.CommentsCount.Equals(other.CommentsCount)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
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
                    this.SupportingUsersCount == other.SupportingUsersCount ||
                    this.SupportingUsersCount != null &&
                    this.SupportingUsersCount.Equals(other.SupportingUsersCount)
                ) && 
                (
                    this.VotesCount == other.VotesCount ||
                    this.VotesCount != null &&
                    this.VotesCount.Equals(other.VotesCount)
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
                if (this.CommentsCount != null)
                    hash = hash * 59 + this.CommentsCount.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.SupportingUsersCount != null)
                    hash = hash * 59 + this.SupportingUsersCount.GetHashCode();
                if (this.VotesCount != null)
                    hash = hash * 59 + this.VotesCount.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}