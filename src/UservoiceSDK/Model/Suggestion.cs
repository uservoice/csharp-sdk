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
    /// Suggestion
    /// </summary>
    [DataContract]
    public partial class Suggestion :  IEquatable<Suggestion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Suggestion" /> class.
        /// </summary>
        /// <param name="AdminUrl">AdminUrl.</param>
        /// <param name="ApprovedAt">ApprovedAt.</param>
        /// <param name="Body">Body.</param>
        /// <param name="BodyMimeType">BodyMimeType.</param>
        /// <param name="ClosedAt">ClosedAt.</param>
        /// <param name="CommentsCount">CommentsCount.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="CreatorBrowser">CreatorBrowser.</param>
        /// <param name="CreatorBrowserVersion">CreatorBrowserVersion.</param>
        /// <param name="CreatorMobile">CreatorMobile.</param>
        /// <param name="CreatorOs">CreatorOs.</param>
        /// <param name="CreatorReferrer">CreatorReferrer.</param>
        /// <param name="CreatorUserAgent">CreatorUserAgent.</param>
        /// <param name="Id">Id.</param>
        /// <param name="InappropriateFlagsCount">InappropriateFlagsCount.</param>
        /// <param name="Links">Links.</param>
        /// <param name="NotesCount">NotesCount.</param>
        /// <param name="PortalUrl">PortalUrl.</param>
        /// <param name="RecentEngagement">RecentEngagement.</param>
        /// <param name="RequestsCount">RequestsCount.</param>
        /// <param name="SatisfactionDetractorCount">SatisfactionDetractorCount.</param>
        /// <param name="SatisfactionNeutralCount">SatisfactionNeutralCount.</param>
        /// <param name="SatisfactionPromoterCount">SatisfactionPromoterCount.</param>
        /// <param name="State">State.</param>
        /// <param name="SupportersCount">SupportersCount.</param>
        /// <param name="SupportingAccountsCount">SupportingAccountsCount.</param>
        /// <param name="Title">Title.</param>
        /// <param name="UpdatedAt">UpdatedAt.</param>
        /// <param name="VotesCount">VotesCount.</param>
        public Suggestion(string AdminUrl = null, DateTime? ApprovedAt = null, string Body = null, string BodyMimeType = null, DateTime? ClosedAt = null, long? CommentsCount = null, DateTime? CreatedAt = null, string CreatorBrowser = null, string CreatorBrowserVersion = null, bool? CreatorMobile = null, string CreatorOs = null, string CreatorReferrer = null, string CreatorUserAgent = null, long? Id = null, long? InappropriateFlagsCount = null, SuggestionLinks Links = null, long? NotesCount = null, string PortalUrl = null, long? RecentEngagement = null, long? RequestsCount = null, long? SatisfactionDetractorCount = null, long? SatisfactionNeutralCount = null, long? SatisfactionPromoterCount = null, string State = null, long? SupportersCount = null, long? SupportingAccountsCount = null, string Title = null, DateTime? UpdatedAt = null, long? VotesCount = null)
        {
            this.AdminUrl = AdminUrl;
            this.ApprovedAt = ApprovedAt;
            this.Body = Body;
            this.BodyMimeType = BodyMimeType;
            this.ClosedAt = ClosedAt;
            this.CommentsCount = CommentsCount;
            this.CreatedAt = CreatedAt;
            this.CreatorBrowser = CreatorBrowser;
            this.CreatorBrowserVersion = CreatorBrowserVersion;
            this.CreatorMobile = CreatorMobile;
            this.CreatorOs = CreatorOs;
            this.CreatorReferrer = CreatorReferrer;
            this.CreatorUserAgent = CreatorUserAgent;
            this.Id = Id;
            this.InappropriateFlagsCount = InappropriateFlagsCount;
            this.Links = Links;
            this.NotesCount = NotesCount;
            this.PortalUrl = PortalUrl;
            this.RecentEngagement = RecentEngagement;
            this.RequestsCount = RequestsCount;
            this.SatisfactionDetractorCount = SatisfactionDetractorCount;
            this.SatisfactionNeutralCount = SatisfactionNeutralCount;
            this.SatisfactionPromoterCount = SatisfactionPromoterCount;
            this.State = State;
            this.SupportersCount = SupportersCount;
            this.SupportingAccountsCount = SupportingAccountsCount;
            this.Title = Title;
            this.UpdatedAt = UpdatedAt;
            this.VotesCount = VotesCount;
        }
        
        /// <summary>
        /// Gets or Sets AdminUrl
        /// </summary>
        [DataMember(Name="admin_url", EmitDefaultValue=false)]
        public string AdminUrl { get; set; }
        /// <summary>
        /// Gets or Sets ApprovedAt
        /// </summary>
        [DataMember(Name="approved_at", EmitDefaultValue=false)]
        public DateTime? ApprovedAt { get; set; }
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
        /// Gets or Sets ClosedAt
        /// </summary>
        [DataMember(Name="closed_at", EmitDefaultValue=false)]
        public DateTime? ClosedAt { get; set; }
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
        /// Gets or Sets CreatorBrowser
        /// </summary>
        [DataMember(Name="creator_browser", EmitDefaultValue=false)]
        public string CreatorBrowser { get; set; }
        /// <summary>
        /// Gets or Sets CreatorBrowserVersion
        /// </summary>
        [DataMember(Name="creator_browser_version", EmitDefaultValue=false)]
        public string CreatorBrowserVersion { get; set; }
        /// <summary>
        /// Gets or Sets CreatorMobile
        /// </summary>
        [DataMember(Name="creator_mobile", EmitDefaultValue=false)]
        public bool? CreatorMobile { get; set; }
        /// <summary>
        /// Gets or Sets CreatorOs
        /// </summary>
        [DataMember(Name="creator_os", EmitDefaultValue=false)]
        public string CreatorOs { get; set; }
        /// <summary>
        /// Gets or Sets CreatorReferrer
        /// </summary>
        [DataMember(Name="creator_referrer", EmitDefaultValue=false)]
        public string CreatorReferrer { get; set; }
        /// <summary>
        /// Gets or Sets CreatorUserAgent
        /// </summary>
        [DataMember(Name="creator_user_agent", EmitDefaultValue=false)]
        public string CreatorUserAgent { get; set; }
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
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public SuggestionLinks Links { get; set; }
        /// <summary>
        /// Gets or Sets NotesCount
        /// </summary>
        [DataMember(Name="notes_count", EmitDefaultValue=false)]
        public long? NotesCount { get; set; }
        /// <summary>
        /// Gets or Sets PortalUrl
        /// </summary>
        [DataMember(Name="portal_url", EmitDefaultValue=false)]
        public string PortalUrl { get; set; }
        /// <summary>
        /// Gets or Sets RecentEngagement
        /// </summary>
        [DataMember(Name="recent_engagement", EmitDefaultValue=false)]
        public long? RecentEngagement { get; set; }
        /// <summary>
        /// Gets or Sets RequestsCount
        /// </summary>
        [DataMember(Name="requests_count", EmitDefaultValue=false)]
        public long? RequestsCount { get; set; }
        /// <summary>
        /// Gets or Sets SatisfactionDetractorCount
        /// </summary>
        [DataMember(Name="satisfaction_detractor_count", EmitDefaultValue=false)]
        public long? SatisfactionDetractorCount { get; set; }
        /// <summary>
        /// Gets or Sets SatisfactionNeutralCount
        /// </summary>
        [DataMember(Name="satisfaction_neutral_count", EmitDefaultValue=false)]
        public long? SatisfactionNeutralCount { get; set; }
        /// <summary>
        /// Gets or Sets SatisfactionPromoterCount
        /// </summary>
        [DataMember(Name="satisfaction_promoter_count", EmitDefaultValue=false)]
        public long? SatisfactionPromoterCount { get; set; }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
        /// <summary>
        /// Gets or Sets SupportersCount
        /// </summary>
        [DataMember(Name="supporters_count", EmitDefaultValue=false)]
        public long? SupportersCount { get; set; }
        /// <summary>
        /// Gets or Sets SupportingAccountsCount
        /// </summary>
        [DataMember(Name="supporting_accounts_count", EmitDefaultValue=false)]
        public long? SupportingAccountsCount { get; set; }
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }
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
            sb.Append("class Suggestion {\n");
            sb.Append("  AdminUrl: ").Append(AdminUrl).Append("\n");
            sb.Append("  ApprovedAt: ").Append(ApprovedAt).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  BodyMimeType: ").Append(BodyMimeType).Append("\n");
            sb.Append("  ClosedAt: ").Append(ClosedAt).Append("\n");
            sb.Append("  CommentsCount: ").Append(CommentsCount).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatorBrowser: ").Append(CreatorBrowser).Append("\n");
            sb.Append("  CreatorBrowserVersion: ").Append(CreatorBrowserVersion).Append("\n");
            sb.Append("  CreatorMobile: ").Append(CreatorMobile).Append("\n");
            sb.Append("  CreatorOs: ").Append(CreatorOs).Append("\n");
            sb.Append("  CreatorReferrer: ").Append(CreatorReferrer).Append("\n");
            sb.Append("  CreatorUserAgent: ").Append(CreatorUserAgent).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InappropriateFlagsCount: ").Append(InappropriateFlagsCount).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  NotesCount: ").Append(NotesCount).Append("\n");
            sb.Append("  PortalUrl: ").Append(PortalUrl).Append("\n");
            sb.Append("  RecentEngagement: ").Append(RecentEngagement).Append("\n");
            sb.Append("  RequestsCount: ").Append(RequestsCount).Append("\n");
            sb.Append("  SatisfactionDetractorCount: ").Append(SatisfactionDetractorCount).Append("\n");
            sb.Append("  SatisfactionNeutralCount: ").Append(SatisfactionNeutralCount).Append("\n");
            sb.Append("  SatisfactionPromoterCount: ").Append(SatisfactionPromoterCount).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  SupportersCount: ").Append(SupportersCount).Append("\n");
            sb.Append("  SupportingAccountsCount: ").Append(SupportingAccountsCount).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(obj as Suggestion);
        }

        /// <summary>
        /// Returns true if Suggestion instances are equal
        /// </summary>
        /// <param name="other">Instance of Suggestion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Suggestion other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AdminUrl == other.AdminUrl ||
                    this.AdminUrl != null &&
                    this.AdminUrl.Equals(other.AdminUrl)
                ) && 
                (
                    this.ApprovedAt == other.ApprovedAt ||
                    this.ApprovedAt != null &&
                    this.ApprovedAt.Equals(other.ApprovedAt)
                ) && 
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
                    this.ClosedAt == other.ClosedAt ||
                    this.ClosedAt != null &&
                    this.ClosedAt.Equals(other.ClosedAt)
                ) && 
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
                    this.CreatorBrowser == other.CreatorBrowser ||
                    this.CreatorBrowser != null &&
                    this.CreatorBrowser.Equals(other.CreatorBrowser)
                ) && 
                (
                    this.CreatorBrowserVersion == other.CreatorBrowserVersion ||
                    this.CreatorBrowserVersion != null &&
                    this.CreatorBrowserVersion.Equals(other.CreatorBrowserVersion)
                ) && 
                (
                    this.CreatorMobile == other.CreatorMobile ||
                    this.CreatorMobile != null &&
                    this.CreatorMobile.Equals(other.CreatorMobile)
                ) && 
                (
                    this.CreatorOs == other.CreatorOs ||
                    this.CreatorOs != null &&
                    this.CreatorOs.Equals(other.CreatorOs)
                ) && 
                (
                    this.CreatorReferrer == other.CreatorReferrer ||
                    this.CreatorReferrer != null &&
                    this.CreatorReferrer.Equals(other.CreatorReferrer)
                ) && 
                (
                    this.CreatorUserAgent == other.CreatorUserAgent ||
                    this.CreatorUserAgent != null &&
                    this.CreatorUserAgent.Equals(other.CreatorUserAgent)
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
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.NotesCount == other.NotesCount ||
                    this.NotesCount != null &&
                    this.NotesCount.Equals(other.NotesCount)
                ) && 
                (
                    this.PortalUrl == other.PortalUrl ||
                    this.PortalUrl != null &&
                    this.PortalUrl.Equals(other.PortalUrl)
                ) && 
                (
                    this.RecentEngagement == other.RecentEngagement ||
                    this.RecentEngagement != null &&
                    this.RecentEngagement.Equals(other.RecentEngagement)
                ) && 
                (
                    this.RequestsCount == other.RequestsCount ||
                    this.RequestsCount != null &&
                    this.RequestsCount.Equals(other.RequestsCount)
                ) && 
                (
                    this.SatisfactionDetractorCount == other.SatisfactionDetractorCount ||
                    this.SatisfactionDetractorCount != null &&
                    this.SatisfactionDetractorCount.Equals(other.SatisfactionDetractorCount)
                ) && 
                (
                    this.SatisfactionNeutralCount == other.SatisfactionNeutralCount ||
                    this.SatisfactionNeutralCount != null &&
                    this.SatisfactionNeutralCount.Equals(other.SatisfactionNeutralCount)
                ) && 
                (
                    this.SatisfactionPromoterCount == other.SatisfactionPromoterCount ||
                    this.SatisfactionPromoterCount != null &&
                    this.SatisfactionPromoterCount.Equals(other.SatisfactionPromoterCount)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.SupportersCount == other.SupportersCount ||
                    this.SupportersCount != null &&
                    this.SupportersCount.Equals(other.SupportersCount)
                ) && 
                (
                    this.SupportingAccountsCount == other.SupportingAccountsCount ||
                    this.SupportingAccountsCount != null &&
                    this.SupportingAccountsCount.Equals(other.SupportingAccountsCount)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
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
                if (this.AdminUrl != null)
                    hash = hash * 59 + this.AdminUrl.GetHashCode();
                if (this.ApprovedAt != null)
                    hash = hash * 59 + this.ApprovedAt.GetHashCode();
                if (this.Body != null)
                    hash = hash * 59 + this.Body.GetHashCode();
                if (this.BodyMimeType != null)
                    hash = hash * 59 + this.BodyMimeType.GetHashCode();
                if (this.ClosedAt != null)
                    hash = hash * 59 + this.ClosedAt.GetHashCode();
                if (this.CommentsCount != null)
                    hash = hash * 59 + this.CommentsCount.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.CreatorBrowser != null)
                    hash = hash * 59 + this.CreatorBrowser.GetHashCode();
                if (this.CreatorBrowserVersion != null)
                    hash = hash * 59 + this.CreatorBrowserVersion.GetHashCode();
                if (this.CreatorMobile != null)
                    hash = hash * 59 + this.CreatorMobile.GetHashCode();
                if (this.CreatorOs != null)
                    hash = hash * 59 + this.CreatorOs.GetHashCode();
                if (this.CreatorReferrer != null)
                    hash = hash * 59 + this.CreatorReferrer.GetHashCode();
                if (this.CreatorUserAgent != null)
                    hash = hash * 59 + this.CreatorUserAgent.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.InappropriateFlagsCount != null)
                    hash = hash * 59 + this.InappropriateFlagsCount.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.NotesCount != null)
                    hash = hash * 59 + this.NotesCount.GetHashCode();
                if (this.PortalUrl != null)
                    hash = hash * 59 + this.PortalUrl.GetHashCode();
                if (this.RecentEngagement != null)
                    hash = hash * 59 + this.RecentEngagement.GetHashCode();
                if (this.RequestsCount != null)
                    hash = hash * 59 + this.RequestsCount.GetHashCode();
                if (this.SatisfactionDetractorCount != null)
                    hash = hash * 59 + this.SatisfactionDetractorCount.GetHashCode();
                if (this.SatisfactionNeutralCount != null)
                    hash = hash * 59 + this.SatisfactionNeutralCount.GetHashCode();
                if (this.SatisfactionPromoterCount != null)
                    hash = hash * 59 + this.SatisfactionPromoterCount.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.SupportersCount != null)
                    hash = hash * 59 + this.SupportersCount.GetHashCode();
                if (this.SupportingAccountsCount != null)
                    hash = hash * 59 + this.SupportingAccountsCount.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
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
