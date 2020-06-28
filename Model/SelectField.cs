using System.Collections.Generic;
using System.Text.Json.Serialization;

class SelectField : FieldBase
{
     [JsonPropertyName("options")]
    public List<SelectFieldOption> Options { get; set; }
}