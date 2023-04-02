using System;

class Running : Activity
{
    private double _distance;

    public Running(double distance, string date, int length) : base(date, length)
    {
        _distance = distance;
        _activityType = "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        // double speed = (_distance / _minutes) * 60;
        return (_distance / _minutes) * 60;
    }
    public override double GetPace()
    {
        return _minutes / _distance;
    }
}