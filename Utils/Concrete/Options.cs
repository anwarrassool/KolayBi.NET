using Microsoft.Extensions.DependencyInjection;
using KolayBi.Net.Utils.Abstract;

namespace KolayBi.Net.Utils.Concrete
{
    public class Options : IOptions
    {
        public string Mode;
        public SandBox SandBox;
        public Live Live;

        public ServiceLifetime KolayBiApiFactoryLifeTime { get; set; }

    }
}
