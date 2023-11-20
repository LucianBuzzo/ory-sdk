/*
Ory APIs

Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

API version: v1.4.1
Contact: support@ory.sh
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
	"fmt"
)

// checks if the InternalProvisionMockSubscription type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &InternalProvisionMockSubscription{}

// InternalProvisionMockSubscription Internal Provision Mock Subscription Request Body
type InternalProvisionMockSubscription struct {
	// Currency usd USD eur Euro
	Currency string `json:"currency"`
	// Identity ID
	IdentityId string `json:"identity_id"`
	// Billing Interval monthly Monthly yearly Yearly
	Interval string `json:"interval"`
	// Plan ID
	Plan string `json:"plan"`
	AdditionalProperties map[string]interface{}
}

type _InternalProvisionMockSubscription InternalProvisionMockSubscription

// NewInternalProvisionMockSubscription instantiates a new InternalProvisionMockSubscription object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewInternalProvisionMockSubscription(currency string, identityId string, interval string, plan string) *InternalProvisionMockSubscription {
	this := InternalProvisionMockSubscription{}
	this.Currency = currency
	this.IdentityId = identityId
	this.Interval = interval
	this.Plan = plan
	return &this
}

// NewInternalProvisionMockSubscriptionWithDefaults instantiates a new InternalProvisionMockSubscription object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewInternalProvisionMockSubscriptionWithDefaults() *InternalProvisionMockSubscription {
	this := InternalProvisionMockSubscription{}
	return &this
}

// GetCurrency returns the Currency field value
func (o *InternalProvisionMockSubscription) GetCurrency() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Currency
}

// GetCurrencyOk returns a tuple with the Currency field value
// and a boolean to check if the value has been set.
func (o *InternalProvisionMockSubscription) GetCurrencyOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Currency, true
}

// SetCurrency sets field value
func (o *InternalProvisionMockSubscription) SetCurrency(v string) {
	o.Currency = v
}

// GetIdentityId returns the IdentityId field value
func (o *InternalProvisionMockSubscription) GetIdentityId() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.IdentityId
}

// GetIdentityIdOk returns a tuple with the IdentityId field value
// and a boolean to check if the value has been set.
func (o *InternalProvisionMockSubscription) GetIdentityIdOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.IdentityId, true
}

// SetIdentityId sets field value
func (o *InternalProvisionMockSubscription) SetIdentityId(v string) {
	o.IdentityId = v
}

// GetInterval returns the Interval field value
func (o *InternalProvisionMockSubscription) GetInterval() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Interval
}

// GetIntervalOk returns a tuple with the Interval field value
// and a boolean to check if the value has been set.
func (o *InternalProvisionMockSubscription) GetIntervalOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Interval, true
}

// SetInterval sets field value
func (o *InternalProvisionMockSubscription) SetInterval(v string) {
	o.Interval = v
}

// GetPlan returns the Plan field value
func (o *InternalProvisionMockSubscription) GetPlan() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Plan
}

// GetPlanOk returns a tuple with the Plan field value
// and a boolean to check if the value has been set.
func (o *InternalProvisionMockSubscription) GetPlanOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Plan, true
}

// SetPlan sets field value
func (o *InternalProvisionMockSubscription) SetPlan(v string) {
	o.Plan = v
}

func (o InternalProvisionMockSubscription) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o InternalProvisionMockSubscription) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	toSerialize["currency"] = o.Currency
	toSerialize["identity_id"] = o.IdentityId
	toSerialize["interval"] = o.Interval
	toSerialize["plan"] = o.Plan

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *InternalProvisionMockSubscription) UnmarshalJSON(bytes []byte) (err error) {
    // This validates that all required properties are included in the JSON object
	// by unmarshalling the object into a generic map with string keys and checking
	// that every required field exists as a key in the generic map.
	requiredProperties := []string{
		"currency",
		"identity_id",
		"interval",
		"plan",
	}

	allProperties := make(map[string]interface{})

	err = json.Unmarshal(bytes, &allProperties)

	if err != nil {
		return err;
	}

	for _, requiredProperty := range(requiredProperties) {
		if _, exists := allProperties[requiredProperty]; !exists {
			return fmt.Errorf("no value given for required property %v", requiredProperty)
		}
	}

	varInternalProvisionMockSubscription := _InternalProvisionMockSubscription{}

	err = json.Unmarshal(bytes, &varInternalProvisionMockSubscription)

	if err != nil {
		return err
	}

	*o = InternalProvisionMockSubscription(varInternalProvisionMockSubscription)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(bytes, &additionalProperties); err == nil {
		delete(additionalProperties, "currency")
		delete(additionalProperties, "identity_id")
		delete(additionalProperties, "interval")
		delete(additionalProperties, "plan")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableInternalProvisionMockSubscription struct {
	value *InternalProvisionMockSubscription
	isSet bool
}

func (v NullableInternalProvisionMockSubscription) Get() *InternalProvisionMockSubscription {
	return v.value
}

func (v *NullableInternalProvisionMockSubscription) Set(val *InternalProvisionMockSubscription) {
	v.value = val
	v.isSet = true
}

func (v NullableInternalProvisionMockSubscription) IsSet() bool {
	return v.isSet
}

func (v *NullableInternalProvisionMockSubscription) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableInternalProvisionMockSubscription(val *InternalProvisionMockSubscription) *NullableInternalProvisionMockSubscription {
	return &NullableInternalProvisionMockSubscription{value: val, isSet: true}
}

func (v NullableInternalProvisionMockSubscription) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableInternalProvisionMockSubscription) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


