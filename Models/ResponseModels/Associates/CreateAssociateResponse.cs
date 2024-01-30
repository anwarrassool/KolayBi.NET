using System.Text.Json.Serialization;
using KolayBi.Net.Interfaces;
using Newtonsoft.Json;

namespace KolayBi.Net.Models.CreateAssociateResponse;

public class Adress
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
    public object Number;

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

public class AssociateData
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("id")]
    public int? Id;

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("name")]
    public string? Name;

    [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("code")]
    public string? Code;

    [JsonProperty("surname", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("surname")]
    public string? Surname;

    [JsonProperty("identity_no", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("identity_no")]
    public string? IdentityNo;

    [JsonProperty("tax_office", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("tax_office")]
    public string? TaxOffice;

    [JsonProperty("associate_type", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("associate_type")]
    public string? AssociateType;

    [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("phone")]
    public string? Phone;

    [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("email")]
    public string? Email;

    [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("country")]
    public string? Country;

    [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("tags")]
    public List<AssociateTags> Tags;

    [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("address")]
    public List<Adress> Address;
}

public class CreateAssociateResponse : BaseResponse
{
    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("data")]
    public AssociateData Data;
}

public class AssociateTags
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("id")]
    public int? Id;

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("name")]
    public string? Name;

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    [JsonPropertyName("description")]
    public string? Description;
}


