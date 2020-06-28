using System.Collections.Generic;
using System.Text.Json.Serialization;

public class Tag
{

    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("names")]
    public List<Name> Names { get; set; }

}