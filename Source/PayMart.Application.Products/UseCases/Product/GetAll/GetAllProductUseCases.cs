using AutoMapper;
using PayMart.Domain.Products.Interface.Repositories;
using PayMart.Domain.Products.Response.ListOfProduct;
using PayMart.Domain.Products.Response.Product;

namespace PayMart.Application.Products.UseCases.Product.GetAll;

public class GetAllProductUseCases : IGetAllProductUseCases
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public GetAllProductUseCases(IProductRepository productRepository,
        IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<ResponseList> Execute()
    {
        var response = await _productRepository.GetProduct();

        if (response.Count != 0)
        {
            return new ResponseList
            {
                Products = _mapper.Map<List<ResponseProduct>>(response)
            };
        }
        return null;
    }
}
