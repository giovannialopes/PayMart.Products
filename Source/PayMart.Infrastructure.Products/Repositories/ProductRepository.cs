using PayMart.Domain.Products.Interface.Database;
using PayMart.Infrastructure.Products.DataAcess;

namespace PayMart.Infrastructure.Products.Repositories;

public class ProductRepository :
    ICommit
{
    private readonly DbProduct _dbProduct;

    public ProductRepository(DbProduct dbProduct)
    {
        _dbProduct = dbProduct;
    }

    public Task Commit()
    {
        throw new NotImplementedException();
    }
}
