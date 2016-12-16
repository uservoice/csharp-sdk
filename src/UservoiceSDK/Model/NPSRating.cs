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
    /// NPSRating
    /// </summary>
    [DataContract]
    public partial class NPSRating :  IEquatable<NPSRating>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NPSRating" /> class.
        /// </summary>
        /// <param name="Body">Body.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="Group">Group.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Links">Links.</param>
        /// <param name="PreviousRating">PreviousRating.</param>
        /// <param name="Prompt">Prompt.</param>
        /// <param name="Rating">Rating.</param>
        /// <param name="RatingDelta">RatingDelta.</param>
        /// <param name="UpdatedAt">UpdatedAt.</param>
        public NPSRating(string Body = null, DateTime? CreatedAt = null, string Group = null, long? Id = null, NPSRatingLinks Links = null, long? PreviousRating = null, string Prompt = null, long? Rating = null, long? RatingDelta = null, DateTime? UpdatedAt = null)
        {
            this.Body = Body;
            this.CreatedAt = CreatedAt;
            this.Group = Group;
            this.Id = Id;
            this.Links = Links;
            this.PreviousRating = PreviousRating;
            this.Prompt = Prompt;
            this.Rating = Rating;
            this.RatingDelta = RatingDelta;
            this.UpdatedAt = UpdatedAt;
        }
        
        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }
        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public string Group { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public NPSRatingLinks Links { get; set; }
        /// <summary>
        /// Gets or Sets PreviousRating
        /// </summary>
        [DataMember(Name="previous_rating", EmitDefaultValue=false)]
        public long? PreviousRating { get; set; }
        /// <summary>
        /// Gets or Sets Prompt
        /// </summary>
        [DataMember(Name="prompt", EmitDefaultValue=false)]
        public string Prompt { get; set; }
        /// <summary>
        /// Gets or Sets Rating
        /// </summary>
        [DataMember(Name="rating", EmitDefaultValue=false)]
        public long? Rating { get; set; }
        /// <summary>
        /// Gets or Sets RatingDelta
        /// </summary>
        [DataMember(Name="rating_delta", EmitDefaultValue=false)]
        public long? RatingDelta { get; set; }
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
            sb.Append("class NPSRating {\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  PreviousRating: ").Append(PreviousRating).Append("\n");
            sb.Append("  Prompt: ").Append(Prompt).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  RatingDelta: ").Append(RatingDelta).Append("\n");
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
            return this.Equals(obj as NPSRating);
        }

        /// <summary>
        /// Returns true if NPSRating instances are equal
        /// </summary>
        /// <param name="other">Instance of NPSRating to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NPSRating other)
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
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
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
                    this.PreviousRating == other.PreviousRating ||
                    this.PreviousRating != null &&
                    this.PreviousRating.Equals(other.PreviousRating)
                ) && 
                (
                    this.Prompt == other.Prompt ||
                    this.Prompt != null &&
                    this.Prompt.Equals(other.Prompt)
                ) && 
                (
                    this.Rating == other.Rating ||
                    this.Rating != null &&
                    this.Rating.Equals(other.Rating)
                ) && 
                (
                    this.RatingDelta == other.RatingDelta ||
                    this.RatingDelta != null &&
                    this.RatingDelta.Equals(other.RatingDelta)
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
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.PreviousRating != null)
                    hash = hash * 59 + this.PreviousRating.GetHashCode();
                if (this.Prompt != null)
                    hash = hash * 59 + this.Prompt.GetHashCode();
                if (this.Rating != null)
                    hash = hash * 59 + this.Rating.GetHashCode();
                if (this.RatingDelta != null)
                    hash = hash * 59 + this.RatingDelta.GetHashCode();
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
