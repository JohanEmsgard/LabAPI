using System.Text.Json.Serialization;

public class Jedi
{
    [JsonPropertyName("Jedi")]
    public string name { get; set; }

    [JsonPropertyName("Height")]
    public int height { get; set; }
}
