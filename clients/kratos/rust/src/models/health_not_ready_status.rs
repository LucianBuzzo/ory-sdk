/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.8.0-alpha.2
 * Contact: hi@ory.sh
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct HealthNotReadyStatus {
    /// Errors contains a list of errors that caused the not ready status.
    #[serde(rename = "errors", skip_serializing_if = "Option::is_none")]
    pub errors: Option<::std::collections::HashMap<String, String>>,
}

impl HealthNotReadyStatus {
    pub fn new() -> HealthNotReadyStatus {
        HealthNotReadyStatus {
            errors: None,
        }
    }
}


