namespace PayMart.Application.Products.Utilities;

public static class ProductIdGenerator
{
    public static int ReturnID()
    {
        var productId = SaveProductID.GetProductId();

        if (productId == 0)
        {
            productId = NumberGenerator.Generate();
            SaveProductID.SaveProductId(productId);
        }

        return productId;
    }
}
