public class Reception : Event
{
    private string _email;
public Reception(string title, string description, string date, Address address, string email) : base (title, description, date, "Reception", address)
{
    _email = email;
}

public override void FullDetails()
{
    Console.WriteLine($"Type: {_eventType}");
    Console.WriteLine($"{_title} - {_description}");
    Console.WriteLine($"{_date}");
    _address.GetStringRepresentation();
    Console.WriteLine($"Email: {_email}");
}

}