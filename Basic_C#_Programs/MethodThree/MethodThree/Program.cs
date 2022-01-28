using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodThree
{
    class Program
    {
        static void Main(string[] args)
        {
            // calling the functions and getting the parameters from the user
            Math math = new Math();

            Console.WriteLine("Please enter your first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            math.add(num1, num2);
            Console.ReadLine();
        }
    }

    public class Math
    {
        // method using the void method, does an equation on the first value and displays the second
        public void add(int value1, int value2)
        {
            int answer = value1 + 10;
            Console.WriteLine("Your first number + 10= " + answer + " and the second number you entered is: " + value2);
        }
    }
}
