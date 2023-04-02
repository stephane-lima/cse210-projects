using System;

class Lecture : Event
{
    private string _speakerName;
    private int _capacity;//available seats

    public Lecture(string speakerName, int capacity, string eventTitle, string destription, string date, string time, Address address) : base(eventTitle, destription, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
        _eventType = "Lecture";
    }
    public void LectureFullDetails()
    {
        Console.WriteLine($"Full details:");
        Console.WriteLine($"Event: *{_eventType}*");
        Console.WriteLine($"Title: '{_eventTitle}'");
        Console.WriteLine($"Speaker: {_speakerName}");
        Console.WriteLine($"Description: --{_destription}--");
        Console.WriteLine($"Available seats: {_capacity}");
        Console.WriteLine($"Date: {_date} {_time}");
        _address.DisplayAddress();
    }
}