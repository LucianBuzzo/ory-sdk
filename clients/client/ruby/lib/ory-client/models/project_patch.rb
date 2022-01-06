=begin
#Ory APIs

#Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

The version of the OpenAPI document: v0.0.1-alpha.40
Contact: support@ory.sh
Generated by: https://openapi-generator.tech
OpenAPI Generator version: 5.2.1

=end

require 'date'
require 'time'

module OryClient
  class ProjectPatch
    # URL of Project API  In the future will allow to override Kratos project URL. If set, error is returned. If left empty our hosted URL is used
    attr_accessor :api_url

    # URL where your application is available.  Your users will be redirected to this URL when they successfully complete a login, logout, verification, recovery, or registration flow. More fine-grained redirection patterns are available for the individual flows (login, registration, ...).  If left empty, our hosted URL will be used instead. It contains technical information on the identities and is useful when developing a new project or trying out Ory Cloud.
    attr_accessor :application_url

    # Default Identity Schema URL  This represents your Ory Kratos Default Identity Schema. It is your identity's default schema. This allows setting custom fields such as \"address\", specifying whether you want to log in using email or a username, and more. For more information on this topic, please check out the identity documentation.  If KratosCustomSchemaID is also added to the payload, it will be preferred and replace the value of DefaultIdentitySchemaURL set by the client.  The value of this field can be either any \"https://\" URL - for example a file hosted at GitHub, or a `preset://`-prefixed string.  Available presets are:  preset://email preset://username preset://basic preset://blank
    attr_accessor :default_identity_schema_url

    # Self-Service Error UI URL  Sets the UI URL for the error UI. If left empty, this will use Ory's hosted pages.
    attr_accessor :error_ui_url

    # The Custom Schema ID  The custom schema ID is a preferred field over DefaultIdentitySchemaURL, meaning it will override the DefaultIdentitySchemaURL with the custom schema's URL instead of accepting it from the client-side. Once this field is set the given custom schema will be associated with this project.
    attr_accessor :kratos_custom_schema_id

    # Self-Service Login UI URL  Sets the UI URL for the login UI. If left empty, this will use Ory's hosted pages.
    attr_accessor :login_ui_url

    attr_accessor :lookup_secret

    # The project name.  Helps you identify your project.  in: body
    attr_accessor :name

    attr_accessor :password

    attr_accessor :recovery

    # Self-Service Login UI URL  Sets the UI URL for the recovery UI. If left empty, this will use Ory's hosted pages.
    attr_accessor :recovery_ui_url

    attr_accessor :redirection_config

    # Self-Service Login UI URL  Sets the UI URL for the registration UI. If left empty, this will use Ory's hosted pages.
    attr_accessor :registration_ui_url

    # Issue Session after Sign Up  If set to true, users will receive a session after they successfully signed up. Enabling this option allows account enumeration during registration flows. Read more: https://www.ory.sh/kratos/docs/self-service/flows/user-registration#successful-registration
    attr_accessor :session_after_sign_up

    # Enable Soft 2FA for Login Sessions
    attr_accessor :session_soft_2fa

    # Duration in Seconds of how long a Session is Privileged  Defines how long a session is considered privileged in seconds. If the session's authenticated_at is older than the value specified here, the user needs to re-authenticate to perform certain actions (e.g. password change).
    attr_accessor :settings_privileged_session_max_age_seconds

    # Enable Soft 2FA for Self-Service Settings Flows
    attr_accessor :settings_soft_2fa

    # Self-Service Settings UI URL  Sets the UI URL for the settings UI. If left empty, this will use Ory's hosted pages.
    attr_accessor :settings_ui_url

    attr_accessor :totp

    attr_accessor :verification

    # Self-Service Login UI URL  Sets the UI URL for the verification UI. If left empty, this will use Ory's hosted pages.
    attr_accessor :verification_ui_url

    attr_accessor :webauthn

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'api_url' => :'api_url',
        :'application_url' => :'application_url',
        :'default_identity_schema_url' => :'default_identity_schema_url',
        :'error_ui_url' => :'error_ui_url',
        :'kratos_custom_schema_id' => :'kratos_custom_schema_id',
        :'login_ui_url' => :'login_ui_url',
        :'lookup_secret' => :'lookup_secret',
        :'name' => :'name',
        :'password' => :'password',
        :'recovery' => :'recovery',
        :'recovery_ui_url' => :'recovery_ui_url',
        :'redirection_config' => :'redirection_config',
        :'registration_ui_url' => :'registration_ui_url',
        :'session_after_sign_up' => :'session_after_sign_up',
        :'session_soft_2fa' => :'session_soft_2fa',
        :'settings_privileged_session_max_age_seconds' => :'settings_privileged_session_max_age_seconds',
        :'settings_soft_2fa' => :'settings_soft_2fa',
        :'settings_ui_url' => :'settings_ui_url',
        :'totp' => :'totp',
        :'verification' => :'verification',
        :'verification_ui_url' => :'verification_ui_url',
        :'webauthn' => :'webauthn'
      }
    end

    # Returns all the JSON keys this model knows about
    def self.acceptable_attributes
      attribute_map.values
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'api_url' => :'String',
        :'application_url' => :'String',
        :'default_identity_schema_url' => :'String',
        :'error_ui_url' => :'String',
        :'kratos_custom_schema_id' => :'String',
        :'login_ui_url' => :'String',
        :'lookup_secret' => :'ProjectLookupSecretConfig',
        :'name' => :'String',
        :'password' => :'ProjectPasswordConfig',
        :'recovery' => :'ProjectRecoveryConfig',
        :'recovery_ui_url' => :'String',
        :'redirection_config' => :'RedirectionConfig',
        :'registration_ui_url' => :'String',
        :'session_after_sign_up' => :'Boolean',
        :'session_soft_2fa' => :'Boolean',
        :'settings_privileged_session_max_age_seconds' => :'Integer',
        :'settings_soft_2fa' => :'Boolean',
        :'settings_ui_url' => :'String',
        :'totp' => :'ProjectTotpConfig',
        :'verification' => :'ProjectVerificationConfig',
        :'verification_ui_url' => :'String',
        :'webauthn' => :'ProjectWebAuthnConfig'
      }
    end

    # List of attributes with nullable: true
    def self.openapi_nullable
      Set.new([
      ])
    end

    # Initializes the object
    # @param [Hash] attributes Model attributes in the form of hash
    def initialize(attributes = {})
      if (!attributes.is_a?(Hash))
        fail ArgumentError, "The input argument (attributes) must be a hash in `OryClient::ProjectPatch` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `OryClient::ProjectPatch`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'api_url')
        self.api_url = attributes[:'api_url']
      end

      if attributes.key?(:'application_url')
        self.application_url = attributes[:'application_url']
      end

      if attributes.key?(:'default_identity_schema_url')
        self.default_identity_schema_url = attributes[:'default_identity_schema_url']
      end

      if attributes.key?(:'error_ui_url')
        self.error_ui_url = attributes[:'error_ui_url']
      end

      if attributes.key?(:'kratos_custom_schema_id')
        self.kratos_custom_schema_id = attributes[:'kratos_custom_schema_id']
      end

      if attributes.key?(:'login_ui_url')
        self.login_ui_url = attributes[:'login_ui_url']
      end

      if attributes.key?(:'lookup_secret')
        self.lookup_secret = attributes[:'lookup_secret']
      end

      if attributes.key?(:'name')
        self.name = attributes[:'name']
      end

      if attributes.key?(:'password')
        self.password = attributes[:'password']
      end

      if attributes.key?(:'recovery')
        self.recovery = attributes[:'recovery']
      end

      if attributes.key?(:'recovery_ui_url')
        self.recovery_ui_url = attributes[:'recovery_ui_url']
      end

      if attributes.key?(:'redirection_config')
        self.redirection_config = attributes[:'redirection_config']
      end

      if attributes.key?(:'registration_ui_url')
        self.registration_ui_url = attributes[:'registration_ui_url']
      end

      if attributes.key?(:'session_after_sign_up')
        self.session_after_sign_up = attributes[:'session_after_sign_up']
      end

      if attributes.key?(:'session_soft_2fa')
        self.session_soft_2fa = attributes[:'session_soft_2fa']
      end

      if attributes.key?(:'settings_privileged_session_max_age_seconds')
        self.settings_privileged_session_max_age_seconds = attributes[:'settings_privileged_session_max_age_seconds']
      end

      if attributes.key?(:'settings_soft_2fa')
        self.settings_soft_2fa = attributes[:'settings_soft_2fa']
      end

      if attributes.key?(:'settings_ui_url')
        self.settings_ui_url = attributes[:'settings_ui_url']
      end

      if attributes.key?(:'totp')
        self.totp = attributes[:'totp']
      end

      if attributes.key?(:'verification')
        self.verification = attributes[:'verification']
      end

      if attributes.key?(:'verification_ui_url')
        self.verification_ui_url = attributes[:'verification_ui_url']
      end

      if attributes.key?(:'webauthn')
        self.webauthn = attributes[:'webauthn']
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      if @error_ui_url.nil?
        invalid_properties.push('invalid value for "error_ui_url", error_ui_url cannot be nil.')
      end

      if @login_ui_url.nil?
        invalid_properties.push('invalid value for "login_ui_url", login_ui_url cannot be nil.')
      end

      if @lookup_secret.nil?
        invalid_properties.push('invalid value for "lookup_secret", lookup_secret cannot be nil.')
      end

      if @password.nil?
        invalid_properties.push('invalid value for "password", password cannot be nil.')
      end

      if @recovery.nil?
        invalid_properties.push('invalid value for "recovery", recovery cannot be nil.')
      end

      if @recovery_ui_url.nil?
        invalid_properties.push('invalid value for "recovery_ui_url", recovery_ui_url cannot be nil.')
      end

      if @registration_ui_url.nil?
        invalid_properties.push('invalid value for "registration_ui_url", registration_ui_url cannot be nil.')
      end

      if @session_after_sign_up.nil?
        invalid_properties.push('invalid value for "session_after_sign_up", session_after_sign_up cannot be nil.')
      end

      if @session_soft_2fa.nil?
        invalid_properties.push('invalid value for "session_soft_2fa", session_soft_2fa cannot be nil.')
      end

      if @settings_privileged_session_max_age_seconds.nil?
        invalid_properties.push('invalid value for "settings_privileged_session_max_age_seconds", settings_privileged_session_max_age_seconds cannot be nil.')
      end

      if @settings_soft_2fa.nil?
        invalid_properties.push('invalid value for "settings_soft_2fa", settings_soft_2fa cannot be nil.')
      end

      if @settings_ui_url.nil?
        invalid_properties.push('invalid value for "settings_ui_url", settings_ui_url cannot be nil.')
      end

      if @totp.nil?
        invalid_properties.push('invalid value for "totp", totp cannot be nil.')
      end

      if @verification.nil?
        invalid_properties.push('invalid value for "verification", verification cannot be nil.')
      end

      if @verification_ui_url.nil?
        invalid_properties.push('invalid value for "verification_ui_url", verification_ui_url cannot be nil.')
      end

      if @webauthn.nil?
        invalid_properties.push('invalid value for "webauthn", webauthn cannot be nil.')
      end

      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      return false if @error_ui_url.nil?
      return false if @login_ui_url.nil?
      return false if @lookup_secret.nil?
      return false if @password.nil?
      return false if @recovery.nil?
      return false if @recovery_ui_url.nil?
      return false if @registration_ui_url.nil?
      return false if @session_after_sign_up.nil?
      return false if @session_soft_2fa.nil?
      return false if @settings_privileged_session_max_age_seconds.nil?
      return false if @settings_soft_2fa.nil?
      return false if @settings_ui_url.nil?
      return false if @totp.nil?
      return false if @verification.nil?
      return false if @verification_ui_url.nil?
      return false if @webauthn.nil?
      true
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          api_url == o.api_url &&
          application_url == o.application_url &&
          default_identity_schema_url == o.default_identity_schema_url &&
          error_ui_url == o.error_ui_url &&
          kratos_custom_schema_id == o.kratos_custom_schema_id &&
          login_ui_url == o.login_ui_url &&
          lookup_secret == o.lookup_secret &&
          name == o.name &&
          password == o.password &&
          recovery == o.recovery &&
          recovery_ui_url == o.recovery_ui_url &&
          redirection_config == o.redirection_config &&
          registration_ui_url == o.registration_ui_url &&
          session_after_sign_up == o.session_after_sign_up &&
          session_soft_2fa == o.session_soft_2fa &&
          settings_privileged_session_max_age_seconds == o.settings_privileged_session_max_age_seconds &&
          settings_soft_2fa == o.settings_soft_2fa &&
          settings_ui_url == o.settings_ui_url &&
          totp == o.totp &&
          verification == o.verification &&
          verification_ui_url == o.verification_ui_url &&
          webauthn == o.webauthn
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [api_url, application_url, default_identity_schema_url, error_ui_url, kratos_custom_schema_id, login_ui_url, lookup_secret, name, password, recovery, recovery_ui_url, redirection_config, registration_ui_url, session_after_sign_up, session_soft_2fa, settings_privileged_session_max_age_seconds, settings_soft_2fa, settings_ui_url, totp, verification, verification_ui_url, webauthn].hash
    end

    # Builds the object from hash
    # @param [Hash] attributes Model attributes in the form of hash
    # @return [Object] Returns the model itself
    def self.build_from_hash(attributes)
      new.build_from_hash(attributes)
    end

    # Builds the object from hash
    # @param [Hash] attributes Model attributes in the form of hash
    # @return [Object] Returns the model itself
    def build_from_hash(attributes)
      return nil unless attributes.is_a?(Hash)
      self.class.openapi_types.each_pair do |key, type|
        if attributes[self.class.attribute_map[key]].nil? && self.class.openapi_nullable.include?(key)
          self.send("#{key}=", nil)
        elsif type =~ /\AArray<(.*)>/i
          # check to ensure the input is an array given that the attribute
          # is documented as an array but the input is not
          if attributes[self.class.attribute_map[key]].is_a?(Array)
            self.send("#{key}=", attributes[self.class.attribute_map[key]].map { |v| _deserialize($1, v) })
          end
        elsif !attributes[self.class.attribute_map[key]].nil?
          self.send("#{key}=", _deserialize(type, attributes[self.class.attribute_map[key]]))
        end
      end

      self
    end

    # Deserializes the data based on type
    # @param string type Data type
    # @param string value Value to be deserialized
    # @return [Object] Deserialized data
    def _deserialize(type, value)
      case type.to_sym
      when :Time
        Time.parse(value)
      when :Date
        Date.parse(value)
      when :String
        value.to_s
      when :Integer
        value.to_i
      when :Float
        value.to_f
      when :Boolean
        if value.to_s =~ /\A(true|t|yes|y|1)\z/i
          true
        else
          false
        end
      when :Object
        # generic object (usually a Hash), return directly
        value
      when /\AArray<(?<inner_type>.+)>\z/
        inner_type = Regexp.last_match[:inner_type]
        value.map { |v| _deserialize(inner_type, v) }
      when /\AHash<(?<k_type>.+?), (?<v_type>.+)>\z/
        k_type = Regexp.last_match[:k_type]
        v_type = Regexp.last_match[:v_type]
        {}.tap do |hash|
          value.each do |k, v|
            hash[_deserialize(k_type, k)] = _deserialize(v_type, v)
          end
        end
      else # model
        # models (e.g. Pet) or oneOf
        klass = OryClient.const_get(type)
        klass.respond_to?(:openapi_one_of) ? klass.build(value) : klass.build_from_hash(value)
      end
    end

    # Returns the string representation of the object
    # @return [String] String presentation of the object
    def to_s
      to_hash.to_s
    end

    # to_body is an alias to to_hash (backward compatibility)
    # @return [Hash] Returns the object in the form of hash
    def to_body
      to_hash
    end

    # Returns the object in the form of hash
    # @return [Hash] Returns the object in the form of hash
    def to_hash
      hash = {}
      self.class.attribute_map.each_pair do |attr, param|
        value = self.send(attr)
        if value.nil?
          is_nullable = self.class.openapi_nullable.include?(attr)
          next if !is_nullable || (is_nullable && !instance_variable_defined?(:"@#{attr}"))
        end

        hash[param] = _to_hash(value)
      end
      hash
    end

    # Outputs non-array value in the form of hash
    # For object, use to_hash. Otherwise, just return the value
    # @param [Object] value Any valid value
    # @return [Hash] Returns the value in the form of hash
    def _to_hash(value)
      if value.is_a?(Array)
        value.compact.map { |v| _to_hash(v) }
      elsif value.is_a?(Hash)
        {}.tap do |hash|
          value.each { |k, v| hash[k] = _to_hash(v) }
        end
      elsif value.respond_to? :to_hash
        value.to_hash
      else
        value
      end
    end

  end

end
