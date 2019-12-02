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
    /// RFVRecency
    /// </summary>
    [DataContract]
    public partial class RFVRecency :  IEquatable<RFVRecency>
    {
        /// <summary>
        /// Defines Direction
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectionEnum
        {
            
            /// <summary>
            /// Enum Any for value: Any
            /// </summary>
            [EnumMember(Value = "Any")]
            Any = 1,
            
            /// <summary>
            /// Enum First for value: First
            /// </summary>
            [EnumMember(Value = "First")]
            First = 2,
            
            /// <summary>
            /// Enum Last for value: Last
            /// </summary>
            [EnumMember(Value = "Last")]
            Last = 3,
            
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 4
        }

        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RFVRecency" /> class.
        /// </summary>
        /// <param name="VariableName">VariableName.</param>
        /// <param name="Sequence">Sequence.</param>
        /// <param name="Direction">Direction.</param>
        /// <param name="Value">Value.</param>
        /// <param name="Distinct">Distinct.</param>
        public RFVRecency(string VariableName = default(string), string Sequence = default(string), DirectionEnum? Direction = default(DirectionEnum?), int? Value = default(int?), bool? Distinct = default(bool?))
        {
            this.VariableName = VariableName;
            this.Sequence = Sequence;
            this.Direction = Direction;
            this.Value = Value;
            this.Distinct = Distinct;
        }
        
        /// <summary>
        /// Gets or Sets VariableName
        /// </summary>
        [DataMember(Name="variableName", EmitDefaultValue=false)]
        public string VariableName { get; set; }

        /// <summary>
        /// Gets or Sets Sequence
        /// </summary>
        [DataMember(Name="sequence", EmitDefaultValue=false)]
        public string Sequence { get; set; }


        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public int? Value { get; set; }

        /// <summary>
        /// Gets or Sets Distinct
        /// </summary>
        [DataMember(Name="distinct", EmitDefaultValue=false)]
        public bool? Distinct { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RFVRecency {\n");
            sb.Append("  VariableName: ").Append(VariableName).Append("\n");
            sb.Append("  Sequence: ").Append(Sequence).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Distinct: ").Append(Distinct).Append("\n");
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
            return this.Equals(input as RFVRecency);
        }

        /// <summary>
        /// Returns true if RFVRecency instances are equal
        /// </summary>
        /// <param name="input">Instance of RFVRecency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RFVRecency input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VariableName == input.VariableName ||
                    (this.VariableName != null &&
                    this.VariableName.Equals(input.VariableName))
                ) && 
                (
                    this.Sequence == input.Sequence ||
                    (this.Sequence != null &&
                    this.Sequence.Equals(input.Sequence))
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Distinct == input.Distinct ||
                    (this.Distinct != null &&
                    this.Distinct.Equals(input.Distinct))
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
                if (this.VariableName != null)
                    hashCode = hashCode * 59 + this.VariableName.GetHashCode();
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Distinct != null)
                    hashCode = hashCode * 59 + this.Distinct.GetHashCode();
                return hashCode;
            }
        }
    }

}
