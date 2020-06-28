using System.Text.Json.Serialization;

class NumberFieldValue : FieldValueBase
{
    [JsonPropertyName("value")]
    public decimal Value { get; set; }
}