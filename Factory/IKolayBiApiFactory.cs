using KolayBi.Net.Client;

namespace KolayBi.Net.Factory;

public interface IKolayBiApiFactory
{

    IKolayBiApi client { get; set; }

    string access_token { get; set; }

    IKolayBiApi GetApiClient(ApiMode apiMode);
}