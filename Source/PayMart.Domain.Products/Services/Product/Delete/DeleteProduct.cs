using PayMart.Domain.Products.Interface.Repositories;
using PayMart.Domain.Products.Services.Product.Delete;

namespace PayMart.Domain.Products.Services.Product.Delete;

public class DeleteProduct(IProductRepository productRepository) : IDeleteProduct
{
    public async Task<string?> Execute(int id)
    {
        var verifyProduct = await productRepository.GetProductByID(id);

        if (verifyProduct != null)
        {
            productRepository.DeleteProduct(verifyProduct);
            await productRepository.Commit();

            return "Ok";
        }
        return default;

    }
}
