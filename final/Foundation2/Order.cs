public class Order
{
    private List<Product> _products;
    private Customer _customer;
    
    
    

public Order(Customer customer, List<Product> products)
{
    _customer = customer;

    _products = new List<Product>(products); 
}
public double GetTotalPrice()
{
    double total=0;
    foreach(Product product in _products)
    {
        total+=product.GetTotal();
    }

    total+=GetShippingPrice();
    
    return total;   
}
public double GetShippingPrice()
{
int shippingPrice=0;
if(_customer.LocatedInUSA())
    {
        shippingPrice=5;

    }
    else
    {
        shippingPrice=35;
    }
    return shippingPrice;
}
public void PrintPackingLabel()
{
    Console.WriteLine("Order: ");
    foreach(Product product in _products)
    {
        Console.WriteLine(product.GetStringRepresentation());
    }
    Console.WriteLine($"Shipping: $" + GetShippingPrice());
    Console.WriteLine("Total: $" + GetTotalPrice());
    
}
public void PrintShippingLabel()
{
    Console.WriteLine($"Ship to: \n{_customer.GetName()}");
    Console.WriteLine(_customer.GetAddress());
}

    
}