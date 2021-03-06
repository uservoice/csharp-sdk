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
    /// FeedbackRankingLinks
    /// </summary>
    [DataContract]
    public partial class FeedbackRankingLinks :  IEquatable<FeedbackRankingLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackRankingLinks" /> class.
        /// </summary>
        /// <param name="Suggestion">Suggestion.</param>
        public FeedbackRankingLinks(long? Suggestion = null)
        {
            this.Suggestion = Suggestion;
        }
        
        /// <summary>
        /// Gets or Sets Suggestion
        /// </summary>
        [DataMember(Name="suggestion", EmitDefaultValue=false)]
        public long? Suggestion { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeedbackRankingLinks {\n");
            sb.Append("  Suggestion: ").Append(Suggestion).Append("\n");
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
            return this.Equals(obj as FeedbackRankingLinks);
        }

        /// <summary>
        /// Returns true if FeedbackRankingLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of FeedbackRankingLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeedbackRankingLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Suggestion == other.Suggestion ||
                    this.Suggestion != null &&
                    this.Suggestion.Equals(other.Suggestion)
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
                if (this.Suggestion != null)
                    hash = hash * 59 + this.Suggestion.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
