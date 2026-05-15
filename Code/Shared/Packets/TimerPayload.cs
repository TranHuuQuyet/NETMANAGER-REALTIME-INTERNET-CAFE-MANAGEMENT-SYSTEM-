using System.Text.Json.Serialization;

namespace NETManager.Shared.Models;

public class TimerPayload
{
    [JsonPropertyName("machineId")]
    public string MachineId { get; set; } = string.Empty;

    [JsonPropertyName("remainingSeconds")]
    public int RemainingSeconds { get; set; }

    [JsonPropertyName("startedAt")]
    public DateTime StartedAt { get; set; }

    [JsonPropertyName("expiresAt")]
    public DateTime ExpiresAt { get; set; }
}
