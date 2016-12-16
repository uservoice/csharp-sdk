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
    /// Forum
    /// </summary>
    [DataContract]
    public partial class Forum :  IEquatable<Forum>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Forum" /> class.
        /// </summary>
        /// <param name="CategoryRequired">CategoryRequired.</param>
        /// <param name="ClassicVoting">ClassicVoting.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="Example">Example.</param>
        /// <param name="Id">Id.</param>
        /// <param name="IsPrivate">IsPrivate.</param>
        /// <param name="IsPublic">IsPublic.</param>
        /// <param name="Links">Links.</param>
        /// <param name="Name">Name.</param>
        /// <param name="OpenSuggestionsCount">OpenSuggestionsCount.</param>
        /// <param name="PortalUrl">PortalUrl.</param>
        /// <param name="Prompt">Prompt.</param>
        /// <param name="SuggestionsCount">SuggestionsCount.</param>
        /// <param name="UpdatedAt">UpdatedAt.</param>
        /// <param name="WelcomeMessage">WelcomeMessage.</param>
        /// <param name="WelcomeMessageMimeType">WelcomeMessageMimeType.</param>
        public Forum(bool? CategoryRequired = null, bool? ClassicVoting = null, DateTime? CreatedAt = null, string Example = null, long? Id = null, bool? IsPrivate = null, bool? IsPublic = null, ForumLinks Links = null, string Name = null, long? OpenSuggestionsCount = null, string PortalUrl = null, string Prompt = null, long? SuggestionsCount = null, DateTime? UpdatedAt = null, string WelcomeMessage = null, string WelcomeMessageMimeType = null)
        {
            this.CategoryRequired = CategoryRequired;
            this.ClassicVoting = ClassicVoting;
            this.CreatedAt = CreatedAt;
            this.Example = Example;
            this.Id = Id;
            this.IsPrivate = IsPrivate;
            this.IsPublic = IsPublic;
            this.Links = Links;
            this.Name = Name;
            this.OpenSuggestionsCount = OpenSuggestionsCount;
            this.PortalUrl = PortalUrl;
            this.Prompt = Prompt;
            this.SuggestionsCount = SuggestionsCount;
            this.UpdatedAt = UpdatedAt;
            this.WelcomeMessage = WelcomeMessage;
            this.WelcomeMessageMimeType = WelcomeMessageMimeType;
        }
        
        /// <summary>
        /// Gets or Sets CategoryRequired
        /// </summary>
        [DataMember(Name="category_required", EmitDefaultValue=false)]
        public bool? CategoryRequired { get; set; }
        /// <summary>
        /// Gets or Sets ClassicVoting
        /// </summary>
        [DataMember(Name="classic_voting", EmitDefaultValue=false)]
        public bool? ClassicVoting { get; set; }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }
        /// <summary>
        /// Gets or Sets Example
        /// </summary>
        [DataMember(Name="example", EmitDefaultValue=false)]
        public string Example { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
        /// <summary>
        /// Gets or Sets IsPrivate
        /// </summary>
        [DataMember(Name="is_private", EmitDefaultValue=false)]
        public bool? IsPrivate { get; set; }
        /// <summary>
        /// Gets or Sets IsPublic
        /// </summary>
        [DataMember(Name="is_public", EmitDefaultValue=false)]
        public bool? IsPublic { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public ForumLinks Links { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets OpenSuggestionsCount
        /// </summary>
        [DataMember(Name="open_suggestions_count", EmitDefaultValue=false)]
        public long? OpenSuggestionsCount { get; set; }
        /// <summary>
        /// Gets or Sets PortalUrl
        /// </summary>
        [DataMember(Name="portal_url", EmitDefaultValue=false)]
        public string PortalUrl { get; set; }
        /// <summary>
        /// Gets or Sets Prompt
        /// </summary>
        [DataMember(Name="prompt", EmitDefaultValue=false)]
        public string Prompt { get; set; }
        /// <summary>
        /// Gets or Sets SuggestionsCount
        /// </summary>
        [DataMember(Name="suggestions_count", EmitDefaultValue=false)]
        public long? SuggestionsCount { get; set; }
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }
        /// <summary>
        /// Gets or Sets WelcomeMessage
        /// </summary>
        [DataMember(Name="welcome_message", EmitDefaultValue=false)]
        public string WelcomeMessage { get; set; }
        /// <summary>
        /// Gets or Sets WelcomeMessageMimeType
        /// </summary>
        [DataMember(Name="welcome_message_mime_type", EmitDefaultValue=false)]
        public string WelcomeMessageMimeType { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Forum {\n");
            sb.Append("  CategoryRequired: ").Append(CategoryRequired).Append("\n");
            sb.Append("  ClassicVoting: ").Append(ClassicVoting).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Example: ").Append(Example).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsPrivate: ").Append(IsPrivate).Append("\n");
            sb.Append("  IsPublic: ").Append(IsPublic).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OpenSuggestionsCount: ").Append(OpenSuggestionsCount).Append("\n");
            sb.Append("  PortalUrl: ").Append(PortalUrl).Append("\n");
            sb.Append("  Prompt: ").Append(Prompt).Append("\n");
            sb.Append("  SuggestionsCount: ").Append(SuggestionsCount).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  WelcomeMessage: ").Append(WelcomeMessage).Append("\n");
            sb.Append("  WelcomeMessageMimeType: ").Append(WelcomeMessageMimeType).Append("\n");
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
            return this.Equals(obj as Forum);
        }

        /// <summary>
        /// Returns true if Forum instances are equal
        /// </summary>
        /// <param name="other">Instance of Forum to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Forum other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CategoryRequired == other.CategoryRequired ||
                    this.CategoryRequired != null &&
                    this.CategoryRequired.Equals(other.CategoryRequired)
                ) && 
                (
                    this.ClassicVoting == other.ClassicVoting ||
                    this.ClassicVoting != null &&
                    this.ClassicVoting.Equals(other.ClassicVoting)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.Example == other.Example ||
                    this.Example != null &&
                    this.Example.Equals(other.Example)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IsPrivate == other.IsPrivate ||
                    this.IsPrivate != null &&
                    this.IsPrivate.Equals(other.IsPrivate)
                ) && 
                (
                    this.IsPublic == other.IsPublic ||
                    this.IsPublic != null &&
                    this.IsPublic.Equals(other.IsPublic)
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
                    this.OpenSuggestionsCount == other.OpenSuggestionsCount ||
                    this.OpenSuggestionsCount != null &&
                    this.OpenSuggestionsCount.Equals(other.OpenSuggestionsCount)
                ) && 
                (
                    this.PortalUrl == other.PortalUrl ||
                    this.PortalUrl != null &&
                    this.PortalUrl.Equals(other.PortalUrl)
                ) && 
                (
                    this.Prompt == other.Prompt ||
                    this.Prompt != null &&
                    this.Prompt.Equals(other.Prompt)
                ) && 
                (
                    this.SuggestionsCount == other.SuggestionsCount ||
                    this.SuggestionsCount != null &&
                    this.SuggestionsCount.Equals(other.SuggestionsCount)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    this.WelcomeMessage == other.WelcomeMessage ||
                    this.WelcomeMessage != null &&
                    this.WelcomeMessage.Equals(other.WelcomeMessage)
                ) && 
                (
                    this.WelcomeMessageMimeType == other.WelcomeMessageMimeType ||
                    this.WelcomeMessageMimeType != null &&
                    this.WelcomeMessageMimeType.Equals(other.WelcomeMessageMimeType)
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
                if (this.CategoryRequired != null)
                    hash = hash * 59 + this.CategoryRequired.GetHashCode();
                if (this.ClassicVoting != null)
                    hash = hash * 59 + this.ClassicVoting.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.Example != null)
                    hash = hash * 59 + this.Example.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.IsPrivate != null)
                    hash = hash * 59 + this.IsPrivate.GetHashCode();
                if (this.IsPublic != null)
                    hash = hash * 59 + this.IsPublic.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.OpenSuggestionsCount != null)
                    hash = hash * 59 + this.OpenSuggestionsCount.GetHashCode();
                if (this.PortalUrl != null)
                    hash = hash * 59 + this.PortalUrl.GetHashCode();
                if (this.Prompt != null)
                    hash = hash * 59 + this.Prompt.GetHashCode();
                if (this.SuggestionsCount != null)
                    hash = hash * 59 + this.SuggestionsCount.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                if (this.WelcomeMessage != null)
                    hash = hash * 59 + this.WelcomeMessage.GetHashCode();
                if (this.WelcomeMessageMimeType != null)
                    hash = hash * 59 + this.WelcomeMessageMimeType.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
