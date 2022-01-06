/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.40
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct ProjectPasswordConfig {
    /// Set to true to enable the password authentication method.
    #[serde(rename = "enabled", skip_serializing_if = "Option::is_none")]
    pub enabled: Option<bool>,
    /// Set to true to remove active sessions when the users logs in.
    #[serde(rename = "revoke_active_sessions", skip_serializing_if = "Option::is_none")]
    pub revoke_active_sessions: Option<bool>,
}

impl ProjectPasswordConfig {
    pub fn new() -> ProjectPasswordConfig {
        ProjectPasswordConfig {
            enabled: None,
            revoke_active_sessions: None,
        }
    }
}


