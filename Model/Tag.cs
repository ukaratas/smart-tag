using System.Collections.Generic;
using System.Text.Json.Serialization;

/// <summary>
/// Tag definitinion 
/// </summary>
public class Tag
{

    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("names")]
    public List<Name> Names { get; set; }

}