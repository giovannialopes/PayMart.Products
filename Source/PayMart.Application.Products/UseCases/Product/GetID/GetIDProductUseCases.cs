using AutoMapper;
using PayMart.Domain.Products.Interface.Products.IGetID;
using PayMart.Domain.Products.Response.Product;

namespace PayMart.Application.Products.UseCases.Product.GetID;

public class GetIDProductUseCases : IGetIDProductUseCases
{
    private readonly IMapper _mapper;
    private readonly IGetID _getID;

    public GetIDProductUseCases(IMapper mapper,
        IGetID getID)
    {
        _mapper = mapper;
        _getID = getID;
    }

    public async Task<ResponseProduct> Execute(int id)
    {
        var response = await _getID.GetID(id);

        return _mapper.Map<ResponseProduct>(response);
    }
}
