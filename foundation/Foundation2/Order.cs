public class Order
{
    private List<(Product Product, int Quantity)> _products;
    private Customer _customer;
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<(Product Product, int Quantity)>();
    }
    public void AddProduct(Product product, int quantity)
    {
        _products.Add((product, quantity));
    }
    public decimal CalculateTotalPrice()
    {
        decimal totalProductCost = _products.Sum(p => p.Product.PricePerUnit * p.Quantity);
        decimal shippingCost = _customer.IsUSACustomer() ? 5 : 35;
        return totalProductCost + shippingCost;
    }
    public string GetPackingLabel()
    {
        return string.Join("\n", _products.Select(p => $"{p.Product.Name} ({p.Product.ProductId}) x {p.Quantity}"));
    }
    public string GetShippingLabel()
    {
        return $"To: {_customer.Name}\n{_customer.Address.GetFullAddress()}";
    }
}