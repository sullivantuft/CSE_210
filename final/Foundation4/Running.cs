public class Running : Event
{
    private double _distance;
public Running(string date, double minutes, double distance) : base (date, minutes)
{
    
    _distance = distance;
    _eventType = "Running";
}
public override double GetDistance()
{
    return _distance;
}
public override double GetSpeed()
{
return Math.Round(GetPace() * _minutes,2);
}
public override double GetPace()
{
return Math.Round(_distance / _minutes,2);
}

}
