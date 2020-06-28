using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class TagStatistics
{

    [JsonPropertyName("entity-count")]
    public long EntityCount { get; set; }


    [JsonPropertyName("items")]
    public List<TagStatisticsItem> Items { get; set; }
}