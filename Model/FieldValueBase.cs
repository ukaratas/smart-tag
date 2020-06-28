using System.Collections.Generic;
using System.Text.Json.Serialization;

public class FieldValueBase
{
    [JsonPropertyName("code")]
    public string Code { get; set; }
}