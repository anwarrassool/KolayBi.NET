namespace KolayBi.Net.Constants;

internal static class HeaderKey
{
    internal const string Accept = nameof(Accept);
    internal const string ContentType = "Content-Type";
    internal const string UserAgent = "User-Agent";
}

internal static class HeaderValue
{
    internal const string ApplicationJson = "application/json";
    internal const string FormData = "application/x-www-form-urlencoded";
    internal const string UserAgent = "KolayBi.Net";
}