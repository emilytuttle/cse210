public class EternalGoal : Goal
{
    int _completionCount;
    private string _name;
    private string _description;

    public EternalGoal(string name, string description, int points, int count) : base (name, description, points)
    {
        _completionCount = count;
        _name = name;
        _description = description;
        _points = points;
    }

    public override void RecordEvent()
    {
       _completionCount += 1;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetRepresentation()
    {
        return $"Eternal Goal|{_name}|{_description}|{_points}|{_completionCount}";
    }

     public override string GetDetailsString()
    {
        Console.WriteLine($"[ ] {_name}: {_description}. ({_points}) You have completed this goal {_completionCount} times.");
        return $"[ ] {_name}: {_description}. ({_points}) You have completed this goal {_completionCount} times." ;
    }

    public override int ReturnScore()
    {
        return _points;
    }

}