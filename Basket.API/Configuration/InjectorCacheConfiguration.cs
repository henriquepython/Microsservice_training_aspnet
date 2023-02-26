using Basket.API.Repositories;
using Microsoft.Extensions.Configuration;

namespace Basket.API.Configuration
{
    public static class InjectorCacheConfiguration
    {
        public static void AddCaching(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = configuration.GetValue<string>("CacheSettings:ConnectionString");
            });

            service.AddScoped<IBasketRepository, BasketRepository>();
        }
    }
}
