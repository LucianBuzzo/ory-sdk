/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.2.0-alpha.44
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */

/// WellKnown : It includes links to several endpoints (e.g. /oauth2/token) and exposes information on supported signature algorithms among others.



#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct WellKnown {
    /// URL of the OP's OAuth 2.0 Authorization Endpoint.
    #[serde(rename = "authorization_endpoint")]
    pub authorization_endpoint: String,
    /// Boolean value specifying whether the OP can pass a sid (session ID) Claim in the Logout Token to identify the RP session with the OP. If supported, the sid Claim is also included in ID Tokens issued by the OP
    #[serde(rename = "backchannel_logout_session_supported", skip_serializing_if = "Option::is_none")]
    pub backchannel_logout_session_supported: Option<bool>,
    /// Boolean value specifying whether the OP supports back-channel logout, with true indicating support.
    #[serde(rename = "backchannel_logout_supported", skip_serializing_if = "Option::is_none")]
    pub backchannel_logout_supported: Option<bool>,
    /// Boolean value specifying whether the OP supports use of the claims parameter, with true indicating support.
    #[serde(rename = "claims_parameter_supported", skip_serializing_if = "Option::is_none")]
    pub claims_parameter_supported: Option<bool>,
    /// JSON array containing a list of the Claim Names of the Claims that the OpenID Provider MAY be able to supply values for. Note that for privacy or other reasons, this might not be an exhaustive list.
    #[serde(rename = "claims_supported", skip_serializing_if = "Option::is_none")]
    pub claims_supported: Option<Vec<String>>,
    /// JSON array containing a list of Proof Key for Code Exchange (PKCE) [RFC7636] code challenge methods supported by this authorization server.
    #[serde(rename = "code_challenge_methods_supported", skip_serializing_if = "Option::is_none")]
    pub code_challenge_methods_supported: Option<Vec<String>>,
    /// URL at the OP to which an RP can perform a redirect to request that the End-User be logged out at the OP.
    #[serde(rename = "end_session_endpoint", skip_serializing_if = "Option::is_none")]
    pub end_session_endpoint: Option<String>,
    /// Boolean value specifying whether the OP can pass iss (issuer) and sid (session ID) query parameters to identify the RP session with the OP when the frontchannel_logout_uri is used. If supported, the sid Claim is also included in ID Tokens issued by the OP.
    #[serde(rename = "frontchannel_logout_session_supported", skip_serializing_if = "Option::is_none")]
    pub frontchannel_logout_session_supported: Option<bool>,
    /// Boolean value specifying whether the OP supports HTTP-based logout, with true indicating support.
    #[serde(rename = "frontchannel_logout_supported", skip_serializing_if = "Option::is_none")]
    pub frontchannel_logout_supported: Option<bool>,
    /// JSON array containing a list of the OAuth 2.0 Grant Type values that this OP supports.
    #[serde(rename = "grant_types_supported", skip_serializing_if = "Option::is_none")]
    pub grant_types_supported: Option<Vec<String>>,
    /// JSON array containing a list of the JWS signing algorithms (alg values) supported by the OP for the ID Token to encode the Claims in a JWT.
    #[serde(rename = "id_token_signing_alg_values_supported")]
    pub id_token_signing_alg_values_supported: Vec<String>,
    /// URL using the https scheme with no query or fragment component that the OP asserts as its IssuerURL Identifier. If IssuerURL discovery is supported , this value MUST be identical to the issuer value returned by WebFinger. This also MUST be identical to the iss Claim value in ID Tokens issued from this IssuerURL.
    #[serde(rename = "issuer")]
    pub issuer: String,
    /// URL of the OP's JSON Web Key Set [JWK] document. This contains the signing key(s) the RP uses to validate signatures from the OP. The JWK Set MAY also contain the Server's encryption key(s), which are used by RPs to encrypt requests to the Server. When both signing and encryption keys are made available, a use (Key Use) parameter value is REQUIRED for all keys in the referenced JWK Set to indicate each key's intended usage. Although some algorithms allow the same key to be used for both signatures and encryption, doing so is NOT RECOMMENDED, as it is less secure. The JWK x5c parameter MAY be used to provide X.509 representations of keys provided. When used, the bare key values MUST still be present and MUST match those in the certificate.
    #[serde(rename = "jwks_uri")]
    pub jwks_uri: String,
    /// URL of the OP's Dynamic Client Registration Endpoint.
    #[serde(rename = "registration_endpoint", skip_serializing_if = "Option::is_none")]
    pub registration_endpoint: Option<String>,
    /// JSON array containing a list of the JWS signing algorithms (alg values) supported by the OP for Request Objects, which are described in Section 6.1 of OpenID Connect Core 1.0 [OpenID.Core]. These algorithms are used both when the Request Object is passed by value (using the request parameter) and when it is passed by reference (using the request_uri parameter).
    #[serde(rename = "request_object_signing_alg_values_supported", skip_serializing_if = "Option::is_none")]
    pub request_object_signing_alg_values_supported: Option<Vec<String>>,
    /// Boolean value specifying whether the OP supports use of the request parameter, with true indicating support.
    #[serde(rename = "request_parameter_supported", skip_serializing_if = "Option::is_none")]
    pub request_parameter_supported: Option<bool>,
    /// Boolean value specifying whether the OP supports use of the request_uri parameter, with true indicating support.
    #[serde(rename = "request_uri_parameter_supported", skip_serializing_if = "Option::is_none")]
    pub request_uri_parameter_supported: Option<bool>,
    /// Boolean value specifying whether the OP requires any request_uri values used to be pre-registered using the request_uris registration parameter.
    #[serde(rename = "require_request_uri_registration", skip_serializing_if = "Option::is_none")]
    pub require_request_uri_registration: Option<bool>,
    /// JSON array containing a list of the OAuth 2.0 response_mode values that this OP supports.
    #[serde(rename = "response_modes_supported", skip_serializing_if = "Option::is_none")]
    pub response_modes_supported: Option<Vec<String>>,
    /// JSON array containing a list of the OAuth 2.0 response_type values that this OP supports. Dynamic OpenID Providers MUST support the code, id_token, and the token id_token Response Type values.
    #[serde(rename = "response_types_supported")]
    pub response_types_supported: Vec<String>,
    /// URL of the authorization server's OAuth 2.0 revocation endpoint.
    #[serde(rename = "revocation_endpoint", skip_serializing_if = "Option::is_none")]
    pub revocation_endpoint: Option<String>,
    /// SON array containing a list of the OAuth 2.0 [RFC6749] scope values that this server supports. The server MUST support the openid scope value. Servers MAY choose not to advertise some supported scope values even when this parameter is used
    #[serde(rename = "scopes_supported", skip_serializing_if = "Option::is_none")]
    pub scopes_supported: Option<Vec<String>>,
    /// JSON array containing a list of the Subject Identifier types that this OP supports. Valid types include pairwise and public.
    #[serde(rename = "subject_types_supported")]
    pub subject_types_supported: Vec<String>,
    /// URL of the OP's OAuth 2.0 Token Endpoint
    #[serde(rename = "token_endpoint")]
    pub token_endpoint: String,
    /// JSON array containing a list of Client Authentication methods supported by this Token Endpoint. The options are client_secret_post, client_secret_basic, client_secret_jwt, and private_key_jwt, as described in Section 9 of OpenID Connect Core 1.0
    #[serde(rename = "token_endpoint_auth_methods_supported", skip_serializing_if = "Option::is_none")]
    pub token_endpoint_auth_methods_supported: Option<Vec<String>>,
    /// URL of the OP's UserInfo Endpoint.
    #[serde(rename = "userinfo_endpoint", skip_serializing_if = "Option::is_none")]
    pub userinfo_endpoint: Option<String>,
    /// JSON array containing a list of the JWS [JWS] signing algorithms (alg values) [JWA] supported by the UserInfo Endpoint to encode the Claims in a JWT [JWT].
    #[serde(rename = "userinfo_signing_alg_values_supported", skip_serializing_if = "Option::is_none")]
    pub userinfo_signing_alg_values_supported: Option<Vec<String>>,
}


