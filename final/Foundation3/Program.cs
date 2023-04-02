using System;

class Program
{
    static void Main(string[] args)
    {

        Address addressLecture = new Address("Provo Event Center: 123 N 100 E", "Provo", "UT", "USA");
        Lecture lecture = new Lecture("Dr. Expert", 50, "Help chilren build emotional skills", "Children can become more successful when they understand their feeling...Let's talk about why and how", "02 Apr 2023", "17:30 P.M", addressLecture);
        lecture.DisplayStandardDetails();
        Console.WriteLine("");
        lecture.LectureFullDetails();
        Console.WriteLine("");
        lecture.DisplayShortDescription();

        Console.WriteLine("");
        Console.WriteLine($"-------------------------------------------------------------------------------");
        Address addressReception = new Address("2200 Temple Hill Dr", "Provo", "UT", "USA");
        Reception reception = new Reception("awesomecouple@gmail.com", "Rachel and Justin", "Please join us to celebrate the love and marriage of Rachel and Justin", "02 May 2023", "18:30 P.M", addressReception);
        reception.DisplayStandardDetails();
        Console.WriteLine("");
        reception.ReceptionFullDetails();
        Console.WriteLine("");
        reception.DisplayShortDescription();

        Console.WriteLine("");
        Console.WriteLine($"--------------------------------------------------------------------------------");
        Address addressOutdoor = new Address("350 N 100 E", "Provo", "UT", "USA");
        Outdoor outdoor = new Outdoor("50°F", "Easter Egg Hunt", "This event is FREE! Bring your kids for the fun game. With over 3,000 eggs to find, nobody will leave empty handed!", "08 Apr 2023", "10:30 A.M", addressOutdoor);
        outdoor.DisplayStandardDetails();
        Console.WriteLine("");
        outdoor.OutdoorFullDetails();
        Console.WriteLine("");
        outdoor.DisplayShortDescription();

    }
}