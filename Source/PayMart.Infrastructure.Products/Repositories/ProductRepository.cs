using Microsoft.EntityFrameworkCore;
using PayMart.Domain.Products.Entities;
using PayMart.Domain.Products.Interface.Repositories;
using PayMart.Infrastructure.Products.DataAcess;

namespace PayMart.Infrastructure.Products.Repositories;

public class ProductRepository : IProductRepository

{
    private readonly DbProduct _dbProduct;

    public ProductRepository(DbProduct dbProduct) => _dbProduct = dbProduct;

    public async Task Commit() => await _dbProduct.SaveChangesAsync();


    public async Task<List<ProductEnt>> GetProduct() => await _dbProduct.Tb_Product.AsNoTracking().ToListAsync();

    public async Task<bool?> VerifyProduct(int productId) => await _dbProduct.Tb_Product.AsNoTracking().AnyAsync(config => config.ProductID == productId);

    public async Task<ProductEnt?> GetProductByID(int id) => await _dbProduct.Tb_Product.AsNoTracking().FirstOrDefaultAsync(config => config.Id == id);

    public async Task<List<ProductEnt>> GetSumPrices(int id) => await _dbProduct.Tb_Product.AsNoTracking().Where(config => config.ProductID == id).ToListAsync();



    public void AddProduct(ProductEnt product) => _dbProduct.Tb_Product.AddAsync(product);

    public void UpdateProduct(ProductEnt product) => _dbProduct.Tb_Product.Update(product);

    public void DeleteProduct(ProductEnt product) => _dbProduct.Tb_Product.Remove(product);


}
