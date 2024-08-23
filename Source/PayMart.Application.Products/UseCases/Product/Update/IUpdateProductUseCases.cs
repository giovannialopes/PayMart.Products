using PayMart.Domain.Products.Request.Product;
using PayMart.Domain.Products.Response.Product;

namespace PayMart.Application.Products.UseCases.Product.Update;

public interface IUpdateProductUseCases
{
    Task<ResponseProduct> Execute(RequestProductUpdate request, int id);
}
