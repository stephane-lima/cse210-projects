using System;
using System.IO;

public class Goals
{
    protected string _name;
    protected string _description;
    protected string _points;
    // protected string _entry;

    // protected Entry entry = new Entry();

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetPoints()
    {
        return _points;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetPoints(string points)
    {
        _points = points;
    }

    // public void GetInfo()
    // {
    //     Console.Write("What is the name of your goal? ");
    //     _name = Console.ReadLine();

    //     Console.Write("What is a short description of it? ");
    //     _description = Console.ReadLine();

    //     Console.Write("What is the amount of points associated with this goal? ");
    //     _points = Console.ReadLine();
    // }
    //public void AddGoal();

    // public void DisplayEntries() 
    // {
    //     entry.Display();
    // }
    
    //public abstract bool IsCompleted();

    //public abstract int RecordEvent();
}