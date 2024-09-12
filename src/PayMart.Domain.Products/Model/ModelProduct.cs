using PayMart.Domain.Products.Enums;
using System.Text.Json.Serialization;

namespace PayMart.Domain.Products.Model;

public class ModelProduct
{
    public class CreateProductRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int StockQuantity { get; set; }
        public decimal Price { get; set; }

        [JsonIgnore]
        public int UserId { get; set; }

        [JsonIgnore]
        public int ProductId { get; set; }

    }

    public class UpdateProductRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int StockQuantity { get; set; }
        public decimal Price { get; set; }

        [JsonIgnore]
        public int UserId { get; set; }

        [JsonIgnore]
        public int ProductId { get; set; }
    }

    public class ProductResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int StockQuantity { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; } = string.Empty;
        public int UserId { get; set; }
    }

    public class ListProductResponse
    {
        public List<ProductResponse> Products { get; set; } = [];
    }

}
