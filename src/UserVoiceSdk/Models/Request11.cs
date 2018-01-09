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
    /// Request11
    /// </summary>
    [DataContract]
    public partial class Request11 :  IEquatable<Request11>, IValidatableObject
    {
        /// <summary>
        /// boolean: True or False value. Sortable.   timestamp: datetime value, 2000-01-01T00:00:00Z or 2006-01-02 15:04:05 format. Sortable.   string: String value; 128 or fewer characters. Sortable.   text: Text value; 10,000 or fewer characters. Not sortable.   number: Number value. 15 or fewer digits. All numbers are processed as 64-bit floating-point numbers. Sortable.
        /// </summary>
        /// <value>boolean: True or False value. Sortable.   timestamp: datetime value, 2000-01-01T00:00:00Z or 2006-01-02 15:04:05 format. Sortable.   string: String value; 128 or fewer characters. Sortable.   text: Text value; 10,000 or fewer characters. Not sortable.   number: Number value. 15 or fewer digits. All numbers are processed as 64-bit floating-point numbers. Sortable.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FieldTypeEnum
        {
            
            /// <summary>
            /// Enum Boolean for "boolean"
            /// </summary>
            [EnumMember(Value = "boolean")]
            Boolean,
            
            /// <summary>
            /// Enum Timestamp for "timestamp"
            /// </summary>
            [EnumMember(Value = "timestamp")]
            Timestamp,
            
            /// <summary>
            /// Enum String for "string"
            /// </summary>
            [EnumMember(Value = "string")]
            String,
            
            /// <summary>
            /// Enum Text for "text"
            /// </summary>
            [EnumMember(Value = "text")]
            Text,
            
            /// <summary>
            /// Enum Number for "number"
            /// </summary>
            [EnumMember(Value = "number")]
            Number
        }

        /// <summary>
        /// Gets or Sets ObjectType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectTypeEnum
        {
            
            /// <summary>
            /// Enum Externalusers for "external_users"
            /// </summary>
            [EnumMember(Value = "external_users")]
            Externalusers,
            
            /// <summary>
            /// Enum Externalaccounts for "external_accounts"
            /// </summary>
            [EnumMember(Value = "external_accounts")]
            Externalaccounts,
            
            /// <summary>
            /// Enum Features for "features"
            /// </summary>
            [EnumMember(Value = "features")]
            Features
        }

        /// <summary>
        /// boolean: True or False value. Sortable.   timestamp: datetime value, 2000-01-01T00:00:00Z or 2006-01-02 15:04:05 format. Sortable.   string: String value; 128 or fewer characters. Sortable.   text: Text value; 10,000 or fewer characters. Not sortable.   number: Number value. 15 or fewer digits. All numbers are processed as 64-bit floating-point numbers. Sortable.
        /// </summary>
        /// <value>boolean: True or False value. Sortable.   timestamp: datetime value, 2000-01-01T00:00:00Z or 2006-01-02 15:04:05 format. Sortable.   string: String value; 128 or fewer characters. Sortable.   text: Text value; 10,000 or fewer characters. Not sortable.   number: Number value. 15 or fewer digits. All numbers are processed as 64-bit floating-point numbers. Sortable.</value>
        [DataMember(Name="field_type", EmitDefaultValue=false)]
        public FieldTypeEnum? FieldType { get; set; }
        /// <summary>
        /// Gets or Sets ObjectType
        /// </summary>
        [DataMember(Name="object_type", EmitDefaultValue=false)]
        public ObjectTypeEnum? ObjectType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Request11" /> class.
        /// </summary>
        /// <param name="FieldType">boolean: True or False value. Sortable.   timestamp: datetime value, 2000-01-01T00:00:00Z or 2006-01-02 15:04:05 format. Sortable.   string: String value; 128 or fewer characters. Sortable.   text: Text value; 10,000 or fewer characters. Not sortable.   number: Number value. 15 or fewer digits. All numbers are processed as 64-bit floating-point numbers. Sortable..</param>
        /// <param name="Key">Key.</param>
        /// <param name="Name">Name.</param>
        /// <param name="ObjectType">ObjectType.</param>
        public Request11(FieldTypeEnum? FieldType = null, string Key = null, string Name = null, ObjectTypeEnum? ObjectType = null)
        {
            this.FieldType = FieldType;
            this.Key = Key;
            this.Name = Name;
            this.ObjectType = ObjectType;
        }
        
        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }
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
            sb.Append("class Request11 {\n");
            sb.Append("  FieldType: ").Append(FieldType).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
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
            return this.Equals(obj as Request11);
        }

        /// <summary>
        /// Returns true if Request11 instances are equal
        /// </summary>
        /// <param name="other">Instance of Request11 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Request11 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FieldType == other.FieldType ||
                    this.FieldType != null &&
                    this.FieldType.Equals(other.FieldType)
                ) && 
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.ObjectType == other.ObjectType ||
                    this.ObjectType != null &&
                    this.ObjectType.Equals(other.ObjectType)
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
                if (this.FieldType != null)
                    hash = hash * 59 + this.FieldType.GetHashCode();
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.ObjectType != null)
                    hash = hash * 59 + this.ObjectType.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // Key (string) pattern
            Regex regexKey = new Regex(@"^cf_[0-9A-Za-z_]+", RegexOptions.CultureInvariant);
            if (false == regexKey.Match(this.Key).Success)
            {
                yield return new ValidationResult("Invalid value for Key, must match a pattern of /^cf_[0-9A-Za-z_]+/.", new [] { "Key" });
            }

            yield break;
        }
    }

}