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
    /// Summary details for a list
    /// </summary>
    [DataContract]
    public partial class ListSummary :  IEquatable<ListSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSummary" /> class.
        /// </summary>
        /// <param name="Id">The list&#39;s id (required).</param>
        /// <param name="Title">The title of the list (required).</param>
        /// <param name="Description">The description of the list (required).</param>
        /// <param name="CreationDate">The date the list was created (required).</param>
        /// <param name="Owner">The details of the user that owns this list (required).</param>
        /// <param name="DeletionDate">The date the list was deleted, or null if it has not been deleted (required).</param>
        /// <param name="ResolveTableName">The FastStats table that the list is defined against (required).</param>
        /// <param name="ResolveTableNettCount">If the list has been counted, the latest overall count for the resolve table.</param>
        /// <param name="NumberOfUsersSharedWith">The number of people this list has been shared with (required).</param>
        /// <param name="ShareId">The id of the share associated with this list, or null if the  list has not yet been shared (required).</param>
        /// <param name="NumberOfHits">The number of hits associated with this list (required).</param>
        /// <param name="SystemName">The FastStats system that this list has been created against (required).</param>
        /// <param name="LastUpdatedUser">The details of the user that last updated this list (required).</param>
        /// <param name="LastUpdatedDate">The date the list was last updated (required).</param>
        /// <param name="LastUpdateId">The id of the last update for this list (required).</param>
        public ListSummary(int? Id = default(int?), string Title = default(string), string Description = default(string), DateTime? CreationDate = default(DateTime?), UserDisplayDetails Owner = default(UserDisplayDetails), DateTime? DeletionDate = default(DateTime?), string ResolveTableName = default(string), long? ResolveTableNettCount = default(long?), int? NumberOfUsersSharedWith = default(int?), int? ShareId = default(int?), int? NumberOfHits = default(int?), string SystemName = default(string), UserDisplayDetails LastUpdatedUser = default(UserDisplayDetails), DateTime? LastUpdatedDate = default(DateTime?), int? LastUpdateId = default(int?))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for ListSummary and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Title" is required (not null)
            if (Title == null)
            {
                throw new InvalidDataException("Title is a required property for ListSummary and cannot be null");
            }
            else
            {
                this.Title = Title;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for ListSummary and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            // to ensure "CreationDate" is required (not null)
            if (CreationDate == null)
            {
                throw new InvalidDataException("CreationDate is a required property for ListSummary and cannot be null");
            }
            else
            {
                this.CreationDate = CreationDate;
            }
            // to ensure "Owner" is required (not null)
            if (Owner == null)
            {
                throw new InvalidDataException("Owner is a required property for ListSummary and cannot be null");
            }
            else
            {
                this.Owner = Owner;
            }
            // to ensure "DeletionDate" is required (not null)
            if (DeletionDate == null)
            {
                throw new InvalidDataException("DeletionDate is a required property for ListSummary and cannot be null");
            }
            else
            {
                this.DeletionDate = DeletionDate;
            }
            // to ensure "ResolveTableName" is required (not null)
            if (ResolveTableName == null)
            {
                throw new InvalidDataException("ResolveTableName is a required property for ListSummary and cannot be null");
            }
            else
            {
                this.ResolveTableName = ResolveTableName;
            }
            // to ensure "NumberOfUsersSharedWith" is required (not null)
            if (NumberOfUsersSharedWith == null)
            {
                throw new InvalidDataException("NumberOfUsersSharedWith is a required property for ListSummary and cannot be null");
            }
            else
            {
                this.NumberOfUsersSharedWith = NumberOfUsersSharedWith;
            }
            // to ensure "ShareId" is required (not null)
            if (ShareId == null)
            {
                throw new InvalidDataException("ShareId is a required property for ListSummary and cannot be null");
            }
            else
            {
                this.ShareId = ShareId;
            }
            // to ensure "NumberOfHits" is required (not null)
            if (NumberOfHits == null)
            {
                throw new InvalidDataException("NumberOfHits is a required property for ListSummary and cannot be null");
            }
            else
            {
                this.NumberOfHits = NumberOfHits;
            }
            // to ensure "SystemName" is required (not null)
            if (SystemName == null)
            {
                throw new InvalidDataException("SystemName is a required property for ListSummary and cannot be null");
            }
            else
            {
                this.SystemName = SystemName;
            }
            // to ensure "LastUpdatedUser" is required (not null)
            if (LastUpdatedUser == null)
            {
                throw new InvalidDataException("LastUpdatedUser is a required property for ListSummary and cannot be null");
            }
            else
            {
                this.LastUpdatedUser = LastUpdatedUser;
            }
            // to ensure "LastUpdatedDate" is required (not null)
            if (LastUpdatedDate == null)
            {
                throw new InvalidDataException("LastUpdatedDate is a required property for ListSummary and cannot be null");
            }
            else
            {
                this.LastUpdatedDate = LastUpdatedDate;
            }
            // to ensure "LastUpdateId" is required (not null)
            if (LastUpdateId == null)
            {
                throw new InvalidDataException("LastUpdateId is a required property for ListSummary and cannot be null");
            }
            else
            {
                this.LastUpdateId = LastUpdateId;
            }
            this.ResolveTableNettCount = ResolveTableNettCount;
        }
        
        /// <summary>
        /// The list&#39;s id
        /// </summary>
        /// <value>The list&#39;s id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The title of the list
        /// </summary>
        /// <value>The title of the list</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// The description of the list
        /// </summary>
        /// <value>The description of the list</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The date the list was created
        /// </summary>
        /// <value>The date the list was created</value>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// The details of the user that owns this list
        /// </summary>
        /// <value>The details of the user that owns this list</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public UserDisplayDetails Owner { get; set; }

        /// <summary>
        /// The date the list was deleted, or null if it has not been deleted
        /// </summary>
        /// <value>The date the list was deleted, or null if it has not been deleted</value>
        [DataMember(Name="deletionDate", EmitDefaultValue=false)]
        public DateTime? DeletionDate { get; set; }

        /// <summary>
        /// The FastStats table that the list is defined against
        /// </summary>
        /// <value>The FastStats table that the list is defined against</value>
        [DataMember(Name="resolveTableName", EmitDefaultValue=false)]
        public string ResolveTableName { get; set; }

        /// <summary>
        /// If the list has been counted, the latest overall count for the resolve table
        /// </summary>
        /// <value>If the list has been counted, the latest overall count for the resolve table</value>
        [DataMember(Name="resolveTableNettCount", EmitDefaultValue=false)]
        public long? ResolveTableNettCount { get; set; }

        /// <summary>
        /// The number of people this list has been shared with
        /// </summary>
        /// <value>The number of people this list has been shared with</value>
        [DataMember(Name="numberOfUsersSharedWith", EmitDefaultValue=false)]
        public int? NumberOfUsersSharedWith { get; set; }

        /// <summary>
        /// The id of the share associated with this list, or null if the  list has not yet been shared
        /// </summary>
        /// <value>The id of the share associated with this list, or null if the  list has not yet been shared</value>
        [DataMember(Name="shareId", EmitDefaultValue=false)]
        public int? ShareId { get; set; }

        /// <summary>
        /// The number of hits associated with this list
        /// </summary>
        /// <value>The number of hits associated with this list</value>
        [DataMember(Name="numberOfHits", EmitDefaultValue=false)]
        public int? NumberOfHits { get; set; }

        /// <summary>
        /// The FastStats system that this list has been created against
        /// </summary>
        /// <value>The FastStats system that this list has been created against</value>
        [DataMember(Name="systemName", EmitDefaultValue=false)]
        public string SystemName { get; set; }

        /// <summary>
        /// The details of the user that last updated this list
        /// </summary>
        /// <value>The details of the user that last updated this list</value>
        [DataMember(Name="lastUpdatedUser", EmitDefaultValue=false)]
        public UserDisplayDetails LastUpdatedUser { get; set; }

        /// <summary>
        /// The date the list was last updated
        /// </summary>
        /// <value>The date the list was last updated</value>
        [DataMember(Name="lastUpdatedDate", EmitDefaultValue=false)]
        public DateTime? LastUpdatedDate { get; set; }

        /// <summary>
        /// The id of the last update for this list
        /// </summary>
        /// <value>The id of the last update for this list</value>
        [DataMember(Name="lastUpdateId", EmitDefaultValue=false)]
        public int? LastUpdateId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  DeletionDate: ").Append(DeletionDate).Append("\n");
            sb.Append("  ResolveTableName: ").Append(ResolveTableName).Append("\n");
            sb.Append("  ResolveTableNettCount: ").Append(ResolveTableNettCount).Append("\n");
            sb.Append("  NumberOfUsersSharedWith: ").Append(NumberOfUsersSharedWith).Append("\n");
            sb.Append("  ShareId: ").Append(ShareId).Append("\n");
            sb.Append("  NumberOfHits: ").Append(NumberOfHits).Append("\n");
            sb.Append("  SystemName: ").Append(SystemName).Append("\n");
            sb.Append("  LastUpdatedUser: ").Append(LastUpdatedUser).Append("\n");
            sb.Append("  LastUpdatedDate: ").Append(LastUpdatedDate).Append("\n");
            sb.Append("  LastUpdateId: ").Append(LastUpdateId).Append("\n");
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
            return this.Equals(input as ListSummary);
        }

        /// <summary>
        /// Returns true if ListSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of ListSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListSummary input)
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
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.DeletionDate == input.DeletionDate ||
                    (this.DeletionDate != null &&
                    this.DeletionDate.Equals(input.DeletionDate))
                ) && 
                (
                    this.ResolveTableName == input.ResolveTableName ||
                    (this.ResolveTableName != null &&
                    this.ResolveTableName.Equals(input.ResolveTableName))
                ) && 
                (
                    this.ResolveTableNettCount == input.ResolveTableNettCount ||
                    (this.ResolveTableNettCount != null &&
                    this.ResolveTableNettCount.Equals(input.ResolveTableNettCount))
                ) && 
                (
                    this.NumberOfUsersSharedWith == input.NumberOfUsersSharedWith ||
                    (this.NumberOfUsersSharedWith != null &&
                    this.NumberOfUsersSharedWith.Equals(input.NumberOfUsersSharedWith))
                ) && 
                (
                    this.ShareId == input.ShareId ||
                    (this.ShareId != null &&
                    this.ShareId.Equals(input.ShareId))
                ) && 
                (
                    this.NumberOfHits == input.NumberOfHits ||
                    (this.NumberOfHits != null &&
                    this.NumberOfHits.Equals(input.NumberOfHits))
                ) && 
                (
                    this.SystemName == input.SystemName ||
                    (this.SystemName != null &&
                    this.SystemName.Equals(input.SystemName))
                ) && 
                (
                    this.LastUpdatedUser == input.LastUpdatedUser ||
                    (this.LastUpdatedUser != null &&
                    this.LastUpdatedUser.Equals(input.LastUpdatedUser))
                ) && 
                (
                    this.LastUpdatedDate == input.LastUpdatedDate ||
                    (this.LastUpdatedDate != null &&
                    this.LastUpdatedDate.Equals(input.LastUpdatedDate))
                ) && 
                (
                    this.LastUpdateId == input.LastUpdateId ||
                    (this.LastUpdateId != null &&
                    this.LastUpdateId.Equals(input.LastUpdateId))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.DeletionDate != null)
                    hashCode = hashCode * 59 + this.DeletionDate.GetHashCode();
                if (this.ResolveTableName != null)
                    hashCode = hashCode * 59 + this.ResolveTableName.GetHashCode();
                if (this.ResolveTableNettCount != null)
                    hashCode = hashCode * 59 + this.ResolveTableNettCount.GetHashCode();
                if (this.NumberOfUsersSharedWith != null)
                    hashCode = hashCode * 59 + this.NumberOfUsersSharedWith.GetHashCode();
                if (this.ShareId != null)
                    hashCode = hashCode * 59 + this.ShareId.GetHashCode();
                if (this.NumberOfHits != null)
                    hashCode = hashCode * 59 + this.NumberOfHits.GetHashCode();
                if (this.SystemName != null)
                    hashCode = hashCode * 59 + this.SystemName.GetHashCode();
                if (this.LastUpdatedUser != null)
                    hashCode = hashCode * 59 + this.LastUpdatedUser.GetHashCode();
                if (this.LastUpdatedDate != null)
                    hashCode = hashCode * 59 + this.LastUpdatedDate.GetHashCode();
                if (this.LastUpdateId != null)
                    hashCode = hashCode * 59 + this.LastUpdateId.GetHashCode();
                return hashCode;
            }
        }
    }

}
