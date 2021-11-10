/**
 * File Name: IMoney.cs
 * Author: Kenneth Lapid David
 *
 * This file contains the Money Interface which lays out the necessary properties
 * that Money should have.
 */

using System;
 
namespace dnc200_change_calculator
{
    public interface IMoney
    {
        /**
         * This method will calculate how much money can be returned 
         * given the value and an amount
         *
         * @return The remaining amount;
         */
        int Calculate(int amount);

        /**
         * This method will return a message to the console displaying how much denomination was used
         *
         */
        void Print();
    }
}