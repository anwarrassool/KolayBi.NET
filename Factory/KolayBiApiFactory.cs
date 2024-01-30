using System.Reflection;
using KolayBi.Net.Client;
using KolayBi.Net.Utils.Abstract;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestEase;
using Stef.Validation;

namespace KolayBi.Net.Factory;

public enum ApiMode
{
    Live,
    SandBox
}

public class KolayBiApiFactory : IKolayBiApiFactory
{
    public IOptions Options { get; private set; }
    public string access_token { get; set; }
    public IKolayBiApi client { get; set; }


    public KolayBiApiFactory(IOptions options)
    {
        Options = options;
        access_token = string.Empty;
        client = GetApiClient(((ApiMode)Enum.Parse(typeof(ApiMode), options.Mode.ToString())));
    }

    public IKolayBiApi GetApiClient(ApiMode apiMode)
    {
        switch (apiMode)
        {
            case ApiMode.SandBox:
                return GetApi(new Uri(Options.SandBox.BaseUrl), Options.SandBox.ApiKey, Options.SandBox.Channel);
            case ApiMode.Live:
                return GetApi(new Uri(Options.Live.BaseUrl), Options.Live.ApiKey, Options.Live.Channel);
            default:
                return GetApi(new Uri(Options.SandBox.BaseUrl), Options.SandBox.ApiKey, Options.SandBox.Channel);
        }
    }

    private IKolayBiApi GetApi(Uri baseUrl, string? apiKey = null, string? channel = null)
    {
        Guard.NotNull(baseUrl);

        var client = new RestClient
        (
            baseUrl,
            (request, _) =>
            {
                request.InterceptRequest(apiKey, channel, access_token);
                return Task.CompletedTask;
            }
        )
        {
            JsonSerializerSettings = new()
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new SnakeCaseNamingStrategy()
                },
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
            }
        }
        .For<IKolayBiApi>();

        return client;
    }
}

public static class IHttpRequestMessageExtensions
{
    private static string TOKENREQUEST = "access_token";

    public static HttpRequestMessage InterceptRequest(this HttpRequestMessage request, string? apiKey = null, string? channel = null, string? access_token = null)
    {
        Guard.NotNull(request);

        if (!string.IsNullOrEmpty(apiKey) && request.RequestUri.Segments.Last() == TOKENREQUEST)
        {
            var uriBuilder = new UriBuilder(request.RequestUri);
            var query = System.Web.HttpUtility.ParseQueryString(uriBuilder.Query);
            query["api_key"] = apiKey;
            uriBuilder.Query = query.ToString();
            request.RequestUri = uriBuilder.Uri;
        }

        if (!string.IsNullOrEmpty(channel))
        {
            request.Headers.Add("Channel", channel);
        }

        if (HasRequiresTokenAttribute(request))
        {
            request.AddAuthorization(access_token);
        }
        return request;
    }

    private static bool HasRequiresTokenAttribute(this HttpRequestMessage request)
    {
        var methodInfo = request.Properties.FirstOrDefault().Value as IRequestInfo;
        if (methodInfo != null)
        {
            var requiresTokenAttribute = methodInfo.MethodInfo.GetCustomAttribute<RequiresTokenAttribute>();
            return requiresTokenAttribute != null;
        }

        return false;
    }

    private static HttpRequestMessage AddAuthorization(this HttpRequestMessage request, string? access_token = null)
    {
        if (!string.IsNullOrEmpty(access_token))
        {
            request.Headers.Add("Authorization", $"Bearer {access_token}");
        }
        else
        {
            // Handle the case where the attribute requires a token, but access_token is missing.
            // You may throw an exception or handle it based on your requirements.
        }

        return request;

    }
}