public class Biking : Event
{
    private double _speed;

public Biking(string date, double minutes, double speed) : base (date, minutes)

{
    _speed = speed;
    _eventType = "Biking";
}
public override double GetDistance()
{
    return _speed * GetPace();
}
public override double GetSpeed()
{
return _speed;
}
public override double GetPace()
{
    return Math.Round( 60 / _speed, 2);
}

}
