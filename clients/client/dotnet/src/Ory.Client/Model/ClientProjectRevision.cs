/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.52
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
    /// ClientProjectRevision
    /// </summary>
    [DataContract(Name = "projectRevision")]
    public partial class ClientProjectRevision : IEquatable<ClientProjectRevision>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientProjectRevision" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientProjectRevision()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientProjectRevision" /> class.
        /// </summary>
        /// <param name="apiUrl">The Project API URL  The URL where the Project&#39;s APIs are available. (required).</param>
        /// <param name="applicationUrl">Your Application URL  The URL where your application is available. Your users will be redirected to this URL when they successfully complete a login, logout, verification, recovery, or registration flow.  More fine-grained redirection patterns are available for the individual flows. (required).</param>
        /// <param name="defaultIdentitySchemaUrl">Default Identity Schema URL  This represents your Ory Kratos Default Identity Schema. It is your identity&#39;s default schema. This allows setting custom fields such as \&quot;address\&quot;, specifying whether you want to log in using email or a username, and more. For more information on this topic, please check out the identity documentation.  The value of this field can be either any \&quot;https://\&quot; URL - for example a file hosted at GitHub, or a &#x60;preset://&#x60;-prefixed string. Available profiles are:  profile://email profile://username (required).</param>
        /// <param name="errorUiUrl">Self-Service Error UI URL  Sets the UI URL for the error UI. If left empty, this will use Ory&#39;s hosted pages..</param>
        /// <param name="hosts">hosts (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="kratosCustomSchemaId">kratosCustomSchemaId.</param>
        /// <param name="loginUiUrl">Self-Service Login UI URL  Sets the UI URL for the login UI. If left empty, this will use Ory&#39;s hosted pages..</param>
        /// <param name="lookupSecret">lookupSecret.</param>
        /// <param name="name">The project&#39;s name. (required).</param>
        /// <param name="oidcProviders">oidcProviders.</param>
        /// <param name="password">password.</param>
        /// <param name="projectId">projectId (required).</param>
        /// <param name="recovery">recovery.</param>
        /// <param name="recoveryUiUrl">Self-Service Login UI URL  Sets the UI URL for the recovery UI. If left empty, this will use Ory&#39;s hosted pages..</param>
        /// <param name="redirectionConfig">redirectionConfig.</param>
        /// <param name="registrationUiUrl">Self-Service Login UI URL  Sets the UI URL for the registration UI. If left empty, this will use Ory&#39;s hosted pages..</param>
        /// <param name="sessionAfterSignUp">Issue Session after Sign Up  If set to true, users will receive a session after they successfully signed up. Enabling this option allows account enumeration during registration flows. Read more: https://www.ory.sh/kratos/docs/self-service/flows/user-registration#successful-registration (required).</param>
        /// <param name="sessionSoft2fa">Enable Soft 2FA for Login Sessions.</param>
        /// <param name="settingsPrivilegedSessionMaxAgeSeconds">Duration in Seconds of how long a Session is Privileged  Defines how long a session is considered privileged in seconds. If the session&#39;s authenticated_at is older than the value specified here, the user needs to re-authenticate to perform certain actions (e.g. password change)..</param>
        /// <param name="settingsSoft2fa">Enable Soft 2FA for Self-Service Settings Flows.</param>
        /// <param name="settingsUiUrl">Self-Service Settings UI URL  Sets the UI URL for the settings UI. If left empty, this will use Ory&#39;s hosted pages..</param>
        /// <param name="totp">totp.</param>
        /// <param name="verification">verification.</param>
        /// <param name="verificationUiUrl">Self-Service Login UI URL  Sets the UI URL for the verification UI. If left empty, this will use Ory&#39;s hosted pages..</param>
        /// <param name="webauthn">webauthn.</param>
        public ClientProjectRevision(string apiUrl = default(string), string applicationUrl = default(string), string defaultIdentitySchemaUrl = default(string), string errorUiUrl = default(string), List<string> hosts = default(List<string>), string id = default(string), string kratosCustomSchemaId = default(string), string loginUiUrl = default(string), ClientProjectLookupSecretConfig lookupSecret = default(ClientProjectLookupSecretConfig), string name = default(string), List<ClientProjectOidcConfig> oidcProviders = default(List<ClientProjectOidcConfig>), ClientProjectPasswordConfig password = default(ClientProjectPasswordConfig), string projectId = default(string), ClientProjectRecoveryConfig recovery = default(ClientProjectRecoveryConfig), string recoveryUiUrl = default(string), ClientRedirectionConfig redirectionConfig = default(ClientRedirectionConfig), string registrationUiUrl = default(string), bool sessionAfterSignUp = default(bool), bool sessionSoft2fa = default(bool), long settingsPrivilegedSessionMaxAgeSeconds = default(long), bool settingsSoft2fa = default(bool), string settingsUiUrl = default(string), ClientProjectTotpConfig totp = default(ClientProjectTotpConfig), ClientProjectVerificationConfig verification = default(ClientProjectVerificationConfig), string verificationUiUrl = default(string), ClientProjectWebAuthnConfig webauthn = default(ClientProjectWebAuthnConfig))
        {
            // to ensure "apiUrl" is required (not null)
            if (apiUrl == null) {
                throw new ArgumentNullException("apiUrl is a required property for ClientProjectRevision and cannot be null");
            }
            this.ApiUrl = apiUrl;
            // to ensure "applicationUrl" is required (not null)
            if (applicationUrl == null) {
                throw new ArgumentNullException("applicationUrl is a required property for ClientProjectRevision and cannot be null");
            }
            this.ApplicationUrl = applicationUrl;
            // to ensure "defaultIdentitySchemaUrl" is required (not null)
            if (defaultIdentitySchemaUrl == null) {
                throw new ArgumentNullException("defaultIdentitySchemaUrl is a required property for ClientProjectRevision and cannot be null");
            }
            this.DefaultIdentitySchemaUrl = defaultIdentitySchemaUrl;
            // to ensure "hosts" is required (not null)
            if (hosts == null) {
                throw new ArgumentNullException("hosts is a required property for ClientProjectRevision and cannot be null");
            }
            this.Hosts = hosts;
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for ClientProjectRevision and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for ClientProjectRevision and cannot be null");
            }
            this.Name = name;
            // to ensure "projectId" is required (not null)
            if (projectId == null) {
                throw new ArgumentNullException("projectId is a required property for ClientProjectRevision and cannot be null");
            }
            this.ProjectId = projectId;
            this.SessionAfterSignUp = sessionAfterSignUp;
            this.ErrorUiUrl = errorUiUrl;
            this.KratosCustomSchemaId = kratosCustomSchemaId;
            this.LoginUiUrl = loginUiUrl;
            this.LookupSecret = lookupSecret;
            this.OidcProviders = oidcProviders;
            this.Password = password;
            this.Recovery = recovery;
            this.RecoveryUiUrl = recoveryUiUrl;
            this.RedirectionConfig = redirectionConfig;
            this.RegistrationUiUrl = registrationUiUrl;
            this.SessionSoft2fa = sessionSoft2fa;
            this.SettingsPrivilegedSessionMaxAgeSeconds = settingsPrivilegedSessionMaxAgeSeconds;
            this.SettingsSoft2fa = settingsSoft2fa;
            this.SettingsUiUrl = settingsUiUrl;
            this.Totp = totp;
            this.Verification = verification;
            this.VerificationUiUrl = verificationUiUrl;
            this.Webauthn = webauthn;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The Project API URL  The URL where the Project&#39;s APIs are available.
        /// </summary>
        /// <value>The Project API URL  The URL where the Project&#39;s APIs are available.</value>
        [DataMember(Name = "api_url", IsRequired = true, EmitDefaultValue = false)]
        public string ApiUrl { get; set; }

        /// <summary>
        /// Your Application URL  The URL where your application is available. Your users will be redirected to this URL when they successfully complete a login, logout, verification, recovery, or registration flow.  More fine-grained redirection patterns are available for the individual flows.
        /// </summary>
        /// <value>Your Application URL  The URL where your application is available. Your users will be redirected to this URL when they successfully complete a login, logout, verification, recovery, or registration flow.  More fine-grained redirection patterns are available for the individual flows.</value>
        [DataMember(Name = "application_url", IsRequired = true, EmitDefaultValue = false)]
        public string ApplicationUrl { get; set; }

        /// <summary>
        /// The Project&#39;s Revision Creation Date
        /// </summary>
        /// <value>The Project&#39;s Revision Creation Date</value>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// Default Identity Schema URL  This represents your Ory Kratos Default Identity Schema. It is your identity&#39;s default schema. This allows setting custom fields such as \&quot;address\&quot;, specifying whether you want to log in using email or a username, and more. For more information on this topic, please check out the identity documentation.  The value of this field can be either any \&quot;https://\&quot; URL - for example a file hosted at GitHub, or a &#x60;preset://&#x60;-prefixed string. Available profiles are:  profile://email profile://username
        /// </summary>
        /// <value>Default Identity Schema URL  This represents your Ory Kratos Default Identity Schema. It is your identity&#39;s default schema. This allows setting custom fields such as \&quot;address\&quot;, specifying whether you want to log in using email or a username, and more. For more information on this topic, please check out the identity documentation.  The value of this field can be either any \&quot;https://\&quot; URL - for example a file hosted at GitHub, or a &#x60;preset://&#x60;-prefixed string. Available profiles are:  profile://email profile://username</value>
        [DataMember(Name = "default_identity_schema_url", IsRequired = true, EmitDefaultValue = false)]
        public string DefaultIdentitySchemaUrl { get; set; }

        /// <summary>
        /// Self-Service Error UI URL  Sets the UI URL for the error UI. If left empty, this will use Ory&#39;s hosted pages.
        /// </summary>
        /// <value>Self-Service Error UI URL  Sets the UI URL for the error UI. If left empty, this will use Ory&#39;s hosted pages.</value>
        [DataMember(Name = "error_ui_url", EmitDefaultValue = false)]
        public string ErrorUiUrl { get; set; }

        /// <summary>
        /// Gets or Sets Hosts
        /// </summary>
        [DataMember(Name = "hosts", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Hosts { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The Project&#39;s Kratos Config Version
        /// </summary>
        /// <value>The Project&#39;s Kratos Config Version</value>
        [DataMember(Name = "kratos_config_version", EmitDefaultValue = false)]
        public string KratosConfigVersion { get; private set; }

        /// <summary>
        /// Returns false as KratosConfigVersion should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeKratosConfigVersion()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets KratosCustomSchemaId
        /// </summary>
        [DataMember(Name = "kratos_custom_schema_id", EmitDefaultValue = false)]
        public string KratosCustomSchemaId { get; set; }

        /// <summary>
        /// Self-Service Login UI URL  Sets the UI URL for the login UI. If left empty, this will use Ory&#39;s hosted pages.
        /// </summary>
        /// <value>Self-Service Login UI URL  Sets the UI URL for the login UI. If left empty, this will use Ory&#39;s hosted pages.</value>
        [DataMember(Name = "login_ui_url", EmitDefaultValue = false)]
        public string LoginUiUrl { get; set; }

        /// <summary>
        /// Gets or Sets LookupSecret
        /// </summary>
        [DataMember(Name = "lookup_secret", EmitDefaultValue = false)]
        public ClientProjectLookupSecretConfig LookupSecret { get; set; }

        /// <summary>
        /// The project&#39;s name.
        /// </summary>
        /// <value>The project&#39;s name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets OidcProviders
        /// </summary>
        [DataMember(Name = "oidc_providers", EmitDefaultValue = false)]
        public List<ClientProjectOidcConfig> OidcProviders { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public ClientProjectPasswordConfig Password { get; set; }

        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        [DataMember(Name = "project_id", IsRequired = true, EmitDefaultValue = false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets Recovery
        /// </summary>
        [DataMember(Name = "recovery", EmitDefaultValue = false)]
        public ClientProjectRecoveryConfig Recovery { get; set; }

        /// <summary>
        /// Self-Service Login UI URL  Sets the UI URL for the recovery UI. If left empty, this will use Ory&#39;s hosted pages.
        /// </summary>
        /// <value>Self-Service Login UI URL  Sets the UI URL for the recovery UI. If left empty, this will use Ory&#39;s hosted pages.</value>
        [DataMember(Name = "recovery_ui_url", EmitDefaultValue = false)]
        public string RecoveryUiUrl { get; set; }

        /// <summary>
        /// Gets or Sets RedirectionConfig
        /// </summary>
        [DataMember(Name = "redirection_config", EmitDefaultValue = false)]
        public ClientRedirectionConfig RedirectionConfig { get; set; }

        /// <summary>
        /// Self-Service Login UI URL  Sets the UI URL for the registration UI. If left empty, this will use Ory&#39;s hosted pages.
        /// </summary>
        /// <value>Self-Service Login UI URL  Sets the UI URL for the registration UI. If left empty, this will use Ory&#39;s hosted pages.</value>
        [DataMember(Name = "registration_ui_url", EmitDefaultValue = false)]
        public string RegistrationUiUrl { get; set; }

        /// <summary>
        /// Issue Session after Sign Up  If set to true, users will receive a session after they successfully signed up. Enabling this option allows account enumeration during registration flows. Read more: https://www.ory.sh/kratos/docs/self-service/flows/user-registration#successful-registration
        /// </summary>
        /// <value>Issue Session after Sign Up  If set to true, users will receive a session after they successfully signed up. Enabling this option allows account enumeration during registration flows. Read more: https://www.ory.sh/kratos/docs/self-service/flows/user-registration#successful-registration</value>
        [DataMember(Name = "session_after_sign_up", IsRequired = true, EmitDefaultValue = true)]
        public bool SessionAfterSignUp { get; set; }

        /// <summary>
        /// Enable Soft 2FA for Login Sessions
        /// </summary>
        /// <value>Enable Soft 2FA for Login Sessions</value>
        [DataMember(Name = "session_soft_2fa", EmitDefaultValue = true)]
        public bool SessionSoft2fa { get; set; }

        /// <summary>
        /// Duration in Seconds of how long a Session is Privileged  Defines how long a session is considered privileged in seconds. If the session&#39;s authenticated_at is older than the value specified here, the user needs to re-authenticate to perform certain actions (e.g. password change).
        /// </summary>
        /// <value>Duration in Seconds of how long a Session is Privileged  Defines how long a session is considered privileged in seconds. If the session&#39;s authenticated_at is older than the value specified here, the user needs to re-authenticate to perform certain actions (e.g. password change).</value>
        [DataMember(Name = "settings_privileged_session_max_age_seconds", EmitDefaultValue = false)]
        public long SettingsPrivilegedSessionMaxAgeSeconds { get; set; }

        /// <summary>
        /// Enable Soft 2FA for Self-Service Settings Flows
        /// </summary>
        /// <value>Enable Soft 2FA for Self-Service Settings Flows</value>
        [DataMember(Name = "settings_soft_2fa", EmitDefaultValue = true)]
        public bool SettingsSoft2fa { get; set; }

        /// <summary>
        /// Self-Service Settings UI URL  Sets the UI URL for the settings UI. If left empty, this will use Ory&#39;s hosted pages.
        /// </summary>
        /// <value>Self-Service Settings UI URL  Sets the UI URL for the settings UI. If left empty, this will use Ory&#39;s hosted pages.</value>
        [DataMember(Name = "settings_ui_url", EmitDefaultValue = false)]
        public string SettingsUiUrl { get; set; }

        /// <summary>
        /// Gets or Sets Totp
        /// </summary>
        [DataMember(Name = "totp", EmitDefaultValue = false)]
        public ClientProjectTotpConfig Totp { get; set; }

        /// <summary>
        /// Last Time Project&#39;s Revision was Updated
        /// </summary>
        /// <value>Last Time Project&#39;s Revision was Updated</value>
        [DataMember(Name = "updated_at", IsRequired = true, EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Verification
        /// </summary>
        [DataMember(Name = "verification", EmitDefaultValue = false)]
        public ClientProjectVerificationConfig Verification { get; set; }

        /// <summary>
        /// Self-Service Login UI URL  Sets the UI URL for the verification UI. If left empty, this will use Ory&#39;s hosted pages.
        /// </summary>
        /// <value>Self-Service Login UI URL  Sets the UI URL for the verification UI. If left empty, this will use Ory&#39;s hosted pages.</value>
        [DataMember(Name = "verification_ui_url", EmitDefaultValue = false)]
        public string VerificationUiUrl { get; set; }

        /// <summary>
        /// Gets or Sets Webauthn
        /// </summary>
        [DataMember(Name = "webauthn", EmitDefaultValue = false)]
        public ClientProjectWebAuthnConfig Webauthn { get; set; }

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
            sb.Append("class ClientProjectRevision {\n");
            sb.Append("  ApiUrl: ").Append(ApiUrl).Append("\n");
            sb.Append("  ApplicationUrl: ").Append(ApplicationUrl).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  DefaultIdentitySchemaUrl: ").Append(DefaultIdentitySchemaUrl).Append("\n");
            sb.Append("  ErrorUiUrl: ").Append(ErrorUiUrl).Append("\n");
            sb.Append("  Hosts: ").Append(Hosts).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  KratosConfigVersion: ").Append(KratosConfigVersion).Append("\n");
            sb.Append("  KratosCustomSchemaId: ").Append(KratosCustomSchemaId).Append("\n");
            sb.Append("  LoginUiUrl: ").Append(LoginUiUrl).Append("\n");
            sb.Append("  LookupSecret: ").Append(LookupSecret).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OidcProviders: ").Append(OidcProviders).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  Recovery: ").Append(Recovery).Append("\n");
            sb.Append("  RecoveryUiUrl: ").Append(RecoveryUiUrl).Append("\n");
            sb.Append("  RedirectionConfig: ").Append(RedirectionConfig).Append("\n");
            sb.Append("  RegistrationUiUrl: ").Append(RegistrationUiUrl).Append("\n");
            sb.Append("  SessionAfterSignUp: ").Append(SessionAfterSignUp).Append("\n");
            sb.Append("  SessionSoft2fa: ").Append(SessionSoft2fa).Append("\n");
            sb.Append("  SettingsPrivilegedSessionMaxAgeSeconds: ").Append(SettingsPrivilegedSessionMaxAgeSeconds).Append("\n");
            sb.Append("  SettingsSoft2fa: ").Append(SettingsSoft2fa).Append("\n");
            sb.Append("  SettingsUiUrl: ").Append(SettingsUiUrl).Append("\n");
            sb.Append("  Totp: ").Append(Totp).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Verification: ").Append(Verification).Append("\n");
            sb.Append("  VerificationUiUrl: ").Append(VerificationUiUrl).Append("\n");
            sb.Append("  Webauthn: ").Append(Webauthn).Append("\n");
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
            return this.Equals(input as ClientProjectRevision);
        }

        /// <summary>
        /// Returns true if ClientProjectRevision instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientProjectRevision to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientProjectRevision input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiUrl == input.ApiUrl ||
                    (this.ApiUrl != null &&
                    this.ApiUrl.Equals(input.ApiUrl))
                ) && 
                (
                    this.ApplicationUrl == input.ApplicationUrl ||
                    (this.ApplicationUrl != null &&
                    this.ApplicationUrl.Equals(input.ApplicationUrl))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.DefaultIdentitySchemaUrl == input.DefaultIdentitySchemaUrl ||
                    (this.DefaultIdentitySchemaUrl != null &&
                    this.DefaultIdentitySchemaUrl.Equals(input.DefaultIdentitySchemaUrl))
                ) && 
                (
                    this.ErrorUiUrl == input.ErrorUiUrl ||
                    (this.ErrorUiUrl != null &&
                    this.ErrorUiUrl.Equals(input.ErrorUiUrl))
                ) && 
                (
                    this.Hosts == input.Hosts ||
                    this.Hosts != null &&
                    input.Hosts != null &&
                    this.Hosts.SequenceEqual(input.Hosts)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.KratosConfigVersion == input.KratosConfigVersion ||
                    (this.KratosConfigVersion != null &&
                    this.KratosConfigVersion.Equals(input.KratosConfigVersion))
                ) && 
                (
                    this.KratosCustomSchemaId == input.KratosCustomSchemaId ||
                    (this.KratosCustomSchemaId != null &&
                    this.KratosCustomSchemaId.Equals(input.KratosCustomSchemaId))
                ) && 
                (
                    this.LoginUiUrl == input.LoginUiUrl ||
                    (this.LoginUiUrl != null &&
                    this.LoginUiUrl.Equals(input.LoginUiUrl))
                ) && 
                (
                    this.LookupSecret == input.LookupSecret ||
                    (this.LookupSecret != null &&
                    this.LookupSecret.Equals(input.LookupSecret))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OidcProviders == input.OidcProviders ||
                    this.OidcProviders != null &&
                    input.OidcProviders != null &&
                    this.OidcProviders.SequenceEqual(input.OidcProviders)
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Recovery == input.Recovery ||
                    (this.Recovery != null &&
                    this.Recovery.Equals(input.Recovery))
                ) && 
                (
                    this.RecoveryUiUrl == input.RecoveryUiUrl ||
                    (this.RecoveryUiUrl != null &&
                    this.RecoveryUiUrl.Equals(input.RecoveryUiUrl))
                ) && 
                (
                    this.RedirectionConfig == input.RedirectionConfig ||
                    (this.RedirectionConfig != null &&
                    this.RedirectionConfig.Equals(input.RedirectionConfig))
                ) && 
                (
                    this.RegistrationUiUrl == input.RegistrationUiUrl ||
                    (this.RegistrationUiUrl != null &&
                    this.RegistrationUiUrl.Equals(input.RegistrationUiUrl))
                ) && 
                (
                    this.SessionAfterSignUp == input.SessionAfterSignUp ||
                    this.SessionAfterSignUp.Equals(input.SessionAfterSignUp)
                ) && 
                (
                    this.SessionSoft2fa == input.SessionSoft2fa ||
                    this.SessionSoft2fa.Equals(input.SessionSoft2fa)
                ) && 
                (
                    this.SettingsPrivilegedSessionMaxAgeSeconds == input.SettingsPrivilegedSessionMaxAgeSeconds ||
                    this.SettingsPrivilegedSessionMaxAgeSeconds.Equals(input.SettingsPrivilegedSessionMaxAgeSeconds)
                ) && 
                (
                    this.SettingsSoft2fa == input.SettingsSoft2fa ||
                    this.SettingsSoft2fa.Equals(input.SettingsSoft2fa)
                ) && 
                (
                    this.SettingsUiUrl == input.SettingsUiUrl ||
                    (this.SettingsUiUrl != null &&
                    this.SettingsUiUrl.Equals(input.SettingsUiUrl))
                ) && 
                (
                    this.Totp == input.Totp ||
                    (this.Totp != null &&
                    this.Totp.Equals(input.Totp))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Verification == input.Verification ||
                    (this.Verification != null &&
                    this.Verification.Equals(input.Verification))
                ) && 
                (
                    this.VerificationUiUrl == input.VerificationUiUrl ||
                    (this.VerificationUiUrl != null &&
                    this.VerificationUiUrl.Equals(input.VerificationUiUrl))
                ) && 
                (
                    this.Webauthn == input.Webauthn ||
                    (this.Webauthn != null &&
                    this.Webauthn.Equals(input.Webauthn))
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
                if (this.ApiUrl != null)
                    hashCode = hashCode * 59 + this.ApiUrl.GetHashCode();
                if (this.ApplicationUrl != null)
                    hashCode = hashCode * 59 + this.ApplicationUrl.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.DefaultIdentitySchemaUrl != null)
                    hashCode = hashCode * 59 + this.DefaultIdentitySchemaUrl.GetHashCode();
                if (this.ErrorUiUrl != null)
                    hashCode = hashCode * 59 + this.ErrorUiUrl.GetHashCode();
                if (this.Hosts != null)
                    hashCode = hashCode * 59 + this.Hosts.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.KratosConfigVersion != null)
                    hashCode = hashCode * 59 + this.KratosConfigVersion.GetHashCode();
                if (this.KratosCustomSchemaId != null)
                    hashCode = hashCode * 59 + this.KratosCustomSchemaId.GetHashCode();
                if (this.LoginUiUrl != null)
                    hashCode = hashCode * 59 + this.LoginUiUrl.GetHashCode();
                if (this.LookupSecret != null)
                    hashCode = hashCode * 59 + this.LookupSecret.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OidcProviders != null)
                    hashCode = hashCode * 59 + this.OidcProviders.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Recovery != null)
                    hashCode = hashCode * 59 + this.Recovery.GetHashCode();
                if (this.RecoveryUiUrl != null)
                    hashCode = hashCode * 59 + this.RecoveryUiUrl.GetHashCode();
                if (this.RedirectionConfig != null)
                    hashCode = hashCode * 59 + this.RedirectionConfig.GetHashCode();
                if (this.RegistrationUiUrl != null)
                    hashCode = hashCode * 59 + this.RegistrationUiUrl.GetHashCode();
                hashCode = hashCode * 59 + this.SessionAfterSignUp.GetHashCode();
                hashCode = hashCode * 59 + this.SessionSoft2fa.GetHashCode();
                hashCode = hashCode * 59 + this.SettingsPrivilegedSessionMaxAgeSeconds.GetHashCode();
                hashCode = hashCode * 59 + this.SettingsSoft2fa.GetHashCode();
                if (this.SettingsUiUrl != null)
                    hashCode = hashCode * 59 + this.SettingsUiUrl.GetHashCode();
                if (this.Totp != null)
                    hashCode = hashCode * 59 + this.Totp.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Verification != null)
                    hashCode = hashCode * 59 + this.Verification.GetHashCode();
                if (this.VerificationUiUrl != null)
                    hashCode = hashCode * 59 + this.VerificationUiUrl.GetHashCode();
                if (this.Webauthn != null)
                    hashCode = hashCode * 59 + this.Webauthn.GetHashCode();
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
