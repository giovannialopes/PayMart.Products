namespace PayMart.Domain.Products.Entities;

public class Product
{
    public int ID { get; set; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public int Amount { get; set; } 
    public decimal Price { get; set; }
    public int UserID {  get; set; }
   
}
