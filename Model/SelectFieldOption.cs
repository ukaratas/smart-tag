using System.Collections.Generic;
using System.Text.Json.Serialization;

public class SelectFieldOption
{
    [JsonPropertyName("value-code")]
    public string ValueCode { get; set; }

    [JsonPropertyName("names")]
    public List<Name> Names { get; set; }
}