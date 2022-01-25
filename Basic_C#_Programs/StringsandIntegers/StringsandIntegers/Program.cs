using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsandIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            // made my list and the empty list that the results move to once divided
            List<int> numbers = new List<int>() { 2, 4, 6, 8, 10, 12, 24, 48 };
            List<int> newNum = new List<int>();

            try
            {
                Console.WriteLine("Pick a whole number to divide each number in our list by: ");
                int divider = Convert.ToInt32(Console.ReadLine());

                // loop to divide all numbers in list1 and move to empty list
                foreach (int num in numbers)
                {
                    newNum.Add(num / divider);
                }

                // for loop to print the new numbers to the screen
                foreach (int num1 in newNum)
                {
                    Console.WriteLine(num1);
                }
            }
            catch (FormatException ex) // catches if user does not enter a numer    
            {
                Console.WriteLine("You did not enter a number.");
            }
            catch (DivideByZeroException ex) // catches if user tries to divide by zero
            {
                Console.WriteLine("You entered zero. This is not possible.");
            }
            catch (Exception ex) // catches all other exceptions
            {
                Console.WriteLine(ex.Message);
            }
            finally // makes sure the readline command is seen regardless of previous code
            {
                Console.ReadLine();
            }
            
        }
    }
}
