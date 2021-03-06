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
    /// ForumInvitationLinks
    /// </summary>
    [DataContract]
    public partial class ForumInvitationLinks :  IEquatable<ForumInvitationLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForumInvitationLinks" /> class.
        /// </summary>
        /// <param name="ClaimedBy">ClaimedBy.</param>
        /// <param name="Forum">Forum.</param>
        /// <param name="InvitedBy">InvitedBy.</param>
        public ForumInvitationLinks(long? ClaimedBy = null, long? Forum = null, long? InvitedBy = null)
        {
            this.ClaimedBy = ClaimedBy;
            this.Forum = Forum;
            this.InvitedBy = InvitedBy;
        }
        
        /// <summary>
        /// Gets or Sets ClaimedBy
        /// </summary>
        [DataMember(Name="claimed_by", EmitDefaultValue=false)]
        public long? ClaimedBy { get; set; }
        /// <summary>
        /// Gets or Sets Forum
        /// </summary>
        [DataMember(Name="forum", EmitDefaultValue=false)]
        public long? Forum { get; set; }
        /// <summary>
        /// Gets or Sets InvitedBy
        /// </summary>
        [DataMember(Name="invited_by", EmitDefaultValue=false)]
        public long? InvitedBy { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForumInvitationLinks {\n");
            sb.Append("  ClaimedBy: ").Append(ClaimedBy).Append("\n");
            sb.Append("  Forum: ").Append(Forum).Append("\n");
            sb.Append("  InvitedBy: ").Append(InvitedBy).Append("\n");
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
            return this.Equals(obj as ForumInvitationLinks);
        }

        /// <summary>
        /// Returns true if ForumInvitationLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of ForumInvitationLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForumInvitationLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ClaimedBy == other.ClaimedBy ||
                    this.ClaimedBy != null &&
                    this.ClaimedBy.Equals(other.ClaimedBy)
                ) && 
                (
                    this.Forum == other.Forum ||
                    this.Forum != null &&
                    this.Forum.Equals(other.Forum)
                ) && 
                (
                    this.InvitedBy == other.InvitedBy ||
                    this.InvitedBy != null &&
                    this.InvitedBy.Equals(other.InvitedBy)
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
                if (this.ClaimedBy != null)
                    hash = hash * 59 + this.ClaimedBy.GetHashCode();
                if (this.Forum != null)
                    hash = hash * 59 + this.Forum.GetHashCode();
                if (this.InvitedBy != null)
                    hash = hash * 59 + this.InvitedBy.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
