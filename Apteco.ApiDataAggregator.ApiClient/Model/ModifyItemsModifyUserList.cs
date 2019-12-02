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
    /// A set of items to modify
    /// </summary>
    [DataContract]
    public partial class ModifyItemsModifyUserList :  IEquatable<ModifyItemsModifyUserList>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyItemsModifyUserList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModifyItemsModifyUserList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyItemsModifyUserList" /> class.
        /// </summary>
        /// <param name="ReturnModifiedItem">Whether to return the modified item in the results (required).</param>
        /// <param name="List">The list of items to modify (required).</param>
        public ModifyItemsModifyUserList(bool? ReturnModifiedItem = default(bool?), List<ModifyUserList> List = default(List<ModifyUserList>))
        {
            // to ensure "ReturnModifiedItem" is required (not null)
            if (ReturnModifiedItem == null)
            {
                throw new InvalidDataException("ReturnModifiedItem is a required property for ModifyItemsModifyUserList and cannot be null");
            }
            else
            {
                this.ReturnModifiedItem = ReturnModifiedItem;
            }
            // to ensure "List" is required (not null)
            if (List == null)
            {
                throw new InvalidDataException("List is a required property for ModifyItemsModifyUserList and cannot be null");
            }
            else
            {
                this.List = List;
            }
        }
        
        /// <summary>
        /// Whether to return the modified item in the results
        /// </summary>
        /// <value>Whether to return the modified item in the results</value>
        [DataMember(Name="returnModifiedItem", EmitDefaultValue=false)]
        public bool? ReturnModifiedItem { get; set; }

        /// <summary>
        /// The list of items to modify
        /// </summary>
        /// <value>The list of items to modify</value>
        [DataMember(Name="list", EmitDefaultValue=false)]
        public List<ModifyUserList> List { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyItemsModifyUserList {\n");
            sb.Append("  ReturnModifiedItem: ").Append(ReturnModifiedItem).Append("\n");
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
            return this.Equals(input as ModifyItemsModifyUserList);
        }

        /// <summary>
        /// Returns true if ModifyItemsModifyUserList instances are equal
        /// </summary>
        /// <param name="input">Instance of ModifyItemsModifyUserList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModifyItemsModifyUserList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReturnModifiedItem == input.ReturnModifiedItem ||
                    (this.ReturnModifiedItem != null &&
                    this.ReturnModifiedItem.Equals(input.ReturnModifiedItem))
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
                if (this.ReturnModifiedItem != null)
                    hashCode = hashCode * 59 + this.ReturnModifiedItem.GetHashCode();
                if (this.List != null)
                    hashCode = hashCode * 59 + this.List.GetHashCode();
                return hashCode;
            }
        }
    }

}
