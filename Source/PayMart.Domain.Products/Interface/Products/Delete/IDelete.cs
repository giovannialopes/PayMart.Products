using PayMart.Domain.Products.Entities;

namespace PayMart.Domain.Products.Interface.Products.Delete;

public interface IDelete
{
    Task Delete(int id);
}
