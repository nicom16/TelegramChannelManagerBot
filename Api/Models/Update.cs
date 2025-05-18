using System.Text.Json.Serialization;
using Api.Controllers;

namespace Api.Models;

public record Update
{
    [JsonPropertyName("update_id")]
    public int Id { get; init; }
    
    [JsonPropertyName("message")]
    public Message? Message { get; init; }
}