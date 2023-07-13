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

# Unit tests for OryOathkeeperClient::VersionApi
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe 'VersionApi' do
  before do
    # run before each test
    @api_instance = OryOathkeeperClient::VersionApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of VersionApi' do
    it 'should create an instance of VersionApi' do
      expect(@api_instance).to be_instance_of(OryOathkeeperClient::VersionApi)
    end
  end

  # unit tests for get_version
  # Get service version
  # This endpoint returns the service version typically notated using semantic versioning.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
  # @param [Hash] opts the optional parameters
  # @return [Version]
  describe 'get_version test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
