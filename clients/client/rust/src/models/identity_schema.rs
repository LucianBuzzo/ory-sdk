/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.52
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */

/// IdentitySchema : Together the name and identity uuid are a unique index constraint. This prevents a user from having schemas with the same name. This also allows schemas to have the same name across the system.



#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct IdentitySchema {
    /// The Schema's Creation Date
    #[serde(rename = "created_at")]
    pub created_at: String,
    #[serde(rename = "id")]
    pub id: String,
    /// The schema name  This is set by the user and is for them to easily recognise their schema
    #[serde(rename = "name")]
    pub name: String,
    /// The actual Identity JSON Schema
    #[serde(rename = "schema", skip_serializing_if = "Option::is_none")]
    pub schema: Option<serde_json::Value>,
    /// Last Time Schema was Updated
    #[serde(rename = "updated_at")]
    pub updated_at: String,
}

impl IdentitySchema {
    /// Together the name and identity uuid are a unique index constraint. This prevents a user from having schemas with the same name. This also allows schemas to have the same name across the system.
    pub fn new(created_at: String, id: String, name: String, updated_at: String) -> IdentitySchema {
        IdentitySchema {
            created_at,
            id,
            name,
            schema: None,
            updated_at,
        }
    }
}


