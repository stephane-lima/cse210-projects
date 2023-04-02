using System;

class Cycling : Activity
{
    private double _speed;

    public Cycling(double speed, string date, int length) : base(date, length)
    {
        _speed = speed;
        _activityType = "Cycling";
    }

    public override double GetDistance()
    {
        return (_speed / 60) * _minutes;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
}