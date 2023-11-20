/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.4.1
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
    /// ClientQuotaUsage
    /// </summary>
    [DataContract(Name = "quotaUsage")]
    public partial class ClientQuotaUsage : IEquatable<ClientQuotaUsage>, IValidatableObject
    {
        /// <summary>
        ///  region_eu RegionEU region_us RegionUS region_apac RegionAPAC region_global RegionGlobal production_projects ProductionProjects daily_active_users DailyActiveUsers custom_domains CustomDomains sla SLA collaborator_seats CollaboratorSeats edge_cache EdgeCache branding_themes BrandingThemes zendesk_support ZendeskSupport project_metrics ProjectMetrics project_metrics_time_window ProjectMetricsTimeWindow organizations Organizations rop_grant ResourceOwnerPasswordGrant rate_limit_tier RateLimitTier session_rate_limit_tier RateLimitTierSessions identities_list_rate_limit_tier RateLimitTierIdentitiesList
        /// </summary>
        /// <value> region_eu RegionEU region_us RegionUS region_apac RegionAPAC region_global RegionGlobal production_projects ProductionProjects daily_active_users DailyActiveUsers custom_domains CustomDomains sla SLA collaborator_seats CollaboratorSeats edge_cache EdgeCache branding_themes BrandingThemes zendesk_support ZendeskSupport project_metrics ProjectMetrics project_metrics_time_window ProjectMetricsTimeWindow organizations Organizations rop_grant ResourceOwnerPasswordGrant rate_limit_tier RateLimitTier session_rate_limit_tier RateLimitTierSessions identities_list_rate_limit_tier RateLimitTierIdentitiesList</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FeatureEnum
        {
            /// <summary>
            /// Enum RegionEu for value: region_eu
            /// </summary>
            [EnumMember(Value = "region_eu")]
            RegionEu = 1,

            /// <summary>
            /// Enum RegionUs for value: region_us
            /// </summary>
            [EnumMember(Value = "region_us")]
            RegionUs = 2,

            /// <summary>
            /// Enum RegionApac for value: region_apac
            /// </summary>
            [EnumMember(Value = "region_apac")]
            RegionApac = 3,

            /// <summary>
            /// Enum RegionGlobal for value: region_global
            /// </summary>
            [EnumMember(Value = "region_global")]
            RegionGlobal = 4,

            /// <summary>
            /// Enum ProductionProjects for value: production_projects
            /// </summary>
            [EnumMember(Value = "production_projects")]
            ProductionProjects = 5,

            /// <summary>
            /// Enum DailyActiveUsers for value: daily_active_users
            /// </summary>
            [EnumMember(Value = "daily_active_users")]
            DailyActiveUsers = 6,

            /// <summary>
            /// Enum CustomDomains for value: custom_domains
            /// </summary>
            [EnumMember(Value = "custom_domains")]
            CustomDomains = 7,

            /// <summary>
            /// Enum Sla for value: sla
            /// </summary>
            [EnumMember(Value = "sla")]
            Sla = 8,

            /// <summary>
            /// Enum CollaboratorSeats for value: collaborator_seats
            /// </summary>
            [EnumMember(Value = "collaborator_seats")]
            CollaboratorSeats = 9,

            /// <summary>
            /// Enum EdgeCache for value: edge_cache
            /// </summary>
            [EnumMember(Value = "edge_cache")]
            EdgeCache = 10,

            /// <summary>
            /// Enum BrandingThemes for value: branding_themes
            /// </summary>
            [EnumMember(Value = "branding_themes")]
            BrandingThemes = 11,

            /// <summary>
            /// Enum ZendeskSupport for value: zendesk_support
            /// </summary>
            [EnumMember(Value = "zendesk_support")]
            ZendeskSupport = 12,

            /// <summary>
            /// Enum ProjectMetrics for value: project_metrics
            /// </summary>
            [EnumMember(Value = "project_metrics")]
            ProjectMetrics = 13,

            /// <summary>
            /// Enum ProjectMetricsTimeWindow for value: project_metrics_time_window
            /// </summary>
            [EnumMember(Value = "project_metrics_time_window")]
            ProjectMetricsTimeWindow = 14,

            /// <summary>
            /// Enum Organizations for value: organizations
            /// </summary>
            [EnumMember(Value = "organizations")]
            Organizations = 15,

            /// <summary>
            /// Enum RopGrant for value: rop_grant
            /// </summary>
            [EnumMember(Value = "rop_grant")]
            RopGrant = 16,

            /// <summary>
            /// Enum RateLimitTier for value: rate_limit_tier
            /// </summary>
            [EnumMember(Value = "rate_limit_tier")]
            RateLimitTier = 17,

            /// <summary>
            /// Enum SessionRateLimitTier for value: session_rate_limit_tier
            /// </summary>
            [EnumMember(Value = "session_rate_limit_tier")]
            SessionRateLimitTier = 18,

            /// <summary>
            /// Enum IdentitiesListRateLimitTier for value: identities_list_rate_limit_tier
            /// </summary>
            [EnumMember(Value = "identities_list_rate_limit_tier")]
            IdentitiesListRateLimitTier = 19

        }


        /// <summary>
        ///  region_eu RegionEU region_us RegionUS region_apac RegionAPAC region_global RegionGlobal production_projects ProductionProjects daily_active_users DailyActiveUsers custom_domains CustomDomains sla SLA collaborator_seats CollaboratorSeats edge_cache EdgeCache branding_themes BrandingThemes zendesk_support ZendeskSupport project_metrics ProjectMetrics project_metrics_time_window ProjectMetricsTimeWindow organizations Organizations rop_grant ResourceOwnerPasswordGrant rate_limit_tier RateLimitTier session_rate_limit_tier RateLimitTierSessions identities_list_rate_limit_tier RateLimitTierIdentitiesList
        /// </summary>
        /// <value> region_eu RegionEU region_us RegionUS region_apac RegionAPAC region_global RegionGlobal production_projects ProductionProjects daily_active_users DailyActiveUsers custom_domains CustomDomains sla SLA collaborator_seats CollaboratorSeats edge_cache EdgeCache branding_themes BrandingThemes zendesk_support ZendeskSupport project_metrics ProjectMetrics project_metrics_time_window ProjectMetricsTimeWindow organizations Organizations rop_grant ResourceOwnerPasswordGrant rate_limit_tier RateLimitTier session_rate_limit_tier RateLimitTierSessions identities_list_rate_limit_tier RateLimitTierIdentitiesList</value>
        [DataMember(Name = "feature", IsRequired = true, EmitDefaultValue = false)]
        public FeatureEnum Feature { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientQuotaUsage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientQuotaUsage()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientQuotaUsage" /> class.
        /// </summary>
        /// <param name="additionalPrice">The additional price per unit in cents. (required).</param>
        /// <param name="canUseMore">canUseMore (required).</param>
        /// <param name="feature"> region_eu RegionEU region_us RegionUS region_apac RegionAPAC region_global RegionGlobal production_projects ProductionProjects daily_active_users DailyActiveUsers custom_domains CustomDomains sla SLA collaborator_seats CollaboratorSeats edge_cache EdgeCache branding_themes BrandingThemes zendesk_support ZendeskSupport project_metrics ProjectMetrics project_metrics_time_window ProjectMetricsTimeWindow organizations Organizations rop_grant ResourceOwnerPasswordGrant rate_limit_tier RateLimitTier session_rate_limit_tier RateLimitTierSessions identities_list_rate_limit_tier RateLimitTierIdentitiesList (required).</param>
        /// <param name="featureAvailable">featureAvailable (required).</param>
        /// <param name="included">included (required).</param>
        /// <param name="used">used (required).</param>
        public ClientQuotaUsage(long additionalPrice = default(long), bool canUseMore = default(bool), FeatureEnum feature = default(FeatureEnum), bool featureAvailable = default(bool), long included = default(long), long used = default(long))
        {
            this.AdditionalPrice = additionalPrice;
            this.CanUseMore = canUseMore;
            this.Feature = feature;
            this.FeatureAvailable = featureAvailable;
            this.Included = included;
            this.Used = used;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The additional price per unit in cents.
        /// </summary>
        /// <value>The additional price per unit in cents.</value>
        [DataMember(Name = "additional_price", IsRequired = true, EmitDefaultValue = false)]
        public long AdditionalPrice { get; set; }

        /// <summary>
        /// Gets or Sets CanUseMore
        /// </summary>
        [DataMember(Name = "can_use_more", IsRequired = true, EmitDefaultValue = true)]
        public bool CanUseMore { get; set; }

        /// <summary>
        /// Gets or Sets FeatureAvailable
        /// </summary>
        [DataMember(Name = "feature_available", IsRequired = true, EmitDefaultValue = true)]
        public bool FeatureAvailable { get; set; }

        /// <summary>
        /// Gets or Sets Included
        /// </summary>
        [DataMember(Name = "included", IsRequired = true, EmitDefaultValue = false)]
        public long Included { get; set; }

        /// <summary>
        /// Gets or Sets Used
        /// </summary>
        [DataMember(Name = "used", IsRequired = true, EmitDefaultValue = false)]
        public long Used { get; set; }

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
            sb.Append("class ClientQuotaUsage {\n");
            sb.Append("  AdditionalPrice: ").Append(AdditionalPrice).Append("\n");
            sb.Append("  CanUseMore: ").Append(CanUseMore).Append("\n");
            sb.Append("  Feature: ").Append(Feature).Append("\n");
            sb.Append("  FeatureAvailable: ").Append(FeatureAvailable).Append("\n");
            sb.Append("  Included: ").Append(Included).Append("\n");
            sb.Append("  Used: ").Append(Used).Append("\n");
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
            return this.Equals(input as ClientQuotaUsage);
        }

        /// <summary>
        /// Returns true if ClientQuotaUsage instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientQuotaUsage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientQuotaUsage input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AdditionalPrice == input.AdditionalPrice ||
                    this.AdditionalPrice.Equals(input.AdditionalPrice)
                ) && 
                (
                    this.CanUseMore == input.CanUseMore ||
                    this.CanUseMore.Equals(input.CanUseMore)
                ) && 
                (
                    this.Feature == input.Feature ||
                    this.Feature.Equals(input.Feature)
                ) && 
                (
                    this.FeatureAvailable == input.FeatureAvailable ||
                    this.FeatureAvailable.Equals(input.FeatureAvailable)
                ) && 
                (
                    this.Included == input.Included ||
                    this.Included.Equals(input.Included)
                ) && 
                (
                    this.Used == input.Used ||
                    this.Used.Equals(input.Used)
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
                hashCode = (hashCode * 59) + this.AdditionalPrice.GetHashCode();
                hashCode = (hashCode * 59) + this.CanUseMore.GetHashCode();
                hashCode = (hashCode * 59) + this.Feature.GetHashCode();
                hashCode = (hashCode * 59) + this.FeatureAvailable.GetHashCode();
                hashCode = (hashCode * 59) + this.Included.GetHashCode();
                hashCode = (hashCode * 59) + this.Used.GetHashCode();
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
