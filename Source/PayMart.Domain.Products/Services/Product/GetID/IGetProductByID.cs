using PayMart.Domain.Products.Model;

namespace PayMart.Domain.Products.Services.Product.GetID;

public interface IGetProductByID
{
    Task<ModelProduct.ProductResponse> Execute(int id);
}
