using AutoMapper;
using PayMart.Domain.Products.Interface.Repositories;
using PayMart.Domain.Products.Model;
using PayMart.Domain.Products.Services.Product.GetID;

namespace PayMart.Domain.Products.Services.Product.GetID;

public class GetProductByID(IProductRepository productRepository,
    IMapper mapper) : IGetProductByID
{
    public async Task<ModelProduct.ProductResponse> Execute(int id)
    {
        var response = await productRepository.GetProductByID(id);

        return mapper.Map<ModelProduct.ProductResponse>(response);
    }
}
