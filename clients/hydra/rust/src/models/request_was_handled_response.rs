/*
 * ORY Hydra
 *
 * Welcome to the ORY Hydra HTTP API documentation. You will find documentation for all HTTP APIs here.
 *
 * The version of the OpenAPI document: v1.10.4-alpha.1
 * 
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct RequestWasHandledResponse {
    /// Original request URL to which you should redirect the user if request was already handled.
    #[serde(rename = "redirect_to")]
    pub redirect_to: String,
}

impl RequestWasHandledResponse {
    pub fn new(redirect_to: String) -> RequestWasHandledResponse {
        RequestWasHandledResponse {
            redirect_to,
        }
    }
}

