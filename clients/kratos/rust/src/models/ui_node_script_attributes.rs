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
pub struct UiNodeScriptAttributes {
    /// The script async type
    #[serde(rename = "async")]
    pub _async: bool,
    /// The script cross origin policy
    #[serde(rename = "crossorigin")]
    pub crossorigin: String,
    /// A unique identifier
    #[serde(rename = "id")]
    pub id: String,
    /// The script's integrity hash
    #[serde(rename = "integrity")]
    pub integrity: String,
    #[serde(rename = "node_type")]
    pub node_type: String,
    /// The script referrer policy
    #[serde(rename = "referrerpolicy")]
    pub referrerpolicy: String,
    /// The script source
    #[serde(rename = "src")]
    pub src: String,
    /// The script MIME type
    #[serde(rename = "type")]
    pub _type: String,
}

impl UiNodeScriptAttributes {
    pub fn new(_async: bool, crossorigin: String, id: String, integrity: String, node_type: String, referrerpolicy: String, src: String, _type: String) -> UiNodeScriptAttributes {
        UiNodeScriptAttributes {
            _async,
            crossorigin,
            id,
            integrity,
            node_type,
            referrerpolicy,
            src,
            _type,
        }
    }
}


