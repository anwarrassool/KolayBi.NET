using KolayBi.Net.Interfaces;
using Newtonsoft.Json;

namespace KolayBi.NET.Models.CancelEDocumentRequest;

public class CancelEDocumentRequest : IInput
{
    [JsonProperty("document_id", NullValueHandling = NullValueHandling.Ignore)]
    public int document_id { get; set; }
}

