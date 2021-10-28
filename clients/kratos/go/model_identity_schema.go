/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * API version: v0.8.0-alpha.2
 * Contact: hi@ory.sh
 */

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
)

// IdentitySchema struct for IdentitySchema
type IdentitySchema struct {
	// The ID of the Identity JSON Schema
	Id *string `json:"id,omitempty"`
	// The actual Identity JSON Schema
	Schema map[string]interface{} `json:"schema,omitempty"`
}

// NewIdentitySchema instantiates a new IdentitySchema object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewIdentitySchema() *IdentitySchema {
	this := IdentitySchema{}
	return &this
}

// NewIdentitySchemaWithDefaults instantiates a new IdentitySchema object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewIdentitySchemaWithDefaults() *IdentitySchema {
	this := IdentitySchema{}
	return &this
}

// GetId returns the Id field value if set, zero value otherwise.
func (o *IdentitySchema) GetId() string {
	if o == nil || o.Id == nil {
		var ret string
		return ret
	}
	return *o.Id
}

// GetIdOk returns a tuple with the Id field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *IdentitySchema) GetIdOk() (*string, bool) {
	if o == nil || o.Id == nil {
		return nil, false
	}
	return o.Id, true
}

// HasId returns a boolean if a field has been set.
func (o *IdentitySchema) HasId() bool {
	if o != nil && o.Id != nil {
		return true
	}

	return false
}

// SetId gets a reference to the given string and assigns it to the Id field.
func (o *IdentitySchema) SetId(v string) {
	o.Id = &v
}

// GetSchema returns the Schema field value if set, zero value otherwise.
func (o *IdentitySchema) GetSchema() map[string]interface{} {
	if o == nil || o.Schema == nil {
		var ret map[string]interface{}
		return ret
	}
	return o.Schema
}

// GetSchemaOk returns a tuple with the Schema field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *IdentitySchema) GetSchemaOk() (map[string]interface{}, bool) {
	if o == nil || o.Schema == nil {
		return nil, false
	}
	return o.Schema, true
}

// HasSchema returns a boolean if a field has been set.
func (o *IdentitySchema) HasSchema() bool {
	if o != nil && o.Schema != nil {
		return true
	}

	return false
}

// SetSchema gets a reference to the given map[string]interface{} and assigns it to the Schema field.
func (o *IdentitySchema) SetSchema(v map[string]interface{}) {
	o.Schema = v
}

func (o IdentitySchema) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if o.Id != nil {
		toSerialize["id"] = o.Id
	}
	if o.Schema != nil {
		toSerialize["schema"] = o.Schema
	}
	return json.Marshal(toSerialize)
}

type NullableIdentitySchema struct {
	value *IdentitySchema
	isSet bool
}

func (v NullableIdentitySchema) Get() *IdentitySchema {
	return v.value
}

func (v *NullableIdentitySchema) Set(val *IdentitySchema) {
	v.value = val
	v.isSet = true
}

func (v NullableIdentitySchema) IsSet() bool {
	return v.isSet
}

func (v *NullableIdentitySchema) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableIdentitySchema(val *IdentitySchema) *NullableIdentitySchema {
	return &NullableIdentitySchema{value: val, isSet: true}
}

func (v NullableIdentitySchema) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableIdentitySchema) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


