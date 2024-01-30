using System.Text.Json.Serialization;
using KolayBi.Net.Interfaces;
using Newtonsoft.Json;

namespace KolayBi.Net.Models.GetAssociateRequest;

public class GetAssociateRequest : IInput
{
    [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("code")]
    public string? code { get; set; }

    [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("group")]
    public string? group { get; set; }

    [JsonProperty("identity_no", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("identity_no")]
    public string? identity_no { get; set; }

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("name")]
    public string? name { get; set; }

    [JsonProperty("surname", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("surname")]
    public string? surname { get; set; }

    [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("email")]
    public string? email { get; set; }

}