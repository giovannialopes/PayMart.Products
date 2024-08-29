using PayMart.Domain.Products.Model;

namespace PayMart.Domain.Products.Services.Product.Update;

public interface IUpdateProduct
{
    Task<ModelProduct.ProductResponse?> Execute(ModelProduct.UpdateProductRequest request, int id);
}
