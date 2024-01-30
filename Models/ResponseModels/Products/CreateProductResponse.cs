using System.Text.Json.Serialization;
using KolayBi.Net.Interfaces;
using Newtonsoft.Json;

namespace KolayBi.Net.Models.CreateProductResponse;

public class ProductData
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("id")]
    public int? Id;

    [JsonProperty("product_type", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("product_type")]
    public string? ProductType;

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("name")]
    public string? Name;

    [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("code")]
    public string? Code;

    [JsonProperty("vat_type", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("vat_type")]
    public string? VatType;

    [JsonProperty("vat_value", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("vat_value")]
    public int? VatValue;

    [JsonProperty("barcode", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("barcode")]
    public string? Barcode;

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("description")]
    public string? Description;

    [JsonProperty("discount_type", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("discount_type")]
    public string? DiscountType;

    [JsonProperty("discount_value", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("discount_value")]
    public object DiscountValue;

    [JsonProperty("sale_price", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("sale_price")]
    public decimal? SalePrice;

    [JsonProperty("sale_unit", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("sale_unit")]
    public string? SaleUnit;

    [JsonProperty("sale_currency", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("sale_currency")]
    public string? SaleCurrency;

    [JsonProperty("total_stock_quantity", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("total_stock_quantity")]
    public string? TotalStockQuantity;

    [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("tags")]
    public List<ProductTags> Tags;
}

public class CreateProductResponse : BaseResponse
{
    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("data")]
    public ProductData Data;
}

public class ProductTags
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("id")]
    public int? Id;

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("name")]
    public string? Name;

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("description")]
    public string? Description;
}



