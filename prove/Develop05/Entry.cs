using System;
using System.IO;

public class Entry
{
    public List<string> _entries = new List<string>();
    private string _filename;

    public void Display() 
    {
        //Console.WriteLine("-----------------------------------------------------------------------------------------------");
        Console.WriteLine("The goals are:");
        
        foreach (string entry in _entries)
            {
                Console.WriteLine(entry);
            }
        //Console.WriteLine("-----------------------------------------------------------------------------------------------");
    }

    public void Save() 
    {
        _filename = Console.ReadLine();

        using(StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (string entry in _entries)
            {
                outputFile.WriteLine(entry);
            }
        }
    }
    
    public void Load()
    {
        _filename = Console.ReadLine();  

        string[] lines = System.IO.File.ReadAllLines(_filename);

        _entries.Clear();

        foreach (string line in lines) 
        {
            _entries.Add(line);
        }
    }

}