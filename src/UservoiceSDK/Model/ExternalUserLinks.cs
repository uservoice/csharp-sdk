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
    /// ExternalUserLinks
    /// </summary>
    [DataContract]
    public partial class ExternalUserLinks :  IEquatable<ExternalUserLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalUserLinks" /> class.
        /// </summary>
        /// <param name="ExternalAccount">ExternalAccount.</param>
        /// <param name="User">User.</param>
        public ExternalUserLinks(long? ExternalAccount = null, long? User = null)
        {
            this.ExternalAccount = ExternalAccount;
            this.User = User;
        }
        
        /// <summary>
        /// Gets or Sets ExternalAccount
        /// </summary>
        [DataMember(Name="external_account", EmitDefaultValue=false)]
        public long? ExternalAccount { get; set; }
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public long? User { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalUserLinks {\n");
            sb.Append("  ExternalAccount: ").Append(ExternalAccount).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(obj as ExternalUserLinks);
        }

        /// <summary>
        /// Returns true if ExternalUserLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalUserLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalUserLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ExternalAccount == other.ExternalAccount ||
                    this.ExternalAccount != null &&
                    this.ExternalAccount.Equals(other.ExternalAccount)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                if (this.ExternalAccount != null)
                    hash = hash * 59 + this.ExternalAccount.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
