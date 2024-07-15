public class SimpleGoal : Goal
{
    private bool _isComplete;
    private string _name;
    private string _description;
    
    

    public SimpleGoal(string name, string description, int points, bool isComplete) : base (name, description, points)
    {
        _isComplete = isComplete;
        _name = name;
        _description = description;
        _points = points;

    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {

        if (_isComplete == true)
        {
            return true;
        }
        else{
            return false;
        }
        
    }

    public override string GetRepresentation()
    {
        return $"Simple Goal|{_name}|{_description}|{_points}|{_isComplete}";
    }

    public override string GetDetailsString()
    {
        if (_isComplete)
        {
            Console.WriteLine($"[X] {_name}: {_description}. ({_points})");
             return $"[ ] {_name}: {_description}. ({_points})";
        }
        else
        {
            Console.WriteLine($"[ ] {_name}: {_description}. ({_points})");
             return $"[ ] {_name}: {_description}. ({_points})";
        }
    }

    public override int ReturnScore()
    {
        return _points;
    }
   
}