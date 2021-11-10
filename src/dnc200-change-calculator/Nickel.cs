/**
 * File name: Nickel.cs
 * Author: Kenneth Lapid David
 *
 * This file contains the Dime class, which defines Dime objects
 */

 using System;
 using System.Linq;

 namespace dnc200_change_calculator
 {
     public class Nickel : IMoney
     {
         public int value; // The value that this money will hold
         public int count; // How much of this money do you have

        /**
         * This constructor will construct a Nickel object and set it's value to be 5
         *
         */
         public Nickel() {
             this.value = 5;
             this.count = 0;
         }

        /**
         * This method will calculate how much money can be returned 
         * given the value and an amount
         *
         * @return The amount of money we can make with the given amount
         */
        public int Calculate(int amount) {
            this.count = amount / this.value;
            return amount % this.value;
        }

         /**
         * This method will return a message to the console displaying how much denomination was used
         *
         */
        public void Print() {
            if(this.count == 1) {
                Console.WriteLine("1 Nickel");
            } else {
                Console.WriteLine(this.count + " Nickels");
            }
        }

     }
 }