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
    /// Details for the definition of a composition for the list check screen
    /// </summary>
    [DataContract]
    public partial class CheckCompositionDefinition :  IEquatable<CheckCompositionDefinition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckCompositionDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CheckCompositionDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckCompositionDefinition" /> class.
        /// </summary>
        /// <param name="DashboardItems">The set of dashboard items to show in this composition (required).</param>
        /// <param name="GridItems">The set of grid items to show in this composition (required).</param>
        public CheckCompositionDefinition(List<DashboardItem> DashboardItems = default(List<DashboardItem>), List<GridItem> GridItems = default(List<GridItem>))
        {
            // to ensure "DashboardItems" is required (not null)
            if (DashboardItems == null)
            {
                throw new InvalidDataException("DashboardItems is a required property for CheckCompositionDefinition and cannot be null");
            }
            else
            {
                this.DashboardItems = DashboardItems;
            }
            // to ensure "GridItems" is required (not null)
            if (GridItems == null)
            {
                throw new InvalidDataException("GridItems is a required property for CheckCompositionDefinition and cannot be null");
            }
            else
            {
                this.GridItems = GridItems;
            }
        }
        
        /// <summary>
        /// The set of dashboard items to show in this composition
        /// </summary>
        /// <value>The set of dashboard items to show in this composition</value>
        [DataMember(Name="dashboardItems", EmitDefaultValue=false)]
        public List<DashboardItem> DashboardItems { get; set; }

        /// <summary>
        /// The set of grid items to show in this composition
        /// </summary>
        /// <value>The set of grid items to show in this composition</value>
        [DataMember(Name="gridItems", EmitDefaultValue=false)]
        public List<GridItem> GridItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckCompositionDefinition {\n");
            sb.Append("  DashboardItems: ").Append(DashboardItems).Append("\n");
            sb.Append("  GridItems: ").Append(GridItems).Append("\n");
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
            return this.Equals(input as CheckCompositionDefinition);
        }

        /// <summary>
        /// Returns true if CheckCompositionDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckCompositionDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckCompositionDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DashboardItems == input.DashboardItems ||
                    this.DashboardItems != null &&
                    this.DashboardItems.SequenceEqual(input.DashboardItems)
                ) && 
                (
                    this.GridItems == input.GridItems ||
                    this.GridItems != null &&
                    this.GridItems.SequenceEqual(input.GridItems)
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
                if (this.DashboardItems != null)
                    hashCode = hashCode * 59 + this.DashboardItems.GetHashCode();
                if (this.GridItems != null)
                    hashCode = hashCode * 59 + this.GridItems.GetHashCode();
                return hashCode;
            }
        }
    }

}
