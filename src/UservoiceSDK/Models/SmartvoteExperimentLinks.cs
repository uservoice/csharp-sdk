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
    /// SmartvoteExperimentLinks
    /// </summary>
    [DataContract]
    public partial class SmartvoteExperimentLinks :  IEquatable<SmartvoteExperimentLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmartvoteExperimentLinks" /> class.
        /// </summary>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="Forum">Forum.</param>
        public SmartvoteExperimentLinks(long? CreatedBy = null, long? Forum = null)
        {
            this.CreatedBy = CreatedBy;
            this.Forum = Forum;
        }
        
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="created_by", EmitDefaultValue=false)]
        public long? CreatedBy { get; set; }
        /// <summary>
        /// Gets or Sets Forum
        /// </summary>
        [DataMember(Name="forum", EmitDefaultValue=false)]
        public long? Forum { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartvoteExperimentLinks {\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Forum: ").Append(Forum).Append("\n");
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
            return this.Equals(obj as SmartvoteExperimentLinks);
        }

        /// <summary>
        /// Returns true if SmartvoteExperimentLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of SmartvoteExperimentLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmartvoteExperimentLinks other)
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
                    this.Forum == other.Forum ||
                    this.Forum != null &&
                    this.Forum.Equals(other.Forum)
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
                if (this.Forum != null)
                    hash = hash * 59 + this.Forum.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
