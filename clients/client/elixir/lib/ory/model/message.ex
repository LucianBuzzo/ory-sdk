# NOTE: This file is auto generated by OpenAPI Generator 6.2.1 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.Message do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :body,
    :created_at,
    :dispatches,
    :id,
    :recipient,
    :send_count,
    :status,
    :subject,
    :template_type,
    :type,
    :updated_at
  ]

  @type t :: %__MODULE__{
    :body => String.t,
    :created_at => DateTime.t,
    :dispatches => [Ory.Model.MessageDispatch.t] | nil,
    :id => String.t,
    :recipient => String.t,
    :send_count => integer(),
    :status => Ory.Model.CourierMessageStatus.t,
    :subject => String.t,
    :template_type => String.t,
    :type => Ory.Model.CourierMessageType.t,
    :updated_at => DateTime.t
  }
end

defimpl Poison.Decoder, for: Ory.Model.Message do
  import Ory.Deserializer
  def decode(value, options) do
    value
    |> deserialize(:dispatches, :list, Ory.Model.MessageDispatch, options)
    |> deserialize(:status, :struct, Ory.Model.CourierMessageStatus, options)
    |> deserialize(:type, :struct, Ory.Model.CourierMessageType, options)
  end
end
