public class SimpleGoal : Goal
{
    private bool _isComplete;
public SimpleGoal(string name, string description, string points) : base(name, description, points)
{
    _isComplete=false;
}
public SimpleGoal(string name, string description, string points, Boolean complete) : base(name, description, points)
{
    _isComplete=complete;
}
public override void RecordEvent()
{
    _isComplete=true;
    
}
public override bool IsComplete()
{
    return _isComplete;
}
public override string ToString()
    {
        return $"{_shortName}, {_description}, {_points}";
    }
public override string GetStringRepresentation()
{

    return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
}

}