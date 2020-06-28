using System.Text.Json.Serialization;

class TextField : FieldBase
{

    [JsonPropertyName("max-lenght")]
    public int Value { get; set; }

}