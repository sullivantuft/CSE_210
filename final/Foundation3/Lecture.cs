public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
public Lecture(string title, string description, string date, Address address, string speaker, int capacity) : base (title, description, date, "Lecture", address)
{
    _speaker = speaker;
    _capacity = capacity;
}

public override void FullDetails()
{
    Console.WriteLine($"Type: {_eventType}");
    Console.WriteLine($"{_title} - {_description}");
    Console.WriteLine($"{_date}");
    _address.GetStringRepresentation();
    Console.WriteLine($"Speaker: {_speaker}");
    Console.WriteLine($"Capacity: {_capacity}");
}

}