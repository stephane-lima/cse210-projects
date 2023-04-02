using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(9, "01 Nov 2022", 48);
        Cycling cycling = new Cycling(25, "02 Nov 2022", 40);
        Swimming swimming = new Swimming(30, "03 Nov 2022", 45);

        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        Console.WriteLine("");

        foreach (Activity a in activities)
        {
            a.GetSummary();
        }

        Console.WriteLine("");
    }
}