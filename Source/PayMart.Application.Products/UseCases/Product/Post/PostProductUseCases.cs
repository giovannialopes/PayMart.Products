using AutoMapper;
using PayMart.Domain.Products.Interface.Database;
using PayMart.Domain.Products.Interface.Products.Post;
using PayMart.Domain.Products.Request.Product;
using PayMart.Domain.Products.Response.Product;
using PayMart.Domain.Products.Entities;

namespace PayMart.Application.Products.UseCases.Product.Post;

public class PostProductUseCases : IPostProductUseCases
{
    private readonly IPost _post;
    private readonly ICommit _commit;
    private readonly IMapper _mapper;

    public PostProductUseCases(IPost post,
        ICommit commit,
        IMapper mapper)
    {
        _post = post;
        _commit = commit;
        _mapper = mapper;
    }

    public async Task<ResponseProduct> Execute(RequestProduct request)
    {
        var Client = _mapper.Map<ProductEnt>(request);

        await _post.Add(Client);

        await _commit.Commit();

        return _mapper.Map<ResponseProduct>(Client);
    }
}
