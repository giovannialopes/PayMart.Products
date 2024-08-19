using Microsoft.EntityFrameworkCore;
using PayMart.Domain.Products.Entities;

namespace PayMart.Infrastructure.Products.DataAcess;

public class DbProduct : DbContext
{
    public DbProduct(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<Product> Tb_Product { get; set; }
}
