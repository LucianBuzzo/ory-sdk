/*
 * Ory APIs
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.52
 * Contact: support@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package sh.ory.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.annotations.SerializedName;

import java.io.IOException;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;

/**
 * Gets or Sets NullPlan
 */
@JsonAdapter(NullPlan.Adapter.class)
public enum NullPlan {
  
  UNKNOWN("unknown"),
  
  FREE("free"),
  
  START_UP_MONTHLY("start_up_monthly"),
  
  START_UP_YEARLY("start_up_yearly"),
  
  CUSTOM("custom");

  private String value;

  NullPlan(String value) {
    this.value = value;
  }

  public String getValue() {
    return value;
  }

  @Override
  public String toString() {
    return String.valueOf(value);
  }

  public static NullPlan fromValue(String value) {
    for (NullPlan b : NullPlan.values()) {
      if (b.value.equals(value)) {
        return b;
      }
    }
    throw new IllegalArgumentException("Unexpected value '" + value + "'");
  }

  public static class Adapter extends TypeAdapter<NullPlan> {
    @Override
    public void write(final JsonWriter jsonWriter, final NullPlan enumeration) throws IOException {
      jsonWriter.value(enumeration.getValue());
    }

    @Override
    public NullPlan read(final JsonReader jsonReader) throws IOException {
      String value = jsonReader.nextString();
      return NullPlan.fromValue(value);
    }
  }
}

