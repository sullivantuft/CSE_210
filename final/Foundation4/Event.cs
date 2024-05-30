public abstract class Event
{
    private string _date;
    protected double _minutes;
    protected string _eventType;
public Event(string date, double minutes)
{
    _date = date;
    _minutes = minutes;
}
public string GetActivitySummary()
{
    return $"{_date} {_eventType} ({_minutes} minutes) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
}
public abstract double GetDistance();
public abstract double GetSpeed();

public abstract double GetPace();


}