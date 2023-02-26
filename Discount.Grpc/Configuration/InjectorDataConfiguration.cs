
using Discount.Grpc.Repositories;

namespace Discount.Grpc.Configuration
{
    public static class InjectorDataConfiguration
    {
        public static void AddDataConfiguration(this IServiceCollection service)
        {
            service.AddScoped<IDiscountRepository, DiscountRepository>();
        }
    }
}
