using PayMart.Domain.Products.Entities;
using PayMart.Domain.Products.Interface.Database;
using PayMart.Domain.Products.Interface.Products.Post;
using PayMart.Infrastructure.Products.DataAcess;

namespace PayMart.Infrastructure.Products.Repositories;

public class ProductRepository :
    ICommit,
    IPost
{
    private readonly DbProduct _dbProduct;

    public ProductRepository(DbProduct dbProduct)
    {
        _dbProduct = dbProduct;
    }

    public async Task Add(Product product) => await _dbProduct.AddAsync(product);


    public async Task Commit() => await _dbProduct.SaveChangesAsync();

}
