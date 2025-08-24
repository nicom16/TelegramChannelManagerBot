using System.Text.Json.Serialization;

namespace Api.Telegram;

public record PhotoSize
{
    [JsonPropertyName("id")]
    public int Id { get; init; }
}