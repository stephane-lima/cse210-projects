using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();
        BreathingActivity breathing = new BreathingActivity();
        ReflectionActivity reflection = new ReflectionActivity();
        ListingActivity listing = new ListingActivity();
        string _choice = "0";
        string _time = "";
        int _seconds = 0;

        while (_choice != "4") 
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            _choice = Console.ReadLine();

            if (_choice == "1") 
            {
                Console.Clear();
                activity.DisplayStartingMessage("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                _time = Console.ReadLine();
                _seconds = int.Parse(_time);
                breathing.SetDuration(_seconds);

                Console.Clear();
                breathing.BreathRepetition();

                activity.DisplayEndingMessage(breathing.GetDuration(), "Breathing Activity");
            }
            else if (_choice == "2")
            {
                Console.Clear();
                activity.DisplayStartingMessage("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                _time = Console.ReadLine();
                _seconds = int.Parse(_time);
                reflection.SetDuration(_seconds);

                Console.Clear();
                Console.WriteLine("Get ready...");
                activity.PausingWithSpinner(5);

                reflection.DisplayPrompt();

                Console.WriteLine("When you have something in my mind, press enter to continue.");
                Console.ReadLine();

                Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
                Console.Write($"You may begin in: ");
                activity.PausingWithCountdown();
                Console.Clear();

                reflection.DisplayQuestion();

                activity.DisplayEndingMessage(reflection.GetDuration(), "Reflection Activity");
            }
            else if (_choice == "3")
            {
                Console.Clear();
                activity.DisplayStartingMessage("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                _time = Console.ReadLine();
                _seconds = int.Parse(_time);
                listing.SetDuration(_seconds);

                Console.Clear();
                Console.WriteLine("Get ready...");
                activity.PausingWithSpinner(5);

                listing.DisplayPromptListing();

                Console.WriteLine("");
                Console.Write($"You may begin in: ");
                activity.PausingWithCountdown();

                Console.WriteLine("");
                listing.GetUserInput();

                activity.DisplayEndingMessage(listing.GetDuration(), "Listing Activity");
            }
        }
    }
}