using System.Text.Json.Serialization;

namespace Api.Telegram;

public record User
{
    [JsonPropertyName("id")]
    public int Id { get; init; }
    
    [JsonPropertyName("first_name")]
    public string Name {get; init; }
    
    [JsonPropertyName("last_name")]
    public string? Surname {get; init; }
}