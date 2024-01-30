using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace KolayBi.Net.Interfaces;

/// <summary>
/// The model's input.
/// </summary>
public class BaseResponse
{
    [JsonProperty("data")]
    [JsonPropertyName("data")]
    public string Data;

    [JsonProperty("message")]
    [JsonPropertyName("message")]
    public object Message;

    [JsonProperty("success")]
    [JsonPropertyName("success")]
    public string Success;
}