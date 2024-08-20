using AutoMapper;
using PayMart.Domain.Products.Interface.Database;
using PayMart.Domain.Products.Interface.Products.Delete;
using PayMart.Domain.Products.Interface.Products.IGetID;
using PayMart.Domain.Products.Interface.Products.Update;
using PayMart.Domain.Products.Response.Product;

namespace PayMart.Application.Products.UseCases.Product.Delete;

public class DeleteProductUseCases : IDeleteProductUseCases
{
    private readonly IDelete _delete;
    private readonly ICommit _commit;
    private readonly IMapper _mapper;

    public DeleteProductUseCases(IDelete delete,
        ICommit commit,
        IMapper mapper)
    {
        _delete = delete;
        _commit = commit;
        _mapper = mapper;
    }

    public async Task Execute(int id)
    {
        await _delete.Delete(id);

        await _commit.Commit();
    }
}
