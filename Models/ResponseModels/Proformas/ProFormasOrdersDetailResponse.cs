using System.Text.Json.Serialization;
using KolayBi.Net.Interfaces;
using Newtonsoft.Json;

namespace KolayBi.Net.Models.ProFormasOrdersDetailResponse;

public class Datum
{
    [JsonProperty("document_id", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("document_id")]
    public int? DocumentId;

    [JsonProperty("exchange_grand_total", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("exchange_grand_total")]
    public int? ExchangeGrandTotal;

    [JsonProperty("exchange_grand_currency", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("exchange_grand_currency")]
    public string? ExchangeGrandCurrency;

    [JsonProperty("grand_total", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("grand_total")]
    public int? GrandTotal;

    [JsonProperty("grand_currency", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("grand_currency")]
    public string? GrandCurrency;
}

public class ProFormasOrdersDetailResponse : BaseResponse
{
    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("data")]
    public List<Datum> Data;
}

