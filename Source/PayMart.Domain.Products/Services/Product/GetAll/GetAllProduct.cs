using AutoMapper;
using PayMart.Domain.Products.Interface.Repositories;
using PayMart.Domain.Products.Model;
using PayMart.Domain.Products.Services.Product.GetAll;

namespace PayMart.Domain.Products.Services.Product.GetAll;

public class GetAllProduct(IProductRepository productRepository,
    IMapper mapper) : IGetAllProduct
{
    public async Task<ModelProduct.ListProductResponse?> Execute()
    {
        var response = await productRepository.GetProduct();

        if (response.Count != 0)
        {
            return new ModelProduct.ListProductResponse
            {
                Products = mapper.Map<List<ModelProduct.ProductResponse>>(response)
            };
        }
        return default;
    }
}
