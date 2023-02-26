using System;

public class BreathingActivity : Activity
{
    public void BreathRepetition()
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);
            Console.WriteLine("Get ready...");
            PausingWithSpinner(5);

            while (DateTime.Now < endTime)
            {
                Console.WriteLine("");
                Console.Write("Breathe in...");
                PausingWithCountdown();
                Console.WriteLine("");
                Console.Write("Now breathe out...");
                PausingWithCountdown();
                Console.WriteLine("");
            }
        }
}