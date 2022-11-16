using System.Text.Json.Serialization;

public class Sith
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
