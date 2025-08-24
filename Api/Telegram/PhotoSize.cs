using System.Text.Json.Serialization;

namespace Api.Telegram;

public record PhotoSize
{
    [JsonPropertyName("id")]
    public int Id { get; init; }
    
    [JsonPropertyName("width")]
    public int Width { get; init; }
    
    [JsonPropertyName("height")]
    public int Height { get; init; }
}