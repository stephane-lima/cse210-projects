using System;

class Event
{
    public Address _address;
    protected string _eventTitle;
    protected string _destription;
    protected string _date;
    protected string _time;
    protected string _eventType;

    public Event(string eventTitle, string destription, string date, string time, Address address)
    {
        _eventTitle = eventTitle;
        _destription = destription;
        _date = date;
        _time = time;
        _address = address;
        _eventType = "";
    }
    public void DisplayStandardDetails()
    {
        Console.WriteLine($"Standard details:");
        // Console.WriteLine("");
        Console.WriteLine($"Title: '{_eventTitle}'");
        Console.WriteLine($"Description: --{_destription}--");
        Console.WriteLine($"Date: {_date} {_time}");
        _address.DisplayAddress();
    }
    // public string DisplayFullDetails()
    // {
    //     return "";
    // }
    public void DisplayShortDescription()
    {
        Console.WriteLine($"Short description:");
        // Console.WriteLine("");
        Console.WriteLine($"Event: *{_eventType}*");
        Console.WriteLine($"Title: '{_eventTitle}'");
        Console.WriteLine($"Date: {_date}");
    }

}