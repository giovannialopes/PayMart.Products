
namespace PayMart.Domain.Products.Services.Product.GetSum;

public interface IGetSumProduct
{
    Task<decimal> Execute(int productID);
}
