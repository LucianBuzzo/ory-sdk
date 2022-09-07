/*
Ory APIs

Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

API version: v0.2.0-alpha.34
Contact: support@ory.sh
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
)

// TrustedJsonWebKey struct for TrustedJsonWebKey
type TrustedJsonWebKey struct {
	// The \"key_id\" is key unique identifier (same as kid header in jws/jwt).
	Kid *string `json:"kid,omitempty"`
	// The \"set\" is basically a name for a group(set) of keys. Will be the same as \"issuer\" in grant.
	Set *string `json:"set,omitempty"`
}

// NewTrustedJsonWebKey instantiates a new TrustedJsonWebKey object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewTrustedJsonWebKey() *TrustedJsonWebKey {
	this := TrustedJsonWebKey{}
	return &this
}

// NewTrustedJsonWebKeyWithDefaults instantiates a new TrustedJsonWebKey object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewTrustedJsonWebKeyWithDefaults() *TrustedJsonWebKey {
	this := TrustedJsonWebKey{}
	return &this
}

// GetKid returns the Kid field value if set, zero value otherwise.
func (o *TrustedJsonWebKey) GetKid() string {
	if o == nil || o.Kid == nil {
		var ret string
		return ret
	}
	return *o.Kid
}

// GetKidOk returns a tuple with the Kid field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *TrustedJsonWebKey) GetKidOk() (*string, bool) {
	if o == nil || o.Kid == nil {
		return nil, false
	}
	return o.Kid, true
}

// HasKid returns a boolean if a field has been set.
func (o *TrustedJsonWebKey) HasKid() bool {
	if o != nil && o.Kid != nil {
		return true
	}

	return false
}

// SetKid gets a reference to the given string and assigns it to the Kid field.
func (o *TrustedJsonWebKey) SetKid(v string) {
	o.Kid = &v
}

// GetSet returns the Set field value if set, zero value otherwise.
func (o *TrustedJsonWebKey) GetSet() string {
	if o == nil || o.Set == nil {
		var ret string
		return ret
	}
	return *o.Set
}

// GetSetOk returns a tuple with the Set field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *TrustedJsonWebKey) GetSetOk() (*string, bool) {
	if o == nil || o.Set == nil {
		return nil, false
	}
	return o.Set, true
}

// HasSet returns a boolean if a field has been set.
func (o *TrustedJsonWebKey) HasSet() bool {
	if o != nil && o.Set != nil {
		return true
	}

	return false
}

// SetSet gets a reference to the given string and assigns it to the Set field.
func (o *TrustedJsonWebKey) SetSet(v string) {
	o.Set = &v
}

func (o TrustedJsonWebKey) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if o.Kid != nil {
		toSerialize["kid"] = o.Kid
	}
	if o.Set != nil {
		toSerialize["set"] = o.Set
	}
	return json.Marshal(toSerialize)
}

type NullableTrustedJsonWebKey struct {
	value *TrustedJsonWebKey
	isSet bool
}

func (v NullableTrustedJsonWebKey) Get() *TrustedJsonWebKey {
	return v.value
}

func (v *NullableTrustedJsonWebKey) Set(val *TrustedJsonWebKey) {
	v.value = val
	v.isSet = true
}

func (v NullableTrustedJsonWebKey) IsSet() bool {
	return v.isSet
}

func (v *NullableTrustedJsonWebKey) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableTrustedJsonWebKey(val *TrustedJsonWebKey) *NullableTrustedJsonWebKey {
	return &NullableTrustedJsonWebKey{value: val, isSet: true}
}

func (v NullableTrustedJsonWebKey) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableTrustedJsonWebKey) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


