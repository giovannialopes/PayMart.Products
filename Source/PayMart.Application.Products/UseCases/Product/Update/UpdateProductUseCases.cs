using AutoMapper;
using PayMart.Domain.Products.Interface.Database;
using PayMart.Domain.Products.Interface.Repositories;
using PayMart.Domain.Products.Request.Product;
using PayMart.Domain.Products.Response.Product;

namespace PayMart.Application.Products.UseCases.Product.Update;

public class UpdateProductUseCases : IUpdateProductUseCases
{

    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public UpdateProductUseCases(IProductRepository productRepository,
        IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<ResponseProduct> Execute(RequestProductUpdate request, int id)
    {
        var GetProduct = await _productRepository.GetProductByID(id);

        if (GetProduct != null)
        {
            var product = _mapper.Map(request, GetProduct);

            _productRepository.UpdateProduct(product!);

            await _productRepository.Commit();

            return _mapper.Map<ResponseProduct>(product);
        }
        return null;
    }
}
