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
    /// StatusResponsePaginated
    /// </summary>
    [DataContract]
    public partial class StatusResponsePaginated :  IEquatable<StatusResponsePaginated>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusResponsePaginated" /> class.
        /// </summary>
        /// <param name="Statuses">Statuses.</param>
        /// <param name="Pagination">Pagination.</param>
        public StatusResponsePaginated(List<Status> Statuses = null, Pagination Pagination = null)
        {
            this.Statuses = Statuses;
            this.Pagination = Pagination;
        }
        
        /// <summary>
        /// Gets or Sets Statuses
        /// </summary>
        [DataMember(Name="statuses", EmitDefaultValue=false)]
        public List<Status> Statuses { get; set; }
        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name="pagination", EmitDefaultValue=false)]
        public Pagination Pagination { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusResponsePaginated {\n");
            sb.Append("  Statuses: ").Append(Statuses).Append("\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
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
            return this.Equals(obj as StatusResponsePaginated);
        }

        /// <summary>
        /// Returns true if StatusResponsePaginated instances are equal
        /// </summary>
        /// <param name="other">Instance of StatusResponsePaginated to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusResponsePaginated other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Statuses == other.Statuses ||
                    this.Statuses != null &&
                    this.Statuses.SequenceEqual(other.Statuses)
                ) && 
                (
                    this.Pagination == other.Pagination ||
                    this.Pagination != null &&
                    this.Pagination.Equals(other.Pagination)
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
                if (this.Statuses != null)
                    hash = hash * 59 + this.Statuses.GetHashCode();
                if (this.Pagination != null)
                    hash = hash * 59 + this.Pagination.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
