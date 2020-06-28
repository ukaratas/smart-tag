using System.Text.Json.Serialization;

class TextFieldValue : FieldValueBase
{

    [JsonPropertyName("value")]
    public string Value { get; set; }

}