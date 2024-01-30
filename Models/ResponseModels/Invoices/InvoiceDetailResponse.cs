using System.Text.Json.Serialization;
using KolayBi.Net.Interfaces;
using Newtonsoft.Json;

namespace KolayBi.Net.Models.InvoiceDetailResponse;

public class Data
{
    [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("uuid")]
    public string? Uuid;
}

public class InvoiceDetailResponse : BaseResponse
{
    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("data")]
    public Data Data;
}





