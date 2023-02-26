using Discount.API.Data;
using Discount.API.Repositories;

namespace Discount.API.Configuration
{
    public static class InjectorDataConfiguration
    {
        public static void AddDataConfiguration(this IServiceCollection service)
        {
            service.AddScoped<DbContextDapper>();
            service.AddScoped<IDiscountRepository, DiscountRepository>();
        }
    }
}
