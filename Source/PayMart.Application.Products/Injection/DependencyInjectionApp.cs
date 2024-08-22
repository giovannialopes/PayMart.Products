using Microsoft.Extensions.DependencyInjection;
using PayMart.Application.Products.AutoMapper;
using PayMart.Application.Products.UseCases.Product.Delete;
using PayMart.Application.Products.UseCases.Product.GetAll;
using PayMart.Application.Products.UseCases.Product.GetID;
using PayMart.Application.Products.UseCases.Product.GetSum;
using PayMart.Application.Products.UseCases.Product.Post;
using PayMart.Application.Products.UseCases.Product.Update;

namespace PayMart.Application.Products.Injection;

public static class DependencyInjectionApp
{
    public static void AddApplication(this IServiceCollection service)
    {
        AddMapping(service);
        AddUseCases(service);
    }

    private static void AddMapping(IServiceCollection service)
    {
        service.AddAutoMapper(typeof(AutoMapping));
    }

    private static void AddUseCases(IServiceCollection services)
    {
        services.AddScoped<IPostProductUseCases, PostProductUseCases>();
        services.AddScoped<IGetAllProductUseCases, GetAllProductUseCases>();
        services.AddScoped<IGetIDProductUseCases, GetIDProductUseCases>();
        services.AddScoped<IUpdateProductUseCases, UpdateProductUseCases>();
        services.AddScoped<IDeleteProductUseCases, DeleteProductUseCases>();
        services.AddScoped<IGetSumProductUseCases, GetSumProductUseCases>();
    }
}
