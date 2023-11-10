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
{ /* This program will ask for grocery items and output total amount to be used for shopping*/
    class Assignment1B
    {
        public static void Main(string[] args)
        {
            /* Will ask user for name and price of item then calculate the total
            for each item and overall total*/

            //The top half will ask for only one item
            string ItemName1;
            float ItemPrice1;
            int ItemQuantity1;
            float PriceTotal1;

            Console.WriteLine("Please enter the name of the item you are buying: ");
            ItemName1= Console.ReadLine();

            Console.WriteLine("How many of this item are you buying? ");
            ItemQuantity1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the price of the item: ");
            Console.Write('$');
            ItemPrice1 = Convert.ToSingle(Console.ReadLine());
            PriceTotal1 = ItemPrice1 * ItemQuantity1;

            Console.WriteLine("Your item total is " + '$' + PriceTotal1);

            //This part asks for the second item.
            string ItemName2;
            float ItemPrice2;
            int ItemQuantity2;
            float PriceTotal2;
            float FinalPrice;

            Console.WriteLine("Please enter the name of the next item you are buying: ");
            ItemName2 = Console.ReadLine();

            Console.WriteLine("How many of this item are you buying? ");
            ItemQuantity2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the price of the item: ");
            Console.Write('$');
            ItemPrice2 = Convert.ToSingle(Console.ReadLine());
            PriceTotal2 = ItemPrice2 * ItemQuantity2;

            Console.WriteLine("Your item total is " + '$' + PriceTotal2);

            //the final list.
            Console.WriteLine("Here is your list: ");
            Console.Write(ItemName1 + " " + "= ");
            Console.WriteLine(ItemQuantity1);

            Console.WriteLine("Price: $" + ItemPrice1);
            Console.WriteLine("Total: $" + PriceTotal1);

            Console.Write(ItemName2 + " " + "= ");
            Console.WriteLine(ItemQuantity2);
            Console.WriteLine("Price: $" + ItemPrice2);
            Console.WriteLine("Total: $" + PriceTotal2);
            
            //final price or total price of all items.
            FinalPrice = PriceTotal1 + PriceTotal2;
            Console.WriteLine("Total cost of items: $" + FinalPrice);
        }
    }
}
