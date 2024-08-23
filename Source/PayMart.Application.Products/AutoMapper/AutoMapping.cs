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
        CreateMap<RequestProduct, ProductEnt>();

        CreateMap<RequestProductUpdate, ProductEnt>()
            .ForMember(dest => dest.UserID, opt => opt.Ignore())
            .ForMember(dest => dest.ProductID, opt => opt.Ignore());
    }

    private void EntityToResponse()
    {
        CreateMap<ProductEnt, ResponseProduct>();
        CreateMap<ProductEnt, ResponseList>();
    }
}
