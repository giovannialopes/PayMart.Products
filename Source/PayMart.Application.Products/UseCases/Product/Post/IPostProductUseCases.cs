using PayMart.Domain.Products.Request.Product;
using PayMart.Domain.Products.Response.Product;

namespace PayMart.Application.Products.UseCases.Product.Post;

public interface IPostProductUseCases
{
    Task<ResponseProduct> Execute(RequestProduct request);
}
