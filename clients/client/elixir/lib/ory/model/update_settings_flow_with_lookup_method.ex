# NOTE: This file is auto generated by OpenAPI Generator 6.2.1 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.UpdateSettingsFlowWithLookupMethod do
  @moduledoc """
  Update Settings Flow with Lookup Method
  """

  @derive [Poison.Encoder]
  defstruct [
    :csrf_token,
    :lookup_secret_confirm,
    :lookup_secret_disable,
    :lookup_secret_regenerate,
    :lookup_secret_reveal,
    :method
  ]

  @type t :: %__MODULE__{
    :csrf_token => String.t | nil,
    :lookup_secret_confirm => boolean() | nil,
    :lookup_secret_disable => boolean() | nil,
    :lookup_secret_regenerate => boolean() | nil,
    :lookup_secret_reveal => boolean() | nil,
    :method => String.t
  }
end

defimpl Poison.Decoder, for: Ory.Model.UpdateSettingsFlowWithLookupMethod do
  def decode(value, _options) do
    value
  end
end
