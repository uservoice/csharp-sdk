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
    /// ExternalAccountsImportRequest
    /// </summary>
    [DataContract]
    public partial class ExternalAccountsImportRequest :  IEquatable<ExternalAccountsImportRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalAccountsImportRequest" /> class.
        /// </summary>
        /// <param name="Accounts">Accounts.</param>
        public ExternalAccountsImportRequest(List<RequestExternalAccount> Accounts = null)
        {
            this.Accounts = Accounts;
        }
        
        /// <summary>
        /// Gets or Sets Accounts
        /// </summary>
        [DataMember(Name="accounts", EmitDefaultValue=false)]
        public List<RequestExternalAccount> Accounts { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalAccountsImportRequest {\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
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
            return this.Equals(obj as ExternalAccountsImportRequest);
        }

        /// <summary>
        /// Returns true if ExternalAccountsImportRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalAccountsImportRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalAccountsImportRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Accounts == other.Accounts ||
                    this.Accounts != null &&
                    this.Accounts.SequenceEqual(other.Accounts)
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
                if (this.Accounts != null)
                    hash = hash * 59 + this.Accounts.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}