
using AutoMapper;
using PayMart.Domain.Products.Interface.Database;
using PayMart.Domain.Products.Interface.Products.GetSum;

namespace PayMart.Application.Products.UseCases.Product.GetSum;

public class GetSumProductUseCases : IGetSumProductUseCases
{
    private readonly IGetSum _getSum;
    private readonly IMapper _mapper;

    public GetSumProductUseCases(
        IGetSum getSum,
        IMapper mapper)
    {
        _getSum = getSum;
        _mapper = mapper;
    }


    public async Task<decimal> Execute(int productID)
    {
        var Product = await _getSum.GetSum(productID);

        var totalSum = Product.Sum(product => product.Price);

        return _mapper.Map<decimal>(totalSum);
    }
}
