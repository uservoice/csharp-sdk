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
    /// Comment
    /// </summary>
    [DataContract]
    public partial class Comment :  IEquatable<Comment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Comment" /> class.
        /// </summary>
        /// <param name="Body">Body.</param>
        /// <param name="BodyMimeType">BodyMimeType.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="Id">Id.</param>
        /// <param name="InappropriateFlagsCount">InappropriateFlagsCount.</param>
        /// <param name="IsAdminComment">IsAdminComment.</param>
        /// <param name="Links">Links.</param>
        /// <param name="State">State.</param>
        /// <param name="UpdatedAt">UpdatedAt.</param>
        public Comment(string Body = null, string BodyMimeType = null, DateTime? CreatedAt = null, long? Id = null, long? InappropriateFlagsCount = null, bool? IsAdminComment = null, CommentLinks Links = null, string State = null, DateTime? UpdatedAt = null)
        {
            this.Body = Body;
            this.BodyMimeType = BodyMimeType;
            this.CreatedAt = CreatedAt;
            this.Id = Id;
            this.InappropriateFlagsCount = InappropriateFlagsCount;
            this.IsAdminComment = IsAdminComment;
            this.Links = Links;
            this.State = State;
            this.UpdatedAt = UpdatedAt;
        }
        
        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }
        /// <summary>
        /// Gets or Sets BodyMimeType
        /// </summary>
        [DataMember(Name="body_mime_type", EmitDefaultValue=false)]
        public string BodyMimeType { get; set; }
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
        /// Gets or Sets InappropriateFlagsCount
        /// </summary>
        [DataMember(Name="inappropriate_flags_count", EmitDefaultValue=false)]
        public long? InappropriateFlagsCount { get; set; }
        /// <summary>
        /// Gets or Sets IsAdminComment
        /// </summary>
        [DataMember(Name="is_admin_comment", EmitDefaultValue=false)]
        public bool? IsAdminComment { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public CommentLinks Links { get; set; }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
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
            sb.Append("class Comment {\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  BodyMimeType: ").Append(BodyMimeType).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InappropriateFlagsCount: ").Append(InappropriateFlagsCount).Append("\n");
            sb.Append("  IsAdminComment: ").Append(IsAdminComment).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(obj as Comment);
        }

        /// <summary>
        /// Returns true if Comment instances are equal
        /// </summary>
        /// <param name="other">Instance of Comment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Comment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Body == other.Body ||
                    this.Body != null &&
                    this.Body.Equals(other.Body)
                ) && 
                (
                    this.BodyMimeType == other.BodyMimeType ||
                    this.BodyMimeType != null &&
                    this.BodyMimeType.Equals(other.BodyMimeType)
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
                    this.InappropriateFlagsCount == other.InappropriateFlagsCount ||
                    this.InappropriateFlagsCount != null &&
                    this.InappropriateFlagsCount.Equals(other.InappropriateFlagsCount)
                ) && 
                (
                    this.IsAdminComment == other.IsAdminComment ||
                    this.IsAdminComment != null &&
                    this.IsAdminComment.Equals(other.IsAdminComment)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                if (this.Body != null)
                    hash = hash * 59 + this.Body.GetHashCode();
                if (this.BodyMimeType != null)
                    hash = hash * 59 + this.BodyMimeType.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.InappropriateFlagsCount != null)
                    hash = hash * 59 + this.InappropriateFlagsCount.GetHashCode();
                if (this.IsAdminComment != null)
                    hash = hash * 59 + this.IsAdminComment.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
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