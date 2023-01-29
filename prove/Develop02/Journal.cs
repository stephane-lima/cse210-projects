using System;
using System.IO;

public class Journal {

    Entry entry = new Entry();

    public string _userInput;
    public string _entry;
    public string _prompt1;
    public DateTime _theCurrentTime;
    public string _dateText;
    public string _entry2;

    public void AddEntry() 
    {
        _theCurrentTime = DateTime.Now;
        _dateText = _theCurrentTime.ToShortDateString();

        PromptGenerator prompt = new PromptGenerator();

        _prompt1 = prompt.GeneratePrompt();
        
        Console.Write("> ");
        _userInput = Console.ReadLine();

        _entry = $"Date: {_dateText} - Prompt: {_prompt1}";
        _entry2 = $"{_userInput}";
        
        entry._entries.Add(_entry);
        entry._entries.Add(_entry2);
    }
    public void DisplayEntries() 
    {
        entry.Display();
    }

    public void SaveToFile()
    {
        Console.WriteLine("Enter the name of the file.");
        Console.Write("> ");

        entry.Save();
    }

    public void LoadFromFile() 
    {
        Console.WriteLine("Enter the name of the file.");
        Console.Write("> ");

        entry.Load();
    }

    public void SearchEntry()
    {
        Console.WriteLine("Enter date as dd-mm-yyyy: ");
        Console.Write(">");

        entry.Search();
    }
}