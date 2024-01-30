using System.Text.Json.Serialization;
using KolayBi.Net.Interfaces;
using Newtonsoft.Json;

namespace KolayBi.Net.Models.CreateAdressRequest;

//public class Address
//{
//    [JsonProperty("associate_id")]
//    public int? AssociateId { get; set; } // Added field

//    [JsonProperty("is_abroad")]
//    public bool? IsAbroad { get; set; }

//    [JsonProperty("address_type")]
//    public string? AddressType { get; set; } = "invoice"; // Default value

//    [JsonProperty("address")]
//    public string? AddressInfo { get; set; }

//    [JsonProperty("country")]
//    public string? Country { get; set; }

//    [JsonProperty("city")]
//    public string? City { get; set; }

//    [JsonProperty("district")]
//    public string? District { get; set; }

//    [JsonProperty("street")]
//    public string? Street { get; set; }

//    [JsonProperty("building_name")]
//    public string? BuildingName { get; set; }

//    [JsonProperty("number")]
//    public int? Number { get; set; }

//    [JsonProperty("postal_code")]
//    public string? PostalCode { get; set; }

//    [JsonProperty("address_location")]
//    public string? AddressLocation { get; set; } = "other"; // Default value
//}

public class CreateAdressRequest : IInput
{
    [JsonProperty("associate_id", NullValueHandling = NullValueHandling.Ignore)]
    public int? AssociateId { get; set; } // Added field

    [JsonProperty("is_abroad", NullValueHandling = NullValueHandling.Ignore)]
    public int? IsAbroad { get; set; }

    [JsonProperty("address_type", NullValueHandling = NullValueHandling.Ignore)]
    public string? AddressType { get; set; } = "invoice"; // Default value

    [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
    public string? AddressInfo { get; set; }

    [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
    public string? Country { get; set; }

    [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
    public string? City { get; set; }

    [JsonProperty("district", NullValueHandling = NullValueHandling.Ignore)]
    public string? District { get; set; }

    [JsonProperty("street", NullValueHandling = NullValueHandling.Ignore)]
    public string? Street { get; set; }

    [JsonProperty("building_name", NullValueHandling = NullValueHandling.Ignore)]
    public string? BuildingName { get; set; }

    [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
    public string? Number { get; set; }

    [JsonProperty("postal_code", NullValueHandling = NullValueHandling.Ignore)]
    public string? PostalCode { get; set; }

    [JsonProperty("address_location", NullValueHandling = NullValueHandling.Ignore)]
    public string? AddressLocation { get; set; } = "other"; // Default value
}