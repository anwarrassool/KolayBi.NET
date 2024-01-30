# .Net Wrapper for KolayBi

Unofficial Kolaybi .Net client library

Developed with .Net 7.0

KolayBi docs at https://developer.kolaybi.com/#overview

# Requirements

* .NET 7.0

# Installation

# KolayBi Usage

# Program.cs

```csharp 1

ServicesExtensions.AddKolayBiInvoicing(builder);
...

```

# ServicesExtensions.cs

```csharp 1
	    
public static class ServicesExtensions
{
    public static void AddKolayBiInvoicing(WebApplicationBuilder builder)
    {
        var kbSettings = AppConfiguration.GetConfiguration<KolayBiSetting>(builder, AppConfigSection.KolayBiSetting);

        builder.Services.AddKolayBiIntegration(opt =>
        {
            opt.Mode = kbSettings.mode;
            opt.Live = new KolayBi.Net.Utils.Abstract.Live
            {
                ApiKey = kbSettings.live.apiKey,
                BaseUrl = kbSettings.live.baseUrl,
                Channel = kbSettings.live.channel
            };
            opt.SandBox = new KolayBi.Net.Utils.Abstract.SandBox
            {
                ApiKey = kbSettings.sandBox.apiKey,
                BaseUrl = kbSettings.sandBox.baseUrl,
                Channel = kbSettings.sandBox.channel
            };
        });

    }
}
...

```

# AppConfiguration.cs

```csharp 1

public enum AppConfigSection
{
	KolayBiSetting
}
...

```

```csharp 1

public static class AppConfiguration
{
    public static T GetConfiguration<T>(IConfiguration configuration, AppConfigSection section)
    {
        var configSection = configuration.GetSection(section.ToString());
        if (configSection == null)
        {
            throw new ArgumentNullException(nameof(section), $"Configuration section {section} not found.");
        }
        return configSection.Get<T>();
    }


    public static T GetConfiguration<T>(WebApplicationBuilder builder, AppConfigSection section)
    {
        var configSection = builder.Configuration.GetSection(section.ToString());
        if (configSection == null)
        {
            throw new ArgumentNullException(nameof(section), $"Configuration section {section} not found.");
        }
        return configSection.Get<T>();
    }
}
...

```

# Settings.cs

```csharp 1

    public class KolayBiSetting
    {
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("mode")]
        public string? mode { get; set; }

        [JsonProperty("sandBox", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("sandBox")]
        public SandBox sandBox { get; set; }

        [JsonProperty("live", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("live")]
        public Live live { get; set; }
    }

    public class Live
    {
        [JsonProperty("apiKey", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("apiKey")]
        public string? apiKey { get; set; }

        [JsonProperty("channel", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("channel")]
        public string? channel { get; set; }

        [JsonProperty("baseUrl", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("baseUrl")]
        public string? baseUrl { get; set; }
    }

    public class SandBox
    {
        [JsonProperty("apiKey", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("apiKey")]
        public string? apiKey { get; set; }

        [JsonProperty("channel", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("channel")]
        public string? channel { get; set; }

        [JsonProperty("baseUrl", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("baseUrl")]
        public string? baseUrl { get; set; }
    }

```

Sample use Injection

```csharp 1
        
using KolayBi.Net.Client;
using KolayBi.Net.Extensions;
using KolayBi.Net.Factory;
using KolayBi.Net.Models;

namespace Api.Controllers
{
	private IKolayBiApi _KolayBiApi;
	private readonly IKolayBiApiFactory _factory;
	public KolayBiSetting _KolayBiSettings { get; }

	public Controller(IOptions<KolayBiSetting> KolayBiAISettings,IKolayBiApiFactory factory)
	{
	    _KolayBiSettings = KolayBiAISettings.Value;
	    _factory = factory;
	
	    if (_factory.client == null)
		_KolayBiApi = _factory.GetApiClient(((ApiMode)Enum.Parse(typeof(ApiMode), _KolayBiSettings.mode.ToString())));
	    else
		_KolayBiApi = _factory.client;
	}
}
...

```

Sample use

```csharp 1

public async Task<TokenResponse> GetToken()
{
    try
    {
        var response = await _KolayBiApi.GetAccessToken();
        return response;
    }
    catch (Exception ex)
    {
        logger.LogError(UtilException.GetAllExceptionDetails(ex));

	if (ex is RestEase.ApiException)
	{
	    return default;
	}
	return default;

    }
}

...

```

