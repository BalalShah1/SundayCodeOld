using System;

namespace ConsoleApp8
{
   public class Program
    {
        static void Main(string[] args)
        {
            /* 
             * How many years in the 20th century
             * How many leap years during that time period
             * How many Sundays occur during that time
             */

            var normalYear = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };   // Declaring an int array with the number of days in every month
            var sundayCount = 0;    // Declaring a Sunday count int variable
            var weeks = 1;          // Declaring a weeks int variable initialized to 1

            for (int currentYear = 1901; currentYear <= 2000; currentYear++)
            {
                // Working out if a year is a leap year by checking if it is divisible by 4 and not divisible by 100 and checking to see if the year is divisible by 400
                if (currentYear % 4 == 0)
                {
                    normalYear[1] = 29;      // This is a leap year
                }
                else if (currentYear % 400 == 0)
                {
                    normalYear[1] = 29;      // This is a leap year
                }
                else
                {
                    normalYear[1] = 28;      // Non-leap year
                }

                foreach (int day in normalYear)       // Logic to check if the 1st day of the month is a Sunday
                {
                    weeks = (weeks + day) % 7; // Update the count of days in weeks, and use modulo 7 to keep the value within the range [0, 6]
                    if (weeks == 0 && currentYear > 1901 && currentYear <= 2000)
                    {
                        sundayCount++;  // Increment the Sunday count
                    }
                }
            }
            Console.WriteLine(sundayCount);    // Displaying the amount of Sundays
        }
    }
}
