/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * API version: v0.0.1-alpha.176
 * Contact: support@ory.sh
 */

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
)

// GetCheckResponse The content of the allowed field is mirrored in the HTTP status code.
type GetCheckResponse struct {
	// whether the relation tuple is allowed
	Allowed bool `json:"allowed"`
}

// NewGetCheckResponse instantiates a new GetCheckResponse object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewGetCheckResponse(allowed bool) *GetCheckResponse {
	this := GetCheckResponse{}
	this.Allowed = allowed
	return &this
}

// NewGetCheckResponseWithDefaults instantiates a new GetCheckResponse object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewGetCheckResponseWithDefaults() *GetCheckResponse {
	this := GetCheckResponse{}
	return &this
}

// GetAllowed returns the Allowed field value
func (o *GetCheckResponse) GetAllowed() bool {
	if o == nil {
		var ret bool
		return ret
	}

	return o.Allowed
}

// GetAllowedOk returns a tuple with the Allowed field value
// and a boolean to check if the value has been set.
func (o *GetCheckResponse) GetAllowedOk() (*bool, bool) {
	if o == nil  {
		return nil, false
	}
	return &o.Allowed, true
}

// SetAllowed sets field value
func (o *GetCheckResponse) SetAllowed(v bool) {
	o.Allowed = v
}

func (o GetCheckResponse) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if true {
		toSerialize["allowed"] = o.Allowed
	}
	return json.Marshal(toSerialize)
}

type NullableGetCheckResponse struct {
	value *GetCheckResponse
	isSet bool
}

func (v NullableGetCheckResponse) Get() *GetCheckResponse {
	return v.value
}

func (v *NullableGetCheckResponse) Set(val *GetCheckResponse) {
	v.value = val
	v.isSet = true
}

func (v NullableGetCheckResponse) IsSet() bool {
	return v.isSet
}

func (v *NullableGetCheckResponse) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableGetCheckResponse(val *GetCheckResponse) *NullableGetCheckResponse {
	return &NullableGetCheckResponse{value: val, isSet: true}
}

func (v NullableGetCheckResponse) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableGetCheckResponse) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}

