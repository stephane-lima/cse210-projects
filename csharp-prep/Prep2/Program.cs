using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage? ");
        string grade = Console.ReadLine();
        int gradeInt = int.Parse(grade);
        string letter = "";
        string sign = "";

        if (gradeInt >= 90 && gradeInt <= 100)
        {
            letter = "A";
        }
        else if (gradeInt >= 80 && gradeInt < 90)
        {
            letter = "B";
        }
        else if (gradeInt >= 70 && gradeInt < 80)
        {
            letter = "C";
        }
        else if (gradeInt >= 60 && gradeInt <70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        
        if (gradeInt % 10 >= 7)
        {
            if (letter == "A" || letter == "F")
            {
                sign = "";
            }
            else
            {
                sign = "+";
            }
        }
        else if (gradeInt % 10 <= 3)
        {
            if (letter == "F")
            {
                sign = "";
            }
            else
            {
                sign = "-";
            }
        }
        else 
        {
            sign = "";
        }
        
        Console.WriteLine($"Your grade letter is {letter}{sign}");
        
        if (gradeInt >= 70 && gradeInt <= 100)
        {
            Console.WriteLine("You passed the class");
        }
        else if (gradeInt < 70)
        {
            Console.WriteLine("You failed the Class");
        }
    }
}