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
    /// ForumInvitation
    /// </summary>
    [DataContract]
    public partial class ForumInvitation :  IEquatable<ForumInvitation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForumInvitation" /> class.
        /// </summary>
        /// <param name="Action">Action.</param>
        /// <param name="AvatarUrl">AvatarUrl.</param>
        /// <param name="ClaimedAt">ClaimedAt.</param>
        /// <param name="Code">Code.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Links">Links.</param>
        /// <param name="ReplyTo">ReplyTo.</param>
        /// <param name="ReturnTo">ReturnTo.</param>
        /// <param name="SatisfactionScore">SatisfactionScore.</param>
        /// <param name="Subject">Subject.</param>
        /// <param name="Text">Text.</param>
        /// <param name="UpdatedAt">UpdatedAt.</param>
        public ForumInvitation(string Action = null, DateTime? AvatarUrl = null, DateTime? ClaimedAt = null, string Code = null, DateTime? CreatedAt = null, string Email = null, long? Id = null, ForumInvitationLinks Links = null, string ReplyTo = null, string ReturnTo = null, DateTime? SatisfactionScore = null, string Subject = null, string Text = null, DateTime? UpdatedAt = null)
        {
            this.Action = Action;
            this.AvatarUrl = AvatarUrl;
            this.ClaimedAt = ClaimedAt;
            this.Code = Code;
            this.CreatedAt = CreatedAt;
            this.Email = Email;
            this.Id = Id;
            this.Links = Links;
            this.ReplyTo = ReplyTo;
            this.ReturnTo = ReturnTo;
            this.SatisfactionScore = SatisfactionScore;
            this.Subject = Subject;
            this.Text = Text;
            this.UpdatedAt = UpdatedAt;
        }
        
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }
        /// <summary>
        /// Gets or Sets AvatarUrl
        /// </summary>
        [DataMember(Name="avatar_url", EmitDefaultValue=false)]
        public DateTime? AvatarUrl { get; set; }
        /// <summary>
        /// Gets or Sets ClaimedAt
        /// </summary>
        [DataMember(Name="claimed_at", EmitDefaultValue=false)]
        public DateTime? ClaimedAt { get; set; }
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public ForumInvitationLinks Links { get; set; }
        /// <summary>
        /// Gets or Sets ReplyTo
        /// </summary>
        [DataMember(Name="reply_to", EmitDefaultValue=false)]
        public string ReplyTo { get; set; }
        /// <summary>
        /// Gets or Sets ReturnTo
        /// </summary>
        [DataMember(Name="return_to", EmitDefaultValue=false)]
        public string ReturnTo { get; set; }
        /// <summary>
        /// Gets or Sets SatisfactionScore
        /// </summary>
        [DataMember(Name="satisfaction_score", EmitDefaultValue=false)]
        public DateTime? SatisfactionScore { get; set; }
        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }
        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }
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
            sb.Append("class ForumInvitation {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  AvatarUrl: ").Append(AvatarUrl).Append("\n");
            sb.Append("  ClaimedAt: ").Append(ClaimedAt).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  ReplyTo: ").Append(ReplyTo).Append("\n");
            sb.Append("  ReturnTo: ").Append(ReturnTo).Append("\n");
            sb.Append("  SatisfactionScore: ").Append(SatisfactionScore).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(obj as ForumInvitation);
        }

        /// <summary>
        /// Returns true if ForumInvitation instances are equal
        /// </summary>
        /// <param name="other">Instance of ForumInvitation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForumInvitation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) && 
                (
                    this.AvatarUrl == other.AvatarUrl ||
                    this.AvatarUrl != null &&
                    this.AvatarUrl.Equals(other.AvatarUrl)
                ) && 
                (
                    this.ClaimedAt == other.ClaimedAt ||
                    this.ClaimedAt != null &&
                    this.ClaimedAt.Equals(other.ClaimedAt)
                ) && 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
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
                    this.ReplyTo == other.ReplyTo ||
                    this.ReplyTo != null &&
                    this.ReplyTo.Equals(other.ReplyTo)
                ) && 
                (
                    this.ReturnTo == other.ReturnTo ||
                    this.ReturnTo != null &&
                    this.ReturnTo.Equals(other.ReturnTo)
                ) && 
                (
                    this.SatisfactionScore == other.SatisfactionScore ||
                    this.SatisfactionScore != null &&
                    this.SatisfactionScore.Equals(other.SatisfactionScore)
                ) && 
                (
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.Equals(other.Subject)
                ) && 
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
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
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                if (this.AvatarUrl != null)
                    hash = hash * 59 + this.AvatarUrl.GetHashCode();
                if (this.ClaimedAt != null)
                    hash = hash * 59 + this.ClaimedAt.GetHashCode();
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.ReplyTo != null)
                    hash = hash * 59 + this.ReplyTo.GetHashCode();
                if (this.ReturnTo != null)
                    hash = hash * 59 + this.ReturnTo.GetHashCode();
                if (this.SatisfactionScore != null)
                    hash = hash * 59 + this.SatisfactionScore.GetHashCode();
                if (this.Subject != null)
                    hash = hash * 59 + this.Subject.GetHashCode();
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
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
