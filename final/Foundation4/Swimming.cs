using System;

class Swimming : Activity
{
    private float _lapNumber;

    public Swimming(float lapN, string date, int length) : base(date, length)
    {
        _lapNumber = lapN;
        _activityType = "Swimming";
    }
    public override double GetDistance()
    {
        // double distance = _lapNumber * 50 / 1000;
        return _lapNumber * 50 / 1000;
    }
    public override double GetPace()
    {
        return _minutes / GetDistance();
    }
    public override double GetSpeed()
    {
        return 60 / GetPace();
    }
}