using AutoMapper;
using PayMart.Domain.Products.Interface.Repositories;
using PayMart.Domain.Products.Response.Product;

namespace PayMart.Application.Products.UseCases.Product.GetID;

public class GetIDProductUseCases : IGetIDProductUseCases
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public GetIDProductUseCases(IProductRepository productRepository,
        IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<ResponseProduct> Execute(int id)
    {
        var response = await _productRepository.GetProductByID(id);

        return _mapper.Map<ResponseProduct>(response);
    }
}
