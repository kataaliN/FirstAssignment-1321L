/*
Class: CSE 1321L
Section: 02
Term: Spring 2023
Instructor: Justin McClung
Name: Kataali Nashiru
Assignment#: 1 
*/


using System;

namespace Assignment_1
{
    class Assignment1C
    {
        //this program prints out a given date in various formats
        static void Main(string[] args)
        {
        //This section just asks the user for the necessary information ie month, year etc.
            int Day;
            int MonthInNumbers;
            string MonthInWords;
            int Year;

            Console.WriteLine("Please enter the day: ");
            Day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the month in numbers: ");
            MonthInNumbers = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the month in words: ");
            MonthInWords = Console.ReadLine();

            Console.WriteLine("Please enter the year: ");
            Year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Here are some ways to write out the date: ");
            Console.WriteLine(Day + "/" + MonthInNumbers + "/" + Year);
            Console.WriteLine(Year + "/" + MonthInNumbers + "/" + Day);
            Console.WriteLine(MonthInNumbers + "/" + Day + "/" + Year);
            Console.WriteLine(MonthInWords + " " + Day + ", " + Year);
            Console.WriteLine(Day + " " + MonthInWords + " " + Year);
       
        }
    }
}
