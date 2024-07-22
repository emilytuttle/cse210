public abstract class Activity
{
    private string _date;
    protected int _activityLength;

    public Activity(string date, int activityLength)
    {
        _date = date;
        _activityLength = activityLength;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public void GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();
        pace = Math.Round(pace, 2);
        Console.WriteLine($"{_date} {this.GetType().Name} ({_activityLength} min): Distance {distance} miles, Speed {speed}mph, Pace {pace} min per mile");
    }

}