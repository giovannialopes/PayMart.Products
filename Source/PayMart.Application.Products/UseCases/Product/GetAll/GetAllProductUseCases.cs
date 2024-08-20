using AutoMapper;
using PayMart.Domain.Products.Interface.Database;
using PayMart.Domain.Products.Interface.Products.GetAll;
using PayMart.Domain.Products.Response.ListOfProduct;
using PayMart.Domain.Products.Response.Product;

namespace PayMart.Application.Products.UseCases.Product.GetAll;

public class GetAllProductUseCases : IGetAllProductUseCases
{
    private readonly IMapper _mapper;
    private readonly IGetAll _getAll;

    public GetAllProductUseCases(IMapper mapper,
    IGetAll getAll)
    {
        _mapper = mapper;
        _getAll = getAll;
    }

    public async Task<ResponseList> Execute()
    {
        var response = await _getAll.GetAll();

        return new ResponseList
        {
            Products = _mapper.Map<List<ResponseProduct>>(response)
        };
    }
}
