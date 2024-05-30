public class Swimming : Event
{
private int _laps;
public Swimming(string date, double minutes, int laps) : base (date, minutes)
{
    _laps = laps;
    _eventType = "Swimming";
}
public override double GetDistance()
{
    return _laps * 50 / 1000 * 0.62;
}
public override double GetSpeed()
{
return Math.Round(GetDistance() / _minutes * 60,2);
}
public override double GetPace()
{
return Math.Round(60 / GetSpeed(),2);
}

}
