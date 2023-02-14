# NOTE: This file is auto generated by OpenAPI Generator 6.2.1 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.PaginationHeaders do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :link,
    :"x-total-count"
  ]

  @type t :: %__MODULE__{
    :link => String.t | nil,
    :"x-total-count" => String.t | nil
  }
end

defimpl Poison.Decoder, for: Ory.Model.PaginationHeaders do
  def decode(value, _options) do
    value
  end
end
