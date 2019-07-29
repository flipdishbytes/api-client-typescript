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
    /// Menu section
    /// </summary>
    [DataContract]
    public partial class MenuSection :  IEquatable<MenuSection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuSection" /> class.
        /// </summary>
        /// <param name="menuSectionId">Menu section identifier.</param>
        /// <param name="imageUrl">Image url.</param>
        /// <param name="menuItems">Menu items.</param>
        /// <param name="menuSectionAvailability">Menu section availability.</param>
        /// <param name="publicId">Permanent reference to the item..</param>
        /// <param name="name">Name.</param>
        /// <param name="description">Description.</param>
        /// <param name="displayOrder">Display order.</param>
        /// <param name="isAvailable">Is available.</param>
        /// <param name="isHiddenFromCustomers">Is hidden from customer. Perhaps when the item is out of stock..</param>
        public MenuSection(int? menuSectionId = default(int?), string imageUrl = default(string), List<MenuSectionItem> menuItems = default(List<MenuSectionItem>), MenuSectionAvailability menuSectionAvailability = default(MenuSectionAvailability), Guid? publicId = default(Guid?), string name = default(string), string description = default(string), int? displayOrder = default(int?), bool? isAvailable = default(bool?), bool? isHiddenFromCustomers = default(bool?))
        {
            this.MenuSectionId = menuSectionId;
            this.ImageUrl = imageUrl;
            this.MenuItems = menuItems;
            this.MenuSectionAvailability = menuSectionAvailability;
            this.PublicId = publicId;
            this.Name = name;
            this.Description = description;
            this.DisplayOrder = displayOrder;
            this.IsAvailable = isAvailable;
            this.IsHiddenFromCustomers = isHiddenFromCustomers;
        }
        
        /// <summary>
        /// Menu section identifier
        /// </summary>
        /// <value>Menu section identifier</value>
        [DataMember(Name="MenuSectionId", EmitDefaultValue=false)]
        public int? MenuSectionId { get; set; }

        /// <summary>
        /// Image url
        /// </summary>
        /// <value>Image url</value>
        [DataMember(Name="ImageUrl", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Menu items
        /// </summary>
        /// <value>Menu items</value>
        [DataMember(Name="MenuItems", EmitDefaultValue=false)]
        public List<MenuSectionItem> MenuItems { get; set; }

        /// <summary>
        /// Menu section availability
        /// </summary>
        /// <value>Menu section availability</value>
        [DataMember(Name="MenuSectionAvailability", EmitDefaultValue=false)]
        public MenuSectionAvailability MenuSectionAvailability { get; set; }

        /// <summary>
        /// Permanent reference to the item.
        /// </summary>
        /// <value>Permanent reference to the item.</value>
        [DataMember(Name="PublicId", EmitDefaultValue=false)]
        public Guid? PublicId { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Display order
        /// </summary>
        /// <value>Display order</value>
        [DataMember(Name="DisplayOrder", EmitDefaultValue=false)]
        public int? DisplayOrder { get; set; }

        /// <summary>
        /// Is available
        /// </summary>
        /// <value>Is available</value>
        [DataMember(Name="IsAvailable", EmitDefaultValue=false)]
        public bool? IsAvailable { get; set; }

        /// <summary>
        /// Is hidden from customer. Perhaps when the item is out of stock.
        /// </summary>
        /// <value>Is hidden from customer. Perhaps when the item is out of stock.</value>
        [DataMember(Name="IsHiddenFromCustomers", EmitDefaultValue=false)]
        public bool? IsHiddenFromCustomers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MenuSection {\n");
            sb.Append("  MenuSectionId: ").Append(MenuSectionId).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  MenuItems: ").Append(MenuItems).Append("\n");
            sb.Append("  MenuSectionAvailability: ").Append(MenuSectionAvailability).Append("\n");
            sb.Append("  PublicId: ").Append(PublicId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
            sb.Append("  IsAvailable: ").Append(IsAvailable).Append("\n");
            sb.Append("  IsHiddenFromCustomers: ").Append(IsHiddenFromCustomers).Append("\n");
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
            return this.Equals(input as MenuSection);
        }

        /// <summary>
        /// Returns true if MenuSection instances are equal
        /// </summary>
        /// <param name="input">Instance of MenuSection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MenuSection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MenuSectionId == input.MenuSectionId ||
                    (this.MenuSectionId != null &&
                    this.MenuSectionId.Equals(input.MenuSectionId))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.MenuItems == input.MenuItems ||
                    this.MenuItems != null &&
                    this.MenuItems.SequenceEqual(input.MenuItems)
                ) && 
                (
                    this.MenuSectionAvailability == input.MenuSectionAvailability ||
                    (this.MenuSectionAvailability != null &&
                    this.MenuSectionAvailability.Equals(input.MenuSectionAvailability))
                ) && 
                (
                    this.PublicId == input.PublicId ||
                    (this.PublicId != null &&
                    this.PublicId.Equals(input.PublicId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisplayOrder == input.DisplayOrder ||
                    (this.DisplayOrder != null &&
                    this.DisplayOrder.Equals(input.DisplayOrder))
                ) && 
                (
                    this.IsAvailable == input.IsAvailable ||
                    (this.IsAvailable != null &&
                    this.IsAvailable.Equals(input.IsAvailable))
                ) && 
                (
                    this.IsHiddenFromCustomers == input.IsHiddenFromCustomers ||
                    (this.IsHiddenFromCustomers != null &&
                    this.IsHiddenFromCustomers.Equals(input.IsHiddenFromCustomers))
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
                if (this.MenuSectionId != null)
                    hashCode = hashCode * 59 + this.MenuSectionId.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.MenuItems != null)
                    hashCode = hashCode * 59 + this.MenuItems.GetHashCode();
                if (this.MenuSectionAvailability != null)
                    hashCode = hashCode * 59 + this.MenuSectionAvailability.GetHashCode();
                if (this.PublicId != null)
                    hashCode = hashCode * 59 + this.PublicId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayOrder != null)
                    hashCode = hashCode * 59 + this.DisplayOrder.GetHashCode();
                if (this.IsAvailable != null)
                    hashCode = hashCode * 59 + this.IsAvailable.GetHashCode();
                if (this.IsHiddenFromCustomers != null)
                    hashCode = hashCode * 59 + this.IsHiddenFromCustomers.GetHashCode();
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
