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
    /// PermissionLinks
    /// </summary>
    [DataContract]
    public partial class PermissionLinks :  IEquatable<PermissionLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionLinks" /> class.
        /// </summary>
        /// <param name="Invitation">Invitation.</param>
        /// <param name="User">User.</param>
        public PermissionLinks(long? Invitation = null, long? User = null)
        {
            this.Invitation = Invitation;
            this.User = User;
        }
        
        /// <summary>
        /// Gets or Sets Invitation
        /// </summary>
        [DataMember(Name="invitation", EmitDefaultValue=false)]
        public long? Invitation { get; set; }
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
            sb.Append("class PermissionLinks {\n");
            sb.Append("  Invitation: ").Append(Invitation).Append("\n");
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
            return this.Equals(obj as PermissionLinks);
        }

        /// <summary>
        /// Returns true if PermissionLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of PermissionLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PermissionLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Invitation == other.Invitation ||
                    this.Invitation != null &&
                    this.Invitation.Equals(other.Invitation)
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
                if (this.Invitation != null)
                    hash = hash * 59 + this.Invitation.GetHashCode();
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