using System.Runtime.CompilerServices;

public class Product
{
private string _name;
private int _product_id;
private double _price;
private int _quantity;
public Product(string name, int prod_id, double price, int quantity)
{
    _name = name;
    _product_id=prod_id;
    _price=price;
    _quantity=quantity;
    
}
public double GetTotal()
{
    return _price * _quantity;
}
public string GetStringRepresentation()
{
    return $"{_name} - ProductID: {_product_id} - ${_price} - QTY - {_quantity}";
}
}
