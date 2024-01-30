using System.Text.Json.Serialization;
using KolayBi.Net.Interfaces;
using Newtonsoft.Json;

namespace KolayBi.Net.Models.ViewInvoiceResponse;

public class Datum
{
    [JsonProperty("src", NullValueHandling = NullValueHandling.Ignore)]
    public string Src { get; set; }

    [JsonProperty("output_type", NullValueHandling = NullValueHandling.Ignore)]
    public string OutputType { get; set; }
}

public class ViewInvoiceResponse : BaseResponse
{
    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    public Datum Data { get; set; }
}




