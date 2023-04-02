using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Skinny Jean", "0024SJ", 45, 2);
        Address address1 = new Address("100 N 100 E", "Provo", "UT", "USA");
        Customer customer1 = new Customer("Tony Goodman", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.PackingLabel();
        Console.WriteLine($"Shipping: ${order1.ShippingCost()}");
        Console.WriteLine($"Subtotal: ${order1.OrderTotal()}");
        order1.ShippingLabel(customer1);

        Console.WriteLine();
        Console.WriteLine($"---------------------");
        Product product2 = new Product("Blue Sweatshirt", "0003BS", 35, 1);
        Product product3 = new Product("Bomber Jacket", "001XZY", 180, 1);
        Address address2 = new Address("123 Main Street", "Montreal", "QC", "Canada");
        Customer customer2 = new Customer("John White", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);
        order2.PackingLabel();
        Console.WriteLine($"Shipping: ${order2.ShippingCost()}");
        Console.WriteLine($"Subtotal: ${order2.OrderTotal()}");
        order2.ShippingLabel(customer2);
    }
}