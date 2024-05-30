public class Outdoor : Event
{
    private string _weather;
public Outdoor(string title, string description, string date, Address address, string weather) : base (title, description, date, "Outdoor", address)
{
    _weather = weather;
    _address = address;
    
}
public override void FullDetails()
{
    Console.WriteLine($"Type: {_eventType}");
    Console.WriteLine($"{_title} - {_description}");
    Console.WriteLine($"{_date}");
    Console.WriteLine(_address.GetStringRepresentation());
    Console.WriteLine($"Weather: {_weather}");
}

}