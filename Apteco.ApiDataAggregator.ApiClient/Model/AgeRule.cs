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
    /// AgeRule
    /// </summary>
    [DataContract]
    public partial class AgeRule :  IEquatable<AgeRule>
    {
        /// <summary>
        /// Defines Units
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitsEnum
        {
            
            /// <summary>
            /// Enum Days for value: Days
            /// </summary>
            [EnumMember(Value = "Days")]
            Days = 1,
            
            /// <summary>
            /// Enum Weeks for value: Weeks
            /// </summary>
            [EnumMember(Value = "Weeks")]
            Weeks = 2,
            
            /// <summary>
            /// Enum Months for value: Months
            /// </summary>
            [EnumMember(Value = "Months")]
            Months = 3,
            
            /// <summary>
            /// Enum Quarters for value: Quarters
            /// </summary>
            [EnumMember(Value = "Quarters")]
            Quarters = 4,
            
            /// <summary>
            /// Enum Years for value: Years
            /// </summary>
            [EnumMember(Value = "Years")]
            Years = 5
        }

        /// <summary>
        /// Gets or Sets Units
        /// </summary>
        [DataMember(Name="units", EmitDefaultValue=false)]
        public UnitsEnum? Units { get; set; }
        /// <summary>
        /// Defines RelativeTo
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RelativeToEnum
        {
            
            /// <summary>
            /// Enum Actual for value: Actual
            /// </summary>
            [EnumMember(Value = "Actual")]
            Actual = 1,
            
            /// <summary>
            /// Enum Relative for value: Relative
            /// </summary>
            [EnumMember(Value = "Relative")]
            Relative = 2
        }

        /// <summary>
        /// Gets or Sets RelativeTo
        /// </summary>
        [DataMember(Name="relativeTo", EmitDefaultValue=false)]
        public RelativeToEnum? RelativeTo { get; set; }
        /// <summary>
        /// Defines ReferenceType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReferenceTypeEnum
        {
            
            /// <summary>
            /// Enum Today for value: Today
            /// </summary>
            [EnumMember(Value = "Today")]
            Today = 1,
            
            /// <summary>
            /// Enum ThisWeek for value: ThisWeek
            /// </summary>
            [EnumMember(Value = "ThisWeek")]
            ThisWeek = 2,
            
            /// <summary>
            /// Enum ThisMonth for value: ThisMonth
            /// </summary>
            [EnumMember(Value = "ThisMonth")]
            ThisMonth = 3,
            
            /// <summary>
            /// Enum ThisQuarter for value: ThisQuarter
            /// </summary>
            [EnumMember(Value = "ThisQuarter")]
            ThisQuarter = 4,
            
            /// <summary>
            /// Enum ThisYear for value: ThisYear
            /// </summary>
            [EnumMember(Value = "ThisYear")]
            ThisYear = 5,
            
            /// <summary>
            /// Enum ThisBusinessMonth for value: ThisBusinessMonth
            /// </summary>
            [EnumMember(Value = "ThisBusinessMonth")]
            ThisBusinessMonth = 6,
            
            /// <summary>
            /// Enum ThisBusinessQuarter for value: ThisBusinessQuarter
            /// </summary>
            [EnumMember(Value = "ThisBusinessQuarter")]
            ThisBusinessQuarter = 7,
            
            /// <summary>
            /// Enum ThisBusinessYear for value: ThisBusinessYear
            /// </summary>
            [EnumMember(Value = "ThisBusinessYear")]
            ThisBusinessYear = 8,
            
            /// <summary>
            /// Enum LoadDate for value: LoadDate
            /// </summary>
            [EnumMember(Value = "LoadDate")]
            LoadDate = 9,
            
            /// <summary>
            /// Enum LoadWeek for value: LoadWeek
            /// </summary>
            [EnumMember(Value = "LoadWeek")]
            LoadWeek = 10,
            
            /// <summary>
            /// Enum LoadMonth for value: LoadMonth
            /// </summary>
            [EnumMember(Value = "LoadMonth")]
            LoadMonth = 11,
            
            /// <summary>
            /// Enum LoadQuarter for value: LoadQuarter
            /// </summary>
            [EnumMember(Value = "LoadQuarter")]
            LoadQuarter = 12,
            
            /// <summary>
            /// Enum LoadYear for value: LoadYear
            /// </summary>
            [EnumMember(Value = "LoadYear")]
            LoadYear = 13,
            
            /// <summary>
            /// Enum FirstPopulatedDate for value: FirstPopulatedDate
            /// </summary>
            [EnumMember(Value = "FirstPopulatedDate")]
            FirstPopulatedDate = 14,
            
            /// <summary>
            /// Enum FirstPopulatedWeek for value: FirstPopulatedWeek
            /// </summary>
            [EnumMember(Value = "FirstPopulatedWeek")]
            FirstPopulatedWeek = 15,
            
            /// <summary>
            /// Enum FirstPopulatedMonth for value: FirstPopulatedMonth
            /// </summary>
            [EnumMember(Value = "FirstPopulatedMonth")]
            FirstPopulatedMonth = 16,
            
            /// <summary>
            /// Enum FirstPopulatedQuarter for value: FirstPopulatedQuarter
            /// </summary>
            [EnumMember(Value = "FirstPopulatedQuarter")]
            FirstPopulatedQuarter = 17,
            
            /// <summary>
            /// Enum FirstPopulatedYear for value: FirstPopulatedYear
            /// </summary>
            [EnumMember(Value = "FirstPopulatedYear")]
            FirstPopulatedYear = 18,
            
            /// <summary>
            /// Enum LastPopulatedDate for value: LastPopulatedDate
            /// </summary>
            [EnumMember(Value = "LastPopulatedDate")]
            LastPopulatedDate = 19,
            
            /// <summary>
            /// Enum LastPopulatedWeek for value: LastPopulatedWeek
            /// </summary>
            [EnumMember(Value = "LastPopulatedWeek")]
            LastPopulatedWeek = 20,
            
            /// <summary>
            /// Enum LastPopulatedMonth for value: LastPopulatedMonth
            /// </summary>
            [EnumMember(Value = "LastPopulatedMonth")]
            LastPopulatedMonth = 21,
            
            /// <summary>
            /// Enum LastPopulatedQuarter for value: LastPopulatedQuarter
            /// </summary>
            [EnumMember(Value = "LastPopulatedQuarter")]
            LastPopulatedQuarter = 22,
            
            /// <summary>
            /// Enum LastPopulatedYear for value: LastPopulatedYear
            /// </summary>
            [EnumMember(Value = "LastPopulatedYear")]
            LastPopulatedYear = 23
        }

        /// <summary>
        /// Gets or Sets ReferenceType
        /// </summary>
        [DataMember(Name="referenceType", EmitDefaultValue=false)]
        public ReferenceTypeEnum? ReferenceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgeRule" /> class.
        /// </summary>
        /// <param name="RangeLow">RangeLow.</param>
        /// <param name="RangeHigh">RangeHigh.</param>
        /// <param name="Units">Units.</param>
        /// <param name="RelativeTo">RelativeTo.</param>
        /// <param name="ReferenceType">ReferenceType.</param>
        /// <param name="ReferenceDate">ReferenceDate.</param>
        public AgeRule(int? RangeLow = default(int?), int? RangeHigh = default(int?), UnitsEnum? Units = default(UnitsEnum?), RelativeToEnum? RelativeTo = default(RelativeToEnum?), ReferenceTypeEnum? ReferenceType = default(ReferenceTypeEnum?), DateTime? ReferenceDate = default(DateTime?))
        {
            this.RangeLow = RangeLow;
            this.RangeHigh = RangeHigh;
            this.Units = Units;
            this.RelativeTo = RelativeTo;
            this.ReferenceType = ReferenceType;
            this.ReferenceDate = ReferenceDate;
        }
        
        /// <summary>
        /// Gets or Sets RangeLow
        /// </summary>
        [DataMember(Name="rangeLow", EmitDefaultValue=false)]
        public int? RangeLow { get; set; }

        /// <summary>
        /// Gets or Sets RangeHigh
        /// </summary>
        [DataMember(Name="rangeHigh", EmitDefaultValue=false)]
        public int? RangeHigh { get; set; }




        /// <summary>
        /// Gets or Sets ReferenceDate
        /// </summary>
        [DataMember(Name="referenceDate", EmitDefaultValue=false)]
        public DateTime? ReferenceDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgeRule {\n");
            sb.Append("  RangeLow: ").Append(RangeLow).Append("\n");
            sb.Append("  RangeHigh: ").Append(RangeHigh).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  RelativeTo: ").Append(RelativeTo).Append("\n");
            sb.Append("  ReferenceType: ").Append(ReferenceType).Append("\n");
            sb.Append("  ReferenceDate: ").Append(ReferenceDate).Append("\n");
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
            return this.Equals(input as AgeRule);
        }

        /// <summary>
        /// Returns true if AgeRule instances are equal
        /// </summary>
        /// <param name="input">Instance of AgeRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgeRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RangeLow == input.RangeLow ||
                    (this.RangeLow != null &&
                    this.RangeLow.Equals(input.RangeLow))
                ) && 
                (
                    this.RangeHigh == input.RangeHigh ||
                    (this.RangeHigh != null &&
                    this.RangeHigh.Equals(input.RangeHigh))
                ) && 
                (
                    this.Units == input.Units ||
                    (this.Units != null &&
                    this.Units.Equals(input.Units))
                ) && 
                (
                    this.RelativeTo == input.RelativeTo ||
                    (this.RelativeTo != null &&
                    this.RelativeTo.Equals(input.RelativeTo))
                ) && 
                (
                    this.ReferenceType == input.ReferenceType ||
                    (this.ReferenceType != null &&
                    this.ReferenceType.Equals(input.ReferenceType))
                ) && 
                (
                    this.ReferenceDate == input.ReferenceDate ||
                    (this.ReferenceDate != null &&
                    this.ReferenceDate.Equals(input.ReferenceDate))
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
                if (this.RangeLow != null)
                    hashCode = hashCode * 59 + this.RangeLow.GetHashCode();
                if (this.RangeHigh != null)
                    hashCode = hashCode * 59 + this.RangeHigh.GetHashCode();
                if (this.Units != null)
                    hashCode = hashCode * 59 + this.Units.GetHashCode();
                if (this.RelativeTo != null)
                    hashCode = hashCode * 59 + this.RelativeTo.GetHashCode();
                if (this.ReferenceType != null)
                    hashCode = hashCode * 59 + this.ReferenceType.GetHashCode();
                if (this.ReferenceDate != null)
                    hashCode = hashCode * 59 + this.ReferenceDate.GetHashCode();
                return hashCode;
            }
        }
    }

}
