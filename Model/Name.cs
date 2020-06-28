using System.Collections.Generic;
using System.Text.Json.Serialization;

public class Name
{

    [JsonPropertyName("name")]
    public string Text { get; set; }

    [JsonPropertyName("language-code")]
    public string LanguageCode { get; set; }
}