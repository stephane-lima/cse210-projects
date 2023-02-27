using System;

public class ListingActivity : Activity
{
    Random _randomPromptListing = new Random();
    private int _index = 0;
    private string _promptListing = "";
    private List<string> _promptsListing = new List<string>() {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private int _counter;
    
    public string RandomPromptListing ()
    {
        _index = _randomPromptListing.Next(0, _promptsListing.Count);
        _promptListing = _promptsListing[_index];
        return _promptListing;
    }

    public void DisplayPromptListing()
    {
        Console.WriteLine("");
        _promptListing = RandomPromptListing();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"--- {_promptListing} ---");
    }

    public void GetUserInput()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        Console.WriteLine("");
        _counter = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            Console.ReadLine();
            _counter++;
        }

        Console.WriteLine("");
        Console.WriteLine($"You listed {_counter} items");
    }
}
