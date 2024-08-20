using PayMart.Domain.Products.Entities;

namespace PayMart.Domain.Products.Interface.Products.Post;

public interface IPost
{
    Task Add(Product product);
}
