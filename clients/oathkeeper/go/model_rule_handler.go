/*
ORY Oathkeeper

ORY Oathkeeper is a reverse proxy that checks the HTTP Authorization for validity against a set of rules. This service uses Hydra to validate access tokens and policies.

API version: v0.40.4
Contact: hi@ory.am
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
)

// RuleHandler struct for RuleHandler
type RuleHandler struct {
	// Config contains the configuration for the handler. Please read the user guide for a complete list of each handler's available settings.
	Config map[string]interface{} `json:"config,omitempty"`
	// Handler identifies the implementation which will be used to handle this specific request. Please read the user guide for a complete list of available handlers.
	Handler *string `json:"handler,omitempty"`
	AdditionalProperties map[string]interface{}
}

type _RuleHandler RuleHandler

// NewRuleHandler instantiates a new RuleHandler object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewRuleHandler() *RuleHandler {
	this := RuleHandler{}
	return &this
}

// NewRuleHandlerWithDefaults instantiates a new RuleHandler object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewRuleHandlerWithDefaults() *RuleHandler {
	this := RuleHandler{}
	return &this
}

// GetConfig returns the Config field value if set, zero value otherwise.
func (o *RuleHandler) GetConfig() map[string]interface{} {
	if o == nil || o.Config == nil {
		var ret map[string]interface{}
		return ret
	}
	return o.Config
}

// GetConfigOk returns a tuple with the Config field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *RuleHandler) GetConfigOk() (map[string]interface{}, bool) {
	if o == nil || o.Config == nil {
		return nil, false
	}
	return o.Config, true
}

// HasConfig returns a boolean if a field has been set.
func (o *RuleHandler) HasConfig() bool {
	if o != nil && o.Config != nil {
		return true
	}

	return false
}

// SetConfig gets a reference to the given map[string]interface{} and assigns it to the Config field.
func (o *RuleHandler) SetConfig(v map[string]interface{}) {
	o.Config = v
}

// GetHandler returns the Handler field value if set, zero value otherwise.
func (o *RuleHandler) GetHandler() string {
	if o == nil || o.Handler == nil {
		var ret string
		return ret
	}
	return *o.Handler
}

// GetHandlerOk returns a tuple with the Handler field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *RuleHandler) GetHandlerOk() (*string, bool) {
	if o == nil || o.Handler == nil {
		return nil, false
	}
	return o.Handler, true
}

// HasHandler returns a boolean if a field has been set.
func (o *RuleHandler) HasHandler() bool {
	if o != nil && o.Handler != nil {
		return true
	}

	return false
}

// SetHandler gets a reference to the given string and assigns it to the Handler field.
func (o *RuleHandler) SetHandler(v string) {
	o.Handler = &v
}

func (o RuleHandler) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if o.Config != nil {
		toSerialize["config"] = o.Config
	}
	if o.Handler != nil {
		toSerialize["handler"] = o.Handler
	}

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return json.Marshal(toSerialize)
}

func (o *RuleHandler) UnmarshalJSON(bytes []byte) (err error) {
	varRuleHandler := _RuleHandler{}

	if err = json.Unmarshal(bytes, &varRuleHandler); err == nil {
		*o = RuleHandler(varRuleHandler)
	}

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(bytes, &additionalProperties); err == nil {
		delete(additionalProperties, "config")
		delete(additionalProperties, "handler")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableRuleHandler struct {
	value *RuleHandler
	isSet bool
}

func (v NullableRuleHandler) Get() *RuleHandler {
	return v.value
}

func (v *NullableRuleHandler) Set(val *RuleHandler) {
	v.value = val
	v.isSet = true
}

func (v NullableRuleHandler) IsSet() bool {
	return v.isSet
}

func (v *NullableRuleHandler) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableRuleHandler(val *RuleHandler) *NullableRuleHandler {
	return &NullableRuleHandler{value: val, isSet: true}
}

func (v NullableRuleHandler) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableRuleHandler) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


