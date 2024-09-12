using PayMart.Domain.Products.Interface.Database;
using PayMart.Domain.Products.Model;

namespace PayMart.Domain.Products.Services;

public interface IProductServices
{
    Task<ModelProduct.ListProductResponse?> GetProducts();

    Task<ModelProduct.ProductResponse?> GetProductById(int id);

    Task<ModelProduct.ProductResponse?> CreateProduct(ModelProduct.CreateProductRequest request);

    Task<ModelProduct.ProductResponse?> UpdateProduct(ModelProduct.UpdateProductRequest request, int id);

    Task<string?> DeleteProduct(int id);

}
