=begin
#ORY Oathkeeper

#ORY Oathkeeper is a reverse proxy that checks the HTTP Authorization for validity against a set of rules. This service uses Hydra to validate access tokens and policies.

The version of the OpenAPI document: v0.40.4
Contact: hi@ory.am
Generated by: https://openapi-generator.tech
OpenAPI Generator version: 6.0.1

=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for OryOathkeeperClient::RuleHandler
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe OryOathkeeperClient::RuleHandler do
  let(:instance) { OryOathkeeperClient::RuleHandler.new }

  describe 'test an instance of RuleHandler' do
    it 'should create an instance of RuleHandler' do
      expect(instance).to be_instance_of(OryOathkeeperClient::RuleHandler)
    end
  end
  describe 'test attribute "config"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "handler"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
