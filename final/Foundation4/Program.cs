using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> _events = new List<Event>();

        Running running = new Running("08/10/2024", 120, 60);
        Biking biking = new Biking("05/29/2024", 100, 10);
        Swimming swimming = new Swimming("06/01/2024", 60, 100);

        _events.Add(running);
        _events.Add(biking);
        _events.Add(swimming);

        foreach(Event event1 in _events)
        {
            Console.WriteLine(event1.GetActivitySummary());
        }

    }
}