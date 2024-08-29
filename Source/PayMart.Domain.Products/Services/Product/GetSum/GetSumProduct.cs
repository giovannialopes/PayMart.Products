
using AutoMapper;
using PayMart.Domain.Products.Interface.Repositories;

namespace PayMart.Domain.Products.Services.Product.GetSum;

public class GetSumProduct(IProductRepository productRepository,
    IMapper mapper) : IGetSumProduct
{
    public async Task<decimal> Execute(int productID)
    {
        var Product = await productRepository.GetSumPrices(productID);

        if (Product.Count != 0)
        {
            var totalSum = Product.Sum(product => product.Price);

            return mapper.Map<decimal>(totalSum);
        }
        return 0;
    }
}
