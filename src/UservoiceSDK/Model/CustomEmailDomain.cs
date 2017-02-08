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
    /// CustomEmailDomain
    /// </summary>
    [DataContract]
    public partial class CustomEmailDomain :  IEquatable<CustomEmailDomain>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEmailDomain" /> class.
        /// </summary>
        /// <param name="ConfirmedAt">ConfirmedAt.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="Domain">Domain.</param>
        /// <param name="Id">Id.</param>
        /// <param name="SpfRecord">SpfRecord.</param>
        /// <param name="UpdatedAt">UpdatedAt.</param>
        public CustomEmailDomain(DateTime? ConfirmedAt = null, DateTime? CreatedAt = null, string Domain = null, long? Id = null, string SpfRecord = null, DateTime? UpdatedAt = null)
        {
            this.ConfirmedAt = ConfirmedAt;
            this.CreatedAt = CreatedAt;
            this.Domain = Domain;
            this.Id = Id;
            this.SpfRecord = SpfRecord;
            this.UpdatedAt = UpdatedAt;
        }
        
        /// <summary>
        /// Gets or Sets ConfirmedAt
        /// </summary>
        [DataMember(Name="confirmed_at", EmitDefaultValue=false)]
        public DateTime? ConfirmedAt { get; set; }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }
        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
        /// <summary>
        /// Gets or Sets SpfRecord
        /// </summary>
        [DataMember(Name="spf_record", EmitDefaultValue=false)]
        public string SpfRecord { get; set; }
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
            sb.Append("class CustomEmailDomain {\n");
            sb.Append("  ConfirmedAt: ").Append(ConfirmedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SpfRecord: ").Append(SpfRecord).Append("\n");
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
            return this.Equals(obj as CustomEmailDomain);
        }

        /// <summary>
        /// Returns true if CustomEmailDomain instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomEmailDomain to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomEmailDomain other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ConfirmedAt == other.ConfirmedAt ||
                    this.ConfirmedAt != null &&
                    this.ConfirmedAt.Equals(other.ConfirmedAt)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.Domain == other.Domain ||
                    this.Domain != null &&
                    this.Domain.Equals(other.Domain)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.SpfRecord == other.SpfRecord ||
                    this.SpfRecord != null &&
                    this.SpfRecord.Equals(other.SpfRecord)
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
                if (this.ConfirmedAt != null)
                    hash = hash * 59 + this.ConfirmedAt.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.Domain != null)
                    hash = hash * 59 + this.Domain.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.SpfRecord != null)
                    hash = hash * 59 + this.SpfRecord.GetHashCode();
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
