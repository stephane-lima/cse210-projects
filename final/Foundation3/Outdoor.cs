using System;

class Outdoor : Event
{
    private string _weather;

    public Outdoor(string weather, string eventTitle, string destription, string date, string time, Address address) : base(eventTitle, destription, date, time, address)
    {
        _weather = weather;
        _eventType = "Outdoor";
    }
    public void OutdoorFullDetails()
    {
        Console.WriteLine($"Full details:");
        Console.WriteLine($"Event: *{_eventType}*");
        Console.WriteLine($"Title:'{_eventTitle}'");
        Console.WriteLine($"Description: --{_destription}--");
        Console.WriteLine($"Weather: {_weather}");
        Console.WriteLine($"Date: {_date} {_time}");
        _address.DisplayAddress();
    }
}