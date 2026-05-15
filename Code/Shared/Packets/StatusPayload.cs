using System.Text.Json.Serialization;

namespace NETManager.Shared.Models;

public class StatusPayload
{
    [JsonPropertyName("machineId")]
    public string MachineId { get; set; } = string.Empty;

    [JsonPropertyName("machineName")]
    public string MachineName { get; set; } = string.Empty;

    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;

    [JsonPropertyName("ipAddress")]
    public string IpAddress { get; set; } = string.Empty;

    [JsonPropertyName("lastSeen")]
    public DateTime LastSeen { get; set; }
}