```csharp 1

using KolayBi.Net.Models.CreateProductResponse;

public async Task<CreateProductResponse> CreateProduct(Product item)
{
    try
    {
	    var tokenResult = await this.GetToken();

	    if (tokenResult.IsSuccess)
	    {
		_factory.access_token = tokenResult.Data.access_token;

		var createProductRequest = new KolayBi.Net.Models.CreateProductRequest.CreateProductRequest()
		{
		    Barcode = item.Barcode,
		    VatRate = item.VatRate,
		    Description = item.Description,
		    Name = item.Name,
		    Price = Convert.ToDouble(item.Amount),
		    Quantity = 1,
		    ProductType = "service",
		    PriceCurrency = item.CurrencyCode,
		    Code = item.PayPalPlanId,
		    DiscountType = "numeric",
		    DiscountValue = 0,
		    Tags = new List<string?>(),

		};

		var paramters = JsonConvert.DeserializeObject<Dictionary<string, object>>(JsonConvert.SerializeObject(createProductRequest));

		var response = await _KolayBiApi.CreateProduct(paramters);

		if (response.Data != null)
		{
		    switch ((ApiMode)Enum.Parse(typeof(ApiMode), _KolayBiSettings.mode.ToString()))
		    {
			case ApiMode.SandBox:
			    item.SandBoxKolayBiProductId = response.Data.Id.ToString();
			    break;
			case ApiMode.Live:
			    item.KolayBiProductId = response.Data.Id.ToString();
			    break;
			default:
			    break;
		    }
		}
		return response;
	    }
	    else
	    {
		return default;
	    }
    }
    catch (Exception ex)
    {
	logger.LogError(UtilException.GetAllExceptionDetails(ex));

	if (ex is RestEase.ApiException)
	{
	    return default;
	}
	return default;
    }
}
...

```

```csharp 1

using olayBi.NET.Models.CreateInvoiceResponse;

public async Task<CreateInvoiceResponse> CreateInvoice(SomeParameters item)
{
    try
    {
	    var tokenResult = await this.GetToken();

	    int KolayBiCustomerCode = 0;
	    int KolayBiAdressCode = 0;
	    int KolayBiProductId = 0;

	    if (tokenResult.IsSuccess)
	    {
		_factory.access_token = tokenResult.Data.access_token;

		switch ((ApiMode)Enum.Parse(typeof(ApiMode), _KolayBiSettings.mode.ToString()))
		{
		    case ApiMode.SandBox:
			KolayBiCustomerCode = Convert.ToInt32(string.IsNullOrEmpty(item.SandboxKolayBiCustomerCode) ? "0" : item.SandboxKolayBiCustomerCode);
			KolayBiAdressCode = Convert.ToInt32(string.IsNullOrEmpty(item.SandboxKolayBiAdressCode) ? "0" : item.SandboxKolayBiAdressCode);
			KolayBiProductId = Convert.ToInt32(string.IsNullOrEmpty(item.SandBoxKolayBiProductId) ? "0" : item.SandBoxKolayBiProductId);

			break;
		    case ApiMode.Live:
			KolayBiCustomerCode = Convert.ToInt32(string.IsNullOrEmpty(item.KolayBiCustomerCode) ? "0" : item.KolayBiCustomerCode);
			KolayBiAdressCode = Convert.ToInt32(string.IsNullOrEmpty(item.KolayBiAdressCode) ? "0" : item.KolayBiAdressCode);
			KolayBiProductId = Convert.ToInt32(string.IsNullOrEmpty(item.KolayBiProductId) ? "0" : item.KolayBiProductId);

			break;
		    default:
			break;
		}
		

		var createInvoiceRequest = new CreateInvoiceRequest()
		{
		    ContactId = KolayBiCustomerCode,
		    AddressId = KolayBiAdressCode,
		    Currency = item.CurrencyCode,
		    DueDate = item.PaymentDate,
		    ReceiverEmail = item.Email,
		    SerialNo = item.OrderId,
		    TrackingCurrency = item.CurrencyCode,
		    Items = new Item[]
		     {
			new Item
			{
			    ProductId = KolayBiProductId,
			    Quantity = 1.ToString(),
			    UnitPrice =  Math.Round(item.Price, 2, MidpointRounding.ToNegativeInfinity).ToString(),
			    Description = item.Description,
			    DiscountAmount = 0,
			    VatRate = item.VatRate.ToString()
			}
		     },
		    InternetSale = new InternetSale()
		    {
			PaymentDate = item.PaymentDate,
			PaymentPlatform = item.PaymentProvider,
			PaymentType = "credit-card",
			Url = siteUrl
		    },
		    OrderDate = item.PaymentDate,
		    Description = item.Description,
		    DocumentType = "SATIS",
		};

		var paramters = JsonConvert.DeserializeObject<Dictionary<string, object>>(JsonConvert.SerializeObject(createInvoiceRequest)).FormDictionary();
		var response = await _KolayBiApi.CreateInvoice(paramters);

		if (response.Data != null)
		{
		    return response;
		}
		else
		{
		    return default
		}
	    }
	    else
	    {
	       return default
	    }
    }
    catch (Exception ex)
    {
	logger.LogError(UtilException.GetAllExceptionDetails(ex));

	if (ex is RestEase.ApiException)
	{
		 return default

	}
	return default
    }
}

...

```

# settings.json

```csharp 1

Sample settings.json

  "KolayBiSetting": {
    "mode": "Live",
    "sandBox": {
      "apiKey": "xxxxxx",
      "channel": "xxxxxx",
      "baseUrl": "https://ofis-sandbox-api.kolaybi.com/kolaybi/v1"
    },
    "live": {
      "apiKey": "xxxxxxxxxxxxxxxxx",
      "channel": "xxxxxxx",
      "baseUrl": "https://ofis-api.kolaybi.com/kolaybi/v1"
    }
  }

...

```
