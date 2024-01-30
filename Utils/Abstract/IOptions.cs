using System.Text.Json.Serialization;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace KolayBi.Net.Utils.Abstract
{
    public class IOptions
    {
        public string Mode;
        public SandBox SandBox;
        public Live Live;

        public ServiceLifetime KolayBiApiFactoryLifeTime { get; set; }

    }

    public class Live
    {
        public string ApiKey;
        public string Channel;
        public string BaseUrl;
    }

    public class SandBox
    {
        public string ApiKey;
        public string Channel;
        public string BaseUrl;
    }
}
