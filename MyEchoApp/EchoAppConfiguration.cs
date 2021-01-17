using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace MyEchoApp
{
    public static class EchoAppConfiguration
    {
        public static IServiceCollection AddEchoApp(this IServiceCollection services, IConfigurationRoot configuration)
        {
            services.Replace(ServiceDescriptor.Singleton(typeof(IConfiguration), configuration));
            return services;
        }
    }
}
