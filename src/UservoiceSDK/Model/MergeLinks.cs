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
    /// MergeLinks
    /// </summary>
    [DataContract]
    public partial class MergeLinks :  IEquatable<MergeLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MergeLinks" /> class.
        /// </summary>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="FromSuggestion">FromSuggestion.</param>
        /// <param name="ToSuggestion">ToSuggestion.</param>
        public MergeLinks(long? CreatedBy = null, long? FromSuggestion = null, long? ToSuggestion = null)
        {
            this.CreatedBy = CreatedBy;
            this.FromSuggestion = FromSuggestion;
            this.ToSuggestion = ToSuggestion;
        }
        
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="created_by", EmitDefaultValue=false)]
        public long? CreatedBy { get; set; }
        /// <summary>
        /// Gets or Sets FromSuggestion
        /// </summary>
        [DataMember(Name="from_suggestion", EmitDefaultValue=false)]
        public long? FromSuggestion { get; set; }
        /// <summary>
        /// Gets or Sets ToSuggestion
        /// </summary>
        [DataMember(Name="to_suggestion", EmitDefaultValue=false)]
        public long? ToSuggestion { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeLinks {\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  FromSuggestion: ").Append(FromSuggestion).Append("\n");
            sb.Append("  ToSuggestion: ").Append(ToSuggestion).Append("\n");
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
            return this.Equals(obj as MergeLinks);
        }

        /// <summary>
        /// Returns true if MergeLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of MergeLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MergeLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) && 
                (
                    this.FromSuggestion == other.FromSuggestion ||
                    this.FromSuggestion != null &&
                    this.FromSuggestion.Equals(other.FromSuggestion)
                ) && 
                (
                    this.ToSuggestion == other.ToSuggestion ||
                    this.ToSuggestion != null &&
                    this.ToSuggestion.Equals(other.ToSuggestion)
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
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                if (this.FromSuggestion != null)
                    hash = hash * 59 + this.FromSuggestion.GetHashCode();
                if (this.ToSuggestion != null)
                    hash = hash * 59 + this.ToSuggestion.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
