namespace PayMart.Domain.Products.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public int Amount { get; set; } 
    public decimal Price { get; set; }
    public int UserID {  get; set; }
    public int ProductID {  get; set; }
   
}
