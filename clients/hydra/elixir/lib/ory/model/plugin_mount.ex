# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# https://openapi-generator.tech
# Do not edit the class manually.

defmodule Ory.Model.PluginMount do
  @moduledoc """
  PluginMount plugin mount
  """

  @derive [Poison.Encoder]
  defstruct [
    :"Description",
    :"Destination",
    :"Name",
    :"Options",
    :"Settable",
    :"Source",
    :"Type"
  ]

  @type t :: %__MODULE__{
    :"Description" => String.t,
    :"Destination" => String.t,
    :"Name" => String.t,
    :"Options" => [String.t],
    :"Settable" => [String.t],
    :"Source" => String.t,
    :"Type" => String.t
  }
end

defimpl Poison.Decoder, for: Ory.Model.PluginMount do
  def decode(value, _options) do
    value
  end
end
