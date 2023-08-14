/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.45
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
    /// ClientCORS
    /// </summary>
    [DataContract(Name = "CORS")]
    public partial class ClientCORS : IEquatable<ClientCORS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientCORS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientCORS()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientCORS" /> class.
        /// </summary>
        /// <param name="enabled">Whether CORS is enabled for this endpoint. (required).</param>
        /// <param name="origins">The allowed origins. Use &#x60;*&#x60; to allow all origins. A wildcard can also be used in the subdomain, i.e. &#x60;https://_*.example.com&#x60; will allow all origins on all subdomains of &#x60;example.com&#x60;. (required).</param>
        public ClientCORS(bool enabled = default(bool), List<string> origins = default(List<string>))
        {
            this.Enabled = enabled;
            // to ensure "origins" is required (not null)
            if (origins == null) {
                throw new ArgumentNullException("origins is a required property for ClientCORS and cannot be null");
            }
            this.Origins = origins;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Whether CORS is enabled for this endpoint.
        /// </summary>
        /// <value>Whether CORS is enabled for this endpoint.</value>
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// The allowed origins. Use &#x60;*&#x60; to allow all origins. A wildcard can also be used in the subdomain, i.e. &#x60;https://_*.example.com&#x60; will allow all origins on all subdomains of &#x60;example.com&#x60;.
        /// </summary>
        /// <value>The allowed origins. Use &#x60;*&#x60; to allow all origins. A wildcard can also be used in the subdomain, i.e. &#x60;https://_*.example.com&#x60; will allow all origins on all subdomains of &#x60;example.com&#x60;.</value>
        [DataMember(Name = "origins", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Origins { get; set; }

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
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClientCORS {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Origins: ").Append(Origins).Append("\n");
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
            return this.Equals(input as ClientCORS);
        }

        /// <summary>
        /// Returns true if ClientCORS instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientCORS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientCORS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Origins == input.Origins ||
                    this.Origins != null &&
                    input.Origins != null &&
                    this.Origins.SequenceEqual(input.Origins)
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
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                if (this.Origins != null)
                {
                    hashCode = (hashCode * 59) + this.Origins.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}