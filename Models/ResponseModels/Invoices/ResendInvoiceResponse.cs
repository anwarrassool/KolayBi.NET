using System.Text.Json.Serialization;
using KolayBi.Net.Interfaces;
using Newtonsoft.Json;

namespace KolayBi.Net.Models.ResendInvoiceResponse;

public class Data
{
    [JsonProperty("document_id", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("document_id")]
    public int? DocumentId;
}

public class ResendInvoiceResponse : BaseResponse
{
    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("data")]
    public Data Data;
}






