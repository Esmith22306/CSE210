using System;


class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1929 North 3000 West", "Skagway", "AK", "USA");
        Customer customer1 = new Customer("Mack Fuller", address1);

        Address address2 = new Address("2121 Elm Street", "Victoria", "BC", "Canada");
        Customer customer2 = new Customer("Jesse Pinkman", address2);

        Product product1 = new Product("Gummy Clusters", 1090, 3.99, 3);
        Product product2 = new Product("Bose 340 speakers", 360, 250.99, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);


        Order order2 = new Order(customer2);
        order2.AddProduct(product2);

        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine("\nOrder 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
    }
}
