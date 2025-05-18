using System.Text.Json.Serialization;

namespace Api.Models;

public record Photo
{
    [JsonPropertyName("id")]
    public int Id { get; init; }
}