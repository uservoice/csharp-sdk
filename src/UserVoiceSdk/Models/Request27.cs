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
    /// Request27
    /// </summary>
    [DataContract]
    public partial class Request27 :  IEquatable<Request27>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Includes
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IncludesEnum
        {
            
            /// <summary>
            /// Enum Forums for "forums"
            /// </summary>
            [EnumMember(Value = "forums")]
            Forums,
            
            /// <summary>
            /// Enum Users for "users"
            /// </summary>
            [EnumMember(Value = "users")]
            Users
        }

        /// <summary>
        /// Gets or Sets Includes
        /// </summary>
        [DataMember(Name="includes", EmitDefaultValue=false)]
        public List<IncludesEnum> Includes { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Request27" /> class.
        /// </summary>
        /// <param name="Includes">Includes.</param>
        /// <param name="Links">Links.</param>
        /// <param name="Name">Name.</param>
        public Request27(List<IncludesEnum> Includes = null, AdminlabelsLinks Links = null, string Name = null)
        {
            this.Includes = Includes;
            this.Links = Links;
            this.Name = Name;
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public AdminlabelsLinks Links { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Request27 {\n");
            sb.Append("  Includes: ").Append(Includes).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as Request27);
        }

        /// <summary>
        /// Returns true if Request27 instances are equal
        /// </summary>
        /// <param name="other">Instance of Request27 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Request27 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Includes == other.Includes ||
                    this.Includes != null &&
                    this.Includes.SequenceEqual(other.Includes)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.Includes != null)
                    hash = hash * 59 + this.Includes.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 128)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 128.", new [] { "Name" });
            }

            yield break;
        }
    }

}
