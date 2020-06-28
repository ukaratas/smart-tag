using System.Collections.Generic;
using System.Text.Json.Serialization;

public class SelectFieldValue : FieldValueBase
{
    [JsonPropertyName("value")]
    public string Value { get; set; }
  
}