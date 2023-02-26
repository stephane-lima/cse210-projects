using System;

public class ReflectionActivity : Activity
{
    Random _randomPrompt = new Random();
    Random _randomQuestion = new Random();
    private int _index = 0;
    private string _prompt = "";
    private string _question = "";
    private List<string> _prompts = new List<string>() {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    private List<string> _questions = new List<string>() {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public string GetRandomPrompt() 
    {
        _index = _randomPrompt.Next(0, _prompts.Count);
        _prompt = _prompts[_index];
        return _prompt;
    }

    public void DisplayPrompt()
    {
        _prompt = GetRandomPrompt();
        Console.WriteLine("");
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"--- {_prompt} ---");
        Console.WriteLine("");

    }

    public string GetRandomQuestion() 
    {
        _index = _randomQuestion.Next(0, _questions.Count);
        _question = _questions[_index];
        return _question;
    }

    public void DisplayQuestion()
    {
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            GetRandomQuestion();
            Console.Write("> ");
            Console.Write($"{_question} ");
            PausingWithSpinner(15);
            Console.WriteLine("");
        }
    }
}