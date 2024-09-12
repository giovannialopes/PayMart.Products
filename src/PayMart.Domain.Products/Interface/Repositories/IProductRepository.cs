using PayMart.Domain.Products.Entities;
using PayMart.Domain.Products.Interface.Database;

namespace PayMart.Domain.Products.Interface.Repositories;

public interface IProductRepository : ICommit
{

    public Task<List<Product>> GetProduct();
    public Task<Product?> GetProductByID(int id);
    public Task<List<Product>> GetSumPrices(int id);

    public void UpdateProduct(Product product);
    public void AddProduct(Product product);
    public void DeleteProduct(Product product);


}
