using System;
using System.Text.Json.Serialization;

public class TagStatisticsItem
{

    [JsonPropertyName("entity-code")]
    public string EntityCode { get; set; }

    [JsonPropertyName("instance-count")]
    public long InstanceCount { get; set; }

    [JsonPropertyName("first-used-at")]
    public DateTime FirstUsed { get; set; }

    [JsonPropertyName("last-used-at")]
    public DateTime LastUsed { get; set; }


}