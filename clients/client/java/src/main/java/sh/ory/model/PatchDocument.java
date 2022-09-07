/*
 * Ory APIs
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.2.0-alpha.34
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

/**
 * A JSONPatch document as defined by RFC 6902
 */
@ApiModel(description = "A JSONPatch document as defined by RFC 6902")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2022-09-07T14:25:18.032801892Z[Etc/UTC]")
public class PatchDocument {
  public static final String SERIALIZED_NAME_FROM = "from";
  @SerializedName(SERIALIZED_NAME_FROM)
  private String from;

  public static final String SERIALIZED_NAME_OP = "op";
  @SerializedName(SERIALIZED_NAME_OP)
  private String op;

  public static final String SERIALIZED_NAME_PATH = "path";
  @SerializedName(SERIALIZED_NAME_PATH)
  private String path;

  public static final String SERIALIZED_NAME_VALUE = "value";
  @SerializedName(SERIALIZED_NAME_VALUE)
  private Object value;

  public PatchDocument() { 
  }

  public PatchDocument from(String from) {
    
    this.from = from;
    return this;
  }

   /**
   * A JSON-pointer
   * @return from
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "A JSON-pointer")

  public String getFrom() {
    return from;
  }


  public void setFrom(String from) {
    this.from = from;
  }


  public PatchDocument op(String op) {
    
    this.op = op;
    return this;
  }

   /**
   * The operation to be performed
   * @return op
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(example = "\"replace\"", required = true, value = "The operation to be performed")

  public String getOp() {
    return op;
  }


  public void setOp(String op) {
    this.op = op;
  }


  public PatchDocument path(String path) {
    
    this.path = path;
    return this;
  }

   /**
   * A JSON-pointer
   * @return path
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(example = "\"/name\"", required = true, value = "A JSON-pointer")

  public String getPath() {
    return path;
  }


  public void setPath(String path) {
    this.path = path;
  }


  public PatchDocument value(Object value) {
    
    this.value = value;
    return this;
  }

   /**
   * The value to be used within the operations
   * @return value
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "The value to be used within the operations")

  public Object getValue() {
    return value;
  }


  public void setValue(Object value) {
    this.value = value;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    PatchDocument patchDocument = (PatchDocument) o;
    return Objects.equals(this.from, patchDocument.from) &&
        Objects.equals(this.op, patchDocument.op) &&
        Objects.equals(this.path, patchDocument.path) &&
        Objects.equals(this.value, patchDocument.value);
  }

  @Override
  public int hashCode() {
    return Objects.hash(from, op, path, value);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class PatchDocument {\n");
    sb.append("    from: ").append(toIndentedString(from)).append("\n");
    sb.append("    op: ").append(toIndentedString(op)).append("\n");
    sb.append("    path: ").append(toIndentedString(path)).append("\n");
    sb.append("    value: ").append(toIndentedString(value)).append("\n");
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

}

