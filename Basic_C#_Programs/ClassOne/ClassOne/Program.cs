using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOne
{
    static class Program
    {
        static void Main(string[] args)
        {

            Math math = new Math();

            double num1;

            math.getValues(out num1);

            Console.WriteLine("Your number divided by two is: " + num1);
            Console.ReadLine();
        }
    }
    class Math
    {
        public void getValues(out int value)
        {
            Console.WriteLine("Please enter a whole number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            value = num1 / 2;
        }
        public void getValues(out double value)
        {
            Console.WriteLine("Please enter a decimal: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            int num2 = Convert.ToInt32(num1);
            int answer = num2 / 2;
            double finalAnswer = Convert.ToDouble(answer);
            value = finalAnswer;
        }
    }
}
