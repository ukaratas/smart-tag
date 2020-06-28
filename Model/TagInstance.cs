using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class TagInstance
{

    [JsonPropertyName("entity-code")]
    public string EntityCode { get; set; }


    [JsonPropertyName("instance-id")]
    public Guid InstanceId { get; set; }


    [JsonPropertyName("values")]
    public List<FieldValueBase> Values { get; set; }

}