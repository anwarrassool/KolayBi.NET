using System.Text.Json.Serialization;
using KolayBi.Net.Interfaces;
using Newtonsoft.Json;

namespace KolayBi.Net.Models.CreateOrdersResponse;

public class Datum
{
    [JsonProperty("document_id", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("document_id")]
    public int? DocumentId;

    [JsonProperty("order_number", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("order_number")]
    public string? OrderNumber;

    [JsonProperty("associate_id", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("associate_id")]
    public int? AssociateId;

    [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("currency")]
    public string? Currency;

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("description")]
    public string? Description;

    [JsonProperty("grand_total", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("grand_total")]
    public double? GrandTotal;

    [JsonProperty("gross_total", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("gross_total")]
    public int? GrossTotal;

    [JsonProperty("total_vat", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("total_vat")]
    public double? TotalVat;

    [JsonProperty("subtotal", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("subtotal")]
    public int? Subtotal;

    [JsonProperty("lines", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("lines")]
    public List<Line> Lines;

    [JsonProperty("invoice_document_ids", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("invoice_document_ids")]
    public string? InvoiceDocumentIds;

    [JsonProperty("proforma_document_ids", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("proforma_document_ids")]
    public string? ProformaDocumentIds;
}

public class Line
{
    [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("product_id")]
    public int? ProductId;

    [JsonProperty("product_name", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("product_name")]
    public string? ProductName;

    [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("unit")]
    public string? Unit;

    [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("quantity")]
    public int? Quantity;

    [JsonProperty("unit_price", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("unit_price")]
    public int? UnitPrice;

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("description")]
    public string? Description;

    [JsonProperty("grand_total", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("grand_total")]
    public double? GrandTotal;

    [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("total")]
    public double? Total;

    [JsonProperty("vat_amount", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("vat_amount")]
    public double? VatAmount;

    [JsonProperty("vat_value", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("vat_value")]
    public string? VatValue;

    [JsonProperty("vat_type", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("vat_type")]
    public string? VatType;

    [JsonProperty("subtotal", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("subtotal")]
    public int? Subtotal;

    [JsonProperty("discount_amount", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("discount_amount")]
    public int? DiscountAmount;

    [JsonProperty("discount_value", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("discount_value")]
    public int? DiscountValue;

    [JsonProperty("discount_type", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("discount_type")]
    public string? DiscountType;

    [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("amount")]
    public int? Amount;
}

public class CreateOrdersResponse : BaseResponse
{
    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("data")]
    public List<Datum> Data;
}





