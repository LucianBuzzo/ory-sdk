/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.0.0
 * Contact: office@ory.sh
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
    /// Indicates that a session was issued, and the application should use this token for authenticated requests
    /// </summary>
    [DataContract(Name = "continueWithSetOrySessionToken")]
    public partial class KratosContinueWithSetOrySessionToken : IEquatable<KratosContinueWithSetOrySessionToken>, IValidatableObject
    {
        /// <summary>
        /// Action will always be &#x60;set_ory_session_token&#x60; set_ory_session_token ContinueWithActionSetOrySessionToken show_verification_ui ContinueWithActionShowVerificationUI
        /// </summary>
        /// <value>Action will always be &#x60;set_ory_session_token&#x60; set_ory_session_token ContinueWithActionSetOrySessionToken show_verification_ui ContinueWithActionShowVerificationUI</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum SetOrySessionToken for value: set_ory_session_token
            /// </summary>
            [EnumMember(Value = "set_ory_session_token")]
            SetOrySessionToken = 1,

            /// <summary>
            /// Enum ShowVerificationUi for value: show_verification_ui
            /// </summary>
            [EnumMember(Value = "show_verification_ui")]
            ShowVerificationUi = 2

        }


        /// <summary>
        /// Action will always be &#x60;set_ory_session_token&#x60; set_ory_session_token ContinueWithActionSetOrySessionToken show_verification_ui ContinueWithActionShowVerificationUI
        /// </summary>
        /// <value>Action will always be &#x60;set_ory_session_token&#x60; set_ory_session_token ContinueWithActionSetOrySessionToken show_verification_ui ContinueWithActionShowVerificationUI</value>
        [DataMember(Name = "action", IsRequired = true, EmitDefaultValue = false)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosContinueWithSetOrySessionToken" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KratosContinueWithSetOrySessionToken()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosContinueWithSetOrySessionToken" /> class.
        /// </summary>
        /// <param name="action">Action will always be &#x60;set_ory_session_token&#x60; set_ory_session_token ContinueWithActionSetOrySessionToken show_verification_ui ContinueWithActionShowVerificationUI (required).</param>
        /// <param name="orySessionToken">Token is the token of the session (required).</param>
        public KratosContinueWithSetOrySessionToken(ActionEnum action = default(ActionEnum), string orySessionToken = default(string))
        {
            this.Action = action;
            // to ensure "orySessionToken" is required (not null)
            if (orySessionToken == null) {
                throw new ArgumentNullException("orySessionToken is a required property for KratosContinueWithSetOrySessionToken and cannot be null");
            }
            this.OrySessionToken = orySessionToken;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Token is the token of the session
        /// </summary>
        /// <value>Token is the token of the session</value>
        [DataMember(Name = "ory_session_token", IsRequired = true, EmitDefaultValue = false)]
        public string OrySessionToken { get; set; }

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
            sb.Append("class KratosContinueWithSetOrySessionToken {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  OrySessionToken: ").Append(OrySessionToken).Append("\n");
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
            return this.Equals(input as KratosContinueWithSetOrySessionToken);
        }

        /// <summary>
        /// Returns true if KratosContinueWithSetOrySessionToken instances are equal
        /// </summary>
        /// <param name="input">Instance of KratosContinueWithSetOrySessionToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KratosContinueWithSetOrySessionToken input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
                ) && 
                (
                    this.OrySessionToken == input.OrySessionToken ||
                    (this.OrySessionToken != null &&
                    this.OrySessionToken.Equals(input.OrySessionToken))
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
                hashCode = (hashCode * 59) + this.Action.GetHashCode();
                if (this.OrySessionToken != null)
                {
                    hashCode = (hashCode * 59) + this.OrySessionToken.GetHashCode();
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
