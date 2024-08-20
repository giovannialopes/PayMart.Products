using AutoMapper;
using PayMart.Domain.Products.Entities;
using PayMart.Domain.Products.Request.Product;
using PayMart.Domain.Products.Response.ListOfProduct;
using PayMart.Domain.Products.Response.Product;

namespace PayMart.Application.Products.AutoMapper;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        RequestToEntity();
        EntityToResponse();
    }

    private void RequestToEntity()
    {
        CreateMap<RequestProduct, Product>();
    }

    private void EntityToResponse()
    {
        CreateMap<Product, ResponseProduct>();
        CreateMap<Product, ResponseList>();
    }
}
