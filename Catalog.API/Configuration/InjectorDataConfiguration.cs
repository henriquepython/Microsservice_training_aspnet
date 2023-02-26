using Catalog.API.Data;
using Catalog.API.Repositories;

namespace Catalog.API.Configuration
{
    public static class InjectorDataConfiguration
    {
        public static void AddDataConfiguration(this IServiceCollection service)
        {
            service.AddScoped<ICatalogContext, CatalogContext>();
            service.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
