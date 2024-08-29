using PayMart.Domain.Products.Enums;

namespace PayMart.Domain.Products.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int StockQuantity { get; set; }
    public decimal Price { get; set; }
    public int UserId { get; set; } 
    public int ProductId { get; set; }
    public ProductStatus Status { get; set; } = ProductStatus.Active; 
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime? UpdatedDate { get; set; }
    public DateTime? DeleteDate { get; set; }
    public int CreatedBy { get; set; } 
    public int UpdatedBy { get; set; } 
    public int DeleteBy { get; set; }  

}
