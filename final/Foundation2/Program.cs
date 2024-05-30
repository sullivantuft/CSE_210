using System;

class Program
{
    static void Main(string[] args)
    {
        List<Product> _products = new List<Product>();

        Address address1 = new Address("101 E Viking St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Chad MacBeth", address1);

        Product product1 = new Product("PS5", 1, 499.99, 1);
        Product product2 = new Product("ASUS Laptop", 2, 899.99, 1);
        Product product3 = new Product("Pencil", 3, 1, 15);
        Product product4 = new Product("Markers", 4, 2, 10);

        _products.Add(product1);
        _products.Add(product3);
        _products.Add(product4);
    
        Order order1 = new Order(customer1, _products);

        order1.PrintPackingLabel();
        Console.WriteLine("");
        order1.PrintShippingLabel();

        _products.Clear();

        Address address2 = new Address("101 Main St", "Berlin", "Deutschland", "Germany");
        Customer customer2 = new Customer("Master Chief", address2);

        

    
        _products.Add(product2);
        _products.Add(product3);
        _products.Add(product4);
    
        Order order2 = new Order(customer2, _products);
        
        Console.WriteLine("");
        order2.PrintPackingLabel();
        Console.WriteLine("");
        order2.PrintShippingLabel();
    }
}