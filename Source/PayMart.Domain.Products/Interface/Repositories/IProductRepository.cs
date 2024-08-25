using PayMart.Domain.Products.Entities;
using PayMart.Domain.Products.Interface.Database;

namespace PayMart.Domain.Products.Interface.Repositories;

public interface IProductRepository : ICommit
{

    public Task<List<ProductEnt>> GetProduct();
    public Task<ProductEnt?> GetProductByID(int id);
    public Task<bool?> VerifyProduct(int productId);
    public Task<List<ProductEnt>> GetSumPrices(int id);

    public void UpdateProduct(ProductEnt product);
    public void AddProduct(ProductEnt product);
    public void DeleteProduct(ProductEnt product);


}
