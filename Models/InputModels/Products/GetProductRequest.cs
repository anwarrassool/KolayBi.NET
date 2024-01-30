using System.Text.Json.Serialization;
using KolayBi.Net.Interfaces;
using Newtonsoft.Json;

namespace KolayBi.Net.Models.GetProductRequest;

public class GetProductRequest : IInput
{
    [JsonProperty("barcode", NullValueHandling = NullValueHandling.Ignore)]
    public string? Barcode { get; set; }

    [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
    public string? Code { get; set; }

    [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
    public string? Group { get; set; }

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; }

    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; }

}