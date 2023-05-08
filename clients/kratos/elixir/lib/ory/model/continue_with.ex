# NOTE: This file is auto generated by OpenAPI Generator 6.2.1 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.ContinueWith do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :action,
    :flow,
    :ory_session_token
  ]

  @type t :: %__MODULE__{
    :action => String.t,
    :flow => Ory.Model.ContinueWithVerificationUiFlow.t,
    :ory_session_token => String.t
  }
end

defimpl Poison.Decoder, for: Ory.Model.ContinueWith do
  import Ory.Deserializer
  def decode(value, options) do
    value
    |> deserialize(:flow, :struct, Ory.Model.ContinueWithVerificationUiFlow, options)
  end
end
