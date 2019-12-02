/* 
 * Apteco API
 *
 * An API to allow access to Apteco Marketing Suite resources
 *
 * OpenAPI spec version: v2
 * Contact: support@apteco.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Apteco.ApiDataAggregator.ApiClient.Client.SwaggerDateConverter;

namespace Apteco.ApiDataAggregator.ApiClient.Model
{
    /// <summary>
    /// Summary for a list composition
    /// </summary>
    [DataContract]
    public partial class CompositionSummary :  IEquatable<CompositionSummary>
    {
        /// <summary>
        /// The type of this composition
        /// </summary>
        /// <value>The type of this composition</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Check for value: Check
            /// </summary>
            [EnumMember(Value = "Check")]
            Check = 1,
            
            /// <summary>
            /// Enum Export for value: Export
            /// </summary>
            [EnumMember(Value = "Export")]
            Export = 2
        }

        /// <summary>
        /// The type of this composition
        /// </summary>
        /// <value>The type of this composition</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompositionSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CompositionSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompositionSummary" /> class.
        /// </summary>
        /// <param name="Id">The id of this composition (required).</param>
        /// <param name="Description">The description of this composition (required).</param>
        /// <param name="Type">The type of this composition (required).</param>
        /// <param name="SystemName">The name of the FastStats system that this composition is for (required).</param>
        public CompositionSummary(int? Id = default(int?), string Description = default(string), TypeEnum Type = default(TypeEnum), string SystemName = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for CompositionSummary and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for CompositionSummary and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for CompositionSummary and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "SystemName" is required (not null)
            if (SystemName == null)
            {
                throw new InvalidDataException("SystemName is a required property for CompositionSummary and cannot be null");
            }
            else
            {
                this.SystemName = SystemName;
            }
        }
        
        /// <summary>
        /// The id of this composition
        /// </summary>
        /// <value>The id of this composition</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The description of this composition
        /// </summary>
        /// <value>The description of this composition</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }


        /// <summary>
        /// The name of the FastStats system that this composition is for
        /// </summary>
        /// <value>The name of the FastStats system that this composition is for</value>
        [DataMember(Name="systemName", EmitDefaultValue=false)]
        public string SystemName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompositionSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SystemName: ").Append(SystemName).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CompositionSummary);
        }

        /// <summary>
        /// Returns true if CompositionSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of CompositionSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompositionSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.SystemName == input.SystemName ||
                    (this.SystemName != null &&
                    this.SystemName.Equals(input.SystemName))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SystemName != null)
                    hashCode = hashCode * 59 + this.SystemName.GetHashCode();
                return hashCode;
            }
        }
    }

}