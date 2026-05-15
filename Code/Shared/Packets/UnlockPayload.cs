using System.Text.Json.Serialization;

namespace NETManager.Shared.Models;

public class UnlockPayload
{
    [JsonPropertyName("machineId")]
    public string MachineId { get; set; } = string.Empty;

    [JsonPropertyName("issuedBy")]
    public string IssuedBy { get; set; } = string.Empty;

    [JsonPropertyName("reason")]
    public string Reason { get; set; } = string.Empty;
}
