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
    /// Request34
    /// </summary>
    [DataContract]
    public partial class Request34 :  IEquatable<Request34>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Includes
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IncludesEnum
        {
            
            /// <summary>
            /// Enum Suggestions for "suggestions"
            /// </summary>
            [EnumMember(Value = "suggestions")]
            Suggestions,
            
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
        /// Initializes a new instance of the <see cref="Request34" /> class.
        /// </summary>
        /// <param name="Body">Body.</param>
        /// <param name="Includes">Includes.</param>
        public Request34(string Body = null, List<IncludesEnum> Includes = null)
        {
            this.Body = Body;
            this.Includes = Includes;
        }
        
        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Request34 {\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Includes: ").Append(Includes).Append("\n");
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
            return this.Equals(obj as Request34);
        }

        /// <summary>
        /// Returns true if Request34 instances are equal
        /// </summary>
        /// <param name="other">Instance of Request34 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Request34 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Body == other.Body ||
                    this.Body != null &&
                    this.Body.Equals(other.Body)
                ) && 
                (
                    this.Includes == other.Includes ||
                    this.Includes != null &&
                    this.Includes.SequenceEqual(other.Includes)
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
                if (this.Body != null)
                    hash = hash * 59 + this.Body.GetHashCode();
                if (this.Includes != null)
                    hash = hash * 59 + this.Includes.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
