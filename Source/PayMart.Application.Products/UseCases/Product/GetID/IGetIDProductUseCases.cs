using PayMart.Domain.Products.Response.Product;

namespace PayMart.Application.Products.UseCases.Product.GetID;

public interface IGetIDProductUseCases
{
    Task<ResponseProduct> Execute(int id);
}
