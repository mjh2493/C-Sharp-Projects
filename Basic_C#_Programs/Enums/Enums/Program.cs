using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            // trys to find the day of the week in the enum list 
            try
            {
                Console.WriteLine("Please enter a day of the week: ");
                string day = Console.ReadLine();

                DaysOfTheWeek newDay = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), day);

                // loop to see if day of the week is in the enum
                foreach (DaysOfTheWeek days in Enum.GetValues(typeof(DaysOfTheWeek)))
                {
                    if (newDay == days)
                    {
                        Console.WriteLine("You wrote: " + newDay);
                    }
                }
            }
            catch // prints error if day of week is entered incorrectly
            {
                Console.WriteLine("You did not write a valid day of the week!");
            }
            finally
            {
                Console.ReadLine();
            }
        }
        // list of enums
        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
