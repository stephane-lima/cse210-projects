using System;
using System.IO;

public class EternalGoal : Goals
{
    Entry entry = new Entry();
    public string _entry;
    public void AddGoal()
    {
        //GetInfo();

        // _entry = $"Eternal Goal:{_name},{_description},{_points}";
        // _entry = "Eternal Goal";
        entry._entries.Add(_entry);
        Console.WriteLine(_entry);
        // Console.WriteLine($"Name: {_name}");
        // Console.WriteLine($"Description: {_description}");
        // Console.WriteLine($"Points: {_points}");
    }
    // public override bool IsCompleted()
    // {

    // }
    // public override int RecordEvent()
    // {

    // }
}