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
    /// ExternalAccountResponsePaginated
    /// </summary>
    [DataContract]
    public partial class ExternalAccountResponsePaginated :  IEquatable<ExternalAccountResponsePaginated>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalAccountResponsePaginated" /> class.
        /// </summary>
        /// <param name="ExternalAccounts">ExternalAccounts.</param>
        /// <param name="Pagination">Pagination.</param>
        public ExternalAccountResponsePaginated(List<ExternalAccount> ExternalAccounts = null, Pagination Pagination = null)
        {
            this.ExternalAccounts = ExternalAccounts;
            this.Pagination = Pagination;
        }
        
        /// <summary>
        /// Gets or Sets ExternalAccounts
        /// </summary>
        [DataMember(Name="external_accounts", EmitDefaultValue=false)]
        public List<ExternalAccount> ExternalAccounts { get; set; }
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
            sb.Append("class ExternalAccountResponsePaginated {\n");
            sb.Append("  ExternalAccounts: ").Append(ExternalAccounts).Append("\n");
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
            return this.Equals(obj as ExternalAccountResponsePaginated);
        }

        /// <summary>
        /// Returns true if ExternalAccountResponsePaginated instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalAccountResponsePaginated to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalAccountResponsePaginated other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ExternalAccounts == other.ExternalAccounts ||
                    this.ExternalAccounts != null &&
                    this.ExternalAccounts.SequenceEqual(other.ExternalAccounts)
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
                if (this.ExternalAccounts != null)
                    hash = hash * 59 + this.ExternalAccounts.GetHashCode();
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