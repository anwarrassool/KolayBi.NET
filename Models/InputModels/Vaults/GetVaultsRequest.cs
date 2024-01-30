using System.Text.Json.Serialization;
using KolayBi.Net.Interfaces;
using Newtonsoft.Json;

namespace KolayBi.Net.Models.GetVaultsRequest;

public class GetVaultsRequest : IInput
{
    [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("currency")]
    public string? currency { get; set; }

    [JsonProperty("vault_type", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("vault_type")]
    public string? type { get; set; }
}