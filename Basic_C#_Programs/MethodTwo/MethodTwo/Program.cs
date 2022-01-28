using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // catches if the user inputs two numbers
            try
            {
                Console.WriteLine("Write the first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Write a second number if you want to: ");
                int num2;
                bool num2Result = Int32.TryParse(Console.ReadLine(), out num2);

                var ourNum = new Math();

                int answerOne = ourNum.add(num1, num2);
                Console.WriteLine("Your answer is: " + answerOne);
            }
            // catches if user just enters one number
            catch
            {
                var ourNum = new Math();
                int num1;
                bool num1Result = Int32.TryParse(Console.ReadLine(), out num1);
                int answerOne = ourNum.add(num1, value2: 8);
                Console.WriteLine("Your answer is: " + answerOne);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }

    public class Math
    {
        public int add(int value1, int value2= 4)
        {
            int answer = value1 + value2;
            return answer;
        }
    }
}
