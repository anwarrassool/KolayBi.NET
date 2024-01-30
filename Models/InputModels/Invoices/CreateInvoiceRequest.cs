using KolayBi.Net.Extensions;
using KolayBi.Net.Interfaces;
using Newtonsoft.Json;

namespace KolayBi.NET.Models.CreateInvoiceRequest;


public class Item
{
    [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
    public int ProductId { get; set; } = 0;

    [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
    public string Quantity { get; set; } = string.Empty;

    [JsonProperty("unit_price", NullValueHandling = NullValueHandling.Ignore)]
    public string UnitPrice { get; set; } = string.Empty;

    [JsonProperty("vat_rate", NullValueHandling = NullValueHandling.Ignore)]
    public string VatRate { get; set; } = string.Empty;

    [JsonProperty("discount_amount", NullValueHandling = NullValueHandling.Ignore)]
    public double DiscountAmount { get; set; } = 0;

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; } = string.Empty;

    [JsonProperty("gtip_no", NullValueHandling = NullValueHandling.Ignore)]
    public long GtipNo { get; set; } = 0;
}

public class InternetSale
{
    [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
    public string Url { get; set; } = string.Empty;

    [JsonProperty("payment_type", NullValueHandling = NullValueHandling.Ignore)]
    public string PaymentType { get; set; } = string.Empty;

    [JsonProperty("payment_platform", NullValueHandling = NullValueHandling.Ignore)]
    public string PaymentPlatform { get; set; } = string.Empty;

    [JsonProperty("payment_date", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime PaymentDate { get; set; }
}

public class InternetSaleShipment
{
    [JsonProperty("carrier_company", NullValueHandling = NullValueHandling.Ignore)]
    public string CarrierCompany { get; set; } = string.Empty;

    [JsonProperty("carrier_person", NullValueHandling = NullValueHandling.Ignore)]
    public string CarrierPerson { get; set; } = string.Empty;

    [JsonProperty("carrier_company_tax_number", NullValueHandling = NullValueHandling.Ignore)]
    public string CarrierCompanyTaxNumber { get; set; } = string.Empty;

    [JsonProperty("carrier_date", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime CarrierDate { get; set; }
}

public class HandlingAndShippingInformation
{
    [JsonProperty("delivery_condition", NullValueHandling = NullValueHandling.Ignore)]
    public string DeliveryCondition { get; set; } = string.Empty;

    [JsonProperty("shipping_method", NullValueHandling = NullValueHandling.Ignore)]
    public int ShippingMethod { get; set; } = 0;

    [JsonProperty("shipping_method_detail", NullValueHandling = NullValueHandling.Ignore)]
    public string ShippingMethodDetail { get; set; } = string.Empty;

    [JsonProperty("freight", NullValueHandling = NullValueHandling.Ignore)]
    public double Freight { get; set; } = 0;

    [JsonProperty("insurance_amount", NullValueHandling = NullValueHandling.Ignore)]
    public double InsuranceAmount { get; set; } = 0;
}

public class SpecialTaxBase
{
    [JsonProperty("reason_code", NullValueHandling = NullValueHandling.Ignore)]
    public string ReasonCode { get; set; } = string.Empty;

    [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
    public string Total { get; set; } = string.Empty;

    [JsonProperty("percentage", NullValueHandling = NullValueHandling.Ignore)]
    public string Percentage { get; set; } = string.Empty;

    [JsonProperty("vat", NullValueHandling = NullValueHandling.Ignore)]
    public string Vat { get; set; } = string.Empty;
}

public class CreateInvoiceRequest : IInput
{
    [JsonProperty("contact_id", NullValueHandling = NullValueHandling.Ignore)]
    public int ContactId { get; set; }

    [JsonProperty("address_id", NullValueHandling = NullValueHandling.Ignore)]
    public int AddressId { get; set; }

    [JsonProperty("order_date", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime OrderDate { get; set; }

    [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
    public string? Currency { get; set; }

    [JsonProperty("receiver_email", NullValueHandling = NullValueHandling.Ignore)]
    public string? ReceiverEmail { get; set; }

    [JsonProperty("serial_no", NullValueHandling = NullValueHandling.Ignore)]
    public string? SerialNo { get; set; }

    [JsonProperty("due_date", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime DueDate { get; set; }

    [JsonProperty("tracking_currency", NullValueHandling = NullValueHandling.Ignore)]
    public string? TrackingCurrency { get; set; }

    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    //[JsonConverter(typeof(ItemConverter))] // Use the custom converter for the "items" property
    public Item []? Items { get; set; }

    [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
    public string []? Tags { get; set; } = null;

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; }

    [JsonProperty("subtotal_discount_amount", NullValueHandling = NullValueHandling.Ignore)]
    public double SubtotalDiscountAmount { get; set; }

    [JsonProperty("exchange_rate", NullValueHandling = NullValueHandling.Ignore)]
    public string? ExchangeRate { get; set; }

    [JsonProperty("cross_currency_rate", NullValueHandling = NullValueHandling.Ignore)]
    public string? CrossCurrencyRate { get; set; }

    [JsonProperty("document_scenario", NullValueHandling = NullValueHandling.Ignore)]
    public string? DocumentScenario { get; set; }

    [JsonProperty("document_type", NullValueHandling = NullValueHandling.Ignore)]
    public string? DocumentType { get; set; } = "SATIS";

    [JsonProperty("vat_exemption_reason_code", NullValueHandling = NullValueHandling.Ignore)]
    public string? VatExemptionReasonCode { get; set; }

    [JsonProperty("shipment_include", NullValueHandling = NullValueHandling.Ignore)]
    public bool ShipmentInclude { get; set; }

    [JsonProperty("special_tax_base", NullValueHandling = NullValueHandling.Ignore)]
    //[JsonConverter(typeof(SpecialTaxBaseConverter))] // Use the custom converter for the "internet_sale" property
    public SpecialTaxBase? SpecialTaxBase { get; set; }

    [JsonProperty("internet_sale", NullValueHandling = NullValueHandling.Ignore)]
    //[JsonConverter(typeof(InternetSaleConverter))] // Use the custom converter for the "internet_sale" property
    public InternetSale? InternetSale { get; set; }

    [JsonProperty("internet_sale_shipment", NullValueHandling = NullValueHandling.Ignore)]
    //[JsonConverter(typeof(InternetSaleShipmentConverter))] // Use the custom converter for the "internet_sale" property
    public InternetSaleShipment? InternetSaleShipment { get; set; }

    [JsonProperty("handling_and_shipping_information", NullValueHandling = NullValueHandling.Ignore)]
    public HandlingAndShippingInformation HandlingAndShippingInformation { get; set; }   
}
