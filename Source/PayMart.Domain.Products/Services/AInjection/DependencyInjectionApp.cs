using Microsoft.Extensions.DependencyInjection;
using PayMart.Application.Products.AutoMapper;
using PayMart.Domain.Products.Services.Product.Delete;
using PayMart.Domain.Products.Services.Product.GetAll;
using PayMart.Domain.Products.Services.Product.GetID;
using PayMart.Domain.Products.Services.Product.GetSum;
using PayMart.Domain.Products.Services.Product.Post;
using PayMart.Domain.Products.Services.Product.Update;

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
        services.AddScoped<IRegisterProduct, RegisterProduct>();
        services.AddScoped<IGetAllProduct, GetAllProduct>();
        services.AddScoped<IGetProductByID, GetProductByID>();
        services.AddScoped<IUpdateProduct, UpdateProduct>();
        services.AddScoped<IDeleteProduct, DeleteProduct>();
        services.AddScoped<IGetSumProduct, GetSumProduct>();
    }
}
