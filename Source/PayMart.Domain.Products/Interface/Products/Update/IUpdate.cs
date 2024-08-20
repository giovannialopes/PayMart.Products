using PayMart.Domain.Products.Entities;

namespace PayMart.Domain.Products.Interface.Products.Update;

public interface IUpdate
{
    Task<Product> GetIDUpdate(int id);

    void Update(Product product);
}
