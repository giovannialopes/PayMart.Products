using Microsoft.Extensions.DependencyInjection;
using PayMart.Application.Products.AutoMapper;

namespace PayMart.Domain.Products.Services.AInjection;

public static class DependencyInjectionApp
{
    public static void AddServices(this IServiceCollection service)
    {
        AddMapping(service);
        AddRepositories(service);
    }

    private static void AddMapping(IServiceCollection service)
    {
        service.AddAutoMapper(typeof(AutoMapping));
    }

    private static void AddRepositories(IServiceCollection services)
    {

        services.AddScoped<IProductServices, ProductServices>();

    }
}
