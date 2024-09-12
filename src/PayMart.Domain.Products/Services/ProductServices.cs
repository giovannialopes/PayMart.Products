using AutoMapper;
using PayMart.Domain.Products.Interface.Repositories;
using PayMart.Domain.Products.Model;

namespace PayMart.Domain.Products.Services;

public class ProductServices(IProductRepository productRepository, 
    IMapper mapper) : IProductServices
{
    public async Task<ModelProduct.ListProductResponse?> GetProducts()
    {
        var Product = await productRepository.GetProduct();

        if (Product.Count != 0)
        {
            return new ModelProduct.ListProductResponse
            {
                Products = mapper.Map<List<ModelProduct.ProductResponse>>(Product)
            };
        }
        return default;
    }

    public async Task<ModelProduct.ProductResponse?> GetProductById(int id)
    {
        var Product = await productRepository.GetProductByID(id);

        if (Product != null)
            return mapper.Map<ModelProduct.ProductResponse>(Product);

        return default;

    }

    public async Task<ModelProduct.ProductResponse?> CreateProduct(ModelProduct.CreateProductRequest request)
    {
        var Product = mapper.Map<Entities.Product>(request);
        Product.CreatedBy = request.UserId;

        productRepository.AddProduct(Product);

        await productRepository.Commit();

        return mapper.Map<ModelProduct.ProductResponse>(Product);
    }

    public async Task<ModelProduct.ProductResponse?> UpdateProduct(ModelProduct.UpdateProductRequest request, int id)
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

    public async Task<string?> DeleteProduct(int id)
    {
        var verifyProduct = await productRepository.GetProductByID(id);

        if (verifyProduct != null)
        {
            productRepository.DeleteProduct(verifyProduct);
            await productRepository.Commit();

            return "Deleted";
        }
        return default;
    }

}
