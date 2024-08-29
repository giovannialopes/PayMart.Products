using PayMart.Domain.Products.Model;

namespace PayMart.Domain.Products.Services.Product.GetAll;

public interface IGetAllProduct
{
    Task<ModelProduct.ListProductResponse?> Execute();
}
