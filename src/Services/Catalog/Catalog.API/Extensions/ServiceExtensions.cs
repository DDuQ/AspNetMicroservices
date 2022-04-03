using Catalog.API.Data;
using Catalog.API.Repositories;

namespace Catalog.API.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddContext(this IServiceCollection services)
    {
        services.AddScoped<ICatalogContext, CatalogContext>();
        return services;
    }

    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IProductRepository, ProductRepository>();
        return services;
    }
}
