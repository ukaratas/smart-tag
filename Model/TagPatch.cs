using System.Collections.Generic;
using System.Text.Json.Serialization;

public class TagPatch
{

    [JsonPropertyName("names")]
    public List<Name> Names { get; set; }

}