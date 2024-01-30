using Microsoft.Extensions.DependencyInjection;
using KolayBi.Net.Utils.Abstract;
using KolayBi.Net.Utils.Concrete;
using System;
using KolayBi.Net.Factory;

namespace KolayBi.Net
{
    public static class ServiceCollectionHelpers
    {
        /// <summary>
        /// Adds iyzipay services to <see cref="IServiceCollection"/>.
        /// You can define <see cref="RestHttpClient"/> and <see cref="RestHttpClientV2"/> lifetimes. 
        /// </summary>
        /// <typeparam name="TJob"></typeparam>
        /// <param name="services"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static IServiceCollection AddKolayBiIntegration(this IServiceCollection services, Action<IOptions> options)
        {
            if (options == null)
                throw new Exception("Please provide Options.");

            var config = new Options();

            options.Invoke(config);

            services = services.AddSingleton<IOptions>(config);

            services = config.KolayBiApiFactoryLifeTime switch
            {
                ServiceLifetime.Singleton => services.AddSingleton<IKolayBiApiFactory, KolayBiApiFactory>(),
                ServiceLifetime.Scoped => services.AddScoped<IKolayBiApiFactory, KolayBiApiFactory>(),
                ServiceLifetime.Transient => services.AddTransient<IKolayBiApiFactory, KolayBiApiFactory>(),
                _ => services.AddScoped<IKolayBiApiFactory, KolayBiApiFactory>(),
            };

            return services;
        }
    }
}
