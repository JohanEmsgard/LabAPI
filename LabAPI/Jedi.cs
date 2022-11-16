using System.Text.Json.Serialization;

public class Jedi
{
    [JsonPropertyName("name")]
    public string name { get; set; }

    [JsonPropertyName("height")]
    public int height { get; set; }
}
