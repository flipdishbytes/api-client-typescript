/* 
 * Flipdish Open API v1.0
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Flipdish.Client.SwaggerDateConverter;

namespace Flipdish.Model
{
    /// <summary>
    /// BusinessHoursOverride
    /// </summary>
    [DataContract]
    public partial class BusinessHoursOverride :  IEquatable<BusinessHoursOverride>, IValidatableObject
    {
        /// <summary>
        /// Delivery or Pickup
        /// </summary>
        /// <value>Delivery or Pickup</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeliveryTypeEnum
        {
            
            /// <summary>
            /// Enum Delivery for value: Delivery
            /// </summary>
            [EnumMember(Value = "Delivery")]
            Delivery = 1,
            
            /// <summary>
            /// Enum Pickup for value: Pickup
            /// </summary>
            [EnumMember(Value = "Pickup")]
            Pickup = 2
        }

        /// <summary>
        /// Delivery or Pickup
        /// </summary>
        /// <value>Delivery or Pickup</value>
        [DataMember(Name="DeliveryType", EmitDefaultValue=false)]
        public DeliveryTypeEnum? DeliveryType { get; set; }
        /// <summary>
        /// Open, Closed or ClosedAllowPreOrders
        /// </summary>
        /// <value>Open, Closed or ClosedAllowPreOrders</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Open for value: Open
            /// </summary>
            [EnumMember(Value = "Open")]
            Open = 1,
            
            /// <summary>
            /// Enum Closed for value: Closed
            /// </summary>
            [EnumMember(Value = "Closed")]
            Closed = 2,
            
            /// <summary>
            /// Enum ClosedAllowPreOrders for value: ClosedAllowPreOrders
            /// </summary>
            [EnumMember(Value = "ClosedAllowPreOrders")]
            ClosedAllowPreOrders = 3
        }

        /// <summary>
        /// Open, Closed or ClosedAllowPreOrders
        /// </summary>
        /// <value>Open, Closed or ClosedAllowPreOrders</value>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessHoursOverride" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BusinessHoursOverride() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessHoursOverride" /> class.
        /// </summary>
        /// <param name="businessHoursOverrideId">Unique identifier.</param>
        /// <param name="deliveryType">Delivery or Pickup.</param>
        /// <param name="startTime">Date and time in ISO 8601 format. (required).</param>
        /// <param name="endTime">Date and time in ISO 8601 format. (required).</param>
        /// <param name="type">Open, Closed or ClosedAllowPreOrders.</param>
        public BusinessHoursOverride(int? businessHoursOverrideId = default(int?), DeliveryTypeEnum? deliveryType = default(DeliveryTypeEnum?), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), TypeEnum? type = default(TypeEnum?))
        {
            // to ensure "startTime" is required (not null)
            if (startTime == null)
            {
                throw new InvalidDataException("startTime is a required property for BusinessHoursOverride and cannot be null");
            }
            else
            {
                this.StartTime = startTime;
            }
            // to ensure "endTime" is required (not null)
            if (endTime == null)
            {
                throw new InvalidDataException("endTime is a required property for BusinessHoursOverride and cannot be null");
            }
            else
            {
                this.EndTime = endTime;
            }
            this.BusinessHoursOverrideId = businessHoursOverrideId;
            this.DeliveryType = deliveryType;
            this.Type = type;
        }
        
        /// <summary>
        /// Unique identifier
        /// </summary>
        /// <value>Unique identifier</value>
        [DataMember(Name="BusinessHoursOverrideId", EmitDefaultValue=false)]
        public int? BusinessHoursOverrideId { get; set; }


        /// <summary>
        /// Date and time in ISO 8601 format.
        /// </summary>
        /// <value>Date and time in ISO 8601 format.</value>
        [DataMember(Name="StartTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Date and time in ISO 8601 format.
        /// </summary>
        /// <value>Date and time in ISO 8601 format.</value>
        [DataMember(Name="EndTime", EmitDefaultValue=false)]
        public DateTime? EndTime { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessHoursOverride {\n");
            sb.Append("  BusinessHoursOverrideId: ").Append(BusinessHoursOverrideId).Append("\n");
            sb.Append("  DeliveryType: ").Append(DeliveryType).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as BusinessHoursOverride);
        }

        /// <summary>
        /// Returns true if BusinessHoursOverride instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessHoursOverride to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessHoursOverride input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BusinessHoursOverrideId == input.BusinessHoursOverrideId ||
                    (this.BusinessHoursOverrideId != null &&
                    this.BusinessHoursOverrideId.Equals(input.BusinessHoursOverrideId))
                ) && 
                (
                    this.DeliveryType == input.DeliveryType ||
                    (this.DeliveryType != null &&
                    this.DeliveryType.Equals(input.DeliveryType))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.BusinessHoursOverrideId != null)
                    hashCode = hashCode * 59 + this.BusinessHoursOverrideId.GetHashCode();
                if (this.DeliveryType != null)
                    hashCode = hashCode * 59 + this.DeliveryType.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
