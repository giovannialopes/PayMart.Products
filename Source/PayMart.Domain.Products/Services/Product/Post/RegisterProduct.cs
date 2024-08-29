using AutoMapper;
using PayMart.Domain.Products.Interface.Repositories;
using PayMart.Domain.Products.Model;

namespace PayMart.Domain.Products.Services.Product.Post;

public class RegisterProduct(IProductRepository productRepository,
    IMapper mapper) : IRegisterProduct
{
    public async Task<ModelProduct.ProductResponse> Execute(ModelProduct.CreateProductRequest request)
    {
        var Product = mapper.Map<Entities.Product>(request);
;        Product.CreatedBy = request.UserId;
        

        productRepository.AddProduct(Product);

        await productRepository.Commit();

        return mapper.Map<ModelProduct.ProductResponse>(Product);
    }
}
