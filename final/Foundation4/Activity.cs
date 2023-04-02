using System;

class Activity
{
    protected string _date;
    protected int _minutes;//in minutes
    protected string _activityType;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public virtual double GetDistance()
    {
        return 1;
    }

    public virtual double GetSpeed()
    {
        return 1;
    }

    public virtual double GetPace()
    {
        return 1;
    }

    public void GetSummary()
    {
        double _distance = GetDistance();
        double _speed = GetSpeed();
        double _pace = GetPace();
        Console.WriteLine($"{_date} {_activityType} ({_minutes} min)- Distance: {_distance.ToString("N2")} km, Speed: {_speed.ToString("N2")} kph, Pace: {_pace.ToString("N2")} min per km");
    }

}