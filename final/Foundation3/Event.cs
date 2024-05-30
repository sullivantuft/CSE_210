using System.Diagnostics;
using System.Net.Sockets;

public abstract class Event
{
protected string _title;
protected string _description;
protected string _date;
protected string _eventType;
protected Address _address;

public Event(string title, string description, string date, string eventType, Address address)
{
    _title = title;
    _description=description;
    _date=date;
    _eventType=eventType;
    _address = address;
    
}
public void StandardDetails()
{
    Console.WriteLine($"{_title} - {_description}");
    Console.WriteLine($"{_date}");
    Console.WriteLine(_address.GetStringRepresentation());
}

public void ShortDescription()
{
    Console.WriteLine($"{_eventType} - {_title} - {_date}");
}
public abstract void FullDetails();



}