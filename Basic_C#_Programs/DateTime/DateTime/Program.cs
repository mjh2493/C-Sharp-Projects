using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTime2
{
    class Program
    {
        static void Main(string[] args)
        {
            // assigns current date and time to variable
            DateTime timeOne = DateTime.Now;

            // prints current time to console
            Console.WriteLine(timeOne);

            // gets user input
            Console.WriteLine("Please type a number between 1-12: ");
            int userNum = Convert.ToInt32(Console.ReadLine());


            // adds user input to current date and time
            DateTime timeTwo = timeOne.AddHours(userNum);

            // prints updated datetime
            Console.WriteLine("The updated time is: {0}", timeTwo);

            Console.ReadLine();
        }
    }
}
