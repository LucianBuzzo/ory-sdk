# NOTE: This file is auto generated by OpenAPI Generator 6.2.1 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.IdentityWithCredentialsOidcConfigProvider do
  @moduledoc """
  Create Identity and Import Social Sign In Credentials Configuration
  """

  @derive [Poison.Encoder]
  defstruct [
    :provider,
    :subject
  ]

  @type t :: %__MODULE__{
    :provider => String.t,
    :subject => String.t
  }
end

defimpl Poison.Decoder, for: Ory.Model.IdentityWithCredentialsOidcConfigProvider do
  def decode(value, _options) do
    value
  end
end
