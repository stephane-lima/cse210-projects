using System;

public class PromptGenerator {
    public string _prompt;
    public Random _randomNumber = new Random();
    public List<string> _prompts = new List<string>() {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string GeneratePrompt()
    {
        int index = _randomNumber.Next(0, _prompts.Count);
        _prompt = _prompts[index];
        Console.WriteLine(_prompt);
        return _prompt;
    }
}