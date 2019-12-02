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
    /// A row of data in the export results
    /// </summary>
    [DataContract]
    public partial class Row :  IEquatable<Row>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Row" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Row() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Row" /> class.
        /// </summary>
        /// <param name="Codes">A tab delimited list of variable codes for this row of the results.  There should be one value per column.  If the value of the item in the tab delimited list for a particular column is empty then the description  for the corresponding column should be used as the code. (required).</param>
        /// <param name="Descriptions">A tab delimited list of variable descriptions for this row of the results.  There should be one value per column (required).</param>
        public Row(string Codes = default(string), string Descriptions = default(string))
        {
            // to ensure "Codes" is required (not null)
            if (Codes == null)
            {
                throw new InvalidDataException("Codes is a required property for Row and cannot be null");
            }
            else
            {
                this.Codes = Codes;
            }
            // to ensure "Descriptions" is required (not null)
            if (Descriptions == null)
            {
                throw new InvalidDataException("Descriptions is a required property for Row and cannot be null");
            }
            else
            {
                this.Descriptions = Descriptions;
            }
        }
        
        /// <summary>
        /// A tab delimited list of variable codes for this row of the results.  There should be one value per column.  If the value of the item in the tab delimited list for a particular column is empty then the description  for the corresponding column should be used as the code.
        /// </summary>
        /// <value>A tab delimited list of variable codes for this row of the results.  There should be one value per column.  If the value of the item in the tab delimited list for a particular column is empty then the description  for the corresponding column should be used as the code.</value>
        [DataMember(Name="codes", EmitDefaultValue=false)]
        public string Codes { get; set; }

        /// <summary>
        /// A tab delimited list of variable descriptions for this row of the results.  There should be one value per column
        /// </summary>
        /// <value>A tab delimited list of variable descriptions for this row of the results.  There should be one value per column</value>
        [DataMember(Name="descriptions", EmitDefaultValue=false)]
        public string Descriptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Row {\n");
            sb.Append("  Codes: ").Append(Codes).Append("\n");
            sb.Append("  Descriptions: ").Append(Descriptions).Append("\n");
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
            return this.Equals(input as Row);
        }

        /// <summary>
        /// Returns true if Row instances are equal
        /// </summary>
        /// <param name="input">Instance of Row to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Row input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Codes == input.Codes ||
                    (this.Codes != null &&
                    this.Codes.Equals(input.Codes))
                ) && 
                (
                    this.Descriptions == input.Descriptions ||
                    (this.Descriptions != null &&
                    this.Descriptions.Equals(input.Descriptions))
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
                if (this.Codes != null)
                    hashCode = hashCode * 59 + this.Codes.GetHashCode();
                if (this.Descriptions != null)
                    hashCode = hashCode * 59 + this.Descriptions.GetHashCode();
                return hashCode;
            }
        }
    }

}
