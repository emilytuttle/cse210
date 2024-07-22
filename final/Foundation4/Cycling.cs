public class Cycling : Activity{
    private int _speed;
    

    public Cycling(string date, int activityLength, int speed) : base(date, activityLength)
    {
        _speed = speed;
        _activityLength = activityLength;
    }

    public override double GetDistance()
    {
        int distance = _speed*_activityLength/60;
        return distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double pace = _activityLength/(_speed*_activityLength/60);
        return pace;
    }
}