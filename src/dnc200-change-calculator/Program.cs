/**
 * File Name: Program.cs
 * Author: Kenneth Lapid David
 *
 * This file contains the program class which will define a program that expects input in the form
 * of sale amount and tender, and will output the required change.
 */
using System;
using System.Linq;

namespace dnc200_change_calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            double totSale; 
            double tender;
            double required;
            double coinPart;
            int dollarAmount;
            int coinAmount;
            Dollar dollars = new Dollar();
            Quarter quarters = new Quarter();
            Dime dimes = new Dime();
            Nickel nickels = new Nickel();
            Penny pennies = new Penny();

            // Prompt user for sale amount and tender
            Console.WriteLine("Welcome to the Change Calculator!");
            Console.WriteLine("Enter the total amount of the sale: \r\n");
            totSale = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter amount tendered by customer: \r\n");
            tender = Convert.ToDouble(Console.ReadLine());
            // Make sure tender > totSale
            while(tender < totSale) {
                required = totSale - tender;
                Console.WriteLine("Customer still owes " + required + " dollars. Please enter more money: \r\n");
                totSale = required;
                tender = Convert.ToDouble(Console.ReadLine());
            }

            dollarAmount = (int)Math.Floor(tender - totSale); // Get the dollar amount
            coinPart = Math.Round(tender - totSale, 2);
            coinAmount = (int)(Math.Round(coinPart - Math.Floor(coinPart),2) * 100); // Get the coin amount

            // Now calculate the denominations needed
            dollars.Calculate(dollarAmount);
            coinAmount = quarters.Calculate(coinAmount);
            coinAmount = dimes.Calculate(coinAmount);
            coinAmount = nickels.Calculate(coinAmount);
            coinAmount = pennies.Calculate(coinAmount);

            // Output the denominations used!
            Console.WriteLine("\nHere's the denominations used: \r\n");
            dollars.Print();
            quarters.Print();
            dimes.Print();
            nickels.Print();
            pennies.Print();
            Console.WriteLine();


        }
    }
}
