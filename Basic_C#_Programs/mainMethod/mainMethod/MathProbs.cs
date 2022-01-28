using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainMethod
{
    public class MathProbs
    {
        static void Main(string[] args)
        {
            // calculates out first equation/method
            Console.WriteLine("Enter a whole number: ");
            int numOne = Convert.ToInt32(Console.ReadLine());

            var ourNum = new mathEquations();

            int resultOne = ourNum.mathCalc(numOne, 5);
            Console.WriteLine("Answer 1: " + resultOne);

            // calculates out second equation
            Console.WriteLine("Enter a decimal number: ");
            decimal numTwo = Convert.ToDecimal(Console.ReadLine());

            decimal resultTwo = ourNum.mathCalc(numTwo, 2);
            int answerTwo = Convert.ToInt32(resultTwo);
            Console.WriteLine("Answer 2: " + answerTwo);

            // exception handling for invalid number/string
            try
            {
                Console.WriteLine("Enter a number: ");
                string numThree = Console.ReadLine();

                int resultThree = ourNum.mathCalc(numThree, 6);
                int answerThree = Convert.ToInt32(resultThree);
                Console.WriteLine("Answer 3: " + answerThree);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("You entered an invalid number!");
            }
            

            Console.ReadLine();
        }
    }

    public class mathEquations
    {
        // takes in and returns int
        public int mathCalc(int data, int value)
        {
            return data + value;
        }

        // takes in decimal and returns int
        public int mathCalc(decimal data, int value)
        {
            int data1 = Convert.ToInt32(data);
            return data1 + value;
        }

        // takes in string and returns int
        public int mathCalc(string data, int value)
        {
                int data1 = Int32.Parse(data);
                return data1 + value;
        }
    } 
}
