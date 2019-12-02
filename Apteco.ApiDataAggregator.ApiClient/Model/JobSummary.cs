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
    /// Summary information for a job in FastStats
    /// </summary>
    [DataContract]
    public partial class JobSummary :  IEquatable<JobSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JobSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JobSummary" /> class.
        /// </summary>
        /// <param name="Id">The id of the job (required).</param>
        /// <param name="Priority">The priority of the job.  The lower the number the more important the job (required).</param>
        /// <param name="State">The state of the job.  Valid values can include &#39;cancel&#39;, &#39;done&#39;, &#39;incomplete&#39;, &#39;inserting&#39; and &#39;unassigned&#39; (required).</param>
        /// <param name="CancelRequested">Whether this job has been asked to cancel.  If it has then acted on this request and been cancelled then the state will be set to &#39;cancel&#39; (required).</param>
        /// <param name="TimeAdded">The date and time that the job was added to the job queue.</param>
        /// <param name="TimeSent">The date and time that the job was sent from the queue to be processed.</param>
        /// <param name="TimeFinished">The date and time that the job finished processing.</param>
        /// <param name="Server">The hostname of the server that is processing/processed this job (required).</param>
        /// <param name="SystemName">The name of the FastStats system that this job is running against (required).</param>
        /// <param name="ThreadNumber">The number of the thread within the FastStats Service that is running this job (required).</param>
        /// <param name="Username">The name of the user that submitted this job (required).</param>
        /// <param name="JobType">The type of the job (required).</param>
        public JobSummary(int? Id = default(int?), int? Priority = default(int?), string State = default(string), bool? CancelRequested = default(bool?), DateTime? TimeAdded = default(DateTime?), DateTime? TimeSent = default(DateTime?), DateTime? TimeFinished = default(DateTime?), string Server = default(string), string SystemName = default(string), int? ThreadNumber = default(int?), string Username = default(string), string JobType = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for JobSummary and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Priority" is required (not null)
            if (Priority == null)
            {
                throw new InvalidDataException("Priority is a required property for JobSummary and cannot be null");
            }
            else
            {
                this.Priority = Priority;
            }
            // to ensure "State" is required (not null)
            if (State == null)
            {
                throw new InvalidDataException("State is a required property for JobSummary and cannot be null");
            }
            else
            {
                this.State = State;
            }
            // to ensure "CancelRequested" is required (not null)
            if (CancelRequested == null)
            {
                throw new InvalidDataException("CancelRequested is a required property for JobSummary and cannot be null");
            }
            else
            {
                this.CancelRequested = CancelRequested;
            }
            // to ensure "Server" is required (not null)
            if (Server == null)
            {
                throw new InvalidDataException("Server is a required property for JobSummary and cannot be null");
            }
            else
            {
                this.Server = Server;
            }
            // to ensure "SystemName" is required (not null)
            if (SystemName == null)
            {
                throw new InvalidDataException("SystemName is a required property for JobSummary and cannot be null");
            }
            else
            {
                this.SystemName = SystemName;
            }
            // to ensure "ThreadNumber" is required (not null)
            if (ThreadNumber == null)
            {
                throw new InvalidDataException("ThreadNumber is a required property for JobSummary and cannot be null");
            }
            else
            {
                this.ThreadNumber = ThreadNumber;
            }
            // to ensure "Username" is required (not null)
            if (Username == null)
            {
                throw new InvalidDataException("Username is a required property for JobSummary and cannot be null");
            }
            else
            {
                this.Username = Username;
            }
            // to ensure "JobType" is required (not null)
            if (JobType == null)
            {
                throw new InvalidDataException("JobType is a required property for JobSummary and cannot be null");
            }
            else
            {
                this.JobType = JobType;
            }
            this.TimeAdded = TimeAdded;
            this.TimeSent = TimeSent;
            this.TimeFinished = TimeFinished;
        }
        
        /// <summary>
        /// The id of the job
        /// </summary>
        /// <value>The id of the job</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The priority of the job.  The lower the number the more important the job
        /// </summary>
        /// <value>The priority of the job.  The lower the number the more important the job</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// The state of the job.  Valid values can include &#39;cancel&#39;, &#39;done&#39;, &#39;incomplete&#39;, &#39;inserting&#39; and &#39;unassigned&#39;
        /// </summary>
        /// <value>The state of the job.  Valid values can include &#39;cancel&#39;, &#39;done&#39;, &#39;incomplete&#39;, &#39;inserting&#39; and &#39;unassigned&#39;</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Whether this job has been asked to cancel.  If it has then acted on this request and been cancelled then the state will be set to &#39;cancel&#39;
        /// </summary>
        /// <value>Whether this job has been asked to cancel.  If it has then acted on this request and been cancelled then the state will be set to &#39;cancel&#39;</value>
        [DataMember(Name="cancelRequested", EmitDefaultValue=false)]
        public bool? CancelRequested { get; set; }

        /// <summary>
        /// The date and time that the job was added to the job queue
        /// </summary>
        /// <value>The date and time that the job was added to the job queue</value>
        [DataMember(Name="timeAdded", EmitDefaultValue=false)]
        public DateTime? TimeAdded { get; set; }

        /// <summary>
        /// The date and time that the job was sent from the queue to be processed
        /// </summary>
        /// <value>The date and time that the job was sent from the queue to be processed</value>
        [DataMember(Name="timeSent", EmitDefaultValue=false)]
        public DateTime? TimeSent { get; set; }

        /// <summary>
        /// The date and time that the job finished processing
        /// </summary>
        /// <value>The date and time that the job finished processing</value>
        [DataMember(Name="timeFinished", EmitDefaultValue=false)]
        public DateTime? TimeFinished { get; set; }

        /// <summary>
        /// The hostname of the server that is processing/processed this job
        /// </summary>
        /// <value>The hostname of the server that is processing/processed this job</value>
        [DataMember(Name="server", EmitDefaultValue=false)]
        public string Server { get; set; }

        /// <summary>
        /// The name of the FastStats system that this job is running against
        /// </summary>
        /// <value>The name of the FastStats system that this job is running against</value>
        [DataMember(Name="systemName", EmitDefaultValue=false)]
        public string SystemName { get; set; }

        /// <summary>
        /// The number of the thread within the FastStats Service that is running this job
        /// </summary>
        /// <value>The number of the thread within the FastStats Service that is running this job</value>
        [DataMember(Name="threadNumber", EmitDefaultValue=false)]
        public int? ThreadNumber { get; set; }

        /// <summary>
        /// The name of the user that submitted this job
        /// </summary>
        /// <value>The name of the user that submitted this job</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// The type of the job
        /// </summary>
        /// <value>The type of the job</value>
        [DataMember(Name="jobType", EmitDefaultValue=false)]
        public string JobType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  CancelRequested: ").Append(CancelRequested).Append("\n");
            sb.Append("  TimeAdded: ").Append(TimeAdded).Append("\n");
            sb.Append("  TimeSent: ").Append(TimeSent).Append("\n");
            sb.Append("  TimeFinished: ").Append(TimeFinished).Append("\n");
            sb.Append("  Server: ").Append(Server).Append("\n");
            sb.Append("  SystemName: ").Append(SystemName).Append("\n");
            sb.Append("  ThreadNumber: ").Append(ThreadNumber).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  JobType: ").Append(JobType).Append("\n");
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
            return this.Equals(input as JobSummary);
        }

        /// <summary>
        /// Returns true if JobSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of JobSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobSummary input)
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
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.CancelRequested == input.CancelRequested ||
                    (this.CancelRequested != null &&
                    this.CancelRequested.Equals(input.CancelRequested))
                ) && 
                (
                    this.TimeAdded == input.TimeAdded ||
                    (this.TimeAdded != null &&
                    this.TimeAdded.Equals(input.TimeAdded))
                ) && 
                (
                    this.TimeSent == input.TimeSent ||
                    (this.TimeSent != null &&
                    this.TimeSent.Equals(input.TimeSent))
                ) && 
                (
                    this.TimeFinished == input.TimeFinished ||
                    (this.TimeFinished != null &&
                    this.TimeFinished.Equals(input.TimeFinished))
                ) && 
                (
                    this.Server == input.Server ||
                    (this.Server != null &&
                    this.Server.Equals(input.Server))
                ) && 
                (
                    this.SystemName == input.SystemName ||
                    (this.SystemName != null &&
                    this.SystemName.Equals(input.SystemName))
                ) && 
                (
                    this.ThreadNumber == input.ThreadNumber ||
                    (this.ThreadNumber != null &&
                    this.ThreadNumber.Equals(input.ThreadNumber))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.JobType == input.JobType ||
                    (this.JobType != null &&
                    this.JobType.Equals(input.JobType))
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
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.CancelRequested != null)
                    hashCode = hashCode * 59 + this.CancelRequested.GetHashCode();
                if (this.TimeAdded != null)
                    hashCode = hashCode * 59 + this.TimeAdded.GetHashCode();
                if (this.TimeSent != null)
                    hashCode = hashCode * 59 + this.TimeSent.GetHashCode();
                if (this.TimeFinished != null)
                    hashCode = hashCode * 59 + this.TimeFinished.GetHashCode();
                if (this.Server != null)
                    hashCode = hashCode * 59 + this.Server.GetHashCode();
                if (this.SystemName != null)
                    hashCode = hashCode * 59 + this.SystemName.GetHashCode();
                if (this.ThreadNumber != null)
                    hashCode = hashCode * 59 + this.ThreadNumber.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.JobType != null)
                    hashCode = hashCode * 59 + this.JobType.GetHashCode();
                return hashCode;
            }
        }
    }

}
