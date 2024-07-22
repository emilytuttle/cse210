public class Swimming : Activity{
    private int _lapNumber;
    

    public Swimming(string date, int activityLength, int lapNumber) : base(date, activityLength)
    {
        _lapNumber = lapNumber;
        _activityLength = activityLength;
    }

    public override double GetDistance()
    {
        double distance = _lapNumber * 50 / 1000 * 0.62;
        return distance;
    }

    public override double GetSpeed()
    {
        int speed = 60*_lapNumber * 50 / 1000/_activityLength;
        return speed;
    }

    public override double GetPace()
    {
        double pace = _activityLength / (_lapNumber * 50 / 1000 * 0.62);
        return pace;
    }
}