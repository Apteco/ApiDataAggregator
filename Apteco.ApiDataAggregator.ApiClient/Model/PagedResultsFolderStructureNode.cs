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
    /// Summary details for a user
    /// </summary>
    [DataContract]
    public partial class PagedResultsFolderStructureNode :  IEquatable<PagedResultsFolderStructureNode>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PagedResultsFolderStructureNode" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PagedResultsFolderStructureNode() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PagedResultsFolderStructureNode" /> class.
        /// </summary>
        /// <param name="Offset">The number of items that were skipped over from the (potentially filtered) result set (required).</param>
        /// <param name="Count">The number of items returned in this page of the result set (required).</param>
        /// <param name="TotalCount">The total number of items available in the (potentially filtered) result set (required).</param>
        /// <param name="List">The list of results (required).</param>
        public PagedResultsFolderStructureNode(int? Offset = default(int?), int? Count = default(int?), int? TotalCount = default(int?), List<FolderStructureNode> List = default(List<FolderStructureNode>))
        {
            // to ensure "Offset" is required (not null)
            if (Offset == null)
            {
                throw new InvalidDataException("Offset is a required property for PagedResultsFolderStructureNode and cannot be null");
            }
            else
            {
                this.Offset = Offset;
            }
            // to ensure "Count" is required (not null)
            if (Count == null)
            {
                throw new InvalidDataException("Count is a required property for PagedResultsFolderStructureNode and cannot be null");
            }
            else
            {
                this.Count = Count;
            }
            // to ensure "TotalCount" is required (not null)
            if (TotalCount == null)
            {
                throw new InvalidDataException("TotalCount is a required property for PagedResultsFolderStructureNode and cannot be null");
            }
            else
            {
                this.TotalCount = TotalCount;
            }
            // to ensure "List" is required (not null)
            if (List == null)
            {
                throw new InvalidDataException("List is a required property for PagedResultsFolderStructureNode and cannot be null");
            }
            else
            {
                this.List = List;
            }
        }
        
        /// <summary>
        /// The number of items that were skipped over from the (potentially filtered) result set
        /// </summary>
        /// <value>The number of items that were skipped over from the (potentially filtered) result set</value>
        [DataMember(Name="offset", EmitDefaultValue=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// The number of items returned in this page of the result set
        /// </summary>
        /// <value>The number of items returned in this page of the result set</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The total number of items available in the (potentially filtered) result set
        /// </summary>
        /// <value>The total number of items available in the (potentially filtered) result set</value>
        [DataMember(Name="totalCount", EmitDefaultValue=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The list of results
        /// </summary>
        /// <value>The list of results</value>
        [DataMember(Name="list", EmitDefaultValue=false)]
        public List<FolderStructureNode> List { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PagedResultsFolderStructureNode {\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  List: ").Append(List).Append("\n");
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
            return this.Equals(input as PagedResultsFolderStructureNode);
        }

        /// <summary>
        /// Returns true if PagedResultsFolderStructureNode instances are equal
        /// </summary>
        /// <param name="input">Instance of PagedResultsFolderStructureNode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PagedResultsFolderStructureNode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) && 
                (
                    this.List == input.List ||
                    this.List != null &&
                    this.List.SequenceEqual(input.List)
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
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.List != null)
                    hashCode = hashCode * 59 + this.List.GetHashCode();
                return hashCode;
            }
        }
    }

}
