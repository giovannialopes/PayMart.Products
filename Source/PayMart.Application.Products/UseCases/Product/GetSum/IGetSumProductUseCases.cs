
namespace PayMart.Application.Products.UseCases.Product.GetSum;

public interface IGetSumProductUseCases
{
    Task<decimal> Execute(int productID);
}
