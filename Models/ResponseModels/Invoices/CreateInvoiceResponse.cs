using System;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using KolayBi.Net.Interfaces;

namespace KolayBi.NET.Models.CreateInvoiceResponse;


public class CreateInvoiceResponseData
{
    [JsonProperty("document_id", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("document_id")]
    public int? DocumentId;

    [JsonProperty("exchange_grand_total", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("exchange_grand_total")]
    public decimal? ExchangeGrandTotal;

    [JsonProperty("exchange_grand_currency", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("exchange_grand_currency")]
    public string ExchangeGrandCurrency;

    [JsonProperty("grand_total", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("grand_total")]
    public decimal? GrandTotal;

    [JsonProperty("grand_currency", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("grand_currency")]
    public string GrandCurrency;
}

public class CreateInvoiceResponse : BaseResponse
{
    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("data")]
    public CreateInvoiceResponseData Data;
}



