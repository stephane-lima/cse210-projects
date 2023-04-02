using System;

class Reception : Event
{
    private string _emailRSVP;

    public Reception(string emailRSVP, string eventTitle, string destription, string date, string time, Address address) : base(eventTitle, destription, date, time, address)
    {
        _emailRSVP = emailRSVP;
        _eventType = "Reception";
    }
    public void ReceptionFullDetails()
    {
        Console.WriteLine($"Full details:");
        Console.WriteLine($"Event: {_eventType} ");
        Console.WriteLine($"Title: {_eventTitle}");
        Console.WriteLine($"Description: {_destription}");
        Console.WriteLine($"Date: {_date} {_time}");
        _address.DisplayAddress();
        Console.WriteLine($"Please RSVP: {_emailRSVP}");
    }
}