/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.7.3-alpha.1
 * Contact: hi@ory.sh
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
using OpenAPIDateConverter = Ory.Kratos.Client.Client.OpenAPIDateConverter;

namespace Ory.Kratos.Client.Model
{
    /// <summary>
    /// A Session
    /// </summary>
    [DataContract(Name = "session")]
    public partial class KratosSession : IEquatable<KratosSession>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosSession" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KratosSession()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosSession" /> class.
        /// </summary>
        /// <param name="active">Whether or not the session is active..</param>
        /// <param name="authenticatedAt">The Session Authentication Timestamp  When this session was authenticated at..</param>
        /// <param name="expiresAt">The Session Expiry  When this session expires at..</param>
        /// <param name="id">id (required).</param>
        /// <param name="identity">identity (required).</param>
        /// <param name="issuedAt">The Session Issuance Timestamp  When this session was authenticated at..</param>
        public KratosSession(bool active = default(bool), DateTime authenticatedAt = default(DateTime), DateTime expiresAt = default(DateTime), string id = default(string), KratosIdentity identity = default(KratosIdentity), DateTime issuedAt = default(DateTime))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for KratosSession and cannot be null");
            // to ensure "identity" is required (not null)
            this.Identity = identity ?? throw new ArgumentNullException("identity is a required property for KratosSession and cannot be null");
            this.Active = active;
            this.AuthenticatedAt = authenticatedAt;
            this.ExpiresAt = expiresAt;
            this.IssuedAt = issuedAt;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Whether or not the session is active.
        /// </summary>
        /// <value>Whether or not the session is active.</value>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// The Session Authentication Timestamp  When this session was authenticated at.
        /// </summary>
        /// <value>The Session Authentication Timestamp  When this session was authenticated at.</value>
        [DataMember(Name = "authenticated_at", EmitDefaultValue = false)]
        public DateTime AuthenticatedAt { get; set; }

        /// <summary>
        /// The Session Expiry  When this session expires at.
        /// </summary>
        /// <value>The Session Expiry  When this session expires at.</value>
        [DataMember(Name = "expires_at", EmitDefaultValue = false)]
        public DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Identity
        /// </summary>
        [DataMember(Name = "identity", IsRequired = true, EmitDefaultValue = false)]
        public KratosIdentity Identity { get; set; }

        /// <summary>
        /// The Session Issuance Timestamp  When this session was authenticated at.
        /// </summary>
        /// <value>The Session Issuance Timestamp  When this session was authenticated at.</value>
        [DataMember(Name = "issued_at", EmitDefaultValue = false)]
        public DateTime IssuedAt { get; set; }

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
            sb.Append("class KratosSession {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  AuthenticatedAt: ").Append(AuthenticatedAt).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Identity: ").Append(Identity).Append("\n");
            sb.Append("  IssuedAt: ").Append(IssuedAt).Append("\n");
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
            return this.Equals(input as KratosSession);
        }

        /// <summary>
        /// Returns true if KratosSession instances are equal
        /// </summary>
        /// <param name="input">Instance of KratosSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KratosSession input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.AuthenticatedAt == input.AuthenticatedAt ||
                    (this.AuthenticatedAt != null &&
                    this.AuthenticatedAt.Equals(input.AuthenticatedAt))
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Identity == input.Identity ||
                    (this.Identity != null &&
                    this.Identity.Equals(input.Identity))
                ) && 
                (
                    this.IssuedAt == input.IssuedAt ||
                    (this.IssuedAt != null &&
                    this.IssuedAt.Equals(input.IssuedAt))
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
                hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.AuthenticatedAt != null)
                    hashCode = hashCode * 59 + this.AuthenticatedAt.GetHashCode();
                if (this.ExpiresAt != null)
                    hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Identity != null)
                    hashCode = hashCode * 59 + this.Identity.GetHashCode();
                if (this.IssuedAt != null)
                    hashCode = hashCode * 59 + this.IssuedAt.GetHashCode();
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
