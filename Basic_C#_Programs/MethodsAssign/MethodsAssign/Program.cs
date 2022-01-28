using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssign
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number to add, subtract, and divide by: ");
            int userValue = Convert.ToInt32(Console.ReadLine());

            var ourNum = new Program();

            // calls the add method
            int resultOne = ourNum.Add(userValue, 2);

            Console.WriteLine("Answer 1: " + resultOne);


            // calls the substract method
            int resultTwo = ourNum.Subtract(userValue, 3);

            Console.WriteLine("Answer 2: " + resultTwo);

            // calls the division method
            int resultThree = ourNum.Divide(userValue, 2);

            Console.WriteLine("Answer 3: " + resultThree);
            Console.ReadLine();

        }

        // all three methods created for different math equations
        public int Add(int data, int value)
        {
            return data + value;
        }

        public int Subtract(int data, int value)
        {
            return data - value;
        }

        public int Divide(int data, int value)
        {
            return data / value;
        }
    }
}
