using System.Text.Json.Serialization;
using KolayBi.Net.Interfaces;
using Newtonsoft.Json;

namespace KolayBi.Net.Models.CreateProFormaOrdersRequest;


public class ProformaOrderItem
{
    [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
    public int ProductId { get; set; }

    [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
    public string? Quantity { get; set; }

    [JsonProperty("unit_price", NullValueHandling = NullValueHandling.Ignore)]
    public string? UnitPrice { get; set; }

    [JsonProperty("vat_rate", NullValueHandling = NullValueHandling.Ignore)]
    public string? VatRate { get; set; }

    [JsonProperty("discount_amount", NullValueHandling = NullValueHandling.Ignore)]
    public double DiscountAmount { get; set; }

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; }
}

public class CreateProFormasOrdersRequest : IInput
{
    [JsonProperty("contact_id", NullValueHandling = NullValueHandling.Ignore)]
    public int ContactId { get; set; }

    [JsonProperty("address_id", NullValueHandling = NullValueHandling.Ignore)]
    public int AddressId { get; set; }

    [JsonProperty("order_date", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime OrderDate { get; set; }

    [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
    public string? Currency { get; set; }

    [JsonProperty("serial_no", NullValueHandling = NullValueHandling.Ignore)]
    public string? SerialNo { get; set; }

    [JsonProperty("due_date", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime DueDate { get; set; }

    [JsonProperty("tracking_currency", NullValueHandling = NullValueHandling.Ignore)]
    public string? TrackingCurrency { get; set; }

    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public List<ProformaOrderItem> Items { get; set; }

    [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
    public List<string?> Tags { get; set; }

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; }

    [JsonProperty("subtotal_discount_amount", NullValueHandling = NullValueHandling.Ignore)]
    public double SubtotalDiscountAmount { get; set; }

    [JsonProperty("exchange_rate", NullValueHandling = NullValueHandling.Ignore)]
    public string? ExchangeRate { get; set; }
}