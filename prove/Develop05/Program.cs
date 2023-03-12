using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop05 World!");
        EternalGoal eternal = new EternalGoal();
        Entry entry = new Entry();
        
        string _choice = "0";
        string _option = "0";

        string _name ="";
        
        while (_choice != "6")
        {
            Console.WriteLine("");
            Console.WriteLine($"You have 0 points");
            Console.WriteLine("");

            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Events");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            _choice = Console.ReadLine();

            if (_choice == "1")
            {
                Console.WriteLine("");
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("1. Simple Goals");
                Console.WriteLine("2. Eternal Goals");
                Console.WriteLine("3. Checklist Goals");
                
                Console.Write("Which type of goal would you like to create? ");
                _option = Console.ReadLine();

                if (_option == "1")
                {

                }
                else if (_option == "2")
                {
                    Console.Write("What is the name of your goal? ");
                    _name = Console.ReadLine();
                    eternal.SetName(_name);


                    // Console.Write("What is a short description of it? ");
                    // _description = Console.ReadLine();

                    // Console.Write("What is the amount of points associated with this goal? ");
                    // _points = Console.ReadLine();
                    eternal.AddGoal();
                }
                else if (_option == "3")
                {

                }
            }
            else if (_choice == "2")
            {
                entry.Display();
            }
            else if (_choice == "3")
            {
                entry.Save();
            }
            else if (_choice == "4")
            {
                entry.Load();
            }
            else if (_choice == "5")
            {
                
            }
        
        }


    }
}