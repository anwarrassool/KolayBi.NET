using KolayBi.Net.Interfaces;
using Newtonsoft.Json;

namespace KolayBi.NET.Models.CreateEDocumentRequest;

public class CreateEDocumentRequest : IInput
{
    [JsonProperty("document_id", NullValueHandling = NullValueHandling.Ignore)]
    public int document_id { get; set; }
}

