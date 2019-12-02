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
    /// Results for processing an export request
    /// </summary>
    [DataContract]
    public partial class ExportResult :  IEquatable<ExportResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExportResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportResult" /> class.
        /// </summary>
        /// <param name="Title">The title of the query that has been counted.</param>
        /// <param name="Notes">Any notes associated with the query that has been counted.</param>
        /// <param name="RanSuccessfully">Whether the query was counted successfully or not (required).</param>
        /// <param name="SystemName">The name of the FastStats system that this count has been produced by.</param>
        /// <param name="SystemLoadDate">The date and time that the FastStats system from which this count has come was last built.</param>
        /// <param name="UserName">The name of the user that requested this count.</param>
        /// <param name="RunDate">The date and time that this count was run on.</param>
        /// <param name="QueryDescription">A textual description of the query that was counted.</param>
        /// <param name="Rows">The rows of browse data for this export request..</param>
        /// <param name="Export">The definition of the export that was requested..</param>
        /// <param name="Counts">A list of counts for each affected table in the FastStats system.  The first count in the list is the main one..</param>
        public ExportResult(string Title = default(string), string Notes = default(string), bool? RanSuccessfully = default(bool?), string SystemName = default(string), DateTime? SystemLoadDate = default(DateTime?), string UserName = default(string), DateTime? RunDate = default(DateTime?), string QueryDescription = default(string), List<Row> Rows = default(List<Row>), Export Export = default(Export), List<Count> Counts = default(List<Count>))
        {
            // to ensure "RanSuccessfully" is required (not null)
            if (RanSuccessfully == null)
            {
                throw new InvalidDataException("RanSuccessfully is a required property for ExportResult and cannot be null");
            }
            else
            {
                this.RanSuccessfully = RanSuccessfully;
            }
            this.Title = Title;
            this.Notes = Notes;
            this.SystemName = SystemName;
            this.SystemLoadDate = SystemLoadDate;
            this.UserName = UserName;
            this.RunDate = RunDate;
            this.QueryDescription = QueryDescription;
            this.Rows = Rows;
            this.Export = Export;
            this.Counts = Counts;
        }
        
        /// <summary>
        /// The title of the query that has been counted
        /// </summary>
        /// <value>The title of the query that has been counted</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Any notes associated with the query that has been counted
        /// </summary>
        /// <value>Any notes associated with the query that has been counted</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Whether the query was counted successfully or not
        /// </summary>
        /// <value>Whether the query was counted successfully or not</value>
        [DataMember(Name="ranSuccessfully", EmitDefaultValue=false)]
        public bool? RanSuccessfully { get; set; }

        /// <summary>
        /// The name of the FastStats system that this count has been produced by
        /// </summary>
        /// <value>The name of the FastStats system that this count has been produced by</value>
        [DataMember(Name="systemName", EmitDefaultValue=false)]
        public string SystemName { get; set; }

        /// <summary>
        /// The date and time that the FastStats system from which this count has come was last built
        /// </summary>
        /// <value>The date and time that the FastStats system from which this count has come was last built</value>
        [DataMember(Name="systemLoadDate", EmitDefaultValue=false)]
        public DateTime? SystemLoadDate { get; set; }

        /// <summary>
        /// The name of the user that requested this count
        /// </summary>
        /// <value>The name of the user that requested this count</value>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// The date and time that this count was run on
        /// </summary>
        /// <value>The date and time that this count was run on</value>
        [DataMember(Name="runDate", EmitDefaultValue=false)]
        public DateTime? RunDate { get; set; }

        /// <summary>
        /// A textual description of the query that was counted
        /// </summary>
        /// <value>A textual description of the query that was counted</value>
        [DataMember(Name="queryDescription", EmitDefaultValue=false)]
        public string QueryDescription { get; set; }

        /// <summary>
        /// The rows of browse data for this export request.
        /// </summary>
        /// <value>The rows of browse data for this export request.</value>
        [DataMember(Name="rows", EmitDefaultValue=false)]
        public List<Row> Rows { get; set; }

        /// <summary>
        /// The definition of the export that was requested.
        /// </summary>
        /// <value>The definition of the export that was requested.</value>
        [DataMember(Name="export", EmitDefaultValue=false)]
        public Export Export { get; set; }

        /// <summary>
        /// A list of counts for each affected table in the FastStats system.  The first count in the list is the main one.
        /// </summary>
        /// <value>A list of counts for each affected table in the FastStats system.  The first count in the list is the main one.</value>
        [DataMember(Name="counts", EmitDefaultValue=false)]
        public List<Count> Counts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportResult {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  RanSuccessfully: ").Append(RanSuccessfully).Append("\n");
            sb.Append("  SystemName: ").Append(SystemName).Append("\n");
            sb.Append("  SystemLoadDate: ").Append(SystemLoadDate).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  RunDate: ").Append(RunDate).Append("\n");
            sb.Append("  QueryDescription: ").Append(QueryDescription).Append("\n");
            sb.Append("  Rows: ").Append(Rows).Append("\n");
            sb.Append("  Export: ").Append(Export).Append("\n");
            sb.Append("  Counts: ").Append(Counts).Append("\n");
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
            return this.Equals(input as ExportResult);
        }

        /// <summary>
        /// Returns true if ExportResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ExportResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExportResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.RanSuccessfully == input.RanSuccessfully ||
                    (this.RanSuccessfully != null &&
                    this.RanSuccessfully.Equals(input.RanSuccessfully))
                ) && 
                (
                    this.SystemName == input.SystemName ||
                    (this.SystemName != null &&
                    this.SystemName.Equals(input.SystemName))
                ) && 
                (
                    this.SystemLoadDate == input.SystemLoadDate ||
                    (this.SystemLoadDate != null &&
                    this.SystemLoadDate.Equals(input.SystemLoadDate))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.RunDate == input.RunDate ||
                    (this.RunDate != null &&
                    this.RunDate.Equals(input.RunDate))
                ) && 
                (
                    this.QueryDescription == input.QueryDescription ||
                    (this.QueryDescription != null &&
                    this.QueryDescription.Equals(input.QueryDescription))
                ) && 
                (
                    this.Rows == input.Rows ||
                    this.Rows != null &&
                    this.Rows.SequenceEqual(input.Rows)
                ) && 
                (
                    this.Export == input.Export ||
                    (this.Export != null &&
                    this.Export.Equals(input.Export))
                ) && 
                (
                    this.Counts == input.Counts ||
                    this.Counts != null &&
                    this.Counts.SequenceEqual(input.Counts)
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.RanSuccessfully != null)
                    hashCode = hashCode * 59 + this.RanSuccessfully.GetHashCode();
                if (this.SystemName != null)
                    hashCode = hashCode * 59 + this.SystemName.GetHashCode();
                if (this.SystemLoadDate != null)
                    hashCode = hashCode * 59 + this.SystemLoadDate.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.RunDate != null)
                    hashCode = hashCode * 59 + this.RunDate.GetHashCode();
                if (this.QueryDescription != null)
                    hashCode = hashCode * 59 + this.QueryDescription.GetHashCode();
                if (this.Rows != null)
                    hashCode = hashCode * 59 + this.Rows.GetHashCode();
                if (this.Export != null)
                    hashCode = hashCode * 59 + this.Export.GetHashCode();
                if (this.Counts != null)
                    hashCode = hashCode * 59 + this.Counts.GetHashCode();
                return hashCode;
            }
        }
    }

}
