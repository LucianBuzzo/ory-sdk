/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.40
 * Contact: support@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Client.Client.OpenAPIDateConverter;

namespace Ory.Client.Model
{
    /// <summary>
    /// VerifiableAddress is an identity&#39;s verifiable address
    /// </summary>
    [DataContract(Name = "verifiableIdentityAddress")]
    public partial class ClientVerifiableIdentityAddress : IEquatable<ClientVerifiableIdentityAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientVerifiableIdentityAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientVerifiableIdentityAddress()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientVerifiableIdentityAddress" /> class.
        /// </summary>
        /// <param name="createdAt">When this entry was created.</param>
        /// <param name="id">id (required).</param>
        /// <param name="status">VerifiableAddressStatus must not exceed 16 characters as that is the limitation in the SQL Schema (required).</param>
        /// <param name="updatedAt">When this entry was last updated.</param>
        /// <param name="value">The address value  example foo@user.com (required).</param>
        /// <param name="verified">Indicates if the address has already been verified (required).</param>
        /// <param name="verifiedAt">verifiedAt.</param>
        /// <param name="via">VerifiableAddressType must not exceed 16 characters as that is the limitation in the SQL Schema (required).</param>
        public ClientVerifiableIdentityAddress(DateTime createdAt = default(DateTime), string id = default(string), string status = default(string), DateTime updatedAt = default(DateTime), string value = default(string), bool verified = default(bool), DateTime verifiedAt = default(DateTime), string via = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for ClientVerifiableIdentityAddress and cannot be null");
            }
            this.Id = id;
            // to ensure "status" is required (not null)
            if (status == null) {
                throw new ArgumentNullException("status is a required property for ClientVerifiableIdentityAddress and cannot be null");
            }
            this.Status = status;
            // to ensure "value" is required (not null)
            if (value == null) {
                throw new ArgumentNullException("value is a required property for ClientVerifiableIdentityAddress and cannot be null");
            }
            this.Value = value;
            this.Verified = verified;
            // to ensure "via" is required (not null)
            if (via == null) {
                throw new ArgumentNullException("via is a required property for ClientVerifiableIdentityAddress and cannot be null");
            }
            this.Via = via;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.VerifiedAt = verifiedAt;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// When this entry was created
        /// </summary>
        /// <value>When this entry was created</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// VerifiableAddressStatus must not exceed 16 characters as that is the limitation in the SQL Schema
        /// </summary>
        /// <value>VerifiableAddressStatus must not exceed 16 characters as that is the limitation in the SQL Schema</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// When this entry was last updated
        /// </summary>
        /// <value>When this entry was last updated</value>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The address value  example foo@user.com
        /// </summary>
        /// <value>The address value  example foo@user.com</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Indicates if the address has already been verified
        /// </summary>
        /// <value>Indicates if the address has already been verified</value>
        [DataMember(Name = "verified", IsRequired = true, EmitDefaultValue = true)]
        public bool Verified { get; set; }

        /// <summary>
        /// Gets or Sets VerifiedAt
        /// </summary>
        [DataMember(Name = "verified_at", EmitDefaultValue = false)]
        public DateTime VerifiedAt { get; set; }

        /// <summary>
        /// VerifiableAddressType must not exceed 16 characters as that is the limitation in the SQL Schema
        /// </summary>
        /// <value>VerifiableAddressType must not exceed 16 characters as that is the limitation in the SQL Schema</value>
        [DataMember(Name = "via", IsRequired = true, EmitDefaultValue = false)]
        public string Via { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientVerifiableIdentityAddress {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Verified: ").Append(Verified).Append("\n");
            sb.Append("  VerifiedAt: ").Append(VerifiedAt).Append("\n");
            sb.Append("  Via: ").Append(Via).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClientVerifiableIdentityAddress);
        }

        /// <summary>
        /// Returns true if ClientVerifiableIdentityAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientVerifiableIdentityAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientVerifiableIdentityAddress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Verified == input.Verified ||
                    this.Verified.Equals(input.Verified)
                ) && 
                (
                    this.VerifiedAt == input.VerifiedAt ||
                    (this.VerifiedAt != null &&
                    this.VerifiedAt.Equals(input.VerifiedAt))
                ) && 
                (
                    this.Via == input.Via ||
                    (this.Via != null &&
                    this.Via.Equals(input.Via))
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
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
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                hashCode = hashCode * 59 + this.Verified.GetHashCode();
                if (this.VerifiedAt != null)
                    hashCode = hashCode * 59 + this.VerifiedAt.GetHashCode();
                if (this.Via != null)
                    hashCode = hashCode * 59 + this.Via.GetHashCode();
                if (this.AdditionalProperties != null)
                    hashCode = hashCode * 59 + this.AdditionalProperties.GetHashCode();
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
