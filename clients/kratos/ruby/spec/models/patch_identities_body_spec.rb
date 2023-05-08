=begin
#Ory Identities API

#This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 

The version of the OpenAPI document: v0.13.1
Contact: office@ory.sh
Generated by: https://openapi-generator.tech
OpenAPI Generator version: 6.0.1

=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for OryKratosClient::PatchIdentitiesBody
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe OryKratosClient::PatchIdentitiesBody do
  let(:instance) { OryKratosClient::PatchIdentitiesBody.new }

  describe 'test an instance of PatchIdentitiesBody' do
    it 'should create an instance of PatchIdentitiesBody' do
      expect(instance).to be_instance_of(OryKratosClient::PatchIdentitiesBody)
    end
  end
  describe 'test attribute "identities"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end