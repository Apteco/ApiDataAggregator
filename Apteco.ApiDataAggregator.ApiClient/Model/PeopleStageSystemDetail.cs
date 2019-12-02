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
    /// Top level details for a PeopleStage system
    /// </summary>
    [DataContract]
    public partial class PeopleStageSystemDetail :  IEquatable<PeopleStageSystemDetail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleStageSystemDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PeopleStageSystemDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleStageSystemDetail" /> class.
        /// </summary>
        /// <param name="Metadata">Metadata about the PeopleStage diagram (required).</param>
        /// <param name="LastRequestedDataAt">The date and time that the API last polled for PeopleStage data.</param>
        /// <param name="SystemName">The name of the system that has PeopleStage configured (required).</param>
        /// <param name="DiagramId">The top-level diagram id for this PeopleStage system (required).</param>
        /// <param name="ProgrammeId">The id of the first programme configured within the PeopleStage diagram (required).</param>
        /// <param name="ProgrammeDescription">The description of the first programme configured within the PeopleStage diagram (required).</param>
        /// <param name="IsAbleToProvideStatistics">Whether statistics information can be gathered for this PeopleStage system (required).</param>
        public PeopleStageSystemDetail(DiagramMetadata Metadata = default(DiagramMetadata), DateTime? LastRequestedDataAt = default(DateTime?), string SystemName = default(string), string DiagramId = default(string), string ProgrammeId = default(string), string ProgrammeDescription = default(string), bool? IsAbleToProvideStatistics = default(bool?))
        {
            // to ensure "Metadata" is required (not null)
            if (Metadata == null)
            {
                throw new InvalidDataException("Metadata is a required property for PeopleStageSystemDetail and cannot be null");
            }
            else
            {
                this.Metadata = Metadata;
            }
            // to ensure "SystemName" is required (not null)
            if (SystemName == null)
            {
                throw new InvalidDataException("SystemName is a required property for PeopleStageSystemDetail and cannot be null");
            }
            else
            {
                this.SystemName = SystemName;
            }
            // to ensure "DiagramId" is required (not null)
            if (DiagramId == null)
            {
                throw new InvalidDataException("DiagramId is a required property for PeopleStageSystemDetail and cannot be null");
            }
            else
            {
                this.DiagramId = DiagramId;
            }
            // to ensure "ProgrammeId" is required (not null)
            if (ProgrammeId == null)
            {
                throw new InvalidDataException("ProgrammeId is a required property for PeopleStageSystemDetail and cannot be null");
            }
            else
            {
                this.ProgrammeId = ProgrammeId;
            }
            // to ensure "ProgrammeDescription" is required (not null)
            if (ProgrammeDescription == null)
            {
                throw new InvalidDataException("ProgrammeDescription is a required property for PeopleStageSystemDetail and cannot be null");
            }
            else
            {
                this.ProgrammeDescription = ProgrammeDescription;
            }
            // to ensure "IsAbleToProvideStatistics" is required (not null)
            if (IsAbleToProvideStatistics == null)
            {
                throw new InvalidDataException("IsAbleToProvideStatistics is a required property for PeopleStageSystemDetail and cannot be null");
            }
            else
            {
                this.IsAbleToProvideStatistics = IsAbleToProvideStatistics;
            }
            this.LastRequestedDataAt = LastRequestedDataAt;
        }
        
        /// <summary>
        /// Metadata about the PeopleStage diagram
        /// </summary>
        /// <value>Metadata about the PeopleStage diagram</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public DiagramMetadata Metadata { get; set; }

        /// <summary>
        /// The date and time that the API last polled for PeopleStage data
        /// </summary>
        /// <value>The date and time that the API last polled for PeopleStage data</value>
        [DataMember(Name="lastRequestedDataAt", EmitDefaultValue=false)]
        public DateTime? LastRequestedDataAt { get; set; }

        /// <summary>
        /// The name of the system that has PeopleStage configured
        /// </summary>
        /// <value>The name of the system that has PeopleStage configured</value>
        [DataMember(Name="systemName", EmitDefaultValue=false)]
        public string SystemName { get; set; }

        /// <summary>
        /// The top-level diagram id for this PeopleStage system
        /// </summary>
        /// <value>The top-level diagram id for this PeopleStage system</value>
        [DataMember(Name="diagramId", EmitDefaultValue=false)]
        public string DiagramId { get; set; }

        /// <summary>
        /// The id of the first programme configured within the PeopleStage diagram
        /// </summary>
        /// <value>The id of the first programme configured within the PeopleStage diagram</value>
        [DataMember(Name="programmeId", EmitDefaultValue=false)]
        public string ProgrammeId { get; set; }

        /// <summary>
        /// The description of the first programme configured within the PeopleStage diagram
        /// </summary>
        /// <value>The description of the first programme configured within the PeopleStage diagram</value>
        [DataMember(Name="programmeDescription", EmitDefaultValue=false)]
        public string ProgrammeDescription { get; set; }

        /// <summary>
        /// Whether statistics information can be gathered for this PeopleStage system
        /// </summary>
        /// <value>Whether statistics information can be gathered for this PeopleStage system</value>
        [DataMember(Name="isAbleToProvideStatistics", EmitDefaultValue=false)]
        public bool? IsAbleToProvideStatistics { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PeopleStageSystemDetail {\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  LastRequestedDataAt: ").Append(LastRequestedDataAt).Append("\n");
            sb.Append("  SystemName: ").Append(SystemName).Append("\n");
            sb.Append("  DiagramId: ").Append(DiagramId).Append("\n");
            sb.Append("  ProgrammeId: ").Append(ProgrammeId).Append("\n");
            sb.Append("  ProgrammeDescription: ").Append(ProgrammeDescription).Append("\n");
            sb.Append("  IsAbleToProvideStatistics: ").Append(IsAbleToProvideStatistics).Append("\n");
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
            return this.Equals(input as PeopleStageSystemDetail);
        }

        /// <summary>
        /// Returns true if PeopleStageSystemDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of PeopleStageSystemDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PeopleStageSystemDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.LastRequestedDataAt == input.LastRequestedDataAt ||
                    (this.LastRequestedDataAt != null &&
                    this.LastRequestedDataAt.Equals(input.LastRequestedDataAt))
                ) && 
                (
                    this.SystemName == input.SystemName ||
                    (this.SystemName != null &&
                    this.SystemName.Equals(input.SystemName))
                ) && 
                (
                    this.DiagramId == input.DiagramId ||
                    (this.DiagramId != null &&
                    this.DiagramId.Equals(input.DiagramId))
                ) && 
                (
                    this.ProgrammeId == input.ProgrammeId ||
                    (this.ProgrammeId != null &&
                    this.ProgrammeId.Equals(input.ProgrammeId))
                ) && 
                (
                    this.ProgrammeDescription == input.ProgrammeDescription ||
                    (this.ProgrammeDescription != null &&
                    this.ProgrammeDescription.Equals(input.ProgrammeDescription))
                ) && 
                (
                    this.IsAbleToProvideStatistics == input.IsAbleToProvideStatistics ||
                    (this.IsAbleToProvideStatistics != null &&
                    this.IsAbleToProvideStatistics.Equals(input.IsAbleToProvideStatistics))
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
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.LastRequestedDataAt != null)
                    hashCode = hashCode * 59 + this.LastRequestedDataAt.GetHashCode();
                if (this.SystemName != null)
                    hashCode = hashCode * 59 + this.SystemName.GetHashCode();
                if (this.DiagramId != null)
                    hashCode = hashCode * 59 + this.DiagramId.GetHashCode();
                if (this.ProgrammeId != null)
                    hashCode = hashCode * 59 + this.ProgrammeId.GetHashCode();
                if (this.ProgrammeDescription != null)
                    hashCode = hashCode * 59 + this.ProgrammeDescription.GetHashCode();
                if (this.IsAbleToProvideStatistics != null)
                    hashCode = hashCode * 59 + this.IsAbleToProvideStatistics.GetHashCode();
                return hashCode;
            }
        }
    }

}
