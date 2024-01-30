using System.Text.Json.Serialization;
using KolayBi.Net.Interfaces;
using Newtonsoft.Json;

namespace KolayBi.Net.Models.GetTagsRequest;

public class GetTagsRequest : IInput
{
    [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("group")]
    public string? group { get; set; }
}