# NOTE: This file is auto generated by OpenAPI Generator 6.2.1 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.PerformNativeLogoutBody do
  @moduledoc """
  Perform Native Logout Request Body
  """

  @derive [Poison.Encoder]
  defstruct [
    :session_token
  ]

  @type t :: %__MODULE__{
    :session_token => String.t
  }
end

defimpl Poison.Decoder, for: Ory.Model.PerformNativeLogoutBody do
  def decode(value, _options) do
    value
  end
end
