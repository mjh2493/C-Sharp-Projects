using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOne
{
    // defined class as static
    static class Program
    {
        static void Main(string[] args)
        {

            Math math = new Math();

            double num1;

            // calls on the function to get the output 
            math.getValues(out num1);

            // prints the answer to the equation
            Console.WriteLine("Your number divided by two is: " + num1);
            Console.ReadLine();
        }
    }
    class Math
    {
        // function that divides integers and gives back an int
        public void getValues(out int value)
        {
            Console.WriteLine("Please enter a whole number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            value = num1 / 2;
        }
        // method that divides double and gives back a double
        public void getValues(out double value)
        {
            Console.WriteLine("Please enter a decimal: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double answer = num1 / 2;
            value = answer;
        }
    }
}
