using System;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using KolayBi.Net.Interfaces;

namespace KolayBi.NET.Models.CreateEDocumentResponse;

public class CreateEDocumentResponseData
{
    [JsonProperty("document_id", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("document_id")]
    public int? DocumentId;

    [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("uuid")]
    public string Uuid;

    [JsonProperty("no", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("no")]
    public string No;

    [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("status")]
    public string Status;

    [JsonProperty("scenario", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("scenario")]
    public string Scenario;

    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("type")]
    public string Type;

    [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("direction")]
    public string Direction;

    [JsonProperty("exchange_grand_total", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("exchange_grand_total")]
    public int? ExchangeGrandTotal;

    [JsonProperty("exchange_grand_currency", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("exchange_grand_currency")]
    public string ExchangeGrandCurrency;

    [JsonProperty("grand_total", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("grand_total")]
    public int? GrandTotal;

    [JsonProperty("grand_currency", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("grand_currency")]
    public string GrandCurrency;
}

public class CreateEDocumentResponse : BaseResponse
{
    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("data")]
    public CreateEDocumentResponseData Data;
}

