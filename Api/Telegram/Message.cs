using System.Text.Json.Serialization;

namespace Api.Telegram;

public record Message
{
    [JsonPropertyName("message_id")]
    public int Id { get; init; }
    
    [JsonPropertyName("from")]
    public User Sender { get; init; }
    
    [JsonPropertyName("animation")]
    public Animation? Animation { get; init; }
    
    [JsonPropertyName("photo")]
    public IEnumerable<PhotoSize>? PhotoSizes { get; init; }
    
    [JsonPropertyName("video")]
    public Video? Video { get; init; }
}