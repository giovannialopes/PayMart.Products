using AutoMapper;
using PayMart.Domain.Products.Interface.Repositories;

namespace PayMart.Application.Products.UseCases.Product.Delete;

public class DeleteProductUseCases : IDeleteProductUseCases
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public DeleteProductUseCases(IProductRepository productRepository,
        IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<string> Execute(int id)
    {
        var verifyProduct = await _productRepository.GetProductByID(id);

        if (verifyProduct != null)
        {
            _productRepository.DeleteProduct(verifyProduct);
            await _productRepository.Commit();

            return "Ok";
        }
        return "";

    }
}
