public class Customer
{
private bool _locatedInUSA;
private string _name;
private Address _address;
public Customer(string name, Address address)
{
    _name = name;
    _address=address;

    

    if(_address.GetCountry() == "USA")
    {
        _locatedInUSA=true;
    }
    else
    {
        _locatedInUSA=false;
    }
}
public bool LocatedInUSA()
{
    return _locatedInUSA;

}
public string GetAddress()
{
    return _address.GetStringRepresentation();
}
public string GetName()
{
    return _name;
}
}