using System.Text.Json.Serialization;

namespace Shared.Telegram;

public record Update
{
    [JsonPropertyName("update_id")]
    public int Id { get; init; }
    
    [JsonPropertyName("message")]
    public Message? Message { get; init; }
}