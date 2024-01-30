using System.Text.Json.Serialization;
using KolayBi.Net.Interfaces;
using Newtonsoft.Json;

namespace KolayBi.Net.Models.TagsDetailResponse;

public class Datum
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("id")]
    public int? Id;

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("name")]
    public string Name;

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("description")]
    public string Description;
}

public class TagsDetailResponse : BaseResponse
{
    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("data")]
    public List<Datum> Data;
}

