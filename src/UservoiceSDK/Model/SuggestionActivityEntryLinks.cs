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
    /// SuggestionActivityEntryLinks
    /// </summary>
    [DataContract]
    public partial class SuggestionActivityEntryLinks :  IEquatable<SuggestionActivityEntryLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestionActivityEntryLinks" /> class.
        /// </summary>
        /// <param name="Comment">Comment.</param>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="Feedback">Feedback.</param>
        /// <param name="MergedFromSuggestion">MergedFromSuggestion.</param>
        /// <param name="MergedToSuggestion">MergedToSuggestion.</param>
        /// <param name="Message">Message.</param>
        /// <param name="NewCategory">NewCategory.</param>
        /// <param name="NewForum">NewForum.</param>
        /// <param name="Note">Note.</param>
        /// <param name="OldCategory">OldCategory.</param>
        /// <param name="OldForum">OldForum.</param>
        /// <param name="StatusUpdate">StatusUpdate.</param>
        /// <param name="Suggestion">Suggestion.</param>
        /// <param name="Ticket">Ticket.</param>
        public SuggestionActivityEntryLinks(long? Comment = null, long? CreatedBy = null, long? Feedback = null, long? MergedFromSuggestion = null, long? MergedToSuggestion = null, long? Message = null, long? NewCategory = null, long? NewForum = null, long? Note = null, long? OldCategory = null, long? OldForum = null, long? StatusUpdate = null, long? Suggestion = null, long? Ticket = null)
        {
            this.Comment = Comment;
            this.CreatedBy = CreatedBy;
            this.Feedback = Feedback;
            this.MergedFromSuggestion = MergedFromSuggestion;
            this.MergedToSuggestion = MergedToSuggestion;
            this.Message = Message;
            this.NewCategory = NewCategory;
            this.NewForum = NewForum;
            this.Note = Note;
            this.OldCategory = OldCategory;
            this.OldForum = OldForum;
            this.StatusUpdate = StatusUpdate;
            this.Suggestion = Suggestion;
            this.Ticket = Ticket;
        }
        
        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public long? Comment { get; set; }
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="created_by", EmitDefaultValue=false)]
        public long? CreatedBy { get; set; }
        /// <summary>
        /// Gets or Sets Feedback
        /// </summary>
        [DataMember(Name="feedback", EmitDefaultValue=false)]
        public long? Feedback { get; set; }
        /// <summary>
        /// Gets or Sets MergedFromSuggestion
        /// </summary>
        [DataMember(Name="merged_from_suggestion", EmitDefaultValue=false)]
        public long? MergedFromSuggestion { get; set; }
        /// <summary>
        /// Gets or Sets MergedToSuggestion
        /// </summary>
        [DataMember(Name="merged_to_suggestion", EmitDefaultValue=false)]
        public long? MergedToSuggestion { get; set; }
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public long? Message { get; set; }
        /// <summary>
        /// Gets or Sets NewCategory
        /// </summary>
        [DataMember(Name="new_category", EmitDefaultValue=false)]
        public long? NewCategory { get; set; }
        /// <summary>
        /// Gets or Sets NewForum
        /// </summary>
        [DataMember(Name="new_forum", EmitDefaultValue=false)]
        public long? NewForum { get; set; }
        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public long? Note { get; set; }
        /// <summary>
        /// Gets or Sets OldCategory
        /// </summary>
        [DataMember(Name="old_category", EmitDefaultValue=false)]
        public long? OldCategory { get; set; }
        /// <summary>
        /// Gets or Sets OldForum
        /// </summary>
        [DataMember(Name="old_forum", EmitDefaultValue=false)]
        public long? OldForum { get; set; }
        /// <summary>
        /// Gets or Sets StatusUpdate
        /// </summary>
        [DataMember(Name="status_update", EmitDefaultValue=false)]
        public long? StatusUpdate { get; set; }
        /// <summary>
        /// Gets or Sets Suggestion
        /// </summary>
        [DataMember(Name="suggestion", EmitDefaultValue=false)]
        public long? Suggestion { get; set; }
        /// <summary>
        /// Gets or Sets Ticket
        /// </summary>
        [DataMember(Name="ticket", EmitDefaultValue=false)]
        public long? Ticket { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SuggestionActivityEntryLinks {\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Feedback: ").Append(Feedback).Append("\n");
            sb.Append("  MergedFromSuggestion: ").Append(MergedFromSuggestion).Append("\n");
            sb.Append("  MergedToSuggestion: ").Append(MergedToSuggestion).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  NewCategory: ").Append(NewCategory).Append("\n");
            sb.Append("  NewForum: ").Append(NewForum).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  OldCategory: ").Append(OldCategory).Append("\n");
            sb.Append("  OldForum: ").Append(OldForum).Append("\n");
            sb.Append("  StatusUpdate: ").Append(StatusUpdate).Append("\n");
            sb.Append("  Suggestion: ").Append(Suggestion).Append("\n");
            sb.Append("  Ticket: ").Append(Ticket).Append("\n");
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
            return this.Equals(obj as SuggestionActivityEntryLinks);
        }

        /// <summary>
        /// Returns true if SuggestionActivityEntryLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of SuggestionActivityEntryLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SuggestionActivityEntryLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Comment == other.Comment ||
                    this.Comment != null &&
                    this.Comment.Equals(other.Comment)
                ) && 
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) && 
                (
                    this.Feedback == other.Feedback ||
                    this.Feedback != null &&
                    this.Feedback.Equals(other.Feedback)
                ) && 
                (
                    this.MergedFromSuggestion == other.MergedFromSuggestion ||
                    this.MergedFromSuggestion != null &&
                    this.MergedFromSuggestion.Equals(other.MergedFromSuggestion)
                ) && 
                (
                    this.MergedToSuggestion == other.MergedToSuggestion ||
                    this.MergedToSuggestion != null &&
                    this.MergedToSuggestion.Equals(other.MergedToSuggestion)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.NewCategory == other.NewCategory ||
                    this.NewCategory != null &&
                    this.NewCategory.Equals(other.NewCategory)
                ) && 
                (
                    this.NewForum == other.NewForum ||
                    this.NewForum != null &&
                    this.NewForum.Equals(other.NewForum)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.OldCategory == other.OldCategory ||
                    this.OldCategory != null &&
                    this.OldCategory.Equals(other.OldCategory)
                ) && 
                (
                    this.OldForum == other.OldForum ||
                    this.OldForum != null &&
                    this.OldForum.Equals(other.OldForum)
                ) && 
                (
                    this.StatusUpdate == other.StatusUpdate ||
                    this.StatusUpdate != null &&
                    this.StatusUpdate.Equals(other.StatusUpdate)
                ) && 
                (
                    this.Suggestion == other.Suggestion ||
                    this.Suggestion != null &&
                    this.Suggestion.Equals(other.Suggestion)
                ) && 
                (
                    this.Ticket == other.Ticket ||
                    this.Ticket != null &&
                    this.Ticket.Equals(other.Ticket)
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
                if (this.Comment != null)
                    hash = hash * 59 + this.Comment.GetHashCode();
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                if (this.Feedback != null)
                    hash = hash * 59 + this.Feedback.GetHashCode();
                if (this.MergedFromSuggestion != null)
                    hash = hash * 59 + this.MergedFromSuggestion.GetHashCode();
                if (this.MergedToSuggestion != null)
                    hash = hash * 59 + this.MergedToSuggestion.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.NewCategory != null)
                    hash = hash * 59 + this.NewCategory.GetHashCode();
                if (this.NewForum != null)
                    hash = hash * 59 + this.NewForum.GetHashCode();
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                if (this.OldCategory != null)
                    hash = hash * 59 + this.OldCategory.GetHashCode();
                if (this.OldForum != null)
                    hash = hash * 59 + this.OldForum.GetHashCode();
                if (this.StatusUpdate != null)
                    hash = hash * 59 + this.StatusUpdate.GetHashCode();
                if (this.Suggestion != null)
                    hash = hash * 59 + this.Suggestion.GetHashCode();
                if (this.Ticket != null)
                    hash = hash * 59 + this.Ticket.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
