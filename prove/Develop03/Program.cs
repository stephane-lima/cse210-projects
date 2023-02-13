using System;
//This program displays a scripture and through a loop, while the userInput == ""(enter), the program will
//hide each word of the scripture. When all words are hidden or if the userInput == "quit", the program will end.

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Proverbs", "3", "5", "6");
        Scripture scripture1 = new Scripture("Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy was acknowledge him, and he shall direct thy paths.", reference1);
        //Each word of the scripture in a list.
        scripture1.WordList();
        string _userInput;
        
        do{
            //Display the scripture.
            scripture1.Display();
            Console.Write("\n\nPress enter to hide a word or type 'quit' to exit: ");
            _userInput = Console.ReadLine();
            //Hide each word of the scripture.
            scripture1.HideWords();
            Console.Clear();   
            //If all words are hidden, finish the program.
            if(scripture1.EverythingIsHidden() == false)
            {  
                scripture1.Display();
                break;
            }
        //Execute these commands while the _userInput is not equal "quit".
        }while(_userInput != "quit");
    }
}