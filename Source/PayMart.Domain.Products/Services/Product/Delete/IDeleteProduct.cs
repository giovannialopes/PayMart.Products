namespace PayMart.Domain.Products.Services.Product.Delete;

public interface IDeleteProduct
{    Task<string?> Execute(int id); 
}
