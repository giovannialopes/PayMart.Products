using AutoMapper;
using PayMart.Domain.Products.Interface.Database;
using PayMart.Domain.Products.Interface.Products.IGetID;
using PayMart.Domain.Products.Interface.Products.Update;
using PayMart.Domain.Products.Request.Product;
using PayMart.Domain.Products.Response.Product;

namespace PayMart.Application.Products.UseCases.Product.Update;

public class UpdateProductUseCases : IUpdateProductUseCases
{

    private readonly IUpdate _update;
    private readonly IGetID _getID;
    private readonly ICommit _commit;
    private readonly IMapper _mapper;

    public UpdateProductUseCases(IUpdate update,
        IGetID getID,
        ICommit commit,
        IMapper mapper)
    {
        _update = update;
        _getID = getID;
        _commit = commit;
        _mapper = mapper;
    }

    public async Task<ResponseProduct> Execute(RequestProduct request, int id)
    {
        var GetID = await _getID.GetID(id);

        var product = _mapper.Map(request,GetID);

        _update.Update(product);

        await _commit.Commit();

        return _mapper.Map<ResponseProduct>(product);
    }
}
