
using AutoMapper;
using PayMart.Domain.Products.Interface.Repositories;

namespace PayMart.Application.Products.UseCases.Product.GetSum;

public class GetSumProductUseCases : IGetSumProductUseCases
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public GetSumProductUseCases(IProductRepository productRepository,
        IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }


    public async Task<decimal> Execute(int productID)
    {
        var Product = await _productRepository.GetSumPrices(productID);

        if (Product.Count != 0)
        {
            var totalSum = Product.Sum(product => product.Price);

            return _mapper.Map<decimal>(totalSum);
        }
        return 0;
    }
}
