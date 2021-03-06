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
    /// CustomerUser
    /// </summary>
    [DataContract]
    public partial class CustomerUser :  IEquatable<CustomerUser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerUser" /> class.
        /// </summary>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="CustCreatedAt">CustCreatedAt.</param>
        /// <param name="CustEmail">CustEmail.</param>
        /// <param name="CustIdentifier">CustIdentifier.</param>
        /// <param name="CustName">CustName.</param>
        /// <param name="CustTraits">CustTraits.</param>
        /// <param name="CustType">CustType.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Links">Links.</param>
        /// <param name="SubdomainId">SubdomainId.</param>
        /// <param name="UpdatedAt">UpdatedAt.</param>
        public CustomerUser(DateTime? CreatedAt = null, DateTime? CustCreatedAt = null, string CustEmail = null, string CustIdentifier = null, string CustName = null, string CustTraits = null, string CustType = null, long? Id = null, CustomerUserLinks Links = null, long? SubdomainId = null, DateTime? UpdatedAt = null)
        {
            this.CreatedAt = CreatedAt;
            this.CustCreatedAt = CustCreatedAt;
            this.CustEmail = CustEmail;
            this.CustIdentifier = CustIdentifier;
            this.CustName = CustName;
            this.CustTraits = CustTraits;
            this.CustType = CustType;
            this.Id = Id;
            this.Links = Links;
            this.SubdomainId = SubdomainId;
            this.UpdatedAt = UpdatedAt;
        }
        
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }
        /// <summary>
        /// Gets or Sets CustCreatedAt
        /// </summary>
        [DataMember(Name="cust_created_at", EmitDefaultValue=false)]
        public DateTime? CustCreatedAt { get; set; }
        /// <summary>
        /// Gets or Sets CustEmail
        /// </summary>
        [DataMember(Name="cust_email", EmitDefaultValue=false)]
        public string CustEmail { get; set; }
        /// <summary>
        /// Gets or Sets CustIdentifier
        /// </summary>
        [DataMember(Name="cust_identifier", EmitDefaultValue=false)]
        public string CustIdentifier { get; set; }
        /// <summary>
        /// Gets or Sets CustName
        /// </summary>
        [DataMember(Name="cust_name", EmitDefaultValue=false)]
        public string CustName { get; set; }
        /// <summary>
        /// Gets or Sets CustTraits
        /// </summary>
        [DataMember(Name="cust_traits", EmitDefaultValue=false)]
        public string CustTraits { get; set; }
        /// <summary>
        /// Gets or Sets CustType
        /// </summary>
        [DataMember(Name="cust_type", EmitDefaultValue=false)]
        public string CustType { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public CustomerUserLinks Links { get; set; }
        /// <summary>
        /// Gets or Sets SubdomainId
        /// </summary>
        [DataMember(Name="subdomain_id", EmitDefaultValue=false)]
        public long? SubdomainId { get; set; }
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
            sb.Append("class CustomerUser {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CustCreatedAt: ").Append(CustCreatedAt).Append("\n");
            sb.Append("  CustEmail: ").Append(CustEmail).Append("\n");
            sb.Append("  CustIdentifier: ").Append(CustIdentifier).Append("\n");
            sb.Append("  CustName: ").Append(CustName).Append("\n");
            sb.Append("  CustTraits: ").Append(CustTraits).Append("\n");
            sb.Append("  CustType: ").Append(CustType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  SubdomainId: ").Append(SubdomainId).Append("\n");
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
            return this.Equals(obj as CustomerUser);
        }

        /// <summary>
        /// Returns true if CustomerUser instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomerUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerUser other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.CustCreatedAt == other.CustCreatedAt ||
                    this.CustCreatedAt != null &&
                    this.CustCreatedAt.Equals(other.CustCreatedAt)
                ) && 
                (
                    this.CustEmail == other.CustEmail ||
                    this.CustEmail != null &&
                    this.CustEmail.Equals(other.CustEmail)
                ) && 
                (
                    this.CustIdentifier == other.CustIdentifier ||
                    this.CustIdentifier != null &&
                    this.CustIdentifier.Equals(other.CustIdentifier)
                ) && 
                (
                    this.CustName == other.CustName ||
                    this.CustName != null &&
                    this.CustName.Equals(other.CustName)
                ) && 
                (
                    this.CustTraits == other.CustTraits ||
                    this.CustTraits != null &&
                    this.CustTraits.Equals(other.CustTraits)
                ) && 
                (
                    this.CustType == other.CustType ||
                    this.CustType != null &&
                    this.CustType.Equals(other.CustType)
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
                    this.SubdomainId == other.SubdomainId ||
                    this.SubdomainId != null &&
                    this.SubdomainId.Equals(other.SubdomainId)
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
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.CustCreatedAt != null)
                    hash = hash * 59 + this.CustCreatedAt.GetHashCode();
                if (this.CustEmail != null)
                    hash = hash * 59 + this.CustEmail.GetHashCode();
                if (this.CustIdentifier != null)
                    hash = hash * 59 + this.CustIdentifier.GetHashCode();
                if (this.CustName != null)
                    hash = hash * 59 + this.CustName.GetHashCode();
                if (this.CustTraits != null)
                    hash = hash * 59 + this.CustTraits.GetHashCode();
                if (this.CustType != null)
                    hash = hash * 59 + this.CustType.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.SubdomainId != null)
                    hash = hash * 59 + this.SubdomainId.GetHashCode();
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
