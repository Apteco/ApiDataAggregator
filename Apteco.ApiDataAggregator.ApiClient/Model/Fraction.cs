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
    /// Fraction
    /// </summary>
    [DataContract]
    public partial class Fraction :  IEquatable<Fraction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Fraction" /> class.
        /// </summary>
        /// <param name="Numerator">Numerator.</param>
        /// <param name="Denominator">Denominator.</param>
        public Fraction(int? Numerator = default(int?), int? Denominator = default(int?))
        {
            this.Numerator = Numerator;
            this.Denominator = Denominator;
        }
        
        /// <summary>
        /// Gets or Sets Numerator
        /// </summary>
        [DataMember(Name="numerator", EmitDefaultValue=false)]
        public int? Numerator { get; set; }

        /// <summary>
        /// Gets or Sets Denominator
        /// </summary>
        [DataMember(Name="denominator", EmitDefaultValue=false)]
        public int? Denominator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Fraction {\n");
            sb.Append("  Numerator: ").Append(Numerator).Append("\n");
            sb.Append("  Denominator: ").Append(Denominator).Append("\n");
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
            return this.Equals(input as Fraction);
        }

        /// <summary>
        /// Returns true if Fraction instances are equal
        /// </summary>
        /// <param name="input">Instance of Fraction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Fraction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Numerator == input.Numerator ||
                    (this.Numerator != null &&
                    this.Numerator.Equals(input.Numerator))
                ) && 
                (
                    this.Denominator == input.Denominator ||
                    (this.Denominator != null &&
                    this.Denominator.Equals(input.Denominator))
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
                if (this.Numerator != null)
                    hashCode = hashCode * 59 + this.Numerator.GetHashCode();
                if (this.Denominator != null)
                    hashCode = hashCode * 59 + this.Denominator.GetHashCode();
                return hashCode;
            }
        }
    }

}
