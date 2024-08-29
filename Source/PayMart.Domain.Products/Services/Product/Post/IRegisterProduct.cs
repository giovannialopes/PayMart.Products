using PayMart.Domain.Products.Model;

namespace PayMart.Domain.Products.Services.Product.Post;

public interface IRegisterProduct
{
    Task<ModelProduct.ProductResponse> Execute(ModelProduct.CreateProductRequest request);
}
