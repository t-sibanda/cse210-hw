using System;
public class Program
{
    public static void Main()
    {
  
        Customer customer1 = new Customer("Terry Bhobho", new Address("835 Main St", "South Bend", "IN", "USA"));
        Customer customer2 = new Customer("Lawrence Sibanda", new Address("790 Makomo Street", "Epworth", "Harare", "Zimbabwe"));

        Product product1 = new Product("Laptop", "Dell G5 Gaming", 999.99m);
        Product product2 = new Product("Phone", "Google Pixel 9 A", 799.99m);
        Product product3 = new Product("Tablet", "Samsung Galaxy 9", 399.99m);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1, 2);
        order1.AddProduct(product2, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3, 3);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice()}");

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice()}");
    }
}