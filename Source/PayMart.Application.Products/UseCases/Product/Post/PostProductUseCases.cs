using AutoMapper;
using PayMart.Domain.Products.Entities;
using PayMart.Domain.Products.Interface.Repositories;
using PayMart.Domain.Products.Request.Product;
using PayMart.Domain.Products.Response.Product;

namespace PayMart.Application.Products.UseCases.Product.Post;

public class PostProductUseCases : IPostProductUseCases
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public PostProductUseCases(IProductRepository productRepository,
        IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<ResponseProduct> Execute(RequestProduct request)
    {
        var verifyProduct = await _productRepository.VerifyProduct(request.ProductID);

        if (verifyProduct == false)
        {
            var Product = _mapper.Map<ProductEnt>(request);

            _productRepository.AddProduct(Product);

            await _productRepository.Commit();

            return _mapper.Map<ResponseProduct>(Product);
        }

        return null;
    }
}
