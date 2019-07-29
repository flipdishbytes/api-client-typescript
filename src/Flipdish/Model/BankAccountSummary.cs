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
    /// BankAccountSummary
    /// </summary>
    [DataContract]
    public partial class BankAccountSummary :  IEquatable<BankAccountSummary>, IValidatableObject
    {
        /// <summary>
        /// Status of Account
        /// </summary>
        /// <value>Status of Account</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountStateEnum
        {
            
            /// <summary>
            /// Enum Unverified for value: Unverified
            /// </summary>
            [EnumMember(Value = "Unverified")]
            Unverified = 1,
            
            /// <summary>
            /// Enum AwatingVerification for value: AwatingVerification
            /// </summary>
            [EnumMember(Value = "AwatingVerification")]
            AwatingVerification = 2,
            
            /// <summary>
            /// Enum Verified for value: Verified
            /// </summary>
            [EnumMember(Value = "Verified")]
            Verified = 3,
            
            /// <summary>
            /// Enum Grandfathered for value: Grandfathered
            /// </summary>
            [EnumMember(Value = "Grandfathered")]
            Grandfathered = 4
        }

        /// <summary>
        /// Status of Account
        /// </summary>
        /// <value>Status of Account</value>
        [DataMember(Name="AccountState", EmitDefaultValue=false)]
        public AccountStateEnum? AccountState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountSummary" /> class.
        /// </summary>
        /// <param name="id">Id of this account.</param>
        /// <param name="storeNames">Store Names that are attached to this account.</param>
        /// <param name="accountState">Status of Account.</param>
        /// <param name="currencyCode">Currency of Account.</param>
        /// <param name="accountName">Name of this account.</param>
        /// <param name="iban">IBAN of this account.</param>
        /// <param name="swift">SWIFT of this bank account.</param>
        public BankAccountSummary(int? id = default(int?), List<string> storeNames = default(List<string>), AccountStateEnum? accountState = default(AccountStateEnum?), string currencyCode = default(string), string accountName = default(string), string iban = default(string), string swift = default(string))
        {
            this.Id = id;
            this.StoreNames = storeNames;
            this.AccountState = accountState;
            this.CurrencyCode = currencyCode;
            this.AccountName = accountName;
            this.Iban = iban;
            this.Swift = swift;
        }
        
        /// <summary>
        /// Id of this account
        /// </summary>
        /// <value>Id of this account</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Store Names that are attached to this account
        /// </summary>
        /// <value>Store Names that are attached to this account</value>
        [DataMember(Name="StoreNames", EmitDefaultValue=false)]
        public List<string> StoreNames { get; set; }


        /// <summary>
        /// Currency of Account
        /// </summary>
        /// <value>Currency of Account</value>
        [DataMember(Name="CurrencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Name of this account
        /// </summary>
        /// <value>Name of this account</value>
        [DataMember(Name="AccountName", EmitDefaultValue=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// IBAN of this account
        /// </summary>
        /// <value>IBAN of this account</value>
        [DataMember(Name="Iban", EmitDefaultValue=false)]
        public string Iban { get; set; }

        /// <summary>
        /// SWIFT of this bank account
        /// </summary>
        /// <value>SWIFT of this bank account</value>
        [DataMember(Name="Swift", EmitDefaultValue=false)]
        public string Swift { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankAccountSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StoreNames: ").Append(StoreNames).Append("\n");
            sb.Append("  AccountState: ").Append(AccountState).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  Swift: ").Append(Swift).Append("\n");
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
            return this.Equals(input as BankAccountSummary);
        }

        /// <summary>
        /// Returns true if BankAccountSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of BankAccountSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankAccountSummary input)
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
                    this.StoreNames == input.StoreNames ||
                    this.StoreNames != null &&
                    this.StoreNames.SequenceEqual(input.StoreNames)
                ) && 
                (
                    this.AccountState == input.AccountState ||
                    (this.AccountState != null &&
                    this.AccountState.Equals(input.AccountState))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.Iban == input.Iban ||
                    (this.Iban != null &&
                    this.Iban.Equals(input.Iban))
                ) && 
                (
                    this.Swift == input.Swift ||
                    (this.Swift != null &&
                    this.Swift.Equals(input.Swift))
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
                if (this.StoreNames != null)
                    hashCode = hashCode * 59 + this.StoreNames.GetHashCode();
                if (this.AccountState != null)
                    hashCode = hashCode * 59 + this.AccountState.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.Iban != null)
                    hashCode = hashCode * 59 + this.Iban.GetHashCode();
                if (this.Swift != null)
                    hashCode = hashCode * 59 + this.Swift.GetHashCode();
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
