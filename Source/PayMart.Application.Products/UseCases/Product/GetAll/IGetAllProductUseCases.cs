using PayMart.Domain.Products.Response.ListOfProduct;
using PayMart.Domain.Products.Response.Product;

namespace PayMart.Application.Products.UseCases.Product.GetAll;

public interface IGetAllProductUseCases
{
    Task<ResponseList> Execute();
}
