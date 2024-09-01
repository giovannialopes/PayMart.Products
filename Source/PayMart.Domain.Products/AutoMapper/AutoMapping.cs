using AutoMapper;
using PayMart.Domain.Products.Entities;
using PayMart.Domain.Products.Model;

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
        CreateMap<ModelProduct.CreateProductRequest, Product>();

        CreateMap<ModelProduct.UpdateProductRequest, Product>()
            .ForMember(dest => dest.UserId, opt => opt.Ignore());
    }

    private void EntityToResponse()
    {
        CreateMap<Product, ModelProduct.ProductResponse>();
        CreateMap<Product, ModelProduct.ListProductResponse>();
    }
}
