using System.Text.Json.Serialization;
using KolayBi.Net.Interfaces;
using Newtonsoft.Json;

namespace KolayBi.Net.Models.ProceedInvoiceResponse;

public class Datum
{
    [JsonProperty("transaction_status", NullValueHandling = NullValueHandling.Ignore)]
    public string TransactionStatus { get; set; }

    [JsonProperty("transaction_type", NullValueHandling = NullValueHandling.Ignore)]
    public string TransactionType { get; set; }

    [JsonProperty("payment_method", NullValueHandling = NullValueHandling.Ignore)]
    public string PaymentMethod { get; set; }

    [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
    public string IssueDate { get; set; }

    [JsonProperty("remaining_amount", NullValueHandling = NullValueHandling.Ignore)]
    public double RemainingAmount { get; set; }

    [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
    public string Currency { get; set; }
}

public class ProceedInvoiceResponse : BaseResponse
{
    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    public Datum Data { get; set; }
}


