using Microsoft.EntityFrameworkCore;
using PayMart.Domain.Products.Entities;
using PayMart.Domain.Products.Interface.Database;
using PayMart.Domain.Products.Interface.Products.GetAll;
using PayMart.Domain.Products.Interface.Products.Post;
using PayMart.Infrastructure.Products.DataAcess;

namespace PayMart.Infrastructure.Products.Repositories;

public class ProductRepository :
    ICommit,
    IPost,
    IGetAll
{
    private readonly DbProduct _dbProduct;

    public ProductRepository(DbProduct dbProduct)
    {
        _dbProduct = dbProduct;
    }
    public async Task Commit() => await _dbProduct.SaveChangesAsync();


    public async Task Add(Product product) => await _dbProduct.Tb_Product.AddAsync(product);
    public async Task<List<Product>> GetAll() => await _dbProduct.Tb_Product.AsNoTracking().ToListAsync();

}
