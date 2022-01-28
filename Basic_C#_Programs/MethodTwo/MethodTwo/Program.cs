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
            // asks user to enter one or two numbers
                var ourNum = new Math(); 
                Console.WriteLine("Write the first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Write a second number if you want to: ");
                string num2 = (Console.ReadLine());

            // if the user doesn't enter the second number, it automatically adds value 2
                if (string.IsNullOrEmpty(num2))
                {
                    int answerOne = ourNum.add(num1);
                    Console.WriteLine("Your answer is: " + answerOne);
                }
                // if they do enter the second number, this converts it to int and then does the equation with the two equaled numbers
                else
                {
                    int num2Final = Convert.ToInt32(num2);
                    int answerTwo = ourNum.add(num1, num2Final);
                    Console.WriteLine("Your answer is: " + answerTwo);
                }
            Console.ReadLine();
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
