using System.Text.Json.Serialization;

class NumberField : FieldBase
{
    [JsonPropertyName("decimal-precision")]
    public int Value { get; set; }
}