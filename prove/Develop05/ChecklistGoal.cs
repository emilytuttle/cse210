public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private string _name;
    private string _description;
    
    public ChecklistGoal(string name, string description, int points, int target, int bonus, int numberComleted) : base (name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = numberComleted;
        _name = name;
        _description = description;
        _points = points;
    }

   public override void RecordEvent()
    {
      _amountCompleted += 1;
    }

    public override bool IsComplete()
    {
        if (_amountCompleted < _target) {
            return false;
        }
        else
        {
            return true;
        }
    }

    public override string GetRepresentation()
    {
        return $"Checklist Goal|{_name}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
    }

     public override string GetDetailsString()
    {
        if (IsComplete())
        {
            Console.WriteLine($"[X] {_name}: {_description}. ({_points}) Completed {_amountCompleted}/{_target} times! You received {_bonus} bonus points.");
             return $"[ ] {_name}: {_description}. ({_points})";
        }
        else
        {
            Console.WriteLine($"[ ] {_name}: {_description}. ({_points}) Completed {_amountCompleted}/{_target} times, and will get {_bonus} bonus points when you complete it.");
             return $"[ ] {_name}: {_description}. ({_points})";
        }
    }

    public override int ReturnScore()
    {
        if (_amountCompleted < _target)
        {
            return _points;
        }
        else{
            return _points + _bonus;
        }
        
    }



  
}