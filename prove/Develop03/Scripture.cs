using System;
using System.Collections.Generic;

class Scripture
{
    static void Main(string[] args)
    {
    // Console.WriteLine("Hello Develop03 World!");
    Reference reference = new Reference();
    Random _randomWord = new Random();
    string _userInput;
    string _renderedText = "";
    string _verseContent= reference.GetVerseContent();
    string[] _words = _verseContent.Split(" ");
    string[] _randomList = _verseContent.Split(" ");
    // string _text;
    // string _renderedWord = "";

    // Reference reference = new Reference();
    
    Console.Write(reference.GenerateReference());
    // Console.WriteLine(reference.GetVerseContent());
    Console.WriteLine(_verseContent);
    Console.WriteLine();
    Console.WriteLine("Press enter to continue or type 'quit' to finish:");
    _userInput = Console.ReadLine();


    while(_userInput != "quit")
    {
        Console.Clear();
        
        HideWords();

        Console.Write(reference.GenerateReference());
        Console.WriteLine(_renderedText);
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        _userInput = Console.ReadLine();

        _renderedText = "";
        // _renderedWord = "";

    }
    string HideWords()
    {
        // for (int k = 0; k < 3; k++) {
        int index = _randomWord.Next(0, _words.Length);
        string _prompt = _words[index];
        Console.WriteLine(_prompt);
        
        for(int i = 0; i < _words.Length; i++) 
        {   
            if(_words[i] == _prompt && _randomList[index] == _words[index]) 
            {
                // for(int k = 0; k < words[i].Length; k++) 
                foreach(char letter in _words[i]) 
                {
                    // if(letter.ToString() == "_ ") {
                    //     continue;
                    // }
                    // else{
                        // _renderedWord += "_ ";
                        // _words[i] = _renderedWord;
                    _words[i] = _words[i].Replace(letter.ToString(), "_ ");
                }
            }
            _renderedText += $" {_words[i]}";
        }       
        return _renderedText; 
    }
        //_renderedText += $" {_words[i]}";
        
        // int index = _randomWord.Next(0, _words.Length);
        // string _prompt = _words[index];
        // Console.WriteLine(_prompt);
        
        // for(int i = 0; i < _words.Length; i++) 
        //     {
        //         if(_words[i] == _prompt && _randomList[index] == _words[index]) 
        //         {
        //             // for(int k = 0; k < words[i].Length; k++) 
        //             foreach(char letter in _words[i]) 
        //             {
        //                 // if(letter.ToString() == "_ ") {
        //                 //     continue;
        //                 // }
        //                 // else{
        //                     // _renderedWord += "_ ";
        //                     // _words[i] = _renderedWord;
        //                     _words[i] = _words[i].Replace(letter.ToString(), "_ ");
        //                 // }
        //             }
        //         }
        //         _renderedText += $" {_words[i]}";

    // public string GetRenderedText()
    // {

    // }

    // public bool IsCompletelyHidden()
    // {

    // }
    }
}