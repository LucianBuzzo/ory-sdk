=begin
#Ory APIs

#Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

The version of the OpenAPI document: v0.0.1-alpha.138
Contact: support@ory.sh
Generated by: https://openapi-generator.tech
OpenAPI Generator version: 5.4.0

=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for OryClient::SelfServiceLogoutUrl
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe OryClient::SelfServiceLogoutUrl do
  let(:instance) { OryClient::SelfServiceLogoutUrl.new }

  describe 'test an instance of SelfServiceLogoutUrl' do
    it 'should create an instance of SelfServiceLogoutUrl' do
      expect(instance).to be_instance_of(OryClient::SelfServiceLogoutUrl)
    end
  end
  describe 'test attribute "logout_token"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "logout_url"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
