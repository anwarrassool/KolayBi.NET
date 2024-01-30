using System.Text.Json.Serialization;
using KolayBi.Net.Interfaces;
using Newtonsoft.Json;

namespace KolayBi.Net.Models;

public class TokenResponse : BaseResponse
{
    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("data")]
    public string access_token;
}

public class KBAuthResponse
{
    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("data")]
    public List<TokenResponse> Data;
}
