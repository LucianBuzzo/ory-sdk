/*
 * Ory APIs
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.26
 * Contact: support@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package sh.ory.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import sh.ory.model.ContinueWithVerificationUiFlow;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonArray;
import com.google.gson.JsonDeserializationContext;
import com.google.gson.JsonDeserializer;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonParseException;
import com.google.gson.TypeAdapterFactory;
import com.google.gson.reflect.TypeToken;

import java.lang.reflect.Type;
import java.util.HashMap;
import java.util.HashSet;
import java.util.List;
import java.util.Map;
import java.util.Map.Entry;
import java.util.Set;

import sh.ory.JSON;

/**
 * Indicates, that the UI flow could be continued by showing a verification ui
 */
@ApiModel(description = "Indicates, that the UI flow could be continued by showing a verification ui")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2023-05-05T06:48:46.434133512Z[Etc/UTC]")
public class ContinueWithVerificationUi {
  /**
   * Action will always be &#x60;show_verification_ui&#x60; set_ory_session_token ContinueWithActionSetOrySessionToken show_verification_ui ContinueWithActionShowVerificationUI
   */
  @JsonAdapter(ActionEnum.Adapter.class)
  public enum ActionEnum {
    SET_ORY_SESSION_TOKEN("set_ory_session_token"),
    
    SHOW_VERIFICATION_UI("show_verification_ui");

    private String value;

    ActionEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static ActionEnum fromValue(String value) {
      for (ActionEnum b : ActionEnum.values()) {
        if (b.value.equals(value)) {
          return b;
        }
      }
      throw new IllegalArgumentException("Unexpected value '" + value + "'");
    }

    public static class Adapter extends TypeAdapter<ActionEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final ActionEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public ActionEnum read(final JsonReader jsonReader) throws IOException {
        String value =  jsonReader.nextString();
        return ActionEnum.fromValue(value);
      }
    }
  }

  public static final String SERIALIZED_NAME_ACTION = "action";
  @SerializedName(SERIALIZED_NAME_ACTION)
  private ActionEnum action;

  public static final String SERIALIZED_NAME_FLOW = "flow";
  @SerializedName(SERIALIZED_NAME_FLOW)
  private ContinueWithVerificationUiFlow flow;

  public ContinueWithVerificationUi() {
  }

  public ContinueWithVerificationUi action(ActionEnum action) {
    
    this.action = action;
    return this;
  }

   /**
   * Action will always be &#x60;show_verification_ui&#x60; set_ory_session_token ContinueWithActionSetOrySessionToken show_verification_ui ContinueWithActionShowVerificationUI
   * @return action
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "Action will always be `show_verification_ui` set_ory_session_token ContinueWithActionSetOrySessionToken show_verification_ui ContinueWithActionShowVerificationUI")

  public ActionEnum getAction() {
    return action;
  }


  public void setAction(ActionEnum action) {
    this.action = action;
  }


  public ContinueWithVerificationUi flow(ContinueWithVerificationUiFlow flow) {
    
    this.flow = flow;
    return this;
  }

   /**
   * Get flow
   * @return flow
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "")

  public ContinueWithVerificationUiFlow getFlow() {
    return flow;
  }


  public void setFlow(ContinueWithVerificationUiFlow flow) {
    this.flow = flow;
  }



  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ContinueWithVerificationUi continueWithVerificationUi = (ContinueWithVerificationUi) o;
    return Objects.equals(this.action, continueWithVerificationUi.action) &&
        Objects.equals(this.flow, continueWithVerificationUi.flow);
  }

  @Override
  public int hashCode() {
    return Objects.hash(action, flow);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ContinueWithVerificationUi {\n");
    sb.append("    action: ").append(toIndentedString(action)).append("\n");
    sb.append("    flow: ").append(toIndentedString(flow)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }


  public static HashSet<String> openapiFields;
  public static HashSet<String> openapiRequiredFields;

  static {
    // a set of all properties/fields (JSON key names)
    openapiFields = new HashSet<String>();
    openapiFields.add("action");
    openapiFields.add("flow");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
    openapiRequiredFields.add("action");
    openapiRequiredFields.add("flow");
  }

 /**
  * Validates the JSON Object and throws an exception if issues found
  *
  * @param jsonObj JSON Object
  * @throws IOException if the JSON Object is invalid with respect to ContinueWithVerificationUi
  */
  public static void validateJsonObject(JsonObject jsonObj) throws IOException {
      if (jsonObj == null) {
        if (!ContinueWithVerificationUi.openapiRequiredFields.isEmpty()) { // has required fields but JSON object is null
          throw new IllegalArgumentException(String.format("The required field(s) %s in ContinueWithVerificationUi is not found in the empty JSON string", ContinueWithVerificationUi.openapiRequiredFields.toString()));
        }
      }

      Set<Entry<String, JsonElement>> entries = jsonObj.entrySet();
      // check to see if the JSON string contains additional fields
      for (Entry<String, JsonElement> entry : entries) {
        if (!ContinueWithVerificationUi.openapiFields.contains(entry.getKey())) {
          throw new IllegalArgumentException(String.format("The field `%s` in the JSON string is not defined in the `ContinueWithVerificationUi` properties. JSON: %s", entry.getKey(), jsonObj.toString()));
        }
      }

      // check to make sure all required properties/fields are present in the JSON string
      for (String requiredField : ContinueWithVerificationUi.openapiRequiredFields) {
        if (jsonObj.get(requiredField) == null) {
          throw new IllegalArgumentException(String.format("The required field `%s` is not found in the JSON string: %s", requiredField, jsonObj.toString()));
        }
      }
      if (!jsonObj.get("action").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `action` to be a primitive type in the JSON string but got `%s`", jsonObj.get("action").toString()));
      }
      // validate the required field `flow`
      ContinueWithVerificationUiFlow.validateJsonObject(jsonObj.getAsJsonObject("flow"));
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!ContinueWithVerificationUi.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'ContinueWithVerificationUi' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<ContinueWithVerificationUi> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(ContinueWithVerificationUi.class));

       return (TypeAdapter<T>) new TypeAdapter<ContinueWithVerificationUi>() {
           @Override
           public void write(JsonWriter out, ContinueWithVerificationUi value) throws IOException {
             JsonObject obj = thisAdapter.toJsonTree(value).getAsJsonObject();
             elementAdapter.write(out, obj);
           }

           @Override
           public ContinueWithVerificationUi read(JsonReader in) throws IOException {
             JsonObject jsonObj = elementAdapter.read(in).getAsJsonObject();
             validateJsonObject(jsonObj);
             return thisAdapter.fromJsonTree(jsonObj);
           }

       }.nullSafe();
    }
  }

 /**
  * Create an instance of ContinueWithVerificationUi given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of ContinueWithVerificationUi
  * @throws IOException if the JSON string is invalid with respect to ContinueWithVerificationUi
  */
  public static ContinueWithVerificationUi fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, ContinueWithVerificationUi.class);
  }

 /**
  * Convert an instance of ContinueWithVerificationUi to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}
