using PayMart.Domain.Products.Entities;

namespace PayMart.Domain.Products.Interface.Products.GetAll;

public interface IGetAll
{
    Task<List<ProductEnt>> GetAll();
}
