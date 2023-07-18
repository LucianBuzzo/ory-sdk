=begin
#ORY Oathkeeper

#ORY Oathkeeper is a reverse proxy that checks the HTTP Authorization for validity against a set of rules. This service uses Hydra to validate access tokens and policies.

The version of the OpenAPI document: v0.40.6
Contact: hi@ory.am
Generated by: https://openapi-generator.tech
OpenAPI Generator version: 6.0.1

=end

require 'spec_helper'
require 'json'

# Unit tests for OryOathkeeperClient::HealthApi
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe 'HealthApi' do
  before do
    # run before each test
    @api_instance = OryOathkeeperClient::HealthApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of HealthApi' do
    it 'should create an instance of HealthApi' do
      expect(@api_instance).to be_instance_of(OryOathkeeperClient::HealthApi)
    end
  end

  # unit tests for is_instance_alive
  # Check alive status
  # This endpoint returns a 200 status code when the HTTP server is up running. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
  # @param [Hash] opts the optional parameters
  # @return [HealthStatus]
  describe 'is_instance_alive test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for is_instance_ready
  # Check readiness status
  # This endpoint returns a 200 status code when the HTTP server is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
  # @param [Hash] opts the optional parameters
  # @return [HealthStatus]
  describe 'is_instance_ready test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
