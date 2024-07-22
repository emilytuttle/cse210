public class Running : Activity{
    private int _distance;
    

    public Running(string date, int activityLength, int distance) : base(date, activityLength)
    {
        _distance = distance;
        _activityLength = activityLength;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    { 
        double speed = 60*_distance/_activityLength;
        return speed;
    }

    public override double GetPace()
    {
        double pace = _activityLength/_distance;
        return pace;
    }
}