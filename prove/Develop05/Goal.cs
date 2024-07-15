using System.ComponentModel;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    protected int _points;



    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetRepresentation();

    public abstract string GetDetailsString();

    public string ListName()
    {
        Console.WriteLine(_shortName);
        return _shortName;
    }

    public abstract int ReturnScore();

}