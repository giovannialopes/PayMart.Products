using PayMart.Domain.Products.Entities;
using PayMart.Domain.Products.Response.Product;

namespace PayMart.Domain.Products.Interface.Products.IGetID;

public interface IGetID
{
    Task<ProductEnt> GetID(int id);
}
