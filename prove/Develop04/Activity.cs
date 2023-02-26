using System;

public class Activity 
{
    protected string _activityName = "";
    protected string _description = "";
    protected int _duration;
    protected string _time = "";
    protected int _seconds;

    protected List<string> animationStrings = new List<string>() {"|", "/", "-", "\\", "|", "/", "-", "\\"};

    public string GetActivityName()
    {
        return _activityName;
    }

    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    
    public void DisplayStartingMessage(string activityName, string description)
        {
            Console.WriteLine($"Welcome to the {activityName}.");
            Console.WriteLine("");
            Console.WriteLine(description);
            Console.WriteLine("");
            Console.Write("How long, in seconds, would like for your sessions? ");
        }

    public void DisplayEndingMessage(int duration, string activityName)
    {
        Console.WriteLine("");
        Console.WriteLine("Well done!");
        PausingWithSpinner(5);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {duration} seconds of the {activityName}");
        PausingWithSpinner(5);
    }

    public void PausingWithCountdown()
    {
        for (int i = 5; i > 0 ; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void PausingWithSpinner(double seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
}