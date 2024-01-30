using System.Text.Json.Serialization;
using KolayBi.Net.Interfaces;
using Newtonsoft.Json;

namespace KolayBi.Net.Models.CreateAdressResponse;

public class AddressData
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("id")]
    public int? Id;

    [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("address")]
    public string? Address;

    [JsonProperty("coutry_name", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("coutry_name")]
    public string? CoutryName;

    [JsonProperty("postal_code", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("postal_code")]
    public string? PostalCode;

    [JsonProperty("is_abroad", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("is_abroad")]
    public bool? IsAbroad;

    [JsonProperty("building_name", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("building_name")]
    public string? BuildingName;

    [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("number")]
    public int? Number;

    [JsonProperty("street", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("street")]
    public string? Street;

    [JsonProperty("address_type", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("address_type")]
    public string? AddressType;

    [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("city")]
    public string? City;

    [JsonProperty("district", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("district")]
    public string? District;
}

public class CreateAdressResponse : BaseResponse
{
    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("data")]
    public AddressData Data;
}




