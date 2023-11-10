/*
Class: CSE 1321L
Section: 02
Term: Spring 2023
Instructor: Justin McClung
Name: Kataali Nashiru
Assignment#: 1 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Assignment1A
    {
        static void Main(string[] args)
        {
            //starting variables
            int UserInput1;
            int UserInput2;
            int UserInput3;

            //taking in primary user input
            Console.WriteLine("Please enter your red value(0-255): ");
            UserInput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your green value(0-255): ");
            UserInput2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your blue value(0-255): ");
            UserInput3 = Convert.ToInt32(Console.ReadLine());

            //inversion of colors happens here
            int InvertedValue1 = 255 - UserInput1;
            int InvertedValue2 = 255 - UserInput2;
            int InvertedValue3 = 255 - UserInput3;

            //displaying results
            Console.WriteLine("Your inverted values are:");
            Console.WriteLine("Red: " + InvertedValue1);
            Console.WriteLine("Green: " + InvertedValue2);
            Console.WriteLine("Blue: " + InvertedValue3);

            //changing the results from above into decimals
            float finalValue1 = InvertedValue1 / 255f;
            float finalValue2 = InvertedValue2 / 255f;
            float finalValue3 = InvertedValue3 / 255f;

            //the final display
            Console.WriteLine("With floating point: ");
            Console.WriteLine("Your red value is " + finalValue1);
            Console.WriteLine("Your green value is " + finalValue2);
            Console.WriteLine("Your blue value is " + finalValue3);
        }
    }
}
