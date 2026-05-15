using System.Text.Json.Serialization;

namespace NETManager.Shared.Models;

public class ChatPayload
{
    [JsonPropertyName("sender")]
    public string Sender { get; set; } = string.Empty;

    [JsonPropertyName("receiver")]
    public string Receiver { get; set; } = string.Empty;

    [JsonPropertyName("message")]
    public string Message { get; set; } = string.Empty;
}
