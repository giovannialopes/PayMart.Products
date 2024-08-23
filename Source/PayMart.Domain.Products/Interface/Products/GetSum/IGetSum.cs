using PayMart.Domain.Products.Entities;

namespace PayMart.Domain.Products.Interface.Products.GetSum;

public interface IGetSum
{
    Task<List<ProductEnt>> GetSum(int id);
}
