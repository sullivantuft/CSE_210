public class ChecklistGoal : Goal
{
    protected int _amountCompleted;
    protected int _target;
    protected int _bonus;
public ChecklistGoal(string name, string description, string points, int target, int bonus) :base (name, description, points)
{
    _target = target;
    _bonus = bonus;
    _amountCompleted=0;
}
public ChecklistGoal(string name, string description, string points, int target, int bonus, int amountCompleted) :base (name, description, points)
{
    _target = target;
    _bonus = bonus;
    _amountCompleted=amountCompleted;
}
public override void RecordEvent()
{
    _amountCompleted++;
}
public override string GetPoints()
{
    if(_target==_amountCompleted)
    {
        return (_bonus + int.Parse(_points)).ToString();
    }
    else
        return _points;
    
}
public override bool IsComplete()
{
    if(_target==_amountCompleted)
    {
        return true;
    }
    else
        return false;
}
public override string GetDetailsString()
{
    if(_target==_amountCompleted)
    {
        return $"[X] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }
    else
        return $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
   
}
public override string ToString()
{
    return $"{_shortName} ({_description}) -- Completed {_amountCompleted} / {_target}";
}
    public override string GetStringRepresentation()
{
    return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
}
}