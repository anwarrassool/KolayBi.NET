using System.Text.Json.Serialization;
using KolayBi.Net.Interfaces;
using Newtonsoft.Json;

namespace KolayBi.Net.Models.UpdateProductRequest;

public class UpdateProductRequest : IInput
{
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
    public string Code { get; set; }

    [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
    public double Quantity { get; set; } = 0; // Default value is 0

    [JsonProperty("vat_rate", NullValueHandling = NullValueHandling.Ignore)]
    public int VatRate { get; set; } = 18; // Default value is 18

    [JsonProperty("barcode", NullValueHandling = NullValueHandling.Ignore)]
    public string Barcode { get; set; }

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    [JsonProperty("discount_type", NullValueHandling = NullValueHandling.Ignore)]
    public string DiscountType { get; set; } = "percentage"; // Default value is "percentage"

    [JsonProperty("discount_value", NullValueHandling = NullValueHandling.Ignore)]
    public double DiscountValue { get; set; }

    [JsonProperty("product_type", NullValueHandling = NullValueHandling.Ignore)]
    public string ProductType { get; set; } = "good"; // Default value is "good"

    [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Tags { get; set; }

    [JsonProperty("price_currency", NullValueHandling = NullValueHandling.Ignore)]
    public string PriceCurrency { get; set; }

    [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
    public double Price { get; set; }
}