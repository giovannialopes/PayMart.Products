using AutoMapper;
using PayMart.Domain.Products.Interface.Repositories;
using PayMart.Domain.Products.Model;
using PayMart.Domain.Products.Services.Product.Update;

namespace PayMart.Domain.Products.Services.Product.Update;

public class UpdateProduct(IProductRepository productRepository,
    IMapper mapper) : IUpdateProduct
{
    public async Task<ModelProduct.ProductResponse?> Execute(ModelProduct.UpdateProductRequest request, int id)
    {
        var GetProduct = await productRepository.GetProductByID(id);

        if (GetProduct != null)
        {
            var product = mapper.Map(request, GetProduct);
            product.UpdatedBy = request.UserId;
            product.UpdatedDate = DateTime.Now;

            productRepository.UpdateProduct(product!);

            await productRepository.Commit();

            return mapper.Map<ModelProduct.ProductResponse>(product);
        }
        return default;
    }
}
