# NOTE: This file is auto generated by OpenAPI Generator 6.2.1 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.UpdateVerificationFlowWithLinkMethod do
  @moduledoc """
  Update Verification Flow with Link Method
  """

  @derive [Poison.Encoder]
  defstruct [
    :csrf_token,
    :email,
    :method
  ]

  @type t :: %__MODULE__{
    :csrf_token => String.t | nil,
    :email => String.t,
    :method => String.t
  }
end

defimpl Poison.Decoder, for: Ory.Model.UpdateVerificationFlowWithLinkMethod do
  def decode(value, _options) do
    value
  end
end
