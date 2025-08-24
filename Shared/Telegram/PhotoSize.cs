using System.Text.Json.Serialization;

namespace Shared.Telegram;

public record PhotoSize
{
    [JsonPropertyName("id")]
    public int Id { get; init; }
}