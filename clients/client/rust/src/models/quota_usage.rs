/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.22
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct QuotaUsage {
    #[serde(rename = "additional_price")]
    pub additional_price: i64,
    #[serde(rename = "can_use_more")]
    pub can_use_more: bool,
    ///  region_eu RegionEU region_us RegionUS region_apac RegionAPAC region_global RegionGlobal production_projects ProductionProjects daily_active_users DailyActiveUsers custom_domains CustomDomains sla SLA collaborator_seats CollaboratorSeats edge_cache EdgeCache branding_themes BrandingThemes zendesk_support ZendeskSupport rate_limit_tier RateLimitTier session_rate_limit_tier RateLimitTierSessions
    #[serde(rename = "feature")]
    pub feature: FeatureEnum,
    #[serde(rename = "feature_available")]
    pub feature_available: bool,
    #[serde(rename = "included")]
    pub included: i64,
    #[serde(rename = "used")]
    pub used: i64,
}


impl QuotaUsage {
    pub fn new(additional_price: i64, can_use_more: bool, feature: FeatureEnum, feature_available: bool, included: i64, used: i64) -> QuotaUsage {
        QuotaUsage {
                additional_price,
                can_use_more,
                feature,
                feature_available,
                included,
                used,
        }
    }
}

///  region_eu RegionEU region_us RegionUS region_apac RegionAPAC region_global RegionGlobal production_projects ProductionProjects daily_active_users DailyActiveUsers custom_domains CustomDomains sla SLA collaborator_seats CollaboratorSeats edge_cache EdgeCache branding_themes BrandingThemes zendesk_support ZendeskSupport rate_limit_tier RateLimitTier session_rate_limit_tier RateLimitTierSessions
#[derive(Clone, Copy, Debug, Eq, PartialEq, Ord, PartialOrd, Hash, Serialize, Deserialize)]
pub enum FeatureEnum {
    #[serde(rename = "region_eu")]
    RegionEu,
    #[serde(rename = "region_us")]
    RegionUs,
    #[serde(rename = "region_apac")]
    RegionApac,
    #[serde(rename = "region_global")]
    RegionGlobal,
    #[serde(rename = "production_projects")]
    ProductionProjects,
    #[serde(rename = "daily_active_users")]
    DailyActiveUsers,
    #[serde(rename = "custom_domains")]
    CustomDomains,
    #[serde(rename = "sla")]
    Sla,
    #[serde(rename = "collaborator_seats")]
    CollaboratorSeats,
    #[serde(rename = "edge_cache")]
    EdgeCache,
    #[serde(rename = "branding_themes")]
    BrandingThemes,
    #[serde(rename = "zendesk_support")]
    ZendeskSupport,
    #[serde(rename = "rate_limit_tier")]
    RateLimitTier,
    #[serde(rename = "session_rate_limit_tier")]
    SessionRateLimitTier,
}
