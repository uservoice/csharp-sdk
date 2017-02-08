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
    /// FeedbackResponse
    /// </summary>
    [DataContract]
    public partial class FeedbackResponse :  IEquatable<FeedbackResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackResponse" /> class.
        /// </summary>
        /// <param name="Feedback">Feedback.</param>
        /// <param name="Suggestions">Suggestions.</param>
        /// <param name="Supporters">Supporters.</param>
        /// <param name="Tickets">Tickets.</param>
        /// <param name="Users">Users.</param>
        public FeedbackResponse(List<Feedback> Feedback = null, List<Suggestion> Suggestions = null, List<Supporter> Supporters = null, List<Ticket> Tickets = null, List<User> Users = null)
        {
            this.Feedback = Feedback;
            this.Suggestions = Suggestions;
            this.Supporters = Supporters;
            this.Tickets = Tickets;
            this.Users = Users;
        }
        
        /// <summary>
        /// Gets or Sets Feedback
        /// </summary>
        [DataMember(Name="feedback", EmitDefaultValue=false)]
        public List<Feedback> Feedback { get; set; }
        /// <summary>
        /// Gets or Sets Suggestions
        /// </summary>
        [DataMember(Name="suggestions", EmitDefaultValue=false)]
        public List<Suggestion> Suggestions { get; set; }
        /// <summary>
        /// Gets or Sets Supporters
        /// </summary>
        [DataMember(Name="supporters", EmitDefaultValue=false)]
        public List<Supporter> Supporters { get; set; }
        /// <summary>
        /// Gets or Sets Tickets
        /// </summary>
        [DataMember(Name="tickets", EmitDefaultValue=false)]
        public List<Ticket> Tickets { get; set; }
        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<User> Users { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeedbackResponse {\n");
            sb.Append("  Feedback: ").Append(Feedback).Append("\n");
            sb.Append("  Suggestions: ").Append(Suggestions).Append("\n");
            sb.Append("  Supporters: ").Append(Supporters).Append("\n");
            sb.Append("  Tickets: ").Append(Tickets).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
            return this.Equals(obj as FeedbackResponse);
        }

        /// <summary>
        /// Returns true if FeedbackResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of FeedbackResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeedbackResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Feedback == other.Feedback ||
                    this.Feedback != null &&
                    this.Feedback.SequenceEqual(other.Feedback)
                ) && 
                (
                    this.Suggestions == other.Suggestions ||
                    this.Suggestions != null &&
                    this.Suggestions.SequenceEqual(other.Suggestions)
                ) && 
                (
                    this.Supporters == other.Supporters ||
                    this.Supporters != null &&
                    this.Supporters.SequenceEqual(other.Supporters)
                ) && 
                (
                    this.Tickets == other.Tickets ||
                    this.Tickets != null &&
                    this.Tickets.SequenceEqual(other.Tickets)
                ) && 
                (
                    this.Users == other.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(other.Users)
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
                if (this.Feedback != null)
                    hash = hash * 59 + this.Feedback.GetHashCode();
                if (this.Suggestions != null)
                    hash = hash * 59 + this.Suggestions.GetHashCode();
                if (this.Supporters != null)
                    hash = hash * 59 + this.Supporters.GetHashCode();
                if (this.Tickets != null)
                    hash = hash * 59 + this.Tickets.GetHashCode();
                if (this.Users != null)
                    hash = hash * 59 + this.Users.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
