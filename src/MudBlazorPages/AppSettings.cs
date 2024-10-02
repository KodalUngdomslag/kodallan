using System.Text.Json.Serialization;

namespace MudBlazorPages;

public class AppSettings
{
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    [JsonPropertyName("intValue")]
    public int IntValue { get; set; }
}