using System.Text.Json.Serialization;

namespace Shared.Telegram;

public record Photo
{
    [JsonPropertyName("id")]
    public int Id { get; init; }
}