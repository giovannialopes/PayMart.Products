namespace PayMart.Domain.Products.Utilities;

public class SaveProductID
{
    private static int _productID;
    public static void SaveProductId(int productID) => _productID = productID;
    public static int GetProductId() => _productID;

}
