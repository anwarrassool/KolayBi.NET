using System.Text.Json.Serialization;
using KolayBi.Net.Interfaces;
using Newtonsoft.Json;

namespace KolayBi.Net.Models.CreateAssociateRequest;

public class Adress
{
    [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
    public string? Address { get; set; }

    [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
    public string? City { get; set; }

    [JsonProperty("district", NullValueHandling = NullValueHandling.Ignore)]
    public string? District { get; set; }

    [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
    public string? Country { get; set; }

    [JsonProperty("address_type", NullValueHandling = NullValueHandling.Ignore)]
    public string? AddressType { get; set; } = "invoice"; // Default value

    [JsonProperty("is_abroad", NullValueHandling = NullValueHandling.Ignore)]
    public int? IsAbroad { get; set; } = 0; // Default value

    [JsonProperty("building_name", NullValueHandling = NullValueHandling.Ignore)]
    public string? BuildingName { get; set; }

    [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
    public string? Number { get; set; }

    [JsonProperty("postal_code", NullValueHandling = NullValueHandling.Ignore)]
    public string? PostalCode { get; set; }

    [JsonProperty("street", NullValueHandling = NullValueHandling.Ignore)]
    public string? Street { get; set; }
}

public class CreateAssociateRequest : IInput
{
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; }

    [JsonProperty("surname", NullValueHandling = NullValueHandling.Ignore)]
    public string? Surname { get; set; }

    [JsonProperty("associate_type", NullValueHandling = NullValueHandling.Ignore)]
    public string? AssociateType { get; set; } = "customer"; // Default value

    [JsonProperty("identity_no", NullValueHandling = NullValueHandling.Ignore)]
    public string? IdentityNo { get; set; }

    [JsonProperty("tax_office", NullValueHandling = NullValueHandling.Ignore)]
    public string? TaxOffice { get; set; }

    [JsonProperty("website", NullValueHandling = NullValueHandling.Ignore)]
    public string? Website { get; set; }

    [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Tags { get; set; }

    [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
    public string? Code { get; set; }

    [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
    public string? Phone { get; set; }

    [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
    public string? Email { get; set; }

    [JsonProperty("addresses", NullValueHandling = NullValueHandling.Ignore)]
    public Adress? Addresses { get; set; }
}