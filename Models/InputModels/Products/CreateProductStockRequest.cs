using System.Text.Json.Serialization;
using KolayBi.Net.Interfaces;
using Newtonsoft.Json;

namespace KolayBi.Net.Models.CreateProductStockRequest;

public class CreateProductStockRequest : IInput
{
    [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("product_id")]
    public int? ProductId;

    [JsonProperty("stock_flow_direction", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("stock_flow_direction")]
    public int? StockFlowDirection;

    [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("quantity")]
    public int? Quantity;

    [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("currency")]
    public string Currency;

    [JsonProperty("stock_code", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("stock_code")]
    public string StockCode;

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("description")]
    public string Description;

    [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("issue_date")]
    public DateTime? IssueDate;

    [JsonProperty("unit_amount", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("unit_amount")]
    public int? UnitAmount;
}