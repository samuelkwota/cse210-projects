using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create two products
        Product product1 = new Product("Product: Apple Vision Pro", "P123", 10.99, 2);
        Product product2 = new Product("Product: Iphone X ","P124", 5.99, 3);

        // Create two addresses
        Address address1 = new Address("123 Main St", "Salt Lake City", "CA", "Country: USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        // Create two customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create two orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);

        Console.WriteLine("SAMUEL KWOTA ENTERPRICE");
        Console.WriteLine("");
        // Display packing label, shipping label, and total price for order 1
        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("\nOrder 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine("\nOrder 1 Total Price: $" + order1.GetTotalPrice());

        // Display packing label, shipping label, and total price for order 2
        Console.WriteLine("\nOrder 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("\nOrder 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine("\nOrder 2 Total Price: $" + order2.GetTotalPrice());
    }
}