impl WellKnown {
    /// It includes links to several endpoints (e.g. /oauth2/token) and exposes information on supported signature algorithms among others.
    pub fn new(authorization_endpoint: String, id_token_signing_alg_values_supported: Vec<String>, issuer: String, jwks_uri: String, response_types_supported: Vec<String>, subject_types_supported: Vec<String>, token_endpoint: String) -> WellKnown {
        WellKnown {
                authorization_endpoint,
                backchannel_logout_session_supported: None,
                backchannel_logout_supported: None,
                claims_parameter_supported: None,
                claims_supported: None,
                code_challenge_methods_supported: None,
                end_session_endpoint: None,
                frontchannel_logout_session_supported: None,
                frontchannel_logout_supported: None,
                grant_types_supported: None,
                id_token_signing_alg_values_supported,
                issuer,
                jwks_uri,
                registration_endpoint: None,
                request_object_signing_alg_values_supported: None,
                request_parameter_supported: None,
                request_uri_parameter_supported: None,
                require_request_uri_registration: None,
                response_modes_supported: None,
                response_types_supported,
                revocation_endpoint: None,
                scopes_supported: None,
                subject_types_supported,
                token_endpoint,
                token_endpoint_auth_methods_supported: None,
                userinfo_endpoint: None,
                userinfo_signing_alg_values_supported: None,
        }
    }
}


