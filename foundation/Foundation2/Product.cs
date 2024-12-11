public class Product
{
    private string _name;
    private string _productId;
    private decimal _pricePerUnit;

    public Product(string name, string productId, decimal pricePerUnit)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
    }

    public string Name => _name;
    public string ProductId => _productId;
    public decimal PricePerUnit => _pricePerUnit;
}