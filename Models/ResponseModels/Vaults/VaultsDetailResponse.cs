using System.Text.Json.Serialization;
using KolayBi.Net.Interfaces;
using Newtonsoft.Json;

namespace KolayBi.Net.Models.VaultsDetailResponse;

public class Datum
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("id")]
    public int? Id;

    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("type")]
    public string Type;

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("name")]
    public string Name;

    [JsonProperty("balance", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("balance")]
    public decimal? Balance;

    [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("currency")]
    public string Currency;
}

public class VaultsDetailResponse : BaseResponse
{
    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("data")]
    public List<Datum> Data;
}

