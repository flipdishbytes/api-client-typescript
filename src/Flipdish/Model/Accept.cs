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
    /// Accept
    /// </summary>
    [DataContract]
    public partial class Accept :  IEquatable<Accept>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Accept" /> class.
        /// </summary>
        /// <param name="estimatedMinutesForDelivery">Estimated minutes for delivery.</param>
        public Accept(int? estimatedMinutesForDelivery = default(int?))
        {
            this.EstimatedMinutesForDelivery = estimatedMinutesForDelivery;
        }
        
        /// <summary>
        /// Estimated minutes for delivery
        /// </summary>
        /// <value>Estimated minutes for delivery</value>
        [DataMember(Name="EstimatedMinutesForDelivery", EmitDefaultValue=false)]
        public int? EstimatedMinutesForDelivery { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Accept {\n");
            sb.Append("  EstimatedMinutesForDelivery: ").Append(EstimatedMinutesForDelivery).Append("\n");
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
            return this.Equals(input as Accept);
        }

        /// <summary>
        /// Returns true if Accept instances are equal
        /// </summary>
        /// <param name="input">Instance of Accept to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Accept input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EstimatedMinutesForDelivery == input.EstimatedMinutesForDelivery ||
                    (this.EstimatedMinutesForDelivery != null &&
                    this.EstimatedMinutesForDelivery.Equals(input.EstimatedMinutesForDelivery))
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
                if (this.EstimatedMinutesForDelivery != null)
                    hashCode = hashCode * 59 + this.EstimatedMinutesForDelivery.GetHashCode();
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
            // EstimatedMinutesForDelivery (int?) maximum
            if(this.EstimatedMinutesForDelivery > (int?)200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EstimatedMinutesForDelivery, must be a value less than or equal to 200.", new [] { "EstimatedMinutesForDelivery" });
            }

            // EstimatedMinutesForDelivery (int?) minimum
            if(this.EstimatedMinutesForDelivery < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EstimatedMinutesForDelivery, must be a value greater than or equal to 0.", new [] { "EstimatedMinutesForDelivery" });
            }

            yield break;
        }
    }

}
