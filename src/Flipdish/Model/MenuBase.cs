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
    /// Menu base
    /// </summary>
    [DataContract]
    public partial class MenuBase :  IEquatable<MenuBase>, IValidatableObject
    {
        /// <summary>
        /// Menu section behaviour
        /// </summary>
        /// <value>Menu section behaviour</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MenuSectionBehaviourEnum
        {
            
            /// <summary>
            /// Enum ExpandSingle for value: ExpandSingle
            /// </summary>
            [EnumMember(Value = "ExpandSingle")]
            ExpandSingle = 1,
            
            /// <summary>
            /// Enum ExpandMultiple for value: ExpandMultiple
            /// </summary>
            [EnumMember(Value = "ExpandMultiple")]
            ExpandMultiple = 2
        }

        /// <summary>
        /// Menu section behaviour
        /// </summary>
        /// <value>Menu section behaviour</value>
        [DataMember(Name="MenuSectionBehaviour", EmitDefaultValue=false)]
        public MenuSectionBehaviourEnum? MenuSectionBehaviour { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuBase" /> class.
        /// </summary>
        /// <param name="displaySectionLinks">Display menu section link on UI.</param>
        /// <param name="menuSectionBehaviour">Menu section behaviour.</param>
        public MenuBase(bool? displaySectionLinks = default(bool?), MenuSectionBehaviourEnum? menuSectionBehaviour = default(MenuSectionBehaviourEnum?))
        {
            this.DisplaySectionLinks = displaySectionLinks;
            this.MenuSectionBehaviour = menuSectionBehaviour;
        }
        
        /// <summary>
        /// Display menu section link on UI
        /// </summary>
        /// <value>Display menu section link on UI</value>
        [DataMember(Name="DisplaySectionLinks", EmitDefaultValue=false)]
        public bool? DisplaySectionLinks { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MenuBase {\n");
            sb.Append("  DisplaySectionLinks: ").Append(DisplaySectionLinks).Append("\n");
            sb.Append("  MenuSectionBehaviour: ").Append(MenuSectionBehaviour).Append("\n");
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
            return this.Equals(input as MenuBase);
        }

        /// <summary>
        /// Returns true if MenuBase instances are equal
        /// </summary>
        /// <param name="input">Instance of MenuBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MenuBase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplaySectionLinks == input.DisplaySectionLinks ||
                    (this.DisplaySectionLinks != null &&
                    this.DisplaySectionLinks.Equals(input.DisplaySectionLinks))
                ) && 
                (
                    this.MenuSectionBehaviour == input.MenuSectionBehaviour ||
                    (this.MenuSectionBehaviour != null &&
                    this.MenuSectionBehaviour.Equals(input.MenuSectionBehaviour))
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
                if (this.DisplaySectionLinks != null)
                    hashCode = hashCode * 59 + this.DisplaySectionLinks.GetHashCode();
                if (this.MenuSectionBehaviour != null)
                    hashCode = hashCode * 59 + this.MenuSectionBehaviour.GetHashCode();
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
