using System.Collections.Generic;
using System.Text.Json.Serialization;

public class ResponsePage<T>
{
    [JsonPropertyName("items")]
    public List<T> Items { get; set; }

    [JsonPropertyName("has-next-page")]
    public bool HasNextPage { get; set; }

}